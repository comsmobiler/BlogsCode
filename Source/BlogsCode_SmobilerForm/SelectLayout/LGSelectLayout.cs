using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlogsCode_SmobilerForm.SelectForm;
using SelectDemo;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace BlogsCode_SmobilerForm.SelectLayout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class LGSelelctLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public LGSelelctLayout() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        private string pressBtn;
        public LGSelelctLayout(String btnName) : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
            pressBtn = btnName;
        }
        private void imageButton2_Press(object sender, EventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            if (btn.Name == pressBtn)
                this.Close();
        }

        private void button3_Press(object sender, EventArgs e)
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
            ((LGSelectForm1)this.Form).ListBind(querystr);
            this.Close();
        }

        private void LGSelelctLayout_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(pressBtn) == false)
            {
                switch (pressBtn)
                {
                    case "imageButton2":
                        imageButton5.ForeColor = System.Drawing.Color.ForestGreen;
                        break;
                    case "imageButton3":
                        imageButton2.ForeColor = System.Drawing.Color.ForestGreen;
                        break;
                    case "imageButton4":
                        imageButton3.ForeColor = System.Drawing.Color.ForestGreen;
                        break;
                    case "imageButton5":
                        imageButton4.ForeColor = System.Drawing.Color.ForestGreen;
                        break;
                }
            }
        }
        private void button2_Press(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            for (int i = 0; i < mianpanel.Controls.Count; i++)
            {
                //判断是否为panel控件
                if (mianpanel.Controls[i].GetType().Name == "Panel")
                {
                    foreach (Button button in ((Panel)mianpanel.Controls[i]).Controls)
                    {
                        button.ForeColor = button.BorderColor = System.Drawing.Color.Gray;
                        button.Tag = false;
                    }

                }
            }
        }

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
                                keyword = button.Text;
                                string querystr = "( " + panel.Name + " like '%" + keyword + "%'" + " )";
                                queries.Add(new Query() { query = querystr, action = "and" });
                            }
                        }

                    }
                    else
                    {
                        List<Query> temp = new List<Query>();
                        string keyword = "";
                        foreach (Button button in panel.Controls)
                        {
                            if ((bool)button.Tag)
                            {
                                keyword = button.Text;
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


}


