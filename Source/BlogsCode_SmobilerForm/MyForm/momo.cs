using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace BlogsCode_SmobilerForm.MyForm
{
    partial class momo : Smobiler.Core.Controls.MobileForm
    {
        public momo() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void imageButton1_Press(object sender, EventArgs e)
        {
            this.Close();
        }

        private void momo_Load(object sender, EventArgs e)
        {
            DataTable gridTable1 = new DataTable();
            gridTable1.Columns.Add("lab1");
            gridTable1.Columns.Add("lab2");
            gridTable1.Columns.Add("lab3");
            gridTable1.Columns.Add("lab4");
            gridTable1.Rows.Add("法国里昂大学", "2016年-2018年，语言家，硕士", "主要研究方式：符号学&幼儿心理语言学。受邀为浙江大学120周年校庆官方法语宣......", "");
            gridTable1.Rows.Add("浙江大学", "2012年-2016年，法语，本科", "浙江大学优秀毕业生；国家留学基金委员会（CSC）“国际区域……", "她有125个好友在此学校");
            if (gridTable1.Rows.Count > 0)    //绑定数据源
            {
                gridView1.DataSource = gridTable1;
                gridView1.DataBind();
            }

            DataTable gridTable2 = new DataTable();
            gridTable2.Columns.Add("label1");
            gridTable2.Columns.Add("label2");
            gridTable2.Columns.Add("label3");
            gridTable2.Rows.Add("法语·83", "“大学同学认识，很尽心负责”", "贝贝集团招聘专家应佳键 评论");
            gridTable2.Rows.Add("IT互联网·83", "“大学同学认识，很尽心负责”", "贝贝集团招聘专家应佳键 评论");
            gridTable2.Rows.Add("产品运营·83", "", "");
            if (gridTable2.Rows.Count > 0)    //绑定数据源
            {
                gridView2.DataSource = gridTable2;
                gridView2.DataBind();
            }

            DataTable gridTable3 = new DataTable();
            gridTable3.Columns.Add("image");
            gridTable3.Columns.Add("lab1");
            gridTable3.Columns.Add("lab2");
            gridTable3.Columns.Add("lab3");
            gridTable3.Rows.Add("4", "张凯特", "杭州创业小公司产品经理", "IT互联网·运营/编辑");
            gridTable3.Rows.Add("4", "张凯特", "杭州创业小公司产品经理", "IT互联网·运营/编辑");
            gridTable3.Rows.Add("4", "张凯特", "杭州创业小公司产品经理", "IT互联网·运营/编辑");
            if (gridTable2.Rows.Count > 0)    //绑定数据源
            {
                gridView3.DataSource = gridTable3;
                gridView3.DataBind();
            }

        }
    }
}