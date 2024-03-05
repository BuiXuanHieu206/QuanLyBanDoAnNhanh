namespace FastFoodStore.GUI
{
    partial class DoiMatKhau
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
            txtMatKhauCu = new TextBox();
            label4 = new Label();
            label2 = new Label();
            btnTroVe = new Button();
            btnDoiMatKhau = new Button();
            label5 = new Label();
            txtMatKhauMoi = new TextBox();
            label6 = new Label();
            txtNhapLaiMatKhau = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 46);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Location = new Point(206, 86);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.PasswordChar = '*';
            txtMatKhauCu.Size = new Size(255, 23);
            txtMatKhauCu.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 84);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 9;
            label4.Text = "Mật khẩu cũ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(129, 28);
            label2.Name = "label2";
            label2.Size = new Size(219, 37);
            label2.TabIndex = 7;
            label2.Text = "ĐỔI MẬT KHẨU";
            // 
            // btnTroVe
            // 
            btnTroVe.BackColor = Color.FromArgb(255, 128, 0);
            btnTroVe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTroVe.Location = new Point(252, 226);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(105, 37);
            btnTroVe.TabIndex = 11;
            btnTroVe.Text = "Trở về";
            btnTroVe.UseVisualStyleBackColor = false;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.BackColor = Color.FromArgb(255, 128, 128);
            btnDoiMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoiMatKhau.Location = new Point(109, 226);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(122, 37);
            btnDoiMatKhau.TabIndex = 8;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = false;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 126);
            label5.Name = "label5";
            label5.Size = new Size(140, 25);
            label5.TabIndex = 9;
            label5.Text = "Mật khẩu mới:";
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(206, 128);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '*';
            txtMatKhauMoi.Size = new Size(255, 23);
            txtMatKhauMoi.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(17, 169);
            label6.Name = "label6";
            label6.Size = new Size(178, 25);
            label6.TabIndex = 9;
            label6.Text = "Nhập lại mật khẩu:";
            // 
            // txtNhapLaiMatKhau
            // 
            txtNhapLaiMatKhau.Location = new Point(206, 171);
            txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            txtNhapLaiMatKhau.PasswordChar = '*';
            txtNhapLaiMatKhau.Size = new Size(255, 23);
            txtNhapLaiMatKhau.TabIndex = 6;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 299);
            Controls.Add(txtNhapLaiMatKhau);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(label6);
            Controls.Add(txtMatKhauCu);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnTroVe);
            Controls.Add(btnDoiMatKhau);
            Controls.Add(label1);
            Name = "DoiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMatKhauCu;
        private Label label4;
        private Label label2;
        private Button btnTroVe;
        private Button btnDoiMatKhau;
        private Label label5;
        private TextBox txtMatKhauMoi;
        private Label label6;
        private TextBox txtNhapLaiMatKhau;
    }
}