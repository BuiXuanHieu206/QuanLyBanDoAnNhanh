namespace FastFoodStore
{
    partial class DangNhap
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTenDN = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnDangKy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(139, 9);
            label1.Name = "label1";
            label1.Size = new Size(315, 25);
            label1.TabIndex = 2;
            label1.Text = "XUNHIU Fast Food Store";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(139, 77);
            label2.Name = "label2";
            label2.Size = new Size(181, 37);
            label2.TabIndex = 3;
            label2.Text = "ĐĂNG NHẬP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 135);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 4;
            label3.Text = "Tên đăng nhập:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 177);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 4;
            label4.Text = "Mật khẩu:";
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(177, 135);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(255, 23);
            txtTenDN.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(177, 179);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(255, 23);
            txtMatKhau.TabIndex = 2;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(255, 128, 128);
            btnDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangNhap.Location = new Point(110, 237);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(105, 37);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(255, 128, 0);
            btnDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangKy.Location = new Point(243, 237);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(105, 37);
            btnDangKy.TabIndex = 4;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 307);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDangKy);
            Controls.Add(btnDangNhap);
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XUNHIU Store";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTenDN;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private Button btnDangKy;
    }
}