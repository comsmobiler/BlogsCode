using System;
using Smobiler.Core;
namespace SelectDemo.Layouts
{
    partial class MYLayout : Smobiler.Core.Controls.MobileUserControl
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
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.KeyLab = new Smobiler.Core.Controls.TextBox();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.hisPanel = new Smobiler.Core.Controls.Panel();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.tabPageControl1 = new Smobiler.Core.Controls.TabPageControl();
            this.tabPageControl2 = new Smobiler.Core.Controls.TabPageControl();
            this.tabPageControl3 = new Smobiler.Core.Controls.TabPageControl();
            this.tabPageControl4 = new Smobiler.Core.Controls.TabPageControl();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2,
            this.button1});
            this.panel1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Smobiler.Core.Controls.Padding(12F, 6F, 12F, 6F);
            this.panel1.Size = new System.Drawing.Size(0, 42);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderRadius = 12;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon1,
            this.KeyLab,
            this.imageButton1});
            this.panel2.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel2.Flex = 1;
            this.panel2.ItemAlign = Smobiler.Core.Controls.LayoutItemAlign.Center;
            this.panel2.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 30);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.Gainsboro;
            this.fontIcon1.Location = new System.Drawing.Point(6, 0);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "search";
            this.fontIcon1.Size = new System.Drawing.Size(15, 19);
            // 
            // KeyLab
            // 
            this.KeyLab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KeyLab.Flex = 1;
            this.KeyLab.FontSize = 15F;
            this.KeyLab.ForeColor = System.Drawing.Color.Gray;
            this.KeyLab.Location = new System.Drawing.Point(10, 0);
            this.KeyLab.Name = "KeyLab";
            this.KeyLab.Size = new System.Drawing.Size(100, 25);
            this.KeyLab.SubmitEditing += new System.EventHandler(this.KeyLab_SubmitEditing);
            // 
            // imageButton1
            // 
            this.imageButton1.ForeColor = System.Drawing.Color.SkyBlue;
            this.imageButton1.IconColor = System.Drawing.Color.Silver;
            this.imageButton1.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.imageButton1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton1.Location = new System.Drawing.Point(12, 0);
            this.imageButton1.Margin = new Smobiler.Core.Controls.Margin(0F, 0F, 12F, 0F);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "instagram";
            this.imageButton1.Size = new System.Drawing.Size(35, 30);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(6, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 0);
            this.button1.Text = "取消";
            this.button1.Press += new System.EventHandler(this.CloseDialog_Press);
            // 
            // hisPanel
            // 
            this.hisPanel.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.hisPanel.Name = "hisPanel";
            this.hisPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // tabPageView1
            // 
            this.tabPageView1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageControl1,
            this.tabPageControl2,
            this.tabPageControl3,
            this.tabPageControl4});
            this.tabPageView1.Flex = 1;
            this.tabPageView1.Margin = new Smobiler.Core.Controls.Margin(12F, 0F, 12F, 0F);
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.PageIndicator = Smobiler.Core.Controls.TabPageIndicator.Title;
            this.tabPageView1.Size = new System.Drawing.Size(0, 300);
            this.tabPageView1.Titles = new string[] {
        "经期健康",
        "两性知识",
        "妇科护理",
        "娱乐八卦"};
            this.tabPageView1.TitleStyle = new Smobiler.Core.Controls.TabPageViewTitleStyle(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129))))), System.Drawing.Color.Pink, 15F, System.Drawing.Color.Pink, 2);
            // 
            // tabPageControl1
            // 
            this.tabPageControl1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.tabPageControl1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.tabPageControl1.Name = "tabPageControl1";
            this.tabPageControl1.Wrap = Smobiler.Core.Controls.LayoutWrap.Wrap;
            // 
            // tabPageControl2
            // 
            this.tabPageControl2.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.tabPageControl2.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.tabPageControl2.Name = "tabPageControl2";
            // 
            // tabPageControl3
            // 
            this.tabPageControl3.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.tabPageControl3.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.tabPageControl3.Name = "tabPageControl3";
            // 
            // tabPageControl4
            // 
            this.tabPageControl4.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.tabPageControl4.Name = "tabPageControl4";
            this.tabPageControl4.Wrap = Smobiler.Core.Controls.LayoutWrap.Wrap;
            // 
            // MYLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.hisPanel,
            this.tabPageView1});
            this.Flex = 1;
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "MYLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.Button button1;
        public Smobiler.Core.Controls.Panel hisPanel;
        private Smobiler.Core.Controls.TextBox KeyLab;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.TabPageView tabPageView1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl1;
        private Smobiler.Core.Controls.TabPageControl tabPageControl2;
        private Smobiler.Core.Controls.TabPageControl tabPageControl3;
        private Smobiler.Core.Controls.TabPageControl tabPageControl4;
    }
}