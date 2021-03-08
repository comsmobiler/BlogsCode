using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SelectDemo.Forms;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SelectDemo.Layouts
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class XCListTemplate : Smobiler.Core.Controls.MobileUserControl
    {
        public XCListTemplate() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void panel1_Press(object sender, EventArgs e)
        {
            ((XCLayout)this.Form).KeyWordSearching(label2.Text);
        }
    }
}