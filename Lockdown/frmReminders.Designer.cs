namespace Lockdown
{
    partial class frmReminders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReminders));
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.FormControlPanel = new System.Windows.Forms.Panel();
            this.lblReminders = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.lblMyReminders = new System.Windows.Forms.Label();
            this.lblDefaultReminders = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAddReminder = new System.Windows.Forms.Label();
            this.clbMyReminders = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clbDefault = new System.Windows.Forms.CheckedListBox();
            this.LogoImgBox = new System.Windows.Forms.PictureBox();
            this.LogoPanel.SuspendLayout();
            this.FormControlPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // FormControlPanel
            // 
            this.FormControlPanel.Controls.Add(this.lblReminders);
            this.FormControlPanel.Controls.Add(this.lblBack);
            this.FormControlPanel.Controls.Add(this.lblMinimize);
            this.FormControlPanel.Controls.Add(this.lblExit);
            this.FormControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormControlPanel.Location = new System.Drawing.Point(200, 0);
            this.FormControlPanel.Name = "FormControlPanel";
            this.FormControlPanel.Size = new System.Drawing.Size(530, 29);
            this.FormControlPanel.TabIndex = 1;
            // 
            // lblReminders
            // 
            this.lblReminders.AutoSize = true;
            this.lblReminders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReminders.Location = new System.Drawing.Point(211, 2);
            this.lblReminders.Name = "lblReminders";
            this.lblReminders.Size = new System.Drawing.Size(102, 24);
            this.lblReminders.TabIndex = 0;
            this.lblReminders.Text = "Reminders";
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
            this.ContentPanel.Controls.Add(this.lblMyReminders);
            this.ContentPanel.Controls.Add(this.lblDefaultReminders);
            this.ContentPanel.Controls.Add(this.panel2);
            this.ContentPanel.Controls.Add(this.panel1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(200, 29);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(530, 411);
            this.ContentPanel.TabIndex = 2;
            // 
            // lblMyReminders
            // 
            this.lblMyReminders.AutoSize = true;
            this.lblMyReminders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyReminders.Location = new System.Drawing.Point(315, 3);
            this.lblMyReminders.Name = "lblMyReminders";
            this.lblMyReminders.Size = new System.Drawing.Size(153, 26);
            this.lblMyReminders.TabIndex = 3;
            this.lblMyReminders.Text = "My Reminders";
            // 
            // lblDefaultReminders
            // 
            this.lblDefaultReminders.AutoSize = true;
            this.lblDefaultReminders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultReminders.Location = new System.Drawing.Point(35, 3);
            this.lblDefaultReminders.Name = "lblDefaultReminders";
            this.lblDefaultReminders.Size = new System.Drawing.Size(193, 26);
            this.lblDefaultReminders.TabIndex = 2;
            this.lblDefaultReminders.Text = "Default Reminders";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblAddReminder);
            this.panel2.Controls.Add(this.clbMyReminders);
            this.panel2.Location = new System.Drawing.Point(276, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 280);
            this.panel2.TabIndex = 1;
            // 
            // lblAddReminder
            // 
            this.lblAddReminder.AutoSize = true;
            this.lblAddReminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblAddReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddReminder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.lblAddReminder.Location = new System.Drawing.Point(217, 242);
            this.lblAddReminder.Name = "lblAddReminder";
            this.lblAddReminder.Size = new System.Drawing.Size(25, 26);
            this.lblAddReminder.TabIndex = 2;
            this.lblAddReminder.Text = "+";
            this.lblAddReminder.Click += new System.EventHandler(this.lblAddReminder_Click);
            // 
            // clbMyReminders
            // 
            this.clbMyReminders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.clbMyReminders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.clbMyReminders.FormattingEnabled = true;
            this.clbMyReminders.Location = new System.Drawing.Point(4, 3);
            this.clbMyReminders.Name = "clbMyReminders";
            this.clbMyReminders.Size = new System.Drawing.Size(243, 274);
            this.clbMyReminders.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clbDefault);
            this.panel1.Location = new System.Drawing.Point(5, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 280);
            this.panel1.TabIndex = 0;
            // 
            // clbDefault
            // 
            this.clbDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.clbDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.clbDefault.FormattingEnabled = true;
            this.clbDefault.Location = new System.Drawing.Point(4, 4);
            this.clbDefault.Name = "clbDefault";
            this.clbDefault.Size = new System.Drawing.Size(243, 274);
            this.clbDefault.TabIndex = 0;
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
            // frmReminders
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(730, 440);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.FormControlPanel);
            this.Controls.Add(this.LogoPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(730, 440);
            this.Name = "frmReminders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lockdown";
            this.LogoPanel.ResumeLayout(false);
            this.FormControlPanel.ResumeLayout(false);
            this.FormControlPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox LogoImgBox;
        private System.Windows.Forms.Panel FormControlPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblReminders;
        private System.Windows.Forms.Label lblMyReminders;
        private System.Windows.Forms.Label lblDefaultReminders;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox clbMyReminders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox clbDefault;
        private System.Windows.Forms.Label lblAddReminder;
    }
}