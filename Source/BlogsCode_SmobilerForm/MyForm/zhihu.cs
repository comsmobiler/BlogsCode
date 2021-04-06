using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace BlogsCode_SmobilerForm.MyForm
{
    partial class zhihu : Smobiler.Core.Controls.MobileForm
    {
        public zhihu() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void imageButton1_Press(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zhihu2_Load(object sender, EventArgs e)
        {
            DataTable gridTable = new DataTable();
            gridTable.Columns.Add("Name1");
            gridTable.Columns.Add("Name2");
            gridTable.Columns.Add("Name3");
            gridTable.Columns.Add("Name4");
            gridTable.Columns.Add("Name5");
            gridTable.Columns.Add("Name6");
            gridTable.Columns.Add("Name7");
            gridTable.Columns.Add("imageName");
            gridTable.Rows.Add("之乎者也", "回答了问答", "两天前", "曾今沧海难为水，除却巫山不是云。真的有吗？爱而不得，该怎么办？", "终有弱水替沧海，再把相思寄巫山爱而不得，那就不是你的，不挣扎，不强求，问心无愧就好", "1", "评论", "");
            gridTable.Rows.Add("之乎者也", "收藏了问答", "两天前", "有什么是适合情侣间做的事情?", "苏陌:“我和我男友恋爱那段时间，我们俩天天晚.上打电话，晚上睡觉都不舍得挂掉电话，每天都是听着对...", "78", "30", "logon");
            gridTable.Rows.Add("之乎者也", "回答了问答", "两天前", "曾今沧海难为水，除却巫山不是云。真的有吗？爱而不得，该怎么办？", "终有弱水替沧海，再把相思寄巫山爱而不得，那就不是你的，不挣扎，不强求，问心无愧就好", "1", "评论", "");
            gridTable.Rows.Add("之乎者也", "收藏了问答", "两天前", "有什么是适合情侣间做的事情?", "苏陌:“我和我男友恋爱那段时间，我们俩天天晚.上打电话，晚上睡觉都不舍得挂掉电话，每天都是听着对...", "78", "30", "logon");
            gridView1.Cells.Clear();     //清除数据
            if (gridTable.Rows.Count > 0)    //绑定数据源
            {
                gridView1.DataSource = gridTable;
                gridView1.DataBind();
            }
        }
     
    }
}