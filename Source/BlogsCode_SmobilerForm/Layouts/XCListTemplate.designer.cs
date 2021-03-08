using System;
using Smobiler.Core;
namespace SelectDemo.Layouts
{
    partial class XCListTemplate : Smobiler.Core.Controls.MobileUserControl
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
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panel1.BorderColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2,
            this.label3,
            this.line1});
            this.panel1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel1.Flex = 1;
            this.panel1.ItemAlign = Smobiler.Core.Controls.LayoutItemAlign.Center;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // label1
            // 
            this.label1.DisplayMember = "no";
            this.label1.FontSize = 14F;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 0);
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.DisplayMember = "lab";
            this.label2.Flex = 1;
            this.label2.FontSize = 14F;
            this.label2.Margin = new Smobiler.Core.Controls.Margin(0F, 0F, 30F, 0F);
            this.label2.Name = "label2";
            this.label2.NumberOfLines = 1;
            this.label2.Size = new System.Drawing.Size(100, 0);
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.DisplayMember = "peo";
            this.label3.FontSize = 14F;
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 0);
            // 
            // line1
            // 
            this.line1.Margin = new Smobiler.Core.Controls.Margin(6F, 0F, 0F, 0F);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(10, 1);
            // 
            // XCListTemplate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(0, 30);
            this.Name = "XCListTemplate";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Line line1;
    }
}