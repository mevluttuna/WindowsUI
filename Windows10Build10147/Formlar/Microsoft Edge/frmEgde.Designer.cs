namespace Windows10Build10147.Formlar.Microsoft_Edge
{
    partial class frmEgde
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
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlSekmeler = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFull = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.pnlContainer.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlContainer.Controls.Add(this.btnAdd);
            this.pnlContainer.Controls.Add(this.pnlSekmeler);
            this.pnlContainer.Controls.Add(this.pnlButtons);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContainer.Location = new System.Drawing.Point(1, 1);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(898, 30);
            this.pnlContainer.TabIndex = 3;
            this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainer_Paint);
            this.pnlContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlContainer_MouseDown);
            this.pnlContainer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlContainer_MouseMove);
            this.pnlContainer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlContainer_MouseUp);
            // 
            // pnlSekmeler
            // 
            this.pnlSekmeler.BackColor = System.Drawing.SystemColors.Window;
            this.pnlSekmeler.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSekmeler.Location = new System.Drawing.Point(0, 0);
            this.pnlSekmeler.Name = "pnlSekmeler";
            this.pnlSekmeler.Size = new System.Drawing.Size(0, 30);
            this.pnlSekmeler.TabIndex = 4;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Controls.Add(this.btnFull);
            this.pnlButtons.Controls.Add(this.btnMin);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButtons.Location = new System.Drawing.Point(778, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(120, 30);
            this.pnlButtons.TabIndex = 2;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(1, 31);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(898, 568);
            this.pnlMain.TabIndex = 4;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Windows10Build10147.Properties.Resources.ios7_plus_empty_128_000000;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Windows10Build10147.Properties.Resources.close2;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(80, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFull
            // 
            this.btnFull.BackgroundImage = global::Windows10Build10147.Properties.Resources.fullScreen;
            this.btnFull.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFull.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFull.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFull.FlatAppearance.BorderSize = 0;
            this.btnFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFull.Location = new System.Drawing.Point(40, 0);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(40, 30);
            this.btnFull.TabIndex = 1;
            this.btnFull.UseVisualStyleBackColor = true;
            this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImage = global::Windows10Build10147.Properties.Resources.minimize;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(0, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 30);
            this.btnMin.TabIndex = 0;
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // frmEgde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(730, 400);
            this.Name = "frmEgde";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "frmEgde";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmEgde_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFull;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Panel pnlSekmeler;
    }
}