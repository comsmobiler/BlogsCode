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
    partial class ElmLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public ElmLayout() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public ElmLayout(List<SelectData> selectDatas, string defalutStr) : base()
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
            foreach (SelectData data in selectDatas)
            {
                Label label1 = new Label()
                {
                    Text = data.title,
                    Flex = 1,
                    FontSize = 15,
                    Size = new System.Drawing.Size(0, 25),
                    Bold=true,
                    ForeColor=System.Drawing.Color.Gray
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
                {   //添加删除按钮
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
                        Button btn = new Button()
                        {
                            Text = data.items[i],
                            BackColor = System.Drawing.Color.WhiteSmoke,
                            ForeColor = System.Drawing.Color.Gray,
                            Size = new System.Drawing.Size(0, 0),
                            Padding = new Padding(12,8,12,8),
                            BorderRadius = 4,
                            Margin = new Margin(0, 4, 12, 4)
                        };
                        btn.Press += this.SelectButtonPress;
                        p2.Controls.Add(btn);
                    }
                    hisPanel.Controls.Add(p1);
                    hisPanel.Controls.Add(p2);
                }
                else
                {
                    Button spbtn = new Button()
                    {
                        Text = data.items[0],
                        BackColor = System.Drawing.Color.AliceBlue,
                        ForeColor = System.Drawing.Color.DeepSkyBlue,
                        Size = new System.Drawing.Size(0, 0),
                        Padding = new Padding(12,8,12,8),
                        BorderRadius = 4,
                        Margin = new Margin(0,4, 12, 4)
                    };
                    spbtn.Press += this.SelectButtonPress;
                    p2.Controls.Add(spbtn);

                    for (int i = 1; i < data.items.Length; i++)
                    {
                        Button btn = new Button()
                        {
                            Text = data.items[i],
                            BackColor = System.Drawing.Color.WhiteSmoke,
                            ForeColor = System.Drawing.Color.Gray,
                            Size = new System.Drawing.Size(0, 0),
                            Padding = new Padding(12,8,12,8),
                            BorderRadius = 4,
                            Margin = new Margin(0, 4, 12, 4)
                        };
                        btn.Press += this.SelectButtonPress;
                        p2.Controls.Add(btn);
                    }
                    disPanel.Controls.Add(p1);
                    disPanel.Controls.Add(p2);
                }

            }
        }


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
            querystr = @"SELECT * FROM `testdata` where data like '%" + KeyLab.Text+ "%'";
            this.Close();
        }

        private void imageButton1_Press(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.No;
            this.Close();
        }
    }
}