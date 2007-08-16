using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace TRMS.CarouselMonitorControl
{
    public partial class EditSchedule : Form
    {

        public enum WeekDays
        {
            Sunday = 0x01,
            Monday= 0x02,
            Tuesday = 0x04,
            Wednesday = 0x08,
            Thursday = 0x010,
            Friday = 0x020,
            Saturday = 0x40
        }

        public EditSchedule()
        {
            InitializeComponent();
        }

        private void EditSchedule_Load(object sender, EventArgs e)
        {
            LoadSettings();
            UpdatePanels();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveSettings();
            //CarouselMonitorControl.Schedue = true;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadSettings()
        {
            Properties.Settings settings = new Properties.Settings();

            PowerOn1.Text = settings.PowerOn1;
            PowerOff1.Text = settings.PowerOff1;
            PowerOn2.Text = settings.PowerOn2 ;
            PowerOff2.Text = settings.PowerOff2;

            if ((settings.Weekday1 & (int)WeekDays.Sunday) > 0)
                Sunday1.Checked = true;
            if ((settings.Weekday1 & (int)WeekDays.Monday) > 0)
                Monday1.Checked = true;
            if ((settings.Weekday1 & (int)WeekDays.Tuesday) > 0)
                Tuesday1.Checked = true;
            if ((settings.Weekday1 & (int)WeekDays.Wednesday) > 0)
                Wednesday1.Checked = true;
            if ((settings.Weekday1 & (int)WeekDays.Thursday) > 0)
                Thursday1.Checked = true;
            if ((settings.Weekday1 & (int)WeekDays.Friday) > 0)
                Friday1.Checked = true;
            if ((settings.Weekday1 & (int)WeekDays.Saturday) > 0)
                Saturday1.Checked = true;

            if ((settings.Weekday2 & (int)WeekDays.Sunday) > 0)
                Sunday2.Checked = true;
            if ((settings.Weekday2 & (int)WeekDays.Monday) > 0)
                Monday2.Checked = true;
            if ((settings.Weekday2 & (int)WeekDays.Tuesday) > 0)
                Tuesday2.Checked = true;
            if ((settings.Weekday2 & (int)WeekDays.Wednesday) > 0)
                Wednesday2.Checked = true;
            if ((settings.Weekday2 & (int)WeekDays.Thursday) > 0)
                Thursday2.Checked = true;
            if ((settings.Weekday2 & (int)WeekDays.Friday) > 0)
                Friday2.Checked = true;
            if ((settings.Weekday2 & (int)WeekDays.Saturday) > 0)
                Saturday2.Checked = true;
        }

        private void SaveSettings()
        {
            Properties.Settings settings = new Properties.Settings();
            settings.Weekday1 = 0;
            settings.Weekday2 = 0;

            settings.PowerOn1 = PowerOn1.Text;
            settings.PowerOff1 = PowerOff1.Text;
            settings.PowerOn2 = PowerOn2.Text;
            settings.PowerOff2 = PowerOff2.Text;

            if (Sunday1.Checked == true)
                settings.Weekday1 += (int)WeekDays.Sunday;
            if (Monday1.Checked == true)
                settings.Weekday1 += (int)WeekDays.Monday;
            if (Tuesday1.Checked == true)
                settings.Weekday1 += (int)WeekDays.Tuesday;
            if (Wednesday1.Checked == true)
                settings.Weekday1 += (int)WeekDays.Wednesday;
            if (Thursday1.Checked == true)
                settings.Weekday1 += (int)WeekDays.Thursday;
            if (Friday1.Checked == true)
                settings.Weekday1 += (int)WeekDays.Friday;
            if (Saturday1.Checked == true)
                settings.Weekday1 += (int)WeekDays.Saturday;

            if (Sunday2.Checked == true)
                settings.Weekday2 += (int)WeekDays.Sunday;
            if (Monday2.Checked == true)
                settings.Weekday2 += (int)WeekDays.Monday;
            if (Tuesday2.Checked == true)
                settings.Weekday2 += (int)WeekDays.Tuesday;
            if (Wednesday2.Checked == true)
                settings.Weekday2 += (int)WeekDays.Wednesday;
            if (Thursday2.Checked == true)
                settings.Weekday2 += (int)WeekDays.Thursday;
            if (Friday2.Checked == true)
                settings.Weekday2 += (int)WeekDays.Friday;
            if (Saturday2.Checked == true)
                settings.Weekday2 += (int)WeekDays.Saturday;

            settings.Save();

            ScheduleHelper.ScheduleChanged = true;
        }

        private void UpdatePanels()
        {
            if (Sunday1.Checked || Monday1.Checked || Tuesday1.Checked || Wednesday1.Checked || Thursday1.Checked || Friday1.Checked || Saturday1.Checked)
                Schedule1Panel.Enabled = true;
            else
                Schedule1Panel.Enabled = false;

            if (Sunday2.Checked || Monday2.Checked || Tuesday2.Checked || Wednesday2.Checked || Thursday2.Checked || Friday2.Checked || Saturday2.Checked)
                Schedule2Panel.Enabled = true;
            else
                Schedule2Panel.Enabled = false;
        }

        private void Sunday2_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePanels();
        }

        private void Monday2_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePanels();
        }

        private void Tuesday2_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePanels();
        }

        private void Wednesday2_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePanels();
        }

        private void Thursday2_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePanels();
        }

        private void Friday2_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePanels();
        }

        private void Saturday2_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePanels();
        }

        private void Sunday1_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePanels();
        }

        private void Monday1_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePanels();
        }

        private void Tuesday1_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePanels();
        }

        private void Wednesday1_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePanels();
        }

        private void Thursday1_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePanels();
        }

        private void Friday1_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePanels();
        }

        private void Saturday1_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePanels();
        }


    }
}