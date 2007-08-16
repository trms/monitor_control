using System;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.Collections;
using System.Threading;
using System.Diagnostics;

namespace TRMS.CarouselMonitorControl
{
    /// <summary>
    /// Summary description for Video.
    /// </summary>
    public class WindowsPowerManagement
    {
        static int WM_SYSCOMMAND = 0x0112;
        static int SC_MONITORPOWER = 0xF170;

        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

        public static void PowerOff(Int32 handle)
        {
            try
            {
                SendMessage(handle, WM_SYSCOMMAND, SC_MONITORPOWER, 2);
                EventLog.WriteEntry("Carousel Monitor Control", "The monitor has been powered off.", EventLogEntryType.Information);
            }
            catch(Exception e)
            {
                EventLog.WriteEntry("Carousel Monitor Control", "Error powering monitor off, " + e.Message, EventLogEntryType.Error);
            }
        }

        public static void PowerOn(Int32 handle)
        {
            try
            {
                SendMessage(handle, WM_SYSCOMMAND, SC_MONITORPOWER, -1);
                EventLog.WriteEntry("Carousel Monitor Control", "The monitor has been powered on.", EventLogEntryType.Information);
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("Carousel Monitor Control", "Error powering monitor on, " + e.Message, EventLogEntryType.Error);
            }
        }

    }

    public class SerialPowerManagement
    {

        public static void PowerOff()
        {
            try
            {
                SendData(new Properties.Settings().PowerOffString);
                EventLog.WriteEntry("Carousel Monitor Control", "The monitor has been powered off.", EventLogEntryType.Information);
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("Carousel Monitor Control", "Error powering monitor off, " + e.Message, EventLogEntryType.Error);
            }
        }

        public static void PowerOn()
        {
            try
            {
                SendData(new Properties.Settings().PowerOnString);
                EventLog.WriteEntry("Carousel Monitor Control", "The monitor has been powered on.", EventLogEntryType.Information);
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("Carousel Monitor Control", "Error powering monitor on, " + e.Message, EventLogEntryType.Error);
            }
        }

        public static ArrayList GetSerialPorts()
        {
            ArrayList AvaliablePorts = new ArrayList();

            try
            {
                SerialPort Serial = new SerialPort();


                for (int i = 1; i <= 256; i++)
                {
                    try
                    {
                        Serial.PortName = "COM" + i;
                        Serial.Open();
                        AvaliablePorts.Add("COM" + i);
                    }
                    catch { }
                    finally
                    {
                        Serial.Close();
                    }
                }
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("Carousel Monitor Control", "Error enumering avaliable COM ports, " + e.Message, EventLogEntryType.Error);
            }

            return AvaliablePorts;

        }

        private static void SendData(string Data)
        {
            Properties.Settings settings = new Properties.Settings();
            SerialPort Serial = new SerialPort();

            Serial.PortName = settings.Port;
            Serial.BaudRate = Convert.ToInt32(settings.Baud);
            Serial.DataBits = Convert.ToInt32(settings.Databits);
            switch (settings.Stopbits)
            {
                case "1":
                    Serial.StopBits = StopBits.One;
                    break;
                case "1.5":
                    Serial.StopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    Serial.StopBits = StopBits.Two;
                    break;
            }
            switch (settings.Parity)
            {
                case "None":
                    Serial.Parity = Parity.None;
                    break;
                case "Even":
                    Serial.Parity = Parity.Even;
                    break;
                case "Odd":
                    Serial.Parity = Parity.Odd;
                    break;
            }

            Serial.Open();

            foreach (string DataPart in Data.Split(','))
            {
                int arraysize = DataPart.Length / 2;
                byte[] x = new byte[arraysize];

                for (int i = 0; i < arraysize; i++)
                {
                    x[i] = byte.Parse(DataPart.Substring(i * 2, 1), System.Globalization.NumberStyles.HexNumber);
                }

                Serial.Write(x, 0, x.Length);

                Thread.Sleep(500);
            }

            Serial.Close();
        }
    }

    public class ScheduleThread
    {
        public static void RunSchedule()
        {
            ScheduleHelper Schedule = new ScheduleHelper();
            ScheduleHelper.PowerEvent Event;

            while (true)
            {
                try
                {
                    Event = Schedule.GetNextEvent();

                    while (true)
                    {
                        if (Event.EventTime < DateTime.Now)
                        {
                            if (Event.EventType == ScheduleHelper.PowerEventType.PowerOn)
                                Schedule.PowerOn();
                            else if (Event.EventType == ScheduleHelper.PowerEventType.PowerOff)
                                Schedule.PowerOff();

                            break;
                        }

                        if (TRMS.CarouselMonitorControl.ScheduleHelper.ScheduleChanged)
                            break;

                        Thread.Sleep(5000);
                    }

                }
                catch (Exception e)
                {
                    EventLog.WriteEntry("Carousel Monitor Control", "Error running the schedule, " + e.Message, EventLogEntryType.Error);
                }
            }
        }
    }

    public class ScheduleHelper
    {
        private Properties.Settings settings = new Properties.Settings();
        public static bool ScheduleChanged = false;
       
        public struct PowerEvent
        {
            public DateTime EventTime;
            public PowerEventType EventType;
        }

        public enum PowerEventType
        {
            NoAction,
            PowerOn,
            PowerOff
        }

        public PowerEvent GetNextEvent()
        {
            //Working variables
            ArrayList EventList = new ArrayList();
            PowerEvent OnEvent1 = new PowerEvent();
            PowerEvent OffEvent1 = new PowerEvent();
            PowerEvent OnEvent2 = new PowerEvent();
            PowerEvent OffEvent2 = new PowerEvent();
            bool OffEventOffset1 = false;
            bool OffEventOffset2 = false;

            //Set the current weekday
            EditSchedule.WeekDays CurrentDay = GetScheduleDay(DateTime.Now);
            EditSchedule.WeekDays YesterDay = GetScheduleDay(DateTime.Now.AddDays(-1));

            //Reload the settings
            settings.Reload();

            //Get the adjusted time of each event
            OnEvent1.EventTime = DateTime.Parse(settings.PowerOn1);
            OnEvent1.EventType = PowerEventType.PowerOn;
            OffEvent1.EventTime = DateTime.Parse(settings.PowerOff1);
            OffEvent1.EventType = PowerEventType.PowerOff;
            if (OffEvent1.EventTime < OnEvent1.EventTime)
            {
                OffEvent1.EventTime = OffEvent1.EventTime.AddDays(1);
                OffEventOffset1 = true;
            }

            OnEvent2.EventTime = DateTime.Parse(settings.PowerOn2);
            OnEvent2.EventType = PowerEventType.PowerOn;
            OffEvent2.EventTime = DateTime.Parse(settings.PowerOff2);
            OffEvent2.EventType = PowerEventType.PowerOff;
            if (OffEvent2.EventTime < OnEvent2.EventTime)
            {
                OffEvent2.EventTime = OffEvent2.EventTime.AddDays(1);
                OffEventOffset2 = true;
            }

            //If the event is on a valid day, add it to the list
            if ((settings.Weekday1 & (int)CurrentDay) > 0)
            {
                EventList.Add(OnEvent1);
                EventList.Add(OffEvent1);
            }

            if ((settings.Weekday2 & (int)CurrentDay) > 0)
            {
                EventList.Add(OnEvent2);
                EventList.Add(OffEvent2);
            }

            if (OffEventOffset1)
                if ((settings.Weekday1 & (int)YesterDay) > 0)
                    EventList.Add(OffEvent1);

            if (OffEventOffset2)
                if ((settings.Weekday2 & (int)YesterDay) > 0)
                    EventList.Add(OffEvent2);

            //Sort the list
            EventList.Sort(new PowerEventSort());

            //Get the next event
            PowerEvent NextEvent = new PowerEvent();
            NextEvent.EventType = PowerEventType.NoAction;

            foreach (PowerEvent pe in EventList)
            {
                if (pe.EventTime > DateTime.Now)
                {
                    NextEvent = pe;
                    break;
                }
            }
           
            //Note that we have updated the schedule
            ScheduleChanged = false;
            
            //Return the next event
            return NextEvent;
        }

        private EditSchedule.WeekDays GetScheduleDay(DateTime Today)
        {
            if (Today.DayOfWeek == DayOfWeek.Sunday)
                return EditSchedule.WeekDays.Sunday;
            if (Today.DayOfWeek == DayOfWeek.Monday)
                return EditSchedule.WeekDays.Monday;
            if (Today.DayOfWeek == DayOfWeek.Tuesday)
                return EditSchedule.WeekDays.Tuesday;
            if (Today.DayOfWeek == DayOfWeek.Wednesday)
                return EditSchedule.WeekDays.Wednesday;
            if (Today.DayOfWeek == DayOfWeek.Thursday)
                return EditSchedule.WeekDays.Thursday;
            if (Today.DayOfWeek == DayOfWeek.Friday)
                return EditSchedule.WeekDays.Friday;
            if (Today.DayOfWeek == DayOfWeek.Saturday)
                return EditSchedule.WeekDays.Saturday;

            return EditSchedule.WeekDays.Sunday;
        }

        public void PowerOn()
        {
            if (settings.UseWindowsPower)
                WindowsPowerManagement.PowerOn(CarouselMonitorControl.WindowHandle);
            else if (settings.UseSerialPortPower)
                SerialPowerManagement.PowerOn();
        }

        public void PowerOff()
        {
            if (settings.UseWindowsPower)
                WindowsPowerManagement.PowerOff(CarouselMonitorControl.WindowHandle);
            else if (settings.UseSerialPortPower)
                SerialPowerManagement.PowerOff();
        }

        public class PowerEventSort : IComparer
        {
            int IComparer.Compare(Object x, Object y)
            {
                if ( ((PowerEvent)x).EventTime < ((PowerEvent)y).EventTime )
                    return -1;
                else if (((PowerEvent)x).EventTime > ((PowerEvent)y).EventTime)
                    return 1;
                else
                    return 0;
            }
        }

      }
}