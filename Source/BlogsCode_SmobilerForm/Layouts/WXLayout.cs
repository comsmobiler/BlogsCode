using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SelectDemo.Layouts
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class WXLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public WXLayout() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }       
        public string currentType;
        public string querystr;
        private DBClass dBClass = new DBClass();
        public WXLayout( string defalutStr) : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
            KeyLab.WaterMarkText = defalutStr;
            currentType = defalutStr;
        }

        private void CloseDialog_Press(object sender, EventArgs e)
        {
            this.Close();
        }
 

        /// <summary>
        /// 搜索框回车键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyLab_SubmitEditing(object sender, EventArgs e)
        {
            //将查询关键字替换进去
            querystr = @"SELECT * FROM `testdata` where data like '%"+KeyLab.Text+"%' and type='"+currentType+"'";
            DataTable dt = dBClass.DbConnectAndQuert(querystr);
            listView1.Rows.Clear();
            listView1.DataSource = dt;
            listView1.DataBind();   

        }
    }
}