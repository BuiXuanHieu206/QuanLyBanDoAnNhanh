using FastFoodStore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodStore.BUS
{
    public class BUSCTDH
    {
        DALCTDH dalctdh = new DALCTDH();
        public int themCTDH(string MaMon, int SoLuongMua, long MaxDH)
        {
            return dalctdh.themCTDH(MaMon, SoLuongMua, MaxDH);
        }
    }
}
