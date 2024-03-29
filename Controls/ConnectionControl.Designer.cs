﻿namespace ArdupilotMega.Controls
{
    partial class ConnectionControl
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
            this.cmb_Baud = new System.Windows.Forms.ComboBox();
            this.cmb_ConnectionType = new System.Windows.Forms.ComboBox();
            this.cmb_Connection = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_ConnectionTX = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb_Baud
            // 
            this.cmb_Baud.BackColor = System.Drawing.Color.Black;
            this.cmb_Baud.ForeColor = System.Drawing.Color.White;
            this.cmb_Baud.FormattingEnabled = true;
            this.cmb_Baud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "111100",
            "115200"});
            this.cmb_Baud.Location = new System.Drawing.Point(325, 7);
            this.cmb_Baud.Name = "cmb_Baud";
            this.cmb_Baud.Size = new System.Drawing.Size(70, 21);
            this.cmb_Baud.TabIndex = 0;
            // 
            // cmb_ConnectionType
            // 
            this.cmb_ConnectionType.BackColor = System.Drawing.Color.Black;
            this.cmb_ConnectionType.ForeColor = System.Drawing.Color.White;
            this.cmb_ConnectionType.FormattingEnabled = true;
            this.cmb_ConnectionType.Location = new System.Drawing.Point(223, 31);
            this.cmb_ConnectionType.Name = "cmb_ConnectionType";
            this.cmb_ConnectionType.Size = new System.Drawing.Size(172, 21);
            this.cmb_ConnectionType.TabIndex = 1;
            this.cmb_ConnectionType.Visible = false;
            // 
            // cmb_Connection
            // 
            this.cmb_Connection.BackColor = System.Drawing.Color.Black;
            this.cmb_Connection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Connection.DropDownWidth = 200;
            this.cmb_Connection.ForeColor = System.Drawing.Color.White;
            this.cmb_Connection.FormattingEnabled = true;
            this.cmb_Connection.Location = new System.Drawing.Point(198, 7);
            this.cmb_Connection.Name = "cmb_Connection";
            this.cmb_Connection.Size = new System.Drawing.Size(121, 21);
            this.cmb_Connection.TabIndex = 2;
            this.cmb_Connection.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmb_Connection_DrawItem);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(154, 32);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Link Stats...";
            this.linkLabel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "RX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "TX";
            // 
            // cmb_ConnectionTX
            // 
            this.cmb_ConnectionTX.BackColor = System.Drawing.Color.Black;
            this.cmb_ConnectionTX.ForeColor = System.Drawing.Color.White;
            this.cmb_ConnectionTX.FormattingEnabled = true;
            this.cmb_ConnectionTX.Location = new System.Drawing.Point(32, 7);
            this.cmb_ConnectionTX.Name = "cmb_ConnectionTX";
            this.cmb_ConnectionTX.Size = new System.Drawing.Size(121, 21);
            this.cmb_ConnectionTX.TabIndex = 7;
            // 
            // ConnectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.Controls.Add(this.cmb_ConnectionTX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cmb_Connection);
            this.Controls.Add(this.cmb_ConnectionType);
            this.Controls.Add(this.cmb_Baud);
            this.Name = "ConnectionControl";
            this.Size = new System.Drawing.Size(402, 54);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ConnectionControl_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Baud;
        private System.Windows.Forms.ComboBox cmb_ConnectionType;
        private System.Windows.Forms.ComboBox cmb_Connection;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_ConnectionTX;
    }
}
