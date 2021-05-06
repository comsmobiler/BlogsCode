using System;
using Smobiler.Core;
namespace BlogsCode_SmobilerForm.SelectLayout
{
    partial class LGSelelctLayout : Smobiler.Core.Controls.MobileUserControl
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
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.tabPageControl1 = new Smobiler.Core.Controls.TabPageControl();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.imageButton2 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton3 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton4 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton5 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton6 = new Smobiler.Core.Controls.ImageButton();
            this.mianpanel = new Smobiler.Core.Controls.Panel();
            this.tabPageControl2 = new Smobiler.Core.Controls.TabPageControl();
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.checkBox1 = new Smobiler.Core.Controls.CheckBox();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.panel6 = new Smobiler.Core.Controls.Panel();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.button3 = new Smobiler.Core.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imageButton1,
            this.panel2,
            this.button1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 44);
            // 
            // imageButton1
            // 
            this.imageButton1.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton1.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton1.Margin = new Smobiler.Core.Controls.Margin(2F, 0F, 0F, 0F);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "angle-down";
            this.imageButton1.Size = new System.Drawing.Size(46, 44);
            this.imageButton1.Text = "北京";
            // 
            // panel2
            // 
            this.panel2.BorderRadius = 15;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon1,
            this.textBox1});
            this.panel2.Location = new System.Drawing.Point(46, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 44);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.Gainsboro;
            this.fontIcon1.Location = new System.Drawing.Point(11, 13);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "search";
            this.fontIcon1.Size = new System.Drawing.Size(20, 20);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Transparent;
            this.textBox1.Location = new System.Drawing.Point(42, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 34);
            this.textBox1.Text = "产品经理";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderRadius = 0;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(245, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 29);
            this.button1.Text = "取消";
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageView1,
            this.panel5,
            this.panel6});
            this.panel3.Flex = 1;
            this.panel3.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 456);
            // 
            // tabPageView1
            // 
            this.tabPageView1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageControl1,
            this.tabPageControl2});
            this.tabPageView1.Flex = 1;
            this.tabPageView1.Location = new System.Drawing.Point(0, 3);
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.PageIndicator = Smobiler.Core.Controls.TabPageIndicator.Title;
            this.tabPageView1.Size = new System.Drawing.Size(300, 345);
            this.tabPageView1.Titles = new string[] {
        "相关职位",
        "相关公司"};
            this.tabPageView1.TitleStyle = new Smobiler.Core.Controls.TabPageViewTitleStyle(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129))))), System.Drawing.Color.Green, 13F, System.Drawing.Color.Green, 2);
            // 
            // tabPageControl1
            // 
            this.tabPageControl1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel4,
            this.mianpanel});
            this.tabPageControl1.Name = "tabPageControl1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imageButton2,
            this.imageButton3,
            this.imageButton4,
            this.imageButton5,
            this.imageButton6});
            this.panel4.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel4.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel4.Name = "panel4";
            this.panel4.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 12F, 0F);
            this.panel4.Size = new System.Drawing.Size(300, 40);
            // 
            // imageButton2
            // 
            this.imageButton2.Flex = 1;
            this.imageButton2.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton2.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton2.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.ResourceID = "angle-down";
            this.imageButton2.Size = new System.Drawing.Size(60, 0);
            this.imageButton2.Text = "区域";
            this.imageButton2.Press += new System.EventHandler(this.imageButton2_Press);
            // 
            // imageButton3
            // 
            this.imageButton3.Flex = 1;
            this.imageButton3.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton3.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton3.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton3.Name = "imageButton3";
            this.imageButton3.ResourceID = "angle-down";
            this.imageButton3.Size = new System.Drawing.Size(60, 0);
            this.imageButton3.Text = "要求";
            this.imageButton3.Press += new System.EventHandler(this.imageButton2_Press);
            // 
            // imageButton4
            // 
            this.imageButton4.Flex = 1;
            this.imageButton4.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton4.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton4.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton4.Name = "imageButton4";
            this.imageButton4.ResourceID = "angle-down";
            this.imageButton4.Size = new System.Drawing.Size(60, 0);
            this.imageButton4.Text = "公司";
            this.imageButton4.Press += new System.EventHandler(this.imageButton2_Press);
            // 
            // imageButton5
            // 
            this.imageButton5.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton5.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton5.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton5.Name = "imageButton5";
            this.imageButton5.ResourceID = "angle-down";
            this.imageButton5.Size = new System.Drawing.Size(60, 0);
            this.imageButton5.Text = "技能";
            this.imageButton5.Press += new System.EventHandler(this.imageButton2_Press);
            // 
            // imageButton6
            // 
            this.imageButton6.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton6.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton6.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton6.Name = "imageButton6";
            this.imageButton6.ResourceID = "angle-down";
            this.imageButton6.Size = new System.Drawing.Size(60, 0);
            this.imageButton6.Text = "排序";
            // 
            // mianpanel
            // 
            this.mianpanel.Flex = 1;
            this.mianpanel.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.mianpanel.Location = new System.Drawing.Point(0, 40);
            this.mianpanel.Name = "mianpanel";
            this.mianpanel.Scrollable = true;
            this.mianpanel.Size = new System.Drawing.Size(300, 316);
            // 
            // tabPageControl2
            // 
            this.tabPageControl2.Name = "tabPageControl2";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.checkBox1,
            this.label2});
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 70);
            // 
            // label1
            // 
            this.label1.Margin = new Smobiler.Core.Controls.Margin(4F, 0F, 0F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 24);
            this.label1.Text = "其他";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(0, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 22);
            this.checkBox1.TintColor = System.Drawing.Color.Gray;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 22);
            this.label2.Text = "屏蔽已投递公司";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button2,
            this.button3});
            this.panel6.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel6.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel6.Name = "panel6";
            this.panel6.Padding = new Smobiler.Core.Controls.Padding(6F);
            this.panel6.Size = new System.Drawing.Size(300, 39);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BorderRadius = 0;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.Text = "重置";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.BorderRadius = 0;
            this.button3.Flex = 2;
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.Text = "确定";
            this.button3.Press += new System.EventHandler(this.button3_Press);
            // 
            // LGSelelctLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel3});
            this.Flex = 1;
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Load += new System.EventHandler(this.LGSelelctLayout_Load);
            this.Name = "LGSelelctLayout";

        }
        #endregion
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.TabPageView tabPageView1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl1;
        private Smobiler.Core.Controls.Panel panel4;
        private Smobiler.Core.Controls.ImageButton imageButton2;
        private Smobiler.Core.Controls.ImageButton imageButton3;
        private Smobiler.Core.Controls.ImageButton imageButton4;
        private Smobiler.Core.Controls.ImageButton imageButton5;
        private Smobiler.Core.Controls.ImageButton imageButton6;
        private Smobiler.Core.Controls.TabPageControl tabPageControl2;
        public Smobiler.Core.Controls.Panel mianpanel;
        private Smobiler.Core.Controls.Panel panel5;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.CheckBox checkBox1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Panel panel6;
        private Smobiler.Core.Controls.Button button2;
        private Smobiler.Core.Controls.Button button3;
    }
}