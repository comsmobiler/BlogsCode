using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace BlogsCode_SmobilerForm
{
    partial class SmobilerForm2 : Smobiler.Core.Controls.MobileForm
    {
        public SmobilerForm2()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void btnShowForm3_Press(object sender, EventArgs e)
        {
            //这里会在回调方法来处理两种情况，一种是Form3关闭后，回到Form2，还有一种情况是Form3关闭后同时关闭Form2，直接回到Form1
            this.Show(new SmobilerForm3(), (obj, args) => {
                if (obj.ShowResult == Smobiler.Core.Controls.ShowResult.Yes)
                {
                    //这里代表，如果SmobilerForm3关闭时，把ShowResult设置为Yes，那么就同时关闭当前界面，这样就直接回到Form1了
                    this.Close();
                }
                else
                {
                    Toast("SmobilerForm3关闭并回到SmobilerForm2"); 
                }
            });
        }

        private void btnClose_Press(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}