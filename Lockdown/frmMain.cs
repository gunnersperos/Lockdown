using System;
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
        private const string BLOCKED_APPS_SCRIPT = @"C:\Users\Gunner\source\repos\Lockdown\Lockdown\Resources\Scripts\BlockList.ps1";
        public frmMain()
        {
            InitializeComponent();
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


        private void LogoImgBox_Click(object sender, EventArgs e)
        {
            //Starts default profile lock
            if (MessageBox.Show("Block this Profile's apps?", "Block Apps", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var runScript = new ProcessStartInfo()
                {
                    FileName = "powershell.exe",
                    Arguments = $"-NoProfile -ExecutionPolicy bypass -file \"{BLOCKED_APPS_SCRIPT}\"",
                    UseShellExecute = false
                };
                Process.Start(runScript);
            }
        }

        #region Navigation Buttons

        private void btnProfile_Click(object sender, EventArgs e)
        {
            try
            {
                frmProfiles profiles = new frmProfiles();
                profiles.Show();
                profiles.BringToFront();
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
        }

        private void btnReminders_Click(object sender, EventArgs e)
        {
            //Opens Reminders Form
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //Opens Settings Form
        }
        #endregion

        #region NotifyIcon
        private void MenuItemClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                this.BringToFront();
                //close all other open forms? or open active form?
            }
        }

        #endregion
    }
}
