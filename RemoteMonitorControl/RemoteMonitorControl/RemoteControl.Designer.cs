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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // servicesList
            // 
            this.servicesList.FormattingEnabled = true;
            this.servicesList.Location = new System.Drawing.Point(12, 12);
            this.servicesList.Name = "servicesList";
            this.servicesList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.servicesList.Size = new System.Drawing.Size(254, 342);
            this.servicesList.Sorted = true;
            this.servicesList.TabIndex = 0;
            this.servicesList.SelectedIndexChanged += new System.EventHandler(this.servicesList_SelectedIndexChanged);
            // 
            // OnButton
            // 
            this.OnButton.Location = new System.Drawing.Point(12, 361);
            this.OnButton.Name = "OnButton";
            this.OnButton.Size = new System.Drawing.Size(75, 23);
            this.OnButton.TabIndex = 1;
            this.OnButton.Text = "On";
            this.OnButton.UseVisualStyleBackColor = true;
            this.OnButton.Click += new System.EventHandler(this.OnButton_Click);
            // 
            // OffButton
            // 
            this.OffButton.Location = new System.Drawing.Point(191, 361);
            this.OffButton.Name = "OffButton";
            this.OffButton.Size = new System.Drawing.Size(75, 23);
            this.OffButton.TabIndex = 2;
            this.OffButton.Text = "Off";
            this.OffButton.UseVisualStyleBackColor = true;
            this.OffButton.Click += new System.EventHandler(this.OffButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // RemoteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OffButton);
            this.Controls.Add(this.OnButton);
            this.Controls.Add(this.servicesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RemoteControl";
            this.Text = "Carousel Remote Monitor Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.ListBox servicesList;
		private System.Windows.Forms.Button OnButton;
		private System.Windows.Forms.Button OffButton;
		private System.Windows.Forms.Label label1;
    }
}

