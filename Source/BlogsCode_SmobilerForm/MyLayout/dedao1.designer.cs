using System;
using Smobiler.Core;
namespace BlogsCode_SmobilerForm.MyLayout
{
    partial class dedao1 : Smobiler.Core.Controls.MobileUserControl
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
            this.titleLab = new Smobiler.Core.Controls.Label();
            this.timeLab = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.imageButton2 = new Smobiler.Core.Controls.ImageButton();
            this.contentLab = new Smobiler.Core.Controls.Label();
            this.avatar = new Smobiler.Core.Controls.Image();
            this.moreBtn = new Smobiler.Core.Controls.Button();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.fontIcon2 = new Smobiler.Core.Controls.FontIcon();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.fontIcon3 = new Smobiler.Core.Controls.FontIcon();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.panel6 = new Smobiler.Core.Controls.Panel();
            this.fontIcon4 = new Smobiler.Core.Controls.FontIcon();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.zoomImage1 = new Smobiler.Core.Controls.ZoomImage();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.titleLab,
            this.timeLab,
            this.button1,
            this.imageButton2,
            this.contentLab,
            this.avatar,
            this.moreBtn});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 169);
            // 
            // titleLab
            // 
            this.titleLab.Bold = true;
            this.titleLab.DisplayMember = "Name1";
            this.titleLab.Location = new System.Drawing.Point(60, 8);
            this.titleLab.Name = "titleLab";
            this.titleLab.NumberOfLines = 1;
            this.titleLab.Size = new System.Drawing.Size(156, 18);
            this.titleLab.Text = "label1";
            // 
            // timeLab
            // 
            this.timeLab.DisplayMember = "Name2";
            this.timeLab.FontSize = 10F;
            this.timeLab.Location = new System.Drawing.Point(60, 26);
            this.timeLab.Name = "timeLab";
            this.timeLab.Size = new System.Drawing.Size(109, 15);
            this.timeLab.Text = "label2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderRadius = 15;
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(222, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 22);
            this.button1.Text = "+关注";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // imageButton2
            // 
            this.imageButton2.IconColor = System.Drawing.Color.DimGray;
            this.imageButton2.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton2.Location = new System.Drawing.Point(264, 8);
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.ResourceID = "ellipsis-h";
            this.imageButton2.Size = new System.Drawing.Size(30, 22);
            this.imageButton2.Press += new System.EventHandler(this.imageButton2_Press);
            // 
            // contentLab
            // 
            this.contentLab.DisplayMember = "Name3";
            this.contentLab.FontSize = 14F;
            this.contentLab.Location = new System.Drawing.Point(56, 41);
            this.contentLab.Margin = new Smobiler.Core.Controls.Margin(4F, 0F, 4F, 0F);
            this.contentLab.Name = "contentLab";
            this.contentLab.NumberOfLines = 7;
            this.contentLab.Size = new System.Drawing.Size(234, 108);
            this.contentLab.Text = "label3";
            // 
            // avatar
            // 
            this.avatar.BorderRadius = 25;
            this.avatar.Location = new System.Drawing.Point(0, 8);
            this.avatar.Margin = new Smobiler.Core.Controls.Margin(4F, 0F, 0F, 0F);
            this.avatar.Name = "avatar";
            this.avatar.ResourceID = "5";
            this.avatar.Size = new System.Drawing.Size(50, 50);
            this.avatar.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            // 
            // moreBtn
            // 
            this.moreBtn.BackColor = System.Drawing.Color.Transparent;
            this.moreBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.moreBtn.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.moreBtn.Location = new System.Drawing.Point(56, 149);
            this.moreBtn.Margin = new Smobiler.Core.Controls.Margin(4F, 0F, 0F, 0F);
            this.moreBtn.Name = "moreBtn";
            this.moreBtn.Size = new System.Drawing.Size(45, 19);
            this.moreBtn.Text = "展开";
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel3,
            this.panel4,
            this.panel5,
            this.panel6});
            this.panel2.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel2.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel2.Location = new System.Drawing.Point(56, 0);
            this.panel2.Margin = new Smobiler.Core.Controls.Margin(4F, 0F, 4F, 0F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 12);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon1,
            this.label1});
            this.panel3.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel3.Flex = 1;
            this.panel3.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(57, 0);
            this.panel3.Touchable = true;
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.DarkGray;
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "share";
            this.fontIcon1.Size = new System.Drawing.Size(20, 0);
            // 
            // label1
            // 
            this.label1.DisplayMember = "repost";
            this.label1.FontSize = 11F;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 0);
            this.label1.Text = "label1";
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon2,
            this.label2});
            this.panel4.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel4.Flex = 1;
            this.panel4.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(57, 0);
            this.panel4.Touchable = true;
            // 
            // fontIcon2
            // 
            this.fontIcon2.ForeColor = System.Drawing.Color.DarkGray;
            this.fontIcon2.Name = "fontIcon2";
            this.fontIcon2.ResourceID = "commenting-o";
            this.fontIcon2.Size = new System.Drawing.Size(20, 0);
            // 
            // label2
            // 
            this.label2.DisplayMember = "comment";
            this.label2.FontSize = 11F;
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 0);
            this.label2.Text = "label1";
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon3,
            this.label3});
            this.panel5.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel5.Flex = 1;
            this.panel5.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(57, 0);
            this.panel5.Touchable = true;
            // 
            // fontIcon3
            // 
            this.fontIcon3.ForeColor = System.Drawing.Color.DarkGray;
            this.fontIcon3.Name = "fontIcon3";
            this.fontIcon3.ResourceID = "thumbs-o-up";
            this.fontIcon3.Size = new System.Drawing.Size(20, 0);
            // 
            // label3
            // 
            this.label3.DisplayMember = "like";
            this.label3.FontSize = 11F;
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 0);
            this.label3.Text = "label1";
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon4,
            this.label4});
            this.panel6.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel6.Flex = 1;
            this.panel6.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(57, 0);
            this.panel6.Touchable = true;
            // 
            // fontIcon4
            // 
            this.fontIcon4.ForeColor = System.Drawing.Color.DarkGray;
            this.fontIcon4.Name = "fontIcon4";
            this.fontIcon4.ResourceID = "share-alt";
            this.fontIcon4.Size = new System.Drawing.Size(20, 0);
            // 
            // label4
            // 
            this.label4.FontSize = 11F;
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 0);
            this.label4.Text = "分享";
            // 
            // zoomImage1
            // 
            this.zoomImage1.BindDisplayValueGone = true;
            this.zoomImage1.DisplayMember = "imageName2";
            this.zoomImage1.Location = new System.Drawing.Point(56, 0);
            this.zoomImage1.Margin = new Smobiler.Core.Controls.Margin(4F, 0F, 4F, 0F);
            this.zoomImage1.Name = "zoomImage1";
            this.zoomImage1.Size = new System.Drawing.Size(100, 100);
            // 
            // dedao1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.zoomImage1,
            this.panel2});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "dedao1";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label titleLab;
        private Smobiler.Core.Controls.Label timeLab;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.ImageButton imageButton2;
        private Smobiler.Core.Controls.Label contentLab;
        private Smobiler.Core.Controls.Image avatar;
        private Smobiler.Core.Controls.Button moreBtn;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.ZoomImage zoomImage1;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Panel panel4;
        private Smobiler.Core.Controls.FontIcon fontIcon2;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Panel panel5;
        private Smobiler.Core.Controls.FontIcon fontIcon3;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Panel panel6;
        private Smobiler.Core.Controls.FontIcon fontIcon4;
        private Smobiler.Core.Controls.Label label4;
    }
}