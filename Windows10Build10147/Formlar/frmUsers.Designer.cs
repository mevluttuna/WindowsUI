namespace Windows10Build10147.Formlar
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.pnlUserContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRestart = new System.Windows.Forms.Panel();
            this.pnlSleep = new System.Windows.Forms.Panel();
            this.pnlClose = new System.Windows.Forms.Panel();
            this.lblYanlis = new System.Windows.Forms.Label();
            this.pnlImageContainer = new System.Windows.Forms.Panel();
            this.pnlPasswordContainer = new System.Windows.Forms.Panel();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.timerYukari = new System.Windows.Forms.Timer(this.components);
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.pnlUserContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPasswordContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUserContainer
            // 
            this.pnlUserContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlUserContainer.Controls.Add(this.panel1);
            this.pnlUserContainer.Controls.Add(this.lblYanlis);
            this.pnlUserContainer.Controls.Add(this.pnlImageContainer);
            this.pnlUserContainer.Controls.Add(this.pnlPasswordContainer);
            this.pnlUserContainer.Location = new System.Drawing.Point(418, 119);
            this.pnlUserContainer.Name = "pnlUserContainer";
            this.pnlUserContainer.Size = new System.Drawing.Size(301, 470);
            this.pnlUserContainer.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlRestart);
            this.panel1.Controls.Add(this.pnlSleep);
            this.panel1.Controls.Add(this.pnlClose);
            this.panel1.Location = new System.Drawing.Point(49, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 50);
            this.panel1.TabIndex = 9;
            // 
            // pnlRestart
            // 
            this.pnlRestart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRestart.BackgroundImage")));
            this.pnlRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRestart.Location = new System.Drawing.Point(1, 0);
            this.pnlRestart.Name = "pnlRestart";
            this.pnlRestart.Size = new System.Drawing.Size(48, 48);
            this.pnlRestart.TabIndex = 5;
            this.pnlRestart.Click += new System.EventHandler(this.pnlRestart_Click);
            // 
            // pnlSleep
            // 
            this.pnlSleep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSleep.BackgroundImage")));
            this.pnlSleep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSleep.Location = new System.Drawing.Point(77, 0);
            this.pnlSleep.Name = "pnlSleep";
            this.pnlSleep.Size = new System.Drawing.Size(49, 49);
            this.pnlSleep.TabIndex = 6;
            this.pnlSleep.Click += new System.EventHandler(this.pnlSleep_Click);
            // 
            // pnlClose
            // 
            this.pnlClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlClose.BackgroundImage")));
            this.pnlClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlClose.Location = new System.Drawing.Point(154, 0);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(48, 48);
            this.pnlClose.TabIndex = 7;
            this.pnlClose.Click += new System.EventHandler(this.pnlClose_Click);
            // 
            // lblYanlis
            // 
            this.lblYanlis.AutoSize = true;
            this.lblYanlis.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYanlis.ForeColor = System.Drawing.SystemColors.Control;
            this.lblYanlis.Location = new System.Drawing.Point(18, 285);
            this.lblYanlis.Name = "lblYanlis";
            this.lblYanlis.Size = new System.Drawing.Size(265, 19);
            this.lblYanlis.TabIndex = 8;
            this.lblYanlis.Text = "Şifre Yanlış , Lütfen Tekrar Deneyiniz\r\n";
            this.lblYanlis.Visible = false;
            // 
            // pnlImageContainer
            // 
            this.pnlImageContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlImageContainer.Location = new System.Drawing.Point(49, 0);
            this.pnlImageContainer.Name = "pnlImageContainer";
            this.pnlImageContainer.Size = new System.Drawing.Size(203, 203);
            this.pnlImageContainer.TabIndex = 4;
            // 
            // pnlPasswordContainer
            // 
            this.pnlPasswordContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlPasswordContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPasswordContainer.BackgroundImage")));
            this.pnlPasswordContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPasswordContainer.Controls.Add(this.btnGo);
            this.pnlPasswordContainer.Controls.Add(this.txtPassword);
            this.pnlPasswordContainer.Controls.Add(this.picLoad);
            this.pnlPasswordContainer.Location = new System.Drawing.Point(33, 245);
            this.pnlPasswordContainer.Name = "pnlPasswordContainer";
            this.pnlPasswordContainer.Size = new System.Drawing.Size(235, 29);
            this.pnlPasswordContainer.TabIndex = 3;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Transparent;
            this.btnGo.BackgroundImage = global::Windows10Build10147.Properties.Resources.Right_Filled_25;
            this.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Location = new System.Drawing.Point(209, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(24, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(5, 1);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(197, 26);
            this.txtPassword.TabIndex = 1;
            // 
            // picLoad
            // 
            this.picLoad.Image = global::Windows10Build10147.Properties.Resources.loading;
            this.picLoad.Location = new System.Drawing.Point(206, 0);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(29, 29);
            this.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoad.TabIndex = 4;
            this.picLoad.TabStop = false;
            this.picLoad.Visible = false;
            // 
            // timerYukari
            // 
            this.timerYukari.Interval = 1;
            this.timerYukari.Tick += new System.EventHandler(this.timerYukari_Tick);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 250;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // timerLoad
            // 
            this.timerLoad.Interval = 4000;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // frmUsers
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlUserContainer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUsers_FormClosing);
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmUsers_Paint);
            this.pnlUserContainer.ResumeLayout(false);
            this.pnlUserContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlPasswordContainer.ResumeLayout(false);
            this.pnlPasswordContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlUserContainer;
        private System.Windows.Forms.Panel pnlPasswordContainer;
        private System.Windows.Forms.Panel pnlImageContainer;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Panel pnlClose;
        private System.Windows.Forms.Panel pnlSleep;
        private System.Windows.Forms.Panel pnlRestart;
        private System.Windows.Forms.Label lblYanlis;
        private System.Windows.Forms.Timer timerYukari;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLoad;
        private System.Windows.Forms.Timer timerLoad;
    }
}