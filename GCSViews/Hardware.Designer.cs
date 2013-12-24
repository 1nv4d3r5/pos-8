namespace ArdupilotMega.GCSViews
{
    partial class Hardware
    {




        

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hardware));
            this.imageLabel1 = new ArdupilotMega.Controls.ImageLabel();
            this.imageLabel2 = new ArdupilotMega.Controls.ImageLabel();
            this.imageLabel3 = new ArdupilotMega.Controls.ImageLabel();
            this.imageLabel4 = new ArdupilotMega.Controls.ImageLabel();
            this.imageLabel5 = new ArdupilotMega.Controls.ImageLabel();
            this.imageLabel6 = new ArdupilotMega.Controls.ImageLabel();
            this.imageLabel7 = new ArdupilotMega.Controls.ImageLabel();
            this.imageLabel8 = new ArdupilotMega.Controls.ImageLabel();
            this.imageLabel9 = new ArdupilotMega.Controls.ImageLabel();
            this.quickView11 = new ArdupilotMega.Controls.QuickView();
            this.currentStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Gauge1 = new AGaugeApp.AGauge();
            this.quickView1 = new ArdupilotMega.Controls.QuickView();
            this.quickView2 = new ArdupilotMega.Controls.QuickView();
            this.quickView3 = new ArdupilotMega.Controls.QuickView();
            this.quickView4 = new ArdupilotMega.Controls.QuickView();
            this.quickView5 = new ArdupilotMega.Controls.QuickView();
            this.quickView6 = new ArdupilotMega.Controls.QuickView();
            this.quickView7 = new ArdupilotMega.Controls.QuickView();
            this.aGauge1 = new AGaugeApp.AGauge();
            this.aGauge2 = new AGaugeApp.AGauge();
            this.aGauge3 = new AGaugeApp.AGauge();
            this.aGauge4 = new AGaugeApp.AGauge();
            this.aGauge5 = new AGaugeApp.AGauge();
            this.aGauge6 = new AGaugeApp.AGauge();
            this.aGauge7 = new AGaugeApp.AGauge();
            this.quickView8 = new ArdupilotMega.Controls.QuickView();
            this.imageLabel10 = new ArdupilotMega.Controls.ImageLabel();
            this.aGauge8 = new AGaugeApp.AGauge();
            ((System.ComponentModel.ISupportInitialize)(this.currentStateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imageLabel1
            // 
            this.imageLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.imageLabel1.Image = null;
            resources.ApplyResources(this.imageLabel1, "imageLabel1");
            this.imageLabel1.Name = "imageLabel1";
            // 
            // imageLabel2
            // 
            this.imageLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.imageLabel2.Image = global::ArdupilotMega.Properties.Resources.icon_battery_charging;
            resources.ApplyResources(this.imageLabel2, "imageLabel2");
            this.imageLabel2.Name = "imageLabel2";
            // 
            // imageLabel3
            // 
            this.imageLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imageLabel3.Image = global::ArdupilotMega.Properties.Resources.radio;
            resources.ApplyResources(this.imageLabel3, "imageLabel3");
            this.imageLabel3.Name = "imageLabel3";
            // 
            // imageLabel4
            // 
            this.imageLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.imageLabel4.Image = global::ArdupilotMega.Properties.Resources.icon_battery_charging;
            resources.ApplyResources(this.imageLabel4, "imageLabel4");
            this.imageLabel4.Name = "imageLabel4";
            // 
            // imageLabel5
            // 
            this.imageLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.imageLabel5.Image = global::ArdupilotMega.Properties.Resources.processor;
            resources.ApplyResources(this.imageLabel5, "imageLabel5");
            this.imageLabel5.Name = "imageLabel5";
            // 
            // imageLabel6
            // 
            this.imageLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.imageLabel6.Image = global::ArdupilotMega.Properties.Resources.icon_battery_charging;
            resources.ApplyResources(this.imageLabel6, "imageLabel6");
            this.imageLabel6.Name = "imageLabel6";
            // 
            // imageLabel7
            // 
            this.imageLabel7.Image = ((System.Drawing.Image)(resources.GetObject("imageLabel7.Image")));
            resources.ApplyResources(this.imageLabel7, "imageLabel7");
            this.imageLabel7.Name = "imageLabel7";
            // 
            // imageLabel8
            // 
            this.imageLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.imageLabel8.Image = global::ArdupilotMega.Properties.Resources.icon_battery_charging;
            resources.ApplyResources(this.imageLabel8, "imageLabel8");
            this.imageLabel8.Name = "imageLabel8";
            // 
            // imageLabel9
            // 
            this.imageLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.imageLabel9.Image = global::ArdupilotMega.Properties.Resources.compass1;
            resources.ApplyResources(this.imageLabel9, "imageLabel9");
            this.imageLabel9.Name = "imageLabel9";
            // 
            // quickView11
            // 
            this.quickView11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView11.DataBindings.Add(new System.Windows.Forms.Binding("number", this.currentStateBindingSource, "rxrssi", true));
            this.quickView11.desc = "Baterai:";
            this.quickView11.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quickView11, "quickView11");
            this.quickView11.Name = "quickView11";
            this.quickView11.number = 0D;
            this.quickView11.numberColor = System.Drawing.Color.White;
            this.quickView11.Tag = "";
            // 
            // currentStateBindingSource
            // 
            this.currentStateBindingSource.DataSource = typeof(ArdupilotMega.CurrentState);
            // 
            // Gauge1
            // 
            this.Gauge1.BackColor = System.Drawing.Color.Transparent;
            this.Gauge1.BackgroundImage = global::ArdupilotMega.Properties.Resources.guagearus90;
            resources.ApplyResources(this.Gauge1, "Gauge1");
            this.Gauge1.BaseArcColor = System.Drawing.Color.Transparent;
            this.Gauge1.BaseArcRadius = 70;
            this.Gauge1.BaseArcStart = 135;
            this.Gauge1.BaseArcSweep = 0;
            this.Gauge1.BaseArcWidth = 2;
            this.Gauge1.basesize = new System.Drawing.Size(150, 150);
            this.Gauge1.Cap_Idx = ((byte)(0));
            this.Gauge1.CapColor = System.Drawing.Color.White;
            this.Gauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gauge1.CapPosition = new System.Drawing.Point(58, 85);
            this.Gauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gauge1.CapsText = new string[] {
        "Suhu",
        "",
        "",
        "",
        ""};
            this.Gauge1.CapText = "Suhu";
            this.Gauge1.Center = new System.Drawing.Point(75, 75);
            this.Gauge1.DataBindings.Add(new System.Windows.Forms.Binding("Value1", this.currentStateBindingSource, "ch5out", true));
            this.Gauge1.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.currentStateBindingSource, "roll", true));
            this.Gauge1.MaxValue = 10000F;
            this.Gauge1.MinValue = 0F;
            this.Gauge1.Name = "Gauge1";
            this.Gauge1.Need_Idx = ((byte)(3));
            this.Gauge1.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Gauge1.NeedleColor2 = System.Drawing.Color.Brown;
            this.Gauge1.NeedleEnabled = false;
            this.Gauge1.NeedleRadius = 70;
            this.Gauge1.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Gauge1.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.Gauge1.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.Gauge1.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.Gauge1.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Gauge1.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.Gauge1.NeedleType = 0;
            this.Gauge1.NeedleWidth = 2;
            this.Gauge1.Range_Idx = ((byte)(2));
            this.Gauge1.RangeColor = System.Drawing.Color.Orange;
            this.Gauge1.RangeEnabled = false;
            this.Gauge1.RangeEndValue = 50F;
            this.Gauge1.RangeInnerRadius = 1;
            this.Gauge1.RangeOuterRadius = 70;
            this.Gauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gauge1.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Gauge1.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.Gauge1.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Gauge1.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.Gauge1.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.Gauge1.RangeStartValue = 35F;
            this.Gauge1.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Gauge1.ScaleLinesInterInnerRadius = 52;
            this.Gauge1.ScaleLinesInterOuterRadius = 60;
            this.Gauge1.ScaleLinesInterWidth = 1;
            this.Gauge1.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Gauge1.ScaleLinesMajorInnerRadius = 50;
            this.Gauge1.ScaleLinesMajorOuterRadius = 60;
            this.Gauge1.ScaleLinesMajorStepValue = 10F;
            this.Gauge1.ScaleLinesMajorWidth = 2;
            this.Gauge1.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Gauge1.ScaleLinesMinorInnerRadius = 55;
            this.Gauge1.ScaleLinesMinorNumOf = 9;
            this.Gauge1.ScaleLinesMinorOuterRadius = 60;
            this.Gauge1.ScaleLinesMinorWidth = 1;
            this.Gauge1.ScaleNumbersColor = System.Drawing.Color.White;
            this.Gauge1.ScaleNumbersFormat = null;
            this.Gauge1.ScaleNumbersRadius = 42;
            this.Gauge1.ScaleNumbersRotation = 0;
            this.Gauge1.ScaleNumbersStartScaleLine = 1;
            this.Gauge1.ScaleNumbersStepScaleLines = 1;
            this.Gauge1.Value = 0F;
            this.Gauge1.Value0 = 0F;
            this.Gauge1.Value1 = 0F;
            this.Gauge1.Value2 = 0F;
            this.Gauge1.Value3 = 0F;
            // 
            // quickView1
            // 
            this.quickView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.quickView1.DataBindings.Add(new System.Windows.Forms.Binding("number", this.currentStateBindingSource, "ch1in", true));
            this.quickView1.desc = "Baterai 1:";
            this.quickView1.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quickView1, "quickView1");
            this.quickView1.Name = "quickView1";
            this.quickView1.number = 0D;
            this.quickView1.numberColor = System.Drawing.Color.White;
            this.quickView1.Tag = "";
            // 
            // quickView2
            // 
            this.quickView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.quickView2.DataBindings.Add(new System.Windows.Forms.Binding("number", this.currentStateBindingSource, "ch7in", true));
            this.quickView2.desc = "Modul TNC:";
            this.quickView2.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quickView2, "quickView2");
            this.quickView2.Name = "quickView2";
            this.quickView2.number = 0D;
            this.quickView2.numberColor = System.Drawing.Color.White;
            this.quickView2.Tag = "";
            // 
            // quickView3
            // 
            this.quickView3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.quickView3.DataBindings.Add(new System.Windows.Forms.Binding("number", this.currentStateBindingSource, "ch2in", true));
            this.quickView3.desc = "Batterai 2:";
            this.quickView3.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quickView3, "quickView3");
            this.quickView3.Name = "quickView3";
            this.quickView3.number = 0D;
            this.quickView3.numberColor = System.Drawing.Color.White;
            this.quickView3.Tag = "";
            // 
            // quickView4
            // 
            this.quickView4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.quickView4.DataBindings.Add(new System.Windows.Forms.Binding("number", this.currentStateBindingSource, "ch6in", true));
            this.quickView4.desc = "OBDH :";
            this.quickView4.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quickView4, "quickView4");
            this.quickView4.Name = "quickView4";
            this.quickView4.number = 0D;
            this.quickView4.numberColor = System.Drawing.Color.White;
            this.quickView4.Tag = "";
            // 
            // quickView5
            // 
            this.quickView5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.quickView5.DataBindings.Add(new System.Windows.Forms.Binding("number", this.currentStateBindingSource, "ch3in", true));
            this.quickView5.desc = "Batterai 3:";
            this.quickView5.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quickView5, "quickView5");
            this.quickView5.Name = "quickView5";
            this.quickView5.number = 0D;
            this.quickView5.numberColor = System.Drawing.Color.White;
            this.quickView5.Tag = "";
            // 
            // quickView6
            // 
            this.quickView6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.quickView6.DataBindings.Add(new System.Windows.Forms.Binding("number", this.currentStateBindingSource, "ch4in", true));
            this.quickView6.desc = "Batterai 4:";
            this.quickView6.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quickView6, "quickView6");
            this.quickView6.Name = "quickView6";
            this.quickView6.number = 0D;
            this.quickView6.numberColor = System.Drawing.Color.White;
            this.quickView6.Tag = "";
            // 
            // quickView7
            // 
            this.quickView7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.quickView7.DataBindings.Add(new System.Windows.Forms.Binding("number", this.currentStateBindingSource, "ch6in", true));
            this.quickView7.desc = "Modul IMU:";
            this.quickView7.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quickView7, "quickView7");
            this.quickView7.Name = "quickView7";
            this.quickView7.number = 0D;
            this.quickView7.numberColor = System.Drawing.Color.White;
            this.quickView7.Tag = "";
            // 
            // aGauge1
            // 
            this.aGauge1.BackColor = System.Drawing.Color.Transparent;
            this.aGauge1.BackgroundImage = global::ArdupilotMega.Properties.Resources.guagearus90;
            resources.ApplyResources(this.aGauge1, "aGauge1");
            this.aGauge1.BaseArcColor = System.Drawing.Color.Transparent;
            this.aGauge1.BaseArcRadius = 70;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 315;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.basesize = new System.Drawing.Size(150, 150);
            this.aGauge1.Cap_Idx = ((byte)(0));
            this.aGauge1.CapColor = System.Drawing.Color.White;
            this.aGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge1.CapPosition = new System.Drawing.Point(58, 85);
            this.aGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge1.CapsText = new string[] {
        "Suhu",
        "",
        "",
        "",
        ""};
            this.aGauge1.CapText = "Suhu";
            this.aGauge1.Center = new System.Drawing.Point(75, 75);
            this.aGauge1.MaxValue = 70F;
            this.aGauge1.MinValue = -15F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.Need_Idx = ((byte)(3));
            this.aGauge1.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.Brown;
            this.aGauge1.NeedleEnabled = false;
            this.aGauge1.NeedleRadius = 70;
            this.aGauge1.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge1.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.aGauge1.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.aGauge1.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.aGauge1.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge1.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.aGauge1.NeedleType = 0;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.Range_Idx = ((byte)(2));
            this.aGauge1.RangeColor = System.Drawing.Color.Orange;
            this.aGauge1.RangeEnabled = false;
            this.aGauge1.RangeEndValue = 50F;
            this.aGauge1.RangeInnerRadius = 1;
            this.aGauge1.RangeOuterRadius = 70;
            this.aGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge1.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge1.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.aGauge1.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.aGauge1.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.aGauge1.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.aGauge1.RangeStartValue = 35F;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.White;
            this.aGauge1.ScaleLinesInterInnerRadius = 52;
            this.aGauge1.ScaleLinesInterOuterRadius = 60;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.aGauge1.ScaleLinesMajorInnerRadius = 50;
            this.aGauge1.ScaleLinesMajorOuterRadius = 60;
            this.aGauge1.ScaleLinesMajorStepValue = 10F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.aGauge1.ScaleLinesMinorInnerRadius = 55;
            this.aGauge1.ScaleLinesMinorNumOf = 9;
            this.aGauge1.ScaleLinesMinorOuterRadius = 60;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 42;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 1;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Value = 0F;
            this.aGauge1.Value0 = 0F;
            this.aGauge1.Value1 = 0F;
            this.aGauge1.Value2 = 0F;
            this.aGauge1.Value3 = 0F;
            // 
            // aGauge2
            // 
            this.aGauge2.BackColor = System.Drawing.Color.Transparent;
            this.aGauge2.BackgroundImage = global::ArdupilotMega.Properties.Resources.guagearus90;
            resources.ApplyResources(this.aGauge2, "aGauge2");
            this.aGauge2.BaseArcColor = System.Drawing.Color.Transparent;
            this.aGauge2.BaseArcRadius = 70;
            this.aGauge2.BaseArcStart = 135;
            this.aGauge2.BaseArcSweep = 315;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.basesize = new System.Drawing.Size(150, 150);
            this.aGauge2.Cap_Idx = ((byte)(0));
            this.aGauge2.CapColor = System.Drawing.Color.White;
            this.aGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge2.CapPosition = new System.Drawing.Point(58, 85);
            this.aGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge2.CapsText = new string[] {
        "Suhu",
        "",
        "",
        "",
        ""};
            this.aGauge2.CapText = "Suhu";
            this.aGauge2.Center = new System.Drawing.Point(75, 75);
            this.aGauge2.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.currentStateBindingSource, "ch7in", true));
            this.aGauge2.DataBindings.Add(new System.Windows.Forms.Binding("Value1", this.currentStateBindingSource, "ch7in", true));
            this.aGauge2.MaxValue = 70F;
            this.aGauge2.MinValue = -15F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.Need_Idx = ((byte)(3));
            this.aGauge2.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.Brown;
            this.aGauge2.NeedleEnabled = false;
            this.aGauge2.NeedleRadius = 70;
            this.aGauge2.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge2.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.aGauge2.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.aGauge2.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.aGauge2.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge2.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.aGauge2.NeedleType = 0;
            this.aGauge2.NeedleWidth = 2;
            this.aGauge2.Range_Idx = ((byte)(2));
            this.aGauge2.RangeColor = System.Drawing.Color.Orange;
            this.aGauge2.RangeEnabled = false;
            this.aGauge2.RangeEndValue = 50F;
            this.aGauge2.RangeInnerRadius = 1;
            this.aGauge2.RangeOuterRadius = 70;
            this.aGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge2.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge2.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.aGauge2.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.aGauge2.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.aGauge2.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.aGauge2.RangeStartValue = 35F;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.White;
            this.aGauge2.ScaleLinesInterInnerRadius = 52;
            this.aGauge2.ScaleLinesInterOuterRadius = 60;
            this.aGauge2.ScaleLinesInterWidth = 1;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.aGauge2.ScaleLinesMajorInnerRadius = 50;
            this.aGauge2.ScaleLinesMajorOuterRadius = 60;
            this.aGauge2.ScaleLinesMajorStepValue = 10F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.aGauge2.ScaleLinesMinorInnerRadius = 55;
            this.aGauge2.ScaleLinesMinorNumOf = 9;
            this.aGauge2.ScaleLinesMinorOuterRadius = 60;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 42;
            this.aGauge2.ScaleNumbersRotation = 0;
            this.aGauge2.ScaleNumbersStartScaleLine = 1;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Value = 0F;
            this.aGauge2.Value0 = 0F;
            this.aGauge2.Value1 = 0F;
            this.aGauge2.Value2 = 0F;
            this.aGauge2.Value3 = 0F;
            // 
            // aGauge3
            // 
            this.aGauge3.BackColor = System.Drawing.Color.Transparent;
            this.aGauge3.BackgroundImage = global::ArdupilotMega.Properties.Resources.guagearus90;
            resources.ApplyResources(this.aGauge3, "aGauge3");
            this.aGauge3.BaseArcColor = System.Drawing.Color.Transparent;
            this.aGauge3.BaseArcRadius = 70;
            this.aGauge3.BaseArcStart = 135;
            this.aGauge3.BaseArcSweep = 315;
            this.aGauge3.BaseArcWidth = 2;
            this.aGauge3.basesize = new System.Drawing.Size(150, 150);
            this.aGauge3.Cap_Idx = ((byte)(0));
            this.aGauge3.CapColor = System.Drawing.Color.White;
            this.aGauge3.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge3.CapPosition = new System.Drawing.Point(58, 85);
            this.aGauge3.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge3.CapsText = new string[] {
        "Suhu",
        "",
        "",
        "",
        ""};
            this.aGauge3.CapText = "Suhu";
            this.aGauge3.Center = new System.Drawing.Point(75, 75);
            this.aGauge3.MaxValue = 70F;
            this.aGauge3.MinValue = -15F;
            this.aGauge3.Name = "aGauge3";
            this.aGauge3.Need_Idx = ((byte)(3));
            this.aGauge3.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge3.NeedleColor2 = System.Drawing.Color.Brown;
            this.aGauge3.NeedleEnabled = false;
            this.aGauge3.NeedleRadius = 70;
            this.aGauge3.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge3.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.aGauge3.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.aGauge3.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.aGauge3.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge3.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.aGauge3.NeedleType = 0;
            this.aGauge3.NeedleWidth = 2;
            this.aGauge3.Range_Idx = ((byte)(2));
            this.aGauge3.RangeColor = System.Drawing.Color.Orange;
            this.aGauge3.RangeEnabled = false;
            this.aGauge3.RangeEndValue = 50F;
            this.aGauge3.RangeInnerRadius = 1;
            this.aGauge3.RangeOuterRadius = 70;
            this.aGauge3.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge3.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge3.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.aGauge3.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.aGauge3.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.aGauge3.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.aGauge3.RangeStartValue = 35F;
            this.aGauge3.ScaleLinesInterColor = System.Drawing.Color.White;
            this.aGauge3.ScaleLinesInterInnerRadius = 52;
            this.aGauge3.ScaleLinesInterOuterRadius = 60;
            this.aGauge3.ScaleLinesInterWidth = 1;
            this.aGauge3.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.aGauge3.ScaleLinesMajorInnerRadius = 50;
            this.aGauge3.ScaleLinesMajorOuterRadius = 60;
            this.aGauge3.ScaleLinesMajorStepValue = 10F;
            this.aGauge3.ScaleLinesMajorWidth = 2;
            this.aGauge3.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.aGauge3.ScaleLinesMinorInnerRadius = 55;
            this.aGauge3.ScaleLinesMinorNumOf = 9;
            this.aGauge3.ScaleLinesMinorOuterRadius = 60;
            this.aGauge3.ScaleLinesMinorWidth = 1;
            this.aGauge3.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge3.ScaleNumbersFormat = null;
            this.aGauge3.ScaleNumbersRadius = 42;
            this.aGauge3.ScaleNumbersRotation = 0;
            this.aGauge3.ScaleNumbersStartScaleLine = 1;
            this.aGauge3.ScaleNumbersStepScaleLines = 1;
            this.aGauge3.Value = 0F;
            this.aGauge3.Value0 = 0F;
            this.aGauge3.Value1 = 0F;
            this.aGauge3.Value2 = 0F;
            this.aGauge3.Value3 = 0F;
            // 
            // aGauge4
            // 
            this.aGauge4.BackColor = System.Drawing.Color.Transparent;
            this.aGauge4.BackgroundImage = global::ArdupilotMega.Properties.Resources.guagearus90;
            resources.ApplyResources(this.aGauge4, "aGauge4");
            this.aGauge4.BaseArcColor = System.Drawing.Color.Transparent;
            this.aGauge4.BaseArcRadius = 70;
            this.aGauge4.BaseArcStart = 135;
            this.aGauge4.BaseArcSweep = 315;
            this.aGauge4.BaseArcWidth = 2;
            this.aGauge4.basesize = new System.Drawing.Size(150, 150);
            this.aGauge4.Cap_Idx = ((byte)(0));
            this.aGauge4.CapColor = System.Drawing.Color.White;
            this.aGauge4.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge4.CapPosition = new System.Drawing.Point(58, 85);
            this.aGauge4.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge4.CapsText = new string[] {
        "Suhu",
        "",
        "",
        "",
        ""};
            this.aGauge4.CapText = "Suhu";
            this.aGauge4.Center = new System.Drawing.Point(75, 75);
            this.aGauge4.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.currentStateBindingSource, "ch6in", true));
            this.aGauge4.DataBindings.Add(new System.Windows.Forms.Binding("Value1", this.currentStateBindingSource, "ch6in", true));
            this.aGauge4.MaxValue = 70F;
            this.aGauge4.MinValue = -15F;
            this.aGauge4.Name = "aGauge4";
            this.aGauge4.Need_Idx = ((byte)(3));
            this.aGauge4.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge4.NeedleColor2 = System.Drawing.Color.Brown;
            this.aGauge4.NeedleEnabled = false;
            this.aGauge4.NeedleRadius = 70;
            this.aGauge4.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge4.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.aGauge4.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.aGauge4.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.aGauge4.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge4.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.aGauge4.NeedleType = 0;
            this.aGauge4.NeedleWidth = 2;
            this.aGauge4.Range_Idx = ((byte)(2));
            this.aGauge4.RangeColor = System.Drawing.Color.Orange;
            this.aGauge4.RangeEnabled = false;
            this.aGauge4.RangeEndValue = 50F;
            this.aGauge4.RangeInnerRadius = 1;
            this.aGauge4.RangeOuterRadius = 70;
            this.aGauge4.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge4.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge4.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.aGauge4.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.aGauge4.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.aGauge4.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.aGauge4.RangeStartValue = 35F;
            this.aGauge4.ScaleLinesInterColor = System.Drawing.Color.White;
            this.aGauge4.ScaleLinesInterInnerRadius = 52;
            this.aGauge4.ScaleLinesInterOuterRadius = 60;
            this.aGauge4.ScaleLinesInterWidth = 1;
            this.aGauge4.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.aGauge4.ScaleLinesMajorInnerRadius = 50;
            this.aGauge4.ScaleLinesMajorOuterRadius = 60;
            this.aGauge4.ScaleLinesMajorStepValue = 10F;
            this.aGauge4.ScaleLinesMajorWidth = 2;
            this.aGauge4.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.aGauge4.ScaleLinesMinorInnerRadius = 55;
            this.aGauge4.ScaleLinesMinorNumOf = 9;
            this.aGauge4.ScaleLinesMinorOuterRadius = 60;
            this.aGauge4.ScaleLinesMinorWidth = 1;
            this.aGauge4.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge4.ScaleNumbersFormat = null;
            this.aGauge4.ScaleNumbersRadius = 42;
            this.aGauge4.ScaleNumbersRotation = 0;
            this.aGauge4.ScaleNumbersStartScaleLine = 1;
            this.aGauge4.ScaleNumbersStepScaleLines = 1;
            this.aGauge4.Value = 0F;
            this.aGauge4.Value0 = 0F;
            this.aGauge4.Value1 = 0F;
            this.aGauge4.Value2 = 0F;
            this.aGauge4.Value3 = 0F;
            // 
            // aGauge5
            // 
            this.aGauge5.BackColor = System.Drawing.Color.Transparent;
            this.aGauge5.BackgroundImage = global::ArdupilotMega.Properties.Resources.guagearus90;
            resources.ApplyResources(this.aGauge5, "aGauge5");
            this.aGauge5.BaseArcColor = System.Drawing.Color.Transparent;
            this.aGauge5.BaseArcRadius = 70;
            this.aGauge5.BaseArcStart = 135;
            this.aGauge5.BaseArcSweep = 315;
            this.aGauge5.BaseArcWidth = 2;
            this.aGauge5.basesize = new System.Drawing.Size(150, 150);
            this.aGauge5.Cap_Idx = ((byte)(0));
            this.aGauge5.CapColor = System.Drawing.Color.White;
            this.aGauge5.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge5.CapPosition = new System.Drawing.Point(58, 85);
            this.aGauge5.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge5.CapsText = new string[] {
        "Suhu",
        "",
        "",
        "",
        ""};
            this.aGauge5.CapText = "Suhu";
            this.aGauge5.Center = new System.Drawing.Point(75, 75);
            this.aGauge5.MaxValue = 70F;
            this.aGauge5.MinValue = -15F;
            this.aGauge5.Name = "aGauge5";
            this.aGauge5.Need_Idx = ((byte)(3));
            this.aGauge5.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge5.NeedleColor2 = System.Drawing.Color.Brown;
            this.aGauge5.NeedleEnabled = false;
            this.aGauge5.NeedleRadius = 70;
            this.aGauge5.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge5.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.aGauge5.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.aGauge5.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.aGauge5.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge5.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.aGauge5.NeedleType = 0;
            this.aGauge5.NeedleWidth = 2;
            this.aGauge5.Range_Idx = ((byte)(2));
            this.aGauge5.RangeColor = System.Drawing.Color.Orange;
            this.aGauge5.RangeEnabled = false;
            this.aGauge5.RangeEndValue = 50F;
            this.aGauge5.RangeInnerRadius = 1;
            this.aGauge5.RangeOuterRadius = 70;
            this.aGauge5.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge5.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge5.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.aGauge5.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.aGauge5.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.aGauge5.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.aGauge5.RangeStartValue = 35F;
            this.aGauge5.ScaleLinesInterColor = System.Drawing.Color.White;
            this.aGauge5.ScaleLinesInterInnerRadius = 52;
            this.aGauge5.ScaleLinesInterOuterRadius = 60;
            this.aGauge5.ScaleLinesInterWidth = 1;
            this.aGauge5.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.aGauge5.ScaleLinesMajorInnerRadius = 50;
            this.aGauge5.ScaleLinesMajorOuterRadius = 60;
            this.aGauge5.ScaleLinesMajorStepValue = 10F;
            this.aGauge5.ScaleLinesMajorWidth = 2;
            this.aGauge5.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.aGauge5.ScaleLinesMinorInnerRadius = 55;
            this.aGauge5.ScaleLinesMinorNumOf = 9;
            this.aGauge5.ScaleLinesMinorOuterRadius = 60;
            this.aGauge5.ScaleLinesMinorWidth = 1;
            this.aGauge5.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge5.ScaleNumbersFormat = null;
            this.aGauge5.ScaleNumbersRadius = 42;
            this.aGauge5.ScaleNumbersRotation = 0;
            this.aGauge5.ScaleNumbersStartScaleLine = 1;
            this.aGauge5.ScaleNumbersStepScaleLines = 1;
            this.aGauge5.Value = 0F;
            this.aGauge5.Value0 = 0F;
            this.aGauge5.Value1 = 0F;
            this.aGauge5.Value2 = 0F;
            this.aGauge5.Value3 = 0F;
            // 
            // aGauge6
            // 
            this.aGauge6.BackColor = System.Drawing.Color.Transparent;
            this.aGauge6.BackgroundImage = global::ArdupilotMega.Properties.Resources.guagearus90;
            resources.ApplyResources(this.aGauge6, "aGauge6");
            this.aGauge6.BaseArcColor = System.Drawing.Color.Transparent;
            this.aGauge6.BaseArcRadius = 70;
            this.aGauge6.BaseArcStart = 135;
            this.aGauge6.BaseArcSweep = 315;
            this.aGauge6.BaseArcWidth = 2;
            this.aGauge6.basesize = new System.Drawing.Size(150, 150);
            this.aGauge6.Cap_Idx = ((byte)(0));
            this.aGauge6.CapColor = System.Drawing.Color.White;
            this.aGauge6.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge6.CapPosition = new System.Drawing.Point(58, 85);
            this.aGauge6.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge6.CapsText = new string[] {
        "Suhu",
        "",
        "",
        "",
        ""};
            this.aGauge6.CapText = "Suhu";
            this.aGauge6.Center = new System.Drawing.Point(75, 75);
            this.aGauge6.MaxValue = 70F;
            this.aGauge6.MinValue = -15F;
            this.aGauge6.Name = "aGauge6";
            this.aGauge6.Need_Idx = ((byte)(3));
            this.aGauge6.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge6.NeedleColor2 = System.Drawing.Color.Brown;
            this.aGauge6.NeedleEnabled = false;
            this.aGauge6.NeedleRadius = 70;
            this.aGauge6.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge6.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.aGauge6.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.aGauge6.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.aGauge6.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge6.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.aGauge6.NeedleType = 0;
            this.aGauge6.NeedleWidth = 2;
            this.aGauge6.Range_Idx = ((byte)(2));
            this.aGauge6.RangeColor = System.Drawing.Color.Orange;
            this.aGauge6.RangeEnabled = false;
            this.aGauge6.RangeEndValue = 50F;
            this.aGauge6.RangeInnerRadius = 1;
            this.aGauge6.RangeOuterRadius = 70;
            this.aGauge6.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge6.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge6.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.aGauge6.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.aGauge6.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.aGauge6.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.aGauge6.RangeStartValue = 35F;
            this.aGauge6.ScaleLinesInterColor = System.Drawing.Color.White;
            this.aGauge6.ScaleLinesInterInnerRadius = 52;
            this.aGauge6.ScaleLinesInterOuterRadius = 60;
            this.aGauge6.ScaleLinesInterWidth = 1;
            this.aGauge6.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.aGauge6.ScaleLinesMajorInnerRadius = 50;
            this.aGauge6.ScaleLinesMajorOuterRadius = 60;
            this.aGauge6.ScaleLinesMajorStepValue = 10F;
            this.aGauge6.ScaleLinesMajorWidth = 2;
            this.aGauge6.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.aGauge6.ScaleLinesMinorInnerRadius = 55;
            this.aGauge6.ScaleLinesMinorNumOf = 9;
            this.aGauge6.ScaleLinesMinorOuterRadius = 60;
            this.aGauge6.ScaleLinesMinorWidth = 1;
            this.aGauge6.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge6.ScaleNumbersFormat = null;
            this.aGauge6.ScaleNumbersRadius = 42;
            this.aGauge6.ScaleNumbersRotation = 0;
            this.aGauge6.ScaleNumbersStartScaleLine = 1;
            this.aGauge6.ScaleNumbersStepScaleLines = 1;
            this.aGauge6.Value = 0F;
            this.aGauge6.Value0 = 0F;
            this.aGauge6.Value1 = 0F;
            this.aGauge6.Value2 = 0F;
            this.aGauge6.Value3 = 0F;
            // 
            // aGauge7
            // 
            this.aGauge7.BackColor = System.Drawing.Color.Transparent;
            this.aGauge7.BackgroundImage = global::ArdupilotMega.Properties.Resources.guagearus90;
            resources.ApplyResources(this.aGauge7, "aGauge7");
            this.aGauge7.BaseArcColor = System.Drawing.Color.Transparent;
            this.aGauge7.BaseArcRadius = 70;
            this.aGauge7.BaseArcStart = 135;
            this.aGauge7.BaseArcSweep = 315;
            this.aGauge7.BaseArcWidth = 2;
            this.aGauge7.basesize = new System.Drawing.Size(150, 150);
            this.aGauge7.Cap_Idx = ((byte)(0));
            this.aGauge7.CapColor = System.Drawing.Color.White;
            this.aGauge7.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge7.CapPosition = new System.Drawing.Point(58, 85);
            this.aGauge7.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge7.CapsText = new string[] {
        "Suhu",
        "",
        "",
        "",
        ""};
            this.aGauge7.CapText = "Suhu";
            this.aGauge7.Center = new System.Drawing.Point(75, 75);
            this.aGauge7.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.currentStateBindingSource, "ch6in", true));
            this.aGauge7.DataBindings.Add(new System.Windows.Forms.Binding("Value1", this.currentStateBindingSource, "ch6out", true));
            this.aGauge7.MaxValue = 70F;
            this.aGauge7.MinValue = -15F;
            this.aGauge7.Name = "aGauge7";
            this.aGauge7.Need_Idx = ((byte)(3));
            this.aGauge7.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge7.NeedleColor2 = System.Drawing.Color.Brown;
            this.aGauge7.NeedleEnabled = false;
            this.aGauge7.NeedleRadius = 70;
            this.aGauge7.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge7.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.aGauge7.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.aGauge7.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.aGauge7.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge7.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.aGauge7.NeedleType = 0;
            this.aGauge7.NeedleWidth = 2;
            this.aGauge7.Range_Idx = ((byte)(2));
            this.aGauge7.RangeColor = System.Drawing.Color.Orange;
            this.aGauge7.RangeEnabled = false;
            this.aGauge7.RangeEndValue = 50F;
            this.aGauge7.RangeInnerRadius = 1;
            this.aGauge7.RangeOuterRadius = 70;
            this.aGauge7.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge7.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge7.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.aGauge7.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.aGauge7.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.aGauge7.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.aGauge7.RangeStartValue = 35F;
            this.aGauge7.ScaleLinesInterColor = System.Drawing.Color.White;
            this.aGauge7.ScaleLinesInterInnerRadius = 52;
            this.aGauge7.ScaleLinesInterOuterRadius = 60;
            this.aGauge7.ScaleLinesInterWidth = 1;
            this.aGauge7.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.aGauge7.ScaleLinesMajorInnerRadius = 50;
            this.aGauge7.ScaleLinesMajorOuterRadius = 60;
            this.aGauge7.ScaleLinesMajorStepValue = 10F;
            this.aGauge7.ScaleLinesMajorWidth = 2;
            this.aGauge7.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.aGauge7.ScaleLinesMinorInnerRadius = 55;
            this.aGauge7.ScaleLinesMinorNumOf = 9;
            this.aGauge7.ScaleLinesMinorOuterRadius = 60;
            this.aGauge7.ScaleLinesMinorWidth = 1;
            this.aGauge7.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge7.ScaleNumbersFormat = null;
            this.aGauge7.ScaleNumbersRadius = 42;
            this.aGauge7.ScaleNumbersRotation = 0;
            this.aGauge7.ScaleNumbersStartScaleLine = 1;
            this.aGauge7.ScaleNumbersStepScaleLines = 1;
            this.aGauge7.Value = 0F;
            this.aGauge7.Value0 = 2000F;
            this.aGauge7.Value1 = 2000F;
            this.aGauge7.Value2 = 0F;
            this.aGauge7.Value3 = 0F;
            // 
            // quickView8
            // 
            this.quickView8.BackColor = System.Drawing.Color.Red;
            this.quickView8.DataBindings.Add(new System.Windows.Forms.Binding("number", this.currentStateBindingSource, "ch4in", true));
            this.quickView8.desc = "Power :";
            this.quickView8.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quickView8, "quickView8");
            this.quickView8.Name = "quickView8";
            this.quickView8.number = 0D;
            this.quickView8.numberColor = System.Drawing.Color.White;
            this.quickView8.Tag = "";
            // 
            // imageLabel10
            // 
            this.imageLabel10.BackColor = System.Drawing.Color.Red;
            this.imageLabel10.BackgroundImage = global::ArdupilotMega.Properties.Resources.power;
            this.imageLabel10.Image = null;
            resources.ApplyResources(this.imageLabel10, "imageLabel10");
            this.imageLabel10.Name = "imageLabel10";
            // 
            // aGauge8
            // 
            this.aGauge8.BackColor = System.Drawing.Color.Transparent;
            this.aGauge8.BackgroundImage = global::ArdupilotMega.Properties.Resources.guagearus90;
            resources.ApplyResources(this.aGauge8, "aGauge8");
            this.aGauge8.BaseArcColor = System.Drawing.Color.Transparent;
            this.aGauge8.BaseArcRadius = 70;
            this.aGauge8.BaseArcStart = 135;
            this.aGauge8.BaseArcSweep = 0;
            this.aGauge8.BaseArcWidth = 2;
            this.aGauge8.basesize = new System.Drawing.Size(150, 150);
            this.aGauge8.Cap_Idx = ((byte)(0));
            this.aGauge8.CapColor = System.Drawing.Color.White;
            this.aGauge8.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge8.CapPosition = new System.Drawing.Point(58, 85);
            this.aGauge8.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge8.CapsText = new string[] {
        "Suhu",
        "",
        "",
        "",
        ""};
            this.aGauge8.CapText = "Suhu";
            this.aGauge8.Center = new System.Drawing.Point(75, 75);
            this.aGauge8.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.currentStateBindingSource, "ch5in", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.aGauge8.DataBindings.Add(new System.Windows.Forms.Binding("Value1", this.currentStateBindingSource, "ch5in", true));
            this.aGauge8.MaxValue = 70F;
            this.aGauge8.MinValue = 20F;
            this.aGauge8.Name = "aGauge8";
            this.aGauge8.Need_Idx = ((byte)(3));
            this.aGauge8.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge8.NeedleColor2 = System.Drawing.Color.Brown;
            this.aGauge8.NeedleEnabled = false;
            this.aGauge8.NeedleRadius = 70;
            this.aGauge8.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge8.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.aGauge8.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.aGauge8.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.aGauge8.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge8.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.aGauge8.NeedleType = 0;
            this.aGauge8.NeedleWidth = 2;
            this.aGauge8.Range_Idx = ((byte)(2));
            this.aGauge8.RangeColor = System.Drawing.Color.Orange;
            this.aGauge8.RangeEnabled = false;
            this.aGauge8.RangeEndValue = 50F;
            this.aGauge8.RangeInnerRadius = 1;
            this.aGauge8.RangeOuterRadius = 70;
            this.aGauge8.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge8.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge8.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.aGauge8.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.aGauge8.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.aGauge8.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.aGauge8.RangeStartValue = 35F;
            this.aGauge8.ScaleLinesInterColor = System.Drawing.Color.White;
            this.aGauge8.ScaleLinesInterInnerRadius = 52;
            this.aGauge8.ScaleLinesInterOuterRadius = 60;
            this.aGauge8.ScaleLinesInterWidth = 1;
            this.aGauge8.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.aGauge8.ScaleLinesMajorInnerRadius = 50;
            this.aGauge8.ScaleLinesMajorOuterRadius = 60;
            this.aGauge8.ScaleLinesMajorStepValue = 10F;
            this.aGauge8.ScaleLinesMajorWidth = 2;
            this.aGauge8.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.aGauge8.ScaleLinesMinorInnerRadius = 55;
            this.aGauge8.ScaleLinesMinorNumOf = 9;
            this.aGauge8.ScaleLinesMinorOuterRadius = 60;
            this.aGauge8.ScaleLinesMinorWidth = 1;
            this.aGauge8.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge8.ScaleNumbersFormat = null;
            this.aGauge8.ScaleNumbersRadius = 42;
            this.aGauge8.ScaleNumbersRotation = 0;
            this.aGauge8.ScaleNumbersStartScaleLine = 1;
            this.aGauge8.ScaleNumbersStepScaleLines = 1;
            this.aGauge8.Value = 0F;
            this.aGauge8.Value0 = 0F;
            this.aGauge8.Value1 = 0F;
            this.aGauge8.Value2 = 0F;
            this.aGauge8.Value3 = 0F;
            // 
            // Hardware
            // 
            this.Controls.Add(this.quickView8);
            this.Controls.Add(this.imageLabel10);
            this.Controls.Add(this.aGauge8);
            this.Controls.Add(this.quickView7);
            this.Controls.Add(this.quickView6);
            this.Controls.Add(this.quickView5);
            this.Controls.Add(this.quickView4);
            this.Controls.Add(this.quickView3);
            this.Controls.Add(this.quickView2);
            this.Controls.Add(this.quickView1);
            this.Controls.Add(this.quickView11);
            this.Controls.Add(this.imageLabel9);
            this.Controls.Add(this.imageLabel8);
            this.Controls.Add(this.imageLabel7);
            this.Controls.Add(this.imageLabel6);
            this.Controls.Add(this.imageLabel5);
            this.Controls.Add(this.imageLabel4);
            this.Controls.Add(this.imageLabel3);
            this.Controls.Add(this.imageLabel2);
            this.Controls.Add(this.imageLabel1);
            this.Controls.Add(this.Gauge1);
            this.Controls.Add(this.aGauge1);
            this.Controls.Add(this.aGauge2);
            this.Controls.Add(this.aGauge3);
            this.Controls.Add(this.aGauge4);
            this.Controls.Add(this.aGauge5);
            this.Controls.Add(this.aGauge6);
            this.Controls.Add(this.aGauge7);
            this.Name = "Hardware";
            resources.ApplyResources(this, "$this");
            this.Load += new System.EventHandler(this.Hardware_Load);
            this.Leave += new System.EventHandler(this.Hardware_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.currentStateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }


        private Controls.ImageLabel imageLabel1;
        private Controls.ImageLabel imageLabel2;
        private Controls.ImageLabel imageLabel3;
        private Controls.ImageLabel imageLabel4;
        private Controls.ImageLabel imageLabel5;
        private Controls.ImageLabel imageLabel6;
        private Controls.ImageLabel imageLabel7;
        private Controls.ImageLabel imageLabel8;
        private Controls.ImageLabel imageLabel9;
        private Controls.QuickView quickView11;
        private AGaugeApp.AGauge Gauge1;
        private Controls.QuickView quickView1;
        private Controls.QuickView quickView2;
        private Controls.QuickView quickView3;
        private Controls.QuickView quickView4;
        private Controls.QuickView quickView5;
        private Controls.QuickView quickView6;
        private Controls.QuickView quickView7;
        private AGaugeApp.AGauge aGauge1;
        private AGaugeApp.AGauge aGauge2;
        private AGaugeApp.AGauge aGauge3;
        private AGaugeApp.AGauge aGauge4;
        private AGaugeApp.AGauge aGauge5;
        private AGaugeApp.AGauge aGauge6;
        private AGaugeApp.AGauge aGauge7;
        private System.Windows.Forms.BindingSource currentStateBindingSource;
        private System.ComponentModel.IContainer components;
        private Controls.QuickView quickView8;
        private Controls.ImageLabel imageLabel10;
        private AGaugeApp.AGauge aGauge8;
    }
}
