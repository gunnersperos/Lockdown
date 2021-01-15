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
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Lockdown
{
    public partial class frmProfiles : Form
    {
        private const string BLOCKED_APPS_SCRIPT = @"C:\Program Files\Lockdown\Scripts\BlockAppList.ps1";
        private const string BLOCKED_SITES_SCRIPT = @"C:\Program Files\Lockdown\Scripts\BlockSiteList.ps1";
        private const string PROFILES_LIST = @"C:\Program Files\Lockdown\Profiles\ProfilesList.txt";
        private const string BLOCKED_APP_LIST = @"C:\Program Files\Lockdown\Profiles\";
        private const string BLOCKED_SITES_LIST = @"C:\Program Files\Lockdown\Profiles\";
        public Form pForm;

        private Profiles _inUseProfile = new Profiles();
        public frmProfiles()
        {
            InitializeComponent();
            
        }

        private void frmProfiles_Load(object sender, EventArgs e)
        {
            //moving this to frmMain
            //Profiles profile = new Profiles();
            //profile.CreateSaveFiles();

            PopulateProfilesBox();
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


        #region Block Apps
        private string AddBlockedApp()
        {
            try
            {
                BlockedApp blockedApp = new BlockedApp();
                //open dialog box for user to pick an app to block
                openFileDialog1.InitialDirectory = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    blockedApp.SetPath(openFileDialog1.FileName);
                    //add blocked app to this profile's txt file
                    System.IO.File.AppendAllText(BLOCKED_APP_LIST + _inUseProfile.profileName + "BlockedApps.txt", blockedApp.appPath + "\n");
                }
                return blockedApp.appName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EXCEPTION");
                throw ex;
            }
        }

        private void BlockApps()
        {
            //block apps from selected profile's blocked app list

            //**(should use powershell directly instead of using script?)**\\
            //loop through blocked apps and run ps script for each one
            foreach (var app in _inUseProfile.blockedApps)
            {
                //overwrite ps script for each app
                System.IO.File.WriteAllText(BLOCKED_APPS_SCRIPT, "cd ~\nICACLS "
                    + "\"" + app + "\"" + " /deny Everyone:RX");

                //run ps script
                var runScript = new ProcessStartInfo()
                {
                    FileName = "powershell.exe",
                    Arguments = $"-NoProfile -ExecutionPolicy bypass -file \"{BLOCKED_APPS_SCRIPT}\"",
                    UseShellExecute = false
                };
                Process.Start(runScript);
            }
        }

        private void UnblockApps()
        {
            //unblocked previously blocked apps
            foreach (var app in _inUseProfile.blockedApps)
            {
                //overwrite ps script for each app
                System.IO.File.WriteAllText(BLOCKED_APPS_SCRIPT, "cd ~\nICACLS "
                    + "\"" + app + "\"" + " /grant Everyone:RX");
                //                                          ^ this is possibly an issue

                //run ps script
                var runScript = new ProcessStartInfo()
                {
                    FileName = "powershell.exe",
                    Arguments = $"-NoProfile -ExecutionPolicy bypass -file \"{BLOCKED_APPS_SCRIPT}\"",
                    UseShellExecute = false
                };
                Process.Start(runScript);
            }
        }

        private void btnAddBlockedApp_Click(object sender, EventArgs e)
        {
            listBlockedApps.Items.Add(AddBlockedApp());
            GetProfileData();
        }

        private void btnUnblockApp_Click(object sender, EventArgs e)
        {
            //Removes app from list
            //if (listBlockedApps.SelectedIndex > -1)
            //{
            //    listBlockedApps.Items.RemoveAt(listBlockedApps.SelectedIndex);
            //}
        }

        #endregion

        #region Block Websites

        private void BlockSites()
        {
            //loop through blocked sites and run ps script for each one
            foreach (var site in _inUseProfile.blockedWebsites)
            {
                //add site to hosts
                System.IO.File.AppendAllText(@"C:\Windows\System32\drivers\etc\hosts",
                    "127.0.0.1 " + site + ".com" + '\n'
                  + "127.0.0.1 www." + site + ".com" + "\n");
            }
        }

        private void UnblockSites()
        {
            System.IO.File.WriteAllText(BLOCKED_SITES_SCRIPT, "Function Unblock {" + '\n');
            foreach (var site in _inUseProfile.blockedWebsites)
            {
                //remove site from hosts
                System.IO.File.AppendAllText(BLOCKED_SITES_SCRIPT,
                  "$hosts = 'C:\\Windows\\System32\\drivers\\etc\\hosts'" + '\n'
                  + "$is_blocked = Get-Content -Path $hosts |" +'\n'
                  + "Select-String -Pattern([regex]::Escape(\"" + site + ".com\"))" +'\n'
                  + "If($is_blocked) {" + '\n'
                  + "$newhosts = Get-Content -Path $hosts |" +'\n'
                  + "Where-Object {" + '\n'
                  + "$_ -notmatch([regex]::Escape(\"" + site + ".com\"))" + '\n'
                  + "}" + '\n'
                  + "Where-Object {" + '\n'
                  + "$_ -notmatch([regex]::Escape(\"www." + site + ".com\"))" + '\n'
                  + "}" + '\n'
                  + "Set-Content -Path $hosts -Value $newhosts" + '\n'
                  + "}" + '\n'
                );
            }
            System.IO.File.AppendAllText(BLOCKED_SITES_SCRIPT,
                "}" + '\n'
                + "Unblock"
            );

            //run ps script
            var runScript = new ProcessStartInfo()
                {
                    FileName = "powershell.exe",
                    Arguments = $"-NoProfile -ExecutionPolicy bypass -file \"{BLOCKED_SITES_SCRIPT}\"",
                    UseShellExecute = false
                };
            Process.Start(runScript);
        }
        private string AddBlockedWebsites()
        {
            try
            {
                using (frmBlockWebsite addUrl = new frmBlockWebsite())
                {
                    var result = addUrl.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        string url = addUrl.url;
                        BlockedSite blockedSite = new BlockedSite(url);

                        //Add to selected profile's blocked site list
                        System.IO.File.AppendAllText(BLOCKED_SITES_LIST + _inUseProfile.profileName + "BlockedSites.txt", blockedSite.url + "\n");

                        return url;
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string UrlAdded(string url)
        {
            return url;
        }

        private void btnUnblockWebsite_Click(object sender, EventArgs e)
        {
            //Remove Website from list
            //if (listBlockedWebsites.SelectedIndex > -1)
            //{
            //    listBlockedWebsites.Items.RemoveAt(listBlockedWebsites.SelectedIndex);
            //}
        }

        private void btnAddBlockedWebsite_Click(object sender, EventArgs e)
        {
            //Adds website to list by refreshing profile
            AddBlockedWebsites();
            GetProfileData();
            //listBlockedWebsites.Items.Add(AddBlockedWebsites());
        }

        #endregion

        #region Events

        private void btnStartProfile_Click(object sender, EventArgs e)
        {
            //Runs script using the lists in the profile
            if (MessageBox.Show("Would you like to start this profile?",
                "Start Profile", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                StartProfile();
            }
        }

        private void btnStopProfile_Click(object sender, EventArgs e)
        {
            StopProfile();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.pForm.Show();
            this.Hide();
        }

        private void btnNewProfile_Click(object sender, EventArgs e)
        {
            //allows user to create a new profile

            //show create profile controls, hide the others //do this instead of using new form?
            ProfileButtonVisibleChange(true);
        }

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            // Create new profile if profile name isn't blank
            if (!string.IsNullOrWhiteSpace(txtNewProfile.Text))
            {
                Profiles newProfile = new Profiles();
                newProfile.CreateProfile(txtNewProfile.Text);
            }
            txtNewProfile.Text = string.Empty;
            ProfileButtonVisibleChange(false);
            PopulateProfilesBox();
        }

        private void btnCancelCreateProfile_Click(object sender, EventArgs e)
        {
            txtNewProfile.Text = string.Empty;
            ProfileButtonVisibleChange(false);
        }

        private void cbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //refresh listboxes
            GetProfileData();
            if ((string)cbProfiles.SelectedValue != string.Empty) // if actually choosing a profile
            {
                btnStartProfile.Visible = true;
                btnStopProfile.Visible = false;
                BlockedAppPanel.Visible = true;
                BlockedWebPanel.Visible = true;
            }
            else // choosing index 0
            {
                btnStartProfile.Visible = false;
                btnStopProfile.Visible = true;
                BlockedAppPanel.Visible = false;
                BlockedWebPanel.Visible = false;
            }
        }

        #endregion

        #region Methods

        private void StartProfile()
        {
            BlockApps();
            BlockSites();
            // disable everything that shouldn't be touched while profile is blocked
            // and enable the stop profile button obviously
            btnStartProfile.Visible = false;
            btnStopProfile.Visible = true;
            cbProfiles.Enabled = false;
            btnNewProfile.Enabled = false;// make this into a method probably since it is used 3 times im just so lazy
            BlockedAppPanel.Enabled = false;
            BlockedWebPanel.Enabled = false;
            panelLocked.Visible = true;
        }

        private void StopProfile()
        {
            UnblockApps();
            UnblockSites();
            // enable everything that shouldn't be touched while profile is not blocked
            // and enable the start profile button obviously
            btnStartProfile.Visible = true;
            btnStopProfile.Visible = false;
            cbProfiles.Enabled = true;
            btnNewProfile.Enabled = true;
            BlockedAppPanel.Enabled = true;
            BlockedWebPanel.Enabled = true;
            panelLocked.Visible = false;
        }

        public void PopulateProfilesBox()
        {
            string[] allProfiles = System.IO.File.ReadAllLines(PROFILES_LIST);
            cbProfiles.Items.Clear();
            foreach (var profile in allProfiles)
            {
                cbProfiles.Items.Add(profile);
            }
        }

        private void ProfileButtonVisibleChange(bool newProfile)
        {
            //flips the visibility when creating new profile or not
            lblNewProfile.Visible = newProfile;
            txtNewProfile.Visible = newProfile;
            btnCreateProfile.Visible = newProfile;
            btnCancelCreateProfile.Visible = newProfile;

            lblProfile.Visible = !newProfile;
            cbProfiles.Visible = !newProfile;
            btnNewProfile.Visible = !newProfile;
        }

        private void GetProfileData()
        {
            string currProfileName = cbProfiles.Text;
            if (currProfileName == string.Empty)
            {
                return; // if no profile return
            }
            this._inUseProfile.profileName = currProfileName;

            //find the right file for profile to get the blocked app list from
            this._inUseProfile.GetBlockedAppsList();

            // find the right file for profile to get the blocked site list from
            this._inUseProfile.GetBlockedSitesList();

            //populate blocked apps list control
            listBlockedApps.Items.Clear();
            foreach (var app in _inUseProfile.blockedApps)
            {
                listBlockedApps.Items.Add(GetAppName(app));
            }

            //populate blocked sites list control
            listBlockedWebsites.Items.Clear();
            foreach (var site in _inUseProfile.blockedWebsites)
            {
                listBlockedWebsites.Items.Add(GetSiteName(site));
            }
            
        }

        public string GetAppName(string appPath) //copied this from BlockedApp.cs
        {
            //gets the app name from the filepath
            string name = string.Empty;
            foreach (char character in appPath)
            {
                if (character == '.')
                {
                    return name;
                }
                name += character;
                if (character == '\\')
                {
                    name = string.Empty;
                }
            }
            return name;
        }

        public string GetSiteName(string url) //copied this from BlockedSite.cs
        {
            //let's just make them put facebook instead of facebook.com etc.
            return url.ToLower();

            // gdi. this works if putting www.example.com but not example.com
            //bool trimmingFront = true;
            //bool trimmingBack = true;
            //string name = string.Empty;
            //foreach (char character in url)
            //{
            //    if (trimmingFront && character == '.')
            //    {
            //        name = string.Empty;
            //        trimmingFront = false;
            //        continue;
            //    }
            //    if (character == '.')
            //    {
            //        return name;
            //    }
            //    name += character;
            //}


            //return name;


            ////gets the site name from the url
            //string siteName = url;

            ////update comment if this works
            //char[] trimFront1 = { 'h', 't', 't', 'p', 's', ':', '/', '/' };
            //char[] trimFront2 = { 'w', 'w', 'w', '.' };
            //char[] trimBack = { '.', 'c', 'o', 'm' };

            ////update comment if this works
            //siteName = siteName.Trim(trimFront1);
            //siteName = siteName.Trim(trimFront2);
            //siteName = siteName.Trim(trimBack);

            //return siteName;
        }

        #endregion


    }
}
