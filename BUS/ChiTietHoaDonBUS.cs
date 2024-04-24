using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class ChiTietHoaDonBUS : DatabaseAccess
    {
        ChiTietHoaDonDAO chiTietHoaDonDAO = new ChiTietHoaDonDAO();
        public bool ThemChiTietHoaDon(ChiTietHoaDon cthd)
        {
            return chiTietHoaDonDAO.ThemChiTietHoaDon(cthd);
        }

        public List<ChiTietHoaDon> LayChiTietHoaDon(int maHoaDon)
        {
            return chiTietHoaDonDAO.LayChiTietHoaDon(maHoaDon);
        }
    }
}
