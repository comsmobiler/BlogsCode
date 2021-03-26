using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using SelectDemo.Layouts;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SelectDemo
{
    partial class ElmSearch : Smobiler.Core.Controls.MobileForm
    {
        public ElmSearch() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private DBClass dBClass = new DBClass();//DBClass 数据库查询类
        private void panel2_Press(object sender, EventArgs e)
        {
            ShowElmLayout();
        }
        private void ShowElmLayout()
        {
            //筛选项数据
            SelectData d1 = new SelectData()
            {
                title = "历史搜索",
                items = new String[] { "粥" },
                ishow = true
            };
            SelectData d2 = new SelectData()
            {
                title = "历史搜索",
                items = new String[] { "超级发布30减20起", "小恒水饺", "早餐", "油条", "炸鸡" ,"包子","皮蛋瘦肉粥"},
                ishow = false
            };

            List<SelectData> sds = new List<SelectData>();
            sds.Add(d1);
            sds.Add(d2);
            
            // 实例化ElmLayout
            ElmLayout uc = new ElmLayout(sds, keyLab.Text);
            DialogOptions footerDialogOptions;
            footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexStart, System.Drawing.Color.Transparent, Smobiler.Core.Controls.Padding.Empty, true);
            //在窗体中弹出ElmLayout
            ShowDialog(uc, footerDialogOptions, (obj, args) =>
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
        private void imageButton1_Press(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}