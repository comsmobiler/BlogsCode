using System;
using Smobiler.Core;
namespace BlogsCode_SmobilerForm.MyLayout
{
    partial class meiyouLayout : Smobiler.Core.Controls.MobileUserControl
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.image2 = new Smobiler.Core.Controls.Image();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.fontIcon2 = new Smobiler.Core.Controls.FontIcon();
            this.label6 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // panel2
            // 
            this.panel2.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2,
            this.imageButton1,
            this.image1,
            this.label3,
            this.panel3,
            this.fontIcon1,
            this.label5,
            this.fontIcon2,
            this.label6});
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 140);
            // 
            // label1
            // 
            this.label1.DisplayMember = "Name1";
            this.label1.Location = new System.Drawing.Point(45, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.DisplayMember = "Name2";
            this.label2.FontSize = 12F;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(45, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.Text = "label2";
            // 
            // imageButton1
            // 
            this.imageButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.imageButton1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton1.Location = new System.Drawing.Point(263, 8);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "ellipsis-h";
            this.imageButton1.Size = new System.Drawing.Size(27, 20);
            // 
            // image1
            // 
            this.image1.BorderRadius = 25;
            this.image1.Location = new System.Drawing.Point(0, 8);
            this.image1.Name = "image1";
            this.image1.ResourceID = "4";
            this.image1.Size = new System.Drawing.Size(35, 35);
            this.image1.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            // 
            // label3
            // 
            this.label3.FontSize = 14F;
            this.label3.Location = new System.Drawing.Point(25, 43);
            this.label3.Margin = new Smobiler.Core.Controls.Margin(20F, 0F, 0F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
            this.label3.Text = "发布了文章";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image2,
            this.label4});
            this.panel3.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel3.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel3.Location = new System.Drawing.Point(45, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 48);
            this.panel3.Touchable = true;
            this.panel3.Press += new System.EventHandler(this.panel3_Press);
            // 
            // image2
            // 
            this.image2.BackColor = System.Drawing.Color.White;
            this.image2.DisplayMember = "imageName";
            this.image2.Flex = 1;
            this.image2.Name = "image2";
            this.image2.Size = new System.Drawing.Size(0, 0);
            // 
            // label4
            // 
            this.label4.DisplayMember = "Name3";
            this.label4.Flex = 4;
            this.label4.FontSize = 14F;
            this.label4.Name = "label4";
            this.label4.NumberOfLines = 2;
            this.label4.Padding = new Smobiler.Core.Controls.Padding(8F, 0F, 8F, 0F);
            this.label4.Size = new System.Drawing.Size(0, 0);
            this.label4.Text = "label4";
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.Gainsboro;
            this.fontIcon1.Location = new System.Drawing.Point(180, 117);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "commenting-o";
            this.fontIcon1.Size = new System.Drawing.Size(26, 13);
            // 
            // label5
            // 
            this.label5.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label5.Location = new System.Drawing.Point(209, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.Text = "34";
            // 
            // fontIcon2
            // 
            this.fontIcon2.ForeColor = System.Drawing.Color.Gainsboro;
            this.fontIcon2.Location = new System.Drawing.Point(243, 117);
            this.fontIcon2.Name = "fontIcon2";
            this.fontIcon2.ResourceID = "heart-o";
            this.fontIcon2.Size = new System.Drawing.Size(19, 13);
            // 
            // label6
            // 
            this.label6.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label6.Location = new System.Drawing.Point(262, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.Text = "赞";
            // 
            // meiyouLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(0, 141);
            this.Name = "meiyouLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.Image image2;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.FontIcon fontIcon2;
        private Smobiler.Core.Controls.Label label6;
    }
}