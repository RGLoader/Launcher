namespace RGBuilder_Launcher_Csharp
{
    partial class About
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDevs = new System.Windows.Forms.Label();
            this.picThanks = new System.Windows.Forms.PictureBox();
            this.lblThanksWhy = new System.Windows.Forms.Label();
            this.picLilMini = new System.Windows.Forms.PictureBox();
            this.picLilExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picThanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLilMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLilExit)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 125;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDevs
            // 
            this.lblDevs.BackColor = System.Drawing.Color.Transparent;
            this.lblDevs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevs.ForeColor = System.Drawing.Color.Black;
            this.lblDevs.Location = new System.Drawing.Point(68, 238);
            this.lblDevs.Name = "lblDevs";
            this.lblDevs.Size = new System.Drawing.Size(173, 36);
            this.lblDevs.TabIndex = 0;
            this.lblDevs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picThanks
            // 
            this.picThanks.Image = ((System.Drawing.Image)(resources.GetObject("picThanks.Image")));
            this.picThanks.Location = new System.Drawing.Point(62, 194);
            this.picThanks.Name = "picThanks";
            this.picThanks.Size = new System.Drawing.Size(185, 37);
            this.picThanks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThanks.TabIndex = 3;
            this.picThanks.TabStop = false;
            this.picThanks.Visible = false;
            // 
            // lblThanksWhy
            // 
            this.lblThanksWhy.BackColor = System.Drawing.Color.Transparent;
            this.lblThanksWhy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanksWhy.ForeColor = System.Drawing.Color.Black;
            this.lblThanksWhy.Location = new System.Drawing.Point(29, 345);
            this.lblThanksWhy.Name = "lblThanksWhy";
            this.lblThanksWhy.Size = new System.Drawing.Size(254, 33);
            this.lblThanksWhy.TabIndex = 4;
            this.lblThanksWhy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLilMini
            // 
            this.picLilMini.BackColor = System.Drawing.Color.Transparent;
            this.picLilMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLilMini.Image = ((System.Drawing.Image)(resources.GetObject("picLilMini.Image")));
            this.picLilMini.Location = new System.Drawing.Point(272, 1);
            this.picLilMini.Name = "picLilMini";
            this.picLilMini.Size = new System.Drawing.Size(20, 20);
            this.picLilMini.TabIndex = 25;
            this.picLilMini.TabStop = false;
            this.picLilMini.Click += new System.EventHandler(this.picLilMini_Click);
            // 
            // picLilExit
            // 
            this.picLilExit.BackColor = System.Drawing.Color.Transparent;
            this.picLilExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLilExit.Image = ((System.Drawing.Image)(resources.GetObject("picLilExit.Image")));
            this.picLilExit.Location = new System.Drawing.Point(289, 1);
            this.picLilExit.Name = "picLilExit";
            this.picLilExit.Size = new System.Drawing.Size(20, 20);
            this.picLilExit.TabIndex = 24;
            this.picLilExit.TabStop = false;
            this.picLilExit.Click += new System.EventHandler(this.picLilExit_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(310, 315);
            this.Controls.Add(this.picLilMini);
            this.Controls.Add(this.picLilExit);
            this.Controls.Add(this.lblThanksWhy);
            this.Controls.Add(this.picThanks);
            this.Controls.Add(this.lblDevs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "About Us";
            this.Load += new System.EventHandler(this.About_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.About_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picThanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLilMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLilExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDevs;
        private System.Windows.Forms.PictureBox picThanks;
        private System.Windows.Forms.Label lblThanksWhy;
        private System.Windows.Forms.PictureBox picLilMini;
        private System.Windows.Forms.PictureBox picLilExit;
    }
}