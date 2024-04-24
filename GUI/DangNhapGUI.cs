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
    public partial class DangNhapGUI : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        ChiTietQuyenBUS chiTietQuyenBUS = new ChiTietQuyenBUS();
        public DangNhapGUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void DangNhap()
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
                {
                    MessageBox.Show("Tên đăng nhập không được để trống");
                    txtTenDangNhap.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                {
                    MessageBox.Show("Mật khẩu không được để trống");
                    txtMatKhau.Focus();
                }
            }
            else
            {
                string tenDangNhap = txtTenDangNhap.Text;
                string matKhau = txtMatKhau.Text;
                if (taiKhoanBUS.DangNhap(tenDangNhap, matKhau))
                {
                    TaiKhoan taiKhoan = taiKhoanBUS.LayThongTinTaiKhoan(tenDangNhap, matKhau);
                    int maTaiKhoan = taiKhoan.MaTaiKhoan;
                    int maNhomQuyen = taiKhoan.MaNhomQuyen;
                    List<int> danhSachMaChucNang = chiTietQuyenBUS.LayDanhSachChucNang(maNhomQuyen);
                    TrangChuGUI trangChuGUI = new TrangChuGUI(maTaiKhoan, maNhomQuyen, danhSachMaChucNang);
                    trangChuGUI.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                    txtMatKhau.Text = "";
                }
            }


        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();

        }

        private void chkHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMatKhau.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
