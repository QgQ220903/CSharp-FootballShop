using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietSanPhamDAO : DatabaseAccess
    {
        public List<ChiTietSanPham> LayToanBoChiTietSanPham()
        {
            List<ChiTietSanPham> danhSachChiTietSanPham = new List<ChiTietSanPham>();
            try
            {
                OpenConnection();
                string sql = "Select * from ChiTietSanPham";
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChiTietSanPham chiTietSanPham = new ChiTietSanPham();
                    chiTietSanPham.MaChiTietSanPham = reader.GetInt32(0);
                    chiTietSanPham.MaSanPham = reader.GetInt32(1);
                    chiTietSanPham.MaMauSac = reader.GetInt32(2);
                    chiTietSanPham.MaKichCo = reader.GetInt32(3);
                    chiTietSanPham.HinhAnh = (byte[])reader["HinhAnh"];
                    chiTietSanPham.SoLuongTon = reader.GetInt32(5);
                    chiTietSanPham.TrangThai = reader.GetInt32(6);
                    danhSachChiTietSanPham.Add(chiTietSanPham);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return danhSachChiTietSanPham;
        }

        public List<ChiTietSanPham> LayToanBoCTSPTheoSLT()
        {
            List<ChiTietSanPham> danhSachChiTietSanPham = new List<ChiTietSanPham>();
            try
            {
                OpenConnection();
                string sql = "Select * from ChiTietSanPham order by SoLuongTon";
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChiTietSanPham chiTietSanPham = new ChiTietSanPham();
                    chiTietSanPham.MaChiTietSanPham = reader.GetInt32(0);
                    chiTietSanPham.MaSanPham = reader.GetInt32(1);
                    chiTietSanPham.MaMauSac = reader.GetInt32(2);
                    chiTietSanPham.MaKichCo = reader.GetInt32(3);
                    chiTietSanPham.HinhAnh = (byte[])reader["HinhAnh"];
                    chiTietSanPham.SoLuongTon = reader.GetInt32(5);
                    chiTietSanPham.TrangThai = reader.GetInt32(6);
                    danhSachChiTietSanPham.Add(chiTietSanPham);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return danhSachChiTietSanPham;
        }
        public List<ChiTietSanPham> TimKiemChiTietTheoMa(int maChiTietSanPham)
        {
            List<ChiTietSanPham> danhSachChiTietSanPham = new List<ChiTietSanPham>();
            try
            {
                OpenConnection();
                string sql = "Select * from ChiTietSanPham where MaChiTietSanPham = @maChiTietSanPham";
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = conn;
                command.Parameters.Add("@maChiTietSanPham", SqlDbType.Int).Value = maChiTietSanPham;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChiTietSanPham chiTietSanPham = new ChiTietSanPham();
                    chiTietSanPham.MaChiTietSanPham = reader.GetInt32(0);
                    chiTietSanPham.MaSanPham = reader.GetInt32(1);
                    chiTietSanPham.MaMauSac = reader.GetInt32(2);
                    chiTietSanPham.MaKichCo = reader.GetInt32(3);
                    chiTietSanPham.HinhAnh = (byte[])reader["HinhAnh"];
                    chiTietSanPham.SoLuongTon = reader.GetInt32(5);
                    chiTietSanPham.TrangThai = reader.GetInt32(6);
                    danhSachChiTietSanPham.Add(chiTietSanPham);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return danhSachChiTietSanPham;
        }

        public bool ThemChiTietSanPham(ChiTietSanPham chiTietSanPham)
        {
            OpenConnection();
            string sql = "insert into ChiTietSanPham values(@MaSanPham,@MaMauSac,@MaKichCo,@HinhAnh,@SoLuongTon, @TrangThai)";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = chiTietSanPham.MaSanPham;
            command.Parameters.Add("@MaMauSac", SqlDbType.Int).Value = chiTietSanPham.MaMauSac;
            command.Parameters.Add("@MaKichCo", SqlDbType.Int).Value = chiTietSanPham.MaKichCo;
            command.Parameters.Add("@HinhAnh", SqlDbType.Image).Value = chiTietSanPham.HinhAnh;
            command.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = chiTietSanPham.SoLuongTon;
            command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = chiTietSanPham.TrangThai;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;

        }

        public bool SuaChiTietSanPham(ChiTietSanPham chiTietSanPham)
        {
            OpenConnection();
            string sql = "UPDATE ChiTietSanPham SET MaMauSac = @maMauSac, MaKichCo = @maKichCo, HinhAnh = @hinhAnh WHERE MaChiTietSanPham = @maChiTietSanPham";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@maMauSac", SqlDbType.Int).Value = chiTietSanPham.MaMauSac;
            command.Parameters.Add("@maKichCo", SqlDbType.Int).Value = chiTietSanPham.MaKichCo;
            command.Parameters.Add("@hinhAnh", SqlDbType.Image).Value = chiTietSanPham.HinhAnh;
            command.Parameters.Add("@maChiTietSanPham", SqlDbType.Int).Value = chiTietSanPham.MaChiTietSanPham;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        public bool CapNhatSoLuong(ChiTietSanPham chiTietSanPham)
        {
            OpenConnection();
            string sql = "UPDATE ChiTietSanPham SET SoLuongTon = @soLuongTon WHERE MaChiTietSanPham = @maChiTietSanPham";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@soLuongTon", SqlDbType.Int).Value = chiTietSanPham.SoLuongTon;
            command.Parameters.Add("@maChiTietSanPham", SqlDbType.Int).Value = chiTietSanPham.MaChiTietSanPham;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }



        public bool XoaChiTietSanPham(int maChiTietSanPham)
        {
            string sql = "UPDATE ChiTietSanPham SET TrangThai = 0 WHERE MaChiTietSanPham = @maChiTietSanPham";
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@maChiTietSanPham", SqlDbType.Int).Value = maChiTietSanPham;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        public bool XoaChiTietSanPhamTheoMaSanPham(int maSanPham)
        {
            string sql = "UPDATE ChiTietSanPham SET TrangThai = 0 WHERE MaSanPham = @maSanPham";
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@maSanPham", SqlDbType.Int).Value = maSanPham;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }


        public List<ChiTietSanPham> TimKiem(string text)
        {
            OpenConnection();
            List<ChiTietSanPham> danhSachChiTietSanPham = new List<ChiTietSanPham>();
            string sql = "select * from ChiTietSanPham where like '%" + text + "%'";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                ChiTietSanPham chiTietSanPham = new ChiTietSanPham();
                chiTietSanPham.MaChiTietSanPham = reader.GetInt32(0);
                chiTietSanPham.MaSanPham = reader.GetInt32(1);
                chiTietSanPham.MaMauSac = reader.GetInt32(2);
                chiTietSanPham.MaKichCo = reader.GetInt32(3);
                chiTietSanPham.HinhAnh = (byte[])reader["HinhAnh"];
                chiTietSanPham.SoLuongTon = reader.GetInt32(7);
                danhSachChiTietSanPham.Add(chiTietSanPham);
            }
            CloseConnection();
            return danhSachChiTietSanPham;
        }

        // cập nhật số lượng chi tiết sản phẩm
        public bool capNhatSoLuong(int maChiTietSanPham, int soLuongNhap, int soLuongTon)
        {
            string sql = "UPDATE ChiTietSanPham SET SoLuongNhap = @soLuongNhap, SoLuongTon = @soLuongTon  WHERE MaChiTietSanPham = @maChiTietSanPham";
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@soLuongNhap", SqlDbType.Int).Value = soLuongNhap;
            command.Parameters.Add("@soLuongTon", SqlDbType.Int).Value = soLuongTon;
            command.Parameters.Add("@maChiTietSanPham", SqlDbType.Int).Value = maChiTietSanPham;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }



    }
}
