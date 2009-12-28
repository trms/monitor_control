using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;

namespace TRMS.CarouselMonitorControl
{
    public partial class EditConfiguration : Form
    {
        public EditConfiguration()
        {
            InitializeComponent();
        }

        private void EditConfiguration_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
			if (Properties.Settings.Default.NetworkControl)
				TRMS.CarouselMonitorControl.NetworkControl.StartServer();
			else
				TRMS.CarouselMonitorControl.NetworkControl.StopServer();

            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (PowerOnString.Text.Replace(",", "").Length % 2  > 0)
                MessageBox.Show("The Power On String must be an even number of characters.");
            else if (PowerOffString.Text.Replace(",", "").Length % 2 > 0)
                MessageBox.Show("The Power Off String must be an even number of characters.");
            else
            {
                SaveSettings();
                this.Close();
            }
        }

        private void LoadSettings()
        {
            ArrayList Ports = SerialPowerManagement.GetSerialPorts();
            foreach (string p in Ports)
                Port.Items.Add(p);

            Properties.Settings settings = new Properties.Settings();

            Port.SelectedItem = settings.Port;
            Baud.SelectedItem = settings.Baud;
            Parity.SelectedItem = settings.Parity;
            Stopbits.SelectedItem = settings.Stopbits;
            Databits.SelectedItem = settings.Databits;
            PowerOnString.Text = settings.PowerOnString;
            PowerOffString.Text = settings.PowerOffString;

            if (settings.UseWindowsPower)
            {
                UseWindowsPower.Checked = true;
                UseSerialPortPower.Checked = false;
                SerialPanel.Enabled = false;
            }
            else
            {
                UseWindowsPower.Checked = false;
                UseSerialPortPower.Checked = true;
                SerialPanel.Enabled = true;
            }

            NetworkControl.Checked = settings.NetworkControl;
        }

        private void SaveSettings()
        {
            Properties.Settings settings = new Properties.Settings();

            settings.Port = Port.Text;
            settings.Baud = Baud.Text;
            settings.Parity = Parity.Text;
            settings.Stopbits = Stopbits.Text;
            settings.Databits = Databits.Text;
            settings.PowerOnString = PowerOnString.Text;
            settings.PowerOffString = PowerOffString.Text;

            if (UseWindowsPower.Checked)
            {
                settings.UseWindowsPower = true;
                settings.UseSerialPortPower = false;
            }
            else
            {
                settings.UseWindowsPower = false;
                settings.UseSerialPortPower = true;
            }

            settings.NetworkControl = NetworkControl.Checked;
            settings.Save();
        }

        private void UseWindowsPower_CheckedChanged(object sender, EventArgs e)
        {
            SerialPanel.Enabled = false;
        }

        private void UseSerialPortPower_CheckedChanged(object sender, EventArgs e)
        {
            SerialPanel.Enabled = true;
        }

        private void PowerOnString_TextChanged(object sender, EventArgs e)
        {
            Regex hex = new Regex("^[0-9a-fA-F,]*$");
            if (hex.IsMatch(PowerOnString.Text))
            {
                if (PowerOnString.Text.Replace(",", "").Length % 2 > 0)
                {
                    errorProvider1.SetError(PowerOnString, "The string length is invalid");
                    Save.Enabled = false;
                }
                else
                {
                    errorProvider1.SetError(PowerOnString, "");
                    Save.Enabled = true;
                }
            }
            else
            {
                errorProvider1.SetError(PowerOnString, "The string contains invalid non-hex characters");
                Save.Enabled = false;
            }

        }

        private void PowerOffString_TextChanged(object sender, EventArgs e)
        {
            Regex hex = new Regex("^[0-9a-fA-F,]*$");
            if (hex.IsMatch(PowerOffString.Text))
            {
                if (PowerOffString.Text.Replace(",", "").Length % 2 > 0)
                {
                    errorProvider1.SetError(PowerOffString, "The string length is invalid");
                    Save.Enabled = false;
                }
                else
                {
                    errorProvider1.SetError(PowerOffString, "");
                    Save.Enabled = true;

                }
            }
            else
            {
                errorProvider1.SetError(PowerOffString, "The string contains invalid non-hexcharacters");
                Save.Enabled = false;
            }
        }

		private void NetworkControl_CheckedChanged(object sender, EventArgs e)
		{
			if (NetworkControl.Checked)
				TRMS.CarouselMonitorControl.NetworkControl.StartServer();
			else
				TRMS.CarouselMonitorControl.NetworkControl.StopServer();
		}



    }
}