using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SelectDemo
{
    partial class ZRSelectForm : Smobiler.Core.Controls.MobileForm
    {
        public ZRSelectForm() : base()
        {
            InitializeComponent();
        }
        private DBClass dBClass = new DBClass();
        private void imageButton1_Press(object sender, EventArgs e)
        {
            ShowSelectDialog("imageButton1");
        }
        private void ShowSelectDialog(string btnName)
        {
            //筛选项数据
            SelectData d1 = new SelectData()
            {
                title = "房源朝向",
                items = new String[] { "东", "南", "西", "北", "南北" },
                ishow = true,//是否显示按钮边框
                isradio = false,//是否为单选
                type = "type1"//数据项字段名
            };
            SelectData d2 = new SelectData()
            {
                title = "房源特色",
                items = new String[] { "深呼吸", "智能新风", "智能空净", "首次出租", "非首次出租", "智能锁", "有电梯", "离地铁近", "绿化率高", "视频看房", "VR看房" },
                ishow = true,
                isradio = false,
                type = "type2"
            };
            SelectData d3 = new SelectData()
            {
                title = "放源周边",
                items = new String[] { "离地铁近", "绿化率高" },
                ishow = true,
                isradio = true,
                type = "type3"
            };
            SelectData d4 = new SelectData()
            {
                title = "装修风格",
                items = new String[] { "有家2.0", "油价3.0", "油价4.0", "油价5.0" },
                ishow = true,
                isradio = true,
                type = "type4"
            };
            SelectData d5 = new SelectData()
            {
                title = "签约时长",
                items = new String[] { "年租", "短租" },
                ishow = true,
                isradio = true,
                type = "type5"
            };
            SelectData d6 = new SelectData()
            {
                title = "房源状态",
                items = new String[] { "可立即入住", "可预约", "转租" },
                ishow = true,
                isradio = true,
                type = "type6"
            };
            SelectData d7 = new SelectData()
            {
                title = "房源状态",
                items = new String[] { "今天", "11/7", "11/8", "11/9", "11/10", "11/11" },
                ishow = false,
                isradio = false,
                type = "type7"
            };
            List<SelectData> sds = new List<SelectData>();
            sds.Add(d1);
            sds.Add(d2);
            sds.Add(d3);
            sds.Add(d4);
            sds.Add(d5);
            sds.Add(d6);
            sds.Add(d7);
            ZRSelectLayout uc = GetControl(sds, btnName);
            DialogOptions footerDialogOptions;
            footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexStart, System.Drawing.Color.Transparent, Smobiler.Core.Controls.Padding.Empty, true);
            ShowDialog(uc, footerDialogOptions);
        }
        /// <summary>
        /// 往ZRSelectLayout中添加label，按钮
        /// </summary>
        /// <param name="selectDatas"></param>
        /// <param name="btnName"></param>
        /// <returns></returns>
        private ZRSelectLayout GetControl(List<SelectData> selectDatas, string btnName)
        {
            ZRSelectLayout uc = new ZRSelectLayout(btnName);
            foreach (SelectData data in selectDatas)
            {
                Label label1 = new Label() { Text = data.title, Size = new System.Drawing.Size(0, 0), Padding = new Padding(6) };
                Panel p1 = new Panel()
                {
                    Layout = LayoutPosition.Relative,
                    Direction = LayoutDirection.Row,
                    Wrap = LayoutWrap.Wrap,
                    Size = new System.Drawing.Size(0, 0),
                    Padding = new Padding(6),
                    Name= data.type,//Name属性用于标记筛选按钮所属分类
                    Tag=data.isradio
                };
                //循环添加按钮
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
                        Tag = false,//此Tag用于表示按钮是否选中
                        Name = "btn" + i.ToString()
                    };
                    if (data.ishow == false)
                        btn.Border = new Border(0);
                    if (data.isradio == false)
                        btn.Press += this.SelectButtonPress;
                    else
                        btn.Press += this.SelectRadioButtonPress;
                    p1.Controls.Add(btn);
                }
                uc.mianpanel.Controls.Add(label1);
                uc.mianpanel.Controls.Add(p1);
            }
            return uc;
        }
        /// <summary>
        /// 单选按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                ((Button)sender).ForeColor = ((Button)sender).BorderColor = System.Drawing.Color.Orange;
                ((Button)sender).Tag = true;
            }
            else
            {
                ((Button)sender).ForeColor = ((Button)sender).BorderColor = System.Drawing.Color.Gray;
                ((Button)sender).Tag = false;
            }
        }
        /// <summary>
        /// 多选按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectButtonPress(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            // 通过Tag判断button是否被选中
            if ((bool)btn.Tag == false)
            {
                ((Button)sender).ForeColor = ((Button)sender).BorderColor = System.Drawing.Color.Orange;
                ((Button)sender).Tag = true;
            }
            else
            {
                ((Button)sender).ForeColor = ((Button)sender).BorderColor = System.Drawing.Color.Gray;
                ((Button)sender).Tag = false;
            }
        }
        /// <summary>
        /// 查询结果并绑定到listview上
        /// </summary>
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

        private void imageButton6_Press(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}