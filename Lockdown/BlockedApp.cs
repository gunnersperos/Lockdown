using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lockdown
{
    public class BlockedApp
    {
        public string appName { get; set; }
        public string appPath { get; set; }

        public BlockedApp()
        {
            this.appName = string.Empty;
            this.appPath = string.Empty;
        }

        public BlockedApp(string path)
        {
            this.appPath = path;
            this.appName = GetAppName();
        }

        public string GetAppName()
        {
            //gets the app name from the filepath
            string name = string.Empty;
            foreach (char character in this.appPath)
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

        public void SetPath(string path)
        {
            this.appPath = path;
            this.appName = GetAppName();
        }
    }
}
