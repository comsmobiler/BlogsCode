using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace BlogsCode_SmobilerForm
{
    partial class InitForm : Smobiler.Core.Controls.MobileForm
    {
        public InitForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void InitForm_Load(object sender, EventArgs e)
        {
            ListMenuViewGroup lg = new ListMenuViewGroup();
            lg.AddItem("logon", "窗体跳转","","");
            lg.AddItem("logon", "搜索界面设计", "", "");
            listMenuView1.Groups.Add(lg);

        }

        private void listMenuView1_ItemPress(object sender, ListMenuViewItemPressEventArgs e)
        {
            switch (e.Item.Content)
            {
                case "窗体跳转":
                    this.Show(new SmobilerForm1());
                    break;
                case "搜索界面设计":
                    this.Show(new democontrols());
                    break;
            }
        }
    }
}