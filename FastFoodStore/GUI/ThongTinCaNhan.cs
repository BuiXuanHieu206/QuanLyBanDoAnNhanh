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
    public partial class ThongTinCaNhan : Form
    {
        DTOTaiKhoan tk { get; set; }
        public ThongTinCaNhan(DTOTaiKhoan tk)
        {
            this.tk = tk;
            InitializeComponent();
            GUIThongTinCaNhan_Load();
        }
        private void GUIThongTinCaNhan_Load()
        {
            txtHoTen.Text = tk.HoTen.ToString();
            txtDiaChi.Text = tk.DiaChi.ToString();
            txtSDT.Text = tk.SDT.ToString();
            txtEmail.Text = tk.Email.ToString();
            txtQuyen.Text = tk.Quyen.ToString();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (tk.Quyen.Equals("Khách hàng"))
            {
                var f = new MenuKhachHang(tk);
                f.ShowDialog();
            }
            else
            {
                var f = new MenuAdmin(tk);
                f.ShowDialog();
            }
        }
    }
}
