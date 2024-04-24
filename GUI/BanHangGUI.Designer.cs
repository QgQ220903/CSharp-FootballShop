namespace GUI
{
    partial class BanHangGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle38 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle32 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle33 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle34 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle35 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle37 = new DataGridViewCellStyle();
            txtTienThoi = new TextBox();
            label9 = new Label();
            btnThanhToan = new Button();
            txtKhachDua = new TextBox();
            label8 = new Label();
            txtMaKhachHang = new TextBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            btnHuyHoaDon = new Button();
            btnTaoHoaDon = new Button();
            btnChon = new Button();
            txtTenNhanVien = new TextBox();
            label5 = new Label();
            txtNgayNhap = new TextBox();
            labelGiaNhap = new Label();
            txtTongTien = new TextBox();
            labelGiaSanPham = new Label();
            groupBox1 = new GroupBox();
            btnTimKiem = new Button();
            comboxTimKiem = new ComboBox();
            label2 = new Label();
            txtTimKiem = new TextBox();
            danhSachChiTietSanPham = new DataGridView();
            MaChiTietSanPham = new DataGridViewTextBoxColumn();
            MaSanPham = new DataGridViewTextBoxColumn();
            MaMauSac = new DataGridViewTextBoxColumn();
            MaKichCo = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            Them = new DataGridViewImageColumn();
            groupBox2 = new GroupBox();
            danhSachGioHang = new DataGridView();
            MaChiTiet = new DataGridViewTextBoxColumn();
            MaCTSP = new DataGridViewTextBoxColumn();
            MauSac = new DataGridViewTextBoxColumn();
            KichCo = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            Xoa = new DataGridViewImageColumn();
            panel1 = new Panel();
            label7 = new Label();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietSanPham).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachGioHang).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTienThoi
            // 
            txtTienThoi.BackColor = SystemColors.Control;
            txtTienThoi.Font = new Font("Segoe UI Variable Text", 9F);
            txtTienThoi.ForeColor = SystemColors.ControlText;
            txtTienThoi.Location = new Point(31, 456);
            txtTienThoi.Name = "txtTienThoi";
            txtTienThoi.Size = new Size(355, 31);
            txtTienThoi.TabIndex = 150;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Segoe UI Variable Text", 9F);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(31, 426);
            label9.Name = "label9";
            label9.Size = new Size(78, 24);
            label9.TabIndex = 149;
            label9.Text = "Tiền thối";
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.MediumSeaGreen;
            btnThanhToan.Font = new Font("Segoe UI Variable Text Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThanhToan.ForeColor = SystemColors.ButtonHighlight;
            btnThanhToan.Location = new Point(31, 645);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(355, 55);
            btnThanhToan.TabIndex = 148;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // txtKhachDua
            // 
            txtKhachDua.BackColor = SystemColors.ButtonHighlight;
            txtKhachDua.Font = new Font("Segoe UI Variable Text", 9F);
            txtKhachDua.ForeColor = SystemColors.ControlText;
            txtKhachDua.Location = new Point(31, 372);
            txtKhachDua.Name = "txtKhachDua";
            txtKhachDua.Size = new Size(355, 31);
            txtKhachDua.TabIndex = 147;
            txtKhachDua.TextChanged += txtKhachDua_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Segoe UI Variable Text", 9F);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(31, 342);
            label8.Name = "label8";
            label8.Size = new Size(129, 24);
            label8.TabIndex = 146;
            label8.Text = "Tiền khách đưa";
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMaKhachHang.ForeColor = SystemColors.ControlText;
            txtMaKhachHang.Location = new Point(142, 58);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.ReadOnly = true;
            txtMaKhachHang.Size = new Size(155, 31);
            txtMaKhachHang.TabIndex = 145;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(31, 61);
            label6.Name = "label6";
            label6.Size = new Size(105, 24);
            label6.TabIndex = 144;
            label6.Text = "Khách Hàng";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnHuyHoaDon);
            groupBox3.Controls.Add(btnTaoHoaDon);
            groupBox3.Controls.Add(btnChon);
            groupBox3.Controls.Add(txtTienThoi);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(btnThanhToan);
            groupBox3.Controls.Add(txtKhachDua);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtMaKhachHang);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtTenNhanVien);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtNgayNhap);
            groupBox3.Controls.Add(labelGiaNhap);
            groupBox3.Controls.Add(txtTongTien);
            groupBox3.Controls.Add(labelGiaSanPham);
            groupBox3.Location = new Point(1167, 110);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(410, 778);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hóa Đơn";
            // 
            // btnHuyHoaDon
            // 
            btnHuyHoaDon.BackColor = Color.Red;
            btnHuyHoaDon.Font = new Font("Segoe UI Variable Text Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuyHoaDon.ForeColor = SystemColors.ButtonHighlight;
            btnHuyHoaDon.Location = new Point(218, 706);
            btnHuyHoaDon.Name = "btnHuyHoaDon";
            btnHuyHoaDon.Size = new Size(168, 55);
            btnHuyHoaDon.TabIndex = 153;
            btnHuyHoaDon.Text = "Hủy Hóa Đơn";
            btnHuyHoaDon.UseVisualStyleBackColor = false;
            btnHuyHoaDon.Click += btnHuyHoaDon_Click;
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.BackColor = Color.Teal;
            btnTaoHoaDon.Font = new Font("Segoe UI Variable Text Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnTaoHoaDon.ForeColor = SystemColors.ButtonHighlight;
            btnTaoHoaDon.Location = new Point(31, 706);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Size = new Size(181, 55);
            btnTaoHoaDon.TabIndex = 152;
            btnTaoHoaDon.Text = "Tạo Hóa Đơn";
            btnTaoHoaDon.UseVisualStyleBackColor = false;
            btnTaoHoaDon.Click += btnTaoHoaDon_Click;
            // 
            // btnChon
            // 
            btnChon.BackColor = Color.MediumSeaGreen;
            btnChon.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnChon.ForeColor = SystemColors.ButtonHighlight;
            btnChon.Location = new Point(303, 51);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(83, 46);
            btnChon.TabIndex = 151;
            btnChon.Text = "Chọn";
            btnChon.UseVisualStyleBackColor = false;
            btnChon.Click += btnChon_Click;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.BackColor = SystemColors.Control;
            txtTenNhanVien.Font = new Font("Segoe UI Variable Text", 9F);
            txtTenNhanVien.ForeColor = SystemColors.ControlText;
            txtTenNhanVien.Location = new Point(31, 143);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.ReadOnly = true;
            txtTenNhanVien.Size = new Size(355, 31);
            txtTenNhanVien.TabIndex = 137;
            txtTenNhanVien.Text = "Quách Gia Quy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI Variable Text", 9F);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(31, 113);
            label5.Name = "label5";
            label5.Size = new Size(91, 24);
            label5.TabIndex = 136;
            label5.Text = "Nhân Viên";
            // 
            // txtNgayNhap
            // 
            txtNgayNhap.BackColor = SystemColors.Control;
            txtNgayNhap.Font = new Font("Segoe UI Variable Text", 9F);
            txtNgayNhap.ForeColor = SystemColors.ControlText;
            txtNgayNhap.Location = new Point(31, 220);
            txtNgayNhap.Name = "txtNgayNhap";
            txtNgayNhap.ReadOnly = true;
            txtNgayNhap.Size = new Size(355, 31);
            txtNgayNhap.TabIndex = 135;
            // 
            // labelGiaNhap
            // 
            labelGiaNhap.AutoSize = true;
            labelGiaNhap.BackColor = SystemColors.Control;
            labelGiaNhap.Font = new Font("Segoe UI Variable Text", 9F);
            labelGiaNhap.ForeColor = SystemColors.ControlText;
            labelGiaNhap.Location = new Point(31, 190);
            labelGiaNhap.Name = "labelGiaNhap";
            labelGiaNhap.Size = new Size(85, 24);
            labelGiaNhap.TabIndex = 134;
            labelGiaNhap.Text = "Ngày Lập";
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = SystemColors.Control;
            txtTongTien.Font = new Font("Segoe UI Variable Text Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtTongTien.ForeColor = Color.Red;
            txtTongTien.Location = new Point(31, 299);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(355, 31);
            txtTongTien.TabIndex = 133;
            txtTongTien.Text = "0";
            // 
            // labelGiaSanPham
            // 
            labelGiaSanPham.AutoSize = true;
            labelGiaSanPham.BackColor = SystemColors.Control;
            labelGiaSanPham.Font = new Font("Segoe UI Variable Text", 9F);
            labelGiaSanPham.ForeColor = SystemColors.ControlText;
            labelGiaSanPham.Location = new Point(31, 269);
            labelGiaSanPham.Name = "labelGiaSanPham";
            labelGiaSanPham.Size = new Size(85, 24);
            labelGiaSanPham.TabIndex = 131;
            labelGiaSanPham.Text = "Tổng tiền";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(comboxTimKiem);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(danhSachChiTietSanPham);
            groupBox1.Location = new Point(23, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1125, 439);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.MediumSeaGreen;
            btnTimKiem.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnTimKiem.ForeColor = SystemColors.ButtonHighlight;
            btnTimKiem.Location = new Point(1020, 35);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(99, 43);
            btnTimKiem.TabIndex = 154;
            btnTimKiem.Text = "Chọn";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // comboxTimKiem
            // 
            comboxTimKiem.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboxTimKiem.FormattingEnabled = true;
            comboxTimKiem.Items.AddRange(new object[] { "Theo mã", "Theo tên" });
            comboxTimKiem.Location = new Point(881, 41);
            comboxTimKiem.Name = "comboxTimKiem";
            comboxTimKiem.Size = new Size(133, 32);
            comboxTimKiem.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(481, 41);
            label2.Name = "label2";
            label2.Size = new Size(93, 27);
            label2.TabIndex = 17;
            label2.Text = "Tìm Kiếm";
            label2.Click += label2_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI Variable Text", 9F);
            txtTimKiem.Location = new Point(580, 41);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(295, 31);
            txtTimKiem.TabIndex = 16;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // danhSachChiTietSanPham
            // 
            danhSachChiTietSanPham.AllowUserToAddRows = false;
            danhSachChiTietSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            danhSachChiTietSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachChiTietSanPham.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachChiTietSanPham.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = SystemColors.Control;
            dataGridViewCellStyle20.Font = new Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle20.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            danhSachChiTietSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            danhSachChiTietSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachChiTietSanPham.Columns.AddRange(new DataGridViewColumn[] { MaChiTietSanPham, MaSanPham, MaMauSac, MaKichCo, SoLuongTon, GiaBan, Them });
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = SystemColors.Window;
            dataGridViewCellStyle28.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle28.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = DataGridViewTriState.False;
            danhSachChiTietSanPham.DefaultCellStyle = dataGridViewCellStyle28;
            danhSachChiTietSanPham.Location = new Point(19, 96);
            danhSachChiTietSanPham.Name = "danhSachChiTietSanPham";
            danhSachChiTietSanPham.ReadOnly = true;
            danhSachChiTietSanPham.RowHeadersWidth = 62;
            danhSachChiTietSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachChiTietSanPham.Size = new Size(1085, 324);
            danhSachChiTietSanPham.TabIndex = 4;
            danhSachChiTietSanPham.CellContentClick += danhSachChiTietSanPham_CellContentClick;
            // 
            // MaChiTietSanPham
            // 
            MaChiTietSanPham.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaChiTietSanPham.DataPropertyName = "MaChiTietSanPham";
            dataGridViewCellStyle21.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle21.SelectionForeColor = Color.White;
            MaChiTietSanPham.DefaultCellStyle = dataGridViewCellStyle21;
            MaChiTietSanPham.HeaderText = "Mã chi tiết";
            MaChiTietSanPham.MinimumWidth = 8;
            MaChiTietSanPham.Name = "MaChiTietSanPham";
            MaChiTietSanPham.ReadOnly = true;
            // 
            // MaSanPham
            // 
            MaSanPham.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaSanPham.DataPropertyName = "MaSanPham";
            dataGridViewCellStyle22.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle22.SelectionForeColor = Color.White;
            MaSanPham.DefaultCellStyle = dataGridViewCellStyle22;
            MaSanPham.HeaderText = "Sản phẩm";
            MaSanPham.MinimumWidth = 8;
            MaSanPham.Name = "MaSanPham";
            MaSanPham.ReadOnly = true;
            // 
            // MaMauSac
            // 
            MaMauSac.DataPropertyName = "MaMauSac";
            dataGridViewCellStyle23.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle23.SelectionForeColor = Color.White;
            MaMauSac.DefaultCellStyle = dataGridViewCellStyle23;
            MaMauSac.HeaderText = "Màu sắc";
            MaMauSac.MinimumWidth = 8;
            MaMauSac.Name = "MaMauSac";
            MaMauSac.ReadOnly = true;
            MaMauSac.Width = 111;
            // 
            // MaKichCo
            // 
            MaKichCo.DataPropertyName = "MaKichCo";
            dataGridViewCellStyle24.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle24.SelectionForeColor = Color.White;
            MaKichCo.DefaultCellStyle = dataGridViewCellStyle24;
            MaKichCo.HeaderText = "Kích cỡ";
            MaKichCo.MinimumWidth = 8;
            MaKichCo.Name = "MaKichCo";
            MaKichCo.ReadOnly = true;
            MaKichCo.Width = 102;
            // 
            // SoLuongTon
            // 
            SoLuongTon.DataPropertyName = "SoLuongTon";
            dataGridViewCellStyle25.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle25.SelectionForeColor = Color.White;
            SoLuongTon.DefaultCellStyle = dataGridViewCellStyle25;
            SoLuongTon.HeaderText = "Số lượng tồn";
            SoLuongTon.MinimumWidth = 8;
            SoLuongTon.Name = "SoLuongTon";
            SoLuongTon.ReadOnly = true;
            SoLuongTon.Width = 151;
            // 
            // GiaBan
            // 
            GiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle26.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle26.SelectionForeColor = Color.White;
            GiaBan.DefaultCellStyle = dataGridViewCellStyle26;
            GiaBan.HeaderText = "Giá bán";
            GiaBan.MinimumWidth = 8;
            GiaBan.Name = "GiaBan";
            GiaBan.ReadOnly = true;
            GiaBan.Width = 106;
            // 
            // Them
            // 
            Them.DataPropertyName = "Them";
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.NullValue = null;
            dataGridViewCellStyle27.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle27.SelectionForeColor = Color.White;
            Them.DefaultCellStyle = dataGridViewCellStyle27;
            Them.HeaderText = "Thêm";
            Them.Image = Properties.Resources.Add_Product;
            Them.MinimumWidth = 8;
            Them.Name = "Them";
            Them.ReadOnly = true;
            Them.Resizable = DataGridViewTriState.True;
            Them.SortMode = DataGridViewColumnSortMode.Automatic;
            Them.Width = 90;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(danhSachGioHang);
            groupBox2.Location = new Point(23, 555);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1125, 333);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giỏ Hàng";
            // 
            // danhSachGioHang
            // 
            danhSachGioHang.AllowUserToAddRows = false;
            danhSachGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            danhSachGioHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachGioHang.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachGioHang.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = SystemColors.Control;
            dataGridViewCellStyle29.Font = new Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle29.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = DataGridViewTriState.True;
            danhSachGioHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            danhSachGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachGioHang.Columns.AddRange(new DataGridViewColumn[] { MaChiTiet, MaCTSP, MauSac, KichCo, dataGridViewTextBoxColumn6, SoLuong, ThanhTien, Xoa });
            dataGridViewCellStyle38.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = SystemColors.Window;
            dataGridViewCellStyle38.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle38.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle38.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = DataGridViewTriState.False;
            danhSachGioHang.DefaultCellStyle = dataGridViewCellStyle38;
            danhSachGioHang.Location = new Point(19, 30);
            danhSachGioHang.Name = "danhSachGioHang";
            danhSachGioHang.RowHeadersWidth = 62;
            danhSachGioHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachGioHang.Size = new Size(1085, 281);
            danhSachGioHang.TabIndex = 4;
            danhSachGioHang.CellContentClick += danhSachGioHang_CellContentClick;
            // 
            // MaChiTiet
            // 
            dataGridViewCellStyle30.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle30.SelectionForeColor = Color.White;
            MaChiTiet.DefaultCellStyle = dataGridViewCellStyle30;
            MaChiTiet.HeaderText = "Mã Chi Tiết";
            MaChiTiet.MinimumWidth = 8;
            MaChiTiet.Name = "MaChiTiet";
            MaChiTiet.Width = 134;
            // 
            // MaCTSP
            // 
            MaCTSP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaCTSP.DataPropertyName = "MaCTSP";
            dataGridViewCellStyle31.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle31.SelectionForeColor = Color.White;
            MaCTSP.DefaultCellStyle = dataGridViewCellStyle31;
            MaCTSP.HeaderText = "Sản phẩm";
            MaCTSP.MinimumWidth = 8;
            MaCTSP.Name = "MaCTSP";
            // 
            // MauSac
            // 
            dataGridViewCellStyle32.SelectionBackColor = Color.MediumSeaGreen;
            MauSac.DefaultCellStyle = dataGridViewCellStyle32;
            MauSac.HeaderText = "Màu Sắc";
            MauSac.MinimumWidth = 8;
            MauSac.Name = "MauSac";
            MauSac.Width = 113;
            // 
            // KichCo
            // 
            dataGridViewCellStyle33.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle33.SelectionForeColor = Color.White;
            KichCo.DefaultCellStyle = dataGridViewCellStyle33;
            KichCo.HeaderText = "Kích Cỡ";
            KichCo.MinimumWidth = 8;
            KichCo.Name = "KichCo";
            KichCo.Width = 105;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "GiaBan";
            dataGridViewCellStyle34.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle34.SelectionForeColor = Color.White;
            dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle34;
            dataGridViewTextBoxColumn6.HeaderText = "Giá bán";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 106;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle35.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle35.SelectionForeColor = Color.White;
            SoLuong.DefaultCellStyle = dataGridViewCellStyle35;
            SoLuong.HeaderText = "Số lượng ";
            SoLuong.MinimumWidth = 8;
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 124;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle36.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle36.SelectionForeColor = Color.White;
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle36;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 8;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.Width = 128;
            // 
            // Xoa
            // 
            Xoa.DataPropertyName = "Xóa";
            dataGridViewCellStyle37.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.NullValue = null;
            dataGridViewCellStyle37.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle37.SelectionForeColor = Color.White;
            Xoa.DefaultCellStyle = dataGridViewCellStyle37;
            Xoa.HeaderText = "Xóa";
            Xoa.Image = Properties.Resources.Delete;
            Xoa.MinimumWidth = 8;
            Xoa.Name = "Xoa";
            Xoa.Resizable = DataGridViewTriState.True;
            Xoa.SortMode = DataGridViewColumnSortMode.Automatic;
            Xoa.Width = 77;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 100);
            panel1.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(693, 33);
            label7.Name = "label7";
            label7.Size = new Size(168, 37);
            label7.TabIndex = 1;
            label7.Text = "BÁN HÀNG";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // BanHangGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BanHangGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BanHangGUI";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietSanPham).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)danhSachGioHang).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public TextBox txtTienThoi;
        private Label label9;
        private Button btnThanhToan;
        public TextBox txtKhachDua;
        private Label label8;
        public TextBox txtMaKhachHang;
        private Label label6;
        private GroupBox groupBox3;
        public TextBox txtTenNhanVien;
        private Label label5;
        public TextBox txtNgayNhap;
        private Label labelGiaNhap;
        public TextBox txtTongTien;
        private Label labelGiaSanPham;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtTimKiem;
        public DataGridView danhSachChiTietSanPham;
        private GroupBox groupBox2;
        public DataGridView danhSachGioHang;
        private Button btnChon;
        private Panel panel1;
        private Label label7;
        private DataGridViewTextBoxColumn MaChiTietSanPham;
        private DataGridViewTextBoxColumn MaSanPham;
        private DataGridViewTextBoxColumn MaMauSac;
        private DataGridViewTextBoxColumn MaKichCo;
        private DataGridViewTextBoxColumn SoLuongTon;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewImageColumn Them;
        private Button btnHuyHoaDon;
        private Button btnTaoHoaDon;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private ComboBox comboxTimKiem;
        private Button btnTimKiem;
        private DataGridViewTextBoxColumn MaChiTiet;
        private DataGridViewTextBoxColumn MaCTSP;
        private DataGridViewTextBoxColumn MauSac;
        private DataGridViewTextBoxColumn KichCo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewImageColumn Xoa;
    }
}