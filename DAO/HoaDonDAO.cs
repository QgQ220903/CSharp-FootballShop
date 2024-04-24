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
    public class HoaDonDAO : DatabaseAccess
    {

        public List<HoaDon> getHoaDon()
        {
            List<HoaDon> danhSachHoaDon = new List<HoaDon>();
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM HoaDon";
            command.Connection = conn;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                HoaDon hd = new HoaDon();
                hd.MaHoaDon = reader.GetInt32(0);
                hd.MaKhachHang = reader.GetInt32(1);
                hd.MaNhanVien = reader.GetInt32(2);
                hd.NgayLap = reader.GetDateTime(3);
                hd.TongTien = Convert.ToSingle(reader.GetDouble(4));
                hd.TrangThai = reader.GetInt32(5);
                danhSachHoaDon.Add(hd);
            }
            CloseConnection();
            return danhSachHoaDon;
        }

        public List<HoaDon> getHoaDon(int makhachhang)
        {
            List<HoaDon> danhSachHoaDon = new List<HoaDon>();
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM HoaDon where makhachhang = @makhachhang";
            command.Connection = conn;
            command.Parameters.Add("@makhachhang", SqlDbType.Int).Value = makhachhang;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                HoaDon hd = new HoaDon();
                hd.MaHoaDon = reader.GetInt32(0);
                hd.MaKhachHang = reader.GetInt32(1);
                hd.MaNhanVien = reader.GetInt32(2);
                hd.NgayLap = reader.GetDateTime(3);
                hd.TongTien = Convert.ToSingle(reader.GetDouble(4));
                hd.TrangThai = reader.GetInt32(5);
                danhSachHoaDon.Add(hd);
            }
            CloseConnection();
            return danhSachHoaDon;
        }

        public bool ThemHoaDon(HoaDon hd)
        {
            OpenConnection();
            string sql = "insert into HoaDon values(@MaKhachHang,@MaNhanVien ,@NgayLap, @TongTien ,@TrangThai)";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add("@MaKhachHang", SqlDbType.Int).Value = hd.MaKhachHang;
            command.Parameters.Add("@MaNhanVien", SqlDbType.Int).Value = hd.MaNhanVien;
            command.Parameters.Add("@NgayLap", SqlDbType.DateTime).Value = hd.NgayLap;
            command.Parameters.Add("@TongTien", SqlDbType.Float).Value = hd.TongTien;
            command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = hd.TrangThai;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        public List<HoaDon> HoaDonTheoNgay(String batDau, String ketThuc, int maNhanVien, int maKhachHang)
        {
            List<HoaDon> list = new List<HoaDon>();
            OpenConnection();
            string sql = "";
            if(maKhachHang == 0)
            {
                if (maNhanVien == 0)
                {
                    sql += "SELECT * FROM HoaDon WHERE NgayLap >= '" + batDau + "' AND NgayLap <= ' " + ketThuc + " 23:59:59'";
                }
                else
                {
                    sql += "SELECT * FROM HoaDon WHERE NgayLap >= '" + batDau + "' AND NgayLap <= ' " + ketThuc + " 23:59:59' and MaNhanVien = " + maNhanVien;

                }
            }
            else
            {
                if (maNhanVien == 0)
                {
                    sql += "SELECT * FROM HoaDon WHERE NgayLap >= '" + batDau + "' AND NgayLap <= ' " + ketThuc + " 23:59:59' and MaKhachHang = " + maKhachHang;
                }
                else
                {
                    sql += "SELECT * FROM HoaDon WHERE NgayLap >= '" + batDau + "' AND NgayLap <= ' " + ketThuc + " 23:59:59' and MaNhanVien = " + maNhanVien + " and MaKhachHang = " + maKhachHang;

                }

            }
            command = new SqlCommand(sql, conn);
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                HoaDon hd = new HoaDon();
                hd.MaHoaDon = reader.GetInt32(0);
                hd.MaKhachHang = reader.GetInt32(1);
                hd.MaNhanVien = reader.GetInt32(2);
                hd.NgayLap = reader.GetDateTime(3);
                hd.TongTien = Convert.ToSingle(reader.GetDouble(4));
                hd.TrangThai = reader.GetInt32(5);
                list.Add(hd);
            }
            CloseConnection();
            return list;
        }
    }
}
