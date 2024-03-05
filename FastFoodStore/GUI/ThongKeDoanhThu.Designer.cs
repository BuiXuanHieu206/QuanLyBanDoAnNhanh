namespace FastFoodStore.GUI
{
    partial class ThongKeDoanhThu
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
            btnTroVe = new Button();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            tsThongTinCaNhan = new ToolStripMenuItem();
            tsDoiMatKhau = new ToolStripMenuItem();
            tsDangXuat = new ToolStripMenuItem();
            dgvDoanhThu = new DataGridView();
            maLoaiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenLoaiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tongSoLuongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tongDoanhThuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dTODoanhThuBindingSource = new BindingSource(components);
            tdt = new Label();
            lblTongDT = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTODoanhThuBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnTroVe
            // 
            btnTroVe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTroVe.Location = new Point(679, 416);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(86, 28);
            btnTroVe.TabIndex = 27;
            btnTroVe.Text = "Trở về";
            btnTroVe.UseVisualStyleBackColor = true;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(292, 62);
            label2.Name = "label2";
            label2.Size = new Size(235, 25);
            label2.TabIndex = 25;
            label2.Text = "THỐNG KÊ DOANH THU";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(610, 30);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 26;
            label1.Text = "XUNHIU Admin";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 24;
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
            // dgvDoanhThu
            // 
            dgvDoanhThu.AllowUserToAddRows = false;
            dgvDoanhThu.AllowUserToDeleteRows = false;
            dgvDoanhThu.AutoGenerateColumns = false;
            dgvDoanhThu.BackgroundColor = Color.FromArgb(255, 255, 192);
            dgvDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoanhThu.Columns.AddRange(new DataGridViewColumn[] { maLoaiDataGridViewTextBoxColumn, tenLoaiDataGridViewTextBoxColumn, tongSoLuongDataGridViewTextBoxColumn, tongDoanhThuDataGridViewTextBoxColumn });
            dgvDoanhThu.DataSource = dTODoanhThuBindingSource;
            dgvDoanhThu.GridColor = SystemColors.ActiveCaption;
            dgvDoanhThu.Location = new Point(55, 185);
            dgvDoanhThu.Name = "dgvDoanhThu";
            dgvDoanhThu.ReadOnly = true;
            dgvDoanhThu.RowTemplate.Height = 25;
            dgvDoanhThu.Size = new Size(710, 178);
            dgvDoanhThu.TabIndex = 28;
            // 
            // maLoaiDataGridViewTextBoxColumn
            // 
            maLoaiDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoai";
            maLoaiDataGridViewTextBoxColumn.HeaderText = "Mã loại";
            maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
            maLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenLoaiDataGridViewTextBoxColumn
            // 
            tenLoaiDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenLoaiDataGridViewTextBoxColumn.DataPropertyName = "TenLoai";
            tenLoaiDataGridViewTextBoxColumn.HeaderText = "Tên loại";
            tenLoaiDataGridViewTextBoxColumn.Name = "tenLoaiDataGridViewTextBoxColumn";
            tenLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongSoLuongDataGridViewTextBoxColumn
            // 
            tongSoLuongDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tongSoLuongDataGridViewTextBoxColumn.DataPropertyName = "TongSoLuong";
            tongSoLuongDataGridViewTextBoxColumn.HeaderText = "Tổng số lượng bán ra";
            tongSoLuongDataGridViewTextBoxColumn.Name = "tongSoLuongDataGridViewTextBoxColumn";
            tongSoLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongDoanhThuDataGridViewTextBoxColumn
            // 
            tongDoanhThuDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tongDoanhThuDataGridViewTextBoxColumn.DataPropertyName = "TongDoanhThu";
            tongDoanhThuDataGridViewTextBoxColumn.HeaderText = "Tổng doanh thu";
            tongDoanhThuDataGridViewTextBoxColumn.Name = "tongDoanhThuDataGridViewTextBoxColumn";
            tongDoanhThuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTODoanhThuBindingSource
            // 
            dTODoanhThuBindingSource.DataSource = typeof(DTO.DTODoanhThu);
            // 
            // tdt
            // 
            tdt.AutoSize = true;
            tdt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tdt.Location = new Point(55, 120);
            tdt.Name = "tdt";
            tdt.Size = new Size(161, 25);
            tdt.TabIndex = 29;
            tdt.Text = "Tổng doanh thu:";
            // 
            // lblTongDT
            // 
            lblTongDT.AutoSize = true;
            lblTongDT.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongDT.Location = new Point(213, 120);
            lblTongDT.Name = "lblTongDT";
            lblTongDT.Size = new Size(0, 25);
            lblTongDT.TabIndex = 29;
            // 
            // ThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 463);
            Controls.Add(lblTongDT);
            Controls.Add(tdt);
            Controls.Add(dgvDoanhThu);
            Controls.Add(btnTroVe);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "ThongKeDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XUNHIU Admin";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTODoanhThuBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTroVe;
        private Label label2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem tsThongTinCaNhan;
        private ToolStripMenuItem tsDoiMatKhau;
        private ToolStripMenuItem tsDangXuat;
        private DataGridView dgvDoanhThu;
        private BindingSource dTODoanhThuBindingSource;
        private DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenLoaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tongSoLuongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tongDoanhThuDataGridViewTextBoxColumn;
        private Label tdt;
        private Label lblTongDT;
    }
}