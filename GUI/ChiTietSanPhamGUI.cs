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
    public partial class ChiTietSanPhamGUI : Form
    {
        public int maSanPham { get; set; }
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        MauSacBUS mauSacBUS = new MauSacBUS();
        KichCoBUS kichCoBUS = new KichCoBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();
        public int maChiTietSanPham { get; set; }
        public ChiTietSanPhamGUI()
        {
            InitializeComponent();
        }
        public ChiTietSanPhamGUI(int maSanPham)
        {
            InitializeComponent();
            this.maSanPham = maSanPham;
            LoadDataChiTietSanPham();
        }

        public void LoadDataChiTietSanPham()
        {
            danhSachChiTietSanPham.RowCount = 0;
            foreach (var item in chiTietSanPhamBUS.LayDanhSachChiTietTheoMaSanPham(this.maSanPham))
            {
                if (item.TrangThai == 1)
                {
                    if (item.HinhAnh != null && item.HinhAnh.Length > 0)
                    {
                        // Chuyển từ kiểu Byte sang đối tượng Image 
                        Image image;
                        using (MemoryStream ms = new MemoryStream(item.HinhAnh))
                        {
                            image = Image.FromStream(ms);
                        }
                        danhSachChiTietSanPham.Rows.Add(item.MaChiTietSanPham, sanPhamBUS.LaySanPhamQuaMa(item.MaSanPham).TenSanPham, mauSacBUS.LayMauSacQuaMa(item.MaMauSac).TenMauSac, kichCoBUS.LayKichCoQuaMa(item.MaKichCo).TenKichCo, image, item.SoLuongTon);
                    }
                    else
                    {
                        danhSachChiTietSanPham.Rows.Add(item.MaChiTietSanPham, sanPhamBUS.LaySanPhamQuaMa(item.MaSanPham).TenSanPham, mauSacBUS.LayMauSacQuaMa(item.MaMauSac).TenMauSac, kichCoBUS.LayKichCoQuaMa(item.MaKichCo).TenKichCo, GUI.Properties.Resources.Product, item.SoLuongTon);
                    }
                }

            }


            danhSachChiTietSanPham.Columns[0].Width = 100;
            danhSachChiTietSanPham.Columns[1].Width = 500;
            danhSachChiTietSanPham.Columns[2].Width = 100;
            danhSachChiTietSanPham.Columns[3].Width = 100;
            danhSachChiTietSanPham.Columns[4].Width = 200;
            danhSachChiTietSanPham.Columns[5].Width = 100;
        }

        private void anhSanPham_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                anhSanPham.ImageLocation = dialog.FileName.ToString();
            }
        }

        private void danhSachChiTietSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = danhSachChiTietSanPham.Rows[e.RowIndex];
            int maChiTietSanPham = Convert.ToInt32(row.Cells[0].Value.ToString());
            this.maChiTietSanPham = maChiTietSanPham;
            ChiTietSanPham chiTietSanPham = chiTietSanPhamBUS.LayChiTietSanPhamQuaMa(maChiTietSanPham);

            comboxMauSac.SelectedItem = mauSacBUS.LayMauSacQuaMa(chiTietSanPham.MaMauSac).TenMauSac;
            comboxKichCo.SelectedItem = kichCoBUS.LayKichCoQuaMa(chiTietSanPham.MaKichCo).TenKichCo;
            // Lấy giá trị của ô hình ảnh trong dòng được chọn
            DataGridViewImageCell imageCell = (DataGridViewImageCell)danhSachChiTietSanPham.Rows[e.RowIndex].Cells["HinhAnh"];
            if (imageCell.Value != null)
            {
                // Lấy ảnh từ ô hình ảnh và gán vào PictureBox
                Image image = (Image)imageCell.Value;
                anhSanPham.Image = image;
            }



            string selectedColumnName = danhSachChiTietSanPham.Columns[e.ColumnIndex].Name;
            if (selectedColumnName == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (chiTietSanPham.SoLuongTon > 0)
                    {
                        MessageBox.Show("Không thể xóa sản phẩm còn số lượng tồn");
                    }
                    else
                    {
                        if (chiTietSanPhamBUS.XoaChiTietSanPham(maChiTietSanPham))
                        {
                            MessageBox.Show("Bạn đã xóa thành công");
                            LoadDataChiTietSanPham();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại");
                        }
                    }
                    
                }
            }


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ChiTietSanPham chiTietSanPham = new ChiTietSanPham();
            chiTietSanPham.MaChiTietSanPham = this.maChiTietSanPham;
            chiTietSanPham.MaSanPham = this.maSanPham;
            chiTietSanPham.MaMauSac = mauSacBUS.LayMauSacQuaTen(comboxMauSac.Text).MaMauSac;
            chiTietSanPham.MaKichCo = kichCoBUS.LayKichCoQuaTen(comboxKichCo.Text).MaKichCo;

            Image hinhAnh = anhSanPham.Image;
            using (MemoryStream ms = new MemoryStream())
            {
                // Tạo một bản sao của ảnh
                using (Bitmap bmp = new Bitmap(hinhAnh))
                {
                    bmp.Save(ms, hinhAnh.RawFormat);
                }
                chiTietSanPham.HinhAnh = ms.ToArray();
            }
            if (chiTietSanPhamBUS.SuaChiTietSanPham(chiTietSanPham))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại. Đã tồn tại chi tiết sản phẩm");
            }
        }

        private void btnThemChiTietSanPham_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboxMauSac.Text))
            {
                MessageBox.Show("Vui lòng chọn màu sắc");
            }
            else if (string.IsNullOrEmpty(comboxKichCo.Text))
            {
                MessageBox.Show("Vui lòng chọn kích cỡ");
            }
            else
            {
                ChiTietSanPham chiTietSanPham = new ChiTietSanPham();
                chiTietSanPham.MaSanPham = this.maSanPham;
                chiTietSanPham.MaMauSac = mauSacBUS.LayMauSacQuaTen(comboxMauSac.Text).MaMauSac;
                chiTietSanPham.MaKichCo = kichCoBUS.LayKichCoQuaTen(comboxKichCo.Text).MaKichCo;
                byte[] anhByte;
                using (MemoryStream ms = new MemoryStream())
                {
                    Image anhGoc = anhSanPham.Image;
                    Image anhSao = new Bitmap(anhGoc); // Tạo bản sao của ảnh gốc

                    anhSao.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    anhByte = ms.ToArray();
                }
                chiTietSanPham.HinhAnh = anhByte;
                chiTietSanPham.TrangThai = 1;
                chiTietSanPham.SoLuongTon = 0;
                if (chiTietSanPhamBUS.ThemChiTietSanPham(chiTietSanPham))
                {
                    MessageBox.Show("Thêm thành công");
                    LoadDataChiTietSanPham();
                }
                else
                {
                    MessageBox.Show("Đã tồn tại chi tiết sản phẩm trên");
                }
            }
        }
    }
}
