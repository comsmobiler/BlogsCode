using System;
using Smobiler.Core;
namespace BlogsCode_SmobilerForm.MyForm
{
    partial class dedao : Smobiler.Core.Controls.MobileForm
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
            this.backImg = new Smobiler.Core.Controls.Image();
            this.returnBtn = new Smobiler.Core.Controls.ImageButton();
            this.moreBtn = new Smobiler.Core.Controls.ImageButton();
            this.avatarImg = new Smobiler.Core.Controls.Image();
            this.nameLab = new Smobiler.Core.Controls.Label();
            this.IDLab = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.subLab = new Smobiler.Core.Controls.Label();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.noteNumLab = new Smobiler.Core.Controls.Label();
            this.noteLab = new Smobiler.Core.Controls.Label();
            this.idolNumLab = new Smobiler.Core.Controls.Label();
            this.idolLab = new Smobiler.Core.Controls.Label();
            this.followerNumLab = new Smobiler.Core.Controls.Label();
            this.followerLab = new Smobiler.Core.Controls.Label();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.image2 = new Smobiler.Core.Controls.Image();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.gridView1 = new Smobiler.Core.Controls.GridView();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.backImg,
            this.returnBtn,
            this.moreBtn,
            this.avatarImg,
            this.nameLab,
            this.IDLab,
            this.button1,
            this.fontIcon1,
            this.subLab,
            this.panel4});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 210);
            // 
            // backImg
            // 
            this.backImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.backImg.Name = "backImg";
            this.backImg.ResourceID = "8";
            this.backImg.Size = new System.Drawing.Size(300, 86);
            this.backImg.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            // 
            // returnBtn
            // 
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.IconColor = System.Drawing.Color.White;
            this.returnBtn.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.returnBtn.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.returnBtn.ImgTextRatio = new Smobiler.Core.Controls.Ratio(3, 7);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.ResourceID = "angle-left";
            this.returnBtn.Size = new System.Drawing.Size(61, 29);
            this.returnBtn.Text = "返回";
            this.returnBtn.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // moreBtn
            // 
            this.moreBtn.IconColor = System.Drawing.Color.White;
            this.moreBtn.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.moreBtn.Location = new System.Drawing.Point(244, 0);
            this.moreBtn.Name = "moreBtn";
            this.moreBtn.ResourceID = "ellipsis-h";
            this.moreBtn.Size = new System.Drawing.Size(43, 29);
            // 
            // avatarImg
            // 
            this.avatarImg.BorderRadius = 50;
            this.avatarImg.Location = new System.Drawing.Point(11, 63);
            this.avatarImg.Name = "avatarImg";
            this.avatarImg.ResourceID = "6";
            this.avatarImg.Size = new System.Drawing.Size(50, 50);
            this.avatarImg.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            // 
            // nameLab
            // 
            this.nameLab.Bold = true;
            this.nameLab.FontSize = 20F;
            this.nameLab.Location = new System.Drawing.Point(0, 117);
            this.nameLab.Margin = new Smobiler.Core.Controls.Margin(4F, 0F, 0F, 0F);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(100, 20);
            this.nameLab.Text = "杜牧";
            // 
            // IDLab
            // 
            this.IDLab.Location = new System.Drawing.Point(4, 142);
            this.IDLab.Name = "IDLab";
            this.IDLab.Size = new System.Drawing.Size(112, 15);
            this.IDLab.Text = "学号：123123123123";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.BorderRadius = 15;
            this.button1.Location = new System.Drawing.Point(206, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.Text = "+关注";
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.OrangeRed;
            this.fontIcon1.Location = new System.Drawing.Point(4, 162);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "life-ring";
            this.fontIcon1.Size = new System.Drawing.Size(15, 15);
            // 
            // subLab
            // 
            this.subLab.FontSize = 10F;
            this.subLab.Location = new System.Drawing.Point(23, 162);
            this.subLab.Name = "subLab";
            this.subLab.Size = new System.Drawing.Size(140, 15);
            this.subLab.Text = "朝代：唐代   职业：诗人";
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.noteNumLab,
            this.noteLab,
            this.idolNumLab,
            this.idolLab,
            this.followerNumLab,
            this.followerLab});
            this.panel4.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel4.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel4.Location = new System.Drawing.Point(4, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 23);
            // 
            // noteNumLab
            // 
            this.noteNumLab.ForeColor = System.Drawing.Color.OrangeRed;
            this.noteNumLab.Margin = new Smobiler.Core.Controls.Margin(0F, 0F, 3F, 0F);
            this.noteNumLab.Name = "noteNumLab";
            this.noteNumLab.Size = new System.Drawing.Size(0, 0);
            this.noteNumLab.Text = "3";
            // 
            // noteLab
            // 
            this.noteLab.FontSize = 10F;
            this.noteLab.ForeColor = System.Drawing.Color.DarkGray;
            this.noteLab.Margin = new Smobiler.Core.Controls.Margin(0F, 0F, 6F, 0F);
            this.noteLab.Name = "noteLab";
            this.noteLab.Size = new System.Drawing.Size(0, 0);
            this.noteLab.Text = "笔记";
            // 
            // idolNumLab
            // 
            this.idolNumLab.ForeColor = System.Drawing.Color.OrangeRed;
            this.idolNumLab.Margin = new Smobiler.Core.Controls.Margin(0F, 0F, 3F, 0F);
            this.idolNumLab.Name = "idolNumLab";
            this.idolNumLab.Size = new System.Drawing.Size(0, 0);
            this.idolNumLab.Text = "3342";
            // 
            // idolLab
            // 
            this.idolLab.FontSize = 10F;
            this.idolLab.ForeColor = System.Drawing.Color.DarkGray;
            this.idolLab.Margin = new Smobiler.Core.Controls.Margin(0F, 0F, 6F, 0F);
            this.idolLab.Name = "idolLab";
            this.idolLab.Size = new System.Drawing.Size(0, 0);
            this.idolLab.Text = "关注TA的人";
            // 
            // followerNumLab
            // 
            this.followerNumLab.ForeColor = System.Drawing.Color.OrangeRed;
            this.followerNumLab.Margin = new Smobiler.Core.Controls.Margin(0F, 0F, 3F, 0F);
            this.followerNumLab.Name = "followerNumLab";
            this.followerNumLab.Size = new System.Drawing.Size(0, 0);
            this.followerNumLab.Text = "3";
            // 
            // followerLab
            // 
            this.followerLab.FontSize = 10F;
            this.followerLab.ForeColor = System.Drawing.Color.DarkGray;
            this.followerLab.Margin = new Smobiler.Core.Controls.Margin(0F, 0F, 6F, 0F);
            this.followerLab.Name = "followerLab";
            this.followerLab.Size = new System.Drawing.Size(0, 0);
            this.followerLab.Text = "TA关注的人";
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel3,
            this.label5,
            this.gridView1});
            this.panel2.Flex = 1;
            this.panel2.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel2.Name = "panel2";
            this.panel2.Scrollable = true;
            this.panel2.Size = new System.Drawing.Size(0, 100);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2,
            this.image1,
            this.label4,
            this.label3,
            this.image2});
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 163);
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.FontSize = 18F;
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Margin = new Smobiler.Core.Controls.Margin(4F, 0F, 0F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 25);
            this.label1.Text = "全部作品";
            // 
            // label2
            // 
            this.label2.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 2F);
            this.label2.BorderColor = System.Drawing.Color.OrangeRed;
            this.label2.FontSize = 15F;
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(0, 28);
            this.label2.Margin = new Smobiler.Core.Controls.Margin(4F, 0F, 0F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.Text = "讲座2";
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(4, 54);
            this.image1.Name = "image1";
            this.image1.ResourceID = "3";
            this.image1.Size = new System.Drawing.Size(74, 81);
            // 
            // label4
            // 
            this.label4.FontSize = 10F;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(89, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 28);
            this.label4.Text = "《中国小说史略》|也是及解读";
            // 
            // label3
            // 
            this.label3.FontSize = 10F;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(4, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 28);
            this.label3.Text = "《中国小说史略》|也是及解读";
            // 
            // image2
            // 
            this.image2.Location = new System.Drawing.Point(89, 54);
            this.image2.Name = "image2";
            this.image2.ResourceID = "3";
            this.image2.Size = new System.Drawing.Size(74, 81);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Bold = true;
            this.label5.Location = new System.Drawing.Point(4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 28);
            this.label5.Text = "笔记";
            // 
            // gridView1
            // 
            this.gridView1.BackColor = System.Drawing.Color.White;
            this.gridView1.Name = "gridView1";
            this.gridView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.gridView1.PageSizeTextSize = 11F;
            this.gridView1.Size = new System.Drawing.Size(0, 0);
            this.gridView1.TemplateControlName = "dedao1";
            // 
            // dedao
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Load += new System.EventHandler(this.dedao2_Load);
            this.Name = "dedao";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image backImg;
        private Smobiler.Core.Controls.ImageButton returnBtn;
        private Smobiler.Core.Controls.ImageButton moreBtn;
        private Smobiler.Core.Controls.Image avatarImg;
        private Smobiler.Core.Controls.Label nameLab;
        private Smobiler.Core.Controls.Label IDLab;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.Label subLab;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Image image2;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.GridView gridView1;
        private Smobiler.Core.Controls.Panel panel4;
        private Smobiler.Core.Controls.Label noteNumLab;
        private Smobiler.Core.Controls.Label noteLab;
        private Smobiler.Core.Controls.Label idolNumLab;
        private Smobiler.Core.Controls.Label idolLab;
        private Smobiler.Core.Controls.Label followerNumLab;
        private Smobiler.Core.Controls.Label followerLab;
    }
}