using System;
using Smobiler.Core;
namespace SelectDemo
{
    partial class ListLayout : Smobiler.Core.Controls.MobileUserControl
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label2 = new Smobiler.Core.Controls.Label();
            // 
            // label1
            // 
            this.label1.DisplayMember = "data";
            this.label1.FontSize = 15F;
            this.label1.Margin = new Smobiler.Core.Controls.Margin(16F, 0F, 16F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 34);
            this.label1.Text = "label1";
            // 
            // image1
            // 
            this.image1.DisplayMember = "img";
            this.image1.Name = "image1";
            this.image1.ResourceID = "logon";
            this.image1.Size = new System.Drawing.Size(35, 33);
            // 
            // label2
            // 
            this.label2.DisplayMember = "fid";
            this.label2.FontSize = 15F;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 34);
            this.label2.Text = "label2";
            // 
            // ListLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.label1,
            this.label2});
            this.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.ItemAlign = Smobiler.Core.Controls.LayoutItemAlign.Center;
            this.JustifyAlign = Smobiler.Core.Controls.LayoutJustifyAlign.Center;
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(0, 50);
            this.Name = "ListLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label2;
    }
}