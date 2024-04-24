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
    public class ChiTietHoaDonDAO : DatabaseAccess
    {
        public bool ThemChiTietHoaDon(ChiTietHoaDon cthd)
        {
            string query = "INSERT INTO ChiTietHoaDon VALUES(@MaHoaDon,@MaChiTietSanPham,@GiaSanPham,@SoLuong,@ThanhTien)";
            OpenConnection();
            command = new SqlCommand(query, conn);
            command.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value = cthd.MaHoaDon;
            command.Parameters.Add("@MaChiTietSanPham", SqlDbType.Int).Value = cthd.MaChiTietSanPham;
            command.Parameters.Add("@GiaSanPham", SqlDbType.Float).Value = cthd.GiaSanPham;
            command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = cthd.SoLuong;
            command.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = cthd.ThanhTien;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }


        public List<ChiTietHoaDon> LayChiTietHoaDon(int maHoaDon)
        {
            List<ChiTietHoaDon> danhSachChiTiet = new List<ChiTietHoaDon>();
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from ChiTietHoaDon where MaHoaDon = @MaHoaDon";
            command.Connection = conn;
            command.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value = maHoaDon;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                ChiTietHoaDon cthd = new ChiTietHoaDon();
                cthd.MaChiTiet = reader.GetInt32(0);
                cthd.MaHoaDon = reader.GetInt32(1);
                cthd.MaChiTietSanPham = reader.GetInt32(2);
                cthd.GiaSanPham = Convert.ToSingle(reader.GetDouble(3));
                cthd.SoLuong = reader.GetInt32(4);
                cthd.ThanhTien = Convert.ToSingle(reader.GetDouble(5));
                danhSachChiTiet.Add(cthd);
            }
            CloseConnection();
            return danhSachChiTiet;
        }
    }
}
