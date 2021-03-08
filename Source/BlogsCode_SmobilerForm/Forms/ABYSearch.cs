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
    partial class ABYSearch : Smobiler.Core.Controls.MobileForm
    {
        public ABYSearch() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private DBClass dBClass = new DBClass();
        private void panel2_Press(object sender, EventArgs e)
        {
            ShowABYLayout();
        }
        private void ShowABYLayout()
        {
            SelectDataPro d1 = new SelectDataPro()
            {
                title = "搜索历史",
                items = new SelectItem[] {
                new SelectItem(){ text="长沙市",subtext="11月16日-11月17日"}
                },
                ishow = true,
                titleicon= "ios-time"
            };
            SelectDataPro d2 = new SelectDataPro()
            {
                title = "长沙市热门目的地附近的房源",
                items = new SelectItem[] { new SelectItem() { text = "五一广场" }, new SelectItem() { text = "天心阁" }, new SelectItem() { text = "湖南省博物馆" }, new SelectItem() { text = "岳麓山" }, new SelectItem() { text = "全部房源" } },
                titleicon = "ios-home",
                ishow=false
            };
            SelectDataPro d3 = new SelectDataPro()
            {
                title = "五一商圈",
                subtitle = "中国.湖南.长沙市",
                titleicon = "ios-pin",
                ishow=false
            };
            List<SelectDataPro> sds = new List<SelectDataPro>();
            sds.Add(d1);
            sds.Add(d2);
            sds.Add(d3);
            ABYLayout uc = new ABYLayout(sds, keyLab.Text);
            DialogOptions footerDialogOptions;
            footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexStart, System.Drawing.Color.Transparent, Smobiler.Core.Controls.Padding.Empty, true);
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