using System;
using Smobiler.Core;
namespace BlogsCode_SmobilerForm.MyLayout
{
    partial class momo4 : Smobiler.Core.Controls.MobileUserControl
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
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            // 
            // image1
            // 
            this.image1.BorderRadius = 25;
            this.image1.DisplayMember = "image";
            this.image1.Location = new System.Drawing.Point(6, 6);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(50, 50);
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.DisplayMember = "lab1";
            this.label1.FontSize = 15F;
            this.label1.Location = new System.Drawing.Point(56, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.DisplayMember = "lab2";
            this.label2.FontSize = 11F;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(56, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.DisplayMember = "lab3";
            this.label3.FontSize = 11F;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(56, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.Text = "label3";
            // 
            // button1
            // 
            this.button1.BorderRadius = 2;
            this.button1.Location = new System.Drawing.Point(190, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 35);
            this.button1.Text = "+好友";
            // 
            // momo4
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.label1,
            this.label2,
            this.label3,
            this.button1});
            this.Size = new System.Drawing.Size(280, 80);
            this.Name = "momo4";

        }
        #endregion

        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Button button1;
    }
}