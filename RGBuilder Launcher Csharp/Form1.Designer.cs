namespace RGBuilder_Launcher_Csharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtCpu = new System.Windows.Forms.TextBox();
            this.picBuilder = new System.Windows.Forms.PictureBox();
            this.picEditor = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.radHackJTAG = new System.Windows.Forms.RadioButton();
            this.radHackRGH = new System.Windows.Forms.RadioButton();
            this.pnlHack = new System.Windows.Forms.Panel();
            this.radHackRGH2 = new System.Windows.Forms.RadioButton();
            this.pnlVersion = new System.Windows.Forms.Panel();
            this.kernelCheckedBox = new System.Windows.Forms.CheckedListBox();
            this.txtNandLoc = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picNand = new System.Windows.Forms.PictureBox();
            this.picRead = new System.Windows.Forms.PictureBox();
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.picLilExit = new System.Windows.Forms.PictureBox();
            this.picLilMini = new System.Windows.Forms.PictureBox();
            this.txtRglVersion = new System.Windows.Forms.Label();
            this.picDonate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBuilder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.pnlHack.SuspendLayout();
            this.pnlVersion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLilExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLilMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDonate)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCpu
            // 
            this.txtCpu.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCpu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpu.ForeColor = System.Drawing.Color.Black;
            this.txtCpu.Location = new System.Drawing.Point(108, 277);
            this.txtCpu.Name = "txtCpu";
            this.txtCpu.Size = new System.Drawing.Size(275, 13);
            this.txtCpu.TabIndex = 4;
            this.txtCpu.Text = "00000000000000000000000000000000";
            this.txtCpu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picBuilder
            // 
            this.picBuilder.BackColor = System.Drawing.Color.Transparent;
            this.picBuilder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBuilder.Image = ((System.Drawing.Image)(resources.GetObject("picBuilder.Image")));
            this.picBuilder.Location = new System.Drawing.Point(30, 360);
            this.picBuilder.Name = "picBuilder";
            this.picBuilder.Size = new System.Drawing.Size(121, 26);
            this.picBuilder.TabIndex = 5;
            this.picBuilder.TabStop = false;
            this.picBuilder.Click += new System.EventHandler(this.picBuilder_Click);
            this.picBuilder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBuilder_MouseDown);
            this.picBuilder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBuilder_MouseUp);
            // 
            // picEditor
            // 
            this.picEditor.BackColor = System.Drawing.Color.Transparent;
            this.picEditor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEditor.Image = ((System.Drawing.Image)(resources.GetObject("picEditor.Image")));
            this.picEditor.Location = new System.Drawing.Point(151, 360);
            this.picEditor.Name = "picEditor";
            this.picEditor.Size = new System.Drawing.Size(130, 26);
            this.picEditor.TabIndex = 6;
            this.picEditor.TabStop = false;
            this.picEditor.Click += new System.EventHandler(this.picGUI_Click);
            this.picEditor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picGUI_MouseDown);
            this.picEditor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picGUI_MouseUp);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(565, 360);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(58, 26);
            this.picExit.TabIndex = 7;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picExit_MouseDown);
            this.picExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picExit_MouseUp);
            // 
            // radHackJTAG
            // 
            this.radHackJTAG.AutoSize = true;
            this.radHackJTAG.BackColor = System.Drawing.Color.Transparent;
            this.radHackJTAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.radHackJTAG.ForeColor = System.Drawing.Color.Black;
            this.radHackJTAG.Location = new System.Drawing.Point(6, 1);
            this.radHackJTAG.Name = "radHackJTAG";
            this.radHackJTAG.Size = new System.Drawing.Size(56, 17);
            this.radHackJTAG.TabIndex = 8;
            this.radHackJTAG.TabStop = true;
            this.radHackJTAG.Text = "JTAG";
            this.radHackJTAG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radHackJTAG.UseMnemonic = false;
            this.radHackJTAG.UseVisualStyleBackColor = false;
            // 
            // radHackRGH
            // 
            this.radHackRGH.AutoSize = true;
            this.radHackRGH.BackColor = System.Drawing.Color.Transparent;
            this.radHackRGH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.radHackRGH.ForeColor = System.Drawing.Color.Black;
            this.radHackRGH.Location = new System.Drawing.Point(6, 18);
            this.radHackRGH.Name = "radHackRGH";
            this.radHackRGH.Size = new System.Drawing.Size(52, 17);
            this.radHackRGH.TabIndex = 9;
            this.radHackRGH.TabStop = true;
            this.radHackRGH.Text = "RGH";
            this.radHackRGH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radHackRGH.UseVisualStyleBackColor = false;
            // 
            // pnlHack
            // 
            this.pnlHack.BackColor = System.Drawing.Color.Transparent;
            this.pnlHack.Controls.Add(this.radHackRGH2);
            this.pnlHack.Controls.Add(this.radHackRGH);
            this.pnlHack.Controls.Add(this.radHackJTAG);
            this.pnlHack.Location = new System.Drawing.Point(411, 284);
            this.pnlHack.Name = "pnlHack";
            this.pnlHack.Size = new System.Drawing.Size(85, 56);
            this.pnlHack.TabIndex = 15;
            // 
            // radHackRGH2
            // 
            this.radHackRGH2.AutoSize = true;
            this.radHackRGH2.BackColor = System.Drawing.Color.Transparent;
            this.radHackRGH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.radHackRGH2.ForeColor = System.Drawing.Color.Black;
            this.radHackRGH2.Location = new System.Drawing.Point(6, 35);
            this.radHackRGH2.Name = "radHackRGH2";
            this.radHackRGH2.Size = new System.Drawing.Size(59, 17);
            this.radHackRGH2.TabIndex = 10;
            this.radHackRGH2.TabStop = true;
            this.radHackRGH2.Text = "RGH2";
            this.radHackRGH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radHackRGH2.UseVisualStyleBackColor = false;
            // 
            // pnlVersion
            // 
            this.pnlVersion.BackColor = System.Drawing.Color.Transparent;
            this.pnlVersion.Controls.Add(this.kernelCheckedBox);
            this.pnlVersion.ForeColor = System.Drawing.Color.Transparent;
            this.pnlVersion.Location = new System.Drawing.Point(523, 282);
            this.pnlVersion.Name = "pnlVersion";
            this.pnlVersion.Size = new System.Drawing.Size(112, 58);
            this.pnlVersion.TabIndex = 16;
            // 
            // kernelCheckedBox
            // 
            this.kernelCheckedBox.FormattingEnabled = true;
            this.kernelCheckedBox.Items.AddRange(new object[] {
            "17150",
            "17349",
            "17489"});
            this.kernelCheckedBox.Location = new System.Drawing.Point(0, 3);
            this.kernelCheckedBox.Name = "kernelCheckedBox";
            this.kernelCheckedBox.Size = new System.Drawing.Size(109, 49);
            this.kernelCheckedBox.TabIndex = 0;
            this.kernelCheckedBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // txtNandLoc
            // 
            this.txtNandLoc.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNandLoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNandLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtNandLoc.ForeColor = System.Drawing.Color.Black;
            this.txtNandLoc.Location = new System.Drawing.Point(92, 320);
            this.txtNandLoc.Name = "txtNandLoc";
            this.txtNandLoc.ReadOnly = true;
            this.txtNandLoc.Size = new System.Drawing.Size(291, 13);
            this.txtNandLoc.TabIndex = 17;
            this.txtNandLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "bin";
            this.openFileDialog1.FileName = "nand.bin";
            this.openFileDialog1.Filter = "Nand Bin File|*.bin|Nand ECC File|*.ecc|All Files|*.**";
            this.openFileDialog1.ShowReadOnly = true;
            this.openFileDialog1.Title = "Go Fetch Your Nand! Slut!";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // picNand
            // 
            this.picNand.BackColor = System.Drawing.Color.Transparent;
            this.picNand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNand.Image = ((System.Drawing.Image)(resources.GetObject("picNand.Image")));
            this.picNand.Location = new System.Drawing.Point(20, 314);
            this.picNand.Name = "picNand";
            this.picNand.Size = new System.Drawing.Size(68, 26);
            this.picNand.TabIndex = 19;
            this.picNand.TabStop = false;
            this.picNand.Click += new System.EventHandler(this.picNand_Click);
            this.picNand.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picNand_MouseDown);
            this.picNand.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picNand_MouseUp);
            // 
            // picRead
            // 
            this.picRead.BackColor = System.Drawing.Color.Transparent;
            this.picRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRead.Image = ((System.Drawing.Image)(resources.GetObject("picRead.Image")));
            this.picRead.Location = new System.Drawing.Point(281, 360);
            this.picRead.Name = "picRead";
            this.picRead.Size = new System.Drawing.Size(93, 26);
            this.picRead.TabIndex = 20;
            this.picRead.TabStop = false;
            this.picRead.Click += new System.EventHandler(this.picHow_Click);
            this.picRead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picHow_MouseDown);
            this.picRead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picHow_MouseUp);
            // 
            // picAbout
            // 
            this.picAbout.BackColor = System.Drawing.Color.Transparent;
            this.picAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAbout.Image = ((System.Drawing.Image)(resources.GetObject("picAbout.Image")));
            this.picAbout.Location = new System.Drawing.Point(374, 360);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(102, 26);
            this.picAbout.TabIndex = 21;
            this.picAbout.TabStop = false;
            this.picAbout.Click += new System.EventHandler(this.picAbout_Click);
            this.picAbout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picAbout_MouseDown);
            this.picAbout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picAbout_MouseUp);
            // 
            // picLilExit
            // 
            this.picLilExit.BackColor = System.Drawing.Color.Transparent;
            this.picLilExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLilExit.Image = ((System.Drawing.Image)(resources.GetObject("picLilExit.Image")));
            this.picLilExit.Location = new System.Drawing.Point(640, 0);
            this.picLilExit.Name = "picLilExit";
            this.picLilExit.Size = new System.Drawing.Size(20, 20);
            this.picLilExit.TabIndex = 22;
            this.picLilExit.TabStop = false;
            this.picLilExit.Click += new System.EventHandler(this.picLilExit_Click);
            // 
            // picLilMini
            // 
            this.picLilMini.BackColor = System.Drawing.Color.Transparent;
            this.picLilMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLilMini.Image = ((System.Drawing.Image)(resources.GetObject("picLilMini.Image")));
            this.picLilMini.Location = new System.Drawing.Point(620, 0);
            this.picLilMini.Name = "picLilMini";
            this.picLilMini.Size = new System.Drawing.Size(20, 20);
            this.picLilMini.TabIndex = 23;
            this.picLilMini.TabStop = false;
            this.picLilMini.Click += new System.EventHandler(this.picLilMini_Click);
            // 
            // txtRglVersion
            // 
            this.txtRglVersion.AutoSize = true;
            this.txtRglVersion.BackColor = System.Drawing.Color.Transparent;
            this.txtRglVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRglVersion.ForeColor = System.Drawing.Color.DarkGray;
            this.txtRglVersion.Location = new System.Drawing.Point(571, 218);
            this.txtRglVersion.Name = "txtRglVersion";
            this.txtRglVersion.Size = new System.Drawing.Size(64, 24);
            this.txtRglVersion.TabIndex = 24;
            this.txtRglVersion.Text = "0v000";
            // 
            // picDonate
            // 
            this.picDonate.BackColor = System.Drawing.Color.Transparent;
            this.picDonate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDonate.BackgroundImage")));
            this.picDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDonate.Location = new System.Drawing.Point(476, 360);
            this.picDonate.Name = "picDonate";
            this.picDonate.Size = new System.Drawing.Size(89, 26);
            this.picDonate.TabIndex = 25;
            this.picDonate.TabStop = false;
            this.picDonate.Click += new System.EventHandler(this.picDonate_Click);
            this.picDonate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDonate_MouseDown);
            this.picDonate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picDonate_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(660, 400);
            this.Controls.Add(this.picDonate);
            this.Controls.Add(this.txtRglVersion);
            this.Controls.Add(this.picLilMini);
            this.Controls.Add(this.picLilExit);
            this.Controls.Add(this.picAbout);
            this.Controls.Add(this.picRead);
            this.Controls.Add(this.picNand);
            this.Controls.Add(this.txtNandLoc);
            this.Controls.Add(this.pnlVersion);
            this.Controls.Add(this.pnlHack);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picEditor);
            this.Controls.Add(this.picBuilder);
            this.Controls.Add(this.txtCpu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGLauncher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBuilder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.pnlHack.ResumeLayout(false);
            this.pnlHack.PerformLayout();
            this.pnlVersion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLilExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLilMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDonate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCpu;
        private System.Windows.Forms.PictureBox picBuilder;
        private System.Windows.Forms.PictureBox picEditor;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.RadioButton radHackJTAG;
        private System.Windows.Forms.RadioButton radHackRGH;
        private System.Windows.Forms.Panel pnlHack;
        private System.Windows.Forms.Panel pnlVersion;
        private System.Windows.Forms.TextBox txtNandLoc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox picNand;
        private System.Windows.Forms.PictureBox picRead;
        private System.Windows.Forms.PictureBox picAbout;
        private System.Windows.Forms.PictureBox picLilExit;
        private System.Windows.Forms.PictureBox picLilMini;
        private System.Windows.Forms.RadioButton radHackRGH2;
        private System.Windows.Forms.Label txtRglVersion;
        private System.Windows.Forms.PictureBox picDonate;
        private System.Windows.Forms.CheckedListBox kernelCheckedBox;
    }
}

