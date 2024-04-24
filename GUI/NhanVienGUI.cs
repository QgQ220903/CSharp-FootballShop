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
    public partial class NhanVienGUI : Form
    {
        NhanVienBUS nhanVienBUS = new NhanVienBUS();

        public NhanVienGUI()
        {
            InitializeComponent();
            LoadDataNhanVien();

        }

        public void LoadDataNhanVien()
        {
            danhSachNhanVien.Rows.Clear();
            foreach (var i in nhanVienBUS.LayDanhSachNhanVien())
            {
                if (i.TrangThai == 1)
                {
                    if (i.HinhAnh != null && i.HinhAnh.Length > 0)
                    {
                        // Chuyển từ kiểu Byte sang đối tượng Image 
                        Image image;
                        using (MemoryStream ms = new MemoryStream(i.HinhAnh))
                        {
                            image = Image.FromStream(ms);
                        }
                        danhSachNhanVien.Rows.Add(i.MaNhanVien, i.TenNhanVien, i.Tuoi, i.SoDienThoai, image);
                    }
                    else
                    {
                        danhSachNhanVien.Rows.Add(i.MaNhanVien, i.TenNhanVien, i.Tuoi, i.SoDienThoai, GUI.Properties.Resources.Employee);
                    }
                }
            }

            danhSachNhanVien.Columns["MaNhanVien"].Width = 100;
            danhSachNhanVien.Columns["TenNhanVien"].Width = 400;
            danhSachNhanVien.Columns["Tuoi"].Width = 100;
            danhSachNhanVien.Columns["SoDienThoai"].Width = 400;
            danhSachNhanVien.Columns["HinhAnh"].Width = 100;
        }

        public void LoadDataNhanVien(string text)
        {
            danhSachNhanVien.Rows.Clear();
            foreach (var i in nhanVienBUS.TimKiemNhanVien(text))
            {
                if (i.HinhAnh != null && i.HinhAnh.Length > 0)
                {
                    // Chuyển từ kiểu Byte sang đối tượng Image 
                    Image image;
                    using (MemoryStream ms = new MemoryStream(i.HinhAnh))
                    {
                        image = Image.FromStream(ms);
                    }
                    danhSachNhanVien.Rows.Add(i.MaNhanVien, i.TenNhanVien, i.Tuoi, i.SoDienThoai, image);
                }
                else
                {
                    danhSachNhanVien.Rows.Add(i.MaNhanVien, i.TenNhanVien, i.Tuoi, i.SoDienThoai, GUI.Properties.Resources.Employee);
                }

            }
            danhSachNhanVien.ClearSelection();
        }

        // hàm hiển thị dialog thêm
        public void ShowDialogThem(NhanVienModule module)
        {
            module.btnThem.Visible = true;
            module.btnSua.Visible = false;

        }
        // hàm hiển thị dialog sửa
        public void ShowDialogSua(NhanVienModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = true;

        }


        private void danhSachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = danhSachNhanVien.Rows[e.RowIndex];

            int maNhanVien = Convert.ToInt32(row.Cells[0].Value.ToString());
            string tenNhanVien = row.Cells[1].Value.ToString();
            int tuoi = Convert.ToInt32(row.Cells[2].Value.ToString());
            string soDienThoai = row.Cells[3].Value.ToString();


            NhanVien nhanVien = nhanVienBUS.LayNhanVienQuaMa(maNhanVien);


            string selectedColumnName = danhSachNhanVien.Columns[e.ColumnIndex].Name;
            if (selectedColumnName == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (nhanVien.TenNhanVien == "Admin")
                    {
                        MessageBox.Show("Không thể xóa tài khoản admin");
                    }
                    else
                    {
                        if (nhanVienBUS.XoaNhanVien(nhanVien.MaNhanVien))
                        {
                            MessageBox.Show("Bạn đã xóa thành công");
                            LoadDataNhanVien();
                        }
                        else
                        {
                            MessageBox.Show("Thất bại");
                        }
                    }
                }
            }
            else if (selectedColumnName == "Sua")
            {
                NhanVienModule nhanVienModule = new NhanVienModule(maNhanVien);
                nhanVienModule.txtTenNhanVien.Text = nhanVien.TenNhanVien;
                nhanVienModule.txtTuoi.Text = nhanVien.Tuoi + "";
                nhanVienModule.txtSoDienThoai.Text = nhanVien.SoDienThoai;
                if (nhanVien.HinhAnh.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(nhanVien.HinhAnh);
                    nhanVienModule.picNhanVien.Image = Image.FromStream(ms);
                    ShowDialogSua(nhanVienModule);
                    nhanVienModule.ShowDialog();
                    LoadDataNhanVien();
                }
                else
                {
                    MessageBox.Show("Không được sửa Admin");
                }

            }
        }



        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            NhanVienModule nhanVienModule = new NhanVienModule();
            ShowDialogThem(nhanVienModule);
            nhanVienModule.ShowDialog();
            LoadDataNhanVien();
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                LoadDataNhanVien();
            }
            else
            {
                LoadDataNhanVien(txtTimKiem.Text);
            }
        }
    }
}
