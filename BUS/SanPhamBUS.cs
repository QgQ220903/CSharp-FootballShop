using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography;

namespace BUS
{
    public class SanPhamBUS
    {
        SanPhamDAO sanPhamDAO = new SanPhamDAO();
        // lấy danh sách sản phẩm
        public List<SanPham> LayDanhSachSanPham()
        {
            return sanPhamDAO.LayDanhSachSanPham();
        }

        // thêm sản phẩm
        public bool ThemSanPham(SanPham sanPham)
        {
            foreach (var item in sanPhamDAO.LayDanhSachSanPham())
            {
                if (item.TenSanPham == sanPham.TenSanPham &&
                    item.MaTheLoai == sanPham.MaTheLoai &&
                    item.TrangThai == 1)
                {
                    return false;
                }
            }
            return sanPhamDAO.ThemSanPham(sanPham);
        }


        // Sửa sản phẩm
        public bool SuaSanPham(SanPham sanPham)
        {
            foreach (var item in sanPhamDAO.LayDanhSachSanPham())
            {
                if (item.TenSanPham == sanPham.TenSanPham &&
                    item.MaTheLoai == sanPham.MaTheLoai &&
                    item.TrangThai == 1 && item.MaSanPham != sanPham.MaSanPham)
                {
                    return false;
                }
            }
            return sanPhamDAO.SuaSanPham(sanPham);
        }

        public bool CapNhatSoLuong(SanPham sanPham)
        {
            return sanPhamDAO.CapNhatSoLuong(sanPham);
        }

        // Xóa sản phẩm
        public bool XoaSanPham(int maSanPham)
        {
            return sanPhamDAO.XoaSanPham(maSanPham);
        }

        public SanPham LaySanPhamQuaMa(int maSanPham)
        {
            SanPham sanPham = new SanPham();
            foreach (var item in sanPhamDAO.LayDanhSachSanPham())
            {
                if (item.TrangThai == 1 && item.MaSanPham == maSanPham)
                {
                    sanPham = item;
                }
            }
            return sanPham;
        }

        public SanPham LaySanPhamQuaTen(string tenSanPham)
        {
            SanPham sanPham = new SanPham();
            foreach (var item in sanPhamDAO.LayDanhSachSanPham())
            {
                if (item.TrangThai == 1 && item.TenSanPham == tenSanPham)
                {
                    sanPham = item;
                }
            }
            return sanPham;
        }

        public List<SanPham> LaySanPhamQuaNhaCungCap(int maNhaCungCap)
        {
            return sanPhamDAO.LaySanPhamQuaNhaCungCap(maNhaCungCap);
        }

        public List<SanPham> LaySanPhamQuaNhaCungCap(int maNhaCungCap, string tenSanPham)
        {
            return sanPhamDAO.LaySanPhamQuaNhaCungCap(maNhaCungCap, tenSanPham);
        }

        public List<SanPham> TimKiemSanPham(string text)
        {
            return sanPhamDAO.TimKiemSanPham(text);
        }

        public List<SanPham> TimKiemSanPhamTheoTen(string text)
        {
            return sanPhamDAO.TimKiemSanPhamTheoTen(text);
        }
    }
}
