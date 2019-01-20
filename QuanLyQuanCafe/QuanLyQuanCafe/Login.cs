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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtTen.Text;
                string passWord = txtPass.Text;
                if (Login(userName, passWord))
                {
                    //Account  loginAccount = AccountDAO.Instance.GetAccountbyUserName(userName);
                    //FrmMain fr = new FrmMain(loginAccount);
                    FrmMain fr = new FrmMain();

                    this.Hide();
                    fr.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Sai Tên Tài Khoản Hoặc Mật Khẩu", "Thông Báo !");
            }
            catch{}
            
        }

         public bool Login(string Username, string Password)
        {
            return AccountDAO.Instance.Login(Username, Password);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }
    
    }
}
