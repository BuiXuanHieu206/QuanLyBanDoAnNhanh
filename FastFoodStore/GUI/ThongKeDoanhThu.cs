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
    public partial class ThongKeDoanhThu : Form
    {
        DTOTaiKhoan tk { get; set; }
        BUSDoanhThu busdt = new BUSDoanhThu();
        public ThongKeDoanhThu(DTOTaiKhoan tk)
        {
            this.tk = tk;
            InitializeComponent();
            GUIDoanhThu_Load();
            lblTongDT.Text = busdt.TongDoanhThu().ToString("N0") + " đồng";
        }
        private void GUIDoanhThu_Load()
        {
            dgvDoanhThu.DataSource = busdt.tkDoanhThu();
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
