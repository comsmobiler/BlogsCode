using System;
using Smobiler.Core;
namespace SelectDemo.Layouts
{
    partial class CYLayout : Smobiler.Core.Controls.MobileUserControl
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
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.imageButton2 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton3 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton4 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton5 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton6 = new Smobiler.Core.Controls.ImageButton();
            this.hisPanel = new Smobiler.Core.Controls.Panel();
            this.disPanel = new Smobiler.Core.Controls.Panel();
            this.im1 = new Smobiler.Plugins.RongIM.IM();
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
            this.panel1.Size = new System.Drawing.Size(0, 40);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderRadius = 12;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon1,
            this.KeyLab});
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
            this.fontIcon1.Location = new System.Drawing.Point(6, 1);
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
            this.KeyLab.Text = "请输入疾病|药品|症状|医生|检查";
            this.KeyLab.SubmitEditing += new System.EventHandler(this.KeyLab_SubmitEditing);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(6, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 0);
            this.button1.Text = "取消";
            this.button1.Press += new System.EventHandler(this.CloseDialog_Press);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imageButton2,
            this.imageButton3,
            this.imageButton4,
            this.imageButton5,
            this.imageButton6});
            this.panel3.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel3.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel3.Margin = new Smobiler.Core.Controls.Margin(0F, 6F, 0F, 6F);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 12F, 0F);
            this.panel3.Size = new System.Drawing.Size(0, 66);
            // 
            // imageButton2
            // 
            this.imageButton2.Flex = 1;
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.ResourceID = "pic1";
            this.imageButton2.Size = new System.Drawing.Size(44, 0);
            this.imageButton2.Text = "症状自诊";
            // 
            // imageButton3
            // 
            this.imageButton3.Flex = 1;
            this.imageButton3.Name = "imageButton3";
            this.imageButton3.ResourceID = "pic2";
            this.imageButton3.Size = new System.Drawing.Size(56, 0);
            this.imageButton3.Text = "疾病率";
            // 
            // imageButton4
            // 
            this.imageButton4.Flex = 1;
            this.imageButton4.Name = "imageButton4";
            this.imageButton4.ResourceID = "pic3";
            this.imageButton4.Size = new System.Drawing.Size(26, 0);
            this.imageButton4.Text = "药品库";
            // 
            // imageButton5
            // 
            this.imageButton5.Flex = 1;
            this.imageButton5.Name = "imageButton5";
            this.imageButton5.ResourceID = "pic4";
            this.imageButton5.Size = new System.Drawing.Size(100, 0);
            this.imageButton5.Text = "自测工具";
            // 
            // imageButton6
            // 
            this.imageButton6.Flex = 1;
            this.imageButton6.Name = "imageButton6";
            this.imageButton6.ResourceID = "pic5";
            this.imageButton6.Size = new System.Drawing.Size(100, 0);
            this.imageButton6.Text = "化验解读";
            // 
            // hisPanel
            // 
            this.hisPanel.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.hisPanel.Name = "hisPanel";
            this.hisPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // disPanel
            // 
            this.disPanel.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.disPanel.Name = "disPanel";
            this.disPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // im1
            // 
            this.im1.Name = "im1";
            // 
            // CYLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.im1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel3,
            this.hisPanel,
            this.disPanel});
            this.Flex = 1;
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "CYLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.TextBox KeyLab;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.ImageButton imageButton2;
        private Smobiler.Core.Controls.ImageButton imageButton3;
        private Smobiler.Core.Controls.ImageButton imageButton4;
        private Smobiler.Core.Controls.ImageButton imageButton5;
        private Smobiler.Core.Controls.ImageButton imageButton6;
        public Smobiler.Core.Controls.Panel hisPanel;
        public Smobiler.Core.Controls.Panel disPanel;
        private Smobiler.Plugins.RongIM.IM im1;
    }
}