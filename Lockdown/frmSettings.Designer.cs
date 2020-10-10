namespace Lockdown
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LogoImgBox = new System.Windows.Forms.PictureBox();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.LogoImgBox);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(200, 440);
            this.LogoPanel.TabIndex = 0;
            // 
            // LogoImgBox
            // 
            this.LogoImgBox.Image = global::Lockdown.Properties.Resources.TestLogo_Cheeseman__1_;
            this.LogoImgBox.Location = new System.Drawing.Point(12, 0);
            this.LogoImgBox.Name = "LogoImgBox";
            this.LogoImgBox.Size = new System.Drawing.Size(180, 440);
            this.LogoImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoImgBox.TabIndex = 0;
            this.LogoImgBox.TabStop = false;
            // 
            // frmSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(730, 440);
            this.Controls.Add(this.LogoPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(730, 440);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lockdown";
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox LogoImgBox;
    }
}