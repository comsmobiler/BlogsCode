using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BlogsCode_SmobilerForm.SelectLayout;
using SelectDemo;
using SelectDemo.Layouts;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace BlogsCode_SmobilerForm.SelectForm
{
    partial class ElmSelectForm : Smobiler.Core.Controls.MobileForm
    {
        public ElmSelectForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private DBClass dBClass = new DBClass();
        private void panel2_Press(object sender, EventArgs e)
        {
            
        }
       
        private void imageButton1_Press(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imageButton4_Press(object sender, EventArgs e)
        {
            ImageButton imageButton = (ImageButton)sender;
            switch (imageButton.Text)
            {
                case "综合排序":
                    ShowElmLayout();
                    break;
                case "销量最高":
                    break;
                case "距离最近":
                    break;
                case "筛选":
                    break;
            }

        }
        private void ShowElmLayout()
        {
            //筛选项数据
            SelectDataPro d1 = new SelectDataPro()
            {
                title = "优惠活动",
                items = new SelectItem[] {
                    new SelectItem(){text="会员领红包",icon="birthday-cake",iconcolor=System.Drawing.Color.Gold },
                    new SelectItem(){text="首单立减" },
                    new SelectItem(){text="津贴联盟" },
                    new SelectItem(){text="门店新客立减" },
                    new SelectItem(){text="满减优惠" },
                    new SelectItem(){text="下单返红包" },
                    new SelectItem(){text="进店领红包" },
                    new SelectItem(){text="赠品优惠" },
                    new SelectItem(){text="特价商品" },
                },
                type = "type1",
                shape = 0
            };
            SelectDataPro d2 = new SelectDataPro()
            {
                title = "优惠活动",
                items = new SelectItem[] {
                    new SelectItem(){text="蜂鸟专送",icon="instagram",iconcolor=System.Drawing.Color.DeepSkyBlue },
                    new SelectItem(){text="品牌商家",icon="gift",iconcolor=System.Drawing.Color.OrangeRed },
                    new SelectItem(){text="新店",icon="home",iconcolor=System.Drawing.Color.Gold },
                    new SelectItem(){text="食安保",icon="archive",iconcolor=System.Drawing.Color.Pink },
                    new SelectItem(){text="开发票",icon="wpforms",iconcolor=System.Drawing.Color.GreenYellow },
                },
                type = "type2",
                shape = 0
            };
            List<SelectDataPro> sds = new List<SelectDataPro>();
            sds.Add(d1);
            sds.Add(d2);
            // 实例化ElmLayout
            ElmSelectLayout uc = new ElmSelectLayout(sds);
            DialogOptions footerDialogOptions;
            footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexStart, System.Drawing.Color.FromArgb(128, 128, 128, 128), Smobiler.Core.Controls.Padding.Empty, true);
            //在窗体中弹出ElmLayout
            ShowDialog(uc, footerDialogOptions, (obj, args) =>
            {
                if (uc.ShowResult == ShowResult.Yes)
                {
                    DataTable dt = dBClass.DbConnectAndQuert("");
                    listView1.Rows.Clear();
                    listView1.DataSource = dt;
                    listView1.DataBind();
                }
            });

        }
        /// <summary>
        /// 根据筛选条件查询数据并绑定
        /// </summary>
        /// <param name="query"></param>
        public  void ListBind( string query)
        {
            DataTable dt = dBClass.DbConnectAndQuert(query);
            listView1.Rows.Clear();
            if(dt!=null)
            {
                listView1.DataSource = dt;
                listView1.DataBind();
            }    
        }
    }
}