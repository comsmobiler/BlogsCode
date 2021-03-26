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
    partial class MYLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public MYLayout() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public MYLayout(List<SelectData> selectDatas, string defalutStr) : base()
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
        private void GethHistory(List<SelectData> selectDatas, string defaultstr)
        {
            this.KeyLab.Text = defaultstr;
            for (int j = 0; j < selectDatas.Count; j++)
            {
                SelectData data = selectDatas[j];

                if (data.ishow == true)
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
                    //刷新按钮
                    ImageButton imgbtn = new ImageButton()
                    {
                        ImageType = ImageEx.ImageStyle.FontIcon,
                        ResourceID = "ios-refresh",
                        IconColor = System.Drawing.Color.Silver,
                        Size = new System.Drawing.Size(60, 25),
                        ImageDirection = Smobiler.Core.Controls.Direction.Left,
                        ImgTextRatio = new Ratio(3, 7),
                        ForeColor = System.Drawing.Color.Silver,
                        Text = "换一换"
                    };
                    imgbtn.Press += this.RefreshButtonPress;
                    p1.Controls.Add(imgbtn);
                    hisPanel.Controls.Add(p1);
                    for (int i = 0; i < data.items.Length; i += 2)
                    {
                        Panel p2 = new Panel()
                        {
                            Layout = LayoutPosition.Relative,
                            Direction = LayoutDirection.Row,
                            Size = new System.Drawing.Size(0, 35),
                            Border = new Border(0, 0, 0, 1),
                            BorderColor = System.Drawing.Color.WhiteSmoke,
                            ItemAlign= LayoutItemAlign.Center

                        };
                        Button btn = new Button()
                        {
                            Text = data.items[i],
                            Border = new Border(0, 0, 1, 0),
                            BorderColor = System.Drawing.Color.WhiteSmoke,
                            Bold = true,
                            BorderRadius = 0,
                            BackColor = System.Drawing.Color.Transparent,
                            ForeColor = System.Drawing.Color.Gray,
                            Flex = 1,
                            HorizontalAlignment = HorizontalAlignment.Left,
                            Padding = new Padding(12, 8, 12, 8),
                            Margin = new Margin(0, 4, 4, 4),
                            Size = new System.Drawing.Size(0, 20)
                        };
                        Button btn1 = new Button()
                        {
                            Text = data.items[i + 1],
                            Border = new Border(0, 0, 0, 0),
                            BorderColor = System.Drawing.Color.WhiteSmoke,
                            Bold = true,
                            BorderRadius = 0,
                            BackColor = System.Drawing.Color.Transparent,
                            ForeColor = System.Drawing.Color.Gray,
                            Flex = 1,
                            HorizontalAlignment = HorizontalAlignment.Left,
                            Padding = new Padding(12, 8, 12, 8),
                            Margin = new Margin(0, 4, 0, 4),
                            Size = new System.Drawing.Size(0, 20)
                        };
                        btn.Press += this.SelectButtonPress;
                        btn1.Press += this.SelectButtonPress;
                        p2.Controls.Add(btn);
                        p2.Controls.Add(btn1); hisPanel.Controls.Add(p2);
                    }
                }
                else
                {
                    for (int i = 0; i < data.items.Length; i++)
                    {
                        Button btn = new Button()
                        {
                            Text = data.items[i],
                            BackColor = System.Drawing.Color.Transparent,
                            Border = new Border(1),
                            BorderColor = System.Drawing.Color.WhiteSmoke,
                            ForeColor = System.Drawing.Color.Gray,
                            Size = new System.Drawing.Size(0, 0),
                            Padding = new Padding(12,4,12,4),
                            BorderRadius = 4,
                            Margin = new Margin(0, 8, 8, 8)
                        };
                        btn.Press += this.SelectButtonPress;
                        switch (data.title)
                        {
                            case "经期健康":
                                tabPageControl1.Controls.Add(btn);
                                break;
                            case "两性知识":
                                break;
                            case "妇科护理":
                                break;
                            case "娱乐八卦":
                                break;
                        }
                    }
                }

            }
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