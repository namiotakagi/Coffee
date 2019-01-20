using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
  public class AccountDAO
  {
    private static AccountDAO instance;
    private DataRow item;

    public static AccountDAO Instance
    {
      get { if (instance == null) instance = new AccountDAO(); return instance; }
      private set { instance = value; }
    }
    private AccountDAO() { }

    public AccountDAO(DataRow item)
    {
      // TODO: Complete member initialization
      this.item = item;
    }

    public bool Login(string Username, string Password)
    {
      string query = "select * from Account where UserName=@username and Password=@password";
      var parameters = new SqlParameter[2];
      parameters[0] = new SqlParameter() { ParameterName = "@username", Value = Username };
      parameters[1] = new SqlParameter() { ParameterName = "@password", Value = Password };
      DataTable result = DataProvider.Instance.ExecuteQuery(query, parameters);
      return result.Rows.Count > 0;
    }
    public AccountDAO GetAccountbyUserName(string userName)
    {
      DataTable data = DataProvider.Instance.ExecuteQuery("select * from Account where UserName = '" + userName+"'");
      foreach (DataRow item in data.Rows)
      {
        return new AccountDAO(item);
      }
      return null;
    }
        SqlConnection con = new SqlConnection(@"Data Source=VINHTOAN-PC;Integrated Security=True");




  }

}
