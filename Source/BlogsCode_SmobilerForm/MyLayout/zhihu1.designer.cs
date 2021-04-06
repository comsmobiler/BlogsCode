using System;
using Smobiler.Core;
namespace BlogsCode_SmobilerForm.MyLayout
{
    partial class zhihu1 : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.image2 = new Smobiler.Core.Controls.Image();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.fontIcon2 = new Smobiler.Core.Controls.FontIcon();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2,
            this.panel3,
            this.fontIcon1,
            this.label5,
            this.label6,
            this.fontIcon2});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2,
            this.label7,
            this.image1});
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 69);
            // 
            // label1
            // 
            this.label1.DisplayMember = "Name1";
            this.label1.Location = new System.Drawing.Point(68, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.DisplayMember = "Name2";
            this.label2.Location = new System.Drawing.Point(68, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "label2";
            // 
            // label7
            // 
            this.label7.DisplayMember = "Name3";
            this.label7.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label7.Location = new System.Drawing.Point(218, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 35);
            this.label7.Text = "label7";
            // 
            // image1
            // 
            this.image1.BorderRadius = 25;
            this.image1.Location = new System.Drawing.Point(8, 8);
            this.image1.Name = "image1";
            this.image1.ResourceID = "4";
            this.image1.Size = new System.Drawing.Size(50, 50);
            this.image1.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3,
            this.image2,
            this.label4});
            this.panel3.Location = new System.Drawing.Point(0, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 89);
            // 
            // label3
            // 
            this.label3.DisplayMember = "Name4";
            this.label3.FontSize = 15F;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 35);
            // 
            // image2
            // 
            this.image2.DisplayMember = "imageName";
            this.image2.Location = new System.Drawing.Point(242, 35);
            this.image2.Name = "image2";
            this.image2.ResourceID = "6";
            this.image2.Size = new System.Drawing.Size(58, 49);
            // 
            // label4
            // 
            this.label4.DisplayMember = "Name5";
            this.label4.Location = new System.Drawing.Point(0, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 48);
            this.label4.Text = "label4";
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.DarkGray;
            this.fontIcon1.Location = new System.Drawing.Point(88, 158);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "commenting-o";
            this.fontIcon1.Size = new System.Drawing.Size(39, 15);
            // 
            // label5
            // 
            this.label5.DisplayMember = "Name7";
            this.label5.FontSize = 10F;
            this.label5.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label5.Location = new System.Drawing.Point(127, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            // 
            // label6
            // 
            this.label6.DisplayMember = "Name6";
            this.label6.FontSize = 10F;
            this.label6.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label6.Location = new System.Drawing.Point(49, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            // 
            // fontIcon2
            // 
            this.fontIcon2.ForeColor = System.Drawing.Color.Gray;
            this.fontIcon2.Location = new System.Drawing.Point(11, 160);
            this.fontIcon2.Name = "fontIcon2";
            this.fontIcon2.ResourceID = "caret-up";
            this.fontIcon2.Size = new System.Drawing.Size(38, 13);
            // 
            // zhihu1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(0, 190);
            this.Name = "zhihu1";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Image image2;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.FontIcon fontIcon2;
        private Smobiler.Core.Controls.Image image1;
    }
}