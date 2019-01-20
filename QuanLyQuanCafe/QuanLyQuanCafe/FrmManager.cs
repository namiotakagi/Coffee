using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
    public partial class FrmManager : Form
    {
        public FrmManager()
        {
            InitializeComponent();
            LoadListFood();
            AddFoodBinding();
            LoadCategoryIntoCombobox(cobFoodcategory);
            LoadListCategory();
            AddCategoryBinding();

        }
        void LoadListFood()
        {
            dtgvFood.DataSource = FoodDAO.Instance.GetListFood();
        }
        void AddFoodBinding()
        {
            txtFoodid.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID",true, DataSourceUpdateMode.Never));
            txtFoodname.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name",true, DataSourceUpdateMode.Never));
            numFoodprice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price",true, DataSourceUpdateMode.Never));

        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        private void txtFoodid_TextChanged(object sender, EventArgs e)
        {
            if (dtgvFood.SelectedCells.Count > 0)
            {
                int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                Category category = CategoryDAO.Instance.GetCategoryByID(id);

                cobFoodcategory.SelectedItem = category;
                int index = -1;
                int i = 0;
                foreach (Category item in cobFoodcategory.Items)
                {
                    if (item.ID == category.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cobFoodcategory.SelectedIndex = index;
            }
        }
        void LoadListCategory()
        {
            dtgvCategory.DataSource= CategoryDAO.Instance.GetListCategory();
        }
        void AddCategoryBinding()
        {
            txtCategoryid.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "ID"));
            txtCategoryname.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Name"));
        }

        private void btnAddfood_Click(object sender, EventArgs e)
        {
            string name = txtFoodname.Text;
            int categoryID = (cobFoodcategory.SelectedItem as Category).ID;
            float price = (float)numFoodprice.Value;
            if(FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm thành công");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Đã có lỗi, Chưa thêm được!");
            }
        }
        

        private void btnDelfood_Click(object sender, EventArgs e)
        {
            int idf = Convert.ToInt32(txtFoodid.Text);

            if (FoodDAO.Instance.DeleteFood(idf))
            {
                MessageBox.Show("Xóa thành công");
                LoadListFood();
                txtFoodid.Text = "";
                txtFoodname.Text = "";
            }
            else
            {
                MessageBox.Show("Chưa Xóa được!");
            }
        }

        private void button2_Click(object sender, EventArgs e) //Sửa Food (btnEditFood)
        {
             
            string name = txtFoodname.Text;
            int categoryID = (cobFoodcategory.SelectedItem as Category).ID;
            float price = (float)numFoodprice.Value;
            int id = Convert.ToInt32(txtFoodid.Text);
            if (FoodDAO.Instance.UpdateFood(id,name,categoryID,price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Đã có lỗi, Chưa sửa được!");
            }
        
        }
        //private void btnAddcategory_Click(object sender, EventArgs e)
      
        private void btnAddcategory_Click_1(object sender, EventArgs e)
        {

             string name = txtCategoryname.Text;
             int idCategory = Convert.ToInt32(txtCategoryid.Text);

             if (CategoryDAO.Instance.InsertFoodCategory(idCategory,name))
               {
                  MessageBox.Show("Thêm thành công");
                  LoadListCategory();
              }
               else
               {
                  MessageBox.Show("Chưa thêm được!");
               }           
        }

        private void btnModifycategory_Click(object sender, EventArgs e)
        {             
             
            string name = txtCategoryname.Text;
            int id = Convert.ToInt32(txtCategoryid.Text);
            if(CategoryDAO.Instance.UpdateFoodCategory(id,name))
            {
                MessageBox.Show("Sửa danh mục thành công");
                LoadListCategory();
            }
            else
            {
                MessageBox.Show("Đã có lỗi, Chưa sửa được!");
            }
        }

        private void btnDelcategory_Click(object sender, EventArgs e)
        {
               
            int id = Convert.ToInt32(txtCategoryid.Text);

            if (CategoryDAO.Instance.DeleteFoodCategory(id))
            {
                MessageBox.Show("Xóa thành công");
                LoadListCategory();
            }
            else
            {
                MessageBox.Show("Chưa Xóa được!");
            }
        }        
    }

}