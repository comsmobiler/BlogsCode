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
    partial class XCSearch : Smobiler.Core.Controls.MobileForm
    {
        public XCSearch() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        private DBClass dBClass = new DBClass();
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
            ShowXCLayout();

        }
        private void ShowXCLayout()
        {
            //筛选项数据
            SelectDataPro d1 = new SelectDataPro()
            {
                title = "搜索推荐",
                items = new SelectItem[] {
                    new SelectItem(){ text="我的附近",backColor=System.Drawing.Color.AliceBlue},
                    new SelectItem(){ text="酒店",icon="ios-bed",iconcolor=System.Drawing.Color.Red},
                    new SelectItem(){ text="探索全球",icon="ios-airplane",iconcolor=System.Drawing.Color.Blue},
                    new SelectItem(){text="杭州马可波罗假日酒店" },},
                ishow = true
            };

            DataTable dt1 = new DataTable();
            dt1.Columns.Add("no");
            dt1.Columns.Add("lab");
            dt1.Columns.Add("peo");
            dt1.Rows.Add("-", "秋季出行好去处，景区热门景点大全");
            dt1.Rows.Add("1", "温泉",21014);
            dt1.Rows.Add("2", "故宫博物馆",20335);
            dt1.Rows.Add("3", "香山",20335);
            dt1.Rows.Add("4", "古北水镇",20124);
            dt1.Rows.Add("5", "三亚",20124);
            SelectDataPro d2 = new SelectDataPro()
            {
                title = "北京热搜",
                dataTable = dt1,
                shape=0,
                ishow = false
            };

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("lab");
            dt2.Columns.Add("img1");
            dt2.Columns.Add("img2");
            dt2.Columns.Add("img3");
            dt2.Rows.Add("【厦门.行程路线】漫步琴岛，聆听鼓浪屿的音符，环岛骑行，去厦大感受最美校园的一缕阳光。by游游君","page1","page2","page3");
            dt2.Rows.Add("【厦门.精选榜单】品质旅行好去处，景点人气榜+美食林精选榜+酒店人气榜+美食人气榜", "page2", "page1", "page3");
    
            SelectDataPro d3 = new SelectDataPro()
            {
                title = "精彩推荐",
                dataTable=dt2,
                shape=1,
                ishow = false
            };
            List<SelectDataPro> sds = new List<SelectDataPro>();
            sds.Add(d1);
            sds.Add(d2);
            sds.Add(d3);
            
            //跳转窗体
            XCLayout form = new XCLayout(sds, keyLab.Text);
            Show(form, (obj, args) =>
             {
                 if (form.ShowResult == ShowResult.Yes)
                 {
                     keyLab.Text = form.currentkey;
                     DataTable dt = dBClass.DbConnectAndQuert(form.querystr);
                     listView1.Rows.Clear();
                     listView1.DataSource = dt;
                     listView1.DataBind();
                 }
             });

        }

        
    }
}
