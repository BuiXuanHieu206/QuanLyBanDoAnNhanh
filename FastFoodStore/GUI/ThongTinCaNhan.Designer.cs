namespace FastFoodStore.GUI
{
    partial class ThongTinCaNhan
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
            label5 = new Label();
            label6 = new Label();
            btnTroVe = new Button();
            txtHoTen = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtQuyen = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(107, 36);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 91);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 1;
            label2.Text = "Họ tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 129);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 1;
            label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(32, 171);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 1;
            label4.Text = "SĐT:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(32, 246);
            label5.Name = "label5";
            label5.Size = new Size(64, 21);
            label5.TabIndex = 1;
            label5.Text = "Quyền:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(32, 212);
            label6.Name = "label6";
            label6.Size = new Size(57, 21);
            label6.TabIndex = 1;
            label6.Text = "Email:";
            // 
            // btnTroVe
            // 
            btnTroVe.BackColor = Color.FromArgb(255, 128, 0);
            btnTroVe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTroVe.Location = new Point(158, 305);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(86, 28);
            btnTroVe.TabIndex = 28;
            btnTroVe.Text = "Trở về";
            btnTroVe.UseVisualStyleBackColor = false;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(105, 91);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ReadOnly = true;
            txtHoTen.Size = new Size(245, 23);
            txtHoTen.TabIndex = 29;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(105, 129);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ReadOnly = true;
            txtDiaChi.Size = new Size(245, 23);
            txtDiaChi.TabIndex = 29;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(105, 169);
            txtSDT.Name = "txtSDT";
            txtSDT.ReadOnly = true;
            txtSDT.Size = new Size(245, 23);
            txtSDT.TabIndex = 29;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(105, 210);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(245, 23);
            txtEmail.TabIndex = 29;
            // 
            // txtQuyen
            // 
            txtQuyen.Location = new Point(105, 248);
            txtQuyen.Name = "txtQuyen";
            txtQuyen.ReadOnly = true;
            txtQuyen.Size = new Size(245, 23);
            txtQuyen.TabIndex = 29;
            // 
            // ThongTinCaNhan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 359);
            Controls.Add(txtQuyen);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtDiaChi);
            Controls.Add(txtHoTen);
            Controls.Add(btnTroVe);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThongTinCaNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnTroVe;
        private TextBox txtHoTen;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtQuyen;
    }
}