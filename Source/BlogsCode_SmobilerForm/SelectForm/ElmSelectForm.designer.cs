using System;
using Smobiler.Core;
namespace BlogsCode_SmobilerForm.SelectForm
{
    partial class ElmSelectForm : Smobiler.Core.Controls.MobileForm
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
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.imageButton2 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton3 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton4 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton5 = new Smobiler.Core.Controls.ImageButton();
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
            this.imageButton1.Size = new System.Drawing.Size(27, 0);
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
            this.panel2.Margin = new Smobiler.Core.Controls.Margin(6F, 0F, 0F, 0F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 0);
            this.panel2.Touchable = true;
            this.panel2.Press += new System.EventHandler(this.panel2_Press);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.Gainsboro;
            this.fontIcon1.Location = new System.Drawing.Point(6, 0);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "search";
            this.fontIcon1.Size = new System.Drawing.Size(15, 15);
            // 
            // keyLab
            // 
            this.keyLab.BorderColor = System.Drawing.Color.Gainsboro;
            this.keyLab.Flex = 1;
            this.keyLab.FontSize = 15F;
            this.keyLab.ForeColor = System.Drawing.Color.Gainsboro;
            this.keyLab.Location = new System.Drawing.Point(6, 0);
            this.keyLab.Margin = new Smobiler.Core.Controls.Margin(6F, 0F, 0F, 0F);
            this.keyLab.Name = "keyLab";
            this.keyLab.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.keyLab.Size = new System.Drawing.Size(100, 18);
            this.keyLab.Text = "曼玲粥店";
            // 
            // listView1
            // 
            this.listView1.Flex = 1;
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.Size = new System.Drawing.Size(0, 300);
            this.listView1.TemplateControlName = "ListLayout";
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imageButton2,
            this.imageButton3,
            this.imageButton4,
            this.imageButton5});
            this.panel4.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel4.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel4.Name = "panel4";
            this.panel4.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 12F, 0F);
            this.panel4.Size = new System.Drawing.Size(0, 40);
            // 
            // imageButton2
            // 
            this.imageButton2.Flex = 1;
            this.imageButton2.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton2.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton2.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.ResourceID = "angle-down";
            this.imageButton2.Size = new System.Drawing.Size(100, 0);
            this.imageButton2.Text = "综合排序";
            this.imageButton2.Press += new System.EventHandler(this.imageButton4_Press);
            // 
            // imageButton3
            // 
            this.imageButton3.Flex = 1;
            this.imageButton3.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton3.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton3.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton3.Name = "imageButton3";
            this.imageButton3.Size = new System.Drawing.Size(100, 0);
            this.imageButton3.Text = "销量最高";
            this.imageButton3.Press += new System.EventHandler(this.imageButton4_Press);
            // 
            // imageButton4
            // 
            this.imageButton4.Flex = 1;
            this.imageButton4.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton4.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton4.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton4.Name = "imageButton4";
            this.imageButton4.Size = new System.Drawing.Size(100, 0);
            this.imageButton4.Text = "距离最近";
            this.imageButton4.Press += new System.EventHandler(this.imageButton4_Press);
            // 
            // imageButton5
            // 
            this.imageButton5.Flex = 1;
            this.imageButton5.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton5.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton5.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.imageButton5.Name = "imageButton5";
            this.imageButton5.ResourceID = "angle-down";
            this.imageButton5.Size = new System.Drawing.Size(100, 0);
            this.imageButton5.Text = "筛选";
            this.imageButton5.Press += new System.EventHandler(this.imageButton4_Press);
            // 
            // ElmSelectForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel4,
            this.listView1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Dark, System.Drawing.Color.White);
            this.Name = "ElmSelectForm";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.Label keyLab;
        private Smobiler.Core.Controls.Panel panel4;
        private Smobiler.Core.Controls.ImageButton imageButton2;
        private Smobiler.Core.Controls.ImageButton imageButton3;
        private Smobiler.Core.Controls.ImageButton imageButton4;
        private Smobiler.Core.Controls.ImageButton imageButton5;
    }
}