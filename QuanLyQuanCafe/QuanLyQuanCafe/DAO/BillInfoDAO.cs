﻿using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null)instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            set { BillInfoDAO.instance = value; }
        }
        private BillInfoDAO() { }

        public List<BillInfo> GetListBillInfo (int id)
        {
            List<BillInfo> ListBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BillInfo WHERE idBill = " +id);
            foreach(DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);

                ListBillInfo.Add(info);
            }
            return ListBillInfo;
        }
         public void InserBillInfo(int idBill, int idFood, int count)
         {
               DataProvider.Instance.ExecuteNonQuery("USP_InsertBillinfo",new object[]{idBill, idFood,count});
         }

        
    }
}
