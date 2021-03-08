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
    partial class GZSearch : Smobiler.Core.Controls.MobileForm
    {
        public GZSearch() : base()
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
            ShowGZLayout();
        }
        private void ShowGZLayout()
        {
            //筛选项数据
            SelectData d1 = new SelectData()
            {
                title = "历史搜索",
                items = new String[] { "奔驰"},
                ishow = true
            };
            SelectData d2 = new SelectData()
            {
                title = "猜你喜欢",
                items = new String[] { "17-31万 奔驰C级", "18-33万 奔驰C级", "17-31万 稳重德系", "17-31万 奔驰专场", "17-31万 三厢轿车", "17-31万 奔驰专场" },
                ishow = false
            };
            SelectData d3 = new SelectData()
            {
                title = "热门搜索",
                items = new String[] { "奔驰C级", "奔驰B级", "奔驰A级", "智跑", "奔驰CLA级","凌度","起亚KX3","起亚KX5","极睿","起亚KX7" },
                ishow = false
            };
            SelectData d4 = new SelectData()
            {
                title = "大家都在看",
                items = new String[] { "【奔驰C级】挑选全国最超值的奔驰C级！", "【奔驰专场】全国最好的奔驰在这里！", "【三厢推荐】知趣生活，活力无限！", "【稳重德系】工业美感，性能科技！", "【奔驰专场】沉着高雅，无线精彩！" ,"【一成购】精选好车，一成就够！"},
                ishow = false
            };
            List<SelectData> sds = new List<SelectData>();
            sds.Add(d1);
            sds.Add(d2);
            sds.Add(d3);
            sds.Add(d4);
            GZLayout uc = new GZLayout (sds,keyLab.Text);
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
