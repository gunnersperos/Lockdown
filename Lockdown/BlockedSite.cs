using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lockdown
{
    public class BlockedSite
    {
        public string siteName { get; set; }
        public string url { get; set; }

        #region Constructors
        public BlockedSite()
        {
            this.siteName = string.Empty;
            this.url = string.Empty;
        }

        public BlockedSite(string url)
        {
            this.url = url;
            this.siteName = GetSiteName();
        }
        #endregion

        public string GetSiteName()
        {
            //gets the site name from the url
            string siteName = this.url;

            //update comment if this works
            char[] trimFront = { 'w', 'w', 'w', '.' };
            char[] trimBack = { '.', 'c', 'o', 'm' };

            //update comment if this works
            siteName.Trim(trimFront);
            siteName.Trim(trimBack);

            return siteName;
        }

        //public void SetPath(string path)
        //{
        //    this.appPath = path;
        //    this.appName = GetAppName();
        //}
    }
}
