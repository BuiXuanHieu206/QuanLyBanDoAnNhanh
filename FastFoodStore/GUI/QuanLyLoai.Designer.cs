namespace FastFoodStore
{
    partial class QuanLyLoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyLoai));
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            tsThongTinCaNhan = new ToolStripMenuItem();
            tsDoiMatKhau = new ToolStripMenuItem();
            tsDangXuat = new ToolStripMenuItem();
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            tsThem = new ToolStripButton();
            tsSua = new ToolStripButton();
            tsXoa = new ToolStripButton();
            tsReset = new ToolStripButton();
            dgvLoai = new DataGridView();
            MaLoai = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            dTOLoaiBindingSource = new BindingSource(components);
            label1 = new Label();
            txtMaLoai = new TextBox();
            txtTenLoai = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnTroVe = new Button();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTOLoaiBindingSource).BeginInit();
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
            // panel1
            // 
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(dgvLoai);
            panel1.Location = new Point(65, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(674, 205);
            panel1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsThem, tsSua, tsXoa, tsReset });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(674, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
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
            // tsSua
            // 
            tsSua.Image = (Image)resources.GetObject("tsSua.Image");
            tsSua.ImageTransparentColor = Color.Magenta;
            tsSua.Name = "tsSua";
            tsSua.Size = new Size(46, 22);
            tsSua.Text = "Sửa";
            tsSua.Click += tsSua_Click;
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
            // tsReset
            // 
            tsReset.Image = (Image)resources.GetObject("tsReset.Image");
            tsReset.ImageTransparentColor = Color.Magenta;
            tsReset.Name = "tsReset";
            tsReset.Size = new Size(55, 22);
            tsReset.Text = "Reset";
            tsReset.Click += tsReset_Click;
            // 
            // dgvLoai
            // 
            dgvLoai.AllowUserToAddRows = false;
            dgvLoai.AllowUserToDeleteRows = false;
            dgvLoai.AutoGenerateColumns = false;
            dgvLoai.BackgroundColor = Color.FromArgb(255, 255, 192);
            dgvLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoai.Columns.AddRange(new DataGridViewColumn[] { MaLoai, TenLoai });
            dgvLoai.DataSource = dTOLoaiBindingSource;
            dgvLoai.GridColor = SystemColors.ActiveCaption;
            dgvLoai.Location = new Point(0, 26);
            dgvLoai.Name = "dgvLoai";
            dgvLoai.ReadOnly = true;
            dgvLoai.RowTemplate.Height = 25;
            dgvLoai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoai.Size = new Size(671, 176);
            dgvLoai.TabIndex = 1;
            dgvLoai.CellClick += dgvLoai_CellClick;
            // 
            // MaLoai
            // 
            MaLoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaLoai.DataPropertyName = "MaLoai";
            MaLoai.HeaderText = "Mã loại";
            MaLoai.Name = "MaLoai";
            MaLoai.ReadOnly = true;
            // 
            // TenLoai
            // 
            TenLoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Tên loại";
            TenLoai.Name = "TenLoai";
            TenLoai.ReadOnly = true;
            // 
            // dTOLoaiBindingSource
            // 
            dTOLoaiBindingSource.DataSource = typeof(DTO.DTOLoai);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(598, 24);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 4;
            label1.Text = "XUNHIU Admin";
            // 
            // txtMaLoai
            // 
            txtMaLoai.Location = new Point(142, 121);
            txtMaLoai.Name = "txtMaLoai";
            txtMaLoai.Size = new Size(204, 23);
            txtMaLoai.TabIndex = 0;
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(535, 123);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(201, 23);
            txtTenLoai.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(455, 123);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 6;
            label2.Text = "Tên loại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(65, 121);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 6;
            label3.Text = "Mã loại:";
            // 
            // btnTroVe
            // 
            btnTroVe.BackColor = Color.FromArgb(255, 128, 0);
            btnTroVe.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTroVe.Location = new Point(629, 401);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(110, 30);
            btnTroVe.TabIndex = 3;
            btnTroVe.Text = "Trở về";
            btnTroVe.UseVisualStyleBackColor = false;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(313, 47);
            label4.Name = "label4";
            label4.Size = new Size(201, 37);
            label4.TabIndex = 4;
            label4.Text = "QUẢN LÝ LOẠI";
            // 
            // QuanLyLoai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 448);
            Controls.Add(btnTroVe);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTenLoai);
            Controls.Add(txtMaLoai);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "QuanLyLoai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XUNHIU Admin";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoai).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTOLoaiBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem tsThongTinCaNhan;
        private ToolStripMenuItem tsDoiMatKhau;
        private ToolStripMenuItem tsDangXuat;
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsThem;
        private ToolStripButton tsSua;
        private ToolStripButton tsXoa;
        private DataGridView dgvLoai;
        private Label label1;
        private TextBox txtMaLoai;
        private TextBox txtTenLoai;
        private Label label2;
        private Label label3;
        private Button btnTroVe;
        private Label label4;
        private BindingSource dTOLoaiBindingSource;
        private DataGridViewTextBoxColumn MaLoai;
        private DataGridViewTextBoxColumn TenLoai;
        private ToolStripButton tsReset;
    }
}