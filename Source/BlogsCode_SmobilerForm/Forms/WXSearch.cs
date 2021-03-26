using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using SelectDemo.Layouts;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SelectDemo.Forms
{
    partial class WXSearch : Smobiler.Core.Controls.MobileForm
    {
        public WXSearch() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        private DBClass dBClass=new DBClass();
        
        private void keyLab_SubmitEditing(object sender, EventArgs e)
        {
            // 跳转搜索结果页
        }
        private void button1_Press(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Select_Press(object sender, EventArgs e)
        {
            ShowWXLayout(((Button)sender).Text);
        }
        private void ShowWXLayout(string type)
        {
            WXLayout uc = new WXLayout(type);
            DialogOptions footerDialogOptions;
            footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexStart, System.Drawing.Color.Transparent, Smobiler.Core.Controls.Padding.Empty, true);
            ShowDialog(uc, footerDialogOptions, (obj, args) =>{ });

        }
        /// <summary>
        /// 搜索框文本改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keyLab_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(keyLab.Text))
            {
                keypanel.Visible = true;
                panel3.Visible = false;
            }
            else
            {
                keypanel.Visible = false;
                panel3.Visible = true;
                string querystr =  @"SELECT* FROM `testdata` where data like '%"+keyLab.Text+"%'";
                DataTable dt = dBClass.DbConnectAndQuert(querystr);
                listView1.Rows.Clear();
                listView1.DataSource = dt;
                listView1.DataBind();
            }
        }
    }
}
