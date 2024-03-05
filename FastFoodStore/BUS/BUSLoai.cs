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
    public class BUSLoai
    {
        DALLoai dalloai = new DALLoai();

        public DataTable getLoai()
        {
            return dalloai.getLoai();
        }
        public bool themLoai(DTOLoai loai)
        {
            return dalloai.themLoai(loai);
        }
        public bool suaLoai(DTOLoai loai)
        {
            return dalloai.suaLoai(loai);
        }
        public bool xoaLoai(string MaLoai)
        {
            return dalloai.xoaLoai(MaLoai);
        }
        public bool kiemTraTrungMa(string MaLoai)
        {
            return dalloai.kiemTraTrungMa(MaLoai);
        }
    }
}
