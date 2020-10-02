namespace Lockdown
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
            this.btnUnblockApp = new System.Windows.Forms.Button();
            this.btnAddBlockedApp = new System.Windows.Forms.Button();
            this.FormControlPanel = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.listBlockedApps = new System.Windows.Forms.ListBox();
            this.cbProfiles = new System.Windows.Forms.ComboBox();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LogoImgBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblMinMaxForm = new System.Windows.Forms.Label();
            this.NavigationPanel.SuspendLayout();
            this.FormControlPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.Controls.Add(this.btnUnblockApp);
            this.NavigationPanel.Controls.Add(this.btnAddBlockedApp);
            this.NavigationPanel.Controls.Add(this.FormControlPanel);
            this.NavigationPanel.Controls.Add(this.listBlockedApps);
            this.NavigationPanel.Controls.Add(this.cbProfiles);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationPanel.Location = new System.Drawing.Point(200, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(530, 440);
            this.NavigationPanel.TabIndex = 5;
            // 
            // btnUnblockApp
            // 
            this.btnUnblockApp.Location = new System.Drawing.Point(7, 216);
            this.btnUnblockApp.Name = "btnUnblockApp";
            this.btnUnblockApp.Size = new System.Drawing.Size(196, 23);
            this.btnUnblockApp.TabIndex = 3;
            this.btnUnblockApp.Text = "Unblock App";
            this.btnUnblockApp.UseVisualStyleBackColor = true;
            // 
            // btnAddBlockedApp
            // 
            this.btnAddBlockedApp.Location = new System.Drawing.Point(7, 187);
            this.btnAddBlockedApp.Name = "btnAddBlockedApp";
            this.btnAddBlockedApp.Size = new System.Drawing.Size(196, 23);
            this.btnAddBlockedApp.TabIndex = 2;
            this.btnAddBlockedApp.Text = "Block App";
            this.btnAddBlockedApp.UseVisualStyleBackColor = true;
            this.btnAddBlockedApp.Click += new System.EventHandler(this.btnAddBlockedApp_Click);
            // 
            // FormControlPanel
            // 
            this.FormControlPanel.Controls.Add(this.lblMinMaxForm);
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
            this.lblExit.Location = new System.Drawing.Point(509, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(21, 20);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // listBlockedApps
            // 
            this.listBlockedApps.FormattingEnabled = true;
            this.listBlockedApps.Location = new System.Drawing.Point(6, 33);
            this.listBlockedApps.Name = "listBlockedApps";
            this.listBlockedApps.Size = new System.Drawing.Size(197, 147);
            this.listBlockedApps.TabIndex = 1;
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
            // lblMinMaxForm
            // 
            this.lblMinMaxForm.AutoSize = true;
            this.lblMinMaxForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMinMaxForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinMaxForm.Location = new System.Drawing.Point(462, 0);
            this.lblMinMaxForm.Name = "lblMinMaxForm";
            this.lblMinMaxForm.Size = new System.Drawing.Size(31, 31);
            this.lblMinMaxForm.TabIndex = 2;
            this.lblMinMaxForm.Text = "□";
            this.lblMinMaxForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMinMaxForm.Click += new System.EventHandler(this.lblMaxMinForm_Click);
            // 
            // frmProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(730, 440);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.LogoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfiles";
            this.NavigationPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblMinMaxForm;
    }
}