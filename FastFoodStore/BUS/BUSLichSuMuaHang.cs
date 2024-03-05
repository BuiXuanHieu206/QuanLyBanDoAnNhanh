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
    public class BUSLichSuMuaHang
    {
        DALLichSuMuaHang dallsmh = new DALLichSuMuaHang();
        public DataTable getLichSuMuaHang()
        {
            return dallsmh.getLichSuMuaHang();
        }
        public List<DTOLichSuMuaHang> getLSMH_User(int MaND)
        {
            return dallsmh.getLSMH_User(MaND);
        }
    }
}
