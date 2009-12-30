namespace RemoteMonitorControl
{
    partial class RemoteControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteControl));
			this.servicesList = new System.Windows.Forms.ListBox();
			this.OnButton = new System.Windows.Forms.Button();
			this.OffButton = new System.Windows.Forms.Button();
			this.radioHost = new System.Windows.Forms.RadioButton();
			this.radioList = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// servicesList
			// 
			this.servicesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.servicesList.FormattingEnabled = true;
			this.servicesList.Location = new System.Drawing.Point(32, 38);
			this.servicesList.Name = "servicesList";
			this.servicesList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.servicesList.Size = new System.Drawing.Size(234, 303);
			this.servicesList.Sorted = true;
			this.servicesList.TabIndex = 0;
			this.servicesList.SelectedIndexChanged += new System.EventHandler(this.servicesList_SelectedIndexChanged);
			// 
			// OnButton
			// 
			this.OnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.OnButton.Location = new System.Drawing.Point(32, 353);
			this.OnButton.Name = "OnButton";
			this.OnButton.Size = new System.Drawing.Size(75, 23);
			this.OnButton.TabIndex = 1;
			this.OnButton.Text = "On";
			this.OnButton.UseVisualStyleBackColor = true;
			this.OnButton.Click += new System.EventHandler(this.OnButton_Click);
			// 
			// OffButton
			// 
			this.OffButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OffButton.Location = new System.Drawing.Point(191, 353);
			this.OffButton.Name = "OffButton";
			this.OffButton.Size = new System.Drawing.Size(75, 23);
			this.OffButton.TabIndex = 2;
			this.OffButton.Text = "Off";
			this.OffButton.UseVisualStyleBackColor = true;
			this.OffButton.Click += new System.EventHandler(this.OffButton_Click);
			// 
			// radioHost
			// 
			this.radioHost.AutoSize = true;
			this.radioHost.Location = new System.Drawing.Point(12, 15);
			this.radioHost.Name = "radioHost";
			this.radioHost.Size = new System.Drawing.Size(14, 13);
			this.radioHost.TabIndex = 5;
			this.radioHost.UseVisualStyleBackColor = true;
			this.radioHost.CheckedChanged += new System.EventHandler(this.radioHost_CheckedChanged);
			// 
			// radioList
			// 
			this.radioList.AutoSize = true;
			this.radioList.Checked = true;
			this.radioList.Location = new System.Drawing.Point(12, 38);
			this.radioList.Name = "radioList";
			this.radioList.Size = new System.Drawing.Size(14, 13);
			this.radioList.TabIndex = 6;
			this.radioList.TabStop = true;
			this.radioList.UseVisualStyleBackColor = true;
			this.radioList.CheckedChanged += new System.EventHandler(this.radioList_CheckedChanged);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(32, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(234, 20);
			this.textBox1.TabIndex = 7;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.statusStrip1.AutoSize = false;
			this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 385);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(277, 22);
			this.statusStrip1.TabIndex = 8;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// RemoteControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(278, 407);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.radioList);
			this.Controls.Add(this.radioHost);
			this.Controls.Add(this.OffButton);
			this.Controls.Add(this.OnButton);
			this.Controls.Add(this.servicesList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "RemoteControl";
			this.Text = "Carousel Remote Monitor Control";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.ListBox servicesList;
		private System.Windows.Forms.Button OnButton;
		private System.Windows.Forms.Button OffButton;
		private System.Windows.Forms.RadioButton radioHost;
		private System.Windows.Forms.RadioButton radioList;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

