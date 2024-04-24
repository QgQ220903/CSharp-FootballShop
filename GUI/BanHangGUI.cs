using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class BanHangGUI : Form
    {
        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        ChiTietHoaDonBUS chiTietHoaDonBUS = new ChiTietHoaDonBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        MauSacBUS mauSacBUS = new MauSacBUS();
        KichCoBUS kichCoBUS = new KichCoBUS();
        KhuyenMaiBUS khuyenMaiBUS = new KhuyenMaiBUS();

        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        public int MaTaiKhoan { get; set; }

        public BanHangGUI()
        {
            InitializeComponent();
        }

        public BanHangGUI(int maTaiKhoan)
        {
            InitializeComponent();
            LoadDataChiTietSanPham();
            MaTaiKhoan = maTaiKhoan;
            NhanVien nhanVien = nhanVienBUS.LayNhanVienQuaMa(this.MaTaiKhoan);
            txtTenNhanVien.Text = nhanVien.TenNhanVien;
        }

        public void LoadDataChiTietSanPham(int maChiTietSanPham)
        {
            danhSachChiTietSanPham.RowCount = 0;
            foreach (var item2 in chiTietSanPhamBUS.TimKiemChiTietTheoMa(maChiTietSanPham))
            {
                if (item2.TrangThai == 1)
                {
                    danhSachChiTietSanPham.Rows.Add(item2.MaChiTietSanPham, sanPhamBUS.LaySanPhamQuaMa(item2.MaSanPham).TenSanPham, mauSacBUS.LayMauSacQuaMa(item2.MaMauSac).TenMauSac, kichCoBUS.LayKichCoQuaMa(item2.MaKichCo).TenKichCo, item2.SoLuongTon, sanPhamBUS.LaySanPhamQuaMa(item2.MaSanPham).GiaBan);
                }
            }
        }

        public void LoadDataChiTietSanPham(string tenSanPham)
        {
            danhSachChiTietSanPham.RowCount = 0;
            List<SanPham> sanphamtimkiem = sanPhamBUS.TimKiemSanPhamTheoTen(tenSanPham);
            foreach (var item in sanphamtimkiem)
            {
                foreach (var item1 in chiTietSanPhamBUS.LayDanhSachChiTietTheoMaSanPham(item.MaSanPham))
                {
                    danhSachChiTietSanPham.Rows.Add(item1.MaChiTietSanPham, sanPhamBUS.LaySanPhamQuaMa(item1.MaSanPham).TenSanPham, mauSacBUS.LayMauSacQuaMa(item1.MaMauSac).TenMauSac, kichCoBUS.LayKichCoQuaMa(item1.MaKichCo).TenKichCo, item1.SoLuongTon, sanPhamBUS.LaySanPhamQuaMa(item1.MaSanPham).GiaBan);
                }
            }
        }

        public void LoadDataChiTietSanPham()
        {
            danhSachChiTietSanPham.RowCount = 0;
            foreach (var item2 in chiTietSanPhamBUS.LayToanBoChiTietSanPham())
            {
                if (item2.TrangThai == 1)
                {
                    danhSachChiTietSanPham.Rows.Add(item2.MaChiTietSanPham, sanPhamBUS.LaySanPhamQuaMa(item2.MaSanPham).TenSanPham, mauSacBUS.LayMauSacQuaMa(item2.MaMauSac).TenMauSac, kichCoBUS.LayKichCoQuaMa(item2.MaKichCo).TenKichCo, item2.SoLuongTon, sanPhamBUS.LaySanPhamQuaMa(item2.MaSanPham).GiaBan);
                }
            }
        }

        public bool KiemTraNhapHangTrunng(int maChiTietSanPham, int soLuongThem)
        {

            for (int i = 0; i < danhSachGioHang.RowCount; i++)
            {
                if (Convert.ToInt32(danhSachGioHang.Rows[i].Cells[0].Value.ToString()) == maChiTietSanPham)
                {
                    int soLuongHienTai = Convert.ToInt32(danhSachGioHang.Rows[i].Cells[5].Value);
                    if (soLuongHienTai + soLuongThem < chiTietSanPhamBUS.LayChiTietSanPhamQuaMa(maChiTietSanPham).SoLuongTon ||
                        soLuongHienTai + soLuongThem == chiTietSanPhamBUS.LayChiTietSanPhamQuaMa(maChiTietSanPham).SoLuongTon)
                    {
                        double giaBan = Convert.ToSingle(danhSachGioHang.Rows[i].Cells[6].Value);
                        double thanhTienHienTai = Convert.ToSingle(danhSachGioHang.Rows[i].Cells[4].Value.ToString());
                        double thanhTienThem = giaBan * soLuongThem;
                        thanhTienHienTai += thanhTienThem;
                        soLuongHienTai += soLuongThem;

                        danhSachGioHang.Rows[i].Cells[5].Value = soLuongHienTai;
                        danhSachGioHang.Rows[i].Cells[6].Value = thanhTienHienTai;

                        double tongTien = Convert.ToSingle(txtTongTien.Text);
                        tongTien += thanhTienThem;
                        txtTongTien.Text = tongTien + "";
                        MessageBox.Show("Đã thêm sản phẩm vào giỏ hàng");
                    }
                    else
                    {
                        MessageBox.Show("Số lượng sản phẩm hiện tại chỉ còn " + (chiTietSanPhamBUS.LayChiTietSanPhamQuaMa(maChiTietSanPham).SoLuongTon - soLuongHienTai));
                    }
                    return true;
                }
            }
            return false;
        }

        private void danhSachChiTietSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;

            }
            if (string.IsNullOrEmpty(txtNgayNhap.Text))
            {
                MessageBox.Show("Vui lòng tạo hóa đơn trước khi thực hiện thêm sản phẩm vào giỏ hàng");
            }
            else
            {
                DataGridViewRow row = danhSachChiTietSanPham.Rows[e.RowIndex];

                int maChiTietSanPham = Convert.ToInt32(row.Cells[0].Value.ToString());
                ChiTietSanPham chiTietSanPham = chiTietSanPhamBUS.LayChiTietSanPhamQuaMa(maChiTietSanPham);
                SanPham sanPham = sanPhamBUS.LaySanPhamQuaMa(chiTietSanPham.MaSanPham);
                string selectedColumnName = danhSachChiTietSanPham.Columns[e.ColumnIndex].Name;
                if (selectedColumnName == "Them")
                {
                    if (chiTietSanPham.SoLuongTon == 0)
                    {
                        MessageBox.Show("Sản phẩm hiện đang hết hàng");
                    }
                    else
                    {
                        NhapSoLuong nhapSoLuong = new NhapSoLuong();
                        nhapSoLuong.ShowDialog();
                        if (nhapSoLuong.SoLuong > chiTietSanPham.SoLuongTon)
                        {
                            MessageBox.Show("Số lượng sản phẩm hiện tại: " + Convert.ToInt32(chiTietSanPham.SoLuongTon));
                        }
                        else if (nhapSoLuong.SoLuong == 0)
                        {
                            return;
                        }
                        else
                        {
                            if (KiemTraNhapHangTrunng(chiTietSanPham.MaChiTietSanPham, nhapSoLuong.SoLuong))
                            {
                            }
                            else
                            {
                                float thanhTien = sanPhamBUS.LaySanPhamQuaMa(chiTietSanPham.MaSanPham).GiaBan * nhapSoLuong.SoLuong;
                                danhSachGioHang.Rows.Add(chiTietSanPham.MaChiTietSanPham,
                                    sanPhamBUS.LaySanPhamQuaMa(chiTietSanPham.MaSanPham).TenSanPham,
                                    mauSacBUS.LayMauSacQuaMa(chiTietSanPham.MaMauSac).TenMauSac,
                                    kichCoBUS.LayKichCoQuaMa(chiTietSanPham.MaKichCo).TenKichCo,
                                    sanPhamBUS.LaySanPhamQuaMa(chiTietSanPham.MaSanPham).GiaBan,
                                    nhapSoLuong.SoLuong,
                                    thanhTien);

                                float tongTien = Convert.ToSingle(txtTongTien.Text);
                                tongTien += thanhTien;
                                txtTongTien.Text = tongTien + "";

                            }


                        }
                    }


                }
            }

        }

        private void danhSachGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = danhSachGioHang.Rows[e.RowIndex];


            string selectedColumnName = danhSachGioHang.Columns[e.ColumnIndex].Name;
            if (selectedColumnName == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    float tongTien = Convert.ToSingle(txtTongTien.Text);
                    tongTien = tongTien - Convert.ToSingle(row.Cells[4].Value + "");
                    txtTongTien.Text = tongTien + "";
                    danhSachGioHang.Rows.Remove(row);
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                LoadDataChiTietSanPham();
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            TimKiemKhachHang timKiemKhachHang = new TimKiemKhachHang();
            timKiemKhachHang.ShowDialog();
            txtMaKhachHang.Text = timKiemKhachHang.maKhachHang + "";

        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin khách hàng trước khi tạo hóa đơn");
            }
            else
            {
                txtNgayNhap.Text = DateTime.Now + "";
            }
        }

        private void txtKhachDua_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKhachDua.Text))
            {
                txtTienThoi.Text = 0 + "";
            }
            else
            {
                CheckError check = new CheckError();
                if (!check.IsNumeric(txtKhachDua.Text))
                {
                    MessageBox.Show("Vui lòng nhập số tiền hợp lệ");
                }
                else
                {
                    float tienKhachDua = Convert.ToSingle(txtKhachDua.Text);
                    float tongTien = Convert.ToSingle(txtTongTien.Text);
                    if (tienKhachDua - tongTien > 0 || tienKhachDua - tongTien == 0)
                    {
                        txtTienThoi.Text = (tienKhachDua - tongTien) + "";
                    }
                }

            }
        }
        public void LamMoiHoaDon()
        {
            danhSachGioHang.RowCount = 0;
            txtMaKhachHang.Text = "";
            txtNgayNhap.Text = "";
            txtTongTien.Text = 0 + "";
            txtKhachDua.Text = "";
            txtTienThoi.Text = "";
        }
        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            LamMoiHoaDon();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (danhSachGioHang.RowCount > 0)
            {
                if (string.IsNullOrWhiteSpace(txtTienThoi.Text))
                {
                    MessageBox.Show("Vui lòng nhập số tiền khách đưa");
                }
                else
                {
                    float tienThoi = Convert.ToSingle(txtTienThoi.Text);
                    float tienKhachDua = Convert.ToSingle(txtKhachDua.Text);
                    float tongTien = Convert.ToSingle(txtTongTien.Text);
                    if (tienKhachDua < tongTien)
                    {
                        MessageBox.Show("Số tiền khách đưa chưa đủ");
                    }
                    else
                    {
                        HoaDon hoaDon = new HoaDon();
                        hoaDon.MaKhachHang = Convert.ToInt32(txtMaKhachHang.Text);
                        hoaDon.MaNhanVien = this.MaTaiKhoan;
                        hoaDon.NgayLap = Convert.ToDateTime(txtNgayNhap.Text);
                        hoaDon.TongTien = Convert.ToSingle(txtTongTien.Text);
                        hoaDon.TrangThai = 1;

                        if (hoaDonBUS.ThemHoaDon(hoaDon))
                        {
                            int maHoaDonVuaTao = hoaDonBUS.getHoaDon().Last<HoaDon>().MaHoaDon;

                            for (int i = 0; i < danhSachGioHang.RowCount; i++)
                            {
                                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                                chiTietHoaDon.MaHoaDon = maHoaDonVuaTao;
                                chiTietHoaDon.MaChiTietSanPham = Convert.ToInt32(danhSachGioHang.Rows[i].Cells[0].Value);
                                chiTietHoaDon.GiaSanPham = Convert.ToSingle(danhSachGioHang.Rows[i].Cells[4].Value);
                                chiTietHoaDon.SoLuong = Convert.ToInt32(danhSachGioHang.Rows[i].Cells[5].Value);
                                chiTietHoaDon.ThanhTien = Convert.ToSingle(danhSachGioHang.Rows[i].Cells[6].Value);
                                chiTietHoaDonBUS.ThemChiTietHoaDon(chiTietHoaDon);
                                ChiTietSanPham chiTietSanPham = chiTietSanPhamBUS.LayChiTietSanPhamQuaMa(chiTietHoaDon.MaChiTietSanPham);
                                chiTietSanPham.SoLuongTon -= chiTietHoaDon.SoLuong;

                                SanPham sanPham = sanPhamBUS.LaySanPhamQuaMa(chiTietSanPham.MaSanPham);
                                sanPham.SoLuongTon -= chiTietHoaDon.SoLuong;
                                chiTietSanPhamBUS.CapNhatSoLuong(chiTietSanPham);
                                sanPhamBUS.CapNhatSoLuong(sanPham);

                            }
                            MessageBox.Show("Giao dịch thành công");
                            DialogResult result = MessageBox.Show("Bạn có muốn in hóa đơn!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                PrintDialog printDialog = new PrintDialog();
                                printDialog.Document = printDocument1;
                                DialogResult result2 = printDialog.ShowDialog();
                                if (result2 == DialogResult.OK)
                                {
                                    printDocument1.Print();
                                }


                            }
                            LamMoiHoaDon();
                            LoadDataChiTietSanPham();
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Vui lòng thêm sản phẩm vào giỏ hàng trước khi thực hiện thanh toán");
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
            e.Graphics.DrawString(txtTenNhanVien.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(150, 120));

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
            for (int i = 0; i < danhSachGioHang.Rows.Count; i++)
            {
                e.Graphics.DrawString((i + 1) + "", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(20, point));
                e.Graphics.DrawString(danhSachGioHang.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(80, point));
                e.Graphics.DrawString(danhSachGioHang.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(290, point));
                e.Graphics.DrawString(danhSachGioHang.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(390, point));
                e.Graphics.DrawString(danhSachGioHang.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(450, point));
                e.Graphics.DrawString(danhSachGioHang.Rows[i].Cells[5].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(560, point));
                e.Graphics.DrawString(danhSachGioHang.Rows[i].Cells[6].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(630, point));

                point += 25;
            }
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, point));
            e.Graphics.DrawString("Tổng Tiền: ",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(500, point += 25));
            e.Graphics.DrawString(txtTongTien.Text,
                new Font("Arial", 10, FontStyle.Bold), Brushes.Red, new Point(600, point));
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboxTimKiem.Text))
            {
                MessageBox.Show("Vui lòng chọn tìm kiếm sản phẩm theo mã hoặc tên");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
                {
                    MessageBox.Show("Vui lòng nhập sản phẩm cần tìm");
                }
                else
                {
                    if (comboxTimKiem.Text == "Theo mã")
                    {
                        CheckError check = new CheckError();
                        if (check.IsNumeric(txtTimKiem.Text))
                        {
                            LoadDataChiTietSanPham(Convert.ToInt32(txtTimKiem.Text));
                        }
                    }
                    else if (comboxTimKiem.Text == "Theo tên")
                    {
                        LoadDataChiTietSanPham(txtTimKiem.Text);
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
