using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace DAO
{
    public class NhomQuyenDAO : DatabaseAccess
    {

        // Lấy danh sách nhóm quyền
        public List<NhomQuyen> LayDanhSachNhomQuyen()
        {
            List<NhomQuyen> dt = new List<NhomQuyen>();
            try
            {
                OpenConnection();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM NhomQuyen";
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    NhomQuyen nhomQuyen = new NhomQuyen();
                    nhomQuyen.MaNhomQuyen = reader.GetInt32(0);
                    nhomQuyen.TenNhomQuyen = reader.GetString(1);
                    nhomQuyen.TrangThai = reader.GetInt32(2);
                    dt.Add(nhomQuyen);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }


        // Thêm nhóm quyền
        public bool ThemNhomQuyen(NhomQuyen nhomquyen)
        {
            OpenConnection();
            string sql = "insert into NhomQuyen values(@TenNhomQuyen,@TrangThai)";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@TenNhomQuyen", SqlDbType.NVarChar).Value = nhomquyen.TenNhomQuyen;
            command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = nhomquyen.TrangThai;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        // Sửa nhóm quyền
        public bool SuaNhomQuyen(NhomQuyen nhomquyen)
        {
            OpenConnection();
            string sql = "update NhomQuyen set TenNhomQuyen=@TenNhomQuyen where MaNhomQuyen=@MaNhomQuyen";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@MaNhomQuyen", SqlDbType.Int).Value = nhomquyen.MaNhomQuyen;
            command.Parameters.Add("@TenNhomQuyen", SqlDbType.NVarChar).Value = nhomquyen.TenNhomQuyen;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        // Xóa nhóm quyền
        public bool XoaNhomQuyen(int MaNhomQuyen)
        {
            OpenConnection();
            string sql = "update NhomQuyen set TrangThai=0 where MaNhomQuyen=@MaNhomQuyen";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@MaNhomQuyen", SqlDbType.Int).Value = MaNhomQuyen;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        // Tìm kiếm nhóm quyền
        public List<NhomQuyen> TimKiemNhomQuyen(string text)
        {
            List<NhomQuyen> nhomQuyen = new List<NhomQuyen>();
            string sql = "select * from NhomQuyen where concat(MaNhomQuyen,TenNhomQuyen) COLLATE Latin1_General_CI_AI like N'%" + text + "%' AND TrangThai = 1";
            command = new SqlCommand(sql, conn);
            OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                NhomQuyen nhomquyen = new NhomQuyen();
                nhomquyen.MaNhomQuyen = reader.GetInt32(0);
                nhomquyen.TenNhomQuyen = reader.GetString(1);
                nhomquyen.TrangThai = reader.GetInt32(2);
                nhomQuyen.Add(nhomquyen);
            }
            CloseConnection();
            return nhomQuyen;
        }


    }
}
