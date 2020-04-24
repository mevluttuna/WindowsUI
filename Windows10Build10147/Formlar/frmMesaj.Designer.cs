namespace Windows10Build10147.Formlar
{
    partial class frmMesaj
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
            this.btnEvet = new System.Windows.Forms.Button();
            this.btnHayır = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.timerAcilis = new System.Windows.Forms.Timer(this.components);
            this.timerKapanis = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnEvet
            // 
            this.btnEvet.AutoSize = true;
            this.btnEvet.BackColor = System.Drawing.Color.Orange;
            this.btnEvet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvet.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnEvet.FlatAppearance.BorderSize = 0;
            this.btnEvet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEvet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEvet.Location = new System.Drawing.Point(513, 160);
            this.btnEvet.Name = "btnEvet";
            this.btnEvet.Size = new System.Drawing.Size(75, 28);
            this.btnEvet.TabIndex = 0;
            this.btnEvet.Text = "Evet";
            this.btnEvet.UseVisualStyleBackColor = false;
            this.btnEvet.Click += new System.EventHandler(this.btnEvet_Click);
            // 
            // btnHayır
            // 
            this.btnHayır.AutoSize = true;
            this.btnHayır.BackColor = System.Drawing.Color.Orange;
            this.btnHayır.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHayır.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnHayır.FlatAppearance.BorderSize = 0;
            this.btnHayır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHayır.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHayır.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHayır.Location = new System.Drawing.Point(432, 160);
            this.btnHayır.Name = "btnHayır";
            this.btnHayır.Size = new System.Drawing.Size(75, 28);
            this.btnHayır.TabIndex = 1;
            this.btnHayır.Text = "Hayır";
            this.btnHayır.UseVisualStyleBackColor = false;
            this.btnHayır.Click += new System.EventHandler(this.btnHayır_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMesaj.Location = new System.Drawing.Point(49, 44);
            this.lblMesaj.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(137, 25);
            this.lblMesaj.TabIndex = 2;
            this.lblMesaj.Text = "Deneme mesaj...";
            // 
            // timerAcilis
            // 
            this.timerAcilis.Interval = 1;
            this.timerAcilis.Tick += new System.EventHandler(this.timerAcilis_Tick);
            // 
            // timerKapanis
            // 
            this.timerKapanis.Interval = 1;
            this.timerKapanis.Tick += new System.EventHandler(this.timerKapanis_Tick);
            // 
            // frmMesaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 200);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnHayır);
            this.Controls.Add(this.btnEvet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMesaj";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.frmMesaj_Deactivate);
            this.Load += new System.EventHandler(this.frmMesaj_Load);
            this.CursorChanged += new System.EventHandler(this.frmMesaj_CursorChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEvet;
        private System.Windows.Forms.Button btnHayır;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Timer timerAcilis;
        private System.Windows.Forms.Timer timerKapanis;
    }
}