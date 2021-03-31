using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace BlogsCode_SmobilerForm.MyForm
{
    partial class meiyou : Smobiler.Core.Controls.MobileForm
    {
        public meiyou() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void meiyou_Load(object sender, EventArgs e)
        {
            DataTable gridTable = new DataTable();
            gridTable.Columns.Add("Name1");
            gridTable.Columns.Add("Name2");
            gridTable.Columns.Add("Name3");
            gridTable.Columns.Add("imageName");
            gridTable.Rows.Add("小暖知识谈", "16小时前","“XXX,XXXXXXXXXXx”","3");
            gridTable.Rows.Add("小暖知识谈", "两天前", "“XXXXXXXXXXXXXXXXXXXXXXXxX,XXXXXXXxxx”", "3");
            gridTable.Rows.Add("小暖知识谈", "两天前", "“XXXXXXXXXXXXXXXXXXXXXXXxX,XXXXXXXxxx”", "3");
            gridView1.Cells.Clear();     //清除数据
            if (gridTable.Rows.Count > 0)    //绑定数据源
            {
                gridView1.DataSource = gridTable;
                gridView1.DataBind();
            }

        }
    }
}