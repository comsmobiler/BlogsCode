using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace BlogsCode_SmobilerForm
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        public SmobilerForm1()
            : base()
        {
            InitializeComponent();
        }

        private void btnShowForm2_Press(object sender, EventArgs e)
        {
            //Show的第一个参数为打开的窗体，第二个参数是打开的窗体关闭后会触发的委托回调，这个委托可以有多种方式，这是使用的匿名方法的写法，并省略委托和声明
            this.Show(new SmobilerForm2(), (obj, args) => { Toast("SmobilerForm2已关闭并回到SmobilerForm1"); });

            //Show等价写法，这是使用的匿名方法的写法，并声明委托
            //this.Show(new SmobilerForm2(), new FormRedirectCallBackEventHandler((obj, args) => { Toast("SmobilerForm2关闭"); });

            //Show等价写法，这么写也是可以的，这里没有使用匿名方法，而是给定了一个方法
            //this.Show(new SmobilerForm2(), SmobilerForm2ShowCallBack);

            //Show等价写法，这是使用委托的标准写法了，实际上，上面的都是语法糖，最终都是委托和形式，不过了为了编程方便，我一般使用最上面的写法，即使用匿名方法
            //this.Show(new SmobilerForm2(), new FormRedirectCallBackEventHandler(SmobilerForm2ShowCallBack));
        }

        private void SmobilerForm2ShowCallBack(MobileForm form, object args)
        {
            Toast("SmobilerForm2已关闭并回到SmobilerForm1");
        }
    }
}