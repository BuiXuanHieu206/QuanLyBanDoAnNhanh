namespace FastFoodStore
{
    partial class QuanLySanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLySanPham));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label3 = new Label();
            label2 = new Label();
            txtTenMon = new TextBox();
            txtMaMon = new TextBox();
            label4 = new Label();
            label1 = new Label();
            dgvSanPham = new DataGridView();
            dTOSanPhamBindingSource = new BindingSource(components);
            tsXoa = new ToolStripButton();
            tsSua = new ToolStripButton();
            tsThem = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            tsReset = new ToolStripButton();
            panel1 = new Panel();
            tsDangXuat = new ToolStripMenuItem();
            tsDoiMatKhau = new ToolStripMenuItem();
            tsThongTinCaNhan = new ToolStripMenuItem();
            menuToolStripMenuItem = new ToolStripMenuItem();
            btnTroVe = new Button();
            menuStrip1 = new MenuStrip();
            txtGia = new TextBox();
            label5 = new Label();
            txtSoLuong = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            picMon = new PictureBox();
            label9 = new Label();
            dtpNgayNhap = new DateTimePicker();
            cbbMaLoai = new ComboBox();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            maMonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenMonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soLuongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngayNhapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Anh = new DataGridViewTextBoxColumn();
            maLoaiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTOSanPhamBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMon).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(61, 138);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 14;
            label3.Text = "Mã món:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(437, 140);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 15;
            label2.Text = "Tên món:";
            // 
            // txtTenMon
            // 
            txtTenMon.Location = new Point(532, 140);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(204, 23);
            txtTenMon.TabIndex = 8;
            // 
            // txtMaMon
            // 
            txtMaMon.Location = new Point(161, 138);
            txtMaMon.Name = "txtMaMon";
            txtMaMon.Size = new Size(204, 23);
            txtMaMon.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(274, 55);
            label4.Name = "label4";
            label4.Size = new Size(285, 37);
            label4.TabIndex = 12;
            label4.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(598, 34);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 13;
            label1.Text = "XUNHIU Admin";
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToDeleteRows = false;
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.BackgroundColor = Color.FromArgb(255, 255, 192);
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { maMonDataGridViewTextBoxColumn, tenMonDataGridViewTextBoxColumn, giaDataGridViewTextBoxColumn, soLuongDataGridViewTextBoxColumn, ngayNhapDataGridViewTextBoxColumn, Anh, maLoaiDataGridViewTextBoxColumn });
            dgvSanPham.DataSource = dTOSanPhamBindingSource;
            dgvSanPham.GridColor = SystemColors.ActiveCaption;
            dgvSanPham.Location = new Point(0, 26);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowTemplate.Height = 25;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(731, 176);
            dgvSanPham.TabIndex = 1;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // dTOSanPhamBindingSource
            // 
            dTOSanPhamBindingSource.DataSource = typeof(DTO.DTOSanPham);
            // 
            // tsXoa
            // 
            tsXoa.Image = (Image)resources.GetObject("tsXoa.Image");
            tsXoa.ImageTransparentColor = Color.Magenta;
            tsXoa.Name = "tsXoa";
            tsXoa.Size = new Size(47, 22);
            tsXoa.Text = "Xóa";
            tsXoa.Click += tsXoa_Click;
            // 
            // tsSua
            // 
            tsSua.Image = (Image)resources.GetObject("tsSua.Image");
            tsSua.ImageTransparentColor = Color.Magenta;
            tsSua.Name = "tsSua";
            tsSua.Size = new Size(46, 22);
            tsSua.Text = "Sửa";
            tsSua.Click += tsSua_Click;
            // 
            // tsThem
            // 
            tsThem.Image = (Image)resources.GetObject("tsThem.Image");
            tsThem.ImageTransparentColor = Color.Magenta;
            tsThem.Name = "tsThem";
            tsThem.Size = new Size(57, 22);
            tsThem.Text = "Thêm";
            tsThem.Click += tsThem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsThem, tsSua, tsXoa, tsReset });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(734, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsReset
            // 
            tsReset.Image = (Image)resources.GetObject("tsReset.Image");
            tsReset.ImageTransparentColor = Color.Magenta;
            tsReset.Name = "tsReset";
            tsReset.Size = new Size(55, 22);
            tsReset.Text = "Reset";
            tsReset.Click += tsReset_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(dgvSanPham);
            panel1.Location = new Point(26, 282);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 205);
            panel1.TabIndex = 10;
            // 
            // tsDangXuat
            // 
            tsDangXuat.Name = "tsDangXuat";
            tsDangXuat.Size = new Size(170, 22);
            tsDangXuat.Text = "Đăng xuất";
            tsDangXuat.Click += tsDangXuat_Click;
            // 
            // tsDoiMatKhau
            // 
            tsDoiMatKhau.Name = "tsDoiMatKhau";
            tsDoiMatKhau.Size = new Size(170, 22);
            tsDoiMatKhau.Text = "Đổi mật khẩu";
            tsDoiMatKhau.Click += tsDoiMatKhau_Click;
            // 
            // tsThongTinCaNhan
            // 
            tsThongTinCaNhan.Name = "tsThongTinCaNhan";
            tsThongTinCaNhan.Size = new Size(170, 22);
            tsThongTinCaNhan.Text = "Thông tin cá nhân";
            tsThongTinCaNhan.Click += tsThongTinCaNhan_Click;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsThongTinCaNhan, tsDoiMatKhau, tsDangXuat });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // btnTroVe
            // 
            btnTroVe.BackColor = Color.FromArgb(255, 128, 0);
            btnTroVe.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTroVe.Location = new Point(650, 499);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(110, 30);
            btnTroVe.TabIndex = 11;
            btnTroVe.Text = "Trở về";
            btnTroVe.UseVisualStyleBackColor = false;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(161, 167);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(204, 23);
            txtGia.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(61, 167);
            label5.Name = "label5";
            label5.Size = new Size(39, 21);
            label5.TabIndex = 14;
            label5.Text = "Giá:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(532, 167);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(204, 23);
            txtSoLuong.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(437, 167);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 14;
            label6.Text = "Số lượng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(61, 196);
            label7.Name = "label7";
            label7.Size = new Size(98, 21);
            label7.TabIndex = 14;
            label7.Text = "Ngày nhập:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(437, 196);
            label8.Name = "label8";
            label8.Size = new Size(45, 21);
            label8.TabIndex = 14;
            label8.Text = "Ảnh:";
            // 
            // picMon
            // 
            picMon.BorderStyle = BorderStyle.FixedSingle;
            picMon.Location = new Point(532, 196);
            picMon.Name = "picMon";
            picMon.Size = new Size(80, 80);
            picMon.SizeMode = PictureBoxSizeMode.Zoom;
            picMon.TabIndex = 16;
            picMon.TabStop = false;
            picMon.Click += picMon_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(61, 230);
            label9.Name = "label9";
            label9.Size = new Size(71, 21);
            label9.TabIndex = 14;
            label9.Text = "Mã loại:";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.Location = new Point(161, 196);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(204, 23);
            dtpNgayNhap.TabIndex = 17;
            // 
            // cbbMaLoai
            // 
            cbbMaLoai.FormattingEnabled = true;
            cbbMaLoai.Location = new Point(161, 230);
            cbbMaLoai.Name = "cbbMaLoai";
            cbbMaLoai.Size = new Size(204, 23);
            cbbMaLoai.TabIndex = 18;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(128, 255, 128);
            btnTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(61, 99);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(88, 23);
            btnTimKiem.TabIndex = 19;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(161, 99);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(204, 23);
            txtTimKiem.TabIndex = 20;
            // 
            // maMonDataGridViewTextBoxColumn
            // 
            maMonDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            maMonDataGridViewTextBoxColumn.DataPropertyName = "MaMon";
            maMonDataGridViewTextBoxColumn.HeaderText = "Mã món";
            maMonDataGridViewTextBoxColumn.Name = "maMonDataGridViewTextBoxColumn";
            maMonDataGridViewTextBoxColumn.ReadOnly = true;
            maMonDataGridViewTextBoxColumn.Width = 77;
            // 
            // tenMonDataGridViewTextBoxColumn
            // 
            tenMonDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenMonDataGridViewTextBoxColumn.DataPropertyName = "TenMon";
            tenMonDataGridViewTextBoxColumn.HeaderText = "Tên món";
            tenMonDataGridViewTextBoxColumn.Name = "tenMonDataGridViewTextBoxColumn";
            tenMonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            giaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            giaDataGridViewTextBoxColumn.HeaderText = "Giá";
            giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            giaDataGridViewTextBoxColumn.ReadOnly = true;
            giaDataGridViewTextBoxColumn.Width = 49;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            soLuongDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            soLuongDataGridViewTextBoxColumn.Width = 79;
            // 
            // ngayNhapDataGridViewTextBoxColumn
            // 
            ngayNhapDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ngayNhapDataGridViewTextBoxColumn.DataPropertyName = "NgayNhap";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            ngayNhapDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            ngayNhapDataGridViewTextBoxColumn.HeaderText = "Ngày nhập";
            ngayNhapDataGridViewTextBoxColumn.Name = "ngayNhapDataGridViewTextBoxColumn";
            ngayNhapDataGridViewTextBoxColumn.ReadOnly = true;
            ngayNhapDataGridViewTextBoxColumn.Width = 90;
            // 
            // Anh
            // 
            Anh.DataPropertyName = "Anh";
            Anh.HeaderText = "Ảnh";
            Anh.Name = "Anh";
            Anh.ReadOnly = true;
            // 
            // maLoaiDataGridViewTextBoxColumn
            // 
            maLoaiDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            maLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoai";
            maLoaiDataGridViewTextBoxColumn.HeaderText = "Mã loại";
            maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
            maLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            maLoaiDataGridViewTextBoxColumn.Width = 71;
            // 
            // QuanLySanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(cbbMaLoai);
            Controls.Add(dtpNgayNhap);
            Controls.Add(picMon);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTenMon);
            Controls.Add(txtSoLuong);
            Controls.Add(txtGia);
            Controls.Add(txtMaMon);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnTroVe);
            Controls.Add(menuStrip1);
            Name = "QuanLySanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XUNHIU Admin";
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTOSanPhamBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox txtTenMon;
        private TextBox txtMaMon;
        private Label label4;
        private Label label1;
        private DataGridView dgvSanPham;
        private ToolStripButton tsXoa;
        private ToolStripButton tsSua;
        private ToolStripButton tsThem;
        private ToolStrip toolStrip1;
        private Panel panel1;
        private ToolStripMenuItem tsDangXuat;
        private ToolStripMenuItem tsDoiMatKhau;
        private ToolStripMenuItem tsThongTinCaNhan;
        private ToolStripMenuItem menuToolStripMenuItem;
        private Button btnTroVe;
        private MenuStrip menuStrip1;
        private TextBox txtGia;
        private Label label5;
        private TextBox txtSoLuong;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox picMon;
        private BindingSource dTOSanPhamBindingSource;
        private Label label9;
        private DateTimePicker dtpNgayNhap;
        private ComboBox cbbMaLoai;
        private ToolStripButton tsReset;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private DataGridViewTextBoxColumn maMonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenMonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayNhapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Anh;
        private DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
    }
}