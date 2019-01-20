using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null)instance = new BillDAO(); return BillDAO.instance; }
            set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        //Hàm thành công sẽ trả về Bill ID, thất bại sẽ là -1
        public int GetUnCheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE idTable = "+ id +"  AND status=0");
            if(data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public void CheckOut(int id) //Hàm thanh toán
        {
            string query = "UPDATE Bill SET status =1 WHERE id =" +id;
            DataProvider.Instance.ExecuteNonQuery(query);

        }
        public void InserBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBill", new object[]{id});
                
        }
        public int GetMaxIDBill()
        {
            try 
            { 
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM Bill");
            }
            catch
             {
                   return -1;
             }
            
        }

    }
}
