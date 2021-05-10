using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace BlogsCode_SmobilerForm.MyForm 
{
    partial class dedao : Smobiler.Core.Controls.MobileForm
    {
        public dedao() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void imageButton1_Press(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dedao2_Load(object sender, EventArgs e)
        {
            DataTable gridTable = new DataTable();
            gridTable.Columns.Add("imageName1");
            gridTable.Columns.Add("Name1");
            gridTable.Columns.Add("Name2");
            gridTable.Columns.Add("Name3");
            gridTable.Columns.Add("imageName2");
            gridTable.Columns.Add("repost");
            gridTable.Columns.Add("comment");
            gridTable.Columns.Add("like");
            gridTable.Rows.Add("4.jpg", "阿房宫赋", "19小时前", "六王毕，四海一。蜀山兀，阿房出。覆压三百余里,隔离天日。骊山北构而西折，直走咸阳。二川溶溶，流入宫墙。五步一楼，十步一阁;廊腰馒回，檐牙高啄;各抱地势，钩心斗角。盘盘焉，困困焉，蜂房水涡，矗不知其几千万落。长桥卧波，未云何龙?复道行空，不霁何虹?", "", "9", "17", "34");
            gridTable.Rows.Add("5.jpg", "水龙吟·次韵章质夫杨花词", "19小时前", "似花还似非花，也无人惜从教坠。抛家傍路，思量却是，无情有思。萦损柔肠，困酣娇眼，欲开还闭。梦随风万里，寻郎去处，又还被、莺呼起。不恨此花飞尽，恨西园、落红难缀。晓来雨过，遗踪何在?一池萍碎。春色三分，二分尘土，一分流水。", "6.jpg", "9", "17", "34");
            gridView1.Cells.Clear();     //清除数据
            if (gridTable.Rows.Count > 0)    //绑定数据源
            {
                gridView1.DataSource = gridTable;
                gridView1.DataBind();
            }
        }
    }
}