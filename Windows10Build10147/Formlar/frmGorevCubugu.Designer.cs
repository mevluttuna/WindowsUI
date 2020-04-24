namespace Windows10Build10147.Formlar
{
    partial class frmGorevCubugu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGorevCubugu));
            this.timerAcilis = new System.Windows.Forms.Timer(this.components);
            this.FlowRight = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSaat = new System.Windows.Forms.Label();
            this.FlowMain = new System.Windows.Forms.FlowLayoutPanel();
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureScreen = new System.Windows.Forms.PictureBox();
            this.pictureEdge = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picNotifications = new System.Windows.Forms.PictureBox();
            this.picStart = new System.Windows.Forms.PictureBox();
            this.FlowRight.SuspendLayout();
            this.FlowMain.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNotifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAcilis
            // 
            this.timerAcilis.Interval = 1;
            this.timerAcilis.Tick += new System.EventHandler(this.timerAcilis_Tick);
            // 
            // FlowRight
            // 
            this.FlowRight.Controls.Add(this.pictureBox1);
            this.FlowRight.Controls.Add(this.pictureBox2);
            this.FlowRight.Controls.Add(this.pictureBox4);
            this.FlowRight.Controls.Add(this.picNotifications);
            this.FlowRight.Controls.Add(this.lblSaat);
            this.FlowRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.FlowRight.Location = new System.Drawing.Point(1176, 0);
            this.FlowRight.Name = "FlowRight";
            this.FlowRight.Size = new System.Drawing.Size(190, 30);
            this.FlowRight.TabIndex = 1;
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSaat.Location = new System.Drawing.Point(123, 1);
            this.lblSaat.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(56, 25);
            this.lblSaat.TabIndex = 4;
            this.lblSaat.Text = "00:00";
            // 
            // FlowMain
            // 
            this.FlowMain.Controls.Add(this.pnlSearch);
            this.FlowMain.Controls.Add(this.pictureScreen);
            this.FlowMain.Controls.Add(this.pictureEdge);
            this.FlowMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowMain.Location = new System.Drawing.Point(35, 0);
            this.FlowMain.Name = "FlowMain";
            this.FlowMain.Size = new System.Drawing.Size(1141, 30);
            this.FlowMain.TabIndex = 2;
            this.FlowMain.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowMain_Paint);
            // 
            // timerSaat
            // 
            this.timerSaat.Interval = 500;
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Windows10Build10147.Properties.Resources.Search_Filled_181;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(199, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(18, 18);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSearch.BackgroundImage")));
            this.pnlSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Location = new System.Drawing.Point(3, 3);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(220, 24);
            this.pnlSearch.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(4, 1);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(189, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // pictureScreen
            // 
            this.pictureScreen.BackColor = System.Drawing.Color.Transparent;
            this.pictureScreen.Image = global::Windows10Build10147.Properties.Resources.win_10_guncel_ekranlar;
            this.pictureScreen.Location = new System.Drawing.Point(226, 0);
            this.pictureScreen.Margin = new System.Windows.Forms.Padding(0);
            this.pictureScreen.Name = "pictureScreen";
            this.pictureScreen.Size = new System.Drawing.Size(35, 30);
            this.pictureScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureScreen.TabIndex = 2;
            this.pictureScreen.TabStop = false;
            this.pictureScreen.Click += new System.EventHandler(this.pictureScreen_Click);
            // 
            // pictureEdge
            // 
            this.pictureEdge.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdge.Image = global::Windows10Build10147.Properties.Resources.MicrosoftEdgeSquare44x44_targetsize_16_altform_unplated;
            this.pictureEdge.Location = new System.Drawing.Point(261, 0);
            this.pictureEdge.Margin = new System.Windows.Forms.Padding(0);
            this.pictureEdge.Name = "pictureEdge";
            this.pictureEdge.Size = new System.Drawing.Size(35, 30);
            this.pictureEdge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureEdge.TabIndex = 4;
            this.pictureEdge.TabStop = false;
            this.pictureEdge.Click += new System.EventHandler(this.pictureEdge_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Windows10Build10147.Properties.Resources.Flag_Filled__20;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Windows10Build10147.Properties.Resources.Wi_Fi_20__1_;
            this.pictureBox2.Location = new System.Drawing.Point(30, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Windows10Build10147.Properties.Resources.Speaker_20;
            this.pictureBox4.Location = new System.Drawing.Point(60, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // picNotifications
            // 
            this.picNotifications.Image = global::Windows10Build10147.Properties.Resources.Appointment_Reminders_20;
            this.picNotifications.Location = new System.Drawing.Point(90, 0);
            this.picNotifications.Margin = new System.Windows.Forms.Padding(0);
            this.picNotifications.Name = "picNotifications";
            this.picNotifications.Size = new System.Drawing.Size(30, 30);
            this.picNotifications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNotifications.TabIndex = 5;
            this.picNotifications.TabStop = false;
            this.picNotifications.Click += new System.EventHandler(this.picNotifications_Click);
            // 
            // picStart
            // 
            this.picStart.BackColor = System.Drawing.Color.Transparent;
            this.picStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.picStart.Image = global::Windows10Build10147.Properties.Resources.white;
            this.picStart.Location = new System.Drawing.Point(0, 0);
            this.picStart.Name = "picStart";
            this.picStart.Size = new System.Drawing.Size(35, 30);
            this.picStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picStart.TabIndex = 0;
            this.picStart.TabStop = false;
            this.picStart.Click += new System.EventHandler(this.picStart_Click);
            // 
            // frmGorevCubugu
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1366, 30);
            this.Controls.Add(this.FlowMain);
            this.Controls.Add(this.FlowRight);
            this.Controls.Add(this.picStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGorevCubugu";
            this.Opacity = 0D;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmGorevCubugu_Load);
            this.FlowRight.ResumeLayout(false);
            this.FlowRight.PerformLayout();
            this.FlowMain.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerAcilis;
        public System.Windows.Forms.PictureBox picStart;
        private System.Windows.Forms.FlowLayoutPanel FlowRight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.PictureBox picNotifications;
        public System.Windows.Forms.PictureBox pictureScreen;
        private System.Windows.Forms.Timer timerSaat;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.FlowLayoutPanel FlowMain;
        public System.Windows.Forms.PictureBox pictureEdge;
    }
}