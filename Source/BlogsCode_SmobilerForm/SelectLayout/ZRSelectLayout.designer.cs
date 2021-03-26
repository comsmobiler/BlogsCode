using System;
using Smobiler.Core;
namespace SelectDemo
{
    partial class ZRSelectLayout : Smobiler.Core.Controls.MobileUserControl
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
            this.imageButton6 = new Smobiler.Core.Controls.ImageButton();
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.imageButton7 = new Smobiler.Core.Controls.ImageButton();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton2 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton3 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton4 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton5 = new Smobiler.Core.Controls.ImageButton();
            this.mianpanel = new Smobiler.Core.Controls.Panel();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2,
            this.panel4});
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 80);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imageButton6,
            this.panel5,
            this.imageButton7});
            this.panel2.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel2.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Smobiler.Core.Controls.Padding(6F);
            this.panel2.Size = new System.Drawing.Size(0, 40);
            // 
            // imageButton6
            // 
            this.imageButton6.Flex = 1;
            this.imageButton6.ForeColor = System.Drawing.Color.Silver;
            this.imageButton6.IconColor = System.Drawing.Color.Silver;
            this.imageButton6.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.imageButton6.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton6.ImgTextRatio = new Smobiler.Core.Controls.Ratio(9, 1);
            this.imageButton6.ItemAlign = Smobiler.Core.Controls.LayoutItemAlign.Center;
            this.imageButton6.Name = "imageButton6";
            this.imageButton6.ResourceID = "long-arrow-left";
            this.imageButton6.Size = new System.Drawing.Size(40, 0);
            this.imageButton6.Press += new System.EventHandler(this.imageButton6_Press);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.BorderRadius = 4;
            this.panel5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon1,
            this.label1});
            this.panel5.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel5.Flex = 6;
            this.panel5.ItemAlign = Smobiler.Core.Controls.LayoutItemAlign.Center;
            this.panel5.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(207, 0);
            this.panel5.TouchDisabled = true;
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.Gainsboro;
            this.fontIcon1.Location = new System.Drawing.Point(6, 1);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "search";
            this.fontIcon1.Size = new System.Drawing.Size(14, 15);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 0);
            this.label1.Text = "清河";
            // 
            // imageButton7
            // 
            this.imageButton7.Flex = 1;
            this.imageButton7.IconColor = System.Drawing.Color.Silver;
            this.imageButton7.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton7.ImgTextRatio = new Smobiler.Core.Controls.Ratio(10, 0);
            this.imageButton7.Name = "imageButton7";
            this.imageButton7.ResourceID = "crosshairs";
            this.imageButton7.Size = new System.Drawing.Size(47, 0);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imageButton1,
            this.imageButton2,
            this.imageButton3,
            this.imageButton4,
            this.imageButton5});
            this.panel4.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel4.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel4.Name = "panel4";
            this.panel4.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 12F, 0F);
            this.panel4.Size = new System.Drawing.Size(0, 40);
            // 
            // imageButton1
            // 
            this.imageButton1.Flex = 1;
            this.imageButton1.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton1.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "angle-down";
            this.imageButton1.Size = new System.Drawing.Size(100, 0);
            this.imageButton1.Text = "合租";
            this.imageButton1.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // imageButton2
            // 
            this.imageButton2.Flex = 1;
            this.imageButton2.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton2.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton2.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.ResourceID = "angle-down";
            this.imageButton2.Size = new System.Drawing.Size(100, 0);
            this.imageButton2.Text = "位置";
            this.imageButton2.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // imageButton3
            // 
            this.imageButton3.Flex = 1;
            this.imageButton3.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton3.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton3.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton3.Name = "imageButton3";
            this.imageButton3.ResourceID = "angle-down";
            this.imageButton3.Size = new System.Drawing.Size(100, 0);
            this.imageButton3.Text = "租金";
            this.imageButton3.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // imageButton4
            // 
            this.imageButton4.Flex = 1;
            this.imageButton4.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton4.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton4.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton4.Name = "imageButton4";
            this.imageButton4.ResourceID = "angle-down";
            this.imageButton4.Size = new System.Drawing.Size(100, 0);
            this.imageButton4.Text = "筛选";
            this.imageButton4.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // imageButton5
            // 
            this.imageButton5.Flex = 1;
            this.imageButton5.FontSize = 10F;
            this.imageButton5.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton5.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton5.ImgTextRatio = new Smobiler.Core.Controls.Ratio(3, 7);
            this.imageButton5.Name = "imageButton5";
            this.imageButton5.ResourceID = "arrows-v";
            this.imageButton5.Size = new System.Drawing.Size(100, 0);
            this.imageButton5.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Default;
            this.imageButton5.Text = " ";
            // 
            // mianpanel
            // 
            this.mianpanel.Flex = 1;
            this.mianpanel.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.mianpanel.Name = "mianpanel";
            this.mianpanel.Padding = new Smobiler.Core.Controls.Padding(6F, 0F, 6F, 0F);
            this.mianpanel.Scrollable = true;
            this.mianpanel.Size = new System.Drawing.Size(0, 389);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button1,
            this.button2});
            this.panel3.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel3.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Smobiler.Core.Controls.Padding(6F);
            this.panel3.Size = new System.Drawing.Size(300, 46);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Margin = new Smobiler.Core.Controls.Margin(0F, 0F, 6F, 0F);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 0);
            this.button1.Text = "重置";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Flex = 2;
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 0);
            this.button2.Text = "确认";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // ZRSelectLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.mianpanel,
            this.panel3});
            this.Flex = 1;
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Load += new System.EventHandler(this.ZRSelectLayout_Load);
            this.Name = "ZRSelectLayout";

        }
        #endregion

        public Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Button button2;
        public Smobiler.Core.Controls.Panel mianpanel;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Panel panel4;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.ImageButton imageButton2;
        private Smobiler.Core.Controls.ImageButton imageButton3;
        private Smobiler.Core.Controls.ImageButton imageButton4;
        private Smobiler.Core.Controls.ImageButton imageButton5;
        private Smobiler.Core.Controls.ImageButton imageButton6;
        private Smobiler.Core.Controls.Panel panel5;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.ImageButton imageButton7;
    }
}