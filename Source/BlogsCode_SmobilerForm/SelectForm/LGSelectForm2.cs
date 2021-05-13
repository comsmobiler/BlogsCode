using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using SelectDemo;
using BlogsCode_SmobilerForm.SelectLayout;

namespace BlogsCode_SmobilerForm.SelectForm
{
    partial class LGSelectForm2 : Smobiler.Core.Controls.MobileForm
    {
        public LGSelectForm2() : base()
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
                title = "工作经验",
                items = new String[] { "应届毕业生", "3年及以下", "3-5年", "5-10年", "10年以上","经验不限" },
                 type = "type1",//数据项字段名
                isradio = false//是否为单选
            };
            SelectData d2 = new SelectData()
            {
                title = "学历要求",
                items = new String[] { "大专", "本科", "硕士", "博士", "不要求" },
                 type = "type2",//数据项字段名
                isradio = false//是否为单选
            };
            SelectData d3 = new SelectData()
            {
                title = "学历要求",
                items = new String[] { "全职", "兼职","实习" },
                type = "type3",//数据项字段名
                isradio = false//是否为单选
            };
            List<SelectData> sds = new List<SelectData>();
            sds.Add(d1);
            sds.Add(d2);
            sds.Add(d3);
            LGSelectLayout1 uc = GetControl(sds, btnName);
            DialogOptions footerDialogOptions;
            footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexStart, System.Drawing.Color.Transparent, Smobiler.Core.Controls.Padding.Empty, true);
            ShowDialog(uc, footerDialogOptions);
        }

        private LGSelectLayout1 GetControl(List<SelectData> selectDatas, string btnName)
        {
            LGSelectLayout1 uc = new LGSelectLayout1(btnName);
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
                            Tag = false
                        };
                        btn.Press += this.SelectButtonPress;
                        p1.Controls.Add(btn);
                    }
                uc.mianpanel.Controls.Add(label1);
                uc.mianpanel.Controls.Add(p1);
            }
            return uc;
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
                ((Button)sender).ForeColor = ((Button)sender).BorderColor = System.Drawing.Color.ForestGreen;
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
                ((Button)sender).ForeColor = ((Button)sender).BorderColor = System.Drawing.Color.ForestGreen;
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

        private void imageButton1_Press(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}