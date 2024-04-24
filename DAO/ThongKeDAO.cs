using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Collections;

namespace DAO
{
    public class ThongKeDAO : DatabaseAccess
    {
        public ArrayList LayDoanhThuTheoNgay(string startDate, string endDate)
        {
            OpenConnection();

            string query = "SELECT CAST(Ngay AS DATE) AS Ngay, SUM(DoanhThu) AS TongDoanhThu, SUM(ChiPhi) AS TongChiPhi, SUM(DoanhThu - ChiPhi) AS LoiNhuan " +
                "FROM (" +
                "   SELECT CAST(NgayLap AS DATE) AS Ngay, TongTien AS DoanhThu, 0 AS ChiPhi " +
                "   FROM HoaDon " +
                "   WHERE CAST(NgayLap AS DATE) >= '"+ startDate +"' AND CAST(NgayLap AS DATE) <= '"+ endDate +"' " +
                "   UNION ALL " +
                "   SELECT CAST(NgayNhap AS DATE) AS Ngay, 0 AS DoanhThu, TongTien AS ChiPhi " +
                "   FROM PhieuNhap " +
                "   WHERE CAST(NgayNhap AS DATE) >= '"+ startDate +"' AND CAST(NgayNhap AS DATE) <= '"+ endDate +"' " +
                ") AS T " +
                "GROUP BY CAST(Ngay AS DATE);";

            ArrayList list = new ArrayList();
            SqlCommand cmd = new SqlCommand(query, conn);
            OpenConnection();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {

                    DateTime Ngay = reader.GetDateTime(0);
                    string NgayFormat = Ngay.ToString("dd/MM/yyyy");

                    Double TongDoanhThu = reader.GetDouble(1);
                    Double TongChiPhi = reader.GetDouble(2);
                    Double LoiNhuan = reader.GetDouble(3);
                    
                    string sb = new string("");
                    sb = NgayFormat + "," + TongDoanhThu + "," + TongChiPhi + "," + LoiNhuan;
                    list.Add(sb);
                }
            }

            CloseConnection();
            return list;
        }


        public ArrayList LaySanPhamBanChay()
        {
            OpenConnection();

            string query = "SELECT TOP 10 " +
                "CTS.MaSanPham, " +
                "SP.TenSanPham, " +
                "SUM(CHD.SoLuong) AS TongSoLuongBan " +
                "FROM " +
                "ChiTietSanPham CTS " +
                "JOIN " +
                "ChiTietHoaDon CHD ON CTS.MaChiTietSanPham = CHD.MaChiTietSanPham " +
                "JOIN " +
                "SanPham SP ON CTS.MaSanPham = SP.MaSanPham " +
                "GROUP BY " +
                "SP.TenSanPham, CTS.MaSanPham " +
                "ORDER BY " +
                "TongSoLuongBan DESC ";

            ArrayList list = new ArrayList();
            SqlCommand cmd = new SqlCommand(query, conn);
            OpenConnection();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {

                    int maChiTiet = reader.GetInt32(0);
                    string tenSanPham = reader.GetString(1);
                    int soLuongBan = reader.GetInt32(2);

                    string sb = new string("");
                    sb = maChiTiet + "," + tenSanPham + "," + soLuongBan;
                    list.Add(sb);
                }
            }

            CloseConnection();
            return list;
        }



        public ArrayList LaySanPhamTon()
        {
            OpenConnection();

            string query = "SELECT " +
                "CTS.MaChiTietSanPham, " +
                "SP.TenSanPham, " +
                "MS.TenMauSac, " +
                "KC.TenKichCo, " +
                "CTS.SoLuongTon " +
                "FROM " +
                "ChiTietSanPham CTS " +
                "JOIN " +
                "SanPham SP ON CTS.MaSanPham = SP.MaSanPham " +
                "JOIN " +
                "MauSac MS ON CTS.MaMauSac = MS.MaMauSac " +
                "JOIN " +
                "KichCo KC ON CTS.MaKichCo = KC.MaKichCo " +
                "ORDER BY " +
                "CTS.SoLuongTon ASC ";

            ArrayList list = new ArrayList();
            SqlCommand cmd = new SqlCommand(query, conn);
            OpenConnection();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {

                    int maChiTiet = reader.GetInt32(0);
                    string tenSanPham = reader.GetString(1);
                    string tenMauSac = reader.GetString(2);
                    string tenKichCo = reader.GetString(3);
                    int soLuongTon = reader.GetInt32(4);

                    string sb = new string("");
                    sb = maChiTiet + "," + tenSanPham + "," + tenMauSac + "," + tenKichCo + "," + soLuongTon;
                    list.Add(sb);
                }
            }

            CloseConnection();
            return list;
        }

    }
}
