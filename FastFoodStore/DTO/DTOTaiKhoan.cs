using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodStore.DTO
{
    public class DTOTaiKhoan
    {
        public int MaNguoiDung {  get; set; }
        public string HoTen {  get; set; }
        public string DiaChi {  get; set; }
        public string SDT {  get; set; }
        public string Email {  get; set; }
        public string TenDN {  get; set; }
        public string MatKhau {  get; set; }
        public string Quyen { get; set;}
        public DTOTaiKhoan() { }
        public DTOTaiKhoan(int maNguoiDung, string hoTen, string diaChi, string sDT, string email, string tenDN, string matKhau, string quyen)
        {
            MaNguoiDung = maNguoiDung;
            HoTen = hoTen;
            DiaChi = diaChi;
            SDT = sDT;
            Email = email;
            TenDN = tenDN;
            MatKhau = matKhau;
            Quyen = quyen;
        }
    }
}
