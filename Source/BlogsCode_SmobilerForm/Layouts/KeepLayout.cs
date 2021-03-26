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
    partial class KeepLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public KeepLayout() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public KeepLayout(List<SelectData> selectDatas, string defalutStr) : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
            GethHistory(selectDatas, defalutStr);
        }
        private void panel2_Press(object sender, EventArgs e)
        {

        }



        private void CloseDialog_Press(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.No;
            this.Close();

        }
        private void GethHistory(List<SelectData> selectDatas, string defaultstr)
        {
            this.KeyLab.Text = defaultstr;
            foreach (SelectData data in selectDatas)
            {
                Label label1 = new Label()
                {
                    Text = data.title,
                    Flex = 1,
                    FontSize = 15,
                    Size=new System.Drawing.Size(0,25),
                    Bold=true
                };

                Panel p1 = new Panel()
                {  
                    Layout = LayoutPosition.Relative,
                    Direction = LayoutDirection.Row,
                    Size = new System.Drawing.Size(0, 0),
                    Padding = new Padding(12,0, 12, 0)
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
                {   //添加清除记录按钮
                    ImageButton imgbtn = new ImageButton()
                    {
                        ImageType = ImageEx.ImageStyle.FontIcon,
                        ResourceID = "trash-o",
                        IconColor = System.Drawing.Color.Silver,
                        Size = new System.Drawing.Size(65, 25),
                        ForeColor = System.Drawing.Color.Silver,
                        Text="清除记录",
                        ImageDirection= Smobiler.Core.Controls.Direction.Left,
                        ImgTextRatio=new Ratio(2,8),
                        FontSize=13
                    };
                    imgbtn.Press += this.DeleteButtonPress;
                    p1.Controls.Add(imgbtn);

                    for (int i = 0; i < data.items.Length; i++)
                    {
                        Button btn = new Button()
                        {
                            Text = data.items[i],
                            BackColor = System.Drawing.Color.WhiteSmoke,
                            ForeColor = System.Drawing.Color.Gray,
                            Size = new System.Drawing.Size(0, 0),
                            Padding = new Padding(8),
                            BorderRadius = 12,
                            Margin = new Margin(0, 4, 4, 4)
                        };
                        btn.Press += this.SelectButtonPress;
                        p2.Controls.Add(btn);
                    }
                    hisPanel.Controls.Add(p1);
                    hisPanel.Controls.Add(p2);
                }
                else
                {
                    for (int i = 0; i < data.items.Length; i++)
                    {
                        if (i < 3)
                        {// 带图标的按钮
                            Panel tem = new Panel()
                            {
                                Size = new System.Drawing.Size(80, 30),
                                Layout = LayoutPosition.Relative,
                                Direction = LayoutDirection.Row,
                                Touchable = true,
                                Padding = new Padding(6),
                                BackColor = System.Drawing.Color.WhiteSmoke,
                                Margin = new Margin(0, 4, 8, 4),
                                BorderRadius = 12
                            };
                            tem.Controls.Add(new FontIcon()
                            {
                                ForeColor = System.Drawing.Color.OrangeRed,
                                ResourceID = "md-flame",
                                Size=new System.Drawing.Size(15,0),
                                Margin=new Margin(0,0,4,0)
                            });
                            tem.Controls.Add(new Label()
                            {
                                Text = data.items[i],
                                ForeColor = System.Drawing.Color.Gray,
                                Size=new System.Drawing.Size(0,0)

                            });
                            tem.Tag = data.items[i];
                            tem.Press += this.SelectPanelPress;
                            p2.Controls.Add(tem);

                        }
                        else
                        {
                            Button btn = new Button()
                            {
                                Text = data.items[i],
                                BackColor = System.Drawing.Color.WhiteSmoke,
                                ForeColor = System.Drawing.Color.Gray,
                                Size = new System.Drawing.Size(0, 0),
                                Padding = new Padding(8),
                                BorderRadius = 12,
                                Margin = new Margin(0, 4, 8, 4)
                            };
                            btn.Press += this.SelectButtonPress;
                            p2.Controls.Add(btn);
                        }
                    }
                    disPanel.Controls.Add(p1);
                    disPanel.Controls.Add(p2);
                }

            }
        }
        public string currentkey;
        public string querystr;

        private void DeleteButtonPress(object sender, EventArgs e)
        {
            hisPanel.Controls.Clear();
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
    }
}