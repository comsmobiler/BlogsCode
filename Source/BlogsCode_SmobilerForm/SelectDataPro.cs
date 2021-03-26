using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectDemo
{
    class SelectDataPro
    {
        public String title { set; get; }

        public String subtitle { set; get; }

        public String titleicon { set; get; }

        public SelectItem[] items { set; get; }

        public Boolean ishow { set; get; }

        public int shape { set; get; }

        public DataTable dataTable { set; get; }
        public String type { set; get; }


    }
}
