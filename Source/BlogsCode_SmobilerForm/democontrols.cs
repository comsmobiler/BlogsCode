using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlogsCode_SmobilerForm.SelectForm;
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
            
            IconMenuViewGroup grp1 = new IconMenuViewGroup("筛选");
            grp1.Items.Add(new IconMenuViewItem("logon", "自如筛选") { Tag = typeof(ZRSelectForm) });
            grp1.Items.Add(new IconMenuViewItem("logon", "饿了么筛选") { Tag = typeof(ElmSelectForm) });
            grp1.Items.Add(new IconMenuViewItem("logon", "拉勾筛选") { Tag = typeof(LGSelectForm1) });
            grp1.Items.Add(new IconMenuViewItem("logon", "拉勾筛选2") { Tag = typeof(LGSelectForm2) });

            this.iconMenuView1.Groups.Add(grp1);
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}