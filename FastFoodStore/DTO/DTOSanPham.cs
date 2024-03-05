using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodStore.DTO
{
    public class DTOSanPham
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public long Gia { get; set; }
        public long SoLuong { get; set; }
        public string Anh { get; set; }
        public DateTime NgayNhap { get; set; }
        public string MaLoai { get; set; }
        public DTOSanPham(){}
        public DTOSanPham(string MaMon, string TenMon, long Gia, long SoLuong, string Anh, DateTime NgayNhap, string MaLoai)
        {
            this.MaMon = MaMon;
            this.TenMon = TenMon;
            this.Gia = Gia;
            this.SoLuong = SoLuong;
            this.Anh = Anh;
            this.NgayNhap = NgayNhap;
            this.MaLoai = MaLoai;
        }

    }
}
