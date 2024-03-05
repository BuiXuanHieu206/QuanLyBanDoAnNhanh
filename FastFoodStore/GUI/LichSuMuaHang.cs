using FastFoodStore.BUS;
using FastFoodStore.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodStore.GUI
{
    public partial class LichSuMuaHang : Form
    {
        BUSLichSuMuaHang buslsmh = new BUSLichSuMuaHang();
        DTOTaiKhoan tk { get; set; }
        public LichSuMuaHang(DTOTaiKhoan tk)
        {
            this.tk = tk;
            InitializeComponent();
            GUILichSuMuaHang_Load();
        }
        private void GUILichSuMuaHang_Load()
        {
            dgvLichSuMuaHang.DataSource = buslsmh.getLichSuMuaHang(); // Lấy loại
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

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new MenuAdmin(tk);
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
