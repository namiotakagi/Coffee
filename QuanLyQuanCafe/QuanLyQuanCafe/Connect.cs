using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyQuanCafe
{
    class Connect
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        String strconnect = "Data Source=VINHTOAN-PC;Integrated Security=True";
        void connect()
        {
            con = new SqlConnection(strconnect);
        }
    }
   
}
