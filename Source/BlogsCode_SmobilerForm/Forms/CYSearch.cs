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
    partial class CYSearch : Smobiler.Core.Controls.MobileForm
    {
        public CYSearch() : base()
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
            ShowJDLayout();
        }
        private void ShowJDLayout()
        {
            //筛选项数据
            SelectData d1 = new SelectData()
            {
                title = "历史搜索",
                items = new String[] { "青霉素", "糖尿病" },
                ishow = true
            };
            SelectData d2 = new SelectData()
            {
                title = "搜索推荐",
                items = new String[] { "减肥训练营", "痔疮", "动态血压", "流感", "发烧" },
                ishow = false
            };

            List<SelectData> sds = new List<SelectData>();
            sds.Add(d1);
            sds.Add(d2);
            CYLayout uc = new CYLayout (sds,keyLab.Text);
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
