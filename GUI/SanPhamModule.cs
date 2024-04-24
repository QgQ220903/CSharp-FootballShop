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
    public partial class SanPhamModule : Form
    {
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
        public int MaSanPham { get; set; }

        public SanPhamModule()
        {
            InitializeComponent();
        }

        public SanPhamModule(int maSanPham)
        {

            InitializeComponent();
            this.MaSanPham = maSanPham;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text) ||
                string.IsNullOrWhiteSpace(txtGiaNhap.Text) ||
                string.IsNullOrWhiteSpace(comboxTheLoai.Text) ||
                string.IsNullOrWhiteSpace(comboxNhaCungCap.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                SanPham sanPham = new SanPham();
                sanPham.TenSanPham = txtTenSanPham.Text;
                sanPham.MaTheLoai = theLoaiBUS.LayTheLoaiQuaTen(comboxTheLoai.Text).MaTheLoai;
                sanPham.MaNhaCungCap = nhaCungCapBUS.LayNhaCungCapQuaTen(comboxNhaCungCap.Text).MaNhaCungCap;
                float giaNhap = Convert.ToSingle(txtGiaNhap.Text);
                sanPham.GiaNhap = giaNhap;
                sanPham.GiaBan = giaNhap + ((giaNhap * 20) / 100);
                sanPham.SoLuongTon = 0;
                sanPham.TrangThai = 1;

                if (sanPhamBUS.ThemSanPham(sanPham))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text) ||
                string.IsNullOrWhiteSpace(txtGiaNhap.Text) ||
                string.IsNullOrWhiteSpace(comboxTheLoai.Text) ||
                string.IsNullOrWhiteSpace(comboxNhaCungCap.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                SanPham sanPham = new SanPham();
                sanPham.MaSanPham = this.MaSanPham;
                sanPham.TenSanPham = txtTenSanPham.Text;
                sanPham.MaTheLoai = theLoaiBUS.LayTheLoaiQuaTen(comboxTheLoai.Text).MaTheLoai;
                sanPham.MaNhaCungCap = nhaCungCapBUS.LayNhaCungCapQuaTen(comboxNhaCungCap.Text).MaNhaCungCap;
                float giaNhap = Convert.ToSingle(txtGiaNhap.Text);
                sanPham.GiaNhap = giaNhap;
                sanPham.GiaBan = giaNhap + ((giaNhap * 20) / 100);
                sanPham.SoLuongTon = 0;
                sanPham.TrangThai = 1;

                if (sanPhamBUS.SuaSanPham(sanPham))
                {
                    MessageBox.Show("Sửa thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
