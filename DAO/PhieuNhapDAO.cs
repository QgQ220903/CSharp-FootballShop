using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DAO
{
    public class PhieuNhapDAO : DatabaseAccess
    {
        public List<PhieuNhap> LayToanBoPhieuNhap()
        {
            List<PhieuNhap> danhSachPhieuNhap = new List<PhieuNhap>();
            try
            {
                string sql = "select * from PhieuNhap";
                OpenConnection();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PhieuNhap phieuNhap = new PhieuNhap();
                    phieuNhap.MaPhieuNhap = reader.GetInt32(0);
                    phieuNhap.MaNhaCungCap = reader.GetInt32(1);
                    phieuNhap.MaNhanVien = reader.GetInt32(2);
                    phieuNhap.NgayNhap = Convert.ToDateTime(reader.GetDateTime(3));
                    double tongtiennhap = reader.GetDouble(4);
                    phieuNhap.TongTien = Convert.ToSingle(tongtiennhap);
                    phieuNhap.TrangThai = reader.GetInt32(5);
                    danhSachPhieuNhap.Add(phieuNhap);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return danhSachPhieuNhap;
        }


        /*public List<PhieuNhap> LayToanBoPhieuNhapTrongKhoang(String DateStart, String DateEnd)
        {
            List<PhieuNhap> danhSachPhieuNhap = new List<PhieuNhap>();
            try
            {
                string sql = "select * from PhieuNhap where trangthai = 1 and ((NgayNhap >= '" + DateStart + "' and  NgayNhap <= '" + DateEnd + "') OR" +
                " (NgayNhap = '" + DateStart + "' and  NgayNhap ='" + DateEnd + "' )) ";
                OpenConnection();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PhieuNhap phieuNhap = new PhieuNhap();
                    phieuNhap.MaPhieuNhap = reader.GetInt32(0);
                    phieuNhap.MaNhaCungCap = reader.GetInt32(1);
                    phieuNhap.MaNhanVien = reader.GetInt32(2);
                    phieuNhap.NgayNhap = Convert.ToDateTime(reader.GetDateTime(3));
                    phieuNhap.TenPhieuNhap = reader.GetString(4);
                    double tongtiennhap = reader.GetDouble(5);
                    phieuNhap.TongTienNhap = Convert.ToSingle(tongtiennhap);
                    phieuNhap.TrangThai = reader.GetInt32(6);
                    danhSachPhieuNhap.Add(phieuNhap);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return danhSachPhieuNhap;
        }*/

        public bool ThemPhieuNhap(PhieuNhap phieuNhap)
        {
            OpenConnection();
            string sql = "insert into PhieuNhap values(@MaNhaCungCap,@MaNhanVien,@NgayNhap,@TongTien,@TrangThai)";
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@MaNhaCungCap", SqlDbType.Int).Value = phieuNhap.MaNhaCungCap;
            command.Parameters.Add("@MaNhanVien", SqlDbType.Int).Value = phieuNhap.MaNhanVien;
            command.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = phieuNhap.NgayNhap;
            command.Parameters.Add("@TongTien", SqlDbType.Float).Value = phieuNhap.TongTien;
            command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = phieuNhap.TrangThai;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        public bool XoaPhieuNhap(int maPhieuNhap)
        {
            string sql = "UPDATE PhieuNhap SET TrangThai = 0 WHERE MaPhieuNhap = @maPhieuNhap";
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@maPhieuNhap", SqlDbType.Int).Value = maPhieuNhap;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        public bool SuaPhieuNhap(PhieuNhap phieuNhap)
        {
            string sql = "UPDATE PhieuNhap SET MaNhaCungCap = @maNhaCungCap, MaNhanVien = @maNhanVien, NgayNhap = @ngayNhap, TongTien = @TongTien WHERE MaPhieuNhap = @maPhieuNhap";
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@maNhaCungCap", SqlDbType.Int).Value = phieuNhap.MaNhaCungCap;
            command.Parameters.Add("@maNhanVien", SqlDbType.Int).Value = phieuNhap.MaNhanVien;
            command.Parameters.Add("@ngayNhap", SqlDbType.DateTime).Value = phieuNhap.NgayNhap;
            command.Parameters.Add("@TongTien", SqlDbType.Float).Value = phieuNhap.TongTien;
            command.Parameters.Add("@MaPhieuNhap", SqlDbType.Int).Value = phieuNhap.MaPhieuNhap;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        public List<PhieuNhap> TimKiemPhieuNhap(string text)
        {
            List<PhieuNhap> arrayphieunhap = new List<PhieuNhap>();
            string sql = "select * from PhieuNhap where concat(MaPhieuNhap, MaNhaCungCap,MaNhanVien, NgayNhap, TenPhieuNhap, TongTienNhap)COLLATE Latin1_General_CI_AI like N'%" + text + "%'";
            command = new SqlCommand(sql, conn);
            OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                double ttt;
                PhieuNhap phieunhap = new PhieuNhap();
                phieunhap.MaPhieuNhap = reader.GetInt32(0);
                phieunhap.MaNhaCungCap = reader.GetInt32(1);
                phieunhap.MaNhanVien = reader.GetInt32(2);
                phieunhap.NgayNhap = reader.GetDateTime(3);
                ttt = reader.GetDouble(5);
                phieunhap.TongTien = Convert.ToSingle(ttt);
                phieunhap.TrangThai = reader.GetInt32(6);
                arrayphieunhap.Add(phieunhap);
            }
            CloseConnection();
            return arrayphieunhap;
        }

        public List<PhieuNhap> LayPhieuNhapTheoNgay(string batDau, string ketThuc, int maNhanVien)
        {
            List<PhieuNhap> arrayphieunhap = new List<PhieuNhap>();
            string sql = "";
            if (maNhanVien == 0)
            {
                sql += "SELECT * FROM PhieuNhap WHERE NgayNhap >= '" + batDau + "' AND NgayNhap <= ' " + ketThuc + "'";
            }
            else
            {
                sql += "SELECT * FROM PhieuNhap WHERE NgayNhap >= '" + batDau + "' AND NgayNhap <= ' " + ketThuc + "' and MaNhanVien = " + maNhanVien;

            }
            command = new SqlCommand(sql, conn);
            OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                double ttt;
                PhieuNhap phieunhap = new PhieuNhap();
                phieunhap.MaPhieuNhap = reader.GetInt32(0);
                phieunhap.MaNhaCungCap = reader.GetInt32(1);
                phieunhap.MaNhanVien = reader.GetInt32(2);
                phieunhap.NgayNhap = reader.GetDateTime(3);
                ttt = reader.GetDouble(4);
                phieunhap.TongTien = Convert.ToSingle(ttt);
                phieunhap.TrangThai = reader.GetInt32(5);
                arrayphieunhap.Add(phieunhap);
            }
            CloseConnection();
            return arrayphieunhap;
        }







    }
}

