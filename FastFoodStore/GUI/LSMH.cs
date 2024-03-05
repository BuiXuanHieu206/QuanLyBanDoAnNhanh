using FastFoodStore.BUS;
using FastFoodStore.DAL;
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
    public partial class LSMH : Form
    {
        BUSLichSuMuaHang buslsmh = new BUSLichSuMuaHang();
        public DTOTaiKhoan tk { get; set; }
        public LSMH(DTOTaiKhoan tk)
        {
            this.tk = tk;
            InitializeComponent();
            GUIHoTen_Load();
            GUILichSuMuaHang_Load();
        }
        void GUIHoTen_Load()
        {
            lblHoTen.Text = tk.HoTen.ToString();
        }
        private void GUILichSuMuaHang_Load()
        {
            dgvLSMH.DataSource = buslsmh.getLSMH_User(tk.MaNguoiDung); // Lấy loại
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new MenuKhachHang(tk);
            f.ShowDialog();
        }
    }
}
