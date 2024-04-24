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
    public class MauSacDAO : DatabaseAccess
    {
        // Lấy danh sách màu sắc
        public List<MauSac> LayDanhSachMauSac()
        {
            List<MauSac> danhSachMauSac = new List<MauSac>();
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT *  FROM MAUSAC";
            command.Connection = conn;
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    int maMauSac = reader.GetInt32(0);
                    string tenMauSac = reader.GetString(1);
                    int trangThai = reader.GetInt32(2);
                    MauSac mauSac = new MauSac();
                    mauSac.MaMauSac = maMauSac;
                    mauSac.TenMauSac = tenMauSac;
                    mauSac.TrangThai = trangThai;

                    danhSachMauSac.Add(mauSac);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            reader.Close();
            CloseConnection();
            return danhSachMauSac;
        }

        // Thêm màu sắc
        public bool ThemMauSac(MauSac mauSac)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO MauSac VALUES(@tenMauSac, @trangThai)";
            command.Connection = conn;
            command.Parameters.Add("@tenMauSac", SqlDbType.NVarChar).Value = mauSac.TenMauSac;
            command.Parameters.Add("@trangThai", SqlDbType.Int).Value = mauSac.TrangThai;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }

        // Sửa màu sắc
        public bool SuaMauSac(MauSac mauSac)
        {
            int ketQua;
            try
            {
                OpenConnection();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE MauSac SET TenMauSac = @tenMauSac, TrangThai = @trangThai WHERE MaMauSac = @maMauSac";
                command.Connection = conn;
                command.Parameters.Add("@tenMauSac", SqlDbType.NVarChar).Value = mauSac.TenMauSac;
                command.Parameters.Add("@trangThai", SqlDbType.Int).Value = mauSac.TrangThai;
                command.Parameters.Add("@maMauSac", SqlDbType.Int).Value = mauSac.MaMauSac;
                ketQua = command.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return ketQua > 0;
        }

        //Xóa màu sắc
        public bool XoaMauSac(MauSac mauSac)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE MauSac SET TRANGTHAI = 0 WHERE MaMauSac = @maMauSac";
            command.Connection = conn;
            command.Parameters.Add("@maMauSac", SqlDbType.Int).Value = mauSac.MaMauSac;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;

        }


        // Tìm kiếm màu sắc
        public List<MauSac> TimKiemMauSac(string text)
        {
            List<MauSac> danhSachMauSacTimKiem = new List<MauSac>();
            OpenConnection();
            string sql = "select * from MauSac where concat(MaMauSac,TenMauSac) COLLATE Latin1_General_CI_AI like N'%" + text + "%' AND TrangThai = 1";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                MauSac mauSac = new MauSac();
                mauSac.MaMauSac = reader.GetInt32(0);
                mauSac.TenMauSac = reader.GetString(1);
                mauSac.TrangThai = reader.GetInt32(2);
                danhSachMauSacTimKiem.Add(mauSac);
            }
            CloseConnection();
            return danhSachMauSacTimKiem;
        }

    }
}
