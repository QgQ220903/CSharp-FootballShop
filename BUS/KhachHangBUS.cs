using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class KhachHangBUS
    {
        KhachHangDAO khachHangDAO = new KhachHangDAO();
        public List<KhachHang> LayDanhSachKhachHang()
        {
            return khachHangDAO.LayDanhSachKhachHang();
        }

        public KhachHang LayKhachHangQuaMa(int maKhachHang)
        {
            foreach (var item in khachHangDAO.LayDanhSachKhachHang())
            {
                if(item.MaKhachHang == maKhachHang)
                {
                    return item;
                }
            }
            return null;
        }

        public bool ThemKhachHang(KhachHang khachHang)
        {
            return khachHangDAO.ThemKhachHang(khachHang);
        } 

        public bool SuaKhachHang(KhachHang khachHang)
        {
            return khachHangDAO.SuaKhachHang(khachHang);
        }



        public bool XoaKhachHang(KhachHang khachHang)
        {
            return khachHangDAO.XoaKhachHang(khachHang);

        }

        public List<KhachHang> TimKiemKhachHang(string text)
        {
            return khachHangDAO.TimKiemKhachHang(text);
        }
    }
}
