﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lockdown
{
    public partial class frmMain : Form
    {
        private const string BLOCKED_APPS_SCRIPT = @"C:\Program Files\Scripts\BlockList.ps1";

        //Create instance of each form
        private frmProfiles profiles = new frmProfiles();
        private frmReminders reminders = new frmReminders();
        private frmScheduler scheduler = new frmScheduler();
        private frmSettings settings = new frmSettings();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Profiles profile = new Profiles();
            profile.CreateSaveFiles();
        }

        #region Title Bar Controls
        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void lblMinimize_Click(object sender, EventArgs e)
        {
            //Minimizes the window
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Run Lock
        

        private void LogoImgBox_Click(object sender, EventArgs e)
        {
            
        }

        private void BlockApps()
        {
            if (MessageBox.Show("Block this Profile's apps?", "Block Apps", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //
                var runScript = new ProcessStartInfo()
                {
                    FileName = "powershell.exe",
                    Arguments = $"-NoProfile -ExecutionPolicy bypass -file \"{BLOCKED_APPS_SCRIPT}\"",
                    UseShellExecute = false
                };
                Process.Start(runScript);
            }
        }

        #endregion

        #region Navigation Buttons

        private void btnProfile_Click(object sender, EventArgs e)
        {
            try
            {
                this.profiles.Show();
                this.profiles.BringToFront();
                this.profiles.pForm = this;
                this.Hide();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnScheduler_Click(object sender, EventArgs e)
        {
            //Opens Scheduler Form
            try
            {
                this.scheduler.pForm = this;
                this.scheduler.Show();
                this.scheduler.BringToFront();
                this.Hide();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnReminders_Click(object sender, EventArgs e)
        {
            //Opens Reminders Form
            try
            {
                this.reminders.pForm = this;
                this.reminders.Show();
                this.reminders.BringToFront();
                this.Hide();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //Opens Settings Form
            try
            {
                this.settings.pForm = this;
                this.settings.Show();
                this.settings.BringToFront();
                this.Hide();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region NotifyIcon
        private void MenuItemClose_Click(object sender, EventArgs e)
        {
            //how user quits the app
            Application.Exit();
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            //if clicked with left mouse
            if (e.Button == MouseButtons.Left)
            {
                //hide other forms and show main form
                this.Show();
                this.profiles.Hide();
                this.scheduler.Hide();
                this.reminders.Hide();
                this.settings.Hide();
            }
        }

        #endregion

        
    }
}
