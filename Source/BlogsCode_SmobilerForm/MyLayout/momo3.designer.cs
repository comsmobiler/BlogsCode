using System;
using Smobiler.Core;
namespace BlogsCode_SmobilerForm.MyLayout
{
    partial class momo3 : Smobiler.Core.Controls.MobileUserControl
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
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            // 
            // label1
            // 
            this.label1.BorderRadius = 15;
            this.label1.DisplayMember = "label1";
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Margin = new Smobiler.Core.Controls.Margin(4F, 0F, 0F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.DisplayMember = "label2";
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(0, 35);
            this.label2.Margin = new Smobiler.Core.Controls.Margin(4F, 0F, 0F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 35);
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.DisplayMember = "label3";
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(0, 70);
            this.label3.Margin = new Smobiler.Core.Controls.Margin(4F, 0F, 0F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 30);
            this.label3.Text = "label3";
            // 
            // momo3
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2,
            this.label3});
            this.Size = new System.Drawing.Size(0, 100);
            this.Name = "momo3";

        }
        #endregion

        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
    }
}