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
    public partial class DangKy : Form
    {
        BUSTaiKhoan bustk = new BUSTaiKhoan();
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new DangNhap();
            f.ShowDialog();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text != "" && txtMatKhau.Text != "" && txtHoTen.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && txtEmail.Text != "")
            {
                if (bustk.kiemTraTenDN(txtTenDN.Text))
                    MessageBox.Show("Tên đăng nhập đã tồn tại!");
                else if (bustk.kiemTraSDT(txtSDT.Text))
                    MessageBox.Show("Số điện thoại đã tồn tại!");
                else if (bustk.kiemTraEmail(txtEmail.Text))
                    MessageBox.Show("Email đã tồn tại!");
                else
                {
                    DTOTaiKhoan tk = new DTOTaiKhoan(1, txtHoTen.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, txtTenDN.Text, txtMatKhau.Text, "Khách hàng");
                    if (bustk.DangKy(tk))
                    {
                        MessageBox.Show("Đăng ký tài khoản thành công!");
                        this.Hide();
                        var f = new DangNhap();
                        f.ShowDialog();
                    }
                    else
                        MessageBox.Show("Đăng ký tài khoản thất bại!" + bustk.DangKy(tk));
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        }
    }
}
