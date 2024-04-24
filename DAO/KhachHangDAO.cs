using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO : DatabaseAccess
    {
        public List<KhachHang> LayDanhSachKhachHang()
        {
            List<KhachHang> danhSachKhachHang = new List<KhachHang>();
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM KhachHang";
            command.Connection = conn;
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    int maKhachHang = reader.GetInt32(0);
                    string tenKhachHang = reader.GetString(1);
                    string soDienThoai = reader.GetString(2);
                    int trangThai = reader.GetInt32(3);
                    KhachHang khachHang = new KhachHang();
                    khachHang.MaKhachHang = maKhachHang;
                    khachHang.TenKhachHang = tenKhachHang;
                    khachHang.SoDienThoai = soDienThoai;
                    khachHang.TrangThai = trangThai;

                    danhSachKhachHang.Add(khachHang);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            reader.Close();
            CloseConnection();
            return danhSachKhachHang;
        }

        public bool ThemKhachHang(KhachHang khachHang)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO KhachHang VALUES(@tenKhachHang, @soDienThoai, 1)";
            command.Connection = conn;
            command.Parameters.Add("@tenKhachHang", SqlDbType.NVarChar).Value = khachHang.TenKhachHang;
            command.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = khachHang.SoDienThoai;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }

        public bool SuaKhachHang(KhachHang khachHang)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE KhachHang SET TenKhachHang = @tenKhachHang, SoDienThoai = @soDienThoai,  TrangThai = 1 WHERE MaKhachHang = @maKhachHang";
            command.Connection = conn;
            command.Parameters.Add("@tenKhachHang", SqlDbType.NVarChar).Value = khachHang.TenKhachHang;
            command.Parameters.Add("@soDienThoai", SqlDbType.NVarChar).Value = khachHang.SoDienThoai;
            command.Parameters.Add("@maKhachHang", SqlDbType.Int).Value = khachHang.MaKhachHang;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }

        

        public bool XoaKhachHang(KhachHang khachHang)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE KhachHang SET TrangThai = 0 WHERE MaKhachHang = @maKhachHang";
            command.Connection = conn;
            command.Parameters.Add("@maKhachHang", SqlDbType.Int).Value = khachHang.MaKhachHang;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;

        }

        public List<KhachHang> TimKiemKhachHang(string text)
        {
            List<KhachHang> danhSachKhachHang = new List<KhachHang>();
            OpenConnection();
            string sql = "select * from KhachHang where concat(TenKhachHang,SoDienThoai) COLLATE Latin1_General_CI_AI like N'%" + text + "%' AND TrangThai = 1";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maKhachHang = reader.GetInt32(0);
                string tenKhachHang = reader.GetString(1);
                string soDienThoai = reader.GetString(2);
                int trangThai = reader.GetInt32(3);
                KhachHang khachHang = new KhachHang();
                khachHang.MaKhachHang = maKhachHang;
                khachHang.TenKhachHang = tenKhachHang;
                khachHang.SoDienThoai = soDienThoai;
                khachHang.TrangThai = trangThai;

                danhSachKhachHang.Add(khachHang);
            }
            CloseConnection();
            return danhSachKhachHang;
        }

    }
}
