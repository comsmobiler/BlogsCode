using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace BlogsCode_SmobilerForm
{
    partial class SmobilerForm3 : Smobiler.Core.Controls.MobileForm
    {
        public SmobilerForm3()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void btnClose_Press(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCloseToForm1_Press(object sender, EventArgs e)
        {
            //在关闭时设置当前ShowResult为Yes，在SmobilerForm2判断并触发关闭
            this.ShowResult = Smobiler.Core.Controls.ShowResult.Yes;
            this.Close();
        }
    }
}