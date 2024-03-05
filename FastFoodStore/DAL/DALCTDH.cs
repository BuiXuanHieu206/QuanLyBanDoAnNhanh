using Microsoft.Data.SqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodStore.DAL
{
    public class DALCTDH:KetNoi
    {
        public int themCTDH(string MaMon, int SoLuongMua, long MaxDH)
        {
            try
            {
                MoKetNoi();
                string sql = "INSERT INTO ChiTietDonHang(MaDH, MaMon, SoLuongMua, DaMua)" +
                    " VALUES(@MaDH, @MaMon, @SLM, @DaMua)";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MaDH", MaxDH);
                cmd.Parameters.AddWithValue("@MaMon", MaMon);
                cmd.Parameters.AddWithValue("@SLM", SoLuongMua);
                cmd.Parameters.AddWithValue("@DaMua", true);
                int kq = cmd.ExecuteNonQuery();
                return kq;
            }
            catch (Exception e){}
            finally
            {
                DongKetNoi();
            }
            return 0;
        }
    }
}
