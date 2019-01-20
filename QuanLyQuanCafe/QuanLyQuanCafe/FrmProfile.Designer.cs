namespace QuanLyQuanCafe
{
    partial class FrmProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginname = new System.Windows.Forms.TextBox();
            this.txtDisplayname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassname = new System.Windows.Forms.TextBox();
            this.btnExitprofile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hiển thị";
            // 
            // txtLoginname
            // 
            this.txtLoginname.Location = new System.Drawing.Point(124, 27);
            this.txtLoginname.Name = "txtLoginname";
            this.txtLoginname.ReadOnly = true;
            this.txtLoginname.Size = new System.Drawing.Size(152, 20);
            this.txtLoginname.TabIndex = 2;
            // 
            // txtDisplayname
            // 
            this.txtDisplayname.Location = new System.Drawing.Point(124, 57);
            this.txtDisplayname.Name = "txtDisplayname";
            this.txtDisplayname.ReadOnly = true;
            this.txtDisplayname.Size = new System.Drawing.Size(152, 20);
            this.txtDisplayname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(26, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu";
            // 
            // txtPassname
            // 
            this.txtPassname.Location = new System.Drawing.Point(124, 92);
            this.txtPassname.Name = "txtPassname";
            this.txtPassname.PasswordChar = '*';
            this.txtPassname.ReadOnly = true;
            this.txtPassname.Size = new System.Drawing.Size(152, 20);
            this.txtPassname.TabIndex = 5;
            // 
            // btnExitprofile
            // 
            this.btnExitprofile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExitprofile.Location = new System.Drawing.Point(141, 118);
            this.btnExitprofile.Name = "btnExitprofile";
            this.btnExitprofile.Size = new System.Drawing.Size(75, 23);
            this.btnExitprofile.TabIndex = 6;
            this.btnExitprofile.Text = "Thoát";
            this.btnExitprofile.UseVisualStyleBackColor = true;
            // 
            // FrmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExitprofile;
            this.ClientSize = new System.Drawing.Size(337, 145);
            this.Controls.Add(this.btnExitprofile);
            this.Controls.Add(this.txtPassname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDisplayname);
            this.Controls.Add(this.txtLoginname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginname;
        private System.Windows.Forms.TextBox txtDisplayname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassname;
        private System.Windows.Forms.Button btnExitprofile;
    }
}