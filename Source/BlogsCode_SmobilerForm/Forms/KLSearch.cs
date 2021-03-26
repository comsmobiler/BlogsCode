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
    partial class KLSearch : Smobiler.Core.Controls.MobileForm
    {
        public KLSearch() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        private DBClass dBClass = new DBClass();
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
            SelectDataPro d1 = new SelectDataPro()
            {
                title = "最近搜索",
                items = new SelectItem[] { new SelectItem() { text = "雅思兰黛" } },
                ishow = true,
                shape = 0
            };
            SelectDataPro d2 = new SelectDataPro()
            {
                title = "搜索发现",
                items = new SelectItem[] {
                    new SelectItem() { text = "考拉三周年人气热销榜",foreColor=System.Drawing.Color.Firebrick },
                    new SelectItem(){text="电动牙刷"},
                new SelectItem(){text="尤妮佳"},
                new SelectItem(){text="豆豆鞋"},
                new SelectItem(){text="沐浴露"},
                new SelectItem(){text="日东红茶",foreColor=System.Drawing.Color.Firebrick},
                new SelectItem(){text="榴莲"},
                new SelectItem(){text="电动牙刷"},
                new SelectItem(){text="尤妮佳"},
                new SelectItem(){text="雅思兰黛"},
                new SelectItem(){text="豆豆鞋"}},
                ishow = false,
                shape = 0
            };
            SelectDataPro d3 = new SelectDataPro()
            {
                title = "常用分类",
                items = new SelectItem[] {
                    new SelectItem() { text = "基础护肤", backColor = System.Drawing.Color.SeaShell },
                    new SelectItem() { text = "面部清洁", backColor = System.Drawing.Color.Ivory },
                    new SelectItem() { text = "面膜", backColor = System.Drawing.Color.Honeydew },
                    new SelectItem() { text = "兰蔻", backColor = System.Drawing.Color.MintCream },
                    new SelectItem() { text = "雅诗兰黛", backColor = System.Drawing.Color.BlanchedAlmond },
                    new SelectItem() { text = "资生堂", backColor = System.Drawing.Color.SeaShell },
                    new SelectItem() { text = "眼部护理 ", backColor = System.Drawing.Color.Ivory },
                    new SelectItem() { text = "悦诗风吟", backColor = System.Drawing.Color.Honeydew },
                    new SelectItem() { text = "美容护肤", backColor = System.Drawing.Color.MintCream }},
                ishow = false,
                shape = 1
            };

            List<SelectDataPro> sds = new List<SelectDataPro>();
            sds.Add(d1);
            sds.Add(d2);
            sds.Add(d3);

            //弹出KLLayout
            KLLayout uc = new KLLayout(sds, keyLab.Text);
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
    }
}
