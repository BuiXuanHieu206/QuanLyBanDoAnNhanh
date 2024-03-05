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
    public class DALLichSuMuaHang:KetNoi
    {
        //Hiển thị món
        public DataTable getLichSuMuaHang()
        {
            SqlDataAdapter cs = new SqlDataAdapter("SELECT * FROM ViewLichSuMuaHang ORDER BY MaDH DESC", kn);
            DataTable lsmh = new DataTable();
            cs.Fill(lsmh);
            return lsmh;
        }
        public List<DTOLichSuMuaHang> getLSMH_User(int MaND)
        {
            List<DTOLichSuMuaHang> ls = new List<DTOLichSuMuaHang>();
            try
            {
                MoKetNoi();
                string sql = "SELECT * FROM ViewLichSuMuaHang WHERE MaNguoiDung = @MaND ORDER BY MaDH DESC";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MaND", MaND);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int madh = reader.GetInt32("MaDH");
                    int mand = reader.GetInt32("MaNguoiDung");
                    int mactdh = reader.GetInt32("MaCTDH");
                    string tenmon = reader.GetString("TenMon");
                    long gia = reader.GetInt64("Gia");
                    long slm = reader.GetInt64("SoLuongMua");
                    long thanhtien = reader.GetInt64("ThanhTien");
                    DateTime ngaydathang = (DateTime)reader.GetDateTime("NgayDatHang");
                    bool damua = reader.GetBoolean("DaMua");
                    ls.Add(new DTOLichSuMuaHang(madh,mand,mactdh,tenmon,gia,slm,thanhtien,ngaydathang,damua));
                }
            }
            catch (Exception e) { }
            finally
            {
                // Dong ket noi
                DongKetNoi();
            }
            return ls;
        }
    }
}
