using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SelectDemo.Layouts;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SelectDemo.Forms
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class XCLayout : Smobiler.Core.Controls.MobileForm
    {
        public XCLayout() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public XCLayout(List<SelectDataPro> selectDatas, string defalutStr) : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
            GethHistory(selectDatas, defalutStr);
        }

        public string currentkey;
        public string querystr;

        private void CloseDialog_Press(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.No;
            this.Close();

        }
        private void GethHistory(List<SelectDataPro> selectDatas, string defaultstr)
        {
            this.KeyLab.Text = defaultstr;
            foreach (SelectDataPro data in selectDatas)
            {
                Label label1 = new Label()
                {
                    Text = data.title,
                    Flex = 1,
                    FontSize = 15,
                    Bold = true
                };

                Panel p1 = new Panel()
                {
                    Layout = LayoutPosition.Relative,
                    Direction = LayoutDirection.Row,
                    Size = new System.Drawing.Size(0, 0),
                    Padding = new Padding(12, 0, 12, 0)
                };

                p1.Controls.Add(label1);

                Panel p2 = new Panel()
                {
                    Layout = LayoutPosition.Relative,
                    Direction = LayoutDirection.Row,
                    Size = new System.Drawing.Size(0, 0),
                    Padding = new Padding(12, 0, 12, 0),
                    Wrap = LayoutWrap.Wrap
                };
                if (data.ishow == true)
                {
                    hisPanel.Controls.Add(p1);
                    //添加“搜索推荐”下按钮
                    for (int i = 0; i < data.items.Length; i++)
                    {
                        System.Drawing.Color backcolor = System.Drawing.Color.Transparent;
                        System.Drawing.Color bordercolor = System.Drawing.Color.DimGray;
                        if (data.items[i].backColor.IsEmpty == false)
                        {
                            backcolor = data.items[i].backColor;
                            bordercolor = System.Drawing.Color.Transparent;
                        }

                        Panel tem = new Panel()
                        {
                            BackColor = backcolor,
                            BorderColor = bordercolor,
                            Border = new Border(1),
                            BorderRadius = 16,
                            Size = new System.Drawing.Size(0, 30),
                            Layout = LayoutPosition.Relative,
                            Direction = LayoutDirection.Row,
                            Touchable = true,
                            Padding = new Padding(12, 6, 12, 6),
                            Margin = new Margin(0, 4, 8, 4),

                        };
                        if (String.IsNullOrEmpty(data.items[i].icon) == false)
                        {
                            tem.Controls.Add(new FontIcon()
                            {
                                ForeColor = data.items[i].iconcolor,
                                ResourceID = data.items[i].icon,
                                Size = new System.Drawing.Size(15, 0),
                                Margin = new Margin(0, 0, 3, 0)
                            });
                        }

                        tem.Controls.Add(new Label()
                        {
                            Text = data.items[i].text,
                            ForeColor = System.Drawing.Color.DarkGray,
                            Size = new System.Drawing.Size(0, 0)
                        });
                        tem.Tag = data.items[i].text;
                        tem.Press += this.SelectPanelPress;
                        p2.Controls.Add(tem);

                    }

                    hisPanel.Controls.Add(p2);
                }
                else
                {
                    disPanel.Controls.Add(p1);
                    if (data.shape == 0)
                    {
                        //添加listview
                        ListView listView = new ListView()
                        {
                            Size = new System.Drawing.Size(0, 0),
                            Margin = new Margin(12, 0, 12, 0)
                        };
                        disPanel.Controls.Add(listView);
                        listView.TemplateControl = new XCListTemplate();
                        listView.DataSource = data.dataTable;
                        listView.DataBind();

                    }
                    else
                    {
                        //添加gridview
                        GridView gridView = new GridView()
                        {
                            Size = new System.Drawing.Size(0, 0),
                            Margin = new Margin(12, 0, 12, 0)
                        };
                        disPanel.Controls.Add(gridView);
                        gridView.TemplateControl = new XCGRIDTemplate();
                        gridView.DataSource = data.dataTable;
                        gridView.DataBind();
                    }


                }

            }
        }

        private void SelectPanelPress(object sender, EventArgs e)
        {
            Panel pan = (Panel)sender;
            this.ShowResult = ShowResult.Yes;
            currentkey = pan.Tag.ToString();
            //将查询关键字替换进去
            querystr = @"SELECT * FROM `testdata` where data like '%"+currentkey+"%'";
            this.Close();
        }
        /// <summary>
        /// 搜索框回车键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyLab_SubmitEditing(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.Yes;
            currentkey = KeyLab.Text;
            //将查询关键字替换进去
            querystr = @"SELECT * FROM `testdata` where data like '%"+KeyLab.Text+"%'";
            this.Close();
        }
        private void imageButton2_Press(object sender, EventArgs e)
        {
            this.Close();
        }
        public void KeyWordSearching(string keyword)
        {
            this.ShowResult = ShowResult.Yes;
            currentkey = keyword;
            querystr = @"SELECT * FROM `testdata` where data like '%"+keyword+"%'";
            this.Close();
        }
    }
}