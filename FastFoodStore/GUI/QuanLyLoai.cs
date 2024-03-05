using FastFoodStore.BUS;
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
using System.Xml.Linq;

namespace FastFoodStore
{
    public partial class QuanLyLoai : Form
    {
        BUSLoai busLoai = new BUSLoai();
        public DTOTaiKhoan tk { get; set; }
        public QuanLyLoai(DTOTaiKhoan tk)
        {
            InitializeComponent();
            GUILoai_Load();
            this.tk = tk;
        }
        private void GUILoai_Load()
        {
            dgvLoai.DataSource = busLoai.getLoai(); // Lấy loại
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new MenuAdmin(tk);
            f.ShowDialog();
        }

        private void dgvLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLoai.Text = dgvLoai.CurrentRow.Cells[0].Value.ToString();
            txtTenLoai.Text = dgvLoai.CurrentRow.Cells[1].Value.ToString();
            if (txtMaLoai.Text != null)
            {
                // Thiết lập TextBox ở chế độ chỉ đọc
                txtMaLoai.ReadOnly = true;
            }
            else
            {
                // Nếu giá trị là null, xử lý tùy thuộc vào yêu cầu của bạn
                txtMaLoai.Text = string.Empty; // Hoặc có thể đặt giá trị mặc định khác
            }
        }

        private void tsThem_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text != "" && txtTenLoai.Text != "")
            {
                // Tạo DTo
                DTOLoai loai = new DTOLoai(txtMaLoai.Text, txtTenLoai.Text);
                if (busLoai.kiemTraTrungMa(txtMaLoai.Text))
                {
                    MessageBox.Show("Mã loại đã tồn tại!");
                    return;
                }
                if (busLoai.themLoai(loai))
                {
                    MessageBox.Show("Thêm loại thành công!");
                    reset();
                    GUILoai_Load();
                }
                else
                {
                    MessageBox.Show("Thêm loại thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin!");
            }
        }

        private void tsSua_Click(object sender, EventArgs e)
        {
            if (dgvLoai.SelectedRows.Count > 0)
            {
                if (txtMaLoai.Text != "" && txtTenLoai.Text != "")
                {
                    // Tạo DTO
                    DTOLoai loai = new DTOLoai(txtMaLoai.Text, txtTenLoai.Text);

                    // Sửa
                    if (busLoai.suaLoai(loai))
                    {
                        MessageBox.Show("Sửa loại thành công!");
                        reset();
                        GUILoai_Load();
                    }
                    else
                    {
                        MessageBox.Show("Sửa loại thất bại!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin loại muốn sửa!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn loại muốn sửa!");
            }
        }

        private void tsXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvLoai.SelectedRows.Count > 0)
            {
                if (txtMaLoai.Text != "")
                {
                    var res = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (res == DialogResult.OK)
                    {
                        if (busLoai.xoaLoai(txtMaLoai.Text))
                        {
                            MessageBox.Show("Xóa loại thành công!");
                            reset();
                            GUILoai_Load();
                        }
                        else
                        {
                            MessageBox.Show("Xóa loại thất bại!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn loại muốn xóa!");
                }
            }
        }

        private void tsReset_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            txtMaLoai.Text = "";
            txtMaLoai.ReadOnly = false;
            txtTenLoai.Text = "";
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
