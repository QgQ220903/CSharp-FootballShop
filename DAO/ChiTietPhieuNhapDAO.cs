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
    public class ChiTietPhieuNhapDAO : DatabaseAccess
    {
        public List<ChiTietPhieuNhap> LayToanBoChiTietPhieuNhap()
        {
            List<ChiTietPhieuNhap> danhSachChiTietPhieuNhap = new List<ChiTietPhieuNhap>();
            try
            {
                string sql = "select * from chitietphieunhap";
                OpenConnection();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();
                    chiTietPhieuNhap.MaChiTietPhieuNhap = reader.GetInt32(0);
                    chiTietPhieuNhap.MaPhieuNhap = reader.GetInt32(1);
                    chiTietPhieuNhap.MaChiTietSanPham = reader.GetInt32(2);
                    chiTietPhieuNhap.SoLuong = reader.GetInt32(3);
                    chiTietPhieuNhap.DonVi = reader.GetString(4);
                    double tiennhap = reader.GetDouble(5);
                    chiTietPhieuNhap.GiaNhap = Convert.ToSingle(tiennhap);
                    double thanhtien = reader.GetDouble(6);
                    chiTietPhieuNhap.ThanhTien = Convert.ToSingle(thanhtien);
                    danhSachChiTietPhieuNhap.Add(chiTietPhieuNhap);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return danhSachChiTietPhieuNhap;
        }


        public List<ChiTietPhieuNhap> LayChiTietQuaMaPhieuNhap(int maPhieuNhap)
        {
            List<ChiTietPhieuNhap> danhSachChiTietPhieuNhap = new List<ChiTietPhieuNhap>();
            try
            {
                string sql = "select * from chitietphieunhap where maphieunhap = @maPhieuNhap";
                OpenConnection();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = conn;
                command.Parameters.Add("@MaPhieuNhap", SqlDbType.Int).Value = maPhieuNhap;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();
                    chiTietPhieuNhap.MaChiTietPhieuNhap = reader.GetInt32(0);
                    chiTietPhieuNhap.MaPhieuNhap = reader.GetInt32(1);
                    chiTietPhieuNhap.MaChiTietSanPham = reader.GetInt32(2);
                    chiTietPhieuNhap.SoLuong = reader.GetInt32(3);
                    chiTietPhieuNhap.DonVi = reader.GetString(4);
                    double tiennhap = reader.GetDouble(5);
                    chiTietPhieuNhap.GiaNhap = Convert.ToSingle(tiennhap);
                    double thanhtien = reader.GetDouble(6);
                    chiTietPhieuNhap.ThanhTien = Convert.ToSingle(thanhtien);
                    danhSachChiTietPhieuNhap.Add(chiTietPhieuNhap);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return danhSachChiTietPhieuNhap;
        }
        public bool ThemChiTietPhieuNhap(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            string sql = "insert into ChiTietPhieuNhap values(@MaPhieuNhap,@MaChiTietSanPham,@SoLuong,@donvi,@GiaNhap,@ThanhTien)";
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@MaPhieuNhap", SqlDbType.Int).Value = chiTietPhieuNhap.MaPhieuNhap;
            command.Parameters.Add("@MaChiTietSanPham", SqlDbType.Int).Value = chiTietPhieuNhap.MaChiTietSanPham;
            command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = chiTietPhieuNhap.SoLuong;
            command.Parameters.Add("@donvi", SqlDbType.NVarChar).Value = chiTietPhieuNhap.DonVi;
            command.Parameters.Add("@GiaNhap", SqlDbType.Float).Value = chiTietPhieuNhap.GiaNhap;
            command.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = chiTietPhieuNhap.ThanhTien;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        public bool XoaChiTietPhieuNhap(int maChiTietPhieuNhap)
        {
            string sql = "UPDATE ChiTietPhieuNhap SET TrangThai = 0 WHERE MaChiTietPhieuNhap = @maChiTietPhieuNhap";
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@maChiTietPhieuNhap", SqlDbType.Int).Value = maChiTietPhieuNhap;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        public bool SuaChiTietPhieuNhap(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            string sql = "UPDATE ChiTietPhieuNhap SET MaPhieuNhap = @maPhieuNhap, MaChiTietSanPham = @maChiTietSanPham, SoLuong = @SoLuong, DonVi = @donVi, GiaNhap = @GiaNhap, ThanhTien = @ThanhTien WHERE MaChiTietPhieuNhap = @maChiTietPhieuNhap";
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@MaPhieuNhap", SqlDbType.Int).Value = chiTietPhieuNhap.MaPhieuNhap;
            command.Parameters.Add("@MaChiTietSanPham", SqlDbType.Int).Value = chiTietPhieuNhap.MaChiTietSanPham;
            command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = chiTietPhieuNhap.SoLuong;
            command.Parameters.Add("@donvi", SqlDbType.NVarChar).Value = chiTietPhieuNhap.DonVi;
            command.Parameters.Add("@GiaNhap", SqlDbType.Float).Value = chiTietPhieuNhap.GiaNhap;
            command.Parameters.Add("@TongTien", SqlDbType.Float).Value = chiTietPhieuNhap.ThanhTien;
            command.Parameters.Add("@maChiTietPhieuNhap", SqlDbType.Int).Value = chiTietPhieuNhap.MaChiTietPhieuNhap;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }



    }
}
