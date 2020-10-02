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
        private bool _mouseDown = false;
        private const string BLOCKED_APPS_SCRIPT = @"C:\Users\Gunner\source\repos\Lockdown\Lockdown\Resources\Scripts\BlockList.ps1";
        public frmMain()
        {
            InitializeComponent();
            //this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        #region Resize Form (all of this is not working yet)
        //found this code in a YouTube video

        //



        private void lblResize_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            this.MouseMove += new MouseEventHandler(lblResize_MouseMove);
            //ResizeWindow(false);
            
        }

        private void lblResize_MouseMove(object sender, MouseEventArgs e)
        {
            Point currPos = MousePosition;
            this.Width = currPos.X - this.Location.X;
            this.Height = currPos.Y - this.Location.Y;
            

        }

        private void lblResize_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
            //ResizeWindow(true);
        }

        private void ResizeWindow(bool endLoop)
        {
            while (true)
            {
                Point currPos = MousePosition;
                this.Width = currPos.X - this.Location.X;
                this.Height = currPos.Y - this.Location.Y;
                if (endLoop)
                {
                    return;
                }
            }
        }



        #endregion

        #region Title Bar Controls
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lblMinimize_Click(object sender, EventArgs e)
        {
            //Minimizes the window
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblMaxMinForm_Click(object sender, EventArgs e)
        {
            //if form is maxed, make it normal, else, maximize it
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
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

        

        private void btnProfile_Click(object sender, EventArgs e)
        {
            try
            {
                frmProfiles profiles = new frmProfiles();
                profiles.Show();
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
    }
}
