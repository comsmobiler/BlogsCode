using System;
using Smobiler.Core;
namespace SelectDemo.Forms
{
    partial class WXSearch : Smobiler.Core.Controls.MobileForm
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
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.keyLab = new Smobiler.Core.Controls.TextBox();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.keypanel = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.button3 = new Smobiler.Core.Controls.Button();
            this.button4 = new Smobiler.Core.Controls.Button();
            this.button5 = new Smobiler.Core.Controls.Button();
            this.button6 = new Smobiler.Core.Controls.Button();
            this.button7 = new Smobiler.Core.Controls.Button();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2,
            this.button1});
            this.panel1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Smobiler.Core.Controls.Padding(6F);
            this.panel1.Size = new System.Drawing.Size(0, 40);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderRadius = 4;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon1,
            this.keyLab});
            this.panel2.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel2.Flex = 1;
            this.panel2.ItemAlign = Smobiler.Core.Controls.LayoutItemAlign.Center;
            this.panel2.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 30);
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
            this.keyLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.keyLab.Location = new System.Drawing.Point(6, 0);
            this.keyLab.Name = "keyLab";
            this.keyLab.Size = new System.Drawing.Size(0, 0);
            this.keyLab.TextChanged += new System.EventHandler(this.keyLab_TextChanged);
            this.keyLab.SubmitEditing += new System.EventHandler(this.keyLab_SubmitEditing);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderColor = System.Drawing.Color.Transparent;
            this.button1.FontSize = 15F;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 0);
            this.button1.Text = "取消";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // keypanel
            // 
            this.keypanel.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.button2,
            this.button3,
            this.button4,
            this.button5,
            this.button6,
            this.button7});
            this.keypanel.Name = "keypanel";
            this.keypanel.Size = new System.Drawing.Size(0, 106);
            // 
            // label1
            // 
            this.label1.FontSize = 15F;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(100, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 27);
            this.label1.Text = "搜索指定内容";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button2.BorderRadius = 0;
            this.button2.FontSize = 15F;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.button2.Location = new System.Drawing.Point(29, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 20);
            this.button2.Text = "朋友圈";
            this.button2.Press += new System.EventHandler(this.Select_Press);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Border = new Smobiler.Core.Controls.Border(1F, 0F, 1F, 0F);
            this.button3.BorderColor = System.Drawing.Color.Gainsboro;
            this.button3.BorderRadius = 0;
            this.button3.FontSize = 15F;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.button3.Location = new System.Drawing.Point(109, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 20);
            this.button3.Text = "文章";
            this.button3.Press += new System.EventHandler(this.Select_Press);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button4.BorderRadius = 0;
            this.button4.FontSize = 15F;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.button4.Location = new System.Drawing.Point(189, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 20);
            this.button4.Text = "公众号";
            this.button4.Press += new System.EventHandler(this.Select_Press);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button5.BorderRadius = 0;
            this.button5.FontSize = 15F;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.button5.Location = new System.Drawing.Point(29, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 20);
            this.button5.Text = "小程序";
            this.button5.Press += new System.EventHandler(this.Select_Press);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Border = new Smobiler.Core.Controls.Border(1F, 0F, 1F, 0F);
            this.button6.BorderColor = System.Drawing.Color.Gainsboro;
            this.button6.BorderRadius = 0;
            this.button6.FontSize = 15F;
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.button6.Location = new System.Drawing.Point(109, 75);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 20);
            this.button6.Text = "音乐";
            this.button6.Press += new System.EventHandler(this.Select_Press);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button7.BorderRadius = 0;
            this.button7.FontSize = 15F;
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.button7.Location = new System.Drawing.Point(189, 75);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 20);
            this.button7.Text = "表情";
            this.button7.Press += new System.EventHandler(this.Select_Press);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView1});
            this.panel3.Flex = 1;
            this.panel3.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 100);
            // 
            // listView1
            // 
            this.listView1.Flex = 1;
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.Size = new System.Drawing.Size(0, 300);
            this.listView1.TemplateControlName = "ListLayout";
            // 
            // WXSearch
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.keypanel,
            this.panel3});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Dark, System.Drawing.Color.White);
            this.Name = "WXSearch";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.TextBox keyLab;
        private Smobiler.Core.Controls.Panel keypanel;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Button button2;
        private Smobiler.Core.Controls.Button button3;
        private Smobiler.Core.Controls.Button button4;
        private Smobiler.Core.Controls.Button button5;
        private Smobiler.Core.Controls.Button button6;
        private Smobiler.Core.Controls.Button button7;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.ListView listView1;
    }
}