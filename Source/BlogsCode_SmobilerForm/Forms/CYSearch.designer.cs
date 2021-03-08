using System;
using Smobiler.Core;
namespace SelectDemo.Forms
{
    partial class CYSearch : Smobiler.Core.Controls.MobileForm
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.keyLab = new Smobiler.Core.Controls.Label();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imageButton1,
            this.panel2});
            this.panel1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Smobiler.Core.Controls.Padding(6F);
            this.panel1.Size = new System.Drawing.Size(0, 40);
            // 
            // imageButton1
            // 
            this.imageButton1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "angle-left";
            this.imageButton1.Size = new System.Drawing.Size(36, 30);
            this.imageButton1.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderRadius = 12;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon1,
            this.keyLab});
            this.panel2.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel2.Flex = 1;
            this.panel2.ItemAlign = Smobiler.Core.Controls.LayoutItemAlign.Center;
            this.panel2.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 30);
            this.panel2.Touchable = true;
            this.panel2.Press += new System.EventHandler(this.panel2_Press);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.Gainsboro;
            this.fontIcon1.Location = new System.Drawing.Point(6, 1);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "search";
            this.fontIcon1.Size = new System.Drawing.Size(15, 15);
            // 
            // keyLab
            // 
            this.keyLab.Flex = 1;
            this.keyLab.FontSize = 15F;
            this.keyLab.ForeColor = System.Drawing.Color.Gray;
            this.keyLab.Location = new System.Drawing.Point(6, 0);
            this.keyLab.Margin = new Smobiler.Core.Controls.Margin(6F, 0F, 0F, 0F);
            this.keyLab.Name = "keyLab";
            this.keyLab.Size = new System.Drawing.Size(100, 0);
            this.keyLab.Text = "请输入疾病|药品|症状|医生|检查";
            // 
            // listView1
            // 
            this.listView1.Flex = 1;
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.Size = new System.Drawing.Size(0, 300);
            this.listView1.TemplateControlName = "ListLayout";
            // 
            // CYSearch
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.listView1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Dark, System.Drawing.Color.White);
            this.Load += new System.EventHandler(this.JDSearch_Load);
            this.Name = "CYSearch";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.Label keyLab;
    }
}