using System;
using Smobiler.Core;
namespace BlogsCode_SmobilerForm.SelectForm
{
    partial class LGSelectForm2 : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.tabPageControl1 = new Smobiler.Core.Controls.TabPageControl();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.imageButton2 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton3 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton4 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton5 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton6 = new Smobiler.Core.Controls.ImageButton();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.tabPageControl2 = new Smobiler.Core.Controls.TabPageControl();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imageButton1,
            this.panel3,
            this.button1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 45);
            // 
            // imageButton1
            // 
            this.imageButton1.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton1.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton1.Location = new System.Drawing.Point(0, 2);
            this.imageButton1.Margin = new Smobiler.Core.Controls.Margin(2F, 0F, 0F, 0F);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "angle-down";
            this.imageButton1.Size = new System.Drawing.Size(46, 44);
            this.imageButton1.Text = "北京";
            this.imageButton1.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderRadius = 15;
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon1,
            this.textBox1});
            this.panel3.Location = new System.Drawing.Point(46, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 30);
            // 
            // fontIcon1
            // 
            this.fontIcon1.Location = new System.Drawing.Point(11, 7);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "search";
            this.fontIcon1.Size = new System.Drawing.Size(17, 17);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Transparent;
            this.textBox1.Location = new System.Drawing.Point(42, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 17);
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
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageView1});
            this.panel2.Flex = 1;
            this.panel2.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 456);
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
            this.tabPageView1.Size = new System.Drawing.Size(300, 452);
            this.tabPageView1.Titles = new string[] {
        "相关职位",
        "相关公司"};
            this.tabPageView1.TitleStyle = new Smobiler.Core.Controls.TabPageViewTitleStyle(System.Drawing.Color.White, System.Drawing.Color.Gray, System.Drawing.Color.Black, 13F, System.Drawing.Color.ForestGreen, 2);
            // 
            // tabPageControl1
            // 
            this.tabPageControl1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel4,
            this.listView1});
            this.tabPageControl1.Name = "tabPageControl1";
            // 
            // panel4
            // 
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
            this.imageButton2.IconColor = System.Drawing.Color.Gray;
            this.imageButton2.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton2.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton2.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.ResourceID = "caret-down";
            this.imageButton2.Size = new System.Drawing.Size(60, 0);
            this.imageButton2.Text = "区域";
            this.imageButton2.Press += new System.EventHandler(this.imageButton2_Press);
            // 
            // imageButton3
            // 
            this.imageButton3.Flex = 1;
            this.imageButton3.IconColor = System.Drawing.Color.Gray;
            this.imageButton3.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton3.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton3.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton3.Name = "imageButton3";
            this.imageButton3.ResourceID = "caret-down";
            this.imageButton3.Size = new System.Drawing.Size(60, 0);
            this.imageButton3.Text = "要求";
            this.imageButton3.Press += new System.EventHandler(this.imageButton2_Press);
            // 
            // imageButton4
            // 
            this.imageButton4.Flex = 1;
            this.imageButton4.IconColor = System.Drawing.Color.Gray;
            this.imageButton4.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton4.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton4.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton4.Name = "imageButton4";
            this.imageButton4.ResourceID = "caret-down";
            this.imageButton4.Size = new System.Drawing.Size(60, 0);
            this.imageButton4.Text = "公司";
            this.imageButton4.Press += new System.EventHandler(this.imageButton2_Press);
            // 
            // imageButton5
            // 
            this.imageButton5.IconColor = System.Drawing.Color.Gray;
            this.imageButton5.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton5.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton5.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton5.Name = "imageButton5";
            this.imageButton5.ResourceID = "caret-down";
            this.imageButton5.Size = new System.Drawing.Size(60, 0);
            this.imageButton5.Text = "技能";
            this.imageButton5.Press += new System.EventHandler(this.imageButton2_Press);
            // 
            // imageButton6
            // 
            this.imageButton6.IconColor = System.Drawing.Color.Gray;
            this.imageButton6.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton6.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton6.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton6.Name = "imageButton6";
            this.imageButton6.ResourceID = "caret-down";
            this.imageButton6.Size = new System.Drawing.Size(60, 0);
            this.imageButton6.Text = "排序";
            // 
            // listView1
            // 
            this.listView1.Flex = 1;
            this.listView1.Location = new System.Drawing.Point(0, 41);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.Size = new System.Drawing.Size(300, 411);
            this.listView1.TemplateControlName = "ListLayout";
            // 
            // tabPageControl2
            // 
            this.tabPageControl2.Name = "tabPageControl2";
            // 
            // LGSelectForm2
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "LGSelectForm2";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.TabPageView tabPageView1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl1;
        private Smobiler.Core.Controls.Panel panel4;
        private Smobiler.Core.Controls.ImageButton imageButton2;
        private Smobiler.Core.Controls.ImageButton imageButton3;
        private Smobiler.Core.Controls.ImageButton imageButton4;
        private Smobiler.Core.Controls.ImageButton imageButton5;
        private Smobiler.Core.Controls.ImageButton imageButton6;
        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl2;
    }
}