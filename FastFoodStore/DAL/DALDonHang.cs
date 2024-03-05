using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodStore.DAL
{
    public class DALDonHang:KetNoi
    {
        public long maxDH()
        {
            try
            {   
                MoKetNoi();
                string sql = "SELECT MAX(MaDH) AS MaxDH  FROM DonHang";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConn;
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                long kq = 0;
                if (reader.Read())
                {
                    kq = reader.GetInt32("MaxDH");
                }
                return kq;
                DongKetNoi();
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public int themDH(int MaNguoiDung)
        {
            try
            {
                MoKetNoi();
                string sql = "INSERT INTO DonHang(MaNguoiDung,NgayDatHang,DaMua)" +
                    " VALUES(@MaND, @NgayDatHang, @DaMua)";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MaND", MaNguoiDung);
                cmd.Parameters.AddWithValue("@NgayDatHang", DateTime.Now);
                cmd.Parameters.AddWithValue("@DaMua", true);
                int kq = cmd.ExecuteNonQuery();
                return kq;
                DongKetNoi();
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
