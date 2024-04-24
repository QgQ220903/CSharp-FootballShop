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
    public partial class SanPhamGUI : Form
    {

        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        MauSacBUS mauSacBUS = new MauSacBUS();
        KichCoBUS kichCoBUS = new KichCoBUS();
        NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();

        public SanPhamGUI()
        {
            InitializeComponent();
            LoadDataSanPham();
        }

        // Load dữ liệu sản phẩm lên bảng
        public void LoadDataSanPham()
        {
            danhSachSanPham.RowCount = 0;
            foreach (SanPham sanPham in sanPhamBUS.LayDanhSachSanPham())
            {
                if (sanPham.TrangThai == 1)
                {
                    danhSachSanPham.Rows.Add(
                       sanPham.MaSanPham,
                       sanPham.TenSanPham,
                       theLoaiBUS.LayTheLoaiQuaMa(sanPham.MaTheLoai).TenTheLoai,
                       nhaCungCapBUS.LayNhaCungCapQuaMa(sanPham.MaNhaCungCap).TenNhaCungCap,
                       sanPham.GiaBan.ToString("C", new CultureInfo("vi-VN")),
                       sanPham.GiaNhap.ToString("C", new CultureInfo("vi-VN")),
                       sanPham.SoLuongTon);
                }
            }

            danhSachSanPham.Columns[0].Width = 100; 
            danhSachSanPham.Columns[1].Width = 400;
            danhSachSanPham.Columns[2].Width = 150;
            danhSachSanPham.Columns[3].Width = 300;
            danhSachSanPham.Columns[4].Width = 120;
            danhSachSanPham.Columns[5].Width = 120;
            danhSachSanPham.Columns[6].Width = 100;






        }

        public void LoadDataSanPham(string text)
        {
            danhSachSanPham.RowCount = 0;
            foreach (SanPham sanPham in sanPhamBUS.TimKiemSanPham(text))
            {
                if (sanPham.TrangThai == 1)
                {
                    danhSachSanPham.Rows.Add(
                       sanPham.MaSanPham,
                       sanPham.TenSanPham,
                       theLoaiBUS.LayTheLoaiQuaMa(sanPham.MaTheLoai).TenTheLoai,
                       nhaCungCapBUS.LayNhaCungCapQuaMa(sanPham.MaNhaCungCap).TenNhaCungCap,
                       sanPham.GiaBan.ToString("C", new CultureInfo("vi-VN")),
                       sanPham.GiaNhap.ToString("C", new CultureInfo("vi-VN")),
                       sanPham.SoLuongTon);
                }
            }

        }

        public void ShowDialogThem(SanPhamModule sanPhamModule)
        {
            sanPhamModule.btnThem.Visible = true;
            sanPhamModule.btnSua.Visible = false;
        }

        public void ShowDialogSua(SanPhamModule sanPhamModule)
        {
            sanPhamModule.btnThem.Visible = false;
            sanPhamModule.btnSua.Visible = true;
        }

        public void LoadComboboxTheLoai(SanPhamModule sanPhamModule)
        {
            foreach (var item in theLoaiBUS.LayDanhSachTheLoai())
            {
                if (item.TrangThai == 1)
                {
                    sanPhamModule.comboxTheLoai.Items.Add(item.TenTheLoai);
                }
            }
        }

        public void LoadComboboxNhaCungCap(SanPhamModule sanPhamModule)
        {
            foreach (var item in nhaCungCapBUS.LayDanhSachNhaCungCap())
            {
                if (item.TrangThai == 1)
                {
                    sanPhamModule.comboxNhaCungCap.Items.Add(item.TenNhaCungCap);
                }
            }
        }

        public void LoadComboboxMauSac(ChiTietSanPhamGUI chiTietSanPhamGUI)
        {
            foreach (var item in mauSacBUS.LayDanhSachMauSac())
            {
                if (item.TrangThai == 1)
                {
                    chiTietSanPhamGUI.comboxMauSac.Items.Add(item.TenMauSac);
                }
            }
        }

        public void LoadComboboxKichCo(ChiTietSanPhamGUI chiTietSanPhamGUI)
        {
            foreach (var item in kichCoBUS.LayDanhSachKichCo())
            {
                if (item.TrangThai == 1)
                {
                    chiTietSanPhamGUI.comboxKichCo.Items.Add(item.TenKichCo);
                }
            }
        }

        private void danhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = danhSachSanPham.Rows[e.RowIndex];
            int maSanPham = Convert.ToInt32(row.Cells[0].Value.ToString());
            SanPham sanPham = sanPhamBUS.LaySanPhamQuaMa(maSanPham);


            string selectedColumnName = danhSachSanPham.Columns[e.ColumnIndex].Name;
            if (selectedColumnName == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    if(sanPham.SoLuongTon == 0)
                    {
                        if (sanPhamBUS.XoaSanPham(maSanPham))
                        {
                            MessageBox.Show("Xóa thành công");


                            LoadDataSanPham();
                            chiTietSanPhamBUS.XoaChiTietTheoMaSanPham(maSanPham);
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại");
                        }
                    } 
                    else
                    {
                        MessageBox.Show("Không thể xóa sản phẩm vì còn số lượng tồn");
                    }
                    
                }
            }
            else if (selectedColumnName == "Sua")
            {
                SanPhamModule sanPhamModule = new SanPhamModule(maSanPham);

                // load dữ liệu cho các combobox 
                LoadComboboxTheLoai(sanPhamModule);
                LoadComboboxNhaCungCap(sanPhamModule);
                //------------------------------------------------------------------------------


                // set giá trị cho các combobox thuộc tính trùng với sản phẩm chọn
                sanPhamModule.comboxTheLoai.Text = theLoaiBUS.LayTheLoaiQuaMa(sanPham.MaTheLoai).TenTheLoai;
                sanPhamModule.comboxNhaCungCap.Text = nhaCungCapBUS.LayNhaCungCapQuaMa(sanPham.MaNhaCungCap).TenNhaCungCap;
                //-------------------------------------------------------------------------------


                // set giá trị cho các trường dữ liệu còn lại
                sanPhamModule.txtTenSanPham.Text = sanPham.TenSanPham;
                sanPhamModule.txtGiaNhap.Text = sanPham.GiaNhap.ToString();
                ShowDialogSua(sanPhamModule);
                sanPhamModule.ShowDialog();
                LoadDataSanPham();
                //-------------------------------------------------------------------------------
            }

            else if (selectedColumnName == "ChiTiet")
            {
                ChiTietSanPhamGUI chiTietSanPhamGUI = new ChiTietSanPhamGUI(sanPham.MaSanPham);
                chiTietSanPhamGUI.txtMaSanPham.Text = sanPham.MaSanPham + "";
                chiTietSanPhamGUI.txtTenSanPham.Text = sanPham.TenSanPham;
                LoadComboboxMauSac(chiTietSanPhamGUI);
                LoadComboboxKichCo(chiTietSanPhamGUI);
                chiTietSanPhamGUI.ShowDialog();

            }
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            SanPhamModule sanPhamModule = new SanPhamModule();
            ShowDialogThem(sanPhamModule);
            LoadComboboxNhaCungCap(sanPhamModule);
            LoadComboboxTheLoai(sanPhamModule);
            sanPhamModule.ShowDialog();
            LoadDataSanPham();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                LoadDataSanPham();
            }
            else
            {
                LoadDataSanPham(txtTimKiem.Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
