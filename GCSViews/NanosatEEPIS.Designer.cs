namespace ArdupilotMega.GCSViews
{
    partial class NanosatEEPIS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NanosatEEPIS));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitBig = new System.Windows.Forms.SplitContainer();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.tabControlUmum = new System.Windows.Forms.TabControl();
            this.tabData = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.quickView31 = new ArdupilotMega.Controls.QuickView();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quickView34 = new ArdupilotMega.Controls.QuickView();
            this.quickView33 = new ArdupilotMega.Controls.QuickView();
            this.quickView32 = new ArdupilotMega.Controls.QuickView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.quickView21 = new ArdupilotMega.Controls.QuickView();
            this.quickView24 = new ArdupilotMega.Controls.QuickView();
            this.quickView23 = new ArdupilotMega.Controls.QuickView();
            this.quickView22 = new ArdupilotMega.Controls.QuickView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.quickView11 = new ArdupilotMega.Controls.QuickView();
            this.quickView13 = new ArdupilotMega.Controls.QuickView();
            this.quickView12 = new ArdupilotMega.Controls.QuickView();
            this.tabGrafik = new System.Windows.Forms.TabPage();
            this.grafik = new ZedGraph.ZedGraphControl();
            this.tabStatHard = new System.Windows.Forms.TabPage();
            this.Gauge3 = new AGaugeApp.AGauge();
            this.Gauge2 = new AGaugeApp.AGauge();
            this.Gauge1 = new AGaugeApp.AGauge();
            this.tabAll = new System.Windows.Forms.TabPage();
            this.splitSmall = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBoxGrafik = new System.Windows.Forms.CheckBox();
            this.checkDataSatelit = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.currentStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TGrafik = new System.Windows.Forms.Timer(this.components);
            this.ZedGraphTimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripMap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.goHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flyToHereAltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointCameraHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triggerCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightPlannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitBig.Panel1.SuspendLayout();
            this.splitBig.Panel2.SuspendLayout();
            this.splitBig.SuspendLayout();
            this.tabControlUmum.SuspendLayout();
            this.tabData.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabGrafik.SuspendLayout();
            this.tabStatHard.SuspendLayout();
            this.splitSmall.Panel1.SuspendLayout();
            this.splitSmall.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentStateBindingSource)).BeginInit();
            this.contextMenuStripMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitBig);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitSmall);
            // 
            // splitBig
            // 
            resources.ApplyResources(this.splitBig, "splitBig");
            this.splitBig.Name = "splitBig";
            // 
            // splitBig.Panel1
            // 
            this.splitBig.Panel1.Controls.Add(this.gMap);
            // 
            // splitBig.Panel2
            // 
            this.splitBig.Panel2.Controls.Add(this.tabControlUmum);
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.GrayScaleMode = false;
            this.gMap.LevelsKeepInMemmory = 5;
            resources.ApplyResources(this.gMap, "gMap");
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 19;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ShowTileGridLines = false;
            this.gMap.streamjpg = ((System.IO.MemoryStream)(resources.GetObject("gMap.streamjpg")));
            this.gMap.Zoom = 0D;
            this.gMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseDown);
            this.gMap.MouseLeave += new System.EventHandler(this.gMap_MouseLeave);
            this.gMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseMove);
            // 
            // tabControlUmum
            // 
            this.tabControlUmum.Controls.Add(this.tabData);
            this.tabControlUmum.Controls.Add(this.tabGrafik);
            this.tabControlUmum.Controls.Add(this.tabStatHard);
            this.tabControlUmum.Controls.Add(this.tabAll);
            resources.ApplyResources(this.tabControlUmum, "tabControlUmum");
            this.tabControlUmum.Name = "tabControlUmum";
            this.tabControlUmum.SelectedIndex = 0;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.tableLayoutPanel3);
            this.tabData.Controls.Add(this.tableLayoutPanel2);
            this.tabData.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.tabData, "tabData");
            this.tabData.Name = "tabData";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.quickView31, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.quickView34, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.quickView33, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.quickView32, 1, 0);
            this.tableLayoutPanel3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // quickView31
            // 
            this.quickView31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView31.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSource, "roll", true));
            this.quickView31.desc = "Roll:";
            this.quickView31.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quickView31, "quickView31");
            this.quickView31.Name = "quickView31";
            this.quickView31.number = 0D;
            this.quickView31.numberColor = System.Drawing.Color.White;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(ArdupilotMega.CurrentState);
            // 
            // quickView34
            // 
            this.quickView34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.quickView34.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSource, "magfield", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.quickView34.desc = "MagField:";
            this.quickView34.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quickView34, "quickView34");
            this.quickView34.Name = "quickView34";
            this.quickView34.number = 0D;
            this.quickView34.numberColor = System.Drawing.Color.White;
            this.quickView34.Tag = "";
            // 
            // quickView33
            // 
            this.quickView33.BackColor = System.Drawing.Color.Red;
            this.quickView33.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSource, "yaw", true));
            this.quickView33.desc = "Yaw:";
            this.quickView33.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quickView33, "quickView33");
            this.quickView33.Name = "quickView33";
            this.quickView33.number = 0D;
            this.quickView33.numberColor = System.Drawing.Color.White;
            // 
            // quickView32
            // 
            this.quickView32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.quickView32.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSource, "pitch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.quickView32.desc = "Pitch:";
            this.quickView32.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quickView32, "quickView32");
            this.quickView32.Name = "quickView32";
            this.quickView32.number = 0D;
            this.quickView32.numberColor = System.Drawing.Color.White;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.quickView21, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.quickView24, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.quickView23, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.quickView22, 1, 0);
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // quickView21
            // 
            this.quickView21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.quickView21.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingSource, "groundspeed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.quickView21.desc = "Speed:";
            this.quickView21.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quickView21, "quickView21");
            this.quickView21.Name = "quickView21";
            this.quickView21.number = 0D;
            this.quickView21.numberColor = System.Drawing.Color.White;
            // 
            // quickView24
            // 
            this.quickView24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.quickView24.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSource, "rssi", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.quickView24.desc = "RSSI:";
            this.quickView24.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quickView24, "quickView24");
            this.quickView24.Name = "quickView24";
            this.quickView24.number = 0D;
            this.quickView24.numberColor = System.Drawing.Color.White;
            // 
            // quickView23
            // 
            this.quickView23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView23.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSource, "pitch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.quickView23.desc = "Elevation:";
            this.quickView23.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quickView23, "quickView23");
            this.quickView23.Name = "quickView23";
            this.quickView23.number = 0D;
            this.quickView23.numberColor = System.Drawing.Color.White;
            // 
            // quickView22
            // 
            this.quickView22.BackColor = System.Drawing.Color.Green;
            this.quickView22.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSource, "yaw", true));
            this.quickView22.desc = "Azimuth:";
            this.quickView22.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quickView22, "quickView22");
            this.quickView22.Name = "quickView22";
            this.quickView22.number = 0D;
            this.quickView22.numberColor = System.Drawing.Color.White;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.quickView11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.quickView13, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.quickView12, 1, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // quickView11
            // 
            this.quickView11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView11.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSource, "alt", true));
            this.quickView11.desc = "Altitude:";
            this.quickView11.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quickView11, "quickView11");
            this.quickView11.Name = "quickView11";
            this.quickView11.number = 0D;
            this.quickView11.numberColor = System.Drawing.Color.White;
            this.quickView11.Tag = "";
            // 
            // quickView13
            // 
            this.quickView13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.quickView13.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSource, "lat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.quickView13.desc = "Lattitude";
            this.quickView13.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quickView13, "quickView13");
            this.quickView13.Name = "quickView13";
            this.quickView13.number = 0D;
            this.quickView13.numberColor = System.Drawing.Color.White;
            // 
            // quickView12
            // 
            this.quickView12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.quickView12.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSource, "lng", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.quickView12.desc = "Longitude:";
            this.quickView12.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quickView12, "quickView12");
            this.quickView12.Name = "quickView12";
            this.quickView12.number = 0D;
            this.quickView12.numberColor = System.Drawing.Color.White;
            // 
            // tabGrafik
            // 
            this.tabGrafik.Controls.Add(this.grafik);
            resources.ApplyResources(this.tabGrafik, "tabGrafik");
            this.tabGrafik.Name = "tabGrafik";
            this.tabGrafik.UseVisualStyleBackColor = true;
            // 
            // grafik
            // 
            resources.ApplyResources(this.grafik, "grafik");
            this.grafik.Name = "grafik";
            this.grafik.ScrollGrace = 0D;
            this.grafik.ScrollMaxX = 0D;
            this.grafik.ScrollMaxY = 0D;
            this.grafik.ScrollMaxY2 = 0D;
            this.grafik.ScrollMinX = 0D;
            this.grafik.ScrollMinY = 0D;
            this.grafik.ScrollMinY2 = 0D;
            this.grafik.DoubleClick += new System.EventHandler(this.grafik_DoubleClick);
            // 
            // tabStatHard
            // 
            this.tabStatHard.Controls.Add(this.Gauge3);
            this.tabStatHard.Controls.Add(this.Gauge2);
            this.tabStatHard.Controls.Add(this.Gauge1);
            resources.ApplyResources(this.tabStatHard, "tabStatHard");
            this.tabStatHard.Name = "tabStatHard";
            this.tabStatHard.UseVisualStyleBackColor = true;
            // 
            // Gauge3
            // 
            this.Gauge3.BackColor = System.Drawing.Color.Transparent;
            this.Gauge3.BackgroundImage = global::ArdupilotMega.Properties.Resources.Gaugebg;
            resources.ApplyResources(this.Gauge3, "Gauge3");
            this.Gauge3.BaseArcColor = System.Drawing.Color.Transparent;
            this.Gauge3.BaseArcRadius = 70;
            this.Gauge3.BaseArcStart = 135;
            this.Gauge3.BaseArcSweep = 270;
            this.Gauge3.BaseArcWidth = 2;
            this.Gauge3.basesize = new System.Drawing.Size(150, 150);
            this.Gauge3.Cap_Idx = ((byte)(0));
            this.Gauge3.CapColor = System.Drawing.Color.White;
            this.Gauge3.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gauge3.CapPosition = new System.Drawing.Point(58, 85);
            this.Gauge3.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gauge3.CapsText = new string[] {
        "Suhu",
        "",
        "",
        "",
        ""};
            this.Gauge3.CapText = "Suhu";
            this.Gauge3.Center = new System.Drawing.Point(75, 75);
            this.Gauge3.DataBindings.Add(new System.Windows.Forms.Binding("Value1", this.bindingSource, "roll", true));
            this.Gauge3.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.bindingSource, "pitch", true));
            this.Gauge3.MaxValue = 10F;
            this.Gauge3.MinValue = 0F;
            this.Gauge3.Name = "Gauge3";
            this.Gauge3.Need_Idx = ((byte)(3));
            this.Gauge3.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Gauge3.NeedleColor2 = System.Drawing.Color.Brown;
            this.Gauge3.NeedleEnabled = false;
            this.Gauge3.NeedleRadius = 70;
            this.Gauge3.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Gauge3.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.Gauge3.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.Gauge3.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.Gauge3.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Gauge3.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.Gauge3.NeedleType = 0;
            this.Gauge3.NeedleWidth = 2;
            this.Gauge3.Range_Idx = ((byte)(2));
            this.Gauge3.RangeColor = System.Drawing.Color.Orange;
            this.Gauge3.RangeEnabled = false;
            this.Gauge3.RangeEndValue = 50F;
            this.Gauge3.RangeInnerRadius = 1;
            this.Gauge3.RangeOuterRadius = 70;
            this.Gauge3.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gauge3.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Gauge3.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.Gauge3.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Gauge3.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.Gauge3.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.Gauge3.RangeStartValue = 35F;
            this.Gauge3.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Gauge3.ScaleLinesInterInnerRadius = 52;
            this.Gauge3.ScaleLinesInterOuterRadius = 60;
            this.Gauge3.ScaleLinesInterWidth = 1;
            this.Gauge3.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Gauge3.ScaleLinesMajorInnerRadius = 50;
            this.Gauge3.ScaleLinesMajorOuterRadius = 60;
            this.Gauge3.ScaleLinesMajorStepValue = 10F;
            this.Gauge3.ScaleLinesMajorWidth = 2;
            this.Gauge3.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Gauge3.ScaleLinesMinorInnerRadius = 55;
            this.Gauge3.ScaleLinesMinorNumOf = 9;
            this.Gauge3.ScaleLinesMinorOuterRadius = 60;
            this.Gauge3.ScaleLinesMinorWidth = 1;
            this.Gauge3.ScaleNumbersColor = System.Drawing.Color.White;
            this.Gauge3.ScaleNumbersFormat = null;
            this.Gauge3.ScaleNumbersRadius = 42;
            this.Gauge3.ScaleNumbersRotation = 0;
            this.Gauge3.ScaleNumbersStartScaleLine = 1;
            this.Gauge3.ScaleNumbersStepScaleLines = 1;
            this.Gauge3.Value = 0F;
            this.Gauge3.Value0 = 0F;
            this.Gauge3.Value1 = 0F;
            this.Gauge3.Value2 = 0F;
            this.Gauge3.Value3 = 0F;
            // 
            // Gauge2
            // 
            this.Gauge2.BackColor = System.Drawing.Color.Transparent;
            this.Gauge2.BackgroundImage = global::ArdupilotMega.Properties.Resources.Gaugebg;
            resources.ApplyResources(this.Gauge2, "Gauge2");
            this.Gauge2.BaseArcColor = System.Drawing.Color.Transparent;
            this.Gauge2.BaseArcRadius = 70;
            this.Gauge2.BaseArcStart = 135;
            this.Gauge2.BaseArcSweep = 270;
            this.Gauge2.BaseArcWidth = 2;
            this.Gauge2.basesize = new System.Drawing.Size(150, 150);
            this.Gauge2.Cap_Idx = ((byte)(0));
            this.Gauge2.CapColor = System.Drawing.Color.White;
            this.Gauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gauge2.CapPosition = new System.Drawing.Point(58, 85);
            this.Gauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gauge2.CapsText = new string[] {
        "Suhu",
        "",
        "",
        "",
        ""};
            this.Gauge2.CapText = "Suhu";
            this.Gauge2.Center = new System.Drawing.Point(75, 75);
            this.Gauge2.DataBindings.Add(new System.Windows.Forms.Binding("Value1", this.bindingSource, "roll", true));
            this.Gauge2.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.bindingSource, "pitch", true));
            this.Gauge2.MaxValue = 10F;
            this.Gauge2.MinValue = 0F;
            this.Gauge2.Name = "Gauge2";
            this.Gauge2.Need_Idx = ((byte)(3));
            this.Gauge2.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Gauge2.NeedleColor2 = System.Drawing.Color.Brown;
            this.Gauge2.NeedleEnabled = false;
            this.Gauge2.NeedleRadius = 70;
            this.Gauge2.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Gauge2.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.Gauge2.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.Gauge2.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.Gauge2.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Gauge2.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.Gauge2.NeedleType = 0;
            this.Gauge2.NeedleWidth = 2;
            this.Gauge2.Range_Idx = ((byte)(2));
            this.Gauge2.RangeColor = System.Drawing.Color.Orange;
            this.Gauge2.RangeEnabled = false;
            this.Gauge2.RangeEndValue = 50F;
            this.Gauge2.RangeInnerRadius = 1;
            this.Gauge2.RangeOuterRadius = 70;
            this.Gauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gauge2.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Gauge2.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.Gauge2.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Gauge2.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.Gauge2.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.Gauge2.RangeStartValue = 35F;
            this.Gauge2.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Gauge2.ScaleLinesInterInnerRadius = 52;
            this.Gauge2.ScaleLinesInterOuterRadius = 60;
            this.Gauge2.ScaleLinesInterWidth = 1;
            this.Gauge2.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Gauge2.ScaleLinesMajorInnerRadius = 50;
            this.Gauge2.ScaleLinesMajorOuterRadius = 60;
            this.Gauge2.ScaleLinesMajorStepValue = 10F;
            this.Gauge2.ScaleLinesMajorWidth = 2;
            this.Gauge2.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Gauge2.ScaleLinesMinorInnerRadius = 55;
            this.Gauge2.ScaleLinesMinorNumOf = 9;
            this.Gauge2.ScaleLinesMinorOuterRadius = 60;
            this.Gauge2.ScaleLinesMinorWidth = 1;
            this.Gauge2.ScaleNumbersColor = System.Drawing.Color.White;
            this.Gauge2.ScaleNumbersFormat = null;
            this.Gauge2.ScaleNumbersRadius = 42;
            this.Gauge2.ScaleNumbersRotation = 0;
            this.Gauge2.ScaleNumbersStartScaleLine = 1;
            this.Gauge2.ScaleNumbersStepScaleLines = 1;
            this.Gauge2.Value = 0F;
            this.Gauge2.Value0 = 0F;
            this.Gauge2.Value1 = 0F;
            this.Gauge2.Value2 = 0F;
            this.Gauge2.Value3 = 0F;
            // 
            // Gauge1
            // 
            this.Gauge1.BackColor = System.Drawing.Color.Transparent;
            this.Gauge1.BackgroundImage = global::ArdupilotMega.Properties.Resources.Gaugebg;
            resources.ApplyResources(this.Gauge1, "Gauge1");
            this.Gauge1.BaseArcColor = System.Drawing.Color.Transparent;
            this.Gauge1.BaseArcRadius = 70;
            this.Gauge1.BaseArcStart = 135;
            this.Gauge1.BaseArcSweep = 270;
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
            this.Gauge1.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.bindingSource, "roll", true));
            this.Gauge1.DataBindings.Add(new System.Windows.Forms.Binding("Value1", this.bindingSource, "alt", true));
            this.Gauge1.MaxValue = 10F;
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
            // tabAll
            // 
            resources.ApplyResources(this.tabAll, "tabAll");
            this.tabAll.Name = "tabAll";
            this.tabAll.UseVisualStyleBackColor = true;
            this.tabAll.Enter += new System.EventHandler(this.tabAll_Enter);
            // 
            // splitSmall
            // 
            resources.ApplyResources(this.splitSmall, "splitSmall");
            this.splitSmall.Name = "splitSmall";
            // 
            // splitSmall.Panel1
            // 
            this.splitSmall.Panel1.Controls.Add(this.tabControl1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBoxGrafik);
            this.tabPage1.Controls.Add(this.checkDataSatelit);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBoxGrafik
            // 
            resources.ApplyResources(this.checkBoxGrafik, "checkBoxGrafik");
            this.checkBoxGrafik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkBoxGrafik.ForeColor = System.Drawing.Color.White;
            this.checkBoxGrafik.Name = "checkBoxGrafik";
            this.checkBoxGrafik.UseVisualStyleBackColor = false;
            this.checkBoxGrafik.CheckedChanged += new System.EventHandler(this.checkBoxGrafik_CheckedChanged);
            // 
            // checkDataSatelit
            // 
            resources.ApplyResources(this.checkDataSatelit, "checkDataSatelit");
            this.checkDataSatelit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.checkDataSatelit.Checked = true;
            this.checkDataSatelit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDataSatelit.ForeColor = System.Drawing.Color.White;
            this.checkDataSatelit.Name = "checkDataSatelit";
            this.checkDataSatelit.UseVisualStyleBackColor = false;
            this.checkDataSatelit.CheckedChanged += new System.EventHandler(this.checkDataSatelit_CheckedChanged);
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // currentStateBindingSource
            // 
            this.currentStateBindingSource.DataSource = typeof(ArdupilotMega.CurrentState);
            // 
            // TGrafik
            // 
            this.TGrafik.Tick += new System.EventHandler(this.TGrafik_Tick);
            // 
            // contextMenuStripMap
            // 
            this.contextMenuStripMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goHereToolStripMenuItem,
            this.flyToHereAltToolStripMenuItem,
            this.pointCameraHereToolStripMenuItem,
            this.triggerCameraToolStripMenuItem,
            this.flightPlannerToolStripMenuItem});
            this.contextMenuStripMap.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStripMap, "contextMenuStripMap");
            // 
            // goHereToolStripMenuItem
            // 
            this.goHereToolStripMenuItem.Name = "goHereToolStripMenuItem";
            resources.ApplyResources(this.goHereToolStripMenuItem, "goHereToolStripMenuItem");
            // 
            // flyToHereAltToolStripMenuItem
            // 
            this.flyToHereAltToolStripMenuItem.Name = "flyToHereAltToolStripMenuItem";
            resources.ApplyResources(this.flyToHereAltToolStripMenuItem, "flyToHereAltToolStripMenuItem");
            // 
            // pointCameraHereToolStripMenuItem
            // 
            this.pointCameraHereToolStripMenuItem.Name = "pointCameraHereToolStripMenuItem";
            resources.ApplyResources(this.pointCameraHereToolStripMenuItem, "pointCameraHereToolStripMenuItem");
            // 
            // triggerCameraToolStripMenuItem
            // 
            this.triggerCameraToolStripMenuItem.Name = "triggerCameraToolStripMenuItem";
            resources.ApplyResources(this.triggerCameraToolStripMenuItem, "triggerCameraToolStripMenuItem");
            // 
            // flightPlannerToolStripMenuItem
            // 
            this.flightPlannerToolStripMenuItem.Name = "flightPlannerToolStripMenuItem";
            resources.ApplyResources(this.flightPlannerToolStripMenuItem, "flightPlannerToolStripMenuItem");
            // 
            // NanosatEEPIS
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "NanosatEEPIS";
            this.Load += new System.EventHandler(this.NanosatEEPIS_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitBig.Panel1.ResumeLayout(false);
            this.splitBig.Panel2.ResumeLayout(false);
            this.splitBig.ResumeLayout(false);
            this.tabControlUmum.ResumeLayout(false);
            this.tabData.ResumeLayout(false);
            this.tabData.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabGrafik.ResumeLayout(false);
            this.tabStatHard.ResumeLayout(false);
            this.splitSmall.Panel1.ResumeLayout(false);
            this.splitSmall.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentStateBindingSource)).EndInit();
            this.contextMenuStripMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitBig;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.TabControl tabControlUmum;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.TabPage tabGrafik;
        private ZedGraph.ZedGraphControl grafik;
        private System.Windows.Forms.SplitContainer splitSmall;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkDataSatelit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabStatHard;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.BindingSource currentStateBindingSource;
        private System.Windows.Forms.CheckBox checkBoxGrafik;
        private System.Windows.Forms.Timer TGrafik;
        private System.Windows.Forms.Timer ZedGraphTimer;
        private AGaugeApp.AGauge Gauge3;
        private AGaugeApp.AGauge Gauge2;
        private AGaugeApp.AGauge Gauge1;
        private System.Windows.Forms.TabPage tabAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.QuickView quickView11;
        private Controls.QuickView quickView12;
        private Controls.QuickView quickView13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Controls.QuickView quickView21;
        private Controls.QuickView quickView24;
        private Controls.QuickView quickView23;
        private Controls.QuickView quickView22;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Controls.QuickView quickView31;
        private Controls.QuickView quickView34;
        private Controls.QuickView quickView33;
        private Controls.QuickView quickView32;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripMap;
        private System.Windows.Forms.ToolStripMenuItem goHereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flyToHereAltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointCameraHereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triggerCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightPlannerToolStripMenuItem;

    }
}
