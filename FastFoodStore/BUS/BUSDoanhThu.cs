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
    public class BUSDoanhThu
    {
        DALDoanhThu daldt = new DALDoanhThu();
        public DataTable tkDoanhThu()
        {
            return daldt.tkDoanhThu();
        }
        public long TongDoanhThu()
        {
            return daldt.TongDoanhThu();
        }
    }
}
