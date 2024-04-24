using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietSanPhamBUS
    {
        ChiTietSanPhamDAO chiTietSanPhamDAO = new ChiTietSanPhamDAO();

        // Lấy danh sách chi tiết sản phẩm
        public List<ChiTietSanPham> LayToanBoChiTietSanPham()
        {
            return chiTietSanPhamDAO.LayToanBoChiTietSanPham();
        }

        // lấy danh sách chi tiết theo thứ tự tăng dần số lượng tồn
        public List<ChiTietSanPham> LayToanBoCTSPTheoSLT()
        {
            return chiTietSanPhamDAO.LayToanBoCTSPTheoSLT();
        }

        public List<ChiTietSanPham> TimKiemChiTietTheoMa(int maChiTietSanPham)
        {
            return chiTietSanPhamDAO.TimKiemChiTietTheoMa(maChiTietSanPham);
        }

        // Lấy danh sách chi tiết sản phẩm thông qua mã sản phẩm
        public List<ChiTietSanPham> LayDanhSachChiTietTheoMaSanPham(int maSanPham)
        {
            List<ChiTietSanPham> danhSachChiTietTheoMa = new List<ChiTietSanPham>();
            foreach (var item in chiTietSanPhamDAO.LayToanBoChiTietSanPham())
            {
                if (item.MaSanPham == maSanPham && item.TrangThai == 1)
                {
                    if (item.TrangThai == 1)
                    {
                        danhSachChiTietTheoMa.Add(item);
                    }
                }
            }
            return danhSachChiTietTheoMa;
        }


        // THêm chi tiết sản phẩm
        public bool ThemChiTietSanPham(ChiTietSanPham chiTietSanPham)
        {
            foreach (var item in chiTietSanPhamDAO.LayToanBoChiTietSanPham())
            {
                if (item.MaSanPham == chiTietSanPham.MaSanPham
                    && item.MaMauSac == chiTietSanPham.MaMauSac
                    && item.MaKichCo == chiTietSanPham.MaKichCo
                    && item.TrangThai == 1)
                {
                    return false;
                }
            }
            return chiTietSanPhamDAO.ThemChiTietSanPham(chiTietSanPham);
        }

        // lấy ra chi tiết sản phẩm thông qua mã sản phẩm, mã màu, mã kích cỡ
        public ChiTietSanPham TimKiemChiTietSanPham(int maSanPham, int maMauSac, int maKichCo)
        {
            foreach (var item in chiTietSanPhamDAO.LayToanBoChiTietSanPham())
            {
                if (item.TrangThai == 1)
                {
                    if (item.MaMauSac == maMauSac && item.MaKichCo == maKichCo && item.MaSanPham == maSanPham && item.TrangThai == 1)
                    {
                        return item;
                    }
                }

            }
            return null;
        }


        // Sửa chi tiết sản phẩm
        public bool SuaChiTietSanPham(ChiTietSanPham chiTietSanPham)
        {
            foreach (var item in chiTietSanPhamDAO.LayToanBoChiTietSanPham())
            {
                if (item.MaSanPham == chiTietSanPham.MaSanPham && item.TrangThai == 1)
                {
                    if (item.MaMauSac == chiTietSanPham.MaMauSac && item.MaKichCo == chiTietSanPham.MaKichCo)
                    {
                        return false;
                    }
                }
            }
            return chiTietSanPhamDAO.SuaChiTietSanPham(chiTietSanPham);
        }

        public bool CapNhatSoLuong(ChiTietSanPham chiTietSanPham)
        {
            return chiTietSanPhamDAO.CapNhatSoLuong(chiTietSanPham);
        }


        // Xóa chi tiết sản phẩm
        public bool XoaChiTietSanPham(int maChiTietSanPham)
        {
            return chiTietSanPhamDAO.XoaChiTietSanPham(maChiTietSanPham);
        }


        public List<ChiTietSanPham> TimKiem(string text)
        {
            return chiTietSanPhamDAO.TimKiem(text);
        }


        // Lấy ra chi tiết sản phẩm thông qua mã chi tiết sản phẩm

        public ChiTietSanPham LayChiTietSanPhamQuaMa(int maChiTietSanPham)
        {
            foreach (var item in chiTietSanPhamDAO.LayToanBoChiTietSanPham())
            {
                if (item.MaChiTietSanPham == maChiTietSanPham)
                {
                    return item;
                }
            }
            return null;
        }


        public void XoaChiTietTheoMaSanPham(int maSanPham)
        {
            foreach (var item in chiTietSanPhamDAO.LayToanBoChiTietSanPham())
            {
                if (item.MaSanPham == maSanPham)
                {
                    chiTietSanPhamDAO.XoaChiTietSanPham(item.MaChiTietSanPham);
                }
            }
        }
    }
}
