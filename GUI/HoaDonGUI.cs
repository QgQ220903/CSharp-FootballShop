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
    public partial class HoaDonGUI : Form
    {
        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        KhachHangBUS khachHangBUS = new KhachHangBUS();
        public int khachhang { get; set; }
        public HoaDonGUI()
        {
            InitializeComponent();
            loadDataHoaDon();
            loadComboboxNhanVien();
        }

        public HoaDonGUI(int maKhachHang)
        {
            InitializeComponent();
            this.khachhang = maKhachHang;
            loadDataHoaDon(this.khachhang);
            loadComboboxNhanVien();
        }

        public void loadDataHoaDon()
        {
            danhSachHoaDon.RowCount = 0;
            foreach (var item in hoaDonBUS.getHoaDon())
            {
                if (item.TrangThai == 1)
                {
                    danhSachHoaDon.Rows.Add(
                        item.MaHoaDon,
                        khachHangBUS.LayKhachHangQuaMa(item.MaKhachHang).TenKhachHang,
                        nhanVienBUS.LayNhanVienQuaMa(item.MaNhanVien).TenNhanVien,
                        item.NgayLap,
                        item.TongTien.ToString("C", new CultureInfo("vi-VN"))
                        );
                }
            }
        }
        public void loadDataHoaDon(int maKhachHang)
        {
            danhSachHoaDon.RowCount = 0;
            foreach (var item in hoaDonBUS.getHoaDon(maKhachHang))
            {
                if (item.TrangThai == 1)
                {
                    danhSachHoaDon.Rows.Add(
                        item.MaHoaDon,
                        khachHangBUS.LayKhachHangQuaMa(item.MaKhachHang).TenKhachHang,
                        nhanVienBUS.LayNhanVienQuaMa(item.MaNhanVien).TenNhanVien,
                        item.NgayLap,
                        item.TongTien.ToString("C", new CultureInfo("vi-VN"))
                        );
                }
            }
        }

        public void loadDataHoaDon(string batDau, string ketThuc, int maNhanVien, int maKhachHang)
        {
            danhSachHoaDon.RowCount = 0;
            foreach (var item in hoaDonBUS.HoaDonTheoNgay(batDau, ketThuc, maNhanVien, maKhachHang))
            {
                if (item.TrangThai == 1)
                {
                    danhSachHoaDon.Rows.Add(
                        item.MaHoaDon,
                        khachHangBUS.LayKhachHangQuaMa(item.MaKhachHang).TenKhachHang,
                        nhanVienBUS.LayNhanVienQuaMa(item.MaNhanVien).TenNhanVien,
                        item.NgayLap,
                        item.TongTien.ToString("C", new CultureInfo("vi-VN"))
                        );
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

        private void danhSachHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = danhSachHoaDon.Rows[e.RowIndex];

            int maHoaDon = Convert.ToInt32(row.Cells[0].Value.ToString());

            string selectedColumnName = danhSachHoaDon.Columns[e.ColumnIndex].Name;
            if (selectedColumnName == "ChiTiet")
            {
                ChiTietHoaDonGUI chiTietHoaDonGUI = new ChiTietHoaDonGUI(maHoaDon);
                chiTietHoaDonGUI.ShowDialog();
            }
        }




        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(comboBoxNhanVien.Text == "Tất cả" || string.IsNullOrWhiteSpace(comboBoxNhanVien.Text))
            {
                loadDataHoaDon(dateBatDau.Text, dateKetThuc.Text, 0, this.khachhang);
            } 
            else
            {
                
                int maNhanVien = Convert.ToInt32(comboBoxNhanVien.Text.Split("-")[0]);
                loadDataHoaDon(dateBatDau.Text, dateKetThuc.Text, maNhanVien, this.khachhang);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            if(this.khachhang == 0)
            {
                loadDataHoaDon();
            } 
            else
            {
                loadDataHoaDon(this.khachhang);
            }
        }
    }
}
