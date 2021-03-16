using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lockdown
{
    public partial class frmTabbed : Form
    {
        public frmTabbed()
        {
            InitializeComponent();
            //MessageBox.Show(this, string.Format("Launched via userStartup arg: {0}", Program.LaunchedByUser));

            //make sure to create files and directories if first time running app
            Profiles profile = new Profiles();
            profile.CreateSaveFiles();

            //Profiles
            PopulateProfilesBox();

            //Reminders
            UpdateMyRemindersList();
            StartReminders();

            //Add Reminder
            PopulateAddReminderDropdowns();

            //SCHEDULER LOCKDOWN
            LockdownOnStartup();


            isLoading = false;
        }

        #region Navigation

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            tablessControl.SelectedIndex = 0; //back button takes you to main page
        }

        private void btnProfiles_Click(object sender, EventArgs e)
        {
            tablessControl.SelectedTab = tabProfiles;
        }

        private void btnNewProfile_Click(object sender, EventArgs e)
        {
            tablessControl.SelectedTab = tabAddProfile;
        }

        private void btnReminders_Click(object sender, EventArgs e)
        {
            tablessControl.SelectedTab = tabReminders;
        }

        private void lblAddReminder_Click(object sender, EventArgs e)
        {
            tablessControl.SelectedTab = tabAddReminder;
        }

        private void btnScheduler_Click(object sender, EventArgs e)
        {
            tablessControl.SelectedTab = tabScheduler;
        }

        private void calendarScheduler_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateStart.Value = calendarScheduler.SelectionStart;
            dateEnd.Value = calendarScheduler.SelectionEnd;
            tablessControl.SelectedTab = tabSetSchedule;
        }

        private void tablessControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hide back button if already on main page
            if (tablessControl.SelectedIndex == 0)
            {
                lblBack.Visible = false;
            }
            else
            {
                lblBack.Visible = true;
            }
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            //if clicked with left mouse
            if (e.Button == MouseButtons.Left)
            {
                //Show main form
                this.Show();
            }
        }

        private void MenuItemClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Profiles

        private const string BLOCKED_APPS_SCRIPT = @"C:\Program Files\Lockdown\Scripts\BlockAppList.ps1";
        private const string BLOCKED_SITES_SCRIPT = @"C:\Program Files\Lockdown\Scripts\BlockSiteList.ps1";
        private const string PROFILES_LIST = @"C:\Program Files\Lockdown\Profiles\ProfilesList.txt";
        private const string BLOCKED_APP_LIST = @"C:\Program Files\Lockdown\Profiles\";
        private const string BLOCKED_SITES_LIST = @"C:\Program Files\Lockdown\Profiles\";

        private Profiles _inUseProfile = new Profiles();

        //METHODS\\
        public void PopulateProfilesBox()
        {
            string[] allProfiles = System.IO.File.ReadAllLines(PROFILES_LIST);
            cbProfiles.Items.Clear();
            foreach (var profile in allProfiles)
            {
                cbProfiles.Items.Add(profile);
            }
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
        }

        private string AddBlockedApp()
        {
            try
            {
                BlockedApp blockedApp = new BlockedApp();
                //open dialog box for user to pick an app to block
                ofdAddApp.InitialDirectory = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
                if (ofdAddApp.ShowDialog() == DialogResult.OK)
                {
                    blockedApp.SetPath(ofdAddApp.FileName);
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

        private void RemoveBlockedApp(int appIndex)
        {
            //odd way of doing this but
            //reads in all lines of current profile's blocked app list
            //then overwriters it without the selected item of the blocked app list
            //then updates profile
            string[] blockedApps = System.IO.File.ReadAllLines(BLOCKED_APP_LIST + _inUseProfile.profileName + "BlockedApps.txt");
            using(System.IO.StreamWriter file = new System.IO.StreamWriter(BLOCKED_APP_LIST + _inUseProfile.profileName + "BlockedApps.txt"))
            {
                for (int i = 0; i < appIndex; i++)
                {
                    if (i != appIndex)
                    {
                        file.WriteLine(blockedApps[i]);
                    }
                }
            }
            GetProfileData();
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

        private void RemoveBlockedSite(int siteIndex)
        {
            //odd way of doing this but
            //reads in all lines of current profile's blocked site list
            //then overwriters it without the selected item of the blocked site list
            //then updates profile
            string[] blockedSites = System.IO.File.ReadAllLines(BLOCKED_SITES_LIST + _inUseProfile.profileName + "BlockedSites.txt");
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(BLOCKED_SITES_LIST + _inUseProfile.profileName + "BlockedSites.txt"))
            {
                for (int i = 0; i < siteIndex; i++)
                {
                    if (i != siteIndex)
                    {
                        file.WriteLine(blockedSites[i]);
                    }
                }
            }
            GetProfileData();
        }

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
                    Arguments = $"-window minimized -NoProfile -ExecutionPolicy bypass -file \"{BLOCKED_APPS_SCRIPT}\"",
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
                    Arguments = $"-window minimize -NoProfile -ExecutionPolicy bypass -file \"{BLOCKED_APPS_SCRIPT}\"",
                    UseShellExecute = false
                };
                Process.Start(runScript);
            }
        }

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
                  + "$is_blocked = Get-Content -Path $hosts |" + '\n'
                  + "Select-String -Pattern([regex]::Escape(\"" + site + ".com\"))" + '\n'
                  + "If($is_blocked) {" + '\n'
                  + "$newhosts = Get-Content -Path $hosts |" + '\n'
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
                Arguments = $"-window minimize -NoProfile -ExecutionPolicy bypass -file \"{BLOCKED_SITES_SCRIPT}\"",
                UseShellExecute = false
            };
            Process.Start(runScript);
        }

        //EVENTS\\
        private void cbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProfileData();
            if ((string)cbProfiles.SelectedValue != string.Empty) // if actually choosing a profile
            {
                btnStartProfile.Visible = true;
                btnStopProfile.Visible = false;
                BlockedAppPanel.Visible = true;
                BlockedWebPanel.Visible = true;

                //let user use scheduler
                panelChooseProfile.Visible = false;
            }
            else // choosing index 0
            {
                btnStartProfile.Visible = false;
                btnStopProfile.Visible = true;
                BlockedAppPanel.Visible = false;
                BlockedWebPanel.Visible = false;

                //block scheduler when no profile is selected
                panelChooseProfile.Visible = true;
            }
        }

        private void btnAddBlockedApp_Click(object sender, EventArgs e)
        {
            listBlockedApps.Items.Add(AddBlockedApp());
            GetProfileData();
        }

        private void btnAddBlockedWebsite_Click(object sender, EventArgs e)
        {
            AddBlockedWebsites();
            GetProfileData();
        }

        private void btnStartProfile_Click(object sender, EventArgs e)
        {
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

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            // Create new profile if profile name isn't blank
            if (!string.IsNullOrWhiteSpace(txtNewProfile.Text))
            {
                Profiles newProfile = new Profiles();
                newProfile.CreateProfile(txtNewProfile.Text);
            }
            txtNewProfile.Text = string.Empty;
            PopulateProfilesBox();
            tablessControl.SelectedTab = tabProfiles;
        }

        private void btnCancelCreateProfile_Click(object sender, EventArgs e)
        {
            txtNewProfile.Text = string.Empty;
            tablessControl.SelectedTab = tabProfiles;
        }

        private void btnUnblockApp_Click(object sender, EventArgs e)
        {
            if (listBlockedApps.SelectedIndex < 0)
            {
                return;
            }
            RemoveBlockedApp(listBlockedApps.SelectedIndex);
        }

        private void btnUnblockWebsite_Click(object sender, EventArgs e)
        {
            if (listBlockedWebsites.SelectedIndex < 0)
            {
                return;
            }
            RemoveBlockedSite(listBlockedWebsites.SelectedIndex);
        }



        #endregion

        #region Reminders

        private bool isLoading = true;
        private bool isListClicked = false;
        private List<Reminder> _defaultReminders = new List<Reminder>();
        public List<Reminder> _myReminders = new List<Reminder>();
        private const string REMINDERS_FILE_PATH = @"C:\Program Files\Lockdown\Reminders\Reminders.json";

        //METHODS\\
        public void UpdateMyRemindersList()
        {
            LoadMyReminders();
            clbMyReminders.Items.Clear();
            foreach (var reminder in _myReminders)
            {
                clbMyReminders.Items.Add(reminder.name);
            }

            //annoyingly long amount of code to make sure reminder checkstate is correct
            int reminderListCount = clbMyReminders.Items.Count;
            for (int i = 0; i < reminderListCount; i++)
            {
                clbMyReminders.SetItemCheckState(i, BoolToCheckState(_myReminders[i].isReminderOn));
            }
        }

        private void LoadMyReminders()
        {
            _myReminders.Clear();
            string[] jsonArray = System.IO.File.ReadAllLines(REMINDERS_FILE_PATH);
            foreach (var line in jsonArray)
            {
                Reminder tempReminder = JsonSerializer.Deserialize<Reminder>(line);
                _myReminders.Add(tempReminder);
            }
        }

        private void StartReminders()
        {
            foreach (var reminder in _myReminders)
            {
                if (reminder.isReminderOn)
                {
                    reminder.ReminderTimer();
                }
            }
        }

        private void UpdateReminderOnOff(int reminderIndex, CheckState reminderSwitch)
        {
            //changes the reminder object enabled field then updates the clbMyReminders
            _myReminders[reminderIndex].isReminderOn = CheckStateToBool(reminderSwitch);
            //need to save over the reminders file
            List<string> jsonStringArray = new List<string>();
            System.IO.File.WriteAllText(REMINDERS_FILE_PATH, string.Empty);
            foreach (var reminder in _myReminders)
            {
                string jsonString = JsonSerializer.Serialize(reminder);
                jsonStringArray.Add(jsonString);
            }
            foreach (var jsonString in jsonStringArray)
            {
                System.IO.File.AppendAllText(REMINDERS_FILE_PATH, jsonString + '\n');
            }
        }

        private bool CheckStateToBool(CheckState checkState)
        {
            // just converting CheckState object to bool
            bool onOff = checkState is CheckState.Checked ? true : false;
            return onOff;
        }

        private CheckState BoolToCheckState(bool checkState)
        {
            // just converting bool object to CheckState
            CheckState onOff = checkState is true ? CheckState.Checked : CheckState.Unchecked;
            return onOff;
        }

        //EVENTS\\

        private void clbMyReminders_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (isLoading || !isListClicked)
            {
                return; // don't want to double do this when loading the app or checkstate not actually changing
            }
            UpdateReminderOnOff(e.Index, e.NewValue);
            _myReminders[e.Index].StartStopReminder(e.NewValue);
            isListClicked = false;
        }

        private void clbMyReminders_Click(object sender, EventArgs e)
        {
            this.isListClicked = true;
        }

        private void clbMyReminders_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.isListClicked = false;
        }

        #endregion

        #region Add Reminder

        //METHODS\\
        private void AddReminder()
        {
            //set all properties
            Reminder newReminder = new Reminder();
            newReminder.name = txtNewReminderName.Text;
            newReminder.isReminderOn = false;
            newReminder.remindInterval = (cboHowOften.SelectedIndex + 1); // index 1 is 15 minutes. do the math
            //newReminder.reminderType = 0;// cboType.SelectedValue;

            // Save to JSON
            string jsonString = JsonSerializer.Serialize(newReminder);
            System.IO.File.AppendAllText(REMINDERS_FILE_PATH, jsonString + '\n');

        }

        private void PopulateAddReminderDropdowns()
        {
            //How Often Dropdown

            //1 minute increments
            for (int i = 1; i < 60; i += 1)
            {
                cboHowOften.Items.Add(i + " minutes");
            }
            for (int j = 60; j < 120; j += 1)
            {
                if (j > 60)
                {
                    cboHowOften.Items.Add("1 hour " + (j - 60) + " minutes");
                }
                else
                {
                    cboHowOften.Items.Add("1 hour");
                }
            }
            cboHowOften.Items.Add("2 hours");

            // 15 minute increments
            //for (int i = 15; i <= 240; i += 15)
            //{
            //    if (i < 60)
            //    {
            //        cboHowOften.Items.Add(i + " minutes");
            //    }
            //    else
            //    {
            //        int hours = (i / 60);
            //        int minutes = i - (hours * 60);
            //        if (minutes == 0)
            //        {
            //            cboHowOften.Items.Add(hours + " hour(s)");
            //        }
            //        else
            //        {
            //            cboHowOften.Items.Add(hours + " hour(s) " + minutes + " minutes");
            //        }
            //    }
            //}
        }

        //EVENTS\\

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tablessControl.SelectedTab = tabReminders;
            txtNewReminderName.Text = string.Empty;
            cboHowOften.SelectedIndex = -1;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddReminder();
            UpdateMyRemindersList();
            tablessControl.SelectedTab = tabReminders;
            txtNewReminderName.Text = string.Empty;
            cboHowOften.SelectedIndex = -1;
            
        }



        #endregion

        #region Scheduler

        private const string SCHEDULER_FILE_PATH = @"C:\Program Files\Lockdown\Scheduler\Scheduler.json";

        // METHODS \\
        private void SetSchedule()
        {
            //set all properties
            Scheduler setSchedule = new Scheduler();
            setSchedule.profile = cbProfiles.Text;
            setSchedule.dateStart = dateStart.Value;
            //setSchedule.dateEnd = dateEnd.Value;
            setSchedule.timeStart = timeStart.Value;
            //setSchedule.timeEnd = timeEnd.Value;

            //Save to JSON
            string jsonString = JsonSerializer.Serialize(setSchedule);
            System.IO.File.WriteAllText(SCHEDULER_FILE_PATH, jsonString + '\n');

            //Writing to ps1 file
            setSchedule.ScheduleTask();
        }

        private void LockdownOnStartup()
        {
            //IF BEING STARTED BY USER, DONT RUN
            //IF BEING STARTED BY TASK SCHEDULER, ARGUMENT IS FALSE SO LOCK PROFILE
            if (!Program.LaunchedByUser)
            {
                string[] jsonArray = System.IO.File.ReadAllLines(SCHEDULER_FILE_PATH);
                Scheduler setSchedule = JsonSerializer.Deserialize<Scheduler>(jsonArray[0]);
                cbProfiles.Text = setSchedule.profile;
                GetProfileData();
                StartProfile();
            }
        }

        // EVENTS \\
        private void btnCancelSetSchedule_Click(object sender, EventArgs e)
        {
            tablessControl.SelectedTab = tabScheduler;
        }

        private void btnSaveSetSchedule_Click(object sender, EventArgs e)
        {
            SetSchedule();
            tablessControl.SelectedTab = tabScheduler;
        }

        private void btnDeleteSchedule_Click(object sender, EventArgs e)
        {
            //should have a confrimaton here but lapotop almst dead
            Scheduler deleteSchedule = new Scheduler();
            deleteSchedule.DeleteTaskSchedule();
        }


        #endregion


    }
}
