using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lockdown
{
    static class Program
    {
        public static bool LaunchedByUser { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Program.LaunchedByUser = args != null && args.Any(arg => arg.Equals("userStartup", StringComparison.CurrentCultureIgnoreCase));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTabbed());
        }
    }
}
