using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class DataProvider
    {
        private static DataProvider instance; // Ctrl+R+E

        public static DataProvider Instance
        {
            get {if(instance==null) instance=new DataProvider();return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider(){}
        private string connstr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter dt = new SqlDataAdapter(cmd);              
                dt.Fill(data);
                conn.Close();
            }

            return data;
            
        }
        public DataTable ExecuteQuery(string query,SqlParameter[] parameters)
        {
          DataTable data = new DataTable();
          using (SqlConnection conn = new SqlConnection(connstr))
          {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(parameters);
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            dt.Fill(data);
            conn.Close();
          }

          return data;

        }

        internal object ExecuteScalar(string p)
        {
          using (SqlConnection conn = new SqlConnection(connstr))
          {
            conn.Open();
            SqlCommand cmd = new SqlCommand(p, conn);
            var rs=cmd.ExecuteScalar();
            conn.Close();
            return rs;
          }
        }

        internal void ExecuteNonQuery(string storeName, object[] p2)
        {
          using (SqlConnection conn = new SqlConnection(connstr))
          {
            conn.Open();
            //var query="exec "+ storeName + " ";
            var query = storeName + " ";
            query = AddParms(query, p2);
            SqlCommand cmd = new SqlCommand(query, conn);
            for (int i = 0; i < p2.Length;i++ )
            {
              var p = new SqlParameter(){ParameterName = "@p"+i,Value = p2[i]};
              cmd.Parameters.Add(p);
            }
            cmd.ExecuteNonQuery();
            conn.Close();
          }
        }
      private string AddParms(string query,object[] parms)
      {
        var sparm = string.Empty;
        for (int i=0;i<parms.Length;i++)
        {
          sparm += "@p" + i + ",";
        }
        if (!string.IsNullOrEmpty(sparm))
          sparm = sparm.Substring(0, sparm.Length - 1);
        return query + sparm;
      }
        internal int ExecuteNonQuery(string query)
        {
          using (SqlConnection conn = new SqlConnection(connstr))
          {
            try
            {
              conn.Open();
              SqlCommand cmd = new SqlCommand(query, conn);
              return cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
              return 0;
            }finally
            {
              conn.Close();
            }

          }
        }
    }
}
