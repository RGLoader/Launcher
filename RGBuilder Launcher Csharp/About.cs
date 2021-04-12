using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Windows;
using System.IO;
using System.Runtime.InteropServices;
//using IrrKlang;





namespace RGBuilder_Launcher_Csharp
{

    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();                        

        }
        //ISoundEngine engine = new ISoundEngine();

        //Start Move form without boarder
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void About_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void About_CrsMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //End Move form without boarder

        int currentName = 0;
        int currentCharacter = 0;
        int countback = 0;
        int pause = 0; // pauses for 8 ticks
        int mode = 0; //0= devs 1= thanks
        int grow = 0; //0=grow, 1=shrink

        string[] names = new string[]
        {
            "Tydye81",
            "Stoker25",
            "M0j0j0_j0",
            "XDK",
            "Juggahax0r",
            "Evil0ne",
            "RF1911",
            "Deathlok",
            "Mustache",
            "iCEQB",
            "spandaman"
        };
        string[] thanks = new string[]
        {
            "[C0z]",
            "Natelx",
            "IceKiller",
            "Team-Xecuter",
            "Tortuga-Cove"
        };
        string[] thanksWhy = new string[]
        {
            "Being generally awesome",
            "Supporting and debugging",
            "Supporting and debugging",
            "Sponsoring our devs",
            "Providing us with a home"
        };


        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 0:
                    if (!(this.Height == 315))
                    {
                        this.Height = 315;
                    }
            
                    if (currentCharacter >= names[currentName].Length)
                    {
                        //has paused on name - starts
                        if (pause == 8)
                        {
                            timer1.Interval = 50;
                            if (pause == 8 && countback==names[currentName].Length)
                            {
                                currentCharacter = 0;
                                countback = 0;
                                currentName++;
                                pause = 0;
                                timer1.Interval = 125;
                                if (currentName >= names.Length)
                                {
                                    currentName = 0;
                                    mode=1;
                                    return;
                                }
                            }
                            else
                            {
                                countback++;
                                lblDevs.Text = names[currentName].Substring(0, names[currentName].Length-countback);
                                return;
                            }
                    
                        }
                        else
                        {
                            pause++;
                            return;
                        }
                    }

                    currentCharacter++;
                    lblDevs.Text += names[currentName].Substring(currentCharacter - 1, 1);
                    break;
                case 1:
                    picThanks.Visible = true;
                    
                    if (grow == 0)
                    {
                        timer1.Interval = 10;
                        if (this.Height < 400)
                        {
                            this.Height = this.Height + 5;
                            break;
                        }
                        else
                        {
                            grow = 1;
                            break;
                        }

                    }
                    else if (grow == 1)
                    {
                        if (!(this.Height == 400))
                        {
                            this.Height = 400;
                        }
                        timer1.Interval = 125;
                        if (currentCharacter >= thanks[currentName].Length)
                        {
                            //has paused on name - starts
                            if (pause == 8)
                            {
                                timer1.Interval = 50;
                                if (pause == 8 && countback == thanks[currentName].Length)
                                {
                                    currentCharacter = 0;
                                    countback = 0;
                                    currentName++;
                                    pause = 0;
                                    timer1.Interval = 125;
                                    if (currentName >= thanks.Length)
                                    {
                                        currentName = 0;
                                        grow = 2;
                                        break;
                                    }
                                }
                                else
                                {
                                    countback++;
                                    lblDevs.Text = thanks[currentName].Substring(0, thanks[currentName].Length - countback);
                                    break;
                                }

                            }
                            else
                            {
                                pause++;
                                break;
                            }
                        }
                        lblThanksWhy.Text = thanksWhy[currentName];
                        currentCharacter++;
                        lblDevs.Text += thanks[currentName].Substring(currentCharacter - 1, 1);
                        break;
                    }
                    else
                    {
                        timer1.Interval = 10;
                        if (this.Height > 315)
                        {
                            this.Height = this.Height -5;
                        }
                        else
                        {
                            grow = 0;
                            mode = 0;
                            picThanks.Visible = false;
                            timer1.Interval = 125;
                        }

                        break;
                    }
                    
            }
        }

        private void About_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //ISoundSource source = engine.AddSoundSourceFromMemory(Resources.Resource1.Alien_bull, "alienbull");
           // engine.Play2D("alienbull", true, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  engine.StopAllSounds();
            this.Close();

        }

        private void picLilMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picLilExit_Click(object sender, EventArgs e)
        {
          //  engine.StopAllSounds();

            this.Close();
        }


    }

}
