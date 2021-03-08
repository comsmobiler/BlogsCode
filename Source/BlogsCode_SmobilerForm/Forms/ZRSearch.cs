using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using SelectDemo.Layouts;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SelectDemo.Forms
{
    partial class ZRSearch : Smobiler.Core.Controls.MobileForm
    {
        public ZRSearch() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        private DBClass dBClass=new DBClass();
        private void imageButton1_Press(object sender, EventArgs e)
        {
            this.Close();
        } 
        /// <summary>
        /// 搜索框点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel2_Press(object sender, EventArgs e)
        {
            ShowZRLayout();
        }
        private void ShowZRLayout()
        {
            //筛选项数据
            SelectDataPro d1 = new SelectDataPro()
            {
                title = "搜索历史",
                items = new SelectItem[] { new SelectItem() { text = "回龙观.直租一居" },new SelectItem() { text = "回龙观.合租/整租" } },
                ishow = true
            };
            SelectDataPro d2 = new SelectDataPro()
            {
                title = "热门搜索",
                items = new SelectItem[] { new SelectItem() { text = "青年陆" },new SelectItem() { text = "宋家庄" },new SelectItem() { text = "融易家园" },new SelectItem() { text = "天通苑" },new SelectItem() { text = "双井" },new SelectItem() { text = "望京" },new SelectItem(){ text ="西二旗"} },
                ishow = false,
                shape=0
            };
            SelectDataPro d3 = new SelectDataPro()
            {
                title = "周边热搜",
                items = new SelectItem[] { new SelectItem() { text = "南邵", subtext = "地铁站-昌平线" },new SelectItem() { text = "沙河高教园", subtext = "地铁站-昌平线" } },
                ishow = false,
                shape=1
            };
            List<SelectDataPro> sds = new List<SelectDataPro>();
            sds.Add(d1);
            sds.Add(d2);
            sds.Add(d3);
            ZRLayout uc = new ZRLayout (sds,keyLab.Text);
            DialogOptions footerDialogOptions;
            footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexStart, System.Drawing.Color.Transparent, Smobiler.Core.Controls.Padding.Empty, true);
            ShowDialog(uc, footerDialogOptions,(obj,args)=>
            {
                if (uc.ShowResult == ShowResult.Yes)
                {
                    keyLab.Text = uc.currentkey;
                    DataTable dt = dBClass.DbConnectAndQuert(uc.querystr);
                    listView1.Rows.Clear();
                    listView1.DataSource = dt;
                    listView1.DataBind();
                }
            });

        }
    }
}
