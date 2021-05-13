using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlogsCode_SmobilerForm.SelectForm;
using SelectDemo;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace BlogsCode_SmobilerForm.SelectLayout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class ElmSelectLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public ElmSelectLayout() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public ElmSelectLayout(List<SelectDataPro> selectDatas) : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
            GethHistory(selectDatas);
        }
        private void GethHistory(List<SelectDataPro> selectDatas)
        {
            
            foreach (SelectDataPro data in selectDatas)
            {
                //显示“优惠活动”，“人均价格带”
                Label label1 = new Label()
                {
                    Text = data.title,
                    FontSize = 15,
                    Size = new System.Drawing.Size(0, 25),
                    Bold = true,
                    ForeColor = System.Drawing.Color.Gray,
                    Padding = new Padding(12, 0, 12, 0),
                };
                panel3.Controls.Add(label1);


                if (data.items != null)
                {
                    Panel p1 = new Panel()
                    {
                        Layout = LayoutPosition.Relative,
                        Direction = LayoutDirection.Row,
                        Size = new System.Drawing.Size(0, 0),
                        Padding = new Padding(12, 0, 12, 0),
                        Wrap = LayoutWrap.Wrap,
                        Name = data.type    //此处用于确认筛选项的字段名
                    };
                    for (int i = 0; i < data.items.Length; i++)
                    {
                        Panel tem = new Panel()
                        {
                            Size = new System.Drawing.Size(88, 30),
                            Layout = LayoutPosition.Relative,
                            Direction = LayoutDirection.Row,
                            Touchable = true,
                            Padding = new Padding(6),
                            Margin = new Margin(0, 4, 0, 4),
                            BackColor = System.Drawing.Color.WhiteSmoke, BorderRadius = 4,
                            ItemAlign = LayoutItemAlign.Center,
                            JustifyAlign = LayoutJustifyAlign.Center,
                            Tag = data.items[i].text + "," + "false"  //此处tag用于记录筛选项的文本以及是否被选中
                        };
                        if ((i + 1) % 3 == 2)
                        { tem.Margin = new Margin(6, 4, 6, 4); }
                        if (!string.IsNullOrEmpty(data.items[i].icon))
                        {
                            tem.Controls.Add(new FontIcon()
                            {
                                ForeColor = data.items[i].iconcolor,
                                ResourceID = data.items[i].icon,
                                Size = new System.Drawing.Size(13, 0),
                                Margin = new Margin(0, 0, 0, 0)
                            });
                        }

                        tem.Controls.Add(new Label()
                        {
                            Text = data.items[i].text,
                            ForeColor = System.Drawing.Color.Gray,
                            FontSize=12,
                            Size = new System.Drawing.Size(0, 0),
                            Padding = new Padding(4, 0, 4, 0),
                            Name = "label"

                        });
                        tem.Press += this.SelectPanelPress;
                        p1.Controls.Add(tem);
                    }
                    panel3.Controls.Add(p1);
                }

            }
        }

        private void SelectPanelPress(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            if (panel.Tag.ToString().Contains("false"))
            {
                ChangePanelColor((Panel)sender, System.Drawing.Color.AliceBlue, System.Drawing.Color.DeepSkyBlue);
                ((Panel)sender).Tag = panel.Tag.ToString().Replace("false", "true");
            }
            else
            {
                ChangePanelColor((Panel)sender, System.Drawing.Color.WhiteSmoke, System.Drawing.Color.Gray);
                ((Panel)sender).Tag = panel.Tag.ToString().Replace("true", "false");
            }
        }

        private void ChangePanelColor(Panel panel, System.Drawing.Color color1, System.Drawing.Color color2)
        {
            panel.BackColor = color1;
            if (panel.Controls.Find("label") != null)
            {
                ((Label)panel.Controls.Find("label")).ForeColor = color2;
            }
        }
        private void imageButton1_Press(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.No;
            this.Close();
        }

        private void panel2_Press(object sender, EventArgs e)
        {

        }

        private void imageButton4_Press(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.No;
            this.Close();
        }

        private void button2_Press(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.Yes;
            string query1 = @"SELECT * FROM `testdata`";
            List<Query> queries = GetQueries(panel3);
            string query2 = GetQueryStr(queries);
            string querystr = "";
            if (query2.Length > 0)
            {
                querystr = query1 + "where " + query2;
            }
            else
                querystr = query1;
            ((ElmSelectForm)this.Form).ListBind(querystr);
            this.Close();
        }
        /// <summary>
        /// 清空按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Press(object sender, EventArgs e)
        {
            for (int i = 0; i < panel3.Controls.Count; i++)
            {
                if (panel3.Controls[i].GetType().Name == "Panel")
                {
                    foreach (Panel tem in ((Panel)panel3.Controls[i]).Controls)
                    {
                        if (tem.Tag.ToString().Contains("true"))
                        {
                            ChangePanelColor(tem, System.Drawing.Color.WhiteSmoke, System.Drawing.Color.Gray);
                            tem.Tag = tem.Tag.ToString().Replace("true", "false");
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 得到筛选语句，实际操作可以另写方法
        /// </summary>
        /// <param name="panels"></param>
        /// <returns></returns>
        private List<Query> GetQueries(Panel panels)
        {
            List<Query> queries = new List<Query>();
            for (int j = 0; j < panels.Controls.Count; j++)
            {
                //判断是否为panel控件
                if (panels.Controls[j].GetType().Name == "Panel")
                {
                    Panel panel = (Panel)panels.Controls[j];
                    //判断是否为单选项

                    List<Query> temp = new List<Query>();
                    string keyword = "";
                    foreach (Panel tem in panel.Controls)
                    {
                        if (tem.Tag.ToString().Contains("true"))
                        {
                            string[] tags = tem.Tag.ToString().Split(',');
                            keyword = tags[0];
                            string querystr = panel.Name + " like '%" + keyword + "%'";
                            temp.Add(new Query() { query = querystr, action = "or" });

                        }
                    }
                    string keyword1 = GetQueryStr(temp);
                    if (!string.IsNullOrEmpty(keyword1))
                        queries.Add(new Query() { query = keyword1, action = "add" });
                }
            }

            return queries;
        }

        private string GetQueryStr(List<Query> queries)
        {
            string result = "";
            if (queries.Count > 0)
            {
                result = "( ";
                for (int i = 0; i < queries.Count; i++)
                {
                    Query query = queries[i];
                    if (i < queries.Count - 1)
                        result += query.query + " " + query.action + " ";
                    else result += query.query;
                }
                result += " )";
            }
            return result;
        }

    }

}