using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SelectDemo.Layouts
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class ABYLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public ABYLayout() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public ABYLayout(List<SelectDataPro> selectDatas, string defalutStr) : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
            GethHistory(selectDatas, defalutStr);
        }



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
                FontIcon fontIcon = new FontIcon()
                {
                    ResourceID = data.titleicon,
                    Size = new System.Drawing.Size(15, 15),
                    ForeColor = System.Drawing.Color.DimGray,
                };
                Label label1 = new Label()
                {
                    Text = data.title,
                    Flex = 1,
                    FontSize = 15,
                    Size = new System.Drawing.Size(0, 25),
                    Bold = true,
                    ForeColor = System.Drawing.Color.DimGray
                };

                Panel p1 = new Panel()
                {
                    Layout = LayoutPosition.Relative,
                    Direction = LayoutDirection.Row,
                    Size = new System.Drawing.Size(0, 0),
                    Padding = new Padding(14, 0, 14, 0),
                    Border = new Border(0, 1, 0, 0),
                    BorderColor = System.Drawing.Color.WhiteSmoke,
                    ItemAlign = LayoutItemAlign.Center,
                    Margin = new Margin(0, 6, 0, 6)
                };
                p1.Controls.Add(fontIcon);
                p1.Controls.Add(label1);
                disPanel.Controls.Add(p1);

                if (!String.IsNullOrEmpty(data.subtitle))
                {
                    Label temlab = new Label()
                    {
                        Text = data.subtitle,
                        Padding = new Padding(27, 0, 12, 0),
                        Size = new System.Drawing.Size(0, 0),
                        ForeColor = System.Drawing.Color.DimGray
                    }; 
                    disPanel.Controls.Add(temlab);
                }

                Panel p2 = new Panel()
                {
                    Layout = LayoutPosition.Relative,
                    Direction = LayoutDirection.Row,
                    Size = new System.Drawing.Size(0, 0),
                    Padding = new Padding(12, 0, 12, 0),
                    Wrap = LayoutWrap.Wrap
                };
                int length = 0;
                if (data.items == null)
                {
                    length = -1;
                }
                else
                {
                    length = data.items.Length;
                }
                if (data.ishow == true)
                {
                    for (int i = 0; i < length; i++)
                    {
                        Panel tem = new Panel()
                        {
                            Border = new Border(1),
                            BorderColor = System.Drawing.Color.WhiteSmoke,
                            BackColor = System.Drawing.Color.Transparent,
                            BorderRadius = 4,
                            Size = new System.Drawing.Size(0, 0),
                            Padding = new Padding(8),
                            Margin = new Margin(0, 4, 4, 4),
                            Tag = data.items[i].text,
                            Touchable = true,
                            Layout = LayoutPosition.Relative
                        };
                        Label temlab = new Label
                        {
                            Text = data.items[i].text,
                            ForeColor = System.Drawing.Color.Gray,
                            Size = new System.Drawing.Size(0, 0),
                            FontSize = 15
                        };
                        Label temlab1 = new Label()
                        {
                            Text = data.items[i].subtext,
                            ForeColor = System.Drawing.Color.Gray,
                            Size = new System.Drawing.Size(0, 0),
                            FontSize = 13
                        };
                        tem.Press += this.SelectPanelPress;
                        tem.Controls.Add(temlab);
                        tem.Controls.Add(temlab1);
                        p2.Controls.Add(tem);
                    }
                    disPanel.Controls.Add(p2);
                }
                else
                {
                    for (int i = 0; i < length; i++)
                    {
                        Button btn = new Button()
                        {
                            Text = data.items[i].text,
                            Border = new Border(1),
                            BackColor = System.Drawing.Color.Transparent,
                            BorderColor = System.Drawing.Color.WhiteSmoke,
                            ForeColor = System.Drawing.Color.Gray,
                            Size = new System.Drawing.Size(0, 0),
                            Padding = new Padding(8),
                            BorderRadius = 4,
                            Margin = new Margin(0, 4, 8, 4)
                        };
                        btn.Press += this.SelectButtonPress;
                        p2.Controls.Add(btn);
                        disPanel.Controls.Add(p2);
                    }
                }

            }
        }
        public string currentkey;
        public string querystr;



        private void SelectButtonPress(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.ShowResult = ShowResult.Yes;
            currentkey = btn.Text;
            //将查询关键字替换进去
            querystr = @"SELECT * FROM `testdata` where data like '%"+currentkey+"%'";
            this.Close();
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

        private void button2_Press(object sender, EventArgs e)
        {
            
        }
    }
}