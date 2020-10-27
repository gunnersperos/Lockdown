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
            this.lblBack = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSetting1 = new System.Windows.Forms.Label();
            this.lblSetting2 = new System.Windows.Forms.Label();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImgBox)).BeginInit();
            this.FromControlPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
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
            this.FromControlPanel.Controls.Add(this.lblBack);
            this.FromControlPanel.Controls.Add(this.lblMinimize);
            this.FromControlPanel.Controls.Add(this.lblExit);
            this.FromControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FromControlPanel.Location = new System.Drawing.Point(200, 0);
            this.FromControlPanel.Name = "FromControlPanel";
            this.FromControlPanel.Size = new System.Drawing.Size(530, 29);
            this.FromControlPanel.TabIndex = 1;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblBack.Location = new System.Drawing.Point(0, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(20, 20);
            this.lblBack.TabIndex = 3;
            this.lblBack.Text = "◁";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
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
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
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
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.lblSetting2);
            this.ContentPanel.Controls.Add(this.lblSetting1);
            this.ContentPanel.Controls.Add(this.label1);
            this.ContentPanel.Controls.Add(this.lblGeneral);
            this.ContentPanel.Controls.Add(this.lblAbout);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(200, 29);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(530, 411);
            this.ContentPanel.TabIndex = 2;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Impact", 22F);
            this.lblAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblAbout.Location = new System.Drawing.Point(40, 269);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(94, 37);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = "About:";
            // 
            // lblGeneral
            // 
            this.lblGeneral.AutoSize = true;
            this.lblGeneral.Font = new System.Drawing.Font("Impact", 22F);
            this.lblGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblGeneral.Location = new System.Drawing.Point(40, 3);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(120, 37);
            this.lblGeneral.TabIndex = 1;
            this.lblGeneral.Text = "General:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(62, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lockdown is a project created by three college seniors from University of Cincinn" +
    "ati.";
            // 
            // lblSetting1
            // 
            this.lblSetting1.AutoSize = true;
            this.lblSetting1.Font = new System.Drawing.Font("Impact", 10F);
            this.lblSetting1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblSetting1.Location = new System.Drawing.Point(65, 53);
            this.lblSetting1.Name = "lblSetting1";
            this.lblSetting1.Size = new System.Drawing.Size(56, 18);
            this.lblSetting1.TabIndex = 3;
            this.lblSetting1.Text = "Setting1:";
            // 
            // lblSetting2
            // 
            this.lblSetting2.AutoSize = true;
            this.lblSetting2.Font = new System.Drawing.Font("Impact", 10F);
            this.lblSetting2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblSetting2.Location = new System.Drawing.Point(65, 95);
            this.lblSetting2.Name = "lblSetting2";
            this.lblSetting2.Size = new System.Drawing.Size(58, 18);
            this.lblSetting2.TabIndex = 4;
            this.lblSetting2.Text = "Setting2:";
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
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox LogoImgBox;
        private System.Windows.Forms.Panel FromControlPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblSetting2;
        private System.Windows.Forms.Label lblSetting1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGeneral;
    }
}