namespace TRMS.CarouselMonitorControl
{
    partial class CarouselMonitorControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarouselMonitorControl));
            this.BasicControlIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.BasicControlMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.EditSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.powerOnNow = new System.Windows.Forms.ToolStripMenuItem();
            this.PowerOff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.BasicControlMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BasicControlIcon
            // 
            this.BasicControlIcon.ContextMenuStrip = this.BasicControlMenuStrip;
            this.BasicControlIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("BasicControlIcon.Icon")));
            this.BasicControlIcon.Text = "CarouselMonitorControl";
            this.BasicControlIcon.Visible = true;
            // 
            // BasicControlMenuStrip
            // 
            this.BasicControlMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditConfiguration,
            this.EditSchedule,
            this.toolStripSeparator2,
            this.powerOnNow,
            this.PowerOff,
            this.toolStripSeparator1,
            this.Exit});
            this.BasicControlMenuStrip.Name = "BasicControlMenuStrip";
            this.BasicControlMenuStrip.Size = new System.Drawing.Size(181, 126);
            // 
            // EditConfiguration
            // 
            this.EditConfiguration.Name = "EditConfiguration";
            this.EditConfiguration.Size = new System.Drawing.Size(180, 22);
            this.EditConfiguration.Text = "Edit Configuration...";
            this.EditConfiguration.Click += new System.EventHandler(this.EditConfiguration_Click);
            // 
            // EditSchedule
            // 
            this.EditSchedule.Name = "EditSchedule";
            this.EditSchedule.Size = new System.Drawing.Size(180, 22);
            this.EditSchedule.Text = "Edit Schedule...";
            this.EditSchedule.Click += new System.EventHandler(this.EditSchedule_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // powerOnNow
            // 
            this.powerOnNow.Name = "powerOnNow";
            this.powerOnNow.Size = new System.Drawing.Size(180, 22);
            this.powerOnNow.Text = "Power On Now";
            this.powerOnNow.Click += new System.EventHandler(this.powerOnNow_Click);
            // 
            // PowerOff
            // 
            this.PowerOff.Name = "PowerOff";
            this.PowerOff.Size = new System.Drawing.Size(180, 22);
            this.PowerOff.Text = "Power Off Now";
            this.PowerOff.Click += new System.EventHandler(this.PowerOff_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 22);
            this.Exit.Text = "Exit...";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CarouselMonitorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 31);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarouselMonitorControl";
            this.Text = "Basic Monitor Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.CarouselMonitorControl_Load);
            this.BasicControlMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon BasicControlIcon;
        private System.Windows.Forms.ContextMenuStrip BasicControlMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem EditSchedule;
        private System.Windows.Forms.ToolStripMenuItem PowerOff;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem EditConfiguration;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem powerOnNow;

    }
}

