using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Reflection.PortableExecutable;

namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO hoaDonDAO = new HoaDonDAO();

        public List<HoaDon> getHoaDon()
        {
            return hoaDonDAO.getHoaDon();
        }
        public bool ThemHoaDon(HoaDon hd)
        {
            return hoaDonDAO.ThemHoaDon(hd);
        }

        public HoaDon LayHoaDonQuaMa(int maHoaDon)
        {
            foreach (var item in hoaDonDAO.getHoaDon())
            {
                if (item.MaHoaDon == maHoaDon)
                {
                    return item;
                }
            }
            return null;
        }

        public List<HoaDon> getHoaDon(int makhachhang)
        {
            return hoaDonDAO.getHoaDon(makhachhang);
        }

        public List<HoaDon> HoaDonTheoNgay(String batDau, String ketThuc, int maNhanVien, int maKhachHang)
        {
            return hoaDonDAO.HoaDonTheoNgay(batDau, ketThuc, maNhanVien, maKhachHang);
        }
    }
}
