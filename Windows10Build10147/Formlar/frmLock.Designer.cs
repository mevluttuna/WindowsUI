namespace Windows10Build10147.Formlar
{
    partial class frmLock
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
            this.timerAcilis = new System.Windows.Forms.Timer(this.components);
            this.timerYukari = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlClockContainer = new System.Windows.Forms.Panel();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlClockContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerAcilis
            // 
            this.timerAcilis.Interval = 1;
            this.timerAcilis.Tick += new System.EventHandler(this.timerAcilis_Tick);
            // 
            // timerYukari
            // 
            this.timerYukari.Interval = 1;
            this.timerYukari.Tick += new System.EventHandler(this.timerYukari_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Windows10Build10147.Properties.Resources.Background;
            this.panel1.Controls.Add(this.pnlClockContainer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 768);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.frmLock_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlClockContainer
            // 
            this.pnlClockContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlClockContainer.Controls.Add(this.lblTarih);
            this.pnlClockContainer.Controls.Add(this.lblSaat);
            this.pnlClockContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlClockContainer.Location = new System.Drawing.Point(0, 643);
            this.pnlClockContainer.Name = "pnlClockContainer";
            this.pnlClockContainer.Size = new System.Drawing.Size(1024, 125);
            this.pnlClockContainer.TabIndex = 0;
            this.pnlClockContainer.Click += new System.EventHandler(this.frmLock_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTarih.Location = new System.Drawing.Point(11, 72);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(270, 37);
            this.lblTarih.TabIndex = 1;
            this.lblTarih.Text = "20 Haziran Cumartesi";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Segoe UI Light", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSaat.Location = new System.Drawing.Point(6, 0);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(154, 72);
            this.lblSaat.TabIndex = 0;
            this.lblSaat.Text = "23:02";
            this.lblSaat.Click += new System.EventHandler(this.lblSaat_Click);
            // 
            // frmLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLock";
            this.Opacity = 0D;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLock_FormClosing);
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.Click += new System.EventHandler(this.frmLock_Click);
            this.panel1.ResumeLayout(false);
            this.pnlClockContainer.ResumeLayout(false);
            this.pnlClockContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerAcilis;
        private System.Windows.Forms.Panel pnlClockContainer;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Timer timerYukari;
        private System.Windows.Forms.Panel panel1;
    }
}