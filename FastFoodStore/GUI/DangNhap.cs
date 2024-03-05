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

namespace FastFoodStore
{
    public partial class DangNhap : Form
    {
        BUSTaiKhoan bustk = new BUSTaiKhoan();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text != "" && txtMatKhau.Text != "")
            {
                DTOTaiKhoan tk = bustk.dangNhap(txtTenDN.Text, txtMatKhau.Text);
                if (tk != null)
                {
                    if (tk.Quyen.Equals("Admin"))
                    {
                        this.Hide();
                        var f = new MenuAdmin(tk);
                        f.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        var f = new MenuKhachHang(tk);
                        f.ShowDialog();
                    }
                }
                else
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new DangKy();
            f.ShowDialog();
        }
    }
}
