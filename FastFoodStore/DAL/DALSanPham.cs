using FastFoodStore.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodStore.DAL
{
    public class DALSanPham:KetNoi
    {
        //Hiển thị món
        public DataTable getSanPham()
        {
            SqlDataAdapter cs = new SqlDataAdapter("SELECT * FROM Mon", kn);
            DataTable dsSanPham = new DataTable();
            cs.Fill(dsSanPham);
            return dsSanPham;
        }
        //Thêm món
        public bool themMon(DTOSanPham sp)
        {
            try
            {
                // Ket noi
                MoKetNoi();

                string SQL = "INSERT INTO Mon(MaMon, TenMon, Gia, SoLuong, Anh, NgayNhap, MaLoai) VALUES (@MaMon, @TenMon, @Gia, @SoLuong, @Anh, @NgayNhap, @MaLoai)";

                SqlCommand cmd = new SqlCommand(SQL, sqlConn);
                cmd.Parameters.AddWithValue("@MaMon", sp.MaMon);
                cmd.Parameters.AddWithValue("@TenMon", sp.TenMon);
                cmd.Parameters.AddWithValue("@Gia", sp.Gia);
                cmd.Parameters.AddWithValue("@SoLuong", sp.SoLuong);
                cmd.Parameters.AddWithValue("@Anh", sp.Anh);
                cmd.Parameters.AddWithValue("@NgayNhap", sp.NgayNhap);
                cmd.Parameters.AddWithValue("@MaLoai", sp.MaLoai);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                DongKetNoi();
            }

            return false;
        }
        //Sửa món
        public bool suaMon(DTOSanPham sp)
        {
            try
            {
                // Ket noi
                MoKetNoi();

                // Query string
                string SQL = "UPDATE Mon SET TenMon = @TenMon, Gia = @Gia, SoLuong = @SoLuong, Anh = @Anh, NgayNhap = @NgayNhap, MaLoai = @MaLoai WHERE MaMon = @MaMon";

                SqlCommand cmd = new SqlCommand(SQL, sqlConn);
                cmd.Parameters.AddWithValue("@MaMon", sp.MaMon);
                cmd.Parameters.AddWithValue("@TenMon", sp.TenMon);
                cmd.Parameters.AddWithValue("@Gia", sp.Gia);
                cmd.Parameters.AddWithValue("@SoLuong", sp.SoLuong);
                cmd.Parameters.AddWithValue("@Anh", sp.Anh);
                cmd.Parameters.AddWithValue("@NgayNhap", sp.NgayNhap);
                cmd.Parameters.AddWithValue("@MaLoai", sp.MaLoai);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                // Dong ket noi
                DongKetNoi();
            }

            return false;
        }
        //Xóa món
        public bool XoaMon(string MaMon)
        {
            try
            {
                // Ket noi
                MoKetNoi();

                string SQL = "DELETE FROM Mon WHERE MaMon = @MaMon";

                SqlCommand cmd = new SqlCommand(SQL, sqlConn);
                cmd.Parameters.AddWithValue("@MaMon", MaMon);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                DongKetNoi();
            }

            return false;
        }
        //Kiểm tra trùng mã
        public bool kiemTraTrungMa(string MaMon)
        {
            try
            {
                // Ket noi
                MoKetNoi();

                string SQL = "SELECT * FROM Mon WHERE MaMon = @MaMon";

                SqlCommand cmd = new SqlCommand(SQL, sqlConn);
                cmd.Parameters.AddWithValue("@MaMon", MaMon);

                // Query và kiểm tra
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                DongKetNoi();
            }

            return false;
        }
        //Tìm kiếm món
        public List<DTOSanPham> timKiemMon(string key)
        {
            List<DTOSanPham> ls = new List<DTOSanPham>();
            try
            {
                MoKetNoi();
                string sql = "SELECT * FROM Mon WHERE TenMon like @TenMon";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@TenMon", "%" + key + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string mamon = reader.GetString("MaMon");
                    string tenmon = reader.GetString("TenMon");
                    long gia = reader.GetInt64("Gia");
                    long soluong = reader.GetInt64("SoLuong");
                    string anh = reader.GetString("Anh");
                    DateTime ngaynhap = (DateTime)reader.GetDateTime("NgayNhap");
                    string maloai = reader.GetString("MaLoai");
                    ls.Add(new DTOSanPham(mamon, tenmon, gia, soluong, anh, ngaynhap, maloai));
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
        //Tìm kiếm loại
        public List<DTOSanPham> timKiemLoai(string key)
        {
            List<DTOSanPham> ls = new List<DTOSanPham>();
            try
            {
                MoKetNoi();
                string sql = "SELECT * FROM Loai LEFT JOIN Mon on Loai.MaLoai = Mon.MaLoai WHERE TenLoai = @TenLoai";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@TenLoai", key);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string mamon = reader.GetString("MaMon");
                    string tenmon = reader.GetString("TenMon");
                    long gia = reader.GetInt64("Gia");
                    long soluong = reader.GetInt64("SoLuong");
                    string anh = reader.GetString("Anh");
                    DateTime ngaynhap = (DateTime)reader.GetDateTime("NgayNhap");
                    string maloai = reader.GetString("MaLoai");
                    ls.Add(new DTOSanPham(mamon, tenmon, gia, soluong, anh, ngaynhap, maloai));
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
        //Lấy mã món
        public string getMaMon(string TenMon)
        {
            string MaMon="";
            try
            {
                MoKetNoi();
                string sql = "SELECT * FROM Mon WHERE TenMon = @TenMon";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@TenMon", TenMon);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MaMon = reader.GetString("MaMon");
                }
            }
            catch (Exception e) { }
            finally
            {
                // Dong ket noi
                DongKetNoi();
            }
            return MaMon;
        }
    }
}
