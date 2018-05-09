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

            //Application.Idle += (s, e) => Console.WriteLine(SynchronizationContext.Current);
            Application.Run(new MyForm());
        }
    }
}
