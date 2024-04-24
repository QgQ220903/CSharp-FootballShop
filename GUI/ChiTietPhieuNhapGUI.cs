using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ChiTietPhieuNhapGUI : Form
    {
        ChiTietPhieuNhapBUS chiTietPhieuNhapBUS = new ChiTietPhieuNhapBUS();
        PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
        NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();
        MauSacBUS mauSacBUS = new MauSacBUS();
        KichCoBUS kichCoBUS = new KichCoBUS();
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        public int maPhieuNhap { get; set; }

        public ChiTietPhieuNhapGUI()
        {
            InitializeComponent();
        }

        public ChiTietPhieuNhapGUI(int maPhieuNhap)
        {
            InitializeComponent();
            this.maPhieuNhap = maPhieuNhap;
            PhieuNhap phieuNhap = phieuNhapBUS.LayPhieuNhapQuaMa(maPhieuNhap);
            lbMaPhieu.Text = phieuNhap.MaPhieuNhap.ToString();
            lbNguoiNhap.Text = nhanVienBUS.LayNhanVienQuaMa(phieuNhap.MaNhanVien).TenNhanVien;
            lbNgayNhap.Text = phieuNhap.NgayNhap.ToString();
            lbNhaCungCap.Text = nhaCungCapBUS.LayNhaCungCapQuaMa(phieuNhap.MaNhaCungCap).TenNhaCungCap;
            lbTongTien.Text = phieuNhap.TongTien.ToString();
            LoadDataTable(maPhieuNhap);

        }

        public void LoadDataTable(int maPhieuNhap)
        {
            danhSachChiTietPhieuNhap.RowCount = 0;
            foreach (var item in chiTietPhieuNhapBUS.LayChiTietQuaMaPhieuNhap(maPhieuNhap))
            {
                ChiTietSanPham chiTietSanPham = chiTietSanPhamBUS.LayChiTietSanPhamQuaMa(item.MaChiTietSanPham);
                SanPham sanPham = sanPhamBUS.LaySanPhamQuaMa(chiTietSanPham.MaSanPham);
                MauSac mauSac = mauSacBUS.LayMauSacQuaMa(chiTietSanPham.MaMauSac);
                KichCo kichCo = kichCoBUS.LayKichCoQuaMa(chiTietSanPham.MaKichCo);
                danhSachChiTietPhieuNhap.Rows.Add(item.MaChiTietPhieuNhap, item.MaPhieuNhap, sanPham.TenSanPham, mauSac.TenMauSac, kichCo.TenKichCo, item.SoLuong, item.DonVi, item.GiaNhap, item.ThanhTien);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn in phiếu nhập!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            
        }

        private void ChiTietPhieuNhapGUI_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("PHIẾU NHẬP", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(350, 20));

            e.Graphics.DrawString("Mã Phiếu: ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 60));
            e.Graphics.DrawString(lbMaPhieu.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(110, 60));

            e.Graphics.DrawString("Ngày Nhập: ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 80));
            e.Graphics.DrawString(lbNgayNhap.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(120, 80));

            e.Graphics.DrawString("Người Nhập: ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 100));
            e.Graphics.DrawString(lbNguoiNhap.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(130, 100));

            e.Graphics.DrawString("Nhà Cung Cấp: ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 120));
            e.Graphics.DrawString(lbNhaCungCap.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(150, 120));

            e.Graphics.DrawString("Thông Tin Chi Tiết", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 160));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 175));
            e.Graphics.DrawString("STT", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(20, 190));
            e.Graphics.DrawString("Tên Sản Phẩm", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(80, 190));
            e.Graphics.DrawString("Màu", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(300, 190));
            e.Graphics.DrawString("Kích Cỡ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(370, 190));
            e.Graphics.DrawString("Số Lượng", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(450, 190));
            e.Graphics.DrawString("Đơn Vị", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(560, 190));
            e.Graphics.DrawString("Giá Nhập", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(620, 190));
            e.Graphics.DrawString("Thành Tiền", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(730, 190));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 200));
            int point = 220;
            for (int i = 0; i < danhSachChiTietPhieuNhap.Rows.Count; i++)
            {
                e.Graphics.DrawString((i + 1) + "", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(20, point));
                e.Graphics.DrawString(danhSachChiTietPhieuNhap.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(80, point));
                e.Graphics.DrawString(danhSachChiTietPhieuNhap.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(300, point));
                e.Graphics.DrawString(danhSachChiTietPhieuNhap.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(390, point));
                e.Graphics.DrawString(danhSachChiTietPhieuNhap.Rows[i].Cells[5].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(460, point));
                e.Graphics.DrawString(danhSachChiTietPhieuNhap.Rows[i].Cells[6].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(560, point));
                e.Graphics.DrawString(danhSachChiTietPhieuNhap.Rows[i].Cells[7].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(620, point));
                e.Graphics.DrawString(danhSachChiTietPhieuNhap.Rows[i].Cells[8].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(740, point));
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
