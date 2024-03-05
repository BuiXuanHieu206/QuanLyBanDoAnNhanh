namespace FastFoodStore.GUI
{
    partial class LichSuMuaHang
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            tsThongTinCaNhan = new ToolStripMenuItem();
            tsDoiMatKhau = new ToolStripMenuItem();
            tsDangXuat = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            dgvLichSuMuaHang = new DataGridView();
            maDHDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maNguoiDungDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maCTDHDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenMonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soLuongMuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            thanhTienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngayDatHangDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dTOLichSuMuaHangBindingSource = new BindingSource(components);
            btnTroVe = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichSuMuaHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTOLichSuMuaHangBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
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
            label1.Location = new Point(610, 24);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 4;
            label1.Text = "XUNHIU Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(292, 56);
            label2.Name = "label2";
            label2.Size = new Size(223, 25);
            label2.TabIndex = 4;
            label2.Text = "THỐNG KÊ ĐƠN HÀNG";
            // 
            // dgvLichSuMuaHang
            // 
            dgvLichSuMuaHang.AllowUserToAddRows = false;
            dgvLichSuMuaHang.AllowUserToDeleteRows = false;
            dgvLichSuMuaHang.AutoGenerateColumns = false;
            dgvLichSuMuaHang.BackgroundColor = Color.FromArgb(255, 255, 192);
            dgvLichSuMuaHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichSuMuaHang.Columns.AddRange(new DataGridViewColumn[] { maDHDataGridViewTextBoxColumn, maNguoiDungDataGridViewTextBoxColumn, maCTDHDataGridViewTextBoxColumn, tenMonDataGridViewTextBoxColumn, giaDataGridViewTextBoxColumn, soLuongMuaDataGridViewTextBoxColumn, thanhTienDataGridViewTextBoxColumn, ngayDatHangDataGridViewTextBoxColumn });
            dgvLichSuMuaHang.DataSource = dTOLichSuMuaHangBindingSource;
            dgvLichSuMuaHang.GridColor = SystemColors.ActiveCaption;
            dgvLichSuMuaHang.Location = new Point(43, 108);
            dgvLichSuMuaHang.Name = "dgvLichSuMuaHang";
            dgvLichSuMuaHang.ReadOnly = true;
            dgvLichSuMuaHang.RowTemplate.Height = 25;
            dgvLichSuMuaHang.Size = new Size(716, 295);
            dgvLichSuMuaHang.TabIndex = 5;
            // 
            // maDHDataGridViewTextBoxColumn
            // 
            maDHDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            maDHDataGridViewTextBoxColumn.DataPropertyName = "MaDH";
            maDHDataGridViewTextBoxColumn.HeaderText = "Mã DH";
            maDHDataGridViewTextBoxColumn.Name = "maDHDataGridViewTextBoxColumn";
            maDHDataGridViewTextBoxColumn.ReadOnly = true;
            maDHDataGridViewTextBoxColumn.Width = 69;
            // 
            // maNguoiDungDataGridViewTextBoxColumn
            // 
            maNguoiDungDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            maNguoiDungDataGridViewTextBoxColumn.DataPropertyName = "MaNguoiDung";
            maNguoiDungDataGridViewTextBoxColumn.HeaderText = "Mã ND";
            maNguoiDungDataGridViewTextBoxColumn.Name = "maNguoiDungDataGridViewTextBoxColumn";
            maNguoiDungDataGridViewTextBoxColumn.ReadOnly = true;
            maNguoiDungDataGridViewTextBoxColumn.Width = 69;
            // 
            // maCTDHDataGridViewTextBoxColumn
            // 
            maCTDHDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            maCTDHDataGridViewTextBoxColumn.DataPropertyName = "MaCTDH";
            maCTDHDataGridViewTextBoxColumn.HeaderText = "Mã CTDH";
            maCTDHDataGridViewTextBoxColumn.Name = "maCTDHDataGridViewTextBoxColumn";
            maCTDHDataGridViewTextBoxColumn.ReadOnly = true;
            maCTDHDataGridViewTextBoxColumn.Width = 77;
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
            // soLuongMuaDataGridViewTextBoxColumn
            // 
            soLuongMuaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            soLuongMuaDataGridViewTextBoxColumn.DataPropertyName = "SoLuongMua";
            soLuongMuaDataGridViewTextBoxColumn.HeaderText = "SLM";
            soLuongMuaDataGridViewTextBoxColumn.Name = "soLuongMuaDataGridViewTextBoxColumn";
            soLuongMuaDataGridViewTextBoxColumn.ReadOnly = true;
            soLuongMuaDataGridViewTextBoxColumn.Width = 55;
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            thanhTienDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            thanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien";
            thanhTienDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            thanhTienDataGridViewTextBoxColumn.ReadOnly = true;
            thanhTienDataGridViewTextBoxColumn.Width = 81;
            // 
            // ngayDatHangDataGridViewTextBoxColumn
            // 
            ngayDatHangDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ngayDatHangDataGridViewTextBoxColumn.DataPropertyName = "NgayDatHang";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            ngayDatHangDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            ngayDatHangDataGridViewTextBoxColumn.HeaderText = "Ngày đặt hàng";
            ngayDatHangDataGridViewTextBoxColumn.Name = "ngayDatHangDataGridViewTextBoxColumn";
            ngayDatHangDataGridViewTextBoxColumn.ReadOnly = true;
            ngayDatHangDataGridViewTextBoxColumn.Width = 101;
            // 
            // dTOLichSuMuaHangBindingSource
            // 
            dTOLichSuMuaHangBindingSource.DataSource = typeof(DTO.DTOLichSuMuaHang);
            // 
            // btnTroVe
            // 
            btnTroVe.BackColor = Color.FromArgb(255, 128, 0);
            btnTroVe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTroVe.Location = new Point(673, 410);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(86, 28);
            btnTroVe.TabIndex = 23;
            btnTroVe.Text = "Trở về";
            btnTroVe.UseVisualStyleBackColor = false;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // LichSuMuaHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTroVe);
            Controls.Add(dgvLichSuMuaHang);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "LichSuMuaHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XUNHIU Admin";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichSuMuaHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTOLichSuMuaHangBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem tsThongTinCaNhan;
        private ToolStripMenuItem tsDoiMatKhau;
        private ToolStripMenuItem tsDangXuat;
        private Label label1;
        private Label label2;
        private DataGridView dgvLichSuMuaHang;
        private BindingSource dTOLichSuMuaHangBindingSource;
        private DataGridViewTextBoxColumn maDHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maNguoiDungDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maCTDHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenMonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongMuaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayDatHangDataGridViewTextBoxColumn;
        private Button btnTroVe;
    }
}