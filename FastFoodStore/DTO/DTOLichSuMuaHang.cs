using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodStore.DTO
{
    public class DTOLichSuMuaHang
    {
        public int MaDH { get; set; }
        public int MaNguoiDung {  get; set; }
        public int MaCTDH {  get; set; }
        public string TenMon {  get; set; }
        public long Gia {  get; set; }
        public long SoLuongMua {  get; set; }
        public long ThanhTien { get; set; }
        public DateTime NgayDatHang { get; set; }
        public bool DaMua { get; set; }
        public DTOLichSuMuaHang() { }
        public DTOLichSuMuaHang(int maDH, int maNguoiDung, int maCTDH, string tenMon, long gia, long soLuongMua, long thanhTien, DateTime ngayDatHang, bool daMua)
        {
            MaDH = maDH;
            MaNguoiDung = maNguoiDung;
            MaCTDH = maCTDH;
            TenMon = tenMon;
            Gia = gia;
            SoLuongMua = soLuongMua;
            ThanhTien = thanhTien;
            NgayDatHang = ngayDatHang;
            DaMua = daMua;
        }
    }
}
