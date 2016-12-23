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
    public partial class frmSettings : Form
    {
        public Launcher launcherThis { get; set; }
        public String[] lines { get; set; }
        public frmSettings(Launcher launcherIn)
        {
            launcherThis = launcherIn;
            InitializeComponent();
            string[] realmlists = System.IO.File.ReadAllLines(launcherThis.wowLocation + "\\Realmlist.wtf");
            cbRealms.Text = realmlists[0];
            if (File.Exists(launcherThis.wowLocation + "\\WTF\\Config.wtf"))
            {
                string[] lines = System.IO.File.ReadAllLines(@launcherThis.wowLocation + "\\WTF\\Config.wtf");
                if (lines[30] == "SET gxWindow \"1\"")
                {
                    chkWindow.Checked = true;
                    if (lines[31] == "SET gxMaximize \"1\"")
                    {
                        chkMaxim.Checked = true;
                    }

                  
               


                }
                else
                {
                    pnlMax.Hide();
                }

            }
            else
            {
                string[] lines = { "SET hwDetect \"0\"",
                    "SET gxColorBits \"24\"",
                    "SET gxDepthBits \"24\"",
                    "SET gxResolution \"1920x1080\"",
                    "SET gxRefresh \"60\"",
                    "SET gxMultisample \"8\"",
                    "SET gxMultisampleQuality \"0.000000\"",
                    "SET gxFixLag \"0\"",
                    "SET fullAlpha \"1\"",
                    "SET lodDist \"250\"",
                    "SET SmallCull \"0.01\"",
                    "SET trilinear \"1\"",
                    "SET frillDensity \"256\"",
                    "SET farclip \"700\"",
                    "SET specular \"1\"",
                    "SET pixelShaders \"1\"",
                    "SET particleDensity \"1\"",
                    "SET unitDrawDist \"300\"",
                    "SET accountName \"Test\"",
                    "SET movie \"0\"",
                    "SET Gamma \"1.000000\"",
                    "SET readTOS \"1\"",
                    "SET readEULA \"1\"",
                    "SET MusicVolume \"0.40000000596046\"",
                    "SET SoundVolume \"1\"",
                    "SET MasterVolume \"1\"",
                    "SET realmList \"logon.elysium-project.org\"",
                    "SET realmName \"Nostalrius PvP\"",
                    "SET gameTip \"3\"",
                    "SET AmbienceVolume \"0.60000002384186\"",
                    "SET uiScale \"1\"",
                    "SET gxWindow \"1\"",
                    "SET gxMaximize \"1\"",
                    "SET DesktopGamma \"1\"",
                    "SET anisotropic \"16\"",
                    "SET detailDoodadAlpha \"100\"",
                    "SET lod \"0\"",
                    "SET mapObjLightLOD \"2\"",
                    "SET maxLOD \"3\"",
                    "SET nearClip \"0.33\"",
                    "SET shadowLevel \"0\"",
                    "SET SkyCloudLOD \"1\"",
                    "SET SkySunGlare \"1\"",
                    "SET textureLodDist \"777\"",
                    "SET texLodBias \"-1\"",
                    "SET weatherDensity \"3\"",
                    "SET waterParticulates \"1\"",
                    "SET waterRipples \"1\"",
                    "SET waterSpecular \"1\"",
                    "SET waterWaves \"1\"",
                    "SET showShadow \"1\"",
                    "SET showLowDetail \"0\"",
                    "SET showSimpleDoodads \"0\"",
                    "SET gxTripleBuffer \"1\"",
                    "SET M2UsePixelShaders \"1\"",
                                    };
                cbResolution.Text = lines[3];
                System.IO.File.WriteAllLines(@launcherThis.wowLocation + "\\WTF\\Config.wtf", lines);

            }




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@launcherThis.wowLocation + "\\WTF\\Config.wtf");
            if (cbResolution.Text == "1920x1080")
            {
                string resolution = "SET gxResolution \"1920x1080\"";

                lines[3] = resolution;
            }  else if (cbResolution.Text == "1024x768") {
                string resolution = "SET gxResolution \"1024x768\"";
                lines[3] = resolution;
            }
            
            System.IO.File.WriteAllLines(@launcherThis.wowLocation + "\\WTF\\Config.wtf", lines);
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@launcherThis.wowLocation + "\\WTF\\Config.wtf");
            if (lines[3] == "SET gxResolution \"1024x768\"")
            {
                cbResolution.SelectedText = "1024x768";
            } else if (lines[3]== "SET gxResolution \"1920x1080\"")
            {
                cbResolution.SelectedText = "1920x1080";
            }

           if(lines[30]== "SET gxWindow \"1\"")
            {
                chkWindow.Checked = true;
                if (lines[31] == "SET gxMaximize \"1\"")
                {
                    chkMaxim.Checked = true;
                }
                else
                {
                    chkMaxim.Checked = false;
                }
            }else
            {
                chkWindow.Checked = false;
            }

            cbResolution.Items.Add("1920x1080");
            cbResolution.Items.Add("1024x768");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void chkWindow_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkWindow.Checked == true)
            {
                pnlMax.Show();
            }
            else
            {
                chkMaxim.Checked = false;
                pnlMax.Hide();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@launcherThis.wowLocation + "\\WTF\\Config.wtf");
            if (cbResolution.Text == "1920x1080") 
            {
                lines[3] = "SET gxResolution \"1920x1080\"";
            }else if (cbResolution.Text == "1024x768")
            {
                lines[3] = "SET gxResolution \"1024x768\"";
            }

            //check for windows setting
            if(chkWindow.Checked== true)
            {
                lines[30] = "SET gxWindow \"1\"";
                if (chkMaxim.Checked == true)
                {
                    lines[31] = "SET gxMaximize \"1\"";
                }
                else if(chkMaxim.Checked == false)
                {
                    lines[31] = "SET gxMaximize \"0\"";
                }

            }
            else if(chkWindow.Checked == false){
                lines[30] = "SET gxWindow \"0\"";
                lines[31] = "SET gxMaximize \"0\"";
            }
            System.IO.File.WriteAllLines(@launcherThis.wowLocation + "\\WTF\\Config.wtf", lines);
            Form frmMain = new Form1(launcherThis);
            this.Hide();
            frmMain.Show();
        }

        private void btnAddRealmlist_Click(object sender, EventArgs e)
        {

        }
    }
}

