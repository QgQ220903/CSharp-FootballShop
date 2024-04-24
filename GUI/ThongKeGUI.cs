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
    public partial class ThongKeGUI : Form
    {
        ThongKeBUS thongKeBUS = new ThongKeBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        KichCoBUS kichCoBUS = new KichCoBUS();
        MauSacBUS mauSacBUS = new MauSacBUS();
        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
        public ThongKeGUI()
        {
            InitializeComponent();
            LoadSPBanChay();
            LoadSPTon();
            loadDuLieuTongQuat();
        }

        public void loadDuLieuTongQuat()
        {
            float tongDoanhThu = 0;
            int tongHoaDon = 0;
            foreach (var item in hoaDonBUS.getHoaDon())
            {
                tongHoaDon++;
                tongDoanhThu += item.TongTien;

            }
            lbDoanhThu.Text = tongDoanhThu.ToString("C", new CultureInfo("vi-VN")); ;

            int tongPhieu = 0;
            foreach (var item in phieuNhapBUS.LayToanBoPhieuNhap())
            {
                tongPhieu++;
            }
            lbPhieuNhap.Text = tongPhieu + "";


            foreach (var item in hoaDonBUS.getHoaDon())
            {
                tongPhieu++;
            }
            lbPhieuNhap.Text = tongPhieu + "";
            lbHoaDonBan.Text = tongHoaDon + "";
        }

        public void LoadDataCTSP()
        {
            foreach (var item in chiTietSanPhamBUS.LayToanBoCTSPTheoSLT())
            {
                danhSachChiTietSanPham.Rows.Add(item.MaChiTietSanPham, sanPhamBUS.LaySanPhamQuaMa(item.MaSanPham).TenSanPham, mauSacBUS.LayMauSacQuaMa(item.MaMauSac).TenMauSac, kichCoBUS.LayKichCoQuaMa(item.MaKichCo).TenKichCo, item.SoLuongTon, sanPhamBUS.LaySanPhamQuaMa(item.MaSanPham).GiaBan);

            }
        }

        public void LoadSPBanChay()
        {
            danhSachBanChay.Rows.Clear();

            foreach (string item in thongKeBUS.LaySanPhamBanChay())
            {
                string[] arr = item.Split(',');

                danhSachBanChay.Rows.Add(arr[0], arr[1], arr[2]);
            }
        }

        public void LoadSPTon()
        {
            danhSachSPTon.Rows.Clear();

            foreach (string item in thongKeBUS.LaySanPhamTon())
            {
                string[] arr = item.Split(',');

                danhSachSPTon.Rows.Add(arr[0], arr[1], arr[2], arr[3], arr[4]);
            }
        }

        public void LoadSPHetHang()
        {
            danhSachSPTon.Rows.Clear();

            foreach (string item in thongKeBUS.LaySanPhamTon())
            {
                string[] arr = item.Split(',');
                if (Convert.ToInt32(arr[4]) == 0)
                {
                    danhSachSPTon.Rows.Add(arr[0], arr[1], arr[2], arr[3], arr[4]);

                }

            }
        }


        public void LoadSPGanHetHang()
        {
            danhSachSPTon.Rows.Clear();

            foreach (string item in thongKeBUS.LaySanPhamTon())
            {
                string[] arr = item.Split(',');
                if(Convert.ToInt32(arr[4]) > 0)
                {
                    if (Convert.ToInt32(arr[4]) < 10 || Convert.ToInt32(arr[4]) == 10)
                    {
                        danhSachSPTon.Rows.Add(arr[0], arr[1], arr[2], arr[3], arr[4]);

                    }
                }
                

            }
        }




        private void btnDoanhThuTheoNgay_Click(object sender, EventArgs e)
        {
            doanhThuTheoNgay.Rows.Clear();

            foreach (string item in thongKeBUS.LayDoanhThuTheoNgay(dateBatDau.Text, dateKetThuc.Text))
            {
                string[] arr = item.Split(',');

                doanhThuTheoNgay.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
            }

            if (doanhThuTheoNgay.RowCount > 0)
            {
                float tongDoanhThu = 0;
                float tongChiPhi = 0;
                float tongLoiNhuan = 0;
                for (int i = 0; i < doanhThuTheoNgay.RowCount; i++)
                {
                    tongDoanhThu += Convert.ToSingle(doanhThuTheoNgay.Rows[i].Cells[1].Value);
                    tongChiPhi += Convert.ToSingle(doanhThuTheoNgay.Rows[i].Cells[2].Value);
                    tongLoiNhuan += Convert.ToSingle(doanhThuTheoNgay.Rows[i].Cells[3].Value);
                }

                lbTongDoanhThu.Text = tongDoanhThu.ToString("C", new CultureInfo("vi-VN"));
                lbTongChiPhi.Text = tongChiPhi.ToString("C", new CultureInfo("vi-VN"));
                lbTongLoiNhuan.Text = tongLoiNhuan.ToString("C", new CultureInfo("vi-VN"));
            }
            else
            {
                lbTongDoanhThu.Text = 0 + "";
                lbTongChiPhi.Text = 0 + "";
                lbTongLoiNhuan.Text = 0 + "";
            }
        }

        private void comboxLocSpTon_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboxLocSpTon.Text == "Tất cả")
            {
                LoadSPTon();
            } else if(comboxLocSpTon.Text == "Hết hàng") 
            {
                LoadSPHetHang();
            } 
            else if(comboxLocSpTon.Text == "Gần hết hàng")
            {
                LoadSPGanHetHang();
            }
  
        }
    }
}
