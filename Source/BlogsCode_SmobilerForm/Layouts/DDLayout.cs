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
    partial class DDLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public DDLayout() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public DDLayout(List<SelectData> selectDatas, string defalutStr) : base()
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

            //添加搜索历史
            for (int i = 0; i < selectDatas[0].items.Length; i++)
            {
                Panel panel = new Panel()
                {
                    Size = new System.Drawing.Size(0, 0),
                    Layout = LayoutPosition.Relative,
                    Direction = LayoutDirection.Row,
                    Touchable = true,
                    ItemAlign= LayoutItemAlign.Center,
                    Tag= selectDatas[0].items[i],
                    Padding=new Padding(12,0,12,0)
                };
                panel.Press += this.HistoryPanelPress;
                FontIcon fontIcon = new FontIcon()
                {
                    Size = new System.Drawing.Size(15, 15),
                    ResourceID = "md-time",
                    ForeColor = System.Drawing.Color.Gainsboro
                };
                Label label = new Label()
                {
                    Text = selectDatas[0].items[i],
                    Flex=1,
                    FontSize=14,
                    Margin=new Margin(6,0,6,0)
                };
                ImageButton imageButton = new ImageButton
                {
                    Size = new System.Drawing.Size(25,25),
                    ImageType = ImageEx.ImageStyle.FontIcon,
                    ResourceID = "md-close",
                    IconColor = System.Drawing.Color.Gainsboro,
                };
                imageButton.Press += this.HistoryDeleteButtonPress;
                panel.Controls.AddRange(new MobileControl[] { fontIcon,label,imageButton });
                hisPanel.Controls.Add(panel);
            }

            //添加热门搜索
            for (int j=1;j<selectDatas.Count;j++)
            {
                SelectData data = selectDatas[j];
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
                for (int i = 0; i < data.items.Length; i++)
                {
                    if (i < 5)
                    {
                        Panel tem = new Panel()
                        {
                            Size = new System.Drawing.Size(0, 0),
                            Layout = LayoutPosition.Relative,
                            Direction = LayoutDirection.Row,
                            Touchable = true,
                            Padding = new Padding(12,6,12,6),
                            BackColor = System.Drawing.Color.WhiteSmoke,
                            Margin = new Margin(0, 4, 8, 4),
                            BorderRadius = 16
                        };
                        tem.Controls.Add(new FontIcon()
                        {
                            ForeColor = System.Drawing.Color.OrangeRed,
                            ResourceID = "md-flame",
                            Size = new System.Drawing.Size(15, 0),
                            Margin=new Margin(0,0,4,0)
                        });
                        tem.Controls.Add(new Label()
                        {
                            Text = data.items[i],
                            ForeColor = System.Drawing.Color.Gray,
                            Size = new System.Drawing.Size(0, 0)
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
                            Padding = new Padding(12,6,12,6),
                            BorderRadius = 16,
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
        /// <summary>
        /// 历史记录行项点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HistoryPanelPress(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            this.ShowResult = ShowResult.Yes;
            currentkey = panel.Tag.ToString();
            //将查询关键字替换进去
            querystr = @"SELECT * FROM `testdata` where data like '%"+currentkey+"%'";
            this.Close();
        }
        /// <summary>
        /// 历史记录行项删除按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HistoryDeleteButtonPress(object sender, EventArgs e)
        {
            ImageButton  btn = (ImageButton)sender;
            hisPanel.Controls.Remove(btn.Parent);
        }

        /// <summary>
        /// 热门搜索按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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