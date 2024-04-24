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
    public partial class TimKiemKhachHang : Form
    {
        public int maKhachHang { get; set; }
        KhachHangBUS khachHangBUS = new KhachHangBUS();
        public TimKiemKhachHang()
        {
            InitializeComponent();
            LoadDataKhachHang();
        }

        public void LoadDataKhachHang()
        {
            dgvKhachHang.RowCount = 0;
            foreach (var item in khachHangBUS.LayDanhSachKhachHang())
            {
                if (item.TrangThai == 1)
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

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                LoadDataKhachHang();
            }
            else
            {
                LoadDataKhachHang(txtTen.Text);
            }
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                LoadDataKhachHang();
            }
            else
            {
                LoadDataKhachHang(txtSoDienThoai.Text);
            }
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

            if (selectedColumnName == "Chon")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.maKhachHang = maKhachHang;
                    this.Dispose();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
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
                    khachHang.TenKhachHang = txtTen.Text;
                    khachHang.SoDienThoai = txtSoDienThoai.Text;
                    if (khachHangBUS.ThemKhachHang(khachHang))
                    {
                        MessageBox.Show("Thêm thành  công");
                        KhachHang khachVuaThem = khachHangBUS.LayDanhSachKhachHang().Last<KhachHang>();
                        this.maKhachHang = khachVuaThem.MaKhachHang;
                        this.Dispose();
                    }
                    else
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
    }
}
