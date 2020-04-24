namespace Windows10Build10147.Formlar.Ayarlar
{
    partial class AyarlarVarsayılan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AyarlarVarsayılan));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContainer.BackgroundImage")));
            this.pnlContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlContainer.Controls.Add(this.panel2);
            this.pnlContainer.Location = new System.Drawing.Point(156, 86);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(320, 260);
            this.pnlContainer.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(15, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 164);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(55, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "  Yeni Windows ile \r\nTüm Kontroller Sizde.";
            // 
            // AyarlarVarsayılan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainer);
            this.Name = "AyarlarVarsayılan";
            this.Size = new System.Drawing.Size(1024, 768);
            this.Load += new System.EventHandler(this.AyarlarVarsayılan_Load);
            this.Resize += new System.EventHandler(this.AyarlarVarsayılan_Resize);
            this.pnlContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
