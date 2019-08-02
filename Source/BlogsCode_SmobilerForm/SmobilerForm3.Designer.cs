using System;
using Smobiler.Core;
namespace BlogsCode_SmobilerForm
{
    partial class SmobilerForm3 : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.btnClose = new Smobiler.Core.Controls.Button();
            this.btnCloseToForm1 = new Smobiler.Core.Controls.Button();
            // 
            // labTitle
            // 
            this.labTitle.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(300, 35);
            this.labTitle.Text = "SmobilerForm2";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(53, 127);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(205, 30);
            this.btnClose.Text = "关闭当前界面并回到SmobilerForm2";
            this.btnClose.Press += new System.EventHandler(this.btnClose_Press);
            // 
            // btnCloseToForm1
            // 
            this.btnCloseToForm1.Location = new System.Drawing.Point(53, 212);
            this.btnCloseToForm1.Name = "btnCloseToForm1";
            this.btnCloseToForm1.Size = new System.Drawing.Size(205, 30);
            this.btnCloseToForm1.Text = "直接回到SmobilerForm1";
            this.btnCloseToForm1.Press += new System.EventHandler(this.btnCloseToForm1_Press);
            // 
            // SmobilerForm3
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labTitle,
            this.btnClose,
            this.btnCloseToForm1});
            this.Name = "SmobilerForm3";

        }
        #endregion

        private Smobiler.Core.Controls.Label labTitle;
        private Smobiler.Core.Controls.Button btnClose;
        private Smobiler.Core.Controls.Button btnCloseToForm1;
    }
}