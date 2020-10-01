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

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string AddBlockedApp()
        {
            try
            {
                
                string blockedApp = string.Empty;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    blockedApp = openFileDialog1.FileName;
                    using (StreamWriter sw = File.AppendText(BLOCKED_APPS_SCRIPT))
                    {
                        sw.WriteLine($"ICACLS \"{blockedApp}\" /deny Everyone:RX");
                    }
                }
                return blockedApp;
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
    }
}
