using System;
using Smobiler.Core;
namespace SelectDemo.Forms
{
    partial class XCLayout : Smobiler.Core.Controls.MobileForm
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
            this.imageButton2 = new Smobiler.Core.Controls.ImageButton();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.KeyLab = new Smobiler.Core.Controls.TextBox();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.hisPanel = new Smobiler.Core.Controls.Panel();
            this.disPanel = new Smobiler.Core.Controls.Panel();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imageButton2,
            this.panel2,
            this.button1});
            this.panel1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Smobiler.Core.Controls.Padding(12F, 6F, 12F, 6F);
            this.panel1.Size = new System.Drawing.Size(0, 40);
            // 
            // imageButton2
            // 
            this.imageButton2.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.ResourceID = "angle-left";
            this.imageButton2.Size = new System.Drawing.Size(30, 30);
            this.imageButton2.Press += new System.EventHandler(this.imageButton2_Press);
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
            this.imageButton1.ResourceID = "map-o";
            this.imageButton1.Size = new System.Drawing.Size(35, 25);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FontSize = 15F;
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(6, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 0);
            this.button1.Text = "搜索";
            this.button1.Press += new System.EventHandler(this.CloseDialog_Press);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.hisPanel,
            this.disPanel});
            this.panel3.Flex = 1;
            this.panel3.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel3.Name = "panel3";
            this.panel3.Scrollable = true;
            this.panel3.Size = new System.Drawing.Size(0, 100);
            // 
            // hisPanel
            // 
            this.hisPanel.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.hisPanel.Margin = new Smobiler.Core.Controls.Margin(6F, 0F, 0F, 0F);
            this.hisPanel.Name = "hisPanel";
            this.hisPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // disPanel
            // 
            this.disPanel.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.disPanel.Name = "disPanel";
            this.disPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // XCLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel3});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "XCLayout";
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Dark, System.Drawing.Color.White);
            this.Name = "XCLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.TextBox KeyLab;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.Panel panel3;
        public Smobiler.Core.Controls.Panel hisPanel;
        public Smobiler.Core.Controls.Panel disPanel;
        private Smobiler.Core.Controls.ImageButton imageButton2;
    }
}