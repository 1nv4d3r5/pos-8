using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArdupilotMega.GCSViews
{
    public partial class Hardware : MyUserControl
    {
        public static int threadrunHW = 0;    
        public Hardware()
        {
            InitializeComponent();

           
        }

        private void Hardware_Load(object sender, EventArgs e)
        {
            System.Threading.Thread tHW = new System.Threading.Thread(new System.Threading.ThreadStart(mainloopHW))
            {
                IsBackground = true,
                Name = "Hardware Update"
            };

            tHW.Start();
        }

        private void mainloopHW()                 //loop utama
        {
            threadrunHW = 1;
            while (threadrunHW==1)
            {
                if (threadrunHW == 0) { return; }

                updateBindingSourceHW();
                System.Threading.Thread.Sleep(100);
                
            }
        }

        private void updateBindingSourceHW()      //--------------------------------> update data baru <------------------------------------------//    
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
                            MainV2.comPort.MAV.cs.UpdateCurrentSettings(currentStateBindingSource);
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
                    catch 
                    {
                        
                    
                    }
                });
            }
            catch
            {
                
            }

        }

        private void Hardware_Leave(object sender, EventArgs e)
        {
            
        }

        
    }
}
