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
    public partial class NhomQuyenGUI : Form
    {
        NhomQuyenBUS nhomQuyenBUS = new NhomQuyenBUS();

        public NhomQuyenGUI()
        {
            InitializeComponent();
            LoadDataNhomQuyen();
        }

        // load dữ liệu lên bảng
        public void LoadDataNhomQuyen()
        {
            danhSachNhomQuyen.Rows.Clear();
            foreach (var item in nhomQuyenBUS.LayDanhSachNhomQuyen())
            {
                if (item.TrangThai == 1)
                {
                    danhSachNhomQuyen.Rows.Add(item.MaNhomQuyen, item.TenNhomQuyen);
                }
            }
        }


        // load dữ liệu tìm kiếm lên bảng
        public void LoadDataNhomQuyen(string text)
        {
            danhSachNhomQuyen.Rows.Clear();
            foreach (var item in nhomQuyenBUS.TimKiemNhomQuyen(text))
            {
                if (item.TrangThai == 1)
                {
                    danhSachNhomQuyen.Rows.Add(item.MaNhomQuyen, item.TenNhomQuyen);
                }
            }
        }

        // hàm hiển thị dialog chi tiết
        public void ShowDialogChiTiet(NhomQuyenModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = false;
            module.btnThoat.Size = new Size(320, 51);
        }

        // hàm hiển thị dialog thêm
        public void ShowDialogThem(NhomQuyenModule module)
        {
            module.btnThem.Visible = true;
            module.btnSua.Visible = false;

        }
        // hàm hiển thị dialog sửa
        public void ShowDialogSua(NhomQuyenModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = true;

        }

        private void danhSachNhomQuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            // dòng được chọn
            DataGridViewRow selectedRow = danhSachNhomQuyen.Rows[e.RowIndex];

            // lấy ra mã nhóm quyền từ dòng được chọn
            int maNhomQuyen = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());

            // lấy ra nhóm quyền thông qua mã nhóm quyền
            NhomQuyen nhomQuyen = nhomQuyenBUS.LayNhomQuyenQuaMa(maNhomQuyen);

            // lấy ra được tên cột  (sửa hoặc xóa)
            string selectedColumnName = danhSachNhomQuyen.Columns[e.ColumnIndex].Name;

            // trường hợp tên cột là Xoa
            if (selectedColumnName == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (nhomQuyen.MaNhomQuyen == 1 && nhomQuyen.TenNhomQuyen == "Admin")
                    {
                        MessageBox.Show("Không thể xóa nhóm quyền admin");
                    }
                    else
                    {
                        if (nhomQuyenBUS.XoaNhomQuyen(nhomQuyen.MaNhomQuyen))
                        {
                            MessageBox.Show("Bạn đã xóa thành công");
                            LoadDataNhomQuyen();
                        }
                        else
                        {
                            MessageBox.Show("Thất bại");
                        }

                    }

                }
            }
            // trường hợp tên cột là Sua
            else if (selectedColumnName == "Sua")
            {
                NhomQuyenModule nhomQuyenModule = new NhomQuyenModule(maNhomQuyen);
                nhomQuyenModule.txtTenNhomQuyen.Text = nhomQuyen.TenNhomQuyen;
                ShowDialogSua(nhomQuyenModule);
                nhomQuyenModule.ShowDialog();
                LoadDataNhomQuyen();
            }
            else if (selectedColumnName == "ChiTiet")
            {
                NhomQuyenModule nhomQuyenModule = new NhomQuyenModule(maNhomQuyen);
                nhomQuyenModule.txtTenNhomQuyen.Text = nhomQuyen.TenNhomQuyen;
                ShowDialogChiTiet(nhomQuyenModule);
                nhomQuyenModule.ShowDialog();
                LoadDataNhomQuyen();
            }
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            NhomQuyenModule nhomQuyenModule = new NhomQuyenModule();
            ShowDialogThem(nhomQuyenModule);
            nhomQuyenModule.ShowDialog();
            LoadDataNhomQuyen();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                LoadDataNhomQuyen();
            } else
            {
                LoadDataNhomQuyen(txtTimKiem.Text);
            }
        }
    }
}
