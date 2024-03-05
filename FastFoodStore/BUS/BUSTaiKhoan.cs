using FastFoodStore.DAL;
using FastFoodStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodStore.BUS
{
    public class BUSTaiKhoan
    {
        DALTaiKhoan daltk = new DALTaiKhoan();

        public DTOTaiKhoan dangNhap(string TenDN, string MatKhau)
        {
            return daltk.dangNhap(TenDN, MatKhau);
        }
        public bool DangKy(DTOTaiKhoan tk)
        {
            return daltk.DangKy(tk);
        }
        public bool kiemTraEmail(string Email)
        {
            return daltk.kiemTraEmail(Email);
        }
        public bool kiemTraSDT(string SDT)
        {
            return daltk.kiemTraSDT(SDT);
        }
        public bool kiemTraTenDN(string TenDN)
        {
            return daltk.kiemTraTenDN(TenDN);
        }
        public bool doiMatKhau(int MaNguoiDung, string MatKhau)
        {
            return daltk.doiMatKhau(MaNguoiDung, MatKhau);
        }
    }
}
