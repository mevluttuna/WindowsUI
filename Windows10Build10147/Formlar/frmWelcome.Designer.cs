namespace Windows10Build10147.Formlar
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlBarContainer = new System.Windows.Forms.Panel();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.timerBar = new System.Windows.Forms.Timer(this.components);
            this.timerYukari = new System.Windows.Forms.Timer(this.components);
            this.pnlContainer.SuspendLayout();
            this.pnlBarContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Controls.Add(this.panel2);
            this.pnlContainer.Controls.Add(this.pnlBarContainer);
            this.pnlContainer.Location = new System.Drawing.Point(622, 456);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(285, 235);
            this.pnlContainer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(55, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Windows MT Edition\r\n";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 190);
            this.panel2.TabIndex = 2;
            // 
            // pnlBarContainer
            // 
            this.pnlBarContainer.BackColor = System.Drawing.Color.Silver;
            this.pnlBarContainer.Controls.Add(this.pnlBar);
            this.pnlBarContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBarContainer.Location = new System.Drawing.Point(0, 231);
            this.pnlBarContainer.Name = "pnlBarContainer";
            this.pnlBarContainer.Size = new System.Drawing.Size(285, 4);
            this.pnlBarContainer.TabIndex = 1;
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlBar.Location = new System.Drawing.Point(-214, 0);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(285, 4);
            this.pnlBar.TabIndex = 2;
            // 
            // timerBar
            // 
            this.timerBar.Interval = 1;
            this.timerBar.Tick += new System.EventHandler(this.timerBar_Tick);
            // 
            // timerYukari
            // 
            this.timerYukari.Interval = 1;
            this.timerYukari.Tick += new System.EventHandler(this.timerYukari_Tick);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWelcome";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlBarContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBarContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Timer timerBar;
        private System.Windows.Forms.Timer timerYukari;
    }
}