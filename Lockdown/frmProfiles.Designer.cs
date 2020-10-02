﻿namespace Lockdown
{
    partial class frmProfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfiles));
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BlockedWebPanel = new System.Windows.Forms.Panel();
            this.listBlockedWebsites = new System.Windows.Forms.ListBox();
            this.btnUnblockWebsite = new System.Windows.Forms.Button();
            this.btnAddBlockedWebsite = new System.Windows.Forms.Button();
            this.BlockedAppPanel = new System.Windows.Forms.Panel();
            this.listBlockedApps = new System.Windows.Forms.ListBox();
            this.btnUnblockApp = new System.Windows.Forms.Button();
            this.btnAddBlockedApp = new System.Windows.Forms.Button();
            this.FormControlPanel = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.cbProfiles = new System.Windows.Forms.ComboBox();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LogoImgBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NavigationPanel.SuspendLayout();
            this.ProfilePanel.SuspendLayout();
            this.BlockedWebPanel.SuspendLayout();
            this.BlockedAppPanel.SuspendLayout();
            this.FormControlPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.Controls.Add(this.ProfilePanel);
            this.NavigationPanel.Controls.Add(this.BlockedWebPanel);
            this.NavigationPanel.Controls.Add(this.BlockedAppPanel);
            this.NavigationPanel.Controls.Add(this.FormControlPanel);
            this.NavigationPanel.Controls.Add(this.cbProfiles);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationPanel.Location = new System.Drawing.Point(200, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(530, 440);
            this.NavigationPanel.TabIndex = 5;
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.Controls.Add(this.label1);
            this.ProfilePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfilePanel.Location = new System.Drawing.Point(0, 29);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(530, 94);
            this.ProfilePanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 59);
            this.label1.TabIndex = 6;
            this.label1.Text = "Profile UI will go here";
            // 
            // BlockedWebPanel
            // 
            this.BlockedWebPanel.Controls.Add(this.listBlockedWebsites);
            this.BlockedWebPanel.Controls.Add(this.btnUnblockWebsite);
            this.BlockedWebPanel.Controls.Add(this.btnAddBlockedWebsite);
            this.BlockedWebPanel.Location = new System.Drawing.Point(266, 129);
            this.BlockedWebPanel.Name = "BlockedWebPanel";
            this.BlockedWebPanel.Size = new System.Drawing.Size(260, 308);
            this.BlockedWebPanel.TabIndex = 5;
            // 
            // listBlockedWebsites
            // 
            this.listBlockedWebsites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.listBlockedWebsites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBlockedWebsites.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBlockedWebsites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.listBlockedWebsites.FormattingEnabled = true;
            this.listBlockedWebsites.Location = new System.Drawing.Point(0, 0);
            this.listBlockedWebsites.Name = "listBlockedWebsites";
            this.listBlockedWebsites.Size = new System.Drawing.Size(260, 223);
            this.listBlockedWebsites.TabIndex = 1;
            // 
            // btnUnblockWebsite
            // 
            this.btnUnblockWebsite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnUnblockWebsite.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUnblockWebsite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.btnUnblockWebsite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnUnblockWebsite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.btnUnblockWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnblockWebsite.ForeColor = System.Drawing.Color.White;
            this.btnUnblockWebsite.Location = new System.Drawing.Point(0, 250);
            this.btnUnblockWebsite.Name = "btnUnblockWebsite";
            this.btnUnblockWebsite.Size = new System.Drawing.Size(260, 29);
            this.btnUnblockWebsite.TabIndex = 3;
            this.btnUnblockWebsite.Text = "Unblock Website";
            this.btnUnblockWebsite.UseVisualStyleBackColor = false;
            this.btnUnblockWebsite.Click += new System.EventHandler(this.btnUnblockWebsite_Click);
            // 
            // btnAddBlockedWebsite
            // 
            this.btnAddBlockedWebsite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnAddBlockedWebsite.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddBlockedWebsite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.btnAddBlockedWebsite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnAddBlockedWebsite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.btnAddBlockedWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBlockedWebsite.ForeColor = System.Drawing.Color.White;
            this.btnAddBlockedWebsite.Location = new System.Drawing.Point(0, 279);
            this.btnAddBlockedWebsite.Name = "btnAddBlockedWebsite";
            this.btnAddBlockedWebsite.Size = new System.Drawing.Size(260, 29);
            this.btnAddBlockedWebsite.TabIndex = 2;
            this.btnAddBlockedWebsite.Text = "Block Website";
            this.btnAddBlockedWebsite.UseVisualStyleBackColor = false;
            this.btnAddBlockedWebsite.Click += new System.EventHandler(this.btnAddBlockedWebsite_Click);
            // 
            // BlockedAppPanel
            // 
            this.BlockedAppPanel.Controls.Add(this.listBlockedApps);
            this.BlockedAppPanel.Controls.Add(this.btnUnblockApp);
            this.BlockedAppPanel.Controls.Add(this.btnAddBlockedApp);
            this.BlockedAppPanel.Location = new System.Drawing.Point(0, 129);
            this.BlockedAppPanel.Name = "BlockedAppPanel";
            this.BlockedAppPanel.Size = new System.Drawing.Size(260, 308);
            this.BlockedAppPanel.TabIndex = 4;
            // 
            // listBlockedApps
            // 
            this.listBlockedApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.listBlockedApps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBlockedApps.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBlockedApps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.listBlockedApps.FormattingEnabled = true;
            this.listBlockedApps.Location = new System.Drawing.Point(0, 0);
            this.listBlockedApps.Name = "listBlockedApps";
            this.listBlockedApps.Size = new System.Drawing.Size(260, 223);
            this.listBlockedApps.TabIndex = 1;
            // 
            // btnUnblockApp
            // 
            this.btnUnblockApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnUnblockApp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUnblockApp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.btnUnblockApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnUnblockApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.btnUnblockApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnblockApp.ForeColor = System.Drawing.Color.White;
            this.btnUnblockApp.Location = new System.Drawing.Point(0, 250);
            this.btnUnblockApp.Name = "btnUnblockApp";
            this.btnUnblockApp.Size = new System.Drawing.Size(260, 29);
            this.btnUnblockApp.TabIndex = 2;
            this.btnUnblockApp.Text = "Unblock App";
            this.btnUnblockApp.UseVisualStyleBackColor = false;
            this.btnUnblockApp.Click += new System.EventHandler(this.btnUnblockApp_Click);
            // 
            // btnAddBlockedApp
            // 
            this.btnAddBlockedApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnAddBlockedApp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddBlockedApp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.btnAddBlockedApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnAddBlockedApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.btnAddBlockedApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBlockedApp.ForeColor = System.Drawing.Color.White;
            this.btnAddBlockedApp.Location = new System.Drawing.Point(0, 279);
            this.btnAddBlockedApp.Name = "btnAddBlockedApp";
            this.btnAddBlockedApp.Size = new System.Drawing.Size(260, 29);
            this.btnAddBlockedApp.TabIndex = 3;
            this.btnAddBlockedApp.Text = "Block App";
            this.btnAddBlockedApp.UseVisualStyleBackColor = false;
            this.btnAddBlockedApp.Click += new System.EventHandler(this.btnAddBlockedApp_Click);
            // 
            // FormControlPanel
            // 
            this.FormControlPanel.Controls.Add(this.lblMinimize);
            this.FormControlPanel.Controls.Add(this.lblExit);
            this.FormControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormControlPanel.Location = new System.Drawing.Point(0, 0);
            this.FormControlPanel.Name = "FormControlPanel";
            this.FormControlPanel.Size = new System.Drawing.Size(530, 29);
            this.FormControlPanel.TabIndex = 3;
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.White;
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
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(509, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(21, 20);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // cbProfiles
            // 
            this.cbProfiles.DisplayMember = "profileName";
            this.cbProfiles.FormattingEnabled = true;
            this.cbProfiles.Location = new System.Drawing.Point(6, 6);
            this.cbProfiles.Name = "cbProfiles";
            this.cbProfiles.Size = new System.Drawing.Size(197, 21);
            this.cbProfiles.TabIndex = 0;
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.LogoImgBox);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(200, 440);
            this.LogoPanel.TabIndex = 4;
            // 
            // LogoImgBox
            // 
            this.LogoImgBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoImgBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoImgBox.Image")));
            this.LogoImgBox.Location = new System.Drawing.Point(0, 0);
            this.LogoImgBox.Name = "LogoImgBox";
            this.LogoImgBox.Size = new System.Drawing.Size(200, 440);
            this.LogoImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoImgBox.TabIndex = 0;
            this.LogoImgBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.ReadOnlyChecked = true;
            // 
            // frmProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(730, 440);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.LogoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfiles";
            this.NavigationPanel.ResumeLayout(false);
            this.ProfilePanel.ResumeLayout(false);
            this.ProfilePanel.PerformLayout();
            this.BlockedWebPanel.ResumeLayout(false);
            this.BlockedAppPanel.ResumeLayout(false);
            this.FormControlPanel.ResumeLayout(false);
            this.FormControlPanel.PerformLayout();
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox LogoImgBox;
        private System.Windows.Forms.Panel FormControlPanel;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.ComboBox cbProfiles;
        private System.Windows.Forms.ListBox listBlockedApps;
        private System.Windows.Forms.Button btnUnblockApp;
        private System.Windows.Forms.Button btnAddBlockedApp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel ProfilePanel;
        private System.Windows.Forms.Panel BlockedWebPanel;
        private System.Windows.Forms.ListBox listBlockedWebsites;
        private System.Windows.Forms.Button btnUnblockWebsite;
        private System.Windows.Forms.Button btnAddBlockedWebsite;
        private System.Windows.Forms.Panel BlockedAppPanel;
        private System.Windows.Forms.Label label1;
    }
}