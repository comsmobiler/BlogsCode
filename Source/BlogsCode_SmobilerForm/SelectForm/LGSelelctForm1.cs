using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using BlogsCode_SmobilerForm.SelectLayout;
using SelectDemo;

namespace BlogsCode_SmobilerForm.SelectForm
{
    partial class LGSelectForm1 : Smobiler.Core.Controls.MobileForm
    {
        public LGSelectForm1() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        private DBClass dBClass = new DBClass();
       
        private void imageButton2_Press(object sender, EventArgs e)
        {
            ShowSelectDialog("imageButton2");
        }
        private void ShowSelectDialog(string btnName)
        {
            //筛选项数据
            SelectData d1 = new SelectData()
            {
                title = "公司规模",
                items = new String[] { "少于15人", "15-50人", "50-150人", "150-500人", "500-2000人","2000人以上" },
                ishow = true,//是否显示按钮边框
                type = "type1",//数据项字段名
                isradio = false//是否为单选
            };
            SelectData d2 = new SelectData()
            {
                title = "融资阶段",
                items = new String[] { "未融资", "天使轮", "A轮", "B轮", "C轮", "D轮及以上", "上市公司", "不需要融资" },
                ishow = true,
                 type = "type2",//数据项字段名
                isradio = false//是否为单选
            };
            SelectData d3 = new SelectData()
            {
                title = "行业领域",
                items = new String[] { "不限", "移动互联网", "电商", "金融", "企业服务", "教育", "文娱|内容", "游戏", "消费生活", "硬件", "社交", "旅游", "体育", "工具", "汽车|出行", "物流|运输", "医疗|健康", "广告营销", "数据服务", "信息安全", "人工智能", "区块链", "物联网", "VR|AR", "软件开发", "通讯电子", "房产家居", "其他" },
                ishow = true,
                type = "type3",//数据项字段名
                isradio = false//是否为单选
            };
            List<SelectData> sds = new List<SelectData>();
            sds.Add(d1);
            sds.Add(d2);
            sds.Add(d3);
            LGSelelctLayout lg = GetControl(sds, btnName);
            DialogOptions footerDialogOptions;
            footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexStart, System.Drawing.Color.Transparent, Smobiler.Core.Controls.Padding.Empty, true);
            ShowDialog(lg, footerDialogOptions);
        }

        private LGSelelctLayout GetControl(List<SelectData> selectDatas, string btnName)
        {
            LGSelelctLayout lg = new LGSelelctLayout(btnName);
            foreach (SelectData data in selectDatas)
            {
                Label label1 = new Label() { Text = data.title, Size = new System.Drawing.Size(0, 0), Padding = new Padding(6) };
                Panel p1 = new Panel() { Layout = LayoutPosition.Relative, Direction = LayoutDirection.Row, Wrap = LayoutWrap.Wrap, Size = new System.Drawing.Size(0, 0), Padding = new Padding(6), Name = data.type, Tag = data.isradio };

                for (int i = 0; i < data.items.Length; i++)
                {
                    Button btn = new Button()
                    {
                        Text = data.items[i],
                        Border = new Border(1, 1, 1, 1),
                        BorderColor = System.Drawing.Color.Gray,
                        BackColor = System.Drawing.Color.Transparent,
                        ForeColor = System.Drawing.Color.Gray,
                        Size = new System.Drawing.Size(75, 0),
                        Padding = new Padding(8),
                        BorderRadius = 4,
                        Margin = new Margin(0, 4, 4, 4),
                        Tag = false,
                        Name = "btn" + i.ToString()
                    };
                    if (data.ishow == false)
                        btn.Border = new Border(0);
                    if (data.isradio == false)
                        btn.Press += this.SelectButtonPress;
                    else
                        btn.Press += this.SelectRadioButtonPress;
                    p1.Controls.Add(btn);
            }
                lg.mianpanel.Controls.Add(label1);
                lg.mianpanel.Controls.Add(p1);
            }
            return lg;
        }
        private void SelectRadioButtonPress(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            // 通过Tag判断button是否被选中
            if ((bool)btn.Tag == false)
            {
                //将父级panel中的panel全部设置成为选中状态
                foreach (Button button in ((Button)sender).Parent.Controls)
                {
                    button.BorderColor = System.Drawing.Color.Gray;
                    button.ForeColor = System.Drawing.Color.Gray;
                    button.Tag = false;
                }
                ((Button)sender).ForeColor = ((Button)sender).BorderColor = System.Drawing.Color.Orange;
                ((Button)sender).Tag = true;
            }
            else
            {
                ((Button)sender).ForeColor = ((Button)sender).BorderColor = System.Drawing.Color.Gray;
                ((Button)sender).Tag = false;
            }
        }

        private void SelectButtonPress(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            // 通过Tag判断button是否被选中
            if ((bool)btn.Tag == false)
            {
                ((Button)sender).ForeColor = ((Button)sender).BorderColor = System.Drawing.Color.Orange;
                ((Button)sender).Tag = true;
            }
            else
            {
                ((Button)sender).ForeColor = ((Button)sender).BorderColor = System.Drawing.Color.Gray;
                ((Button)sender).Tag = false;
            }
        }
       
        public void ListBind(string querystr)
        {
            if (String.IsNullOrEmpty(querystr) == false)
            {
                DataTable dt = dBClass.DbConnectAndQuert(querystr);
                listView1.Rows.Clear();
                if (dt != null)
                {
                    listView1.DataSource = dt;
                }
                listView1.DataBind();
            }
          
        }
            
        private void button1_Press(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imageButton1_Press_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}