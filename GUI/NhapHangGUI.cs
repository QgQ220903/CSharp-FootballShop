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
    public partial class NhapHangGUI : Form
    {
        public int NhanVien { get; set; }
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
        PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        MauSacBUS mauSacBUS = new MauSacBUS();
        KichCoBUS kichCoBUS = new KichCoBUS();
        public NhapHangGUI()
        {
            InitializeComponent();
        }

        public NhapHangGUI(int maNhanVien)
        {
            InitializeComponent();
            LoadDataPhieuNhap();
            loadComboboxNhanVien();
            this.NhanVien = maNhanVien;
        }

        public void LoadDataPhieuNhap()
        {
            danhSachPhieuNhap.RowCount = 0;
            foreach (var item in phieuNhapBUS.LayToanBoPhieuNhap())
            {
                if (item.TrangThai == 1)
                {
                    danhSachPhieuNhap.Rows.Add(
                        item.MaPhieuNhap,
                        nhaCungCapBUS.LayNhaCungCapQuaMa(item.MaNhaCungCap).TenNhaCungCap,
                        nhanVienBUS.LayNhanVienQuaMa(item.MaNhanVien).TenNhanVien,
                        item.NgayNhap,
                        item.TongTien.ToString("C", new CultureInfo("vi-VN")));
                }
            }
        }

        public void LoadDataPhieuNhap(string batDau, string ketThuc, int maNhanVien)
        {
            danhSachPhieuNhap.RowCount = 0;
            foreach (var item in phieuNhapBUS.LayPhieuNhapTheoNgay(batDau, ketThuc, maNhanVien))
            {
                if (item.TrangThai == 1)
                {
                    danhSachPhieuNhap.Rows.Add(
                        item.MaPhieuNhap,
                        nhaCungCapBUS.LayNhaCungCapQuaMa(item.MaNhaCungCap).TenNhaCungCap,
                        nhanVienBUS.LayNhanVienQuaMa(item.MaNhanVien).TenNhanVien,
                        item.NgayNhap,
                        item.TongTien.ToString("C", new CultureInfo("vi-VN")));
                }
            }
        }




        public void loadComboboxNhanVien()
        {
            comboBoxNhanVien.Items.Clear();
            foreach (var item in nhanVienBUS.LayDanhSachNhanVien())
            {
                comboBoxNhanVien.Items.Add(item.MaNhanVien + "-" + item.TenNhanVien);
            }
            comboBoxNhanVien.Items.Add("Tất cả");
            comboBoxNhanVien.SelectedItem = "Tất cả";
        }





        public void showDialogThem(NhapHangModule nhapHangModule)
        {
            NhanVien nhanVien = nhanVienBUS.LayNhanVienQuaMa(this.NhanVien);
            nhapHangModule.txtTenNhanVien.Text = nhanVien.MaNhanVien + "-" + nhanVien.TenNhanVien;
            nhapHangModule.txtNgayNhap.Text = DateTime.Now.ToString();
            nhapHangModule.comboxNhaCungCap.Items.Clear();
            foreach (var item in nhaCungCapBUS.LayDanhSachNhaCungCap())
            {

                if (item.TrangThai == 1)
                {
                    nhapHangModule.comboxNhaCungCap.Items.Add(item.TenNhaCungCap);
                }
            }


        }
        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            NhapHangModule nhapHangModule = new NhapHangModule();

            showDialogThem(nhapHangModule);
            nhapHangModule.ShowDialog();
            LoadDataPhieuNhap();
        }

        private void danhSachPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = danhSachPhieuNhap.Rows[e.RowIndex];

            int maPhieuNhap = Convert.ToInt32(row.Cells[0].Value.ToString());
            PhieuNhap phieuNhap = phieuNhapBUS.LayPhieuNhapQuaMa(maPhieuNhap);

            string selectedColumnName = danhSachPhieuNhap.Columns[e.ColumnIndex].Name;
            if (selectedColumnName == "ChiTiet")
            {
                ChiTietPhieuNhapGUI chiTietPhieuNhapGUI = new ChiTietPhieuNhapGUI(maPhieuNhap);
                chiTietPhieuNhapGUI.ShowDialog();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDataPhieuNhap();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (comboBoxNhanVien.Text == "Tất cả" || string.IsNullOrWhiteSpace(comboBoxNhanVien.Text))
            {
                LoadDataPhieuNhap(dateBatDau.Text, dateKetThuc.Text, 0);
            }
            else
            {

                int maNhanVien = Convert.ToInt32(comboBoxNhanVien.Text.Split("-")[0]);
                LoadDataPhieuNhap(dateBatDau.Text, dateKetThuc.Text, maNhanVien);
            }
        }
    }
}
