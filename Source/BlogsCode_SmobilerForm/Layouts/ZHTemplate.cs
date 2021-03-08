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
    partial class ZHTemplate : Smobiler.Core.Controls.MobileUserControl
    {
        public ZHTemplate() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public ZHTemplate(int index,System.Drawing.Color color,SelectItem selectItem) : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
            indexLab.Text = index.ToString();
            indexLab.ForeColor = color;
            textLab.Text = selectItem.text;
            subLab.Text = selectItem.subtext;
        }
        private void panel1_Press(object sender, EventArgs e)
        {
            ((ZHSearch_1)this.Form).SelectButtonPress(textLab.Text);
        }
    }
}