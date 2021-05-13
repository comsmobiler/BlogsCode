using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SelectDemo
{
    class DBClass
    {
        public DataTable DbConnectAndQuert(string query)
        {
           
            String connetStr = "server=127.0.0.1;port=3306;user=****;password=****; database=***;charset=utf8";
            // server=127.0.0.1/localhost 代表本机，端口号port默认是3306可以不写
            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {   
                DataTable dt = new DataTable();
                conn.Open();
                MySqlCommand com = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                adapter.Fill(dt);
                return dt;
               
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
    class Query
    {
        public string query { set; get; }
        public string action { set; get; }
    }
}
