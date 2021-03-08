using System;
using Smobiler.Core;
namespace BlogsCode_SmobilerForm
{
    partial class democontrols : Smobiler.Core.Controls.MobileForm
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
            this.iconMenuView1 = new Smobiler.Core.Controls.IconMenuView();
            this.title1 = new Smobiler.Core.Controls.Title();
            // 
            // iconMenuView1
            // 
            this.iconMenuView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconMenuView1.Location = new System.Drawing.Point(12, 8);
            this.iconMenuView1.Name = "iconMenuView1";
            this.iconMenuView1.ShowGroupTitle = true;
            this.iconMenuView1.Size = new System.Drawing.Size(344, 483);
            this.iconMenuView1.ItemPress += new Smobiler.Core.Controls.IconMenuViewItemPressClickHandler(this.iconMenuView1_ItemPress);
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Location = new System.Drawing.Point(45, 61);
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(100, 30);
            this.title1.Text = "搜索";
            this.title1.Visible = false;
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // democontrols
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.iconMenuView1});
            this.Load += new System.EventHandler(this.democontrols_Load);
            this.Name = "democontrols";

        }
        #endregion

        private Smobiler.Core.Controls.IconMenuView iconMenuView1;
        private Smobiler.Core.Controls.Title title1;
    }
}