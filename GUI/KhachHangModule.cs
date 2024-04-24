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
    public partial class KhachHangModule : Form
    {
        KhachHangBUS khachHangBUS = new KhachHangBUS();
        public int MaKhachHang { get; set; }
        public KhachHangModule()
        {
            InitializeComponent();
        }

        public KhachHangModule(int mKhachHang)
        {
            InitializeComponent();
            this.MaKhachHang = mKhachHang;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtSoDienThoai.Text)) 
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");    
            } else
            {
                CheckError check = new CheckError();
                if(check.IsPhoneNumberValid(txtSoDienThoai.Text))
                {
                    KhachHang khachHang = new KhachHang();
                    khachHang.TenKhachHang = txtTen.Text;
                    khachHang.SoDienThoai = txtSoDienThoai.Text;
                    if(khachHangBUS.ThemKhachHang(khachHang))
                    {
                        MessageBox.Show("Thêm thành  công");
                        this.Dispose();
                    } else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                } 
                else
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng (VD: Bắt đầu bằng 0xxx và có 10 số)");

                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                CheckError check = new CheckError();
                if (check.IsPhoneNumberValid(txtSoDienThoai.Text))
                {
                    KhachHang khachHang = new KhachHang();
                    khachHang.MaKhachHang = this.MaKhachHang;
                    khachHang.TenKhachHang = txtTen.Text;
                    khachHang.SoDienThoai = txtSoDienThoai.Text;
                    if (khachHangBUS.SuaKhachHang(khachHang))
                    {
                        MessageBox.Show("Sửa thành công");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng (VD: Bắt đầu bằng 0xxx và có 10 số)");

                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
