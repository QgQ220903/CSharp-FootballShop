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
    public partial class NhapHangModule : Form
    {
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();
        NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
        PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
        ChiTietPhieuNhapBUS chiTietPhieuNhapBUS = new ChiTietPhieuNhapBUS();
        public int maCTSPClick { get; set; }

        MauSacBUS mauSacBUS = new MauSacBUS();
        KichCoBUS kichCoBUS = new KichCoBUS();
        public NhapHangModule()
        {
            InitializeComponent();
        }
        public void LoadDataChiTietSanPham(string tenNhaCungCap)
        {
            danhSachChiTietSanPham.RowCount = 0;
            NhaCungCap nhaCungCap = nhaCungCapBUS.LayNhaCungCapQuaTen(tenNhaCungCap);
            foreach (var item1 in sanPhamBUS.LaySanPhamQuaNhaCungCap(nhaCungCap.MaNhaCungCap))
            {
                foreach (var item2 in chiTietSanPhamBUS.LayDanhSachChiTietTheoMaSanPham(item1.MaSanPham))
                {
                    danhSachChiTietSanPham.Rows.Add(item2.MaChiTietSanPham, sanPhamBUS.LaySanPhamQuaMa(item2.MaSanPham).TenSanPham, mauSacBUS.LayMauSacQuaMa(item2.MaMauSac).TenMauSac, kichCoBUS.LayKichCoQuaMa(item2.MaKichCo).TenKichCo, item2.SoLuongTon);

                }
            }
        }
        public void LoadDataChiTietSanPham(string tenNhaCungCap, string tenSanPham)
        {
            danhSachChiTietSanPham.RowCount = 0;
            NhaCungCap nhaCungCap = nhaCungCapBUS.LayNhaCungCapQuaTen(tenNhaCungCap);
            foreach (var item1 in sanPhamBUS.LaySanPhamQuaNhaCungCap(nhaCungCap.MaNhaCungCap, tenSanPham))
            {
                foreach (var item2 in chiTietSanPhamBUS.LayDanhSachChiTietTheoMaSanPham(item1.MaSanPham))
                {
                    danhSachChiTietSanPham.Rows.Add(item2.MaChiTietSanPham, sanPhamBUS.LaySanPhamQuaMa(item2.MaSanPham).TenSanPham, mauSacBUS.LayMauSacQuaMa(item2.MaMauSac).TenMauSac, kichCoBUS.LayKichCoQuaMa(item2.MaKichCo).TenKichCo, item2.SoLuongTon);
                }

            }
        }

        private void comboxNhaCungCap_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDataChiTietSanPham(comboxNhaCungCap.Text);

        }

        private void danhSachChiTietSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow row = danhSachChiTietSanPham.Rows[e.RowIndex];
                int maChiTietSanPham = Convert.ToInt32(row.Cells[0].Value.ToString());
                this.maCTSPClick = maChiTietSanPham;
                ChiTietSanPham chiTietSanPham = chiTietSanPhamBUS.LayChiTietSanPhamQuaMa(maChiTietSanPham);
                SanPham sanPham = sanPhamBUS.LaySanPhamQuaMa(chiTietSanPham.MaSanPham);
                txtGiaNhap.Text = sanPham.GiaNhap + "";
                txtMaChiTietSanPham.Text = maChiTietSanPham + "";
            }
        }

        public bool KiemTraNhapHangTrunng(ChiTietSanPham chiTietSanPham)
        {
            for (int i = 0; i < danhSachChiTietPhieuNhap.RowCount; i++)
            {
                if (danhSachChiTietPhieuNhap.Rows[i].Cells[0].Value.ToString() == chiTietSanPham.MaChiTietSanPham.ToString()
                   && danhSachChiTietPhieuNhap.Rows[i].Cells[2].Value.ToString() == mauSacBUS.LayMauSacQuaMa(chiTietSanPham.MaMauSac).TenMauSac
                   && danhSachChiTietPhieuNhap.Rows[i].Cells[3].Value.ToString() == kichCoBUS.LayKichCoQuaMa(chiTietSanPham.MaKichCo).TenKichCo)
                {
                    int soLuongHienTai = Convert.ToInt32(danhSachChiTietPhieuNhap.Rows[i].Cells[4].Value);
                    double giaNhap = Convert.ToSingle(txtGiaNhap.Text);
                    double thanhTienHienTai = Convert.ToSingle(danhSachChiTietPhieuNhap.Rows[i].Cells[7].Value.ToString());
                    int soLuongNhapThem = Convert.ToInt32(slNhap.Value);
                    double thanhTienThem = giaNhap * soLuongNhapThem;
                    thanhTienHienTai += thanhTienThem;
                    soLuongHienTai += soLuongNhapThem;

                    danhSachChiTietPhieuNhap.Rows[i].Cells[4].Value = soLuongHienTai;
                    danhSachChiTietPhieuNhap.Rows[i].Cells[7].Value = thanhTienHienTai;

                    double tongTien = Convert.ToSingle(txtTongTien.Text);
                    tongTien += thanhTienThem;
                    txtTongTien.Text = tongTien + "";
                    return true;
                }
            }
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaChiTietSanPham.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để nhập hàng");
            }
            else
            {
                if (string.IsNullOrEmpty(comboxDonVi.Text))
                {
                    MessageBox.Show("Vui lòng chọn đơn vị nhập");
                }
                else
                {
                    if (slNhap.Value < 0 || slNhap.Value == 0)
                    {
                        MessageBox.Show("Số lượng nhập phải là số nguyên > 0");
                    }
                    else
                    {
                        ChiTietSanPham chiTietSanPham = chiTietSanPhamBUS.LayChiTietSanPhamQuaMa(this.maCTSPClick);
                        if (KiemTraNhapHangTrunng(chiTietSanPham))
                        {
                            MessageBox.Show("Đã cộng thêm sản phẩm");
                        }
                        else
                        {
                            double tongTien = Convert.ToSingle(txtTongTien.Text);

                            double giaNhap = Convert.ToSingle(txtGiaNhap.Text);
                            int soLuongNhap = Convert.ToInt32(slNhap.Value);

                            double thanhTien = giaNhap * soLuongNhap;

                            tongTien += thanhTien;
                            txtTongTien.Text = tongTien.ToString();


                            danhSachChiTietPhieuNhap.Rows.Add(
                                txtMaChiTietSanPham.Text,
                                sanPhamBUS.LaySanPhamQuaMa(chiTietSanPham.MaSanPham).TenSanPham,
                                mauSacBUS.LayMauSacQuaMa(chiTietSanPham.MaMauSac).TenMauSac,
                                kichCoBUS.LayKichCoQuaMa(chiTietSanPham.MaKichCo).TenKichCo,
                                slNhap.Value,
                                comboxDonVi.Text,
                                txtGiaNhap.Text,
                                thanhTien
                                );
                        }


                    }
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                LoadDataChiTietSanPham(comboxNhaCungCap.Text);
            }
            else
            {
                LoadDataChiTietSanPham(comboxNhaCungCap.Text, txtTimKiem.Text);
            }
        }

        private void buttonLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            if(danhSachChiTietPhieuNhap.RowCount == 0)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin phiếu nhập");
            } 
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn tạo phiếu nhập!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int maNhaCungCap = nhaCungCapBUS.LayNhaCungCapQuaTen(comboxNhaCungCap.Text).MaNhaCungCap;
                    string[] nhanVien = txtTenNhanVien.Text.Split('-');
                    int maNhanVien = Convert.ToInt32(nhanVien[0]);
                    DateTime ngayNhap = Convert.ToDateTime(txtNgayNhap.Text);
                    float tongTien = Convert.ToSingle(txtTongTien.Text);

                    PhieuNhap phieuNhap = new PhieuNhap();
                    phieuNhap.MaNhaCungCap = maNhaCungCap;
                    phieuNhap.MaNhanVien = maNhanVien;
                    phieuNhap.NgayNhap = ngayNhap;
                    phieuNhap.TongTien = tongTien;
                    phieuNhap.TrangThai = 1;
                    if (danhSachChiTietPhieuNhap.RowCount > 0)
                    {
                        if (phieuNhapBUS.ThemPhieuNhap(phieuNhap))
                        {

                            for (int i = 0; i < danhSachChiTietPhieuNhap.RowCount; i++)
                            {
                                ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();
                                chiTietPhieuNhap.MaPhieuNhap = Convert.ToInt32(phieuNhapBUS.LayPhieuNhapMoiNhat().MaPhieuNhap);
                                chiTietPhieuNhap.MaChiTietSanPham = Convert.ToInt32(danhSachChiTietPhieuNhap.Rows[i].Cells[0].Value.ToString());
                                chiTietPhieuNhap.SoLuong = Convert.ToInt32(danhSachChiTietPhieuNhap.Rows[i].Cells[4].Value.ToString());
                                chiTietPhieuNhap.DonVi = danhSachChiTietPhieuNhap.Rows[i].Cells[5].Value.ToString();
                                chiTietPhieuNhap.GiaNhap = Convert.ToSingle(danhSachChiTietPhieuNhap.Rows[i].Cells[6].Value.ToString());
                                chiTietPhieuNhap.ThanhTien = Convert.ToSingle(danhSachChiTietPhieuNhap.Rows[i].Cells[7].Value.ToString());
                                if (chiTietPhieuNhapBUS.ThemChiTietPhieuNhap(chiTietPhieuNhap))
                                {
                                    ChiTietSanPham chiTietSanPham = chiTietSanPhamBUS.LayChiTietSanPhamQuaMa(chiTietPhieuNhap.MaChiTietSanPham);
                                    chiTietSanPham.SoLuongTon += chiTietPhieuNhap.SoLuong;

                                    SanPham sanPham = sanPhamBUS.LaySanPhamQuaMa(chiTietSanPham.MaSanPham);
                                    sanPham.SoLuongTon += chiTietPhieuNhap.SoLuong;
                                    chiTietSanPhamBUS.CapNhatSoLuong(chiTietSanPham);
                                    sanPhamBUS.CapNhatSoLuong(sanPham);


                                }

                            }
                            MessageBox.Show("Nhập hàng thành công");
                            this.Dispose();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin phiếu nhập");
                    }
                }
            }

                
        }

        private void comboxNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void danhSachChiTietPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = danhSachChiTietPhieuNhap.Rows[e.RowIndex];


            string selectedColumnName = danhSachChiTietPhieuNhap.Columns[e.ColumnIndex].Name;
            if (selectedColumnName == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    float tongTien = Convert.ToSingle(txtTongTien.Text);
                    tongTien = tongTien - Convert.ToSingle(row.Cells[7].Value + "");
                    txtTongTien.Text = tongTien + "";
                    danhSachChiTietPhieuNhap.Rows.Remove(row);
                }
            }
        }
    }
}
