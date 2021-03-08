using System;
using Smobiler.Core;
namespace SelectDemo.Layouts
{
    partial class ZHTemplate : Smobiler.Core.Controls.MobileUserControl
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
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.indexLab = new Smobiler.Core.Controls.Label();
            this.textLab = new Smobiler.Core.Controls.Label();
            this.subLab = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2,
            this.panel3});
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.indexLab,
            this.textLab});
            this.panel2.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel2.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 24);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.subLab});
            this.panel3.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel3.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 0);
            // 
            // indexLab
            // 
            this.indexLab.Name = "indexLab";
            this.indexLab.Size = new System.Drawing.Size(15, 0);
            this.indexLab.Text = "label1";
            // 
            // textLab
            // 
            this.textLab.Flex = 1;
            this.textLab.FontSize = 15F;
            this.textLab.Name = "textLab";
            this.textLab.Size = new System.Drawing.Size(100, 0);
            this.textLab.Text = "label2";
            // 
            // subLab
            // 
            this.subLab.Flex = 1;
            this.subLab.ForeColor = System.Drawing.Color.Silver;
            this.subLab.Margin = new Smobiler.Core.Controls.Margin(15F, 0F, 0F, 0F);
            this.subLab.Name = "subLab";
            this.subLab.Size = new System.Drawing.Size(0, 0);
            // 
            // ZHTemplate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(130, 40);
            this.Name = "ZHTemplate";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.Label indexLab;
        private Smobiler.Core.Controls.Label textLab;
        private Smobiler.Core.Controls.Label subLab;
    }
}