namespace Windows10Build10147.Formlar
{
    partial class frmAraclar
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
            this.timerDenetle = new System.Windows.Forms.Timer(this.components);
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.performanceCounter2 = new System.Diagnostics.PerformanceCounter();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.gaugeControl2 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.timerGoster = new System.Windows.Forms.Timer(this.components);
            this.timerGizle = new System.Windows.Forms.Timer(this.components);
            this.circularGauge2 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.labelComponent3 = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            this.BarRam = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleRangeBarComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent();
            this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.labelComponent4 = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            this.BarCpu = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleRangeBarComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent();
            this.performanceCounter3 = new System.Diagnostics.PerformanceCounter();
            this.performanceCounter4 = new System.Diagnostics.PerformanceCounter();
            this.gaugeControl5 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.gaugeControl6 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge3 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.BarWrite = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleRangeBarComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent();
            this.circularGauge4 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.labelComponent1 = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            this.BarRead = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleRangeBarComponent4 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent();
            this.labelComponent2 = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            this.labelComponent5 = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarCpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter4)).BeginInit();
            this.gaugeControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarWrite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarRead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent5)).BeginInit();
            this.SuspendLayout();
            // 
            // timerDenetle
            // 
            this.timerDenetle.Interval = 1500;
            this.timerDenetle.Tick += new System.EventHandler(this.timerDenetle_Tick);
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Processor";
            this.performanceCounter1.CounterName = "% Processor Time";
            this.performanceCounter1.InstanceName = "_Total";
            // 
            // performanceCounter2
            // 
            this.performanceCounter2.CategoryName = "Memory";
            this.performanceCounter2.CounterName = "% Committed Bytes In Use";
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.AutoLayout = false;
            this.gaugeControl1.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl1.ColorScheme.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gaugeControl1.ColorScheme.TargetElements = ((DevExpress.XtraGauges.Win.TargetElement)(((DevExpress.XtraGauges.Win.TargetElement.RangeBar | DevExpress.XtraGauges.Win.TargetElement.ImageIndicator) 
            | DevExpress.XtraGauges.Win.TargetElement.Label)));
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(15, 12);
            this.gaugeControl1.MaximumSize = new System.Drawing.Size(120, 120);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(120, 120);
            this.gaugeControl1.TabIndex = 6;
            // 
            // gaugeControl2
            // 
            this.gaugeControl2.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl2.ColorScheme.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gaugeControl2.ColorScheme.TargetElements = ((DevExpress.XtraGauges.Win.TargetElement)(((DevExpress.XtraGauges.Win.TargetElement.RangeBar | DevExpress.XtraGauges.Win.TargetElement.ImageIndicator) 
            | DevExpress.XtraGauges.Win.TargetElement.Label)));
            this.gaugeControl2.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge2});
            this.gaugeControl2.Location = new System.Drawing.Point(15, 138);
            this.gaugeControl2.MaximumSize = new System.Drawing.Size(120, 120);
            this.gaugeControl2.Name = "gaugeControl2";
            this.gaugeControl2.Size = new System.Drawing.Size(120, 120);
            this.gaugeControl2.TabIndex = 7;
            this.gaugeControl2.Click += new System.EventHandler(this.gaugeControl2_Click);
            // 
            // timerGoster
            // 
            this.timerGoster.Interval = 1;
            this.timerGoster.Tick += new System.EventHandler(this.timerGoster_Tick);
            // 
            // timerGizle
            // 
            this.timerGizle.Interval = 1;
            this.timerGizle.Tick += new System.EventHandler(this.timerGizle_Tick);
            // 
            // circularGauge2
            // 
            this.circularGauge2.Bounds = new System.Drawing.Rectangle(6, 6, 108, 108);
            this.circularGauge2.Labels.AddRange(new DevExpress.XtraGauges.Win.Base.LabelComponent[] {
            this.labelComponent3});
            this.circularGauge2.Name = "circularGauge2";
            this.circularGauge2.RangeBars.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent[] {
            this.arcScaleRangeBarComponent2});
            this.circularGauge2.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.BarRam});
            // 
            // labelComponent3
            // 
            this.labelComponent3.AppearanceText.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelComponent3.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:buttonface");
            this.labelComponent3.Name = "circularGauge3_Label1";
            this.labelComponent3.Text = "RAM";
            this.labelComponent3.ZOrder = -1001;
            // 
            // BarRam
            // 
            this.BarRam.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.BarRam.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.BarRam.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.BarRam.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.BarRam.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.BarRam.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            this.BarRam.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.BarRam.EndAngle = -45F;
            this.BarRam.MajorTickCount = 0;
            this.BarRam.MajorTickmark.FormatString = "{0:F0}";
            this.BarRam.MajorTickmark.ShapeOffset = -14F;
            this.BarRam.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1;
            this.BarRam.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.BarRam.MaxValue = 100F;
            this.BarRam.MinorTickCount = 0;
            this.BarRam.MinorTickmark.ShapeOffset = -7F;
            this.BarRam.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2;
            this.BarRam.Name = "scale1";
            this.BarRam.StartAngle = -270F;
            // 
            // arcScaleRangeBarComponent2
            // 
            this.arcScaleRangeBarComponent2.AppearanceRangeBar.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gold");
            this.arcScaleRangeBarComponent2.ArcScale = this.BarRam;
            this.arcScaleRangeBarComponent2.Name = "circularGauge3_RangeBar2";
            this.arcScaleRangeBarComponent2.RoundedCaps = true;
            this.arcScaleRangeBarComponent2.ShowBackground = true;
            this.arcScaleRangeBarComponent2.StartOffset = 79F;
            this.arcScaleRangeBarComponent2.ZOrder = -10;
            // 
            // circularGauge1
            // 
            this.circularGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 108, 108);
            this.circularGauge1.Labels.AddRange(new DevExpress.XtraGauges.Win.Base.LabelComponent[] {
            this.labelComponent4});
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.RangeBars.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent[] {
            this.arcScaleRangeBarComponent1});
            this.circularGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.BarCpu});
            // 
            // labelComponent4
            // 
            this.labelComponent4.AppearanceText.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelComponent4.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:buttonface");
            this.labelComponent4.Name = "circularGauge3_Label1";
            this.labelComponent4.Text = "CPU";
            this.labelComponent4.ZOrder = -1001;
            // 
            // BarCpu
            // 
            this.BarCpu.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.BarCpu.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.BarCpu.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.BarCpu.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.BarCpu.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.BarCpu.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            this.BarCpu.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.BarCpu.EndAngle = -45F;
            this.BarCpu.MajorTickCount = 0;
            this.BarCpu.MajorTickmark.FormatString = "{0:F0}";
            this.BarCpu.MajorTickmark.ShapeOffset = -14F;
            this.BarCpu.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1;
            this.BarCpu.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.BarCpu.MaxValue = 100F;
            this.BarCpu.MinorTickCount = 0;
            this.BarCpu.MinorTickmark.ShapeOffset = -7F;
            this.BarCpu.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2;
            this.BarCpu.Name = "scale1";
            this.BarCpu.StartAngle = -270F;
            // 
            // arcScaleRangeBarComponent1
            // 
            this.arcScaleRangeBarComponent1.AppearanceRangeBar.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Orange");
            this.arcScaleRangeBarComponent1.ArcScale = this.BarCpu;
            this.arcScaleRangeBarComponent1.Name = "circularGauge3_RangeBar2";
            this.arcScaleRangeBarComponent1.RoundedCaps = true;
            this.arcScaleRangeBarComponent1.ShowBackground = true;
            this.arcScaleRangeBarComponent1.StartOffset = 79F;
            this.arcScaleRangeBarComponent1.ZOrder = -10;
            // 
            // performanceCounter3
            // 
            this.performanceCounter3.CategoryName = "LogicalDisk";
            this.performanceCounter3.CounterName = "% Disk Write Time";
            this.performanceCounter3.InstanceName = "_Total";
            // 
            // performanceCounter4
            // 
            this.performanceCounter4.CategoryName = "LogicalDisk";
            this.performanceCounter4.CounterName = "% Disk Read Time";
            this.performanceCounter4.InstanceName = "_Total";
            // 
            // gaugeControl5
            // 
            this.gaugeControl5.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl5.ColorScheme.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gaugeControl5.ColorScheme.TargetElements = ((DevExpress.XtraGauges.Win.TargetElement)(((DevExpress.XtraGauges.Win.TargetElement.RangeBar | DevExpress.XtraGauges.Win.TargetElement.ImageIndicator) 
            | DevExpress.XtraGauges.Win.TargetElement.Label)));
            this.gaugeControl5.Controls.Add(this.gaugeControl6);
            this.gaugeControl5.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge4});
            this.gaugeControl5.Location = new System.Drawing.Point(15, 264);
            this.gaugeControl5.MaximumSize = new System.Drawing.Size(120, 120);
            this.gaugeControl5.Name = "gaugeControl5";
            this.gaugeControl5.Size = new System.Drawing.Size(120, 120);
            this.gaugeControl5.TabIndex = 9;
            // 
            // gaugeControl6
            // 
            this.gaugeControl6.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl6.ColorScheme.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gaugeControl6.ColorScheme.TargetElements = ((DevExpress.XtraGauges.Win.TargetElement)(((DevExpress.XtraGauges.Win.TargetElement.RangeBar | DevExpress.XtraGauges.Win.TargetElement.ImageIndicator) 
            | DevExpress.XtraGauges.Win.TargetElement.Label)));
            this.gaugeControl6.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge3});
            this.gaugeControl6.Location = new System.Drawing.Point(10, 8);
            this.gaugeControl6.MaximumSize = new System.Drawing.Size(120, 120);
            this.gaugeControl6.Name = "gaugeControl6";
            this.gaugeControl6.Size = new System.Drawing.Size(102, 104);
            this.gaugeControl6.TabIndex = 10;
            // 
            // circularGauge3
            // 
            this.circularGauge3.Bounds = new System.Drawing.Rectangle(6, 6, 90, 92);
            this.circularGauge3.Name = "circularGauge3";
            this.circularGauge3.RangeBars.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent[] {
            this.arcScaleRangeBarComponent3});
            this.circularGauge3.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.BarWrite});
            // 
            // BarWrite
            // 
            this.BarWrite.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.BarWrite.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.BarWrite.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.BarWrite.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.BarWrite.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.BarWrite.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            this.BarWrite.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.BarWrite.EndAngle = -45F;
            this.BarWrite.MajorTickCount = 0;
            this.BarWrite.MajorTickmark.FormatString = "{0:F0}";
            this.BarWrite.MajorTickmark.ShapeOffset = -14F;
            this.BarWrite.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1;
            this.BarWrite.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.BarWrite.MaxValue = 100F;
            this.BarWrite.MinorTickCount = 0;
            this.BarWrite.MinorTickmark.ShapeOffset = -7F;
            this.BarWrite.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2;
            this.BarWrite.Name = "scale1";
            this.BarWrite.StartAngle = -270F;
            // 
            // arcScaleRangeBarComponent3
            // 
            this.arcScaleRangeBarComponent3.AppearanceRangeBar.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:DeepSkyBlue");
            this.arcScaleRangeBarComponent3.ArcScale = this.BarWrite;
            this.arcScaleRangeBarComponent3.Name = "circularGauge3_RangeBar2";
            this.arcScaleRangeBarComponent3.RoundedCaps = true;
            this.arcScaleRangeBarComponent3.ShowBackground = true;
            this.arcScaleRangeBarComponent3.StartOffset = 79F;
            this.arcScaleRangeBarComponent3.ZOrder = -10;
            // 
            // circularGauge4
            // 
            this.circularGauge4.Bounds = new System.Drawing.Rectangle(6, 6, 108, 108);
            this.circularGauge4.Labels.AddRange(new DevExpress.XtraGauges.Win.Base.LabelComponent[] {
            this.labelComponent1,
            this.labelComponent2,
            this.labelComponent5});
            this.circularGauge4.Name = "circularGauge4";
            this.circularGauge4.RangeBars.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent[] {
            this.arcScaleRangeBarComponent4});
            this.circularGauge4.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.BarRead});
            // 
            // labelComponent1
            // 
            this.labelComponent1.AppearanceText.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelComponent1.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:buttonface");
            this.labelComponent1.Name = "circularGauge3_Label1";
            this.labelComponent1.Text = "HDD";
            this.labelComponent1.ZOrder = -1001;
            // 
            // BarRead
            // 
            this.BarRead.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.BarRead.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.BarRead.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.BarRead.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.BarRead.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.BarRead.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            this.BarRead.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.BarRead.EndAngle = -45F;
            this.BarRead.MajorTickCount = 0;
            this.BarRead.MajorTickmark.FormatString = "{0:F0}";
            this.BarRead.MajorTickmark.ShapeOffset = -14F;
            this.BarRead.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1;
            this.BarRead.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.BarRead.MaxValue = 100F;
            this.BarRead.MinorTickCount = 0;
            this.BarRead.MinorTickmark.ShapeOffset = -7F;
            this.BarRead.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2;
            this.BarRead.Name = "scale1";
            this.BarRead.StartAngle = -270F;
            // 
            // arcScaleRangeBarComponent4
            // 
            this.arcScaleRangeBarComponent4.AppearanceRangeBar.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Chartreuse");
            this.arcScaleRangeBarComponent4.ArcScale = this.BarRead;
            this.arcScaleRangeBarComponent4.Name = "circularGauge3_RangeBar2";
            this.arcScaleRangeBarComponent4.RoundedCaps = true;
            this.arcScaleRangeBarComponent4.ShowBackground = true;
            this.arcScaleRangeBarComponent4.StartOffset = 79F;
            this.arcScaleRangeBarComponent4.ZOrder = -10;
            // 
            // labelComponent2
            // 
            this.labelComponent2.AppearanceText.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelComponent2.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:buttonface");
            this.labelComponent2.Name = "circularGauge4_Label2";
            this.labelComponent2.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(150F, 212F);
            this.labelComponent2.Size = new System.Drawing.SizeF(25F, 25F);
            this.labelComponent2.Text = "R";
            this.labelComponent2.ZOrder = -1001;
            // 
            // labelComponent5
            // 
            this.labelComponent5.AppearanceText.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelComponent5.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:buttonface");
            this.labelComponent5.Name = "circularGauge4_Label3";
            this.labelComponent5.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(150F, 198F);
            this.labelComponent5.Size = new System.Drawing.SizeF(25F, 25F);
            this.labelComponent5.Text = "W";
            this.labelComponent5.ZOrder = -1001;
            // 
            // frmAraclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(150, 600);
            this.Controls.Add(this.gaugeControl5);
            this.Controls.Add(this.gaugeControl2);
            this.Controls.Add(this.gaugeControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAraclar";
            this.Opacity = 0.95D;
            this.Text = "frmAraclar";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.frmAraclar_Deactivate);
            this.Load += new System.EventHandler(this.frmAraclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarCpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter4)).EndInit();
            this.gaugeControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarWrite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarRead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer timerDenetle;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Diagnostics.PerformanceCounter performanceCounter2;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl2;
        public System.Windows.Forms.Timer timerGoster;
        public System.Windows.Forms.Timer timerGizle;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Base.LabelComponent labelComponent4;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent arcScaleRangeBarComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent BarCpu;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge2;
        private DevExpress.XtraGauges.Win.Base.LabelComponent labelComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent arcScaleRangeBarComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent BarRam;
        private System.Diagnostics.PerformanceCounter performanceCounter3;
        private System.Diagnostics.PerformanceCounter performanceCounter4;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl5;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl6;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent arcScaleRangeBarComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent BarWrite;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge4;
        private DevExpress.XtraGauges.Win.Base.LabelComponent labelComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent arcScaleRangeBarComponent4;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent BarRead;
        private DevExpress.XtraGauges.Win.Base.LabelComponent labelComponent2;
        private DevExpress.XtraGauges.Win.Base.LabelComponent labelComponent5;
    }
}