using System;
using Smobiler.Core;
namespace BlogsCode_SmobilerForm
{
    partial class InitForm : Smobiler.Core.Controls.MobileForm
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
            this.listMenuView1 = new Smobiler.Core.Controls.ListMenuView();
            // 
            // listMenuView1
            // 
            this.listMenuView1.Flex = 1;
            this.listMenuView1.Name = "listMenuView1";
            this.listMenuView1.Size = new System.Drawing.Size(0, 300);
            this.listMenuView1.ItemPress += new Smobiler.Core.Controls.ListMenuViewItemPressEventHandler(this.listMenuView1_ItemPress);
            // 
            // InitForm
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listMenuView1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Load += new System.EventHandler(this.InitForm_Load);
            this.Name = "InitForm";

        }
        #endregion

        private Smobiler.Core.Controls.ListMenuView listMenuView1;
    }
}