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
    partial class ZHSearch : Smobiler.Core.Controls.MobileForm
    {
        public ZHSearch() : base()
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
            ShowZHLayout();
        }
        private void ShowZHLayout()
        {
            //筛选项数据
            SelectDataPro d1 = new SelectDataPro()
            {
                title = "热搜",
                items = new SelectItem[] {
                    new SelectItem() { text = "@雷军知乎首次发问",subtext="大家都在搜" },
                    new SelectItem() { text = "十月CPI上涨3.8%",subtext="背后有哪些深度解读" },
                    new SelectItem() { text = "李诞奇葩说辩论首秀",subtext="你喜欢脱口秀式辩论吗" },
                    new SelectItem() { text = "王思聪被限制高消费",subtext="投资出了什么问题？" },
                    new SelectItem() { text = "电影《小丑》上线",subtext="为何小丑会成为小丑" },
                    new SelectItem() { text = "双十一倒计时",subtext="快上车" },
                    new SelectItem() { text = "FPX夺冠",subtext="中国战队再次夺冠" },
                    new SelectItem() { text = "双十一狂欢夜晚会",subtext="你期待吗" },
                },
                ishow=true
            };

            SelectDataPro d2 = new SelectDataPro()
            {
                title = "双十一",
                ishow = false
            };
            SelectDataPro d3 = new SelectDataPro()
            {
                title = "影视",
                ishow = false
            };
            SelectDataPro d4 = new SelectDataPro()
            {
                title = "数码",
                ishow = false
            };
            SelectDataPro d5 = new SelectDataPro()
            {
                title = "体育",
                ishow = false
            };
            SelectDataPro d6 = new SelectDataPro()
            {
                title = "百科",
                ishow = false
            };
            List<SelectDataPro> sds = new List<SelectDataPro>();
            sds.Add(d1);
            sds.Add(d2);
            sds.Add(d3);
            sds.Add(d4);
            sds.Add(d5);
            sds.Add(d6);
            ZHSearch_1 form = new ZHSearch_1(sds, keyLab.Text);
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
