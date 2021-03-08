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
    partial class RRSearch : Smobiler.Core.Controls.MobileForm
    {
        public RRSearch() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        private DBClass dBClass=new DBClass();
        private void imageButton1_Press(object sender, EventArgs e)
        {
            this.Close();
        } 
        private void JDSearch_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// 搜索框点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel2_Press(object sender, EventArgs e)
        {
            ShowRRLayout();
        }
        private void ShowRRLayout()
        {
            //筛选项数据
            SelectData d1 = new SelectData()
            {
                title = "搜索历史",
                items = new String[] { "PRD", "电商运营"},
                ishow = true
            };
            SelectData d2 = new SelectData()
            {
                title = "热搜词",
                items = new String[] { "优惠券", "用户画像", "小程序", "运营", "新零售","产品体验报告" },
                ishow = false
            };

            List<SelectData> sds = new List<SelectData>();
            sds.Add(d1);
            sds.Add(d2);
            RRLayout uc = new RRLayout (sds,keyLab.Text);
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
