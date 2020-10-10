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
            this.FromControlPanel = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImgBox)).BeginInit();
            this.FromControlPanel.SuspendLayout();
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
            // FromControlPanel
            // 
            this.FromControlPanel.Controls.Add(this.lblMinimize);
            this.FromControlPanel.Controls.Add(this.lblExit);
            this.FromControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FromControlPanel.Location = new System.Drawing.Point(200, 0);
            this.FromControlPanel.Name = "FromControlPanel";
            this.FromControlPanel.Size = new System.Drawing.Size(530, 29);
            this.FromControlPanel.TabIndex = 1;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(200, 29);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(530, 411);
            this.ContentPanel.TabIndex = 2;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblExit.Location = new System.Drawing.Point(509, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(21, 20);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "X";
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblMinimize.Location = new System.Drawing.Point(493, 0);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(16, 20);
            this.lblMinimize.TabIndex = 1;
            this.lblMinimize.Text = "–";
            // 
            // frmSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(730, 440);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.FromControlPanel);
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
            this.FromControlPanel.ResumeLayout(false);
            this.FromControlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox LogoImgBox;
        private System.Windows.Forms.Panel FromControlPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblMinimize;
    }
}