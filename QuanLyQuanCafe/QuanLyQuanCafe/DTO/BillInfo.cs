using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
   public class BillInfo
    {

        public BillInfo(int id, int billID, int foodID, int count)
       {
           this.ID = id;
           this.BillID = billID;
           this.FoodID = foodID;
           this.Count = count;
       }
       public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.BillID = (int)row ["idbill"];
            this.FoodID = (int)row["idfood"];
            this.Count = (int)row["count"];
        }

        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
       
       private int FoodID;

        public int FoodID1
        {
            get { return FoodID; }
            set { FoodID = value; }
        }

       private int billID;

        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }
 
       private int ID;

        public int ID1
        {
            get { return ID; }
            set { ID = value; }
        }
    }
}
