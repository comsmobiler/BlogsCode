using System;
using Smobiler.Core;
namespace BlogsCode_SmobilerForm
{
    partial class demoMyForm : Smobiler.Core.Controls.MobileForm
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
            this.title1 = new Smobiler.Core.Controls.Title();
            this.listMenuView1 = new Smobiler.Core.Controls.ListMenuView();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(0, 30);
            this.title1.Text = "个人主页";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // listMenuView1
            // 
            this.listMenuView1.Flex = 1;
            this.listMenuView1.Name = "listMenuView1";
            this.listMenuView1.Size = new System.Drawing.Size(0, 300);
            this.listMenuView1.ItemPress += new Smobiler.Core.Controls.ListMenuViewItemPressEventHandler(this.listMenuView1_ItemPress);
            // 
            // demoMyForm
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.listMenuView1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Load += new System.EventHandler(this.demoMyForm_Load);
            this.Name = "demoMyForm";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.ListMenuView listMenuView1;
    }
}