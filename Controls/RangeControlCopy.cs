﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArdupilotMega.Controls
{
   public partial class RangeControlCopy : UserControl, IDynamicParameterControl
   {
      #region Properties

       public event EventValueChanged ValueChanged;

      public NumericUpDown NumericUpDownControl { get { return numericUpDown1; } set { numericUpDown1 = value; } }
      public string DescriptionText { get { return label1.Text; } set { label1.Text = value; } }
      public string LabelText { get { return myLabel1.Text; } set { myLabel1.Text = value; } }
      public MyTrackBar TrackBarControl { get { return trackBar1; } set { trackBar1 = value; } }
      public float Increment
      {
          get
          {
              return _increment;
          }
          set
          {
              _increment = value;
              trackBar1.TickFrequency = _increment;
              trackBar1.SmallChange = _increment;
              trackBar1.LargeChange = _increment;
              numericUpDown1.Increment = (decimal)_increment;
              numericUpDown1.DecimalPlaces = _increment.ToString(CultureInfo.InvariantCulture).Length - 1;
          }
      }
      public float DisplayScale { get; set; }
      public float MinRange { get { return _minrange; } set { _minrange = value; numericUpDown1.Minimum = (decimal)(value / DisplayScale); trackBar1.Minimum = value; LBL_min.Text = numericUpDown1.Minimum.ToString(); } }
      public float MaxRange { get { return _maxrange; } set { _maxrange = value; numericUpDown1.Maximum = (decimal)(value / DisplayScale); trackBar1.Maximum = value; LBL_max.Text = numericUpDown1.Maximum.ToString(); } }
      float _minrange = 0;
      float _maxrange = 10;
      float _increment = 1;

      #region Interface Properties

      public string Value
      {
          get { return ((float)numericUpDown1.Value * DisplayScale).ToString(CultureInfo.InvariantCulture); } 
         set
         {
             float back1 = _minrange;
             float back2 = _maxrange;

             MinRange = (float)Math.Min(MinRange, double.Parse(value));
             MaxRange = (float)Math.Max(MaxRange, double.Parse(value));

             _minrange = back1;
             _maxrange = back2;

             numericUpDown1.Value = (decimal)((float)decimal.Parse(value) / DisplayScale);
            numericUpDown1_ValueChanged(null, null);

            if (ValueChanged != null)
                ValueChanged(this,Name, Value);
         }
      }

      #endregion

      #endregion

      #region Constructor

      public RangeControlCopy()
      {
         InitializeComponent();
         DisplayScale = 1;
      }


      public RangeControlCopy(string param, String Desc, string Label, float increment, float Displayscale, float minrange, float maxrange, string value)
      {
          InitializeComponent();
          this.DisplayScale = Displayscale;

          Name = param;
          Increment = increment;
          DescriptionText = Desc;
          LabelText = Label;
          MinRange = minrange;
          MaxRange = maxrange;
          float delta = maxrange - minrange;

          Console.WriteLine("RangeControl "+Increment + " " + MinRange + " " + MaxRange);

          if (((maxrange - minrange) / increment) > 100)
          {
              trackBar1.TickFrequency = 0;// (maxrange - minrange) / 20;
              Console.WriteLine("RangeControl TickFrequency to high " + param);
          }

          this.Value = value;
      }

      #endregion

      #region Methods

      public void AttachEvents()
      {
         numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
         trackBar1.ValueChanged += trackBar1_ValueChanged;
      }

      public void DeAttachEvents()
      {
          numericUpDown1.ValueChanged -= numericUpDown1_ValueChanged;
          trackBar1.ValueChanged -= trackBar1_ValueChanged;
      }

      #endregion

      #region Events

      protected void numericUpDown1_ValueChanged(object sender, EventArgs e)
      {
         trackBar1.Value = (float)numericUpDown1.Value * DisplayScale;

         numericUpDown1.BackColor = Color.Green;

         if ((float)numericUpDown1.Value < (MinRange))
             numericUpDown1.BackColor = Color.Orange;

         if ((float)numericUpDown1.Value > (MaxRange))
             numericUpDown1.BackColor = Color.Orange;

         if (ValueChanged != null)
             ValueChanged(this,Name, Value);
      }

      protected void trackBar1_ValueChanged(object sender, EventArgs e)
      {         
          numericUpDown1.Value = (decimal)(trackBar1.Value / DisplayScale);
         numericUpDown1.Text = (numericUpDown1.Value).ToString();

         if (ValueChanged != null)
             ValueChanged(this,Name, Value);
      }

      #endregion
   }
}
