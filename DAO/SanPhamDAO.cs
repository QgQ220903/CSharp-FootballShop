using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DAO
{
    public class SanPhamDAO : DatabaseAccess
    {

        // Lấy danh sách sản phẩm
        public List<SanPham> LayDanhSachSanPham()
        {
            List<SanPham> danhSachSanPham = new List<SanPham>();
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT  * FROM SanPham";
            command.Connection = conn;
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    SanPham sanPham = new SanPham();
                    sanPham.MaSanPham = reader.GetInt32(0);
                    sanPham.MaTheLoai = reader.GetInt32(1);
                    sanPham.MaNhaCungCap = reader.GetInt32(2);
                    sanPham.TenSanPham = reader.GetString(3);

                    double giaBan = reader.GetDouble(4);
                    double giaNhap = reader.GetDouble(5);
                    sanPham.GiaBan = Convert.ToSingle(giaBan);
                    sanPham.GiaNhap = Convert.ToSingle(giaNhap);
                    sanPham.SoLuongTon = reader.GetInt32(6);
                    sanPham.TrangThai = reader.GetInt32(7);
                    danhSachSanPham.Add(sanPham);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            reader.Close();
            CloseConnection();
            return danhSachSanPham;
        }

        public List<SanPham> LaySanPhamQuaNhaCungCap(int maNhaCungCap)
        {
            List<SanPham> danhSachSanPham = new List<SanPham>();
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT  * FROM SanPham where MaNhaCungCap = @maNhaCungCap";
            command.Connection = conn;
            command.Parameters.Add("@maNhaCungCap", SqlDbType.NVarChar).Value = maNhaCungCap;
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    SanPham sanPham = new SanPham();
                    sanPham.MaSanPham = reader.GetInt32(0);
                    sanPham.MaTheLoai = reader.GetInt32(1);
                    sanPham.MaNhaCungCap = reader.GetInt32(2);
                    sanPham.TenSanPham = reader.GetString(3);

                    double giaBan = reader.GetDouble(4);
                    double giaNhap = reader.GetDouble(5);
                    sanPham.GiaBan = Convert.ToSingle(giaBan);
                    sanPham.GiaNhap = Convert.ToSingle(giaNhap);
                    sanPham.SoLuongTon = reader.GetInt32(6);
                    sanPham.TrangThai = reader.GetInt32(7);
                    danhSachSanPham.Add(sanPham);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            reader.Close();
            CloseConnection();
            return danhSachSanPham;
        }

        public List<SanPham> LaySanPhamQuaNhaCungCap(int maNhaCungCap, string tenSanPham)
        {
            List<SanPham> danhSachSanPham = new List<SanPham>();
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT  * FROM SanPham where TenSanPham COLLATE Latin1_General_CI_AI like N'%" + tenSanPham + "%' AND TrangThai = 1 AND  MaNhaCungCap = @maNhaCungCap";
            command.Connection = conn;
            command.Parameters.Add("@maNhaCungCap", SqlDbType.NVarChar).Value = maNhaCungCap;
            command.Parameters.Add("@tenSanPham", SqlDbType.NVarChar).Value = tenSanPham;
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    SanPham sanPham = new SanPham();
                    sanPham.MaSanPham = reader.GetInt32(0);
                    sanPham.MaTheLoai = reader.GetInt32(1);
                    sanPham.MaNhaCungCap = reader.GetInt32(2);
                    sanPham.TenSanPham = reader.GetString(3);

                    double giaBan = reader.GetDouble(4);
                    double giaNhap = reader.GetDouble(5);
                    sanPham.GiaBan = Convert.ToSingle(giaBan);
                    sanPham.GiaNhap = Convert.ToSingle(giaNhap);
                    sanPham.SoLuongTon = reader.GetInt32(6);
                    sanPham.TrangThai = reader.GetInt32(7);
                    danhSachSanPham.Add(sanPham);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            reader.Close();
            CloseConnection();
            return danhSachSanPham;
        }


        // Thêm sản phẩm
        public bool ThemSanPham(SanPham sanPham)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO SanPham VALUES(@maTheLoai, @maNhaCungCap, @tenSanPham, @giaBan, @giaNhap, @soLuongTon, @trangThai)";
            command.Connection = conn;
            command.Parameters.Add("@tenSanPham", SqlDbType.NVarChar).Value = sanPham.TenSanPham;
            command.Parameters.Add("@maTheLoai", SqlDbType.NVarChar).Value = sanPham.MaTheLoai;
            command.Parameters.Add("@maNhaCungCap", SqlDbType.NVarChar).Value = sanPham.MaNhaCungCap;
            command.Parameters.Add("@giaBan", SqlDbType.NVarChar).Value = sanPham.GiaBan;
            command.Parameters.Add("@giaNhap", SqlDbType.NVarChar).Value = sanPham.GiaNhap;
            command.Parameters.Add("@soLuongTon", SqlDbType.NVarChar).Value = sanPham.SoLuongTon;
            command.Parameters.Add("@trangThai", SqlDbType.NVarChar).Value = sanPham.TrangThai;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }

        // Sửa sản phẩm
        public bool SuaSanPham(SanPham sanPham)
        {
            OpenConnection();
            string sql = "update SanPham set TenSanPham=@tenSanPham, MaTheLoai=@maTheLoai, MaNhaCungCap=@maNhaCungCap, GiaNhap=@giaNhap, GiaBan=@giaBan where MaSanPham=@MaSanPham";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = sanPham.MaSanPham;
            command.Parameters.Add("@maNhaCungCap", SqlDbType.Int).Value = sanPham.MaNhaCungCap;
            command.Parameters.Add("@maTheLoai", SqlDbType.Int).Value = sanPham.MaTheLoai;
            command.Parameters.Add("@tenSanPham", SqlDbType.NVarChar).Value = sanPham.TenSanPham;
            command.Parameters.Add("@giaNhap", SqlDbType.Float).Value = sanPham.GiaNhap;
            command.Parameters.Add("@giaBan", SqlDbType.Float).Value = sanPham.GiaBan;
            OpenConnection();
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }


        // Cập nhật số lượng
        public bool CapNhatSoLuong(SanPham sanPham)
        {
            string sql = "update SanPham set SoLuongTon=@soLuongTon where MaSanPham=@MaSanPham";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = sanPham.MaSanPham;
            command.Parameters.Add("@soLuongTon", SqlDbType.Int).Value = sanPham.SoLuongTon;
            OpenConnection();
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }
        // Xóa sản phẩm
        public bool XoaSanPham(int maSanPham)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE SanPham SET TrangThai = 0 WHERE MaSanPham = @maSanPham";
            command.Connection = conn;
            command.Parameters.Add("@maSanPham", SqlDbType.Int).Value = maSanPham;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }



        public List<SanPham> TimKiemSanPham(string text)
        {
            List<SanPham> arraysanpham = new List<SanPham>();
            string sql = "select * from SanPham where concat(MaSanPham, TenSanPham) COLLATE Latin1_General_CI_AI like N'%" + text + "%'";

            command = new SqlCommand(sql, conn);
            OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                double gsp, gn;
                SanPham sanpham = new SanPham();
                sanpham.MaSanPham = reader.GetInt32(0);
                sanpham.MaTheLoai = reader.GetInt32(1);
                sanpham.MaNhaCungCap = reader.GetInt32(2);
                sanpham.TenSanPham = reader.GetString(3);
                gsp = reader.GetDouble(4);
                sanpham.GiaBan = Convert.ToSingle(gsp);
                gn = reader.GetDouble(5);
                sanpham.GiaNhap = Convert.ToSingle(gn);
                sanpham.SoLuongTon = reader.GetInt32(6);
                sanpham.TrangThai = reader.GetInt32(7);
                arraysanpham.Add(sanpham);
            }
            CloseConnection();
            return arraysanpham;
        }


        public List<SanPham> TimKiemSanPhamTheoTen(string text)
        {
            List<SanPham> arraysanpham = new List<SanPham>();
            string sql = "SELECT * FROM SanPham WHERE TenSanPham LIKE N'%" + text + "%'";

            command = new SqlCommand(sql, conn);
            OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                double gsp, gn;
                SanPham sanpham = new SanPham();
                sanpham.MaSanPham = reader.GetInt32(0);
                sanpham.MaTheLoai = reader.GetInt32(1);
                sanpham.MaNhaCungCap = reader.GetInt32(2);
                sanpham.TenSanPham = reader.GetString(3);
                gsp = reader.GetDouble(4);
                sanpham.GiaBan = Convert.ToSingle(gsp);
                gn = reader.GetDouble(5);
                sanpham.GiaNhap = Convert.ToSingle(gn);
                sanpham.SoLuongTon = reader.GetInt32(6);
                sanpham.TrangThai = reader.GetInt32(7);
                arraysanpham.Add(sanpham);
            }
            CloseConnection();
            return arraysanpham;
        }




    }
}
