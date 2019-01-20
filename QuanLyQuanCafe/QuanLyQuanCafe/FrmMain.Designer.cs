using System.Windows.Forms;
namespace QuanLyQuanCafe
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Hethong = new System.Windows.Forms.ToolStripMenuItem();
            this.Quantri = new System.Windows.Forms.ToolStripMenuItem();
            this.Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.Taikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.Thongtintaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.Dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nmFoodcount = new System.Windows.Forms.NumericUpDown();
            this.cobFood = new System.Windows.Forms.ComboBox();
            this.cobCategory = new System.Windows.Forms.ComboBox();
            this.btnAddfood = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.txtTotalprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodcount)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Hethong,
            this.Taikhoan,
            this.hỗTrợToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Hethong
            // 
            this.Hethong.BackColor = System.Drawing.Color.White;
            this.Hethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Quantri,
            this.Thoat});
            this.Hethong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hethong.ForeColor = System.Drawing.Color.Navy;
            this.Hethong.Image = global::QuanLyQuanCafe.Properties.Resources.System_icon;
            this.Hethong.Name = "Hethong";
            this.Hethong.Size = new System.Drawing.Size(105, 25);
            this.Hethong.Text = "Hệ Thống";
            this.Hethong.Click += new System.EventHandler(this.Hethong_Click);
            // 
            // Quantri
            // 
            this.Quantri.BackColor = System.Drawing.Color.White;
            this.Quantri.ForeColor = System.Drawing.Color.Red;
            this.Quantri.Name = "Quantri";
            this.Quantri.Size = new System.Drawing.Size(137, 26);
            this.Quantri.Text = "Quản trị";
            this.Quantri.Click += new System.EventHandler(this.Quantri_Click);
            // 
            // Thoat
            // 
            this.Thoat.ForeColor = System.Drawing.Color.Red;
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(137, 26);
            this.Thoat.Text = "Thoát ";
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // Taikhoan
            // 
            this.Taikhoan.BackColor = System.Drawing.Color.White;
            this.Taikhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Thongtintaikhoan,
            this.Dangxuat});
            this.Taikhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Taikhoan.ForeColor = System.Drawing.Color.Navy;
            this.Taikhoan.Image = global::QuanLyQuanCafe.Properties.Resources.user_login_icon;
            this.Taikhoan.Name = "Taikhoan";
            this.Taikhoan.Size = new System.Drawing.Size(106, 25);
            this.Taikhoan.Text = "Tài Khoản";
            // 
            // Thongtintaikhoan
            // 
            this.Thongtintaikhoan.ForeColor = System.Drawing.Color.Red;
            this.Thongtintaikhoan.Name = "Thongtintaikhoan";
            this.Thongtintaikhoan.Size = new System.Drawing.Size(214, 26);
            this.Thongtintaikhoan.Text = "Thông tin tài khoản";
            this.Thongtintaikhoan.Click += new System.EventHandler(this.Thongtin_Click);
            // 
            // Dangxuat
            // 
            this.Dangxuat.ForeColor = System.Drawing.Color.Red;
            this.Dangxuat.Name = "Dangxuat";
            this.Dangxuat.Size = new System.Drawing.Size(214, 26);
            this.Dangxuat.Text = "Đăng xuất";
            this.Dangxuat.Click += new System.EventHandler(this.Dangxuat_Click);
            // 
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.hỗTrợToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hỗTrợToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.hỗTrợToolStripMenuItem.Image = global::QuanLyQuanCafe.Properties.Resources.Help;
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.hỗTrợToolStripMenuItem.Text = "Hỗ Trợ";
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(0, 32);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(295, 398);
            this.flpTable.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nmFoodcount);
            this.panel1.Controls.Add(this.cobFood);
            this.panel1.Controls.Add(this.cobCategory);
            this.panel1.Controls.Add(this.btnAddfood);
            this.panel1.Location = new System.Drawing.Point(301, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 55);
            this.panel1.TabIndex = 2;
            // 
            // nmFoodcount
            // 
            this.nmFoodcount.Location = new System.Drawing.Point(348, 17);
            this.nmFoodcount.Name = "nmFoodcount";
            this.nmFoodcount.Size = new System.Drawing.Size(81, 20);
            this.nmFoodcount.TabIndex = 3;
            // 
            // cobFood
            // 
            this.cobFood.FormattingEnabled = true;
            this.cobFood.Location = new System.Drawing.Point(3, 27);
            this.cobFood.Name = "cobFood";
            this.cobFood.Size = new System.Drawing.Size(211, 21);
            this.cobFood.TabIndex = 2;
            this.cobFood.SelectedIndexChanged += new System.EventHandler(this.cobFood_SelectedIndexChanged);
            // 
            // cobCategory
            // 
            this.cobCategory.FormattingEnabled = true;
            this.cobCategory.Location = new System.Drawing.Point(3, 3);
            this.cobCategory.Name = "cobCategory";
            this.cobCategory.Size = new System.Drawing.Size(211, 21);
            this.cobCategory.TabIndex = 1;
            this.cobCategory.SelectedIndexChanged += new System.EventHandler(this.cobCategory_SelectedIndexChanged);
            // 
            // btnAddfood
            // 
            this.btnAddfood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddfood.ForeColor = System.Drawing.Color.Blue;
            this.btnAddfood.Image = global::QuanLyQuanCafe.Properties.Resources.Steak_icon;
            this.btnAddfood.Location = new System.Drawing.Point(229, 3);
            this.btnAddfood.Name = "btnAddfood";
            this.btnAddfood.Size = new System.Drawing.Size(97, 45);
            this.btnAddfood.TabIndex = 0;
            this.btnAddfood.Text = "Thêm Món";
            this.btnAddfood.UseVisualStyleBackColor = true;
            this.btnAddfood.Click += new System.EventHandler(this.btnAddfood_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(301, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 260);
            this.panel2.TabIndex = 3;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.GridLines = true;
            this.lsvBill.Location = new System.Drawing.Point(3, 3);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(558, 250);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.lsvBill_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 229;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 114;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCheckout);
            this.panel3.Controls.Add(this.txtTotalprice);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(301, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 74);
            this.panel3.TabIndex = 4;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCheckout.Location = new System.Drawing.Point(433, 16);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(112, 45);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.Text = "Thanh Toán";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // txtTotalprice
            // 
            this.txtTotalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalprice.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalprice.Location = new System.Drawing.Point(229, 27);
            this.txtTotalprice.Name = "txtTotalprice";
            this.txtTotalprice.ReadOnly = true;
            this.txtTotalprice.Size = new System.Drawing.Size(132, 22);
            this.txtTotalprice.TabIndex = 7;
            this.txtTotalprice.Text = "0";
            this.txtTotalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(126, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tổng Tiền";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 427);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Quán Cafe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodcount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Dangxuat_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                FrmLogin fr = new FrmLogin();//(loginAccount);
                this.Hide();
                //fr.ShowDialog();
                fr.Show();
            }
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Hethong;
        private System.Windows.Forms.ToolStripMenuItem Quantri;
        private System.Windows.Forms.ToolStripMenuItem Thoat;
        private System.Windows.Forms.ToolStripMenuItem Taikhoan;
        private System.Windows.Forms.ToolStripMenuItem Thongtintaikhoan;
        private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Dangxuat;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nmFoodcount;
        private System.Windows.Forms.ComboBox cobFood;
        private System.Windows.Forms.ComboBox cobCategory;
        private System.Windows.Forms.Button btnAddfood;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtTotalprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckout;
    }
}

