using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int MaTheLoai { get; set; }
        public int MaNhaCungCap { get; set; }
        public float GiaBan { get; set; }
        public float GiaNhap { get; set; }
        public int SoLuongTon { get; set; }
        public int TrangThai { get; set; }
    }
}