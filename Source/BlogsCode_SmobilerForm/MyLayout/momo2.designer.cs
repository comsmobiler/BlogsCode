using System;
using Smobiler.Core;
namespace BlogsCode_SmobilerForm.MyLayout
{
    partial class momo2 : Smobiler.Core.Controls.MobileUserControl
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
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.fontIcon2 = new Smobiler.Core.Controls.FontIcon();
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.BlueViolet;
            this.fontIcon1.Margin = new Smobiler.Core.Controls.Margin(4F, 0F, 0F, 0F);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "graduation-cap";
            this.fontIcon1.Size = new System.Drawing.Size(73, 57);
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.DisplayMember = "lab1";
            this.label1.FontSize = 15F;
            this.label1.Location = new System.Drawing.Point(77, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.DisplayMember = "lab2";
            this.label2.Location = new System.Drawing.Point(77, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.DisplayMember = "lab3";
            this.label3.FontSize = 12F;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(77, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 53);
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.DisplayMember = "lab4";
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(77, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.Text = "label4";
            // 
            // fontIcon2
            // 
            this.fontIcon2.ForeColor = System.Drawing.Color.DarkGray;
            this.fontIcon2.Location = new System.Drawing.Point(278, 72);
            this.fontIcon2.Name = "fontIcon2";
            this.fontIcon2.ResourceID = "angle-right";
            this.fontIcon2.Size = new System.Drawing.Size(29, 13);
            // 
            // momo2
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon1,
            this.label1,
            this.label2,
            this.label3,
            this.label4,
            this.fontIcon2});
            this.Size = new System.Drawing.Size(0, 130);
            this.Name = "momo2";

        }
        #endregion
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.FontIcon fontIcon2;
    }
}