using FastFoodStore.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodStore.DAL
{
    public class DALLoai:KetNoi
    {
        //Lấy danh sách loại
        public DataTable getLoai()
        {
            SqlDataAdapter cs = new SqlDataAdapter("SELECT * FROM Loai", kn);
            DataTable dsLoai = new DataTable();
            cs.Fill(dsLoai);
            return dsLoai;
        }
        //Thêm loại
        public bool themLoai(DTOLoai loai)
        {
            try
            {
                // Ket noi
                MoKetNoi();
                
                string SQL = "INSERT INTO Loai(MaLoai, TenLoai) VALUES (@MaLoai, @TenLoai)";

                SqlCommand cmd = new SqlCommand(SQL, sqlConn);
                cmd.Parameters.AddWithValue("@MaLoai", loai.MaLoai);
                cmd.Parameters.AddWithValue("@TenLoai", loai.TenLoai);

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
        //Sửa loại
        public bool suaLoai(DTOLoai loai)
        {
            try
            {
                // Ket noi
                MoKetNoi();

                // Query string
                string SQL = "UPDATE Loai SET TenLoai = @TenLoai WHERE MaLoai = @MaLoai";

                SqlCommand cmd = new SqlCommand(SQL, sqlConn);
                cmd.Parameters.AddWithValue("@MaLoai", loai.MaLoai);
                cmd.Parameters.AddWithValue("@TenLoai", loai.TenLoai);

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
        //Xóa loại
        public bool xoaLoai(string MaLoai)
        {
            try
            {
                // Ket noi
                MoKetNoi();

                string SQL = "DELETE FROM Loai WHERE MALOAI = @MaLoai";

                SqlCommand cmd = new SqlCommand(SQL, sqlConn);
                cmd.Parameters.AddWithValue("@MaLoai", MaLoai);

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
        public bool kiemTraTrungMa(string MaLoai)
        {
            try
            {
                // Ket noi
                MoKetNoi();

                string SQL = "SELECT * FROM Loai WHERE MaLoai = @MaLoai";

                SqlCommand cmd = new SqlCommand(SQL, sqlConn);
                cmd.Parameters.AddWithValue("@MaLoai", MaLoai);

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
    }
}
