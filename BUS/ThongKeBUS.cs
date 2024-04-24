using DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThongKeBUS
    {
        ThongKeDAO thongKeDAO = new ThongKeDAO();
        public ArrayList LayDoanhThuTheoNgay(string startDate, string endDate)
        {
            return thongKeDAO.LayDoanhThuTheoNgay(startDate, endDate);
        }

        public ArrayList LaySanPhamBanChay()
        {
            return thongKeDAO.LaySanPhamBanChay();
        }

        public ArrayList LaySanPhamTon()
        {
            return thongKeDAO.LaySanPhamTon();
        }
    }
}
