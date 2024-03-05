namespace FastFoodStore
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            tsThongTinCaNhan = new ToolStripMenuItem();
            tsDoiMatKhau = new ToolStripMenuItem();
            tsDangXuat = new ToolStripMenuItem();
            label1 = new Label();
            btnQuanLyLoai = new Button();
            btnQuanLySanPham = new Button();
            btnThongKeHoaDon = new Button();
            btnThongKeDoanhThu = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(481, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsThongTinCaNhan, tsDoiMatKhau, tsDangXuat });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // tsThongTinCaNhan
            // 
            tsThongTinCaNhan.Name = "tsThongTinCaNhan";
            tsThongTinCaNhan.Size = new Size(180, 22);
            tsThongTinCaNhan.Text = "Thông tin cá nhân";
            tsThongTinCaNhan.Click += tsThongTinCaNhan_Click;
            // 
            // tsDoiMatKhau
            // 
            tsDoiMatKhau.Name = "tsDoiMatKhau";
            tsDoiMatKhau.Size = new Size(180, 22);
            tsDoiMatKhau.Text = "Đổi mật khẩu";
            tsDoiMatKhau.Click += tsDoiMatKhau_Click;
            // 
            // tsDangXuat
            // 
            tsDangXuat.Name = "tsDangXuat";
            tsDangXuat.Size = new Size(180, 22);
            tsDangXuat.Text = "Đăng xuất";
            tsDangXuat.Click += tsDangXuat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(158, 33);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 3;
            label1.Text = "XUNHIU Admin";
            // 
            // btnQuanLyLoai
            // 
            btnQuanLyLoai.BackColor = Color.FromArgb(255, 255, 128);
            btnQuanLyLoai.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuanLyLoai.Location = new Point(50, 221);
            btnQuanLyLoai.Name = "btnQuanLyLoai";
            btnQuanLyLoai.Size = new Size(144, 32);
            btnQuanLyLoai.TabIndex = 0;
            btnQuanLyLoai.Text = "Quản lý Loại";
            btnQuanLyLoai.UseVisualStyleBackColor = false;
            btnQuanLyLoai.Click += btnQuanLyLoai_Click;
            // 
            // btnQuanLySanPham
            // 
            btnQuanLySanPham.BackColor = Color.FromArgb(255, 128, 128);
            btnQuanLySanPham.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuanLySanPham.Location = new Point(284, 221);
            btnQuanLySanPham.Name = "btnQuanLySanPham";
            btnQuanLySanPham.Size = new Size(144, 32);
            btnQuanLySanPham.TabIndex = 2;
            btnQuanLySanPham.Text = "Quản lý sản phẩm";
            btnQuanLySanPham.UseVisualStyleBackColor = false;
            btnQuanLySanPham.Click += btnQuanLySanPham_Click;
            // 
            // btnThongKeHoaDon
            // 
            btnThongKeHoaDon.BackColor = Color.FromArgb(128, 255, 255);
            btnThongKeHoaDon.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThongKeHoaDon.Location = new Point(50, 408);
            btnThongKeHoaDon.Name = "btnThongKeHoaDon";
            btnThongKeHoaDon.Size = new Size(144, 32);
            btnThongKeHoaDon.TabIndex = 1;
            btnThongKeHoaDon.Text = "Thống kê hóa đơn";
            btnThongKeHoaDon.UseVisualStyleBackColor = false;
            btnThongKeHoaDon.Click += btnThongKeHoaDon_Click;
            // 
            // btnThongKeDoanhThu
            // 
            btnThongKeDoanhThu.BackColor = Color.FromArgb(255, 192, 128);
            btnThongKeDoanhThu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThongKeDoanhThu.Location = new Point(284, 408);
            btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            btnThongKeDoanhThu.Size = new Size(144, 32);
            btnThongKeDoanhThu.TabIndex = 3;
            btnThongKeDoanhThu.Text = "Thống kê doanh thu";
            btnThongKeDoanhThu.UseVisualStyleBackColor = false;
            btnThongKeDoanhThu.Click += btnThongKeDoanhThu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(284, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(50, 81);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(144, 143);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(50, 266);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(144, 143);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(284, 266);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(144, 143);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 473);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnThongKeDoanhThu);
            Controls.Add(btnThongKeHoaDon);
            Controls.Add(btnQuanLySanPham);
            Controls.Add(btnQuanLyLoai);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XUNHIU Admin";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem tsThongTinCaNhan;
        private ToolStripMenuItem tsDoiMatKhau;
        private Button btnQuanLyLoai;
        private ToolStripMenuItem tsDangXuat;
        private Button btnQuanLySanPham;
        private Button btnThongKeHoaDon;
        private Button btnThongKeDoanhThu;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}