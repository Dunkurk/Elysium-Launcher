using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElysiumLaunhcer
{
    public partial class Form1 : Form
    {
        public string wowLoc { get; set; }
        public Launcher launcherThis { get; set; }
        public Form1(Launcher launcherIn)
        {
            InitializeComponent();
            this.wowLoc = launcherIn.wowLocation;
            launcherThis = launcherIn;

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start(wowLoc+"\\wow.exe");

        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://elysium-project.org/");
                    }
        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            // Set text while the page has not yet loaded.
            this.Text = "Navigating";
        }

        private void webBrowser1_DocumentCompleted(object sender,
        WebBrowserDocumentCompletedEventArgs e)
        {
            // Better use the e parameter to get the url.
            // ... This makes the method more generic and reusable.
            this.Text = "Elysium Launcher";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://elysium-project.org/control"); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://elysium-project.org/play");
        }



     

       

        private void btnAddons_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @wowLoc.ToString()+"\\Interface\\AddOns");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form frmSettings = new frmSettings(launcherThis);
            frmSettings.Show();
        }
    }
}
