namespace Windows10Build10147.Formlar
{
    partial class frmNotifications
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
            this.timerAc = new System.Windows.Forms.Timer(this.components);
            this.timerKapat = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picOpen = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FlowButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.timerBtnAc = new System.Windows.Forms.Timer(this.components);
            this.timerBtnKapat = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpen)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.FlowButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAc
            // 
            this.timerAc.Interval = 1;
            this.timerAc.Tick += new System.EventHandler(this.timerAc_Tick);
            // 
            // timerKapat
            // 
            this.timerKapat.Interval = 1;
            this.timerKapat.Tick += new System.EventHandler(this.timerKapat_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(350, 474);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picOpen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 30);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picOpen
            // 
            this.picOpen.Image = global::Windows10Build10147.Properties.Resources.yukari;
            this.picOpen.Location = new System.Drawing.Point(317, 0);
            this.picOpen.Name = "picOpen";
            this.picOpen.Size = new System.Drawing.Size(30, 30);
            this.picOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picOpen.TabIndex = 0;
            this.picOpen.TabStop = false;
            this.picOpen.Click += new System.EventHandler(this.picOpen_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(350, 60);
            this.pnlHeader.TabIndex = 2;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hızlı İşlem Merkezi";
            // 
            // FlowButtons
            // 
            this.FlowButtons.Controls.Add(this.pictureBox1);
            this.FlowButtons.Controls.Add(this.pictureBox2);
            this.FlowButtons.Controls.Add(this.pictureBox4);
            this.FlowButtons.Controls.Add(this.pictureBox5);
            this.FlowButtons.Controls.Add(this.pictureBox6);
            this.FlowButtons.Controls.Add(this.pictureBox7);
            this.FlowButtons.Controls.Add(this.pictureBox8);
            this.FlowButtons.Controls.Add(this.pictureBox9);
            this.FlowButtons.Controls.Add(this.pictureBox10);
            this.FlowButtons.Controls.Add(this.pictureBox11);
            this.FlowButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlowButtons.Location = new System.Drawing.Point(0, 534);
            this.FlowButtons.Name = "FlowButtons";
            this.FlowButtons.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.FlowButtons.Size = new System.Drawing.Size(350, 66);
            this.FlowButtons.TabIndex = 3;
            this.FlowButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowButtons_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pictureBox1.Image = global::Windows10Build10147.Properties.Resources.tablet_mode;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pictureBox2.Image = global::Windows10Build10147.Properties.Resources.baglan;
            this.pictureBox2.Location = new System.Drawing.Point(90, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pictureBox4.Image = global::Windows10Build10147.Properties.Resources.ayarlar;
            this.pictureBox4.Location = new System.Drawing.Point(177, 2);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(83, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pictureBox5.Image = global::Windows10Build10147.Properties.Resources.VPN;
            this.pictureBox5.Location = new System.Drawing.Point(264, 2);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(83, 60);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pictureBox6.Image = global::Windows10Build10147.Properties.Resources.ekran;
            this.pictureBox6.Location = new System.Drawing.Point(3, 66);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(83, 60);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pictureBox7.Image = global::Windows10Build10147.Properties.Resources.Not;
            this.pictureBox7.Location = new System.Drawing.Point(90, 66);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(83, 60);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pictureBox8.Image = global::Windows10Build10147.Properties.Resources.wifi;
            this.pictureBox8.Location = new System.Drawing.Point(177, 66);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(83, 60);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pictureBox9.Image = global::Windows10Build10147.Properties.Resources.sessiz;
            this.pictureBox9.Location = new System.Drawing.Point(264, 66);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(83, 60);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pictureBox10.Image = global::Windows10Build10147.Properties.Resources.konum;
            this.pictureBox10.Location = new System.Drawing.Point(3, 130);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(83, 60);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pictureBox11.Image = global::Windows10Build10147.Properties.Resources.ucak_mode;
            this.pictureBox11.Location = new System.Drawing.Point(90, 130);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(83, 60);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // timerBtnAc
            // 
            this.timerBtnAc.Interval = 1;
            this.timerBtnAc.Tick += new System.EventHandler(this.timerBtnAc_Tick);
            // 
            // timerBtnKapat
            // 
            this.timerBtnKapat.Interval = 1;
            this.timerBtnKapat.Tick += new System.EventHandler(this.timerBtnKapat_Tick);
            // 
            // frmNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(350, 600);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.FlowButtons);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotifications";
            this.Opacity = 0.95D;
            this.Text = "frmNotifications";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.frmNotifications_Deactivate);
            this.Load += new System.EventHandler(this.frmNotifications_Load);
            this.pnlMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOpen)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.FlowButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer timerAc;
        public System.Windows.Forms.Timer timerKapat;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.FlowLayoutPanel FlowButtons;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picOpen;
        private System.Windows.Forms.Timer timerBtnAc;
        private System.Windows.Forms.Timer timerBtnKapat;
        private System.Windows.Forms.Label label1;
    }
}