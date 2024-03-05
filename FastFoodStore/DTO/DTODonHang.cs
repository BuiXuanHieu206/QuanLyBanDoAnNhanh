using FastFoodStore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodStore.DTO
{
    public class DTODonHang:KetNoi
    {
        public int MaDH { get; set; }
        public int MaNguoiDung {  get; set; }
        public DateTime NgayDatHang {  get; set; }
        public bool DaMua {  get; set; }
        public DTODonHang() { }
        public DTODonHang(int maDH, int maNguoiDung, DateTime ngayDatHang, bool daMua)
        {
            MaDH = maDH;
            MaNguoiDung = maNguoiDung;
            NgayDatHang = ngayDatHang;
            DaMua = daMua;
        }
    }
}
