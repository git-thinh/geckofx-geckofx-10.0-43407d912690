using Gecko;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeckoFxTest
{ 
    class MainClass
    {
        [STAThread]
        public static void Main(string[] args)
        {
            if (Directory.Exists(@"bin"))
            {
                Xpcom.Initialize(@"bin");
            }
            Application.ApplicationExit += (sender, e) =>
            {
                Xpcom.Shutdown();
            };

            //Gecko.GeckoPreferences["extensions.blocklist.enabled"] = false; 
            //GeckoPreferences.User["browser.xul.error_pages.enabled"] = true;
            //GeckoPreferences.User["media.navigator.enabled"] = true;
            //GeckoPreferences.User["media.navigator.permission.disabled"] = true; // enable Access to video & audio

            //Application.Idle += (s, e) => Console.WriteLine(SynchronizationContext.Current);
            Application.Run(new MyForm());
        }
    }
}
