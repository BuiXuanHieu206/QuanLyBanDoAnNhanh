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
    public partial class DoiMatKhau : Form
    {
        DTOTaiKhoan tk { get; set; }
        BUSTaiKhoan bustk = new BUSTaiKhoan();
        public DoiMatKhau(DTOTaiKhoan tk)
        {
            this.tk = tk;
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string mkc = txtMatKhauCu.Text;
            string mkm = txtMatKhauMoi.Text;
            string nlmk = txtNhapLaiMatKhau.Text;
            if (mkc != "" && mkm != "" && nlmk != "")
            {
                if (mkc.Equals(tk.MatKhau))
                {
                    if (mkm.Equals(nlmk))
                    {
                        if (bustk.doiMatKhau(tk.MaNguoiDung, mkm))
                        {
                            MessageBox.Show("Đổi mật khẩu thành công!");
                            txtMatKhauCu.Text = "";
                            txtMatKhauMoi.Text = "";
                            txtNhapLaiMatKhau.Text = "";
                        }
                        else
                            MessageBox.Show("Đổi mật khẩu thất bại!");
                    }
                    else
                        MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu không trùng khớp!");
                }
                else
                    MessageBox.Show("Mật khẩu cũ không chính xác, vui lòng nhập lại!");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            if(tk.Quyen.Equals("Khách hàng"))
            {
                this.Hide();
                var f = new MenuKhachHang(tk);
                f.ShowDialog();
            }
            else
            {
                this.Hide();
                var f = new MenuAdmin(tk);
                f.ShowDialog();
            }
        }
    }
}
