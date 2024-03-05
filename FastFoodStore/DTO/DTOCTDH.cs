using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodStore.DTO
{
    public class DTOCTDH
    {
        public int MaCTDH {  get; set; }
        public int MaHD { get; set; }
        public string MaMon {  get; set; }
        public long SoLuongMua {  get; set; }
        public bool DaMua {  get; set; }
        public DTOCTDH() { }
        public DTOCTDH(int maCTDH, int maHD, string maMon, long soLuongMua, bool daMua)
        {
            MaCTDH = maCTDH;
            MaHD = maHD;
            MaMon = maMon;
            SoLuongMua = soLuongMua;
            DaMua = daMua;
        }
    }
}
