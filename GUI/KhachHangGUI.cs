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
    public partial class KhachHangGUI : Form
    {
        KhachHangBUS khachHangBUS = new KhachHangBUS();
        public KhachHangGUI()
        {
            InitializeComponent();
            LoadDataKhachHang();
        }

        public void LoadDataKhachHang()
        {
            dgvKhachHang.RowCount = 0;
            foreach (var item in khachHangBUS.LayDanhSachKhachHang())
            {
                if(item.TrangThai == 1)
                {
                    dgvKhachHang.Rows.Add(item.MaKhachHang, item.TenKhachHang, item.SoDienThoai);
                }
            }
        }

        public void LoadDataKhachHang(string text)
        {
            dgvKhachHang.RowCount = 0;
            foreach (var item in khachHangBUS.TimKiemKhachHang(text))
            {
                if (item.TrangThai == 1)
                {
                    dgvKhachHang.Rows.Add(item.MaKhachHang, item.TenKhachHang, item.SoDienThoai);
                }
            }
        }


        // hàm hiển thị dialog thêm
        public void ShowDialogThem(KhachHangModule module)
        {
            module.btnThem.Visible = true;
            module.btnSua.Visible = false;

        }
        // hàm hiển thị dialog sửa
        public void ShowDialogSua(KhachHangModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = true;

        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

            int maKhachHang = Convert.ToInt32(row.Cells[0].Value.ToString());
            KhachHang khachHang = khachHangBUS.LayKhachHangQuaMa(maKhachHang);


            string selectedColumnName = dgvKhachHang.Columns[e.ColumnIndex].Name;

            if (selectedColumnName == "xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (khachHangBUS.XoaKhachHang(khachHang))
                    {
                        MessageBox.Show("Bạn đã xóa thành công");
                        LoadDataKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
            else if (selectedColumnName == "sua")
            {
                KhachHangModule khachHangModule = new KhachHangModule(khachHang.MaKhachHang);
                khachHangModule.txtTen.Focus();
                khachHangModule.txtTen.Text = khachHang.TenKhachHang;
                khachHangModule.txtSoDienThoai.Text = khachHang.SoDienThoai;
                ShowDialogSua(khachHangModule);
                khachHangModule.ShowDialog();

                LoadDataKhachHang();
            }
            else if (selectedColumnName == "giaodich")
            {
                HoaDonGUI hoaDonGUI = new HoaDonGUI(maKhachHang);
                hoaDonGUI.FormBorderStyle = FormBorderStyle.FixedSingle;
                hoaDonGUI.MaximizeBox = false;
                hoaDonGUI.ShowDialog();
            }

        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            KhachHangModule khachHangModule = new KhachHangModule();
            khachHangModule.txtTen.Focus();
            ShowDialogThem(khachHangModule);
            khachHangModule.ShowDialog();
            LoadDataKhachHang();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                LoadDataKhachHang();
            } else
            {
                LoadDataKhachHang(txtTimKiem.Text);
            }
        }
    }
}
