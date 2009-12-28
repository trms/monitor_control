namespace RemoteMonitorControl
{
    partial class Form1
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
			this.servicesList = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// servicesList
			// 
			this.servicesList.FormattingEnabled = true;
			this.servicesList.Location = new System.Drawing.Point(26, 25);
			this.servicesList.Name = "servicesList";
			this.servicesList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.servicesList.Size = new System.Drawing.Size(204, 238);
			this.servicesList.Sorted = true;
			this.servicesList.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 344);
			this.Controls.Add(this.servicesList);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.ListBox servicesList;
    }
}

