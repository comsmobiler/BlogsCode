using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SelectDemo
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class ZRSelectLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public ZRSelectLayout() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        private string pressBtn;
        public ZRSelectLayout(String btnName) : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
            pressBtn = btnName;
        }
        private void ZRSelectLayout_Load(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(pressBtn) == false)
            {
                switch (pressBtn)
                {
                    case "imageButton1":
                        imageButton1.ForeColor = System.Drawing.Color.Orange;
                        break;
                    case "imageButton2":
                        imageButton2.ForeColor = System.Drawing.Color.Orange;
                        break;
                    case "imageButton3":
                        imageButton3.ForeColor = System.Drawing.Color.Orange;
                        break;
                    case "imageButton4":
                        imageButton4.ForeColor = System.Drawing.Color.Orange;
                        break;
                }
            }
        }

        private void imageButton6_Press(object sender, EventArgs e)
        {
            this.Close();
        }
        //筛选分类按钮点击事件
        private void imageButton1_Press(object sender, EventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            if (btn.Name == pressBtn)
                this.Close();
        }
        /// <summary>
        /// 确认按钮事件，在该事件中获取所有选中的筛选条件并传递给form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Press(object sender, EventArgs e)
        {
            string query1 = @"SELECT * FROM `testdata`";
            List<Query> queries = GetQueries(mianpanel);
            string query2 = GetQueryStr(queries);
            string querystr = "";
            if (query2.Length > 0)
            {
                querystr = query1 + "where " + query2;
            }
            else
                querystr = query1;
           ((ZRSelectForm)this.Form).ListBind(querystr);
            this.Close();
        }
        /// <summary>
        /// 重置按钮 点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Press(object sender, EventArgs e)
        {
            for (int j = 0; j < mianpanel.Controls.Count; j++)
            {
                //判断是否为panel控件
                if (mianpanel.Controls[j].GetType().Name == "Panel")
                {
                    
                    foreach (Button button in ((Panel)mianpanel.Controls[j]).Controls)
                    {
                        ((Button)button).ForeColor = System.Drawing.Color.Gray;
                        ((Button)button).BorderColor = System.Drawing.Color.Gray;
                        ((Button)button).Tag = false;
                    }

                }
            }
        }
        /// <summary>
        /// 得到筛选语句，实际操作可以另写方法
        /// </summary>
        /// <param name="panels"></param>
        /// <returns></returns>
        private List<Query> GetQueries(Panel panels)
        {
            List<Query> queries = new List<Query>();
            for (int j = 0; j < panels.Controls.Count; j++)
            {
                //判断是否为panel控件
                if (panels.Controls[j].GetType().Name == "Panel")
                {
                    Panel panel = (Panel)panels.Controls[j];
                    //判断是否为单选项
                    if ((bool)panel.Tag)
                    {
                        string keyword = "";
                        foreach (Button button in panel.Controls)
                        {
                            if ((bool)button.Tag)
                            {
                                keyword = button.Text;//获取选中按钮的文本
                                string querystr = "( " + panel.Name + " like '%" + keyword + "%'" + " )";//组查询语句
                                queries.Add(new Query() { query = querystr, action = "and" });
                            }
                        }

                    }
                    else
                    {   //多选按钮 查询语句组合
                        List<Query> temp = new List<Query>();
                        string keyword = "";
                        foreach (Button button in panel.Controls)
                        {
                            if ((bool)button.Tag)
                            {
                                keyword = button.Text;//获取选中按钮的文本
                                string querystr = panel.Name + " like '%" + keyword + "%'";
                                temp.Add(new Query() { query = querystr, action = "or" });
                            }
                        }
                        string keyword1 = GetQueryStr(temp);
                        if (!string.IsNullOrEmpty(keyword1))
                            queries.Add(new Query() { query = keyword1, action = "add" });
                    }
                }
            }

            return queries;
        }

        private string GetQueryStr(List<Query> queries)
        {
            string result = "";
            if (queries.Count > 0)
            {
                result = "( ";
                for (int i = 0; i < queries.Count; i++)
                {
                    Query query = queries[i];
                    if (i < queries.Count - 1)
                        result += query.query + " " + query.action + " ";
                    else result += query.query;
                }
                result += " )";
            }
            return result;
        }

        
    }
    class Query
    {
        public string query { set; get; }
        public string action { set; get; }
    }
}