namespace Windows10Build10147.Formlar.Microsoft_Edge
{
    partial class EdgeMain
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlAdressContainer = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnGo = new System.Windows.Forms.Button();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.WebKitBR = new System.Windows.Forms.WebBrowser();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleRangeBarComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent();
            this.pnlContainer.SuspendLayout();
            this.pnlAdressContainer.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlContainer.Controls.Add(this.pnlAdressContainer);
            this.pnlContainer.Controls.Add(this.btnNext);
            this.pnlContainer.Controls.Add(this.btnPrev);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(806, 36);
            this.pnlContainer.TabIndex = 1;
            // 
            // pnlAdressContainer
            // 
            this.pnlAdressContainer.Controls.Add(this.gaugeControl1);
            this.pnlAdressContainer.Controls.Add(this.pnlSearch);
            this.pnlAdressContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdressContainer.Location = new System.Drawing.Point(72, 0);
            this.pnlAdressContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAdressContainer.Name = "pnlAdressContainer";
            this.pnlAdressContainer.Size = new System.Drawing.Size(734, 36);
            this.pnlAdressContainer.TabIndex = 4;
            this.pnlAdressContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAdressContainer_Paint);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BackColor = System.Drawing.SystemColors.Window;
            this.pnlSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSearch.Controls.Add(this.pnlRight);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Location = new System.Drawing.Point(164, 5);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(3);
            this.pnlSearch.Size = new System.Drawing.Size(406, 26);
            this.pnlSearch.TabIndex = 4;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.btnGo);
            this.pnlRight.Controls.Add(this.picLoading);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(383, 3);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(20, 20);
            this.pnlRight.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.SystemColors.Window;
            this.btnGo.BackgroundImage = global::Windows10Build10147.Properties.Resources.Search_Filled_181;
            this.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btnGo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Location = new System.Drawing.Point(0, 0);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(20, 20);
            this.btnGo.TabIndex = 0;
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // picLoading
            // 
            this.picLoading.Image = global::Windows10Build10147.Properties.Resources.loading;
            this.picLoading.Location = new System.Drawing.Point(0, 0);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(20, 20);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoading.TabIndex = 5;
            this.picLoading.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(5, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(374, 18);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "About:Blank";
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::Windows10Build10147.Properties.Resources.Right_Filled_251;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(36, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(36, 36);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackgroundImage = global::Windows10Build10147.Properties.Resources.Left_Filled_25;
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(0, 0);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(36, 36);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // WebKitBR
            // 
            this.WebKitBR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebKitBR.Location = new System.Drawing.Point(0, 36);
            this.WebKitBR.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebKitBR.Name = "WebKitBR";
            this.WebKitBR.Size = new System.Drawing.Size(806, 449);
            this.WebKitBR.TabIndex = 2;
            this.WebKitBR.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.WebKitBR_Navigated);
            this.WebKitBR.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.WebKitBR_Navigating);
            this.WebKitBR.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.WebKitBR_ProgressChanged);
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gaugeControl1.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(572, -2);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(39, 39);
            this.gaugeControl1.TabIndex = 5;
            // 
            // circularGauge1
            // 
            this.circularGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 27, 27);
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.RangeBars.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent[] {
            this.arcScaleRangeBarComponent1});
            this.circularGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent1});
            // 
            // arcScaleComponent1
            // 
            this.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.arcScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            this.arcScaleComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.arcScaleComponent1.EndAngle = 90F;
            this.arcScaleComponent1.MajorTickCount = 0;
            this.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent1.MajorTickmark.ShapeOffset = -14F;
            this.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1;
            this.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent1.MaxValue = 100F;
            this.arcScaleComponent1.MinorTickCount = 0;
            this.arcScaleComponent1.MinorTickmark.ShapeOffset = -7F;
            this.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2;
            this.arcScaleComponent1.Name = "scale1";
            this.arcScaleComponent1.StartAngle = -270F;
            // 
            // arcScaleRangeBarComponent1
            // 
            this.arcScaleRangeBarComponent1.AppearanceRangeBar.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F02828");
            this.arcScaleRangeBarComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleRangeBarComponent1.Name = "circularGauge1_RangeBar2";
            this.arcScaleRangeBarComponent1.RoundedCaps = true;
            this.arcScaleRangeBarComponent1.ShowBackground = true;
            this.arcScaleRangeBarComponent1.StartOffset = 80F;
            this.arcScaleRangeBarComponent1.ZOrder = -10;
            // 
            // EdgeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.WebKitBR);
            this.Controls.Add(this.pnlContainer);
            this.Name = "EdgeMain";
            this.Size = new System.Drawing.Size(806, 485);
            this.pnlContainer.ResumeLayout(false);
            this.pnlAdressContainer.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlAdressContainer;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.WebBrowser WebKitBR;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent arcScaleRangeBarComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent1;
    }
}
