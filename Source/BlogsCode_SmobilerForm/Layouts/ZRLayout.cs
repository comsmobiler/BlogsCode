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
    partial class ZRLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public ZRLayout() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public ZRLayout(List<SelectDataPro> selectDatas, string defalutStr) : base()
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
                    Size = new System.Drawing.Size(0, 25)
                };

                Panel p1 = new Panel()
                {
                    Layout = LayoutPosition.Relative,
                    Direction = LayoutDirection.Row,
                    Size = new System.Drawing.Size(0, 0),
                    Padding = new Padding(12, 0, 12, 0)
                };

                p1.Controls.Add(label1);


                if (data.ishow == true)
                {
                    Panel p2 = new Panel()
                    {
                        Layout = LayoutPosition.Relative,
                        Padding = new Padding(12, 0, 12, 0),
                        Size = new System.Drawing.Size(0, 0)
                    };
                    //添加删除按钮
                    ImageButton imgbtn = new ImageButton()
                    {
                        ImageType = ImageEx.ImageStyle.FontIcon,
                        ResourceID = "trash-o",
                        IconColor = System.Drawing.Color.Silver,
                        Size = new System.Drawing.Size(25, 25)
                    };
                    imgbtn.Press += this.DeleteButtonPress;
                    p1.Controls.Add(imgbtn);

                    for (int i = 0; i < data.items.Length; i++)
                    {
                        Panel tem = new Panel()
                        {
                            Size = new System.Drawing.Size(0, 30),
                            Layout = LayoutPosition.Relative,
                            Direction = LayoutDirection.Row,
                            Touchable = true,
                            Padding = new Padding(0, 6, 0, 6),
                            BackColor = System.Drawing.Color.Transparent,
                            Margin = new Margin(0, 4, 8, 4),
                            BorderRadius = 12,
                            ItemAlign = LayoutItemAlign.Center
                        };
                        tem.Controls.Add(new FontIcon()
                        {
                            ForeColor = System.Drawing.Color.Silver,
                            ResourceID = "md-time",
                            Size = new System.Drawing.Size(15, 0)
                        });
                        tem.Controls.Add(new Label()
                        {
                            Text = data.items[i].text,
                            ForeColor = System.Drawing.Color.Gray,
                            Flex = 1,
                            FontSize = 15,
                            Border = new Border(0, 0, 0, 1),
                            BorderColor = System.Drawing.Color.Silver,
                            Size = new System.Drawing.Size(0, 0),
                            Padding = new Padding(0, 6, 0, 6),
                            Margin = new Margin(6, 0, 0, 0)
                        });
                        tem.Tag = data.items[i].text;
                        tem.Press += this.SelectPanelPress;



                        p2.Controls.Add(tem);
                    }
                    hisPanel.Controls.Add(p1);
                    hisPanel.Controls.Add(p2);
                }
                else
                {
                    disPanel.Controls.Add(p1);
                    if (data.shape == 0)
                    {
                        Panel p2 = new Panel()
                        {
                            Layout = LayoutPosition.Relative,
                            Padding = new Padding(12, 0, 12, 0),
                            Size = new System.Drawing.Size(0, 0),
                            Direction = LayoutDirection.Row,
                            Wrap = LayoutWrap.Wrap
                        };
                        for (int i = 0; i < data.items.Length; i++)
                        {
                            Button btn = new Button()
                            {
                                Text = data.items[i].text,
                                BackColor = System.Drawing.Color.WhiteSmoke,
                                ForeColor = System.Drawing.Color.Gray,
                                Size = new System.Drawing.Size(0, 0),
                                Padding = new Padding(8),
                                BorderRadius = 4,
                                Margin = new Margin(0, 4, 4, 4)
                            };
                            btn.Press += this.SelectButtonPress;
                            p2.Controls.Add(btn);
                        }

                        disPanel.Controls.Add(p2);
                    }
                    else
                    {
                        for (int i = 0; i < data.items.Length; i++)
                        {
                            Panel tem = new Panel()
                            {
                                Border = new Border(0, 0, 0, 1),
                                BorderColor = System.Drawing.Color.Silver,
                                Layout = LayoutPosition.Relative,
                                Margin = new Margin(33, 0, 18, 6),
                                Size = new System.Drawing.Size(0, 0),
                                Touchable = true
                            };
                            tem.Controls.Add(new Label()
                            {
                                Text = data.items[i].text,
                                ForeColor = System.Drawing.Color.Gray,
                                FontSize = 15,
                                Margin=new Margin(0,4,0,0),
                                Size = new System.Drawing.Size(0, 0)
                            });
                            tem.Controls.Add(new Label()
                            {
                                Text = data.items[i].subtext,
                                ForeColor = System.Drawing.Color.Gray,
                                FontSize = 13,
                                Size = new System.Drawing.Size(0, 0),
                                Margin = new Margin(0, 4, 0, 4),
                            }); 
                            disPanel.Controls.Add(tem);
                        }
                    }

                }

            }
        }


        private void DeleteButtonPress(object sender, EventArgs e)
        {
            hisPanel.Controls.Clear();
        }
        private void RefreshButtonPress(object sender, EventArgs e)
        {
            //重新获取
        }


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
            Panel panel = (Panel)sender;
            this.ShowResult = ShowResult.Yes;
            currentkey = panel.Tag.ToString();
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
    }
}