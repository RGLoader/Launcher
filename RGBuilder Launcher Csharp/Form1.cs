using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using IniParser;
using System.Windows;
using System.Runtime.InteropServices;
using System.Threading;


namespace RGBuilder_Launcher_Csharp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.AssemblyResolve += new ResolveEventHandler(currentDomain_AssemblyResolve);
            load_INI();
        }
        //private string mPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath); //path to launcher
        //private static string mCPUKey = ""; // cpu key
        
        //Start Move form without boarder
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender,System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //End Move form without boarder

        /// <summary>
        /// Function to validate Location - needed seperate for both gui and builder.
        /// True if correct, False if incorrent.
        /// </summary>
        /// <returns>Boolean if located outside of rgbuild\rgbuild.exe retuns True</returns>
        /// <author>M0j0</author>
        private Boolean ValidateLocation()
        {
            string rgbuild= Variables.LocalPath + "\\rgbuild\\rgbuild.exe";
    
            if (!File.Exists(@rgbuild))
            {
                MessageBox.Show("The Launcher is not installed correctly!\nPlease make sure RGBuild.exe is located at \\rgbuild\\rgbuild.exe");
                return false;
            }
            return true;
        }
        
        /// <summary>
        /// Function to validate input.
        /// True if correct, False if incorrent.
        /// </summary>
        /// <returns>Boolean if CPU and Nand valid retuns True</returns>
        /// <author>M0j0</author>
        public Boolean Validate()
        {

            Variables.CPUkey  = txtCpu.Text;
            string nand= @txtNandLoc.Text;
            string rgbuild= Variables.LocalPath  + "\\rgbuild\\rgbuild.exe";


            if (Variables.CPUkey.ToUpper().Equals("PORKCHOPS") || Variables.CPUkey.ToUpper().Equals("PORKCHOP") || Variables.CPUkey.Equals("BACON")) 
            {
                MessageBox.Show("May the bacon gods bless you." + Environment.NewLine + "But no, Invalid CPUKey");
                return false;

            }
            if (Variables.CPUkey.Equals("00000000000000000000000000000000"))
            {
                MessageBox.Show("Please enter a valid CPU Key");
                return false;
            }
            if (Variables.CPUkey.Count() != 32)
            {
                MessageBox.Show("Please enter a valid CPU Key");
                return false;
            }
            
            if (!ValidateLocation())
            {
                MessageBox.Show("The builder is not present or this file is not in the appropriate location." + Environment.NewLine + "Refer to readme");
                return false;
            }
            if(nand.Equals("Please Select Your Nand Location"))
            {
                MessageBox.Show("Specify your nand image location!");
                return false;

            }

            if (!File.Exists(@nand))
            {
                MessageBox.Show("Please make sure nand.bin is properly located.");
                return false;
            }

                
            return true;
        }

        /// <summary>
        /// Ty's assembly function
        /// not going to pretend I know what it does.
        /// </summary>
        /// <returns>nothing</returns>
        /// <author>tydye81</author>
        Assembly currentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            //This handler is called only when the common language runtime tries to bind to the assembly and fails.
	
            //Retrieve the list of referenced assemblies in an array of AssemblyName.
            Assembly MyAssembly, objExecutingAssemblies;
            string strTempAssmbPath = "";
	
            objExecutingAssemblies = Assembly.GetExecutingAssembly();
            AssemblyName[] arrReferencedAssmbNames = objExecutingAssemblies.GetReferencedAssemblies();
	
            //Loop through the array of referenced assembly names.
            foreach (AssemblyName strAssmbName in arrReferencedAssmbNames)
            {
                //Check for the assembly names that have raised the "AssemblyResolve" event.
                if (strAssmbName.FullName.Substring(0, strAssmbName.FullName.IndexOf(",")) == args.Name.Substring(0, args.Name.IndexOf(",")))
                {
                    //Build the path of the assembly from where it has to be loaded.
                    //The following line is probably the only line of code in this method you may need to modify:
                    strTempAssmbPath = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
                    if (strTempAssmbPath.EndsWith("\\")) strTempAssmbPath += "\\";
                    if (args.Name.Substring(0, args.Name.IndexOf(",")) == "INIFileParser" || args.Name.Substring(0, args.Name.IndexOf(",")) == "irrKlang.NET4") strTempAssmbPath += "\\rgbuild\\";
                    strTempAssmbPath += args.Name.Substring(0, args.Name.IndexOf(",")) + ".dll";
                    break;
                }
	
            }
            //Load the assembly from the specified path.
            MyAssembly = Assembly.LoadFrom(strTempAssmbPath);
	
            //Return the loaded assembly.
            return MyAssembly;
        }

        /// <summary>
        /// Loads INI file
        /// </summary>
        /// Loads INI config file and parse data
        /// <returns>nothing</returns>
        /// <author>tydye81</author>
        private void load_INI()
        {
            {
                FileIniDataParser parser = null;
                IniData parsedData = null;
                try
                {
                    parser = new FileIniDataParser();
                    parsedData = parser.LoadFile(Variables.LocalPath + "\\options.ini");
                }
                catch { return; }


                    //Console.WriteLine("Consoletype: " + consoleType);
                    if (!String.IsNullOrEmpty(parsedData["RGLauncher"]["CPU_Key"]))
                        txtCpu.Text = parsedData["RGLauncher"]["CPU_Key"];
                    if (!String.IsNullOrEmpty(parsedData["RGLauncher"]["exploit"]))
                    {
                        string hacktype = parsedData["RGLauncher"]["exploit"];
                        if (hacktype == radHackJTAG.Text) radHackJTAG.Checked = true;
                        else if(hacktype == radHackRGH.Text) radHackRGH.Checked = true;
                        else if (hacktype == radHackRGH2.Text) radHackRGH2.Checked = true;
                        
                    }
                    if (!string.IsNullOrEmpty(parsedData["RGLauncher"]["nand_location"]))
                        txtNandLoc.Text = parsedData["RGLauncher"]["nand_location"];

                    if (!String.IsNullOrEmpty(parsedData["RGLauncher"]["kernel"]))
                    {
                        string kernel = parsedData["RGLauncher"]["kernel"];

                        for (int i = 0; i < kernelCheckedBox.Items.Count; i++)
                        {
                            if (kernelCheckedBox.Items[i].ToString() == kernel)
                            {
                                int index = kernelCheckedBox.Items.IndexOf(kernelCheckedBox.Items[i]);
                                if (index > 0)
                                {
                                    kernelCheckedBox.SetSelected(index, true);
                                    kernelCheckedBox.SetItemChecked(index, true);
                                }

                                break;
                            }
                        }

                        /*foreach(object item in kernelCheckedBox.Items) 
                        {
                            //if (kernelCheckedBox.GetItemText(item) == kernel) kernelCheckedBox.SetItemChecked(kernelCheckedBox.Items.IndexOf(item), true);
                            if (item.ToString() == kernel) 
                                kernelCheckedBox.SetItemChecked(kernelCheckedBox.Items.IndexOf(item), true);
                        }*/
                        
                    }

                    if (!string.IsNullOrEmpty(parsedData["RGLauncher"]["rglversion"]))
                        txtRglVersion.Text = parsedData["RGLauncher"]["rglversion"];
            }
        }

        /// <summary>
        /// Save's INI
        /// </summary>
        /// <returns>nothing</returns>
        /// <author>tydye81</author>
        private void save_INI()
        {
            {
                FileIniDataParser parser = null;
                IniData parsedData = null;
                try
                {
                    parser = new FileIniDataParser();
                    parsedData = parser.LoadFile(Variables.LocalPath + "\\"+"options.ini");
                    //MessageBox.Show(Variables.LocalPath + "options.ini");
                }
                catch { return; }

                //cpu save check
                if (txtCpu.Text.Count() == 32)
                    parsedData["RGLauncher"]["CPU_Key"] = txtCpu.Text;

                //
                if (!(txtNandLoc.Text.Equals("Please Select Your Nand Location")))
                {
                    parsedData["RGLauncher"]["nand_location"] = txtNandLoc.Text;
                }
                if (radHackJTAG.Checked == true) parsedData["RGLauncher"]["exploit"] = "JTAG";
                else if(radHackRGH.Checked == true) parsedData["RGLauncher"]["exploit"] = "RGH";
                else if (radHackRGH2.Checked == true) parsedData["RGLauncher"]["exploit"] = "RGH2";
                
                if (!String.IsNullOrEmpty(parsedData["RGLauncher"]["kernel"]))
                {
                    string hacktype = parsedData["RGLauncher"]["kernel"];
               
                    foreach(object item in kernelCheckedBox.CheckedItems) 
                    {
                        parsedData["RGLauncher"]["kernel"] = kernelCheckedBox.GetItemText(item);
                        break;
                    }

                }


                try
                {
                    parser.SaveFile(Variables.LocalPath + "\\"+"options.ini", parsedData);
                    //MessageBox.Show(Variables.LocalPath + "options.ini");
                }
                catch { return; }
            }
        }


        /// <summary>
        ///Builder button, initiates builder and sends required args
        /// </summary>
        /// <returns>nothing</returns>
        /// <author>m0j0j0_j0, tydye81</author>
        private void picBuilder_Click(object sender, EventArgs e)
        {
            //Terminal f = new Terminal();
            //f.Show();
            if (Validate()) // true == 1 so if its true it will continue
            {
                save_INI();
                Variables.CPUkey  = txtCpu.Text;

                string cpukey_arg = "/cpu:" + Variables.CPUkey;
                string guided = "/guided \"" + txtNandLoc.Text + "\"";
                string rgb = Variables.LocalPath + "\\rgbuild\\rgbuild.exe";
                string wrkdir = Variables.LocalPath + "\\rgbuild";

                string hack = "/hack:";
                string kernel = "/kernel:";

                if (radHackJTAG.Checked) hack += "JTAG";
                else if (radHackRGH.Checked) hack += "RGH";
                else if (radHackRGH2.Checked) hack += "RGH2";
                else
                {
                    MessageBox.Show("Invalid hack selection", "Error");
                }

                
                if(kernelCheckedBox.CheckedItems.Count==1){
                    foreach(object item in kernelCheckedBox.CheckedItems) 
                    {
                        kernel += kernelCheckedBox.GetItemText(item);
                        break;
                    }

                }else
                {
                    MessageBox.Show("Invalid kernel selection", "Error");
                }


                ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo();
                start.FileName = rgb;
                start.Arguments = "/1bl:DD88AD0C9ED669E7B56794FB68563EFA " + cpukey_arg + " " + hack + " " + kernel + " " + guided;
                start.WorkingDirectory = wrkdir;
                Process p = Process.Start(start);
                Environment.Exit(1);
            }

        }

        /// <summary>
        /// Gui Launcher button, launches gui, no args sent except -ui
        /// </summary>
        /// <returns>nothing</returns>
        /// <author>m0j0j0_j0, tydye81</author>
        private void picGUI_Click(object sender, EventArgs e)
        {
            if (ValidateLocation())
            {
                string path = Variables.LocalPath;
                path = path + "\\rgbuild\\rgbuild.exe";
                if (ValidateLocation())
                {
                    Process.Start(path, "-ui");
                    save_INI();
                    Environment.Exit(1);
                }
            }
        }

        /// <summary>
        /// Just an exit button
        /// </summary>
        /// <returns>nothing</returns>
        /// <author>m0j0j0_j0</author>
        private void picExit_Click(object sender, EventArgs e)
        {
            save_INI();
            Application.Exit();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            save_INI();
        }

        private void rad13599_CheckedChanged(object sender, EventArgs e)
        {
            save_INI();
        }

        private void rad14719_CheckedChanged(object sender, EventArgs e)
        {
            save_INI();
        }

        

        /// <summary>
        /// File explorer 
        /// opens explorer to obtain location of nand
        /// - still needs to be edited to change paramters of search - .bin
        /// 
        /// </summary>
        /// <returns>nothing</returns>
        /// <author>m0j0j0_j0</author>
        //Start Nand file opener location do dad - i've been drinking
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void picNand_Click(object sender, EventArgs e)
        {
            save_INI();
            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                txtNandLoc.Text = @file;
                Variables.NandPath = @txtNandLoc.Text;
                openFileDialog1.Dispose();
                save_INI();
            }
            Directory.SetCurrentDirectory(Variables.LocalPath);

        }
        //End Nand file locator

        /// <summary>
        /// On load check, checks to see if nand if located in the same folder as the launcher.exe,
        /// If not sets nand text field to "please located nand... etc"
        /// 
        /// </summary>
        /// <returns>nothing</returns>
        /// <author>m0j0j0_j0</author>
        private void Form1_Load(object sender, EventArgs e)
        {
            load_INI();
            FileIniDataParser parser = null;
            IniData parsedData = null;
            try
            {
                parser = new FileIniDataParser();
                parsedData = parser.LoadFile("options.ini");
            }
            catch { return; }
            if (!((!string.IsNullOrEmpty(parsedData["RGLauncher"]["nand_location"])) && (File.Exists(parsedData["RGLauncher"]["nand_location"]))))
            {
                string tempPath = Variables.LocalPath  + "\\nand.bin";
                string tempPath1 = Variables.LocalPath + "\\nand1.bin";
                string tempPath2 = Variables.LocalPath + "\\nand2.bin";
                if (File.Exists(@tempPath))
                {
                    txtNandLoc.Text = @tempPath;
                }
                else if(File.Exists(@tempPath1))
                {
                    txtNandLoc.Text = @tempPath1;
                }
                else if(File.Exists(@tempPath2))
                {
                    txtNandLoc.Text = @tempPath2;
                }
                else
                {
                    txtNandLoc.Text = "Please Select Your Nand Location";
                }
                if(!(txtNandLoc.Text.Equals("Please Select Your Nand Location")))
                {
                    save_INI();
                }
            }
        }

        /// <summary>
        /// Fake exit button - replacing windows boarder 
        /// </summary>
        /// <returns>nothing</returns>
        /// <author>m0j0j0_j0</author>
        private void picLilExit_Click(object sender, EventArgs e)
        {
            save_INI();
            Application.Exit();
        }

        /// <summary>
        /// Fake Minimize button - replace windows boarder
        /// </summary>
        /// <returns>nothing</returns>
        /// <author>m0j0j0_j0</author>
        private void picLilMini_Click(object sender, EventArgs e)
        {
            save_INI();
            this.WindowState = FormWindowState.Minimized;
        }

        private void picAbout_Click(object sender, EventArgs e)
        {
            About f = new About();
            f.Show();
        }

        private void picHow_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("RGLoader-dev.txt");
            }
            catch { MessageBox.Show("RGLoader-dev.txt file has been moved or deleted \n Please return it to its location"); }
        }
        private void picDonate_Click(object sender, EventArgs e)
        {
            string url = "";
            string business = "rgloader.dev@gmail.com";  
            string description = "Donation";        
            string country = "US";          
            string currency = "USD";     
            url += "https://www.paypal.com/cgi-bin/webscr" +
                "?cmd=" + "_donations" +
                "&business=" + business +
                "&lc=" + country +
                "&item_name=" + description +
                 "&currency_code=" + currency +
                "&bn=" + "PP%2dDonationsBF";
            System.Diagnostics.Process.Start(url);
        }
        //pic button functions - mousedown/up/hover/leave

        //pichow
        Image picTemp;
        private void picHow_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            picTemp = picRead.Image;
            picRead.Image = RGBuilder_Launcher_Csharp.Resources.Resource1.ReadMeButtonDown;
        }
        private void picHow_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            picRead.Image = picTemp;
        }
        //private void picHow_MouseHover(object sender, EventArgs e)
        //{
        //}
        //private void picHow_MouseLeave(object sender, EventArgs e)
        //{
        //}

        //picAbout
        private void picAbout_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            picTemp = picAbout.Image;
            picAbout.Image = RGBuilder_Launcher_Csharp.Resources.Resource1.AboutUsButtonDown;
        }
        private void picAbout_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            picAbout.Image = picTemp;
        }
        //private void picAbout_MouseHover(object sender, EventArgs e)
        //{
        //}
        //private void picAbout_MouseLeave(object sender, EventArgs e)
        //{
        //}

        //picNand
        private void picNand_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            picTemp = picNand.Image;
            picNand.Image = RGBuilder_Launcher_Csharp.Resources.Resource1.NandButtonDown;
        }
        private void picNand_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            picNand.Image = picTemp;

        }
        //private void picNand_MouseHover(object sender, EventArgs e)
        //{
        //}
        //private void picNand_MouseLeave(object sender, EventArgs e)
        //{
        //}

        //picExit
        private void picExit_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            picTemp = picExit.Image;
            picExit.Image = RGBuilder_Launcher_Csharp.Resources.Resource1.ExitButtonDown;
        }
        private void picExit_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            picExit.Image = picTemp;

        }
        //private void picExit_MouseHover(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //}
        //private void picExit_MouseLeave(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //}

        //picGUI
        private void picGUI_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            picTemp = picEditor.Image;
            picEditor.Image = RGBuilder_Launcher_Csharp.Resources.Resource1.ImageEditorButtonDown;
        }
        private void picGUI_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            picEditor.Image = picTemp;

        }
        //private void picGUI_MouseHover(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //}
        //private void picGUI_MouseLeave(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //}

        //picBuilder
        private void picBuilder_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            picTemp = picBuilder.Image;
            picBuilder.Image = RGBuilder_Launcher_Csharp.Resources.Resource1.RGBButtonDown;
        }
        private void picBuilder_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            picBuilder.Image = picTemp;

        }
        
        //private void picBuilder_MouseHover(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //}
        //private void picBuilder_MouseLeave(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //}

        private void picDonate_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            picTemp = picDonate.Image;
            picDonate.Image = RGBuilder_Launcher_Csharp.Resources.Resource1.DonateButtonDown;
        }
        private void picDonate_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            picDonate.Image = picTemp;

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = kernelCheckedBox.SelectedIndex;
            for (int i = 0; i < kernelCheckedBox.Items.Count; i++)
                kernelCheckedBox.SetItemChecked(i, false);
            kernelCheckedBox.SetItemChecked(selected, true);
        }
        

        /// <summary>
        /// Confirm Exit
        /// -removed with tys implimentation of application.exit vs me.close
        /// </summary>
        /// <returns>nothing</returns>
        /// <author>m0j0j0_j0, Icekiller</author>
    //    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    //    {
    //        if (MessageBox.Show("Closing program are you sure?", "Closing RGH", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
    //        {
    //            Application.Exit();
    //        }
    //        else
    //        {
    //            e.Cancel = true;
    //        }
    //    }

    }
}
