﻿using System;
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
        private const string BLOCKED_APPS_SCRIPT = @"C:\Program Files\Lockdown\Scripts\BlockList.ps1";
        private const string PROFILES_LIST = @"C:\Program Files\Lockdown\Profiles\ProfilesList.txt";
        private const string BLOCKED_APP_LIST = @"C:\Program Files\Lockdown\Profiles\";
        public Form pForm;

        private Profiles _inUseProfile = new Profiles();
        public frmProfiles()
        {
            InitializeComponent();
            
        }

        private void frmProfiles_Load(object sender, EventArgs e)
        {
            Profiles profile = new Profiles();
            profile.CreateSaveFiles();

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

                    //using (StreamWriter sw = File.AppendText(BLOCKED_APPS_SCRIPT))
                    //{
                    //    sw.WriteLine($"ICACLS \"{blockedApp.appPath}\" /deny Everyone:RX");
                    //}
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
            if (listBlockedApps.SelectedIndex > -1)
            {
                listBlockedApps.Items.RemoveAt(listBlockedApps.SelectedIndex);
            }
        }

        #endregion

        #region Block Websites
        private void btnUnblockWebsite_Click(object sender, EventArgs e)
        {
            //Removes website from list
        }

        private void btnAddBlockedWebsite_Click(object sender, EventArgs e)
        {
            //Adds website to list
        }

        #endregion

        #region Events

        private void btnStartProfile_Click(object sender, EventArgs e)
        {
            //Runs script using the lists in the profile
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
        }

        #endregion

        #region Methods

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

            //populate blocked apps list control
            listBlockedApps.Items.Clear();
            foreach (var app in _inUseProfile.blockedApps)
            {
                listBlockedApps.Items.Add(GetAppName(app));
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

        #endregion

    }
}
