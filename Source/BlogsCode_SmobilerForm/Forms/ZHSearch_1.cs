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
    partial class ZHSearch_1 : Smobiler.Core.Controls.MobileForm
    {
        public ZHSearch_1() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public ZHSearch_1(List<SelectDataPro> selectDatas, string defalutStr) : base()
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
            string[] tabtitle = new string[6];
            for (int i = 0; i < selectDatas.Count; i++)
            {
                SelectDataPro data = selectDatas[i];
                tabtitle[i] = data.title;
                Panel panel = new Panel()
                {
                    Direction = LayoutDirection.Row,
                    Flex = 1,
                    Layout = LayoutPosition.Relative,
                    Wrap = LayoutWrap.Wrap,
                    Margin = new Margin(0, 6, 0, 0)
                };
                int itemlength;
                if (data.items != null)
                    itemlength = data.items.Length;
                else
                    itemlength = -1;
                for (int j = 0; j < itemlength; j++)
                {
                    if (j < 3)
                    {
                        ZHTemplate zHTemplate = new ZHTemplate(j + 1, System.Drawing.Color.OrangeRed, data.items[j]);
                        panel.Controls.Add(zHTemplate);
                    }
                    else
                    {
                        ZHTemplate zHTemplate = new ZHTemplate(j + 1, System.Drawing.Color.Silver, data.items[j]);
                        panel.Controls.Add(zHTemplate);
                    }
                }
                if (data.ishow)
                {
                    Button button = new Button()
                    {
                        ForeColor = System.Drawing.Color.CornflowerBlue,
                        FontSize = 15,
                        BackColor = System.Drawing.Color.Transparent,
                        Text = "更多搜索内容 >",
                        Size = new System.Drawing.Size(260, 35)
                    };
                    button.Press += this.MorePress;
                    panel.Controls.Add(button);
                }
                tabPageView1.Controls.Add(panel);

            }
            tabPageView1.Titles = tabtitle;
        }
        public string currentkey;
        public string querystr;

        private void MorePress(object sender, EventArgs e)
        {
            // 跳转更多窗口
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
        public void SelectButtonPress(string keyword)
        {
            this.ShowResult = ShowResult.Yes;
            currentkey = keyword;
            //将查询关键字替换进去
            querystr = @"SELECT * FROM `testdata` where data like '%"+keyword+"%'";
            this.Close();
        }
    }
}