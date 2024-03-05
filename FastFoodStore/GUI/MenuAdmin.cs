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
    public partial class MenuAdmin : Form
    {
        public DTOTaiKhoan tk { get; set; }
        public MenuAdmin(DTOTaiKhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
        }

        private void btnQuanLyLoai_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new QuanLyLoai(tk);
            f.ShowDialog();
        }

        private void btnQuanLySanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new QuanLySanPham(tk);
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

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new ThongKeDoanhThu(tk);
            f.ShowDialog();
        }

        private void btnThongKeHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new LichSuMuaHang(tk);
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
