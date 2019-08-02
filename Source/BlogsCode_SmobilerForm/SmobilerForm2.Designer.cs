using System;
using Smobiler.Core;
namespace BlogsCode_SmobilerForm
{
    partial class SmobilerForm2 : Smobiler.Core.Controls.MobileForm
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
            this.btnShowForm3 = new Smobiler.Core.Controls.Button();
            this.btnClose = new Smobiler.Core.Controls.Button();
            this.labTitle = new Smobiler.Core.Controls.Label();
            // 
            // btnShowForm3
            // 
            this.btnShowForm3.Location = new System.Drawing.Point(68, 94);
            this.btnShowForm3.Name = "btnShowForm3";
            this.btnShowForm3.Size = new System.Drawing.Size(163, 33);
            this.btnShowForm3.Text = "打开SmobilerForm3";
            this.btnShowForm3.Press += new System.EventHandler(this.btnShowForm3_Press);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(51, 163);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(192, 34);
            this.btnClose.Text = "关闭当前界面回到SmobilerForm1";
            this.btnClose.Press += new System.EventHandler(this.btnClose_Press);
            // 
            // labTitle
            // 
            this.labTitle.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(300, 35);
            this.labTitle.Text = "SmobilerForm2";
            // 
            // SmobilerForm2
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnShowForm3,
            this.btnClose,
            this.labTitle});
            this.Name = "SmobilerForm2";

        }
        #endregion

        private Smobiler.Core.Controls.Button btnShowForm3;
        private Smobiler.Core.Controls.Button btnClose;
        private Smobiler.Core.Controls.Label labTitle;
    }
}