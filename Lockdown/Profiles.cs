using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lockdown
{
    public class Profiles
    {
        #region Class Members
        //private members for Profiles Class
        public string profileName { get; set; }
        private bool profileEnabled { get; set; }
        public List<string> blockedApps { get; set; }
        public List<string> blockedWebsites { get; set; }

        #endregion

        #region Constructors

        //Empty Constructor
        public Profiles()
        {
            this.profileName = string.Empty;
            this.profileEnabled = false;
            this.blockedApps = new List<string>();
            this.blockedWebsites = new List<string>();
        }

        //override constructor - all fields
        public Profiles(string pName, bool pEnabled, List<string> bApps, List<string> bWebsites)
        {
            this.profileName = pName;
            this.profileEnabled = pEnabled;
            this.blockedApps = bApps;
            this.blockedWebsites = bWebsites;
        }

        #endregion

        #region Methods

        public void CreateSaveFiles()
        {
            //if user doesn't already have directories and files for saving, create them

            // **General Lockdown Directory** \\
            if (System.IO.Directory.Exists(@"C:\Program Files\Lockdown"))
            {
                //return; //dont need to run rest of method if these all already exist
            }
            else
            {
                System.IO.Directory.CreateDirectory(@"C:\Program Files\Lockdown");
            }

            // **Reminders Directory and Files** \\
            List<string> reminderFiles = new List<string>
                {
                "isReminderOn.txt",
                "Reminders.txt",
                "reminderType.txt",
                "remindInterval.txt",
                "repeatInterval.txt"
                };
            if (!System.IO.Directory.Exists(@"C:\Program Files\Lockdown\Reminders"))
            {
                System.IO.Directory.CreateDirectory(@"C:\Program Files\Lockdown\Reminders");
                // testing out JSON
                System.IO.File.WriteAllText(@"C:\Program Files\Lockdown\Reminders\Reminders.json", string.Empty);

                //if (reminderFiles != System.IO.Directory.GetFiles(@"C:\Program Files\Lockdown\Reminders").ToList<string>())//this probably wont work right
                //{
                //    foreach (var file in reminderFiles)
                //    {
                //        System.IO.File.WriteAllText(@"C:\Program Files\Lockdown\Reminders\" + file, string.Empty);
                //    }
                //}
            }

            // **Create Profiles Name List** \\
            if (!System.IO.Directory.Exists(@"C:\Program Files\Lockdown\Profiles"))
            {
                System.IO.Directory.CreateDirectory(@"C:\Program Files\Lockdown\Profiles");
                System.IO.File.WriteAllText(@"C:\Program Files\Lockdown\Profiles\ProfilesList.txt", string.Empty);
            }

            // **Scripts** \\
            List<string> scriptFiles = new List<string>
                {
                "BlockAppList.ps1",
                "BlockSiteList.ps1"
                };
            if (!System.IO.Directory.Exists(@"C:\Program Files\Lockdown\Scripts"))
            {
                System.IO.Directory.CreateDirectory(@"C:\Program Files\Lockdown\Scripts");
                //assume if directory doesn't exist neither do files?
                foreach (var file in scriptFiles)
                {
                    System.IO.File.WriteAllText(@"C:\Program Files\Lockdown\Scripts\" + file, string.Empty);
                }
                //Write initial commands in BlockAppList.ps1
                System.IO.File.WriteAllText(@"C:\Program Files\Lockdown\Scripts\BlockAppList.ps1", string.Empty);
            }
        }

        public void CreateProfile(string profileName)
        {
            if (!System.IO.Directory.Exists(@"C:\Program Files\Lockdown\Profiles"))
            {
                System.IO.Directory.CreateDirectory(@"C:\Program Files\Lockdown\Profiles");
            }
            if (System.IO.Directory.Exists(@"C:\Program Files\Lockdown\Profiles"))
            {
                //create the files for the new profile, 
                System.IO.File.WriteAllText(@"C:\Program Files\Lockdown\Profiles\" + profileName + "BlockedApps.txt", string.Empty);
                System.IO.File.WriteAllText(@"C:\Program Files\Lockdown\Profiles\" + profileName + "BlockedSites.txt", string.Empty);

                //add new profile to profiles list file
                System.IO.File.AppendAllText(@"C:\Program Files\Lockdown\Profiles\ProfilesList.txt", profileName + "\n");
            }
        }

        public void GetBlockedAppsList()
        {
            string[] appsArray = System.IO.File.ReadAllLines(@"C:\Program Files\Lockdown\Profiles\" + profileName + "BlockedApps.txt");
            this.blockedApps = appsArray.ToList<string>();
        }

        public void GetBlockedSitesList()
        {
            string[] sitesArray = System.IO.File.ReadAllLines(@"C:\Program Files\Lockdown\Profiles\" + profileName + "BlockedSites.txt");
            this.blockedWebsites = sitesArray.ToList<string>();
        }

        #endregion
    }
}
