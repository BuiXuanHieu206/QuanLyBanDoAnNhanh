namespace FastFoodStore
{
    partial class MenuKhachHang
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuKhachHang));
            label1 = new Label();
            label3 = new Label();
            cbbLoai = new ComboBox();
            dgvSanPham = new DataGridView();
            TenMon = new DataGridViewTextBoxColumn();
            Gia = new DataGridViewTextBoxColumn();
            Anh = new DataGridViewImageColumn();
            dTOSanPhamBindingSource = new BindingSource(components);
            btnMuaHang = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            tsThongTinCaNhan = new ToolStripMenuItem();
            tsDoiMatKhau = new ToolStripMenuItem();
            tsLichSuMuaHang = new ToolStripMenuItem();
            tsDangXuat = new ToolStripMenuItem();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            btnThemVaoGio = new Button();
            btnTBSP = new Button();
            dgvGioHang = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Gia2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewImageColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Sua = new DataGridViewImageColumn();
            Xoa = new DataGridViewImageColumn();
            dTOGioHangBindingSource = new BindingSource(components);
            label2 = new Label();
            txtTongTien = new TextBox();
            label4 = new Label();
            lblHoTen = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTOSanPhamBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTOGioHangBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(485, 24);
            label1.Name = "label1";
            label1.Size = new Size(315, 25);
            label1.TabIndex = 9;
            label1.Text = "XUNHIU Fast Food Store";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 84);
            label3.Name = "label3";
            label3.Size = new Size(165, 21);
            label3.TabIndex = 12;
            label3.Text = "Chọn loại sản phẩm:";
            // 
            // cbbLoai
            // 
            cbbLoai.FormattingEnabled = true;
            cbbLoai.Location = new Point(196, 84);
            cbbLoai.Name = "cbbLoai";
            cbbLoai.Size = new Size(148, 23);
            cbbLoai.TabIndex = 13;
            cbbLoai.SelectedIndexChanged += cbbLoai_SelectedIndexChanged;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToDeleteRows = false;
            dgvSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.BackgroundColor = Color.FromArgb(255, 255, 192);
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { TenMon, Gia, Anh });
            dgvSanPham.DataSource = dTOSanPhamBindingSource;
            dgvSanPham.GridColor = SystemColors.ActiveCaption;
            dgvSanPham.Location = new Point(25, 136);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowTemplate.Height = 25;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(258, 185);
            dgvSanPham.TabIndex = 14;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // TenMon
            // 
            TenMon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenMon.DataPropertyName = "TenMon";
            TenMon.HeaderText = "Tên món";
            TenMon.Name = "TenMon";
            TenMon.ReadOnly = true;
            // 
            // Gia
            // 
            Gia.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Gia.DataPropertyName = "Gia";
            dataGridViewCellStyle1.NullValue = null;
            Gia.DefaultCellStyle = dataGridViewCellStyle1;
            Gia.HeaderText = "Giá";
            Gia.Name = "Gia";
            Gia.ReadOnly = true;
            Gia.Width = 49;
            // 
            // Anh
            // 
            Anh.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Anh.DataPropertyName = "Anh";
            Anh.HeaderText = "Ảnh";
            Anh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Anh.Name = "Anh";
            Anh.ReadOnly = true;
            Anh.Resizable = DataGridViewTriState.True;
            Anh.SortMode = DataGridViewColumnSortMode.Automatic;
            Anh.Width = 54;
            // 
            // dTOSanPhamBindingSource
            // 
            dTOSanPhamBindingSource.DataSource = typeof(DTO.DTOSanPham);
            // 
            // btnMuaHang
            // 
            btnMuaHang.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMuaHang.BackColor = Color.Goldenrod;
            btnMuaHang.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMuaHang.Location = new Point(676, 363);
            btnMuaHang.Name = "btnMuaHang";
            btnMuaHang.Size = new Size(98, 28);
            btnMuaHang.TabIndex = 15;
            btnMuaHang.Text = "Mua hàng";
            btnMuaHang.UseVisualStyleBackColor = false;
            btnMuaHang.Click += btnMuaHang_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(799, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsThongTinCaNhan, tsDoiMatKhau, tsLichSuMuaHang, tsDangXuat });
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
            // tsLichSuMuaHang
            // 
            tsLichSuMuaHang.Name = "tsLichSuMuaHang";
            tsLichSuMuaHang.Size = new Size(180, 22);
            tsLichSuMuaHang.Text = "Lịch sử mua hàng";
            tsLichSuMuaHang.Click += tsLichSuMuaHang_Click;
            // 
            // tsDangXuat
            // 
            tsDangXuat.Name = "tsDangXuat";
            tsDangXuat.Size = new Size(180, 22);
            tsDangXuat.Text = "Đăng xuất";
            tsDangXuat.Click += tsDangXuat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Tomato;
            btnTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(518, 81);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(76, 28);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(600, 84);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(176, 23);
            txtTimKiem.TabIndex = 18;
            // 
            // btnThemVaoGio
            // 
            btnThemVaoGio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThemVaoGio.BackColor = Color.MediumAquamarine;
            btnThemVaoGio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThemVaoGio.Location = new Point(557, 363);
            btnThemVaoGio.Name = "btnThemVaoGio";
            btnThemVaoGio.Size = new Size(113, 28);
            btnThemVaoGio.TabIndex = 15;
            btnThemVaoGio.Text = "Thêm vào giỏ";
            btnThemVaoGio.UseVisualStyleBackColor = false;
            btnThemVaoGio.Click += btnThemVaoGio_Click;
            // 
            // btnTBSP
            // 
            btnTBSP.BackColor = Color.FromArgb(255, 192, 128);
            btnTBSP.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTBSP.Location = new Point(366, 81);
            btnTBSP.Name = "btnTBSP";
            btnTBSP.Size = new Size(134, 28);
            btnTBSP.TabIndex = 15;
            btnTBSP.Text = "Toàn bộ sản phẩm";
            btnTBSP.UseVisualStyleBackColor = false;
            btnTBSP.Click += btnTBSP_Click;
            // 
            // dgvGioHang
            // 
            dgvGioHang.AllowUserToAddRows = false;
            dgvGioHang.AllowUserToDeleteRows = false;
            dgvGioHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGioHang.BackgroundColor = Color.FromArgb(255, 255, 192);
            dgvGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGioHang.Columns.AddRange(new DataGridViewColumn[] { Column1, Gia2, Column3, Column4, Column5, Sua, Xoa });
            dgvGioHang.GridColor = SystemColors.ActiveCaption;
            dgvGioHang.Location = new Point(283, 136);
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.RowTemplate.Height = 25;
            dgvGioHang.Size = new Size(493, 185);
            dgvGioHang.TabIndex = 19;
            dgvGioHang.CellClick += dgvGioHang_CellClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Tên món";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Gia2
            // 
            Gia2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Gia2.HeaderText = "Giá";
            Gia2.Name = "Gia2";
            Gia2.ReadOnly = true;
            Gia2.Width = 49;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            Column3.DefaultCellStyle = dataGridViewCellStyle2;
            Column3.HeaderText = "SLM";
            Column3.Name = "Column3";
            Column3.Width = 55;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column4.HeaderText = "Ảnh";
            Column4.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column4.Name = "Column4";
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            Column4.Width = 54;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column5.HeaderText = "Thành tiền";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 88;
            // 
            // Sua
            // 
            Sua.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Sua.HeaderText = "Sửa";
            Sua.Image = (Image)resources.GetObject("Sua.Image");
            Sua.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Sua.Name = "Sua";
            Sua.Resizable = DataGridViewTriState.True;
            Sua.SortMode = DataGridViewColumnSortMode.Automatic;
            Sua.Width = 51;
            // 
            // Xoa
            // 
            Xoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Xoa.HeaderText = "Xóa";
            Xoa.Image = (Image)resources.GetObject("Xoa.Image");
            Xoa.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Xoa.Name = "Xoa";
            Xoa.Resizable = DataGridViewTriState.True;
            Xoa.SortMode = DataGridViewColumnSortMode.Automatic;
            Xoa.Width = 52;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(730, 329);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 12;
            label2.Text = "VNĐ";
            // 
            // txtTongTien
            // 
            txtTongTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtTongTien.BackColor = SystemColors.Window;
            txtTongTien.Location = new Point(588, 327);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(136, 23);
            txtTongTien.TabIndex = 20;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(495, 329);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 12;
            label4.Text = "Tổng tiền:";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoTen.ForeColor = Color.Blue;
            lblHoTen.Location = new Point(103, 28);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(0, 21);
            lblHoTen.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(25, 28);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 22;
            label5.Text = "Xin chào: ";
            // 
            // MenuKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 413);
            Controls.Add(lblHoTen);
            Controls.Add(label5);
            Controls.Add(txtTongTien);
            Controls.Add(dgvGioHang);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(btnThemVaoGio);
            Controls.Add(btnTBSP);
            Controls.Add(btnMuaHang);
            Controls.Add(dgvSanPham);
            Controls.Add(cbbLoai);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XUNHIU Store";
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTOSanPhamBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTOGioHangBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private ComboBox cbbLoai;
        private DataGridView dgvSanPham;
        private Button btnMuaHang;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem tsThongTinCaNhan;
        private ToolStripMenuItem tsDoiMatKhau;
        private ToolStripMenuItem tsLichSuMuaHang;
        private ToolStripMenuItem tsDangXuat;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private BindingSource dTOSanPhamBindingSource;
        private Button btnThemVaoGio;
        private Button btnTBSP;
        private DataGridView dgvGioHang;
        private BindingSource dTOGioHangBindingSource;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Gia2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewImageColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewImageColumn Sua;
        private DataGridViewImageColumn Xoa;
        private Label label2;
        private TextBox txtTongTien;
        private Label label4;
        private DataGridViewTextBoxColumn TenMon;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewImageColumn Anh;
        private Label lblHoTen;
        private Label label5;
    }
}