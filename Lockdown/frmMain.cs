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

        private void exitLabelClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            //Minimizes the window
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
    }
}
