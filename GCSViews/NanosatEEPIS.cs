﻿using System;
using System.Collections.Generic; // Lists
using System.Text; // stringbuilder
using System.Drawing; // pens etc
using System.IO; // file io
using System.IO.Ports; // serial
using System.Windows.Forms; // Forms
using System.Collections; // hashs
using System.Text.RegularExpressions; // regex
using System.Xml; // GE xml alt reader
using System.Net; // dns, ip address
using System.Net.Sockets; // tcplistner
using System.Threading;
using GMap.NET;
using GMap.NET.WindowsForms;
using System.Globalization; // language
using GMap.NET.WindowsForms.Markers;
using ZedGraph; // Graphs
using System.Drawing.Drawing2D;
using ArdupilotMega.Controls;
using ArdupilotMega.Utilities;
using ArdupilotMega.Controls.BackstageView;
//using Crom.Controls.Docking;
using log4net;
using System.Reflection;
using ArdupilotMega.Controls;
using ArdupilotMega.Utilities;

namespace ArdupilotMega.GCSViews
{
    public partial class NanosatEEPIS : MyUserControl
    {
        int tickStart = 0,niam=0;
        String RxString;

        public static int threadrun = 0;                    // buat loop while 1

        internal static GMapOverlay kmlpolygons;
        internal static GMapOverlay geofence;

        RollingPointPairList list1 = new RollingPointPairList(1200);
        RollingPointPairList list2 = new RollingPointPairList(1200);
        RollingPointPairList list3 = new RollingPointPairList(1200);
        RollingPointPairList list4 = new RollingPointPairList(1200);
        RollingPointPairList list5 = new RollingPointPairList(1200);
        RollingPointPairList list6 = new RollingPointPairList(1200);
        RollingPointPairList list7 = new RollingPointPairList(1200);
        RollingPointPairList list8 = new RollingPointPairList(1200);
        RollingPointPairList list9 = new RollingPointPairList(1200);
        RollingPointPairList list10 = new RollingPointPairList(1200);

        System.Reflection.PropertyInfo list1item = null;
        System.Reflection.PropertyInfo list2item = null;
        System.Reflection.PropertyInfo list3item = null;
        System.Reflection.PropertyInfo list4item = null;
        System.Reflection.PropertyInfo list5item = null;
        System.Reflection.PropertyInfo list6item = null;
        System.Reflection.PropertyInfo list7item = null;
        System.Reflection.PropertyInfo list8item = null;
        System.Reflection.PropertyInfo list9item = null;
        System.Reflection.PropertyInfo list10item = null;

        CurveItem list1curve;
        CurveItem list2curve;
        CurveItem list3curve;
        CurveItem list4curve;
        CurveItem list5curve;
        CurveItem list6curve;
        CurveItem list7curve;
        CurveItem list8curve;
        CurveItem list9curve;
        CurveItem list10curve;

        GMapMarker marker;

                        // layers
        GMapOverlay top;
        public static GMapOverlay objects; // where the markers a drawn
        public static GMapOverlay routes;// static so can update from gcs
        public static GMapOverlay polygons; // where the track is drawn
        GMapOverlay drawnpolygons;



        
        public NanosatEEPIS()
        {
            InitializeComponent();
            CreateChart(grafik);
            setmap();
     
       
        }

        private void NanosatEEPIS_Load(object sender, EventArgs e)
        {
            //gambar orbit

            //gambar orbit
            //resize ukuran
            ubahukuran();
            //resize ukuran


            System.Threading.Thread t11 = new System.Threading.Thread(new System.Threading.ThreadStart(mainloop))
            {
                IsBackground = true,
                Name = "FlightData updater"
            };



            miniTerminal.Text = "MINI TERMINAL EEPISat";

            t11.Start();                        //while 1
            threadrun = 1;
            TGrafik.Enabled = true;
            TGrafik.Start();
            
        }

        private void mainloop()                 //loop utama
        {
            threadrun = 1;
            EndPoint Remote = (EndPoint)(new IPEndPoint(IPAddress.Any, 0));

            DateTime lastdata = DateTime.MinValue;

            DateTime tracklast = DateTime.Now.AddSeconds(0);

            DateTime tunning = DateTime.Now.AddSeconds(0);

            DateTime mapupdate = DateTime.Now.AddSeconds(0);

            DateTime vidrec = DateTime.Now.AddSeconds(0);

            DateTime waypoints = DateTime.Now.AddSeconds(0);

            DateTime updatescreen = DateTime.Now;

            DateTime tsreal = DateTime.Now;
            double taketime = 0;
            double timeerror = 0;

            while (threadrun == 1)
            {
                //------------------------------------------------> gak bisa ambil data kalau gak ada ini<----------------------//
                if (threadrun == 0) { return; }
                
                if (MainV2.comPort.giveComport == true)
                {
                    System.Threading.Thread.Sleep(50);
                    continue;
                }
                if (!MainV2.comPort.BaseStream.IsOpen)
                    lastdata = DateTime.Now;
                
                // re-request servo data
                if (!(lastdata.AddSeconds(8) > DateTime.Now) && MainV2.comPort.BaseStream.IsOpen)
                {
                    //Console.WriteLine("REQ streams - flightdata");
                    try
                    {
                        //System.Threading.Thread.Sleep(1000);
                        
                        //comPort.requestDatastream((byte)ArdupilotMega.MAVLink09.MAV_DATA_STREAM.RAW_CONTROLLER, 0); // request servoout
                        /* 
                        MainV2.comPort.requestDatastream(ArdupilotMega.MAVLink.MAV_DATA_STREAM.EXTENDED_STATUS, MainV2.comPort.MAV.cs.ratestatus); // mode
                        MainV2.comPort.requestDatastream(ArdupilotMega.MAVLink.MAV_DATA_STREAM.POSITION, MainV2.comPort.MAV.cs.rateposition); // request gps
                        MainV2.comPort.requestDatastream(ArdupilotMega.MAVLink.MAV_DATA_STREAM.EXTRA1, MainV2.comPort.MAV.cs.rateattitude); // request attitude
                        MainV2.comPort.requestDatastream(ArdupilotMega.MAVLink.MAV_DATA_STREAM.EXTRA2, MainV2.comPort.MAV.cs.rateattitude); // request vfr
                        MainV2.comPort.requestDatastream(ArdupilotMega.MAVLink.MAV_DATA_STREAM.EXTRA3, MainV2.comPort.MAV.cs.ratesensors); // request extra stuff - tridge
                        MainV2.comPort.requestDatastream(ArdupilotMega.MAVLink.MAV_DATA_STREAM.RAW_SENSORS, MainV2.comPort.MAV.cs.ratesensors); // request raw sensor
                        MainV2.comPort.requestDatastream(ArdupilotMega.MAVLink.MAV_DATA_STREAM.RC_CHANNELS, MainV2.comPort.MAV.cs.raterc); // request rc info
                        */
                    }
                    catch { MessageBox.Show("Failed to request rates"); }
                    lastdata = DateTime.Now.AddSeconds(120); // prevent flooding
                }
                
                if (!MainV2.comPort.logreadmode)
                    System.Threading.Thread.Sleep(100); // max is only ever 10 hz
                 
                //------------------------------------------------> gak bisa ambil data kalau gak ada ini<----------------------//
                //------------------------------------------------->database<-------------------------------------------------------
                //request
                updateBindingSource();
                //------------------------------------------------->database<-------------------------------------------------------
                // ------------------------------------->data ke grafik<------------------------------------------------------------
                if (tunning.AddMilliseconds(50) < DateTime.Now && checkDataSatelit.Checked == true)
                {

                    double time = (Environment.TickCount - tickStart) / 1000.0;
                    if (list1item != null)
                        list1.Add(time, (float)list1item.GetValue((object)MainV2.comPort.MAV.cs, null));
                    if (list2item != null)
                        list2.Add(time, (float)list2item.GetValue((object)MainV2.comPort.MAV.cs, null));
                    if (list3item != null)
                        list3.Add(time, (float)list3item.GetValue((object)MainV2.comPort.MAV.cs, null));
                    if (list4item != null)
                        list4.Add(time, (float)list4item.GetValue((object)MainV2.comPort.MAV.cs, null));
                    if (list5item != null)
                        list5.Add(time, (float)list5item.GetValue((object)MainV2.comPort.MAV.cs, null));
                    if (list6item != null)
                        list6.Add(time, (float)list6item.GetValue((object)MainV2.comPort.MAV.cs, null));
                    if (list7item != null)
                        list7.Add(time, (float)list7item.GetValue((object)MainV2.comPort.MAV.cs, null));
                    if (list8item != null)
                        list8.Add(time, (float)list8item.GetValue((object)MainV2.comPort.MAV.cs, null));
                    if (list9item != null)
                        list9.Add(time, (float)list9item.GetValue((object)MainV2.comPort.MAV.cs, null));
                    if (list10item != null)
                        list10.Add(time, (float)list10item.GetValue((object)MainV2.comPort.MAV.cs, null));
                }
                //-------------------------------------->data grafik<-----------------------------------------------------------

            }
        }

        
        private void updateBindingSource()      //--------------------------------> update data baru <------------------------------------------//    
        {
            try
            {
                this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate()
                {
                    try
                    {
                        if (this.Visible)
                        {
                            //Console.Write("bindingSource1 ");
                            MainV2.comPort.MAV.cs.UpdateCurrentSettings(bindingSource);
                            //Console.Write("bindingSourceHud ");
                            //MainV2.comPort.MAV.cs.UpdateCurrentSettings(bindingSourceHud);
                            //Console.WriteLine("DONE ");
                        }
                        else
                        {
                            //Console.WriteLine("Null Binding");
                            MainV2.comPort.MAV.cs.UpdateCurrentSettings(null);
                        }
                    }
                    catch { }
                });
            }
            catch { }
        }
        private void checkDataSatelit_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !checkDataSatelit.Checked;
            ubahukuran();

            if (checkDataSatelit.Checked)
            {
                TGrafik.Enabled = true;
                TGrafik.Start();
                grafik.Refresh();

            }
            else
            {
                TGrafik.Stop();
                TGrafik.Enabled = false;
            }
        }



        private void ubahukuran()
        {
            int x, y,l;

            //punya gmap
            splitContainer3.Width = splitContainer1.Width-20;
            splitContainer3.Height = splitContainer1.Panel1.Height;
            splitContainer3.SplitterDistance = 100;

            gMap.Width = splitContainer1.Width;
            gMap.Height = splitContainer1.Panel1.Height;
            
            //punya tab
            tabControlUmum.Width = splitContainer1.Width-20;
            tabControlUmum.Height = splitContainer1.Panel2.Height-20;

            splitContainer2.Height = splitContainer1.Panel2.Height;
            splitContainer2.Width = tabControlUmum.Width;

            //grafik
            grafik.Width = splitContainer2.Panel1.Width;
            grafik.Height = splitContainer2.Height-60;

            //
            miniTerminal.Height = splitContainer3.Panel1.Height;
            miniTerminal.Location = new Point(splitContainer3.Width - miniTerminal.Width,0);

            x = splitContainer3.Width;
            y = splitContainer3.Panel1.Height;
            l = (int)0.25 * x;

            Gauge1.Width = l;
            Gauge1.Height = y;
            Gauge1.Location = new Point(3, 3);
            
            Gauge2.Width = l;
            Gauge2.Height = y;
            Gauge2.Location = new Point(Gauge1.Right, 3);

            Gauge3.Width = l;
            Gauge3.Height = y;
            Gauge3.Location = new Point(Gauge2.Right, 3);

            
            //quick view
            tableLayoutPanel1.Width = splitContainer2.Panel2.Width - 20;
            tableLayoutPanel2.Width = splitContainer2.Panel2.Width - 20;
            tableLayoutPanel3.Width = splitContainer2.Panel2.Width - 20;

            tableLayoutPanel1.Height = splitContainer2.Panel2.Height / 3;
            tableLayoutPanel2.Height = splitContainer2.Panel2.Height / 3;
            tableLayoutPanel3.Height = splitContainer2.Panel2.Height / 3;

            quickView11.Width = tableLayoutPanel1.ClientSize.Width;
            quickView12.Width = tableLayoutPanel1.ClientSize.Width; 
            quickView13.Width = tableLayoutPanel1.ClientSize.Width;
            quickView21.Width = tableLayoutPanel2.ClientSize.Width;
            quickView22.Width = tableLayoutPanel2.ClientSize.Width;
            quickView23.Width = tableLayoutPanel2.ClientSize.Width;
            quickView24.Width = tableLayoutPanel2.ClientSize.Width;
            quickView31.Width = tableLayoutPanel3.ClientSize.Width;
            quickView32.Width = tableLayoutPanel3.ClientSize.Width;
            quickView33.Width = tableLayoutPanel3.ClientSize.Width;
            quickView34.Width = tableLayoutPanel3.ClientSize.Width;


        }
        
        //private orbit()
        //{
            /*
            if (polygongridmode == false)
            {
                CustomMessageBox.Show("You will remain in polygon mode until you clear the polygon or create a grid/upload a fence");
            }

            polygongridmode = true;

            List<PointLatLng> polygonPoints = new List<PointLatLng>();
            if (drawnpolygons.Polygons.Count == 0)
            {
                drawnpolygon.Points.Clear();
                drawnpolygons.Polygons.Add(drawnpolygon);
            }

            // remove full loop is exists
            if (drawnpolygon.Points.Count > 1 && drawnpolygon.Points[0] == drawnpolygon.Points[drawnpolygon.Points.Count - 1])
                drawnpolygon.Points.RemoveAt(drawnpolygon.Points.Count - 1); // unmake a full loop

            drawnpolygon.Points.Add(new PointLatLng(start.Lat, start.Lng));

            addpolygonmarkergrid(drawnpolygon.Points.Count.ToString(), start.Lng, start.Lat, 0);

            gMap.UpdatePolygonLocalPosition(drawnpolygon);

            gMap.Invalidate();
            */

            
        //}
        
        


        bool setupPropertyInfo(ref System.Reflection.PropertyInfo input, string name, object source)
        {
            Type test = source.GetType();

            foreach (var field in test.GetProperties())
            {
                if (field.Name == name)
                {
                    input = field;
                    return true;
                }
            }

            return false;
        }


        //------------------------------------------>grafik<-------------------------------------------------------------
        void chk_log_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                grafik.GraphPane.YAxis.Type = AxisType.Log;
            }
            else
            {
                grafik.GraphPane.YAxis.Type = AxisType.Linear;
            }
        }

        public void CreateChart(ZedGraphControl zgc)
        {
            GraphPane myPane = zgc.GraphPane;

            // Set the titles and axis labels
            myPane.Title.Text = "Grafik Data";
            myPane.XAxis.Title.Text = "Time (s)";
            myPane.YAxis.Title.Text = "Unit";

            // Show the x axis grid
            myPane.XAxis.MajorGrid.IsVisible = true;

            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 5;

            // Make the Y axis scale red
            myPane.YAxis.Scale.FontSpec.FontColor = Color.White;
            myPane.YAxis.Title.FontSpec.FontColor = Color.White;
            // turn off the opposite tics so the Y tics don't show up on the Y2 axis
            myPane.YAxis.MajorTic.IsOpposite = false;
            myPane.YAxis.MinorTic.IsOpposite = false;
            // Don't display the Y zero line
            myPane.YAxis.MajorGrid.IsZeroLine = true;
            // Align the Y axis labels so they are flush to the axis
            myPane.YAxis.Scale.Align = AlignP.Inside;
            // Manually set the axis range
            //myPane.YAxis.Scale.Min = -1;
            //myPane.YAxis.Scale.Max = 1;

            // Fill the axis background with a gradient
            //myPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);

            // Sample at 50ms intervals
            //TGrafik.Interval = 100;
            //timer1.Enabled = true;
            //timer1.Start();


            // Calculate the Axis Scale Ranges
            zgc.AxisChange();

            tickStart = Environment.TickCount;
            return;
        }

        //mbuat opsi yang ditampilkan di grafik
        void chk_box_CheckedChanged(object sender, EventArgs e)         
        {
            if (((CheckBox)sender).Checked)
            {
                if (list1item == null)
                {
                    if (setupPropertyInfo(ref list1item, ((CheckBox)sender).Name, MainV2.comPort.MAV.cs))
                    {
                        list1.Clear();
                        list1curve = grafik.GraphPane.AddCurve(((CheckBox)sender).Name, list1, Color.Red, SymbolType.None);
                    }
                }
                else if (list2item == null)
                {
                    if (setupPropertyInfo(ref list2item, ((CheckBox)sender).Name, MainV2.comPort.MAV.cs))
                    {
                        list2.Clear();
                        list2curve = grafik.GraphPane.AddCurve(((CheckBox)sender).Name, list2, Color.Blue, SymbolType.None);
                    }
                }
                else if (list3item == null)
                {
                    if (setupPropertyInfo(ref list3item, ((CheckBox)sender).Name, MainV2.comPort.MAV.cs))
                    {
                        list3.Clear();
                        list3curve = grafik.GraphPane.AddCurve(((CheckBox)sender).Name, list3, Color.Green, SymbolType.None);
                    }
                }
                else if (list4item == null)
                {
                    if (setupPropertyInfo(ref list4item, ((CheckBox)sender).Name, MainV2.comPort.MAV.cs))
                    {
                        list4.Clear();
                        list4curve = grafik.GraphPane.AddCurve(((CheckBox)sender).Name, list4, Color.Orange, SymbolType.None);
                    }
                }
                else if (list5item == null)
                {
                    if (setupPropertyInfo(ref list5item, ((CheckBox)sender).Name, MainV2.comPort.MAV.cs))
                    {
                        list5.Clear();
                        list5curve = grafik.GraphPane.AddCurve(((CheckBox)sender).Name, list5, Color.Yellow, SymbolType.None);
                    }
                }
                else if (list6item == null)
                {
                    if (setupPropertyInfo(ref list6item, ((CheckBox)sender).Name, MainV2.comPort.MAV.cs))
                    {
                        list6.Clear();
                        list6curve = grafik.GraphPane.AddCurve(((CheckBox)sender).Name, list6, Color.Magenta, SymbolType.None);
                    }
                }
                else if (list7item == null)
                {
                    if (setupPropertyInfo(ref list7item, ((CheckBox)sender).Name, MainV2.comPort.MAV.cs))
                    {
                        list7.Clear();
                        list7curve = grafik.GraphPane.AddCurve(((CheckBox)sender).Name, list7, Color.Purple, SymbolType.None);
                    }
                }
                else if (list8item == null)
                {
                    if (setupPropertyInfo(ref list8item, ((CheckBox)sender).Name, MainV2.comPort.MAV.cs))
                    {
                        list8.Clear();
                        list8curve = grafik.GraphPane.AddCurve(((CheckBox)sender).Name, list8, Color.LimeGreen, SymbolType.None);
                    }
                }
                else if (list9item == null)
                {
                    if (setupPropertyInfo(ref list9item, ((CheckBox)sender).Name, MainV2.comPort.MAV.cs))
                    {
                        list9.Clear();
                        list9curve = grafik.GraphPane.AddCurve(((CheckBox)sender).Name, list9, Color.Cyan, SymbolType.None);
                    }
                }
                else if (list10item == null)
                {
                    if (setupPropertyInfo(ref list10item, ((CheckBox)sender).Name, MainV2.comPort.MAV.cs))
                    {
                        list10.Clear();
                        list10curve = grafik.GraphPane.AddCurve(((CheckBox)sender).Name, list10, Color.Violet, SymbolType.None);
                    }
                }
                else
                {
                    CustomMessageBox.Show("Upss, terlalu banyak bos...Maksimal 10 grafik ya.");
                    ((CheckBox)sender).Checked = false;
                }
                ThemeManager.ApplyThemeTo(this);

                string selected = "";
                try
                {
                    selected = selected + grafik.GraphPane.CurveList[0].Label.Text + "|";
                    selected = selected + grafik.GraphPane.CurveList[1].Label.Text + "|";
                    selected = selected + grafik.GraphPane.CurveList[2].Label.Text + "|";
                    selected = selected + grafik.GraphPane.CurveList[3].Label.Text + "|";
                    selected = selected + grafik.GraphPane.CurveList[4].Label.Text + "|";
                    selected = selected + grafik.GraphPane.CurveList[5].Label.Text + "|";
                    selected = selected + grafik.GraphPane.CurveList[6].Label.Text + "|";
                    selected = selected + grafik.GraphPane.CurveList[7].Label.Text + "|";
                    selected = selected + grafik.GraphPane.CurveList[8].Label.Text + "|";
                    selected = selected + grafik.GraphPane.CurveList[9].Label.Text + "|";
                    selected = selected + grafik.GraphPane.CurveList[10].Label.Text + "|";
                }
                catch { }
                MainV2.config["Tuning_Graph_Selected"] = selected;
            }
            else
            {
                // reset old stuff
                if (list1item != null && list1item.Name == ((CheckBox)sender).Name)
                {
                    list1item = null;
                    grafik.GraphPane.CurveList.Remove(list1curve);
                }
                if (list2item != null && list2item.Name == ((CheckBox)sender).Name)
                {
                    list2item = null;
                    grafik.GraphPane.CurveList.Remove(list2curve);
                }
                if (list3item != null && list3item.Name == ((CheckBox)sender).Name)
                {
                    list3item = null;
                    grafik.GraphPane.CurveList.Remove(list3curve);
                }
                if (list4item != null && list4item.Name == ((CheckBox)sender).Name)
                {
                    list4item = null;
                    grafik.GraphPane.CurveList.Remove(list4curve);
                }
                if (list5item != null && list5item.Name == ((CheckBox)sender).Name)
                {
                    list5item = null;
                    grafik.GraphPane.CurveList.Remove(list5curve);
                }
                if (list6item != null && list6item.Name == ((CheckBox)sender).Name)
                {
                    list6item = null;
                    grafik.GraphPane.CurveList.Remove(list6curve);
                }
                if (list7item != null && list7item.Name == ((CheckBox)sender).Name)
                {
                    list7item = null;
                    grafik.GraphPane.CurveList.Remove(list7curve);
                }
                if (list8item != null && list8item.Name == ((CheckBox)sender).Name)
                {
                    list8item = null;
                    grafik.GraphPane.CurveList.Remove(list8curve);
                }
                if (list9item != null && list9item.Name == ((CheckBox)sender).Name)
                {
                    list9item = null;
                    grafik.GraphPane.CurveList.Remove(list9curve);
                }
                if (list10item != null && list10item.Name == ((CheckBox)sender).Name)
                {
                    list10item = null;
                    grafik.GraphPane.CurveList.Remove(list10curve);
                }
            }
        }
        private void grafik_DoubleClick(object sender, EventArgs e)                     //mbuat pilihan grafik apa yang akan ditampilkan
        {
            Form selectform = new Form()
            {
                Name = "select",
                Width = 50,
                Height = 250,
                Text = "Plot Grafik"
            };

            int x = 10;
            int y = 10;

            {
                CheckBox chk_box = new CheckBox();
                chk_box.Text = "Logarithmic";
                chk_box.Name = "Logarithmic";
                chk_box.Location = new Point(x, y);
                chk_box.Size = new System.Drawing.Size(100, 20);
                chk_box.CheckedChanged += new EventHandler(chk_log_CheckedChanged);

                selectform.Controls.Add(chk_box);
            }

            y += 20;

            object thisBoxed = MainV2.comPort.MAV.cs;
            Type test = thisBoxed.GetType();

            foreach (var field in test.GetProperties())
            {
                // field.Name has the field's name.
                object fieldValue;
                TypeCode typeCode;
                try
                {
                    fieldValue = field.GetValue(thisBoxed, null); // Get value


                    // Get the TypeCode enumeration. Multiple types get mapped to a common typecode.
                    typeCode = Type.GetTypeCode(fieldValue.GetType());

                }
                catch { continue; }

                if (!(typeCode == TypeCode.Single))
                    continue;

                CheckBox chk_box = new CheckBox();

                if (list1item != null && list1item.Name == field.Name)
                    chk_box.Checked = true;
                if (list2item != null && list2item.Name == field.Name)
                    chk_box.Checked = true;
                if (list3item != null && list3item.Name == field.Name)
                    chk_box.Checked = true;
                if (list4item != null && list4item.Name == field.Name)
                    chk_box.Checked = true;
                if (list5item != null && list5item.Name == field.Name)
                    chk_box.Checked = true;
                if (list6item != null && list6item.Name == field.Name)
                    chk_box.Checked = true;
                if (list7item != null && list7item.Name == field.Name)
                    chk_box.Checked = true;
                if (list8item != null && list8item.Name == field.Name)
                    chk_box.Checked = true;
                if (list9item != null && list9item.Name == field.Name)
                    chk_box.Checked = true;
                if (list10item != null && list10item.Name == field.Name)
                    chk_box.Checked = true;

                chk_box.Text = field.Name;
                chk_box.Name = field.Name;
                chk_box.Location = new Point(x, y);
                chk_box.Size = new System.Drawing.Size(100, 20);
                chk_box.CheckedChanged += new EventHandler(chk_box_CheckedChanged);

                selectform.Controls.Add(chk_box);

                Application.DoEvents();

                x += 0;
                y += 20;

                if (y > selectform.Height - 50)
                {
                    x += 100;
                    y = 10;

                    selectform.Width = x + 100;
                }
            }
            ThemeManager.ApplyThemeTo(selectform);
            selectform.Show();
        }
        // detak, tick grafik
        private void TGrafik_Tick(object sender, EventArgs e)
        {
            try
            {
                // Make sure that the curvelist has at least one curve
                if (grafik.GraphPane.CurveList.Count <= 0)
                    return;

                // Get the first CurveItem in the graph
                LineItem curve = grafik.GraphPane.CurveList[0] as LineItem;
                if (curve == null)
                    return;

                // Get the PointPairList
                IPointListEdit list = curve.Points as IPointListEdit;
                // If this is null, it means the reference at curve.Points does not
                // support IPointListEdit, so we won't be able to modify it
                if (list == null)
                    return;

                // Time is measured in seconds
                double time = (Environment.TickCount - tickStart) / 1000.0;

                // Keep the X scale at a rolling 30 second interval, with one
                // major step between the max X value and the end of the axis
                Scale xScale = grafik.GraphPane.XAxis.Scale;
                if (time > xScale.Max - xScale.MajorStep)
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = xScale.Max - 10.0;
                }

                // Make sure the Y axis is rescaled to accommodate actual data
                grafik.AxisChange();

                // Force a redraw
                grafik.Invalidate();


            }
            catch
            { }
        }
        //------------------------------------------>grafik<-------------------------------------------------------------

        //----------------------------------------> google map <----------------------------------------------------
        private void setmap()
        {
            gMap.MapType = MapType.GoogleSatellite;
            gMap.MinZoom = 1;
            gMap.CacheLocation = Path.GetDirectoryName(Application.ExecutablePath) + "/gmapcache/";

            //gMap.OnMapZoomChanged += new MapZoomChanged(gMap_OnMapZoomChanged);

            gMap.Zoom = 3;

            gMap.RoutesEnabled = true;
            gMap.PolygonsEnabled = true;

            kmlpolygons = new GMapOverlay(gMap, "kmlpolygons");
            gMap.Overlays.Add(kmlpolygons);

            geofence = new GMapOverlay(gMap, "geofence");
            gMap.Overlays.Add(geofence);

            
            polygons = new GMapOverlay(gMap, "polygons");
            gMap.Overlays.Add(polygons);

            routes = new GMapOverlay(gMap, "routes");
            gMap.Overlays.Add(routes);
            

        }
        private void addpolygonmarker(string tag, double lng, double lat, int alt, Color? color, GMapOverlay overlay)
        {
            try
            {
                PointLatLng point = new PointLatLng(lat, lng);
                GMapMarkerGoogleGreen m = new GMapMarkerGoogleGreen(point);
                m.ToolTipMode = MarkerTooltipMode.Always;
                m.ToolTipText = tag;
                m.Tag = tag;

                GMapMarkerRect mBorders = new GMapMarkerRect(point);
                {

                    mBorders.InnerMarker = m;
                    try
                    {
                        mBorders.wprad = (int)(float.Parse(ArdupilotMega.MainV2.config["TXT_WPRad"].ToString()) / MainV2.comPort.MAV.cs.multiplierdist);
                    }
                    catch { }
                    //mBorders.MainMap = MainMap;
                    if (color.HasValue)
                    {
                        mBorders.Color = color.Value;
                    }
                }

                overlay.Markers.Add(m);
                overlay.Markers.Add(mBorders);
                
            }
            catch (Exception) { }
        }

        private void tabAll_Enter(object sender, EventArgs e)
        {
            int x = 10;
            int y = 10;

            object thisBoxed = MainV2.comPort.MAV.cs;
            Type test = thisBoxed.GetType();

            PropertyInfo[] props = test.GetProperties();

            //props

            foreach (var field in props)
            {
                // field.Name has the field's name.
                object fieldValue;
                TypeCode typeCode;
                try
                {
                    fieldValue = field.GetValue(thisBoxed, null); // Get value

                    // Get the TypeCode enumeration. Multiple types get mapped to a common typecode.
                    typeCode = Type.GetTypeCode(fieldValue.GetType());

                }
                catch { continue; }

                bool add = true;

                MyLabel lbl1 = new MyLabel();
                MyLabel lbl2 = new MyLabel();
                try
                {
                    lbl1 = (MyLabel)tabAll.Controls.Find(field.Name, false)[0];

                    lbl2 = (MyLabel)tabAll.Controls.Find(field.Name + "value", false)[0];

                    add = false;
                }
                catch { }

                if (add)
                {

                    lbl1.Location = new Point(x, y);
                    lbl1.Size = new System.Drawing.Size(75, 13);
                    lbl1.Text = field.Name;
                    lbl1.Name = field.Name;
                    lbl1.Visible = true;
                    lbl2.AutoSize = false;

                    lbl2.Location = new Point(lbl1.Right + 5, y);
                    lbl2.Size = new System.Drawing.Size(50, 13);
                    //if (lbl2.Name == "")
                    lbl2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, field.Name, false, System.Windows.Forms.DataSourceUpdateMode.Never, "0"));
                    lbl2.Name = field.Name + "value";
                    lbl2.Visible = true;
                    //lbl2.Text = fieldValue.ToString();


                    tabAll.Controls.Add(lbl1);
                    tabAll.Controls.Add(lbl2);
                }
                else
                {
                    lbl1.Location = new Point(x, y);
                    lbl2.Location = new Point(lbl1.Right + 5, y);
                }

                //Application.DoEvents();

                x += 0;
                y += 15;

                if (y > tabAll.Height - 30)
                {
                    x += 140;
                    y = 10;
                }
            }

            tabAll.Width = x;

            ThemeManager.ApplyThemeTo(tabAll);

            //   tabStatus.ResumeLayout();
        }
        PointLatLng gotolocation = new PointLatLng();
        private void gMap_MouseDown(object sender, MouseEventArgs e)
        {
            gotolocation = gMap.FromLocalToLatLng(e.X, e.Y);

            if (Control.ModifierKeys == Keys.Control)
            {
                goHereToolStripMenuItem_Click(null, null);
            }
        }
        private void goHereToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void flyToHereAltToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gMap_MouseLeave(object sender, EventArgs e)
        {
            if (marker != null)
            {
                if (routes.Markers.Contains(marker))
                    routes.Markers.Remove(marker);
            }
            PointLatLng point = new PointLatLng(-7.287500, 112.802500);

            marker = new GMapMarkerRect(point);
            marker.ToolTip = new GMapToolTip(marker);
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = "Stasiun Bumi EEPISat";

            routes.Markers.Add(marker);

        }

        private void gMap_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PointLatLng point = gMap.FromLocalToLatLng(e.X, e.Y);

                double latdif = gotolocation.Lat - point.Lat;
                double lngdif = gotolocation.Lng - point.Lng;

                try
                {
                    gMap.Position = new PointLatLng(gMap.Position.Lat + latdif, gMap.Position.Lng + lngdif);
                }
                catch { }
            }
            else
            {
                // setup a ballon with home distance
                if (marker != null)
                {
                    if (routes.Markers.Contains(marker))
                        routes.Markers.Remove(marker);
                }

                if (MainV2.getConfig("CHK_disttohomeflightdata") != false.ToString())
                {
                    PointLatLng point = new PointLatLng(-7.287500, 112.802500);

                    marker = new GMapMarkerRect(point);
                    marker.ToolTip = new GMapToolTip(marker);
                    marker.ToolTipMode = MarkerTooltipMode.Always;
                    marker.ToolTipText = "Stasiun Bumi EEPISat";

                    routes.Markers.Add(marker);
                }
            }
            
        }

        private void DisplayText(object sender, EventArgs e)
        {
            miniTerminal.AppendText(RxString);
        }

        private void serialPortTX_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
             
            RxString = serialPortTX.ReadExisting();
            this.Invoke(new EventHandler(DisplayText));
        }

        private void button_serialTX_Click(object sender, EventArgs e)
        {
            serialPortTX.PortName = ArdupilotMega.MainV2._connectionControl.CMB_serialportTX.Text;
            serialPortTX.BaudRate = int.Parse(ArdupilotMega.MainV2._connectionControl.CMB_baudrate.Text);

            serialPortTX.Open();
            if (serialPortTX.IsOpen)
            {
                //button_serialTX.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hit;
            byte[] packet = new byte[58];
            char[] data = new char[50];
            
            packet[0] = 254;
            packet[1] = (byte)miniTerminal.Text.Length;
            packet[2] = (byte)0;//packetcount

            //packetcount++;

            packet[3] = 255; // this is always 255 - MYGCS
            packet[4] = 0;
            packet[5] = 253;

            /*
            foreach (byte b in data)
            {
                packet[i] = b;
                i++;
            }
             * */
            
            /*
            ushort checksum = MavlinkCRC.crc_calculate(packet, packet[1] + 6);
            
            checksum = MavlinkCRC.crc_accumulate(83, checksum);

            byte ck_a = (byte)(checksum & 0xFF); ///< High byte
            byte ck_b = (byte)(checksum >> 8); ///< Low byte

            packet[i] = ck_a;
            i += 1;
            packet[i] = ck_b;
            i += 1;
            */
            serialPortTX.Write(packet,0,6);
            //serialPortTX.WriteLine(textBox1.Text);
            //MainV2.comPort.sendPacket(ArdupilotMega.MAVLink.MAVLINK_MSG_ID_STATUSTEXT
            /*
            for (hit = (7 + richTextBox1.TextLength); hit < 56; hit++)
            {
                packet[hit] = (byte)0;
            }
            packet[56] = 0;
            packet[57] = 0;
            serialPortTX.Write(packet, (7 + richTextBox1.TextLength), (51 - richTextBox1.TextLength));
            */
        }

        private void checkBoxMiniTerminal_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer3.Panel1Collapsed = !checkBoxMiniTerminal.Checked;
            ubahukuran();
        }



        


        //----------------------------------------> google map <----------------------------------------------------
    }
}
