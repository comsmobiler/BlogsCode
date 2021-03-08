using System;
using Smobiler.Core;
namespace SelectDemo.Layouts
{
    partial class XCGRIDTemplate : Smobiler.Core.Controls.MobileUserControl
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.image2 = new Smobiler.Core.Controls.Image();
            this.image3 = new Smobiler.Core.Controls.Image();
            // 
            // panel1
            // 
            this.panel1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panel1.BorderColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.panel2});
            this.panel1.Flex = 1;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Margin = new Smobiler.Core.Controls.Margin(0F, 6F, 0F, 0F);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 200);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // label1
            // 
            this.label1.DisplayMember = "lab";
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 0);
            this.label1.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.image2,
            this.image3});
            this.panel2.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel2.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel2.Margin = new Smobiler.Core.Controls.Margin(0F, 0F, 0F, 6F);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Smobiler.Core.Controls.Padding(0F, 6F, 0F, 6F);
            this.panel2.Size = new System.Drawing.Size(0, 77);
            // 
            // image1
            // 
            this.image1.BorderRadius = 8;
            this.image1.DisplayMember = "img1";
            this.image1.Flex = 1;
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(45, 0);
            // 
            // image2
            // 
            this.image2.BorderRadius = 8;
            this.image2.DisplayMember = "img2";
            this.image2.Flex = 1;
            this.image2.Margin = new Smobiler.Core.Controls.Margin(6F, 0F, 6F, 0F);
            this.image2.Name = "image2";
            this.image2.Size = new System.Drawing.Size(45, 0);
            // 
            // image3
            // 
            this.image3.BorderRadius = 8;
            this.image3.DisplayMember = "img3";
            this.image3.Flex = 1;
            this.image3.Name = "image3";
            this.image3.Size = new System.Drawing.Size(45, 0);
            // 
            // XCGRIDTemplate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(0, 110);
            this.Name = "XCGRIDTemplate";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Image image2;
        private Smobiler.Core.Controls.Image image3;
    }
}