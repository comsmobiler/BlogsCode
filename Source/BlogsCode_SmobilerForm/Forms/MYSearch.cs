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
    partial class MYSearch : Smobiler.Core.Controls.MobileForm
    {
        public MYSearch() : base()
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
                title = "小柚们都在搜",
                items = new String[] { "月经推迟","经期同房","月经量少时间短","夫妻生活","催经方法","早孕检测"},
                ishow = true
            };
            SelectData d2 = new SelectData()
            {
                title = "经期健康",
                items = new String[] { "月经量少", "月经量多","排卵期","经期饮食","早孕症状"},
                ishow = false
            };

            List<SelectData> sds = new List<SelectData>();
            sds.Add(d1);
            sds.Add(d2);
            MYLayout uc = new MYLayout (sds,keyLab.Text);
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
