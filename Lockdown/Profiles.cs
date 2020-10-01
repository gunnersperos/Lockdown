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
        private string profileName { get; set; }
        private bool profileEnabled { get; set; }
        private List<string> blockedApps { get; set; }
        private List<string> blockedWebsites { get; set; }

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
    }
}
