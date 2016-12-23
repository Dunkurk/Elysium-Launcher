using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElysiumLaunhcer
{
    public partial class frmFirstTime : Form
    {
        private FolderBrowserDialog folderBrowserDialog1;
        string wowlocation;
        Launcher launcherIn;

        public frmFirstTime(Launcher theLauncher)
        {
            launcherIn = theLauncher;
            InitializeComponent();
            wowlocation = launcherIn.wowLocation;
        }

        private void frmFirstTime_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectLocation_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();

            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                string folderName = folderBrowserDialog1.SelectedPath;
                wowlocation = folderName;
                pnlRealmlist.Visible = true;
            }
            
           

            
        }

        private void btmEditRealmlist_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad", wowlocation + "\\realmlist.wtf");
        }

        private void btnRealmlistDefault_Click(object sender, EventArgs e)
        {
            string[] lines = { "set realmlist logon.elysium-project.org" };
            System.IO.File.WriteAllLines(@wowlocation+ "\\realmlist.wtf", lines);
            Launcher launcherOut = new Launcher("1",wowlocation);
            string[] SettingsLines = { "1", wowlocation, "EN" };
            System.IO.File.WriteAllLines(@"C:\Users\Public\Settings.txt", SettingsLines);
            Form1 formmain = new Form1(launcherOut);
            formmain.Show();
            this.Hide();
            
            
        }

        private void Form2_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            Application.Exit();
        }
    }
}
