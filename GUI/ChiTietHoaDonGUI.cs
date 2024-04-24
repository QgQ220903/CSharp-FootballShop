using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ChiTietHoaDonGUI : Form
    {
        public int maHoaDon { get; set; }
        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        ChiTietHoaDonBUS chiTietHoaDonBUS = new ChiTietHoaDonBUS();
        KhachHangBUS khachHangBUS = new KhachHangBUS();
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        KichCoBUS kichCoBUS = new KichCoBUS();
        MauSacBUS mauSacBUS = new MauSacBUS();

        public ChiTietHoaDonGUI()
        {
            InitializeComponent();
        }

        public ChiTietHoaDonGUI(int maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
            HoaDon hoaDon = hoaDonBUS.LayHoaDonQuaMa(maHoaDon);
            lbMaHoaDon.Text = maHoaDon + "";
            lbMaKhachHang.Text = khachHangBUS.LayKhachHangQuaMa(hoaDon.MaKhachHang).TenKhachHang;
            lbMaNhanVien.Text = hoaDon.MaNhanVien + "-" + nhanVienBUS.LayNhanVienQuaMa(hoaDon.MaNhanVien).TenNhanVien;
            lbNgayLap.Text = hoaDon.NgayLap + "";
            lbTongTien.Text = hoaDon.TongTien.ToString("C", new CultureInfo("vi-VN"));
            LoadDataTable(this.maHoaDon);



        }
        public void LoadDataTable(int maHoaDon)
        {
            danhSachChiTietHoaDon.RowCount = 0;
            foreach (var item in chiTietHoaDonBUS.LayChiTietHoaDon(maHoaDon))
            {
                ChiTietSanPham chiTietSanPham = chiTietSanPhamBUS.LayChiTietSanPhamQuaMa(item.MaChiTietSanPham);
                SanPham sanPham = sanPhamBUS.LaySanPhamQuaMa(chiTietSanPham.MaSanPham);
                MauSac mauSac = mauSacBUS.LayMauSacQuaMa(chiTietSanPham.MaMauSac);
                KichCo kichCo = kichCoBUS.LayKichCoQuaMa(chiTietSanPham.MaKichCo);
                danhSachChiTietHoaDon.Rows.Add(
                    item.MaChiTiet,
                    item.MaHoaDon,
                    sanPham.TenSanPham,
                    mauSac.TenMauSac,
                    kichCo.TenKichCo,
                    item.SoLuong,
                    item.GiaSanPham,
                    item.ThanhTien);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            DialogResult result2 = printDialog.ShowDialog();
            if (result2 == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            HoaDon hoaDon = hoaDonBUS.getHoaDon().Last();
            KhachHangBUS khachHangBUS = new KhachHangBUS();
            e.Graphics.DrawString("HÓA ĐƠN", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(350, 20));

            e.Graphics.DrawString("Mã Hóa Đơn: ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 60));
            e.Graphics.DrawString(hoaDon.MaHoaDon + "", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(140, 60));

            e.Graphics.DrawString("Ngày Lập: ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 80));
            e.Graphics.DrawString(hoaDon.NgayLap + "", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(120, 80));

            e.Graphics.DrawString("Khách Hàng: ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 100));
            e.Graphics.DrawString(khachHangBUS.LayKhachHangQuaMa(hoaDon.MaKhachHang).TenKhachHang, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(130, 100));

            e.Graphics.DrawString("Nhân Viên: ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 120));
            NhanVien nhanVien = nhanVienBUS.LayNhanVienQuaMa(Convert.ToInt32(lbMaNhanVien.Text.Split("-")[0]));
            e.Graphics.DrawString(nhanVien.TenNhanVien
                , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(150, 120));

            e.Graphics.DrawString("Thông Tin Chi Tiết", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 160));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 175));
            e.Graphics.DrawString("STT", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(20, 190));
            e.Graphics.DrawString("Tên Sản Phẩm", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(80, 190));
            e.Graphics.DrawString("Màu", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(290, 190));
            e.Graphics.DrawString("Kích Cỡ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(370, 190));
            e.Graphics.DrawString("Giá Bán", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(450, 190));
            e.Graphics.DrawString("Số Lượng", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(530, 190));
            e.Graphics.DrawString("Thành Tiền", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(620, 190));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 200));
            int point = 220;
            for (int i = 0; i < danhSachChiTietHoaDon.Rows.Count; i++)
            {
                e.Graphics.DrawString((i + 1) + "", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(20, point));
                e.Graphics.DrawString(danhSachChiTietHoaDon.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(80, point));
                e.Graphics.DrawString(danhSachChiTietHoaDon.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(290, point));
                e.Graphics.DrawString(danhSachChiTietHoaDon.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(390, point));
                e.Graphics.DrawString(danhSachChiTietHoaDon.Rows[i].Cells[6].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(450, point));
                e.Graphics.DrawString(danhSachChiTietHoaDon.Rows[i].Cells[5].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(560, point));
                e.Graphics.DrawString(danhSachChiTietHoaDon.Rows[i].Cells[7].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(630, point));

                point += 25;
            }
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, point));
            e.Graphics.DrawString("Tổng Tiền: ",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(500, point += 25));
            e.Graphics.DrawString(lbTongTien.Text,
                new Font("Arial", 10, FontStyle.Bold), Brushes.Red, new Point(600, point));
        }
    }
}
