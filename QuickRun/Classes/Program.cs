using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickRun.Classes
{
    static class Program
    {
        private const string CURRENT_USER_RUN = @"Software\Microsoft\Windows\CurrentVersion\Run";
        private const string QUICKRUN = @"QuickRun";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TrayIcon());
        }

        internal static bool AutoStart
        {
            get
            {
                string lReturn = null;

                using (RegistryKey lKey = Registry.CurrentUser.OpenSubKey(CURRENT_USER_RUN))
                {
                    lReturn = lKey.GetValue(QUICKRUN, "").ToString();
                }

                return (!string.IsNullOrEmpty(lReturn));
            }
            set
            {
                using (RegistryKey lKey = Registry.CurrentUser.OpenSubKey(CURRENT_USER_RUN, true))
                {
                    if (value)
                    { lKey.SetValue(QUICKRUN, Application.ExecutablePath, RegistryValueKind.String); }
                    else
                    {
                        if (lKey.GetValue(QUICKRUN) != null)
                            lKey.DeleteValue(QUICKRUN);
                    }
                }
            }
        }
    }
}
