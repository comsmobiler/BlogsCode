﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlogsCode_SmobilerForm.MyForm;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace BlogsCode_SmobilerForm
{
    partial class demoMyForm : Smobiler.Core.Controls.MobileForm
    {
        public demoMyForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void demoMyForm_Load(object sender, EventArgs e)
        {
            ListMenuViewGroup lg = new ListMenuViewGroup();
            lg.AddItem("logon", "个人主页-美柚", "", "");
            lg.AddItem("logon", "个人主页-知乎", "", "");
            lg.AddItem("logon", "个人主页-脉脉", "", "");
            lg.AddItem("logon", "个人主页-得到", "", "");
            listMenuView1.Groups.Add(lg);

        }

        private void listMenuView1_ItemPress(object sender, ListMenuViewItemPressEventArgs e)
        {
            switch (e.Item.Content)
            {
                case "个人主页-美柚":
                    this.Show(new meiyou());
                    break;
                case "个人主页-知乎":
                    this.Show(new zhihu());
                    break;
                case "个人主页-脉脉":
                    this.Show(new momo());
                    break;
                case "个人主页-得到":
                    this.Show(new dedao());
                    break;
            }
        }
    }
}