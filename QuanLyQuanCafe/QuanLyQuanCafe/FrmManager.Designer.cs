namespace QuanLyQuanCafe
{
    partial class FrmManager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tapBill = new System.Windows.Forms.TabPage();
            this.dtBillto = new System.Windows.Forms.DateTimePicker();
            this.btnViewbill = new System.Windows.Forms.Button();
            this.dtbBillfrom = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.tapFood = new System.Windows.Forms.TabPage();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numFoodprice = new System.Windows.Forms.NumericUpDown();
            this.cobFoodcategory = new System.Windows.Forms.ComboBox();
            this.txtFoodname = new System.Windows.Forms.TextBox();
            this.txtFoodid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelfood = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.btnAddfood = new System.Windows.Forms.Button();
            this.btnModifyfood = new System.Windows.Forms.Panel();
            this.tapCategory = new System.Windows.Forms.TabPage();
            this.btnModifycategory = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCategoryname = new System.Windows.Forms.TextBox();
            this.txtCategoryid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelcategory = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.btnAddcategory = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tapTable = new System.Windows.Forms.TabPage();
            this.btnModifytable = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.btnDeltable = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cobTablestatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTablename = new System.Windows.Forms.TextBox();
            this.txtTableid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddtable = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tapAcount = new System.Windows.Forms.TabPage();
            this.btnModifyacount = new System.Windows.Forms.Button();
            this.btnDelaccount = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.btnAddacount = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cobTypeaccount = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtViewaccount = new System.Windows.Forms.TextBox();
            this.txtAccountname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tapBill.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.tapFood.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFoodprice)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.tapCategory.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.tapTable.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.panel7.SuspendLayout();
            this.tapAcount.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tapBill);
            this.tabControl1.Controls.Add(this.tapFood);
            this.tabControl1.Controls.Add(this.tapCategory);
            this.tabControl1.Controls.Add(this.tapTable);
            this.tabControl1.Controls.Add(this.tapAcount);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(734, 375);
            this.tabControl1.TabIndex = 0;
            // 
            // tapBill
            // 
            this.tapBill.Controls.Add(this.dtBillto);
            this.tapBill.Controls.Add(this.btnViewbill);
            this.tapBill.Controls.Add(this.dtbBillfrom);
            this.tapBill.Controls.Add(this.panel3);
            this.tapBill.Location = new System.Drawing.Point(4, 25);
            this.tapBill.Name = "tapBill";
            this.tapBill.Padding = new System.Windows.Forms.Padding(3);
            this.tapBill.Size = new System.Drawing.Size(726, 346);
            this.tapBill.TabIndex = 0;
            this.tapBill.Text = "Doanh Thu";
            this.tapBill.UseVisualStyleBackColor = true;
            // 
            // dtBillto
            // 
            this.dtBillto.Location = new System.Drawing.Point(339, 32);
            this.dtBillto.Name = "dtBillto";
            this.dtBillto.Size = new System.Drawing.Size(142, 22);
            this.dtBillto.TabIndex = 3;
            // 
            // btnViewbill
            // 
            this.btnViewbill.Location = new System.Drawing.Point(233, 29);
            this.btnViewbill.Name = "btnViewbill";
            this.btnViewbill.Size = new System.Drawing.Size(75, 23);
            this.btnViewbill.TabIndex = 2;
            this.btnViewbill.Text = "Thống Kê";
            this.btnViewbill.UseVisualStyleBackColor = true;
            // 
            // dtbBillfrom
            // 
            this.dtbBillfrom.Location = new System.Drawing.Point(61, 32);
            this.dtbBillfrom.Name = "dtbBillfrom";
            this.dtbBillfrom.Size = new System.Drawing.Size(142, 22);
            this.dtbBillfrom.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvBill);
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(726, 284);
            this.panel3.TabIndex = 0;
            // 
            // dtgvBill
            // 
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(0, 2);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.Size = new System.Drawing.Size(720, 282);
            this.dtgvBill.TabIndex = 0;
            // 
            // tapFood
            // 
            this.tapFood.Controls.Add(this.btnEditFood);
            this.tapFood.Controls.Add(this.panel1);
            this.tapFood.Controls.Add(this.btnDelfood);
            this.tapFood.Controls.Add(this.panel2);
            this.tapFood.Controls.Add(this.btnAddfood);
            this.tapFood.Controls.Add(this.btnModifyfood);
            this.tapFood.Location = new System.Drawing.Point(4, 25);
            this.tapFood.Name = "tapFood";
            this.tapFood.Padding = new System.Windows.Forms.Padding(3);
            this.tapFood.Size = new System.Drawing.Size(726, 346);
            this.tapFood.TabIndex = 1;
            this.tapFood.Text = "Thức Ăn";
            this.tapFood.UseVisualStyleBackColor = true;
            // 
            // btnEditFood
            // 
            this.btnEditFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFood.ForeColor = System.Drawing.Color.Blue;
            this.btnEditFood.Location = new System.Drawing.Point(156, 235);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(75, 26);
            this.btnEditFood.TabIndex = 4;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numFoodprice);
            this.panel1.Controls.Add(this.cobFoodcategory);
            this.panel1.Controls.Add(this.txtFoodname);
            this.panel1.Controls.Add(this.txtFoodid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 180);
            this.panel1.TabIndex = 2;
            // 
            // numFoodprice
            // 
            this.numFoodprice.Location = new System.Drawing.Point(77, 143);
            this.numFoodprice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numFoodprice.Name = "numFoodprice";
            this.numFoodprice.Size = new System.Drawing.Size(137, 22);
            this.numFoodprice.TabIndex = 7;
            // 
            // cobFoodcategory
            // 
            this.cobFoodcategory.FormattingEnabled = true;
            this.cobFoodcategory.Location = new System.Drawing.Point(77, 106);
            this.cobFoodcategory.Name = "cobFoodcategory";
            this.cobFoodcategory.Size = new System.Drawing.Size(137, 24);
            this.cobFoodcategory.TabIndex = 6;
            // 
            // txtFoodname
            // 
            this.txtFoodname.Location = new System.Drawing.Point(77, 68);
            this.txtFoodname.Name = "txtFoodname";
            this.txtFoodname.Size = new System.Drawing.Size(137, 22);
            this.txtFoodname.TabIndex = 5;
            // 
            // txtFoodid
            // 
            this.txtFoodid.Location = new System.Drawing.Point(77, 28);
            this.txtFoodid.Name = "txtFoodid";
            this.txtFoodid.Size = new System.Drawing.Size(137, 22);
            this.txtFoodid.TabIndex = 4;
            this.txtFoodid.TextChanged += new System.EventHandler(this.txtFoodid_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh Mục:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Món:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // btnDelfood
            // 
            this.btnDelfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelfood.ForeColor = System.Drawing.Color.Blue;
            this.btnDelfood.Location = new System.Drawing.Point(89, 235);
            this.btnDelfood.Name = "btnDelfood";
            this.btnDelfood.Size = new System.Drawing.Size(61, 26);
            this.btnDelfood.TabIndex = 3;
            this.btnDelfood.Text = "Xóa";
            this.btnDelfood.UseVisualStyleBackColor = true;
            this.btnDelfood.Click += new System.EventHandler(this.btnDelfood_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvFood);
            this.panel2.Location = new System.Drawing.Point(237, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 315);
            this.panel2.TabIndex = 1;
            // 
            // dtgvFood
            // 
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(-8, 4);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.Size = new System.Drawing.Size(501, 312);
            this.dtgvFood.TabIndex = 0;
            // 
            // btnAddfood
            // 
            this.btnAddfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddfood.ForeColor = System.Drawing.Color.Blue;
            this.btnAddfood.Location = new System.Drawing.Point(10, 235);
            this.btnAddfood.Name = "btnAddfood";
            this.btnAddfood.Size = new System.Drawing.Size(64, 26);
            this.btnAddfood.TabIndex = 2;
            this.btnAddfood.Text = "Thêm";
            this.btnAddfood.UseVisualStyleBackColor = true;
            this.btnAddfood.Click += new System.EventHandler(this.btnAddfood_Click);
            // 
            // btnModifyfood
            // 
            this.btnModifyfood.Location = new System.Drawing.Point(0, 0);
            this.btnModifyfood.Name = "btnModifyfood";
            this.btnModifyfood.Size = new System.Drawing.Size(720, 21);
            this.btnModifyfood.TabIndex = 0;
            // 
            // tapCategory
            // 
            this.tapCategory.Controls.Add(this.btnModifycategory);
            this.tapCategory.Controls.Add(this.panel4);
            this.tapCategory.Controls.Add(this.btnDelcategory);
            this.tapCategory.Controls.Add(this.panel5);
            this.tapCategory.Controls.Add(this.btnAddcategory);
            this.tapCategory.Controls.Add(this.panel6);
            this.tapCategory.Location = new System.Drawing.Point(4, 25);
            this.tapCategory.Name = "tapCategory";
            this.tapCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tapCategory.Size = new System.Drawing.Size(726, 346);
            this.tapCategory.TabIndex = 2;
            this.tapCategory.Text = "Danh Mục";
            this.tapCategory.UseVisualStyleBackColor = true;
            // 
            // btnModifycategory
            // 
            this.btnModifycategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifycategory.ForeColor = System.Drawing.Color.Blue;
            this.btnModifycategory.Location = new System.Drawing.Point(144, 180);
            this.btnModifycategory.Name = "btnModifycategory";
            this.btnModifycategory.Size = new System.Drawing.Size(67, 26);
            this.btnModifycategory.TabIndex = 4;
            this.btnModifycategory.Text = "Sửa";
            this.btnModifycategory.UseVisualStyleBackColor = true;
            this.btnModifycategory.Click += new System.EventHandler(this.btnModifycategory_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtCategoryname);
            this.panel4.Controls.Add(this.txtCategoryid);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(3, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 131);
            this.panel4.TabIndex = 5;
            // 
            // txtCategoryname
            // 
            this.txtCategoryname.Location = new System.Drawing.Point(84, 70);
            this.txtCategoryname.Name = "txtCategoryname";
            this.txtCategoryname.Size = new System.Drawing.Size(124, 22);
            this.txtCategoryname.TabIndex = 5;
            // 
            // txtCategoryid
            // 
            this.txtCategoryid.Location = new System.Drawing.Point(84, 30);
            this.txtCategoryid.Name = "txtCategoryid";
            this.txtCategoryid.Size = new System.Drawing.Size(124, 22);
            this.txtCategoryid.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên DM:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID:";
            // 
            // btnDelcategory
            // 
            this.btnDelcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelcategory.ForeColor = System.Drawing.Color.Blue;
            this.btnDelcategory.Location = new System.Drawing.Point(74, 180);
            this.btnDelcategory.Name = "btnDelcategory";
            this.btnDelcategory.Size = new System.Drawing.Size(62, 26);
            this.btnDelcategory.TabIndex = 3;
            this.btnDelcategory.Text = "Xóa";
            this.btnDelcategory.UseVisualStyleBackColor = true;
            this.btnDelcategory.Click += new System.EventHandler(this.btnDelcategory_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgvCategory);
            this.panel5.Location = new System.Drawing.Point(230, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(490, 311);
            this.panel5.TabIndex = 4;
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Location = new System.Drawing.Point(3, 6);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.Size = new System.Drawing.Size(505, 308);
            this.dtgvCategory.TabIndex = 0;
            // 
            // btnAddcategory
            // 
            this.btnAddcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddcategory.ForeColor = System.Drawing.Color.Blue;
            this.btnAddcategory.Location = new System.Drawing.Point(6, 180);
            this.btnAddcategory.Name = "btnAddcategory";
            this.btnAddcategory.Size = new System.Drawing.Size(64, 26);
            this.btnAddcategory.TabIndex = 2;
            this.btnAddcategory.Text = "Thêm";
            this.btnAddcategory.UseVisualStyleBackColor = true;
            this.btnAddcategory.Click += new System.EventHandler(this.btnAddcategory_Click_1);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(726, 23);
            this.panel6.TabIndex = 3;
            // 
            // tapTable
            // 
            this.tapTable.Controls.Add(this.btnModifytable);
            this.tapTable.Controls.Add(this.panel9);
            this.tapTable.Controls.Add(this.btnDeltable);
            this.tapTable.Controls.Add(this.panel7);
            this.tapTable.Controls.Add(this.btnAddtable);
            this.tapTable.Controls.Add(this.panel8);
            this.tapTable.Location = new System.Drawing.Point(4, 25);
            this.tapTable.Name = "tapTable";
            this.tapTable.Padding = new System.Windows.Forms.Padding(3);
            this.tapTable.Size = new System.Drawing.Size(726, 346);
            this.tapTable.TabIndex = 3;
            this.tapTable.Text = "Bàn Ăn";
            this.tapTable.UseVisualStyleBackColor = true;
            // 
            // btnModifytable
            // 
            this.btnModifytable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifytable.ForeColor = System.Drawing.Color.Blue;
            this.btnModifytable.Location = new System.Drawing.Point(143, 209);
            this.btnModifytable.Name = "btnModifytable";
            this.btnModifytable.Size = new System.Drawing.Size(66, 26);
            this.btnModifytable.TabIndex = 4;
            this.btnModifytable.Text = "Sửa";
            this.btnModifytable.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dtgvTable);
            this.panel9.Location = new System.Drawing.Point(227, 34);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(493, 309);
            this.panel9.TabIndex = 8;
            // 
            // dtgvTable
            // 
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Location = new System.Drawing.Point(3, 2);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.Size = new System.Drawing.Size(487, 306);
            this.dtgvTable.TabIndex = 0;
            // 
            // btnDeltable
            // 
            this.btnDeltable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeltable.ForeColor = System.Drawing.Color.Blue;
            this.btnDeltable.Location = new System.Drawing.Point(74, 209);
            this.btnDeltable.Name = "btnDeltable";
            this.btnDeltable.Size = new System.Drawing.Size(63, 26);
            this.btnDeltable.TabIndex = 3;
            this.btnDeltable.Text = "Xóa";
            this.btnDeltable.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cobTablestatus);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.txtTablename);
            this.panel7.Controls.Add(this.txtTableid);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(5, 34);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(216, 161);
            this.panel7.TabIndex = 7;
            // 
            // cobTablestatus
            // 
            this.cobTablestatus.FormattingEnabled = true;
            this.cobTablestatus.Location = new System.Drawing.Point(83, 109);
            this.cobTablestatus.Name = "cobTablestatus";
            this.cobTablestatus.Size = new System.Drawing.Size(116, 24);
            this.cobTablestatus.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(1, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Trạng Thái:";
            // 
            // txtTablename
            // 
            this.txtTablename.Location = new System.Drawing.Point(84, 65);
            this.txtTablename.Name = "txtTablename";
            this.txtTablename.Size = new System.Drawing.Size(116, 22);
            this.txtTablename.TabIndex = 5;
            // 
            // txtTableid
            // 
            this.txtTableid.Location = new System.Drawing.Point(84, 24);
            this.txtTableid.Name = "txtTableid";
            this.txtTableid.Size = new System.Drawing.Size(116, 22);
            this.txtTableid.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên Bàn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID:";
            // 
            // btnAddtable
            // 
            this.btnAddtable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtable.ForeColor = System.Drawing.Color.Blue;
            this.btnAddtable.Location = new System.Drawing.Point(5, 209);
            this.btnAddtable.Name = "btnAddtable";
            this.btnAddtable.Size = new System.Drawing.Size(63, 26);
            this.btnAddtable.TabIndex = 2;
            this.btnAddtable.Text = "Thêm";
            this.btnAddtable.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(2, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(724, 22);
            this.panel8.TabIndex = 6;
            // 
            // tapAcount
            // 
            this.tapAcount.Controls.Add(this.btnModifyacount);
            this.tapAcount.Controls.Add(this.btnDelaccount);
            this.tapAcount.Controls.Add(this.panel12);
            this.tapAcount.Controls.Add(this.btnAddacount);
            this.tapAcount.Controls.Add(this.panel10);
            this.tapAcount.Controls.Add(this.panel11);
            this.tapAcount.Location = new System.Drawing.Point(4, 25);
            this.tapAcount.Name = "tapAcount";
            this.tapAcount.Padding = new System.Windows.Forms.Padding(3);
            this.tapAcount.Size = new System.Drawing.Size(726, 346);
            this.tapAcount.TabIndex = 4;
            this.tapAcount.Text = "Tài Khoản";
            this.tapAcount.UseVisualStyleBackColor = true;
            // 
            // btnModifyacount
            // 
            this.btnModifyacount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyacount.ForeColor = System.Drawing.Color.Blue;
            this.btnModifyacount.Location = new System.Drawing.Point(157, 218);
            this.btnModifyacount.Name = "btnModifyacount";
            this.btnModifyacount.Size = new System.Drawing.Size(74, 26);
            this.btnModifyacount.TabIndex = 4;
            this.btnModifyacount.Text = "Sửa";
            this.btnModifyacount.UseVisualStyleBackColor = true;
            // 
            // btnDelaccount
            // 
            this.btnDelaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelaccount.ForeColor = System.Drawing.Color.Blue;
            this.btnDelaccount.Location = new System.Drawing.Point(81, 218);
            this.btnDelaccount.Name = "btnDelaccount";
            this.btnDelaccount.Size = new System.Drawing.Size(68, 26);
            this.btnDelaccount.TabIndex = 3;
            this.btnDelaccount.Text = "Xóa";
            this.btnDelaccount.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.dtgvAccount);
            this.panel12.Location = new System.Drawing.Point(250, 38);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(470, 249);
            this.panel12.TabIndex = 10;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(6, 3);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.Size = new System.Drawing.Size(464, 246);
            this.dtgvAccount.TabIndex = 0;
            // 
            // btnAddacount
            // 
            this.btnAddacount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddacount.ForeColor = System.Drawing.Color.Blue;
            this.btnAddacount.Location = new System.Drawing.Point(12, 218);
            this.btnAddacount.Name = "btnAddacount";
            this.btnAddacount.Size = new System.Drawing.Size(63, 26);
            this.btnAddacount.TabIndex = 2;
            this.btnAddacount.Text = "Thêm";
            this.btnAddacount.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cobTypeaccount);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Controls.Add(this.txtViewaccount);
            this.panel10.Controls.Add(this.txtAccountname);
            this.panel10.Controls.Add(this.label11);
            this.panel10.Controls.Add(this.label12);
            this.panel10.Location = new System.Drawing.Point(5, 48);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(239, 154);
            this.panel10.TabIndex = 9;
            // 
            // cobTypeaccount
            // 
            this.cobTypeaccount.FormattingEnabled = true;
            this.cobTypeaccount.Location = new System.Drawing.Point(110, 104);
            this.cobTypeaccount.Name = "cobTypeaccount";
            this.cobTypeaccount.Size = new System.Drawing.Size(116, 24);
            this.cobTypeaccount.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(3, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "Loại Tài Khoản:";
            // 
            // txtViewaccount
            // 
            this.txtViewaccount.Location = new System.Drawing.Point(110, 64);
            this.txtViewaccount.Name = "txtViewaccount";
            this.txtViewaccount.Size = new System.Drawing.Size(116, 22);
            this.txtViewaccount.TabIndex = 5;
            // 
            // txtAccountname
            // 
            this.txtAccountname.Location = new System.Drawing.Point(110, 26);
            this.txtAccountname.Name = "txtAccountname";
            this.txtAccountname.ReadOnly = true;
            this.txtAccountname.Size = new System.Drawing.Size(116, 22);
            this.txtAccountname.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(3, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tên Hiển Thị:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(3, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên Tài Khoản:";
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(2, 6);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(718, 26);
            this.panel11.TabIndex = 8;
            // 
            // FrmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 383);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManager";
            this.tabControl1.ResumeLayout(false);
            this.tapBill.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.tapFood.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFoodprice)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.tapCategory.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.tapTable.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tapAcount.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tapBill;
        private System.Windows.Forms.DateTimePicker dtBillto;
        private System.Windows.Forms.Button btnViewbill;
        private System.Windows.Forms.DateTimePicker dtbBillfrom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.TabPage tapFood;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numFoodprice;
        private System.Windows.Forms.ComboBox cobFoodcategory;
        private System.Windows.Forms.TextBox txtFoodname;
        private System.Windows.Forms.TextBox txtFoodid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel btnModifyfood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDelfood;
        private System.Windows.Forms.Button btnAddfood;
        private System.Windows.Forms.TabPage tapCategory;
        private System.Windows.Forms.TabPage tapTable;
        private System.Windows.Forms.TabPage tapAcount;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCategoryname;
        private System.Windows.Forms.TextBox txtCategoryid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtgvCategory;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnModifycategory;
        private System.Windows.Forms.Button btnDelcategory;
        private System.Windows.Forms.Button btnAddcategory;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dtgvTable;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cobTablestatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTablename;
        private System.Windows.Forms.TextBox txtTableid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnModifytable;
        private System.Windows.Forms.Button btnDeltable;
        private System.Windows.Forms.Button btnAddtable;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cobTypeaccount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtViewaccount;
        private System.Windows.Forms.TextBox txtAccountname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnModifyacount;
        private System.Windows.Forms.Button btnDelaccount;
        private System.Windows.Forms.Button btnAddacount;
    }
}