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
    public partial class NhomQuyenModule : Form
    {
        NhomQuyenBUS nhomQuyenBUS = new NhomQuyenBUS();
        ChucNangBUS chucNangBUS = new ChucNangBUS();
        ChiTietQuyenBUS chiTietQuyenBUS = new ChiTietQuyenBUS();
        public int MaNhomQuyen { get; set; }

        public NhomQuyenModule()
        {
            InitializeComponent();
            LoadDataChucNang();
        }

        public NhomQuyenModule(int maNhomQuyen)
        {
            InitializeComponent();
            this.MaNhomQuyen = maNhomQuyen;
            LoadDataChucNang();
            LoadDataChiTietQuyen();
        }

        public void LoadDataChucNang()
        {
            danhSachChucNang.Rows.Clear();
            foreach (var item in chucNangBUS.LayDanhSachChucNang())
            {
                danhSachChucNang.Rows.Add(item.TenChucNang);
            }
        }

        public void LoadDataChiTietQuyen()
        {
            for (int i = 0; i < danhSachChucNang.RowCount; i++)
            {
                string tenChucNang = danhSachChucNang.Rows[i].Cells[0].Value.ToString();
                for (int j = 1; j < danhSachChucNang.ColumnCount; j++)
                {
                    string tenHanhDong = danhSachChucNang.Columns[j].Name;
                    foreach (var item in chiTietQuyenBUS.TimKiemChiTietQuyen(this.MaNhomQuyen))
                    {
                        string chucNang = chucNangBUS.LayChucNangQuaMa(item.MaChucNang).TenChucNang;
                        string hanhDong = item.HanhDong;
                        if (chucNang == tenChucNang)
                        {
                            if (hanhDong == tenHanhDong)
                            {
                                danhSachChucNang.Rows[i].Cells[j].Value = true;
                            }
                        }
                    }
                }
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNhomQuyen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhóm quyền");
            }
            else
            {
                NhomQuyen nhomQuyen = new NhomQuyen();
                nhomQuyen.TenNhomQuyen = txtTenNhomQuyen.Text;
                nhomQuyen.TrangThai = 1;
                if (nhomQuyenBUS.ThemNhomQuyen(nhomQuyen))
                {
                    NhomQuyen nhomQuyenVuaThem = nhomQuyenBUS.LayNhomQuyenQuaTen(txtTenNhomQuyen.Text);
                    for (int i = 0; i < danhSachChucNang.Rows.Count; i++)
                    {
                        for (int j = 1; j < danhSachChucNang.Columns.Count; j++)
                        {
                            DataGridViewCheckBoxCell cell = danhSachChucNang.Rows[i].Cells[j] as DataGridViewCheckBoxCell;
                            if (cell.Value != null && (bool)cell.Value == true)
                            {
                                string tenHanhDong = danhSachChucNang.Columns[j].HeaderText;
                                ChiTietQuyen chiTietQuyen = new ChiTietQuyen();
                                chiTietQuyen.MaNhomQuyen = nhomQuyenVuaThem.MaNhomQuyen;
                                chiTietQuyen.MaChucNang = chucNangBUS.LayChucNangQuaTen(danhSachChucNang.Rows[i].Cells[0].Value.ToString()).MaChucNang;
                                chiTietQuyen.HanhDong = tenHanhDong;
                                chiTietQuyenBUS.ThemChiTietQuyen(chiTietQuyen);
                            }

                        }
                    }
                    MessageBox.Show("Thêm thành công nhóm quyền");
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
            if (string.IsNullOrWhiteSpace(txtTenNhomQuyen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhóm quyền");
            }
            else
            {
                NhomQuyen nhomQuyen = new NhomQuyen();
                nhomQuyen.MaNhomQuyen = this.MaNhomQuyen;
                nhomQuyen.TenNhomQuyen = txtTenNhomQuyen.Text;
                nhomQuyen.TrangThai = 1;
                if (nhomQuyenBUS.SuaNhomQuyen(nhomQuyen))
                {
                    NhomQuyen nhomQuyenCanSua = nhomQuyenBUS.LayNhomQuyenQuaTen(txtTenNhomQuyen.Text);
                    chiTietQuyenBUS.XoaToanBoChiTietQuyen(nhomQuyenCanSua.MaNhomQuyen);

                    for (int i = 0; i < danhSachChucNang.Rows.Count; i++)
                    {
                        for (int j = 1; j < danhSachChucNang.Columns.Count; j++)
                        {
                            DataGridViewCheckBoxCell cell = danhSachChucNang.Rows[i].Cells[j] as DataGridViewCheckBoxCell;
                            if (cell.Value != null && (bool)cell.Value == true)
                            {
                                string tenHanhDong = danhSachChucNang.Columns[j].HeaderText;
                                ChiTietQuyen chiTietQuyen = new ChiTietQuyen();
                                chiTietQuyen.MaNhomQuyen = nhomQuyenCanSua.MaNhomQuyen;
                                chiTietQuyen.MaChucNang = chucNangBUS.LayChucNangQuaTen(danhSachChucNang.Rows[i].Cells[0].Value.ToString()).MaChucNang;
                                chiTietQuyen.HanhDong = tenHanhDong;
                                chiTietQuyenBUS.ThemChiTietQuyen(chiTietQuyen);
                            }

                        }
                    }
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

        private void danhSachChucNang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
