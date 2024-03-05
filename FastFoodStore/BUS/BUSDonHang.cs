using FastFoodStore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodStore.BUS
{
    public class BUSDonHang
    {
        DALDonHang daldh = new DALDonHang();
        public long maxDH()
        {
            return daldh.maxDH();
        }
        public int themDH(int MaNguoiDung)
        {
            return daldh.themDH(MaNguoiDung);
        }
    }
}
