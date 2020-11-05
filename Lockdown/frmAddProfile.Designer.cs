namespace Lockdown
{
    partial class frmAddProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProfile));
            this.LogoImgBox = new System.Windows.Forms.PictureBox();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.FormControlPanel = new System.Windows.Forms.Panel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.btnCreateProfile = new System.Windows.Forms.Button();
            this.lblNewProfile = new System.Windows.Forms.Label();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.txtNewProfile = new System.Windows.Forms.TextBox();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImgBox)).BeginInit();
            this.FormControlPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.NavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoImgBox
            // 
            this.LogoImgBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoImgBox.Image")));
            this.LogoImgBox.Location = new System.Drawing.Point(12, 0);
            this.LogoImgBox.Name = "LogoImgBox";
            this.LogoImgBox.Size = new System.Drawing.Size(180, 440);
            this.LogoImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoImgBox.TabIndex = 0;
            this.LogoImgBox.TabStop = false;
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
            this.lblBack.TabIndex = 2;
            this.lblBack.Text = "◁";
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblMinimize.Location = new System.Drawing.Point(693, 0);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(16, 20);
            this.lblMinimize.TabIndex = 1;
            this.lblMinimize.Text = "–";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblExit.Location = new System.Drawing.Point(709, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(21, 20);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // FormControlPanel
            // 
            this.FormControlPanel.Controls.Add(this.lblBack);
            this.FormControlPanel.Controls.Add(this.lblMinimize);
            this.FormControlPanel.Controls.Add(this.lblExit);
            this.FormControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormControlPanel.Location = new System.Drawing.Point(0, 0);
            this.FormControlPanel.Name = "FormControlPanel";
            this.FormControlPanel.Size = new System.Drawing.Size(730, 29);
            this.FormControlPanel.TabIndex = 3;
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.LogoImgBox);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(200, 440);
            this.LogoPanel.TabIndex = 6;
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnCreateProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.btnCreateProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnCreateProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.btnCreateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateProfile.Font = new System.Drawing.Font("Impact", 22F);
            this.btnCreateProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnCreateProfile.Location = new System.Drawing.Point(670, 27);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.Size = new System.Drawing.Size(35, 50);
            this.btnCreateProfile.TabIndex = 8;
            this.btnCreateProfile.Text = "✓";
            this.btnCreateProfile.UseVisualStyleBackColor = false;
            this.btnCreateProfile.Click += new System.EventHandler(this.btnNewProfile_Click);
            // 
            // lblNewProfile
            // 
            this.lblNewProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewProfile.AutoSize = true;
            this.lblNewProfile.Font = new System.Drawing.Font("Impact", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblNewProfile.Location = new System.Drawing.Point(206, 4);
            this.lblNewProfile.Name = "lblNewProfile";
            this.lblNewProfile.Size = new System.Drawing.Size(124, 88);
            this.lblNewProfile.TabIndex = 6;
            this.lblNewProfile.Text = "New\nProfile:";
            // 
            // panelProfile
            // 
            this.panelProfile.Controls.Add(this.txtNewProfile);
            this.panelProfile.Controls.Add(this.btnCreateProfile);
            this.panelProfile.Controls.Add(this.lblNewProfile);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfile.Location = new System.Drawing.Point(0, 29);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(730, 94);
            this.panelProfile.TabIndex = 5;
            // 
            // txtNewProfile
            // 
            this.txtNewProfile.Location = new System.Drawing.Point(340, 50);
            this.txtNewProfile.Name = "txtNewProfile";
            this.txtNewProfile.Size = new System.Drawing.Size(318, 20);
            this.txtNewProfile.TabIndex = 9;
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.Controls.Add(this.panelProfile);
            this.NavigationPanel.Controls.Add(this.FormControlPanel);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(730, 440);
            this.NavigationPanel.TabIndex = 7;
            // 
            // frmAddProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(730, 440);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.NavigationPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddProfile";
            this.Text = "frmAddProfile";
            ((System.ComponentModel.ISupportInitialize)(this.LogoImgBox)).EndInit();
            this.FormControlPanel.ResumeLayout(false);
            this.FormControlPanel.PerformLayout();
            this.LogoPanel.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            this.NavigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoImgBox;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel FormControlPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Button btnCreateProfile;
        private System.Windows.Forms.Label lblNewProfile;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.TextBox txtNewProfile;
    }
}