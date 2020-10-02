using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lockdown
{
    public partial class frmProfiles : Form
    { 
        private const string BLOCKED_APPS_SCRIPT = "C:\\Users\\Gunner\\source\\repos\\Lockdown\\Lockdown\\Resources\\Scripts\\BlockList.ps1";
        public frmProfiles()
        {
            InitializeComponent();

            Profiles profile1 = new Profiles("Gunner", true, null, null);
            cbProfiles.Items.Add(profile1);
        }

        #region Title Bar Controls
        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            //Minimizes the window
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion


        private string AddBlockedApp()
        {
            try
            {
                BlockedApp blockedApp = new BlockedApp();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    blockedApp.SetPath(openFileDialog1.FileName);
                    using (StreamWriter sw = File.AppendText(BLOCKED_APPS_SCRIPT))
                    {
                        sw.WriteLine($"ICACLS \"{blockedApp.appPath}\" /deny Everyone:RX");
                    }
                }
                return blockedApp.appName;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAddBlockedApp_Click(object sender, EventArgs e)
        {
            listBlockedApps.Items.Add(AddBlockedApp());
        }

        private void btnUnblockApp_Click(object sender, EventArgs e)
        {
            //Removes app from list
            listBlockedApps.Items.RemoveAt(listBlockedApps.SelectedIndex);

        }

        private void btnUnblockWebsite_Click(object sender, EventArgs e)
        {
            //Removes website from list
        }

        private void btnAddBlockedWebsite_Click(object sender, EventArgs e)
        {
            //Adds website to list
        }

        private void btnStartProfile_Click(object sender, EventArgs e)
        {
            //Runs script using the lists in the profile
        }
    }
}
