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
    public partial class TrangChuGUI : Form
    {
        public int MaTaiKhoan { get; set; }
        public int MaNhomQuyen { get; set; }


        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        ChucNangBUS chucNangBUS = new ChucNangBUS();
        ChiTietQuyenBUS chiTietQuyenBUS = new ChiTietQuyenBUS();
        NhomQuyenBUS nhomQuyenBUS = new NhomQuyenBUS();
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        Form activeForm = null;

        // Phân Quyền
        NhomQuyenGUI nhomQuyenGUI = null;

        // Nhân Viên
        NhanVienGUI nhanVienGUI = null;

        // Tài Khoản
        TaiKhoanGUI taiKhoanGUI = null;

        // Thuộc tính sản phẩm
        TheLoaiGUI theLoaiGUI = null;
        MauSacGUI mauSacGUI = null;
        KichCoGUI kichCoGUI = null;
        ThuocTinhGUI thuocTinhGUI = null;

        // Sản phẩm
        SanPhamGUI sanPhamGUI = null;

        // Nhà cung cấp
        NhaCungCapGUI nhaCungCapGUI = null;

        // Nhập hàng
        NhapHangGUI nhapHangGUI = null;

        // Khuyến mãi
        KhuyenMaiGUI khuyenMaiGUI = null;

        // Khách Hang
        KhachHangGUI khachHangGUI = null;
        // Bán hàng
        BanHangGUI banHangGUI = null;
        // Hóa Đơn
        HoaDonGUI hoaDonGUI = null;

        // Thống kê
        ThongKeGUI thongKeGUI = null;
        public TrangChuGUI()
        {
            InitializeComponent();
        }


        public TrangChuGUI(int maTaiKhoan, int maNhomQuyen, List<int> danhSachMaChucNang)
        {
            InitializeComponent();
            this.MaNhomQuyen = maNhomQuyen;
            NhanVien nhanVien = nhanVienBUS.LayNhanVienQuaMa(maTaiKhoan);
            this.MaTaiKhoan = maTaiKhoan;


            // hiển thị tên nhân viên
            lbTenNhanVien.Text = nhanVien.TenNhanVien;
            lbNhomQuyen.Text = nhomQuyenBUS.LayNhomQuyenQuaMa(taiKhoanBUS.LayTaiKhoanQuaMa(this.MaTaiKhoan).MaNhomQuyen).TenNhomQuyen;
            // Chuyển từ kiểu Byte sang đối tượng Image 
            Image image;
            if (nhanVien.HinhAnh.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(nhanVien.HinhAnh))
                {

                    image = Image.FromStream(ms);
                }
                picNhanVien.Image = image;
            }
            else
            {
                picNhanVien.Image = Properties.Resources.Employee;
            }

            // đổi mã chức năng sang tên chức năng
            List<string> danhSachTenChucNang = new List<string>();

            foreach (var item in danhSachMaChucNang)
            {
                danhSachTenChucNang.Add(chucNangBUS.LayChucNangQuaMa(item).TenChucNang);
            }

            //dùng vòng lặp tạo ra các nút chức năng của nhóm quyền 

            if (danhSachTenChucNang.Count > 0)
            {
                foreach (var item in danhSachTenChucNang)
                {
                    Button btn = new Button();
                    btn.Text = item;
                    if (btn.Text == "Sản Phẩm")
                    {
                        btn.Image = Properties.Resources.Product;
                    }
                    else if (btn.Text == "Thuộc Tính")
                    {
                        btn.Image = Properties.Resources.Attribute;
                    }
                    else if (btn.Text == "Bán Hàng")
                    {
                        btn.Image = Properties.Resources.Cart;
                    }
                    else if (btn.Text == "Phiếu Nhập")
                    {
                        btn.Image = Properties.Resources.Invoice;
                    }
                    else if (btn.Text == "Nhân Viên")
                    {
                        btn.Image = Properties.Resources.employee2;
                    }
                    else if (btn.Text == "Khách Hàng")
                    {
                        btn.Image = Properties.Resources.Customer;

                    }
                    else if (btn.Text == "Hóa Đơn")
                    {
                        btn.Image = Properties.Resources.Bill;

                    }
                    else if (btn.Text == "Khuyến Mãi")
                    {
                        btn.Image = Properties.Resources.Sale;

                    }

                    else if (btn.Text == "Phân Quyền")
                    {
                        btn.Image = Properties.Resources.role;
                    }
                    else if (btn.Text == "Thống Kê")
                    {
                        btn.Image = Properties.Resources.Chart;

                    }
                    else if (btn.Text == "Nhà Cung Cấp")
                    {
                        btn.Image = Properties.Resources.Supplier;
                    }
                    else if (btn.Text == "Tài Khoản")
                    {
                        btn.Image = Properties.Resources.Account;
                    }




                    btn.Size = new System.Drawing.Size(293, 55);
                    btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
                    btn.Font = new System.Drawing.Font("Segoe UI Variable", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.ForeColor = System.Drawing.Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    btn.Click += new EventHandler(Click);
                    sideBar.Controls.Add(btn);
                }
                // Tạo nút đăng xuất
                Button btnDangXuat = new Button();
                btnDangXuat.Text = "Đăng Xuất";
                btnDangXuat.Size = new System.Drawing.Size(293, 55);
                btnDangXuat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
                btnDangXuat.Font = new System.Drawing.Font("Segoe UI Variable", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnDangXuat.ForeColor = System.Drawing.Color.White;
                btnDangXuat.FlatStyle = FlatStyle.Flat;
                btnDangXuat.FlatAppearance.BorderSize = 0;
                btnDangXuat.Image = Properties.Resources.logout;
                btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                btnDangXuat.Click += new EventHandler(Click);
                sideBar.Controls.Add(btnDangXuat);
            }
        }

        public void OpenForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            else
            {
                activeForm = form;
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void Click(object sender, EventArgs e)
        {
            Button check = sender as Button;
            if (check.Text == "Phân Quyền")
            {
                nhomQuyenGUI = new NhomQuyenGUI();
                OpenForm(nhomQuyenGUI);
            }
            else if (check.Text == "Bán Hàng")
            {
                banHangGUI = new BanHangGUI(this.MaTaiKhoan);
                OpenForm(banHangGUI);
            }
            else if (check.Text == "Nhân Viên")
            {
                nhanVienGUI = new NhanVienGUI();
                OpenForm(nhanVienGUI);
            }
            else if (check.Text == "Tài Khoản")
            {
                taiKhoanGUI = new TaiKhoanGUI();
                OpenForm(taiKhoanGUI);


            }
            else if (check.Text == "Thuộc Tính")
            {
                theLoaiGUI = new TheLoaiGUI();
                mauSacGUI = new MauSacGUI();
                kichCoGUI = new KichCoGUI();
                thuocTinhGUI = new ThuocTinhGUI(theLoaiGUI, mauSacGUI, kichCoGUI);
                OpenForm(thuocTinhGUI);

            }
            else if (check.Text == "Sản Phẩm")
            {
                sanPhamGUI = new SanPhamGUI();
                OpenForm(sanPhamGUI);
            }
            else if (check.Text == "Khách Hàng")
            {
                khachHangGUI = new KhachHangGUI();
                OpenForm(khachHangGUI);
            }

            else if (check.Text == "Khuyến Mãi")
            {
                khuyenMaiGUI = new KhuyenMaiGUI();
                OpenForm(khuyenMaiGUI);
            }
            else if (check.Text == "Hóa Đơn")
            {
                hoaDonGUI = new HoaDonGUI();
                OpenForm(hoaDonGUI);
            }
            else if (check.Text == "Nhà Cung Cấp")
            {
                nhaCungCapGUI = new NhaCungCapGUI();
                OpenForm(nhaCungCapGUI);
            }
            else if (check.Text == "Phiếu Nhập")
            {
                nhapHangGUI = new NhapHangGUI(MaTaiKhoan);
                OpenForm(nhapHangGUI);
            }
            else if (check.Text == "Thống Kê")
            {
                thongKeGUI = new ThongKeGUI();
                OpenForm(thongKeGUI);
            }

            else if (check.Text == "Đăng Xuất")
            {
                this.Dispose();
                DangNhapGUI dangNhapGUI = new DangNhapGUI();
                dangNhapGUI.ShowDialog();
            }

        }

        private void containerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
