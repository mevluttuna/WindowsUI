namespace Windows10Build10147.Formlar.Ayarlar
{
    partial class frmAyarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAyarlar));
            this.pnlAna = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlKapat = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picKapat = new System.Windows.Forms.PictureBox();
            this.timerCursorControl = new System.Windows.Forms.Timer(this.components);
            this.timerAc = new System.Windows.Forms.Timer(this.components);
            this.timerKapat = new System.Windows.Forms.Timer(this.components);
            this.timerKontrolEkle = new System.Windows.Forms.Timer(this.components);
            this.timerKontrolEkleGeri = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlKapat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAna
            // 
            this.pnlAna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlAna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAna.Location = new System.Drawing.Point(0, 0);
            this.pnlAna.Name = "pnlAna";
            this.pnlAna.Size = new System.Drawing.Size(1366, 768);
            this.pnlAna.TabIndex = 1;
            this.pnlAna.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAna_Paint);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlAna);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1366, 768);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlKapat
            // 
            this.pnlKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pnlKapat.Controls.Add(this.pictureBox3);
            this.pnlKapat.Controls.Add(this.picKapat);
            this.pnlKapat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKapat.Location = new System.Drawing.Point(0, 0);
            this.pnlKapat.Name = "pnlKapat";
            this.pnlKapat.Size = new System.Drawing.Size(1366, 0);
            this.pnlKapat.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 0);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // picKapat
            // 
            this.picKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.picKapat.Image = ((System.Drawing.Image)(resources.GetObject("picKapat.Image")));
            this.picKapat.Location = new System.Drawing.Point(1331, 0);
            this.picKapat.Name = "picKapat";
            this.picKapat.Size = new System.Drawing.Size(35, 0);
            this.picKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picKapat.TabIndex = 1;
            this.picKapat.TabStop = false;
            this.picKapat.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timerCursorControl
            // 
            this.timerCursorControl.Tick += new System.EventHandler(this.timerCursorControl_Tick);
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
            // timerKontrolEkle
            // 
            this.timerKontrolEkle.Interval = 1;
            this.timerKontrolEkle.Tick += new System.EventHandler(this.timerKontrolEkle_Tick);
            // 
            // timerKontrolEkleGeri
            // 
            this.timerKontrolEkleGeri.Interval = 1;
            // 
            // frmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlKapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAyarlar";
            this.Text = "frmAyarlar";
            this.Load += new System.EventHandler(this.frmAyarlar_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlKapat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKapat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlKapat;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picKapat;
        private System.Windows.Forms.Timer timerCursorControl;
        private System.Windows.Forms.Timer timerAc;
        private System.Windows.Forms.Timer timerKapat;
        private System.Windows.Forms.Timer timerKontrolEkle;
        private System.Windows.Forms.Timer timerKontrolEkleGeri;
        public System.Windows.Forms.Panel pnlAna;
    }
}