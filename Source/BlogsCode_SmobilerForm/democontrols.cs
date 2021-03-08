using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SelectDemo;
using SelectDemo.Forms;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace BlogsCode_SmobilerForm
{
    partial class democontrols : Smobiler.Core.Controls.MobileForm
    {
        public democontrols() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void iconMenuView1_ItemPress(object sender, IconMenuViewItemPressEventArgs e)
        {
            MobileForm demoForm = Activator.CreateInstance((Type)e.Item.Tag) as MobileForm;
            this.Show(demoForm);
        }

        private void democontrols_Load(object sender, EventArgs e)
        {
            //Basic Control
            IconMenuViewGroup grpBasic = new IconMenuViewGroup("搜索");
            grpBasic.Items.Add(new IconMenuViewItem("logon", "饿了么搜索") { Tag = typeof(ElmSearch) });
            grpBasic.Items.Add(new IconMenuViewItem("logon", "京东搜索") { Tag = typeof(JDSearch) });
            grpBasic.Items.Add(new IconMenuViewItem("logon", "Keep搜索") { Tag = typeof(KeepSearch) });
            grpBasic.Items.Add(new IconMenuViewItem("logon", "人人搜索") { Tag = typeof(RRSearch) });
            grpBasic.Items.Add(new IconMenuViewItem("logon", "瓜子搜索") { Tag = typeof(GZSearch) });
            grpBasic.Items.Add(new IconMenuViewItem("logon", "网易云搜索") { Tag = typeof(WYSearch) });
            grpBasic.Items.Add(new IconMenuViewItem("logon", "爱彼迎搜索") { Tag = typeof(ABYSearch) });
            grpBasic.Items.Add(new IconMenuViewItem("logon", "得到搜索") { Tag = typeof(DDSearch) });
            grpBasic.Items.Add(new IconMenuViewItem("logon", "春雨医生搜索") { Tag = typeof(CYSearch) });
            grpBasic.Items.Add(new IconMenuViewItem("logon", "微信搜索") { Tag = typeof(WXSearch) });
            grpBasic.Items.Add(new IconMenuViewItem("logon", "考拉搜索") { Tag = typeof(KLSearch) });
            grpBasic.Items.Add(new IconMenuViewItem("logon", "美柚搜索") { Tag = typeof(MYSearch) });
            grpBasic.Items.Add(new IconMenuViewItem("logon", "自如搜索") { Tag = typeof(ZRSearch) });
            grpBasic.Items.Add(new IconMenuViewItem("logon", "知乎搜索") { Tag = typeof(ZHSearch) });
            grpBasic.Items.Add(new IconMenuViewItem("logon", "携程搜索") { Tag = typeof(XCSearch) });

            this.iconMenuView1.Groups.Add(grpBasic);
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}