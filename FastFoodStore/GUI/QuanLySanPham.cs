using FastFoodStore.BUS;
using FastFoodStore.DAL;
using FastFoodStore.DTO;
using FastFoodStore.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodStore
{
    public partial class QuanLySanPham : Form
    {
        BUSSanPham busSanPham = new BUSSanPham();
        BUSLoai busLoai = new BUSLoai();
        public DTOTaiKhoan tk { get; set; }
        public QuanLySanPham(DTOTaiKhoan tk)
        {
            InitializeComponent();
            GUIMaLoai_Load();
            GUISanPham_Load();
            this.tk = tk;
        }
        private void GUISanPham_Load()
        {
            dgvSanPham.DataSource = busSanPham.getSanPham(); // Lấy loại
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new MenuAdmin(tk);
            f.ShowDialog();
        }
        private void reset()
        {
            txtMaMon.Text = "";
            txtMaMon.ReadOnly = false;
            txtTenMon.Text = "";
            txtGia.Text = "";
            txtSoLuong.Text = "";
            picMon.ImageLocation = null;
            txtTimKiem.Text = "";
            GUISanPham_Load();
            GUIMaLoai_Load();
        }
        private void GUIMaLoai_Load()
        {
            var loai = busLoai.getLoai();
            cbbMaLoai.DataSource = loai;
            cbbMaLoai.DisplayMember = "MaLoai";
        }
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMon.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            txtTenMon.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
            txtGia.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
            DateTime ngayNhapValue = (DateTime)dgvSanPham.CurrentRow.Cells[4].Value;
            dtpNgayNhap.Value = ngayNhapValue;
            if (dgvSanPham.CurrentRow.Cells[5].Value.ToString().Contains("E:\\img\\"))
                picMon.ImageLocation = dgvSanPham.CurrentRow.Cells[5].Value.ToString();
            else
                picMon.ImageLocation = "E:\\" + dgvSanPham.CurrentRow.Cells[5].Value.ToString();
            cbbMaLoai.Text = dgvSanPham.CurrentRow.Cells[6].Value.ToString();

            if (txtMaMon.Text != null)
            {
                // Thiết lập TextBox ở chế độ chỉ đọc
                txtMaMon.ReadOnly = true;
            }
            else
            {
                // Nếu giá trị là null, xử lý tùy thuộc vào yêu cầu của bạn
                txtMaMon.Text = string.Empty; // Hoặc có thể đặt giá trị mặc định khác
            }
        }

        private void tsReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void tsThem_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text != "" && txtTenMon.Text != "" && txtGia.Text != "" && txtSoLuong.Text != "" && picMon.ImageLocation != "")
            {
                // Tạo DTo
                DTOSanPham sp = new DTOSanPham(txtMaMon.Text, txtTenMon.Text, long.Parse(txtGia.Text), long.Parse(txtSoLuong.Text), picMon.ImageLocation, dtpNgayNhap.Value, cbbMaLoai.Text);
                if (busLoai.kiemTraTrungMa(txtMaMon.Text))
                {
                    MessageBox.Show("Mã món đã tồn tại!");
                    return;
                }
                if (busSanPham.themMon(sp))
                {
                    MessageBox.Show("Thêm món thành công!");
                    reset();
                    GUISanPham_Load();
                }
                else
                {
                    MessageBox.Show("Thêm món thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin!");
            }
        }

        private void picMon_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog()
            {
                Title = "Chọn file ảnh"
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var selectedFile = openFile.FileName;
                picMon.ImageLocation = selectedFile;
            }
        }

        private void tsSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                if (txtMaMon.Text != "" && txtTenMon.Text != "" && txtGia.Text != "" && txtSoLuong.Text != "" && picMon.ImageLocation != "")
                {
                    // Tạo DTO
                    DTOSanPham sp = new DTOSanPham(txtMaMon.Text, txtTenMon.Text, long.Parse(txtGia.Text), long.Parse(txtSoLuong.Text), picMon.ImageLocation, dtpNgayNhap.Value, cbbMaLoai.Text);

                    // Sửa
                    if (busSanPham.suaMon(sp))
                    {
                        MessageBox.Show("Sửa món thành công!");
                        reset();
                        GUISanPham_Load();
                    }
                    else
                    {
                        MessageBox.Show("Sửa món thất bại!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin món muốn sửa!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn món muốn sửa!");
            }
        }

        private void tsXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                if (txtMaMon.Text != "")
                {
                    var res = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (res == DialogResult.OK)
                    {
                        if (busSanPham.XoaMon(txtMaMon.Text))
                        {
                            MessageBox.Show("Xóa món thành công!");
                            reset();
                            GUISanPham_Load();
                        }
                        else
                        {
                            MessageBox.Show("Xóa món thất bại!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn món muốn xóa!");
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                if (busSanPham.timKiemMon(txtTimKiem.Text).Count != 0)
                    dgvSanPham.DataSource = busSanPham.timKiemMon(txtTimKiem.Text);
                else
                    MessageBox.Show("Không tìm thấy món cho từ khóa " + txtTimKiem.Text + "!");
            }
            else
            {
                MessageBox.Show("Hãy nhập tên món cần tìm kiếm!");
            }
        }

        private void tsThongTinCaNhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new ThongTinCaNhan(tk);
            f.ShowDialog();
        }

        private void tsDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new DangNhap();
            f.ShowDialog();
        }

        private void tsDoiMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new DoiMatKhau(tk);
            f.ShowDialog();
        }
    }
}
