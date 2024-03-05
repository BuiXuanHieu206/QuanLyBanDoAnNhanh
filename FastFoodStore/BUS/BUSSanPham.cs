using FastFoodStore.DAL;
using FastFoodStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodStore.BUS
{
    public class BUSSanPham
    {
        DALSanPham dalSanPham = new DALSanPham();

        public DataTable getSanPham()
        {
            return dalSanPham.getSanPham();
        }
        public bool themMon(DTOSanPham sp)
        {
            return dalSanPham.themMon(sp);
        }
        public bool suaMon(DTOSanPham sp)
        {
            return dalSanPham.suaMon(sp);
        }
        public bool XoaMon(string MaMon)
        {
            return dalSanPham.XoaMon(MaMon);
        }
        public bool kiemTraTrungMa(string MaMon)
        {
            return dalSanPham.kiemTraTrungMa(MaMon);
        }
        public List<DTOSanPham> timKiemMon(string key)
        {
            return dalSanPham.timKiemMon(key);
        }
        public List<DTOSanPham> timKiemLoai(string key)
        {
            return dalSanPham.timKiemLoai(key);
        }
        public string getMaMon(string TenMon)
        {
            return dalSanPham.getMaMon(TenMon);
        }
    } 
}
