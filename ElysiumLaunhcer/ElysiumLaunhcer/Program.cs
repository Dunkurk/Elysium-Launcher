using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElysiumLaunhcer
{
    static class Program
    {
       

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists(@"C:\Users\Public\Settings.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Public\Settings.txt");
                if (lines[0] == "1")
                {
                    Launcher theLauncher = new Launcher(lines[0], lines[1]);
                    Application.Run(new Form1(theLauncher));
                }
                else if (lines[0] == "0")
                {
                    Launcher theLauncher = new Launcher(lines[0], lines[1]);
                    Application.Run(new frmFirstTime(theLauncher));
                }
            }
            else
            {
                string[] lines = { "0", "NA", "EN" };
                System.IO.File.WriteAllLines(@"C:\Users\Public\Settings.txt", lines);
                Launcher theLauncher = new Launcher(lines[0], lines[1]);
                Application.Run(new frmFirstTime(theLauncher));
            }

         
        }
    }
}
