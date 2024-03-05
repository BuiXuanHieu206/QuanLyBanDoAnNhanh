using FastFoodStore.BUS;
using FastFoodStore.DTO;
using FastFoodStore.GUI;
using System;
using System.Collections;
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
    public partial class MenuKhachHang : Form
    {
        BUSLoai busloai = new BUSLoai();
        BUSSanPham busSanPham = new BUSSanPham();
        BUSDonHang busdh = new BUSDonHang();
        BUSCTDH busctdh = new BUSCTDH();
        public DTOTaiKhoan tk { get; set; }
        public MenuKhachHang(DTOTaiKhoan tk)
        {
            this.tk = tk;
            InitializeComponent();
            GUIMaLoai_Load();
            GUIHoTen_Load();
            GUISanPham_Load(busSanPham.getSanPham());
        }
        private void GUIMaLoai_Load()
        {
            var loai = busloai.getLoai();
            cbbLoai.DataSource = loai;
            cbbLoai.DisplayMember = "TenLoai";
        }
        void GUIHoTen_Load()
        {
            lblHoTen.Text = tk.HoTen;
        }
        private void GUISanPham_Load(DataTable sanPhamList)
        {

            // Tạo DataTable mới để chứa dữ liệu với cột hình ảnh và các cột khác cần thiết
            DataTable dt = new DataTable();
            dt.Columns.Add("TenMon"); // Thêm các cột khác nếu cần
            dt.Columns.Add("Gia");
            dt.Columns.Add("Anh", typeof(Image)); // Cột hình ảnh

            // Đổ dữ liệu từ DataTable sanPhamList vào DataTable dt
            foreach (DataRow sanPhamRow in sanPhamList.Rows)
            {
                // Chuyển đổi đường dẫn hình ảnh thành đối tượng Image
                Image image = Image.FromFile(sanPhamRow["Anh"].ToString());

                // Tạo một hàng mới
                DataRow row = dt.NewRow();

                // Đặt giá trị cho các cột
                row["TenMon"] = sanPhamRow["TenMon"];
                row["Gia"] = sanPhamRow["Gia"];
                row["Anh"] = image;

                // Thêm hàng vào DataTable
                dt.Rows.Add(row);
            }

            // Gán DataTable làm nguồn dữ liệu cho DataGridView
            dgvSanPham.DataSource = dt;
            dgvSanPham.RowPostPaint += dgvSanPham_RowPostPaint;
        }
        private void GUISanPham_ListLoad(List<DTOSanPham> sanPhamList)
        {

            // Tạo DataTable mới để chứa dữ liệu với cột hình ảnh và các cột khác cần thiết
            DataTable dt = new DataTable();
            dt.Columns.Add("TenMon"); // Thêm các cột khác nếu cần
            dt.Columns.Add("Gia");
            dt.Columns.Add("Anh", typeof(Image)); // Cột hình ảnh

            // Đổ dữ liệu từ DataTable sanPhamList vào DataTable dt
            foreach (var sanPham in sanPhamList)
            {
                // Chuyển đổi đường dẫn hình ảnh thành đối tượng Image
                Image image = Image.FromFile(sanPham.Anh);

                // Tạo một hàng mới
                DataRow row = dt.NewRow();

                // Đặt giá trị cho các cột
                row["TenMon"] = sanPham.TenMon;
                row["Gia"] = sanPham.Gia;
                row["Anh"] = image;

                // Thêm hàng vào DataTable
                dt.Rows.Add(row);
            }

            // Gán DataTable làm nguồn dữ liệu cho DataGridView
            dgvSanPham.DataSource = dt;
            dgvSanPham.RowPostPaint += dgvSanPham_RowPostPaint;
        }
        private void dgvSanPham_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var dataGridView = sender as DataGridView;

            // Lấy hình ảnh từ cột
            var image = dataGridView.Rows[e.RowIndex].Cells["Anh"].Value as Image;

            // Định kích thước cột là kích thước của hình ảnh
            if (image != null)
            {
                dataGridView.Rows[e.RowIndex].Height = 50;
                dataGridView.Columns["Anh"].Width = 50;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                if (busSanPham.timKiemMon(txtTimKiem.Text).Count != 0)
                    GUISanPham_ListLoad(busSanPham.timKiemMon(txtTimKiem.Text));
                else
                    MessageBox.Show("Không tìm thấy món cho từ khóa " + txtTimKiem.Text + "!");
            }
            else
            {
                MessageBox.Show("Hãy nhập tên món cần tìm kiếm!");
            }
        }

        private void btnTBSP_Click(object sender, EventArgs e)
        {
            GUISanPham_Load(busSanPham.getSanPham());
        }

        private void cbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            GUISanPham_ListLoad(busSanPham.timKiemLoai(cbbLoai.Text));
        }
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvGioHang.Rows)
            {
                // Nếu sản phẩm đã tồn tại thì tăng số lượng lên 1
                if (item.Cells[0].Value.Equals(dgvSanPham.CurrentRow.Cells[0].Value.ToString()))
                {
                    item.Cells[2].Value = int.Parse(item.Cells[2].Value.ToString()) + 1;
                    item.Cells[4].Value = int.Parse(item.Cells[2].Value.ToString()) * int.Parse(item.Cells[1].Value.ToString());
                    TongTien();
                    return;
                }
            }
            dgvGioHang.Rows.Add(new object[] {
                dgvSanPham.CurrentRow.Cells[0].Value.ToString(),
                dgvSanPham.CurrentRow.Cells[1].Value.ToString(),
                1,
                dgvSanPham.CurrentRow.Cells[2].Value,
                dgvSanPham.CurrentRow.Cells[1].Value.ToString()
            });
            TongTien();
        }
        private void TongTien()
        {
            long tongTien = 0;
            int tongSoLuong = 0;

            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                int soLuong = Convert.ToInt32(row.Cells[2].Value);
                long donGia = Convert.ToInt64(row.Cells[1].Value);

                tongSoLuong += soLuong;
                tongTien += soLuong * donGia;
            }
            txtTongTien.Text = tongTien.ToString();
        }
        private void dgvGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvGioHang.Columns[e.ColumnIndex].Name;

            if (columnName == "Xoa")
            {
                DataGridViewRow selectedRow = dgvGioHang.Rows[e.RowIndex];
                dgvGioHang.Rows.Remove(selectedRow);
                TongTien();
            }

            if (columnName == "Sua")
            {
                object cellValue = dgvGioHang.Rows[e.RowIndex].Cells[2].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int result))
                {
                    int currentQuantity = Convert.ToInt32(dgvGioHang.Rows[e.RowIndex].Cells[2].Value);
                    if (currentQuantity <= 0)
                    {
                        MessageBox.Show("Số lượng nhập vào không được âm");
                        return;
                    }
                    dgvGioHang.Rows[e.RowIndex].Cells[2].Value = currentQuantity;
                    dgvGioHang.Rows[e.RowIndex].Cells[4].Value = currentQuantity * int.Parse(dgvGioHang.Rows[e.RowIndex].Cells[1].Value.ToString());
                    TongTien();
                }
                else
                {
                    MessageBox.Show("Số lượng nhập vào không hợp lệ");
                }
            }
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.Rows.Count != 0)
            {
                busdh.themDH(tk.MaNguoiDung);
                long MaxDH = busdh.maxDH();
                foreach (DataGridViewRow item in dgvGioHang.Rows)
                {

                    if (item.Cells[0].Value != null && item.Cells[1].Value != null &&
                        item.Cells[2].Value != null)
                    {
                        busctdh.themCTDH(busSanPham.getMaMon(item.Cells[0].Value.ToString()),
                        int.Parse(item.Cells[2].Value.ToString()), MaxDH);
                    }
                }
                dgvGioHang.Rows.Clear();
                MessageBox.Show("Mua hàng thành công! Vui lòng kiểm tra ở lịch sử mua hàng.");
            }
            else
                MessageBox.Show("Vui lòng chọn hàng vào giỏ hàng!");
        }

        private void tsLichSuMuaHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new LSMH(tk);
            f.ShowDialog();
        }

        private void tsDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new DangNhap();
            f.ShowDialog();
        }

        private void tsThongTinCaNhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new ThongTinCaNhan(tk);
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
