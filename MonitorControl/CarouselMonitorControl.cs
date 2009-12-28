using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace TRMS.CarouselMonitorControl
{
    public partial class CarouselMonitorControl : Form
    {
        private Thread schedule;

        public CarouselMonitorControl()
        {
            InitializeComponent();

            if(EventLog.SourceExists("Carousel Monitor Control") == false)
                EventLog.CreateEventSource("Carousel Monitor Control", "TRMS");

            PowerManagement.hWnd = this.Handle.ToInt32();

			if (Properties.Settings.Default.NetworkControl)
				NetworkControl.StartServer();

            schedule = new Thread(new ThreadStart(ScheduleThread.RunSchedule));
            schedule.Start();
        }

        private void CarouselMonitorControl_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
			NetworkControl.StopServer();
            schedule.Abort();
            Application.Exit();
        }

        private void EditSchedule_Click(object sender, EventArgs e)
        {
            Form Schedule = new EditSchedule();
            Schedule.Show();
        }

        private void EditConfiguration_Click(object sender, EventArgs e)
        {
            Form Configuration = new EditConfiguration();
            Configuration.Show();
        }

        private void powerOnNow_Click(object sender, EventArgs e)
        {
            PowerManagement.PowerOn();
        }

        private void PowerOff_Click(object sender, EventArgs e)
        {
            PowerManagement.PowerOff();
        }


        
    }





}