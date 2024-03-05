using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodStore.DTO
{
    public class DTODoanhThu
    {
        public string MaLoai {  get; set; }
        public string TenLoai {  get; set; }
        public long TongSoLuong {  get; set; }
        public long TongDoanhThu {  get; set; }
        public DTODoanhThu() { }
        public DTODoanhThu(string maLoai, string tenLoai, long tongSoLuong, long tongDoanhThu)
        {
            MaLoai = maLoai;
            TenLoai = tenLoai;
            TongSoLuong = tongSoLuong;
            TongDoanhThu = tongDoanhThu;
        }
    }
}
