﻿namespace ArdupilotMega.GCSViews
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.CHK_showconsole = new System.Windows.Forms.CheckBox();
            this.BUT_updatecheck = new ArdupilotMega.Controls.MyButton();
            this.SuspendLayout();
            // 
            // CHK_showconsole
            // 
            resources.ApplyResources(this.CHK_showconsole, "CHK_showconsole");
            this.CHK_showconsole.Name = "CHK_showconsole";
            this.CHK_showconsole.UseVisualStyleBackColor = true;
            this.CHK_showconsole.CheckedChanged += new System.EventHandler(this.CHK_showconsole_CheckedChanged);
            // 
            // BUT_updatecheck
            // 
            resources.ApplyResources(this.BUT_updatecheck, "BUT_updatecheck");
            this.BUT_updatecheck.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(226)))), ((int)(((byte)(150)))));
            this.BUT_updatecheck.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.BUT_updatecheck.Name = "BUT_updatecheck";
            this.BUT_updatecheck.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(148)))), ((int)(((byte)(41)))));
            this.BUT_updatecheck.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_updatecheck.UseVisualStyleBackColor = true;
            this.BUT_updatecheck.Click += new System.EventHandler(this.BUT_updatecheck_Click);
            // 
            // Help
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CHK_showconsole);
            this.Controls.Add(this.BUT_updatecheck);
            this.Name = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ArdupilotMega.Controls.MyButton BUT_updatecheck;
        private System.Windows.Forms.CheckBox CHK_showconsole;

    }
}
