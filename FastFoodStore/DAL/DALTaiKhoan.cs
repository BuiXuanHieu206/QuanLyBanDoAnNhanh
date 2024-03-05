using FastFoodStore.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodStore.DAL
{
    public class DALTaiKhoan:KetNoi
    {   
        //Đăng nhập
        public DTOTaiKhoan dangNhap(string TenDN, string MatKhau)
        {
            DTOTaiKhoan tk = null;
            try
            {
                MoKetNoi();
                string sql = "SELECT * FROM TaiKhoan WHERE TenDN = @TenDN AND MatKhau = @MatKhau";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@TenDN", TenDN);
                cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tk = new DTOTaiKhoan();
                    tk.MaNguoiDung = reader.GetInt32("MaNguoiDung");
                    tk.HoTen = reader.GetString("HoTen");
                    tk.DiaChi = reader.GetString("DiaChi");
                    tk.SDT = reader.GetString("SDT");
                    tk.Email = reader.GetString("Email");
                    tk.TenDN = reader.GetString("TenDN");
                    tk.MatKhau = reader.GetString("MatKhau");
                    tk.Quyen = reader.GetString("Quyen");
                }
            }catch(Exception e) { }
            finally
            {
                // Dong ket noi
                DongKetNoi();
            }
            return tk;
        }
        //Đăng ký tài khoản
        public bool DangKy(DTOTaiKhoan tk)
        {
            try
            {
                // Ket noi
                MoKetNoi();

                string SQL = "INSERT INTO TaiKhoan(HoTen, DiaChi, SDT, Email,TenDN, MatKhau, Quyen) VALUES (@HoTen, @DiaChi, @SDT, @Email, @TenDN, @MatKhau, @Quyen)";

                SqlCommand cmd = new SqlCommand(SQL, sqlConn);
                cmd.Parameters.AddWithValue("@HoTen", tk.HoTen);
                cmd.Parameters.AddWithValue("@DiaChi", tk.DiaChi);
                cmd.Parameters.AddWithValue("@SDT", tk.SDT);
                cmd.Parameters.AddWithValue("@Email", tk.Email);
                cmd.Parameters.AddWithValue("@TenDN", tk.TenDN);
                cmd.Parameters.AddWithValue("@MatKhau", tk.MatKhau);
                cmd.Parameters.AddWithValue("@Quyen", tk.Quyen);

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
        //Kiểm tra email
        public bool kiemTraEmail(string Email)
        {
            try
            {
                // Ket noi
                MoKetNoi();

                string SQL = "SELECT * FROM TaiKhoan WHERE Email = @Email";

                SqlCommand cmd = new SqlCommand(SQL, sqlConn);
                cmd.Parameters.AddWithValue("@Email", Email);

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
        //Kiểm tra SĐT
        public bool kiemTraSDT(string SDT)
        {
            try
            {
                // Ket noi
                MoKetNoi();

                string SQL = "SELECT * FROM TaiKhoan WHERE SDT = @SDT";

                SqlCommand cmd = new SqlCommand(SQL, sqlConn);
                cmd.Parameters.AddWithValue("@SDT", SDT);

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
        //Kiểm tra tên đăng nhập
        public bool kiemTraTenDN(string TenDN)
        {
            try
            {
                // Ket noi
                MoKetNoi();

                string SQL = "SELECT * FROM TaiKhoan WHERE TenDN = @TenDN";

                SqlCommand cmd = new SqlCommand(SQL, sqlConn);
                cmd.Parameters.AddWithValue("@TenDN", TenDN);

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
        public bool doiMatKhau(int MaNguoiDung, string MatKhau)
        {
            try
            {
                MoKetNoi();

                using (SqlCommand cmd = new SqlCommand("update TaiKhoan set MatKhau=@MatKhau where MaNguoiDung=@MaNguoiDung", sqlConn))
                {
                    cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
                    cmd.Parameters.AddWithValue("@MaNguoiDung", MaNguoiDung);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                DongKetNoi();
            }

            return false;
        }
    }
}
