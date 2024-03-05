using FastFoodStore.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodStore.DAL
{
    public class DALDoanhThu:KetNoi
    {
        public DataTable tkDoanhThu()
        {
            SqlDataAdapter cs = new SqlDataAdapter("select MaLoai, TenLoai, isnull(count(SoLuongMua),0) as TongSoLuong, isnull(sum(ThanhTien),0) as TongDoanhThu from ViewThongKeDoanhThu group by MaLoai, TenLoai order by MaLoai asc", kn);
            DataTable tkdt = new DataTable();
            cs.Fill(tkdt);
            return tkdt;
        }
        public long TongDoanhThu()
        {
            long tdt = 0;
            try
            {
                MoKetNoi();
                string sql = "select isnull(sum(ThanhTien),0) as TongDoanhThu from ViewThongKeDoanhThu";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConn;
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tdt = reader.GetInt64("TongDoanhThu");
                }
            }
            catch (Exception e) { }
            finally
            {
                // Dong ket noi
                DongKetNoi();
            }
            return tdt;
        }
    }
}
