using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class FrmMain : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public FrmMain()
        {
            InitializeComponent();
            //this.LoginAccount = acc;
            LoadTable();
            LoadCategory();
        }
        void ChangeAccount(int type)
        {
            Thongtintaikhoan.Enabled = type == 1;
        }

        void LoadCategory()
        {
            List<Category> listCategory =  CategoryDAO.Instance.GetListCategory();
            cobCategory.DataSource = listCategory;
            cobCategory.DisplayMember = "Name";
           
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listfood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cobFood.DataSource = listfood;
            cobFood.DisplayMember = "Name";
            
        }
        void LoadTable(int currentid = -1)
        {
            flpTable.Controls.Clear();
            List<Table> tablelist = TableDAO.Instance.LoadTableList();
            foreach (Table item in tablelist)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click +=btn_Click;
                btn.Tag = item;
                flpTable.Controls.Add(btn);
                switch (item.Status.ToLower().Trim())
                {
                    case "trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightSteelBlue;
                        break;
                }
            }
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<QuanLyQuanCafe.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float Totalprice = 0;
            foreach(QuanLyQuanCafe.DTO.Menu item in listBillInfo )
            {
                ListViewItem lsvitem = new ListViewItem(item.FoodName.ToString());
                lsvitem.SubItems.Add(item.Count.ToString());
                lsvitem.SubItems.Add(item.Price.ToString());
                lsvitem.SubItems.Add(item.Totalprice.ToString());
                Totalprice += item.Totalprice;
                lsvBill.Items.Add(lsvitem);
           
            }
            txtTotalprice.Text = Totalprice.ToString("c");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int TableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(TableID);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Quantri_Click(object sender, EventArgs e)
        {
            FrmManager f = new FrmManager();
            f.ShowDialog();
        }

        private void Thongtin_Click(object sender, EventArgs e)
        {
            FrmProfile f = new FrmProfile();
            f.ShowDialog();
        }

        private void Hethong_Click(object sender, EventArgs e)
        {

        }

       private void cobFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int id=0;
            //ComboBox cb = sender as ComboBox;
            //if(cb.SelectedItem==null)
            //    return;
            //Category selected = cb.SelectedItem as Category;
            //id = selected.ID;
            //LoadFoodListByCategoryID(id);
       }
        private void cobCategory_SelectedIndexChanged(object sender, EventArgs e) //Thay thế hàm ở trên k chịu chạy
        {
            var idcat = ((Category)cobCategory.SelectedItem).ID;
            LoadFoodListByCategoryID(idcat);
        }

        private void btnAddfood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
          if(table==null)
          {
            MessageBox.Show("Vui long chọn bàn để thêm món.");
            return;
          }
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.ID);
            int foodID = (cobFood.SelectedItem as Food).ID;
            int count = (int)nmFoodcount.Value;
            if(idBill==-1)   //Thêm món cho bàn mới
            {
                BillDAO.Instance.InserBill(table.ID);
                BillInfoDAO.Instance.InserBillInfo(BillDAO.Instance.GetMaxIDBill(),foodID,count);
            }
            else
            {
                BillInfoDAO.Instance.InserBillInfo(idBill, foodID, count); // thêm món cho bàn đã có sẵn
            }

            ShowBill(table.ID);
            LoadTable();
        }

        private void btnCheckout_Click(object sender, EventArgs e) 
        {
            {
                Table table = lsvBill.Tag as Table;
                int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.ID);
                if (idBill != -1)
                {
                    if (MessageBox.Show("Bạn Muốn Thanh Toán Cho Bàn " + table.Name, "Thông Báo!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        BillDAO.Instance.CheckOut(idBill);
                        ShowBill(table.ID);
                        LoadTable();
                    }
                }
            }
        }

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
        
    }
}
