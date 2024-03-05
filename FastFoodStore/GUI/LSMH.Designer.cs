namespace FastFoodStore.GUI
{
    partial class LSMH
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            dgvLSMH = new DataGridView();
            maDHDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maCTDHDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenMonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soLuongMuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            thanhTienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngayDatHangDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            daMuaDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dTOLichSuMuaHangBindingSource = new BindingSource(components);
            label2 = new Label();
            lblHoTen = new Label();
            label3 = new Label();
            btnTroVe = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLSMH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTOLichSuMuaHangBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(483, 22);
            label1.Name = "label1";
            label1.Size = new Size(315, 25);
            label1.TabIndex = 17;
            label1.Text = "XUNHIU Fast Food Store";
            // 
            // dgvLSMH
            // 
            dgvLSMH.AllowUserToAddRows = false;
            dgvLSMH.AllowUserToDeleteRows = false;
            dgvLSMH.AutoGenerateColumns = false;
            dgvLSMH.BackgroundColor = Color.FromArgb(255, 255, 192);
            dgvLSMH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLSMH.Columns.AddRange(new DataGridViewColumn[] { maDHDataGridViewTextBoxColumn, maCTDHDataGridViewTextBoxColumn, tenMonDataGridViewTextBoxColumn, giaDataGridViewTextBoxColumn, soLuongMuaDataGridViewTextBoxColumn, thanhTienDataGridViewTextBoxColumn, ngayDatHangDataGridViewTextBoxColumn, daMuaDataGridViewCheckBoxColumn });
            dgvLSMH.DataSource = dTOLichSuMuaHangBindingSource;
            dgvLSMH.GridColor = SystemColors.ActiveCaption;
            dgvLSMH.Location = new Point(25, 118);
            dgvLSMH.Name = "dgvLSMH";
            dgvLSMH.ReadOnly = true;
            dgvLSMH.RowTemplate.Height = 25;
            dgvLSMH.Size = new Size(761, 251);
            dgvLSMH.TabIndex = 19;
            // 
            // maDHDataGridViewTextBoxColumn
            // 
            maDHDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            maDHDataGridViewTextBoxColumn.DataPropertyName = "MaDH";
            maDHDataGridViewTextBoxColumn.HeaderText = "Mã ĐH";
            maDHDataGridViewTextBoxColumn.Name = "maDHDataGridViewTextBoxColumn";
            maDHDataGridViewTextBoxColumn.ReadOnly = true;
            maDHDataGridViewTextBoxColumn.Width = 69;
            // 
            // maCTDHDataGridViewTextBoxColumn
            // 
            maCTDHDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            maCTDHDataGridViewTextBoxColumn.DataPropertyName = "MaCTDH";
            maCTDHDataGridViewTextBoxColumn.HeaderText = "Mã CTĐH";
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
            soLuongMuaDataGridViewTextBoxColumn.HeaderText = "Số lượng mua";
            soLuongMuaDataGridViewTextBoxColumn.Name = "soLuongMuaDataGridViewTextBoxColumn";
            soLuongMuaDataGridViewTextBoxColumn.ReadOnly = true;
            soLuongMuaDataGridViewTextBoxColumn.Width = 97;
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
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            ngayDatHangDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            ngayDatHangDataGridViewTextBoxColumn.HeaderText = "Ngày đặt hàng";
            ngayDatHangDataGridViewTextBoxColumn.Name = "ngayDatHangDataGridViewTextBoxColumn";
            ngayDatHangDataGridViewTextBoxColumn.ReadOnly = true;
            ngayDatHangDataGridViewTextBoxColumn.Width = 101;
            // 
            // daMuaDataGridViewCheckBoxColumn
            // 
            daMuaDataGridViewCheckBoxColumn.DataPropertyName = "DaMua";
            daMuaDataGridViewCheckBoxColumn.HeaderText = "DaMua";
            daMuaDataGridViewCheckBoxColumn.Name = "daMuaDataGridViewCheckBoxColumn";
            daMuaDataGridViewCheckBoxColumn.ReadOnly = true;
            daMuaDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dTOLichSuMuaHangBindingSource
            // 
            dTOLichSuMuaHangBindingSource.DataSource = typeof(DTO.DTOLichSuMuaHang);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(25, 26);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 20;
            label2.Text = "Xin chào: ";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoTen.ForeColor = Color.Blue;
            lblHoTen.Location = new Point(103, 26);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(0, 21);
            lblHoTen.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(305, 70);
            label3.Name = "label3";
            label3.Size = new Size(198, 25);
            label3.TabIndex = 21;
            label3.Text = "LỊCH SỬ MUA HÀNG";
            // 
            // btnTroVe
            // 
            btnTroVe.BackColor = Color.FromArgb(255, 128, 0);
            btnTroVe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTroVe.Location = new Point(700, 393);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(86, 28);
            btnTroVe.TabIndex = 22;
            btnTroVe.Text = "Trở về";
            btnTroVe.UseVisualStyleBackColor = false;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // LSMH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 438);
            Controls.Add(btnTroVe);
            Controls.Add(label3);
            Controls.Add(lblHoTen);
            Controls.Add(label2);
            Controls.Add(dgvLSMH);
            Controls.Add(label1);
            Name = "LSMH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XUNHIU Store";
            ((System.ComponentModel.ISupportInitialize)dgvLSMH).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTOLichSuMuaHangBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvLSMH;
        private DataGridViewTextBoxColumn maDHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maNguoiDungDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maCTDHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenMonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongMuaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayDatHangDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn daMuaDataGridViewCheckBoxColumn;
        private BindingSource dTOLichSuMuaHangBindingSource;
        private Label label2;
        private Label lblHoTen;
        private Label label3;
        private Button btnTroVe;
    }
}