using System;
using Smobiler.Core;
namespace SelectDemo.Forms
{
    partial class ZHSearch_1 : Smobiler.Core.Controls.MobileForm
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
            this.button1 = new Smobiler.Core.Controls.Button();
            this.hisPanel = new Smobiler.Core.Controls.Panel();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.disPanel = new Smobiler.Core.Controls.Panel();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2,
            this.button1});
            this.panel1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Smobiler.Core.Controls.LayoutItemAlign.Center;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Smobiler.Core.Controls.Padding(12F, 6F, 12F, 6F);
            this.panel1.Size = new System.Drawing.Size(0, 40);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderRadius = 4;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon1,
            this.KeyLab});
            this.panel2.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel2.Flex = 1;
            this.panel2.ItemAlign = Smobiler.Core.Controls.LayoutItemAlign.Center;
            this.panel2.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 30);
            this.panel2.Touchable = true;
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
            this.KeyLab.BorderColor = System.Drawing.Color.Gainsboro;
            this.KeyLab.Flex = 1;
            this.KeyLab.FontSize = 15F;
            this.KeyLab.ForeColor = System.Drawing.Color.Gainsboro;
            this.KeyLab.Location = new System.Drawing.Point(10, 0);
            this.KeyLab.Name = "KeyLab";
            this.KeyLab.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.KeyLab.Size = new System.Drawing.Size(100, 18);
            this.KeyLab.WaterMarkText = "请输入关键字";
            this.KeyLab.WaterMarkTextColor = System.Drawing.Color.Gainsboro;
            this.KeyLab.SubmitEditing += new System.EventHandler(this.KeyLab_SubmitEditing);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Bold = true;
            this.button1.FontSize = 15F;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(6, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 20);
            this.button1.Text = "取消";
            this.button1.Press += new System.EventHandler(this.CloseDialog_Press);
            // 
            // hisPanel
            // 
            this.hisPanel.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.hisPanel.BorderColor = System.Drawing.Color.Silver;
            this.hisPanel.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageView1});
            this.hisPanel.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.hisPanel.Margin = new Smobiler.Core.Controls.Margin(0F, 6F, 0F, 0F);
            this.hisPanel.Name = "hisPanel";
            this.hisPanel.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 12F, 0F);
            this.hisPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // tabPageView1
            // 
            this.tabPageView1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.PageIndicator = Smobiler.Core.Controls.TabPageIndicator.Title;
            this.tabPageView1.Size = new System.Drawing.Size(0, 240);
            this.tabPageView1.TitleStyle = new Smobiler.Core.Controls.TabPageViewTitleStyle(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129))))), System.Drawing.Color.Black, 15F, System.Drawing.Color.Black, 2);
            // 
            // disPanel
            // 
            this.disPanel.Flex = 1;
            this.disPanel.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.disPanel.Name = "disPanel";
            this.disPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ZHSearch_1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.hisPanel,
            this.disPanel});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Dark, System.Drawing.Color.White);
            this.Name = "ZHSearch_1";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.Button button1;
        public Smobiler.Core.Controls.Panel hisPanel;
        public Smobiler.Core.Controls.Panel disPanel;
        private Smobiler.Core.Controls.TextBox KeyLab;
        private Smobiler.Core.Controls.TabPageView tabPageView1;
    }
}