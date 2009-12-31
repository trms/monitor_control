namespace TRMS.CarouselMonitorControl
{
    partial class EditConfiguration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditConfiguration));
            this.UseWindowsPower = new System.Windows.Forms.RadioButton();
            this.UseSerialPortPower = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Baud = new System.Windows.Forms.ComboBox();
            this.Parity = new System.Windows.Forms.ComboBox();
            this.Databits = new System.Windows.Forms.ComboBox();
            this.Stopbits = new System.Windows.Forms.ComboBox();
            this.Port = new System.Windows.Forms.ComboBox();
            this.PowerOnString = new System.Windows.Forms.TextBox();
            this.PowerOffString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SerialPanel = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.NetworkControl = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UseUSBUIRTPower = new System.Windows.Forms.RadioButton();
            this.USBPanel = new System.Windows.Forms.GroupBox();
            this.USBPowerOnString = new System.Windows.Forms.TextBox();
            this.USBPowerOffString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.USBLearnOn = new System.Windows.Forms.Button();
            this.USBTestOn = new System.Windows.Forms.Button();
            this.USBTestOff = new System.Windows.Forms.Button();
            this.USBLearnOff = new System.Windows.Forms.Button();
            this.SerialPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.USBPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UseWindowsPower
            // 
            this.UseWindowsPower.AutoSize = true;
            this.UseWindowsPower.Location = new System.Drawing.Point(13, 19);
            this.UseWindowsPower.Name = "UseWindowsPower";
            this.UseWindowsPower.Size = new System.Drawing.Size(187, 17);
            this.UseWindowsPower.TabIndex = 0;
            this.UseWindowsPower.TabStop = true;
            this.UseWindowsPower.Text = "Use Windows power management";
            this.UseWindowsPower.UseVisualStyleBackColor = true;
            this.UseWindowsPower.CheckedChanged += new System.EventHandler(this.UseWindowsPower_CheckedChanged);
            // 
            // UseSerialPortPower
            // 
            this.UseSerialPortPower.AutoSize = true;
            this.UseSerialPortPower.Location = new System.Drawing.Point(13, 42);
            this.UseSerialPortPower.Name = "UseSerialPortPower";
            this.UseSerialPortPower.Size = new System.Drawing.Size(127, 17);
            this.UseSerialPortPower.TabIndex = 1;
            this.UseSerialPortPower.TabStop = true;
            this.UseSerialPortPower.Text = "Use serial port control";
            this.UseSerialPortPower.UseVisualStyleBackColor = true;
            this.UseSerialPortPower.CheckedChanged += new System.EventHandler(this.UseSerialPortPower_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // Baud
            // 
            this.Baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Baud.FormattingEnabled = true;
            this.Baud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "23400",
            "57600"});
            this.Baud.Location = new System.Drawing.Point(121, 17);
            this.Baud.Name = "Baud";
            this.Baud.Size = new System.Drawing.Size(69, 21);
            this.Baud.TabIndex = 5;
            // 
            // Parity
            // 
            this.Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Parity.FormattingEnabled = true;
            this.Parity.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None"});
            this.Parity.Location = new System.Drawing.Point(196, 16);
            this.Parity.Name = "Parity";
            this.Parity.Size = new System.Drawing.Size(47, 21);
            this.Parity.TabIndex = 6;
            // 
            // Databits
            // 
            this.Databits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Databits.FormattingEnabled = true;
            this.Databits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.Databits.Location = new System.Drawing.Point(249, 16);
            this.Databits.Name = "Databits";
            this.Databits.Size = new System.Drawing.Size(46, 21);
            this.Databits.TabIndex = 7;
            // 
            // Stopbits
            // 
            this.Stopbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Stopbits.FormattingEnabled = true;
            this.Stopbits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.Stopbits.Location = new System.Drawing.Point(301, 17);
            this.Stopbits.Name = "Stopbits";
            this.Stopbits.Size = new System.Drawing.Size(45, 21);
            this.Stopbits.TabIndex = 8;
            // 
            // Port
            // 
            this.Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Port.FormattingEnabled = true;
            this.Port.Location = new System.Drawing.Point(3, 16);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(112, 21);
            this.Port.TabIndex = 9;
            // 
            // PowerOnString
            // 
            this.PowerOnString.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PowerOnString.Location = new System.Drawing.Point(3, 64);
            this.PowerOnString.Name = "PowerOnString";
            this.PowerOnString.Size = new System.Drawing.Size(343, 20);
            this.PowerOnString.TabIndex = 10;
            this.PowerOnString.TextChanged += new System.EventHandler(this.PowerOnString_TextChanged);
            // 
            // PowerOffString
            // 
            this.PowerOffString.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PowerOffString.Location = new System.Drawing.Point(3, 104);
            this.PowerOffString.Name = "PowerOffString";
            this.PowerOffString.Size = new System.Drawing.Size(343, 20);
            this.PowerOffString.TabIndex = 11;
            this.PowerOffString.TextChanged += new System.EventHandler(this.PowerOffString_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Power on string";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Power off string";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(266, 449);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 14;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(347, 449);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Parity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Databits";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Baud";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Stopbits";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(330, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "* strings are 2 character hex values. ie. FF0D  = decimal 255 then 13";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "* use a comma \',\' for a 500ms delay";
            // 
            // SerialPanel
            // 
            this.SerialPanel.Controls.Add(this.label2);
            this.SerialPanel.Controls.Add(this.label10);
            this.SerialPanel.Controls.Add(this.Baud);
            this.SerialPanel.Controls.Add(this.label9);
            this.SerialPanel.Controls.Add(this.Parity);
            this.SerialPanel.Controls.Add(this.label8);
            this.SerialPanel.Controls.Add(this.Databits);
            this.SerialPanel.Controls.Add(this.label7);
            this.SerialPanel.Controls.Add(this.Stopbits);
            this.SerialPanel.Controls.Add(this.label6);
            this.SerialPanel.Controls.Add(this.Port);
            this.SerialPanel.Controls.Add(this.label5);
            this.SerialPanel.Controls.Add(this.PowerOnString);
            this.SerialPanel.Controls.Add(this.PowerOffString);
            this.SerialPanel.Controls.Add(this.label3);
            this.SerialPanel.Controls.Add(this.label4);
            this.SerialPanel.Location = new System.Drawing.Point(35, 65);
            this.SerialPanel.Name = "SerialPanel";
            this.SerialPanel.Size = new System.Drawing.Size(381, 171);
            this.SerialPanel.TabIndex = 22;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 100;
            this.errorProvider1.ContainerControl = this;
            // 
            // NetworkControl
            // 
            this.NetworkControl.AutoSize = true;
            this.NetworkControl.Location = new System.Drawing.Point(13, 19);
            this.NetworkControl.Name = "NetworkControl";
            this.NetworkControl.Size = new System.Drawing.Size(127, 17);
            this.NetworkControl.TabIndex = 23;
            this.NetworkControl.Text = "Allow network control";
            this.NetworkControl.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.USBPanel);
            this.groupBox1.Controls.Add(this.UseUSBUIRTPower);
            this.groupBox1.Controls.Add(this.UseWindowsPower);
            this.groupBox1.Controls.Add(this.UseSerialPortPower);
            this.groupBox1.Controls.Add(this.SerialPanel);
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 383);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "How would you like to control the monitors?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NetworkControl);
            this.groupBox2.Location = new System.Drawing.Point(5, 401);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 41);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Would you like to allow network control?";
            // 
            // UseUSBUIRTPower
            // 
            this.UseUSBUIRTPower.AutoSize = true;
            this.UseUSBUIRTPower.Location = new System.Drawing.Point(13, 242);
            this.UseUSBUIRTPower.Name = "UseUSBUIRTPower";
            this.UseUSBUIRTPower.Size = new System.Drawing.Size(98, 17);
            this.UseUSBUIRTPower.TabIndex = 23;
            this.UseUSBUIRTPower.TabStop = true;
            this.UseUSBUIRTPower.Text = "Use USB-UIRT";
            this.UseUSBUIRTPower.UseVisualStyleBackColor = true;
            this.UseUSBUIRTPower.CheckedChanged += new System.EventHandler(this.UseUSBUIRTPower_CheckedChanged);
            // 
            // USBPanel
            // 
            this.USBPanel.Controls.Add(this.USBTestOff);
            this.USBPanel.Controls.Add(this.USBLearnOff);
            this.USBPanel.Controls.Add(this.USBTestOn);
            this.USBPanel.Controls.Add(this.USBLearnOn);
            this.USBPanel.Controls.Add(this.USBPowerOnString);
            this.USBPanel.Controls.Add(this.USBPowerOffString);
            this.USBPanel.Controls.Add(this.label1);
            this.USBPanel.Controls.Add(this.label11);
            this.USBPanel.Location = new System.Drawing.Point(35, 265);
            this.USBPanel.Name = "USBPanel";
            this.USBPanel.Size = new System.Drawing.Size(381, 108);
            this.USBPanel.TabIndex = 24;
            this.USBPanel.TabStop = false;
            // 
            // USBPowerOnString
            // 
            this.USBPowerOnString.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.USBPowerOnString.Location = new System.Drawing.Point(19, 36);
            this.USBPowerOnString.Name = "USBPowerOnString";
            this.USBPowerOnString.Size = new System.Drawing.Size(242, 20);
            this.USBPowerOnString.TabIndex = 14;
            // 
            // USBPowerOffString
            // 
            this.USBPowerOffString.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.USBPowerOffString.Location = new System.Drawing.Point(19, 76);
            this.USBPowerOffString.Name = "USBPowerOffString";
            this.USBPowerOffString.Size = new System.Drawing.Size(242, 20);
            this.USBPowerOffString.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Power on string";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Power off string";
            // 
            // USBLearnOn
            // 
            this.USBLearnOn.Location = new System.Drawing.Point(267, 36);
            this.USBLearnOn.Name = "USBLearnOn";
            this.USBLearnOn.Size = new System.Drawing.Size(52, 23);
            this.USBLearnOn.TabIndex = 18;
            this.USBLearnOn.Text = "Learn";
            this.USBLearnOn.UseVisualStyleBackColor = true;
            this.USBLearnOn.Click += new System.EventHandler(this.USBLearnOn_Click);
            // 
            // USBTestOn
            // 
            this.USBTestOn.Location = new System.Drawing.Point(321, 36);
            this.USBTestOn.Name = "USBTestOn";
            this.USBTestOn.Size = new System.Drawing.Size(52, 23);
            this.USBTestOn.TabIndex = 19;
            this.USBTestOn.Text = "Test";
            this.USBTestOn.UseVisualStyleBackColor = true;
            this.USBTestOn.Click += new System.EventHandler(this.USBTestOn_Click);
            // 
            // USBTestOff
            // 
            this.USBTestOff.Location = new System.Drawing.Point(321, 74);
            this.USBTestOff.Name = "USBTestOff";
            this.USBTestOff.Size = new System.Drawing.Size(52, 23);
            this.USBTestOff.TabIndex = 21;
            this.USBTestOff.Text = "Test";
            this.USBTestOff.UseVisualStyleBackColor = true;
            this.USBTestOff.Click += new System.EventHandler(this.USBTestOff_Click);
            // 
            // USBLearnOff
            // 
            this.USBLearnOff.Location = new System.Drawing.Point(267, 74);
            this.USBLearnOff.Name = "USBLearnOff";
            this.USBLearnOff.Size = new System.Drawing.Size(52, 23);
            this.USBLearnOff.TabIndex = 20;
            this.USBLearnOff.Text = "Learn";
            this.USBLearnOff.UseVisualStyleBackColor = true;
            this.USBLearnOff.Click += new System.EventHandler(this.USBLearnOff_Click);
            // 
            // EditConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(439, 481);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditConfiguration";
            this.Text = "Carousel Monitor Control Configuration";
            this.Load += new System.EventHandler(this.EditConfiguration_Load);
            this.SerialPanel.ResumeLayout(false);
            this.SerialPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.USBPanel.ResumeLayout(false);
            this.USBPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton UseWindowsPower;
        private System.Windows.Forms.RadioButton UseSerialPortPower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Baud;
        private System.Windows.Forms.ComboBox Parity;
        private System.Windows.Forms.ComboBox Databits;
        private System.Windows.Forms.ComboBox Stopbits;
        private System.Windows.Forms.ComboBox Port;
        private System.Windows.Forms.TextBox PowerOnString;
        private System.Windows.Forms.TextBox PowerOffString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel SerialPanel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox NetworkControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox USBPanel;
        private System.Windows.Forms.RadioButton UseUSBUIRTPower;
        private System.Windows.Forms.Button USBTestOff;
        private System.Windows.Forms.Button USBLearnOff;
        private System.Windows.Forms.Button USBTestOn;
        private System.Windows.Forms.Button USBLearnOn;
        private System.Windows.Forms.TextBox USBPowerOnString;
        private System.Windows.Forms.TextBox USBPowerOffString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
    }
}