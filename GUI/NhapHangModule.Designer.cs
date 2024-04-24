namespace GUI
{
    partial class NhapHangModule
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
            DataGridViewCellStyle dataGridViewCellStyle33 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle34 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle35 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle37 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle38 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle39 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle40 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapHangModule));
            DataGridViewCellStyle dataGridViewCellStyle43 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle44 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle45 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle46 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle47 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle48 = new DataGridViewCellStyle();
            danhSachChiTietPhieuNhap = new DataGridView();
            MaChiTietSP = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            MauSac = new DataGridViewTextBoxColumn();
            KichCo = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            TienNhap = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            Xoa = new DataGridViewImageColumn();
            groupBox2 = new GroupBox();
            txtTimKiem = new TextBox();
            labelTenSanPham = new Label();
            btnThem = new Button();
            txtMaChiTietSanPham = new TextBox();
            danhSachChiTietSanPham = new DataGridView();
            MaChiTietSanPham = new DataGridViewTextBoxColumn();
            MaSanPham = new DataGridViewTextBoxColumn();
            MaMauSac = new DataGridViewTextBoxColumn();
            MaKichCo = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            label2 = new Label();
            comboxDonVi = new ComboBox();
            slNhap = new NumericUpDown();
            txtGiaNhap = new TextBox();
            label11 = new Label();
            label13 = new Label();
            label12 = new Label();
            labelGiaNhap = new Label();
            txtTongTien = new TextBox();
            labelGiaSanPham = new Label();
            comboxNhaCungCap = new ComboBox();
            txtNgayNhap = new TextBox();
            groupBox1 = new GroupBox();
            buttonLuuPhieuNhap = new Button();
            txtTenNhanVien = new TextBox();
            label5 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietPhieuNhap).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slNhap).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // danhSachChiTietPhieuNhap
            // 
            danhSachChiTietPhieuNhap.AllowUserToAddRows = false;
            danhSachChiTietPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachChiTietPhieuNhap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachChiTietPhieuNhap.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle33.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = SystemColors.Control;
            dataGridViewCellStyle33.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle33.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle33.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = DataGridViewTriState.True;
            danhSachChiTietPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            danhSachChiTietPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachChiTietPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { MaChiTietSP, TenSanPham, MauSac, KichCo, SoLuong, DonVi, TienNhap, ThanhTien, Xoa });
            danhSachChiTietPhieuNhap.Location = new Point(18, 30);
            danhSachChiTietPhieuNhap.Name = "danhSachChiTietPhieuNhap";
            danhSachChiTietPhieuNhap.RowHeadersWidth = 62;
            danhSachChiTietPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachChiTietPhieuNhap.Size = new Size(1511, 299);
            danhSachChiTietPhieuNhap.TabIndex = 131;
            danhSachChiTietPhieuNhap.CellContentClick += danhSachChiTietPhieuNhap_CellContentClick;
            // 
            // MaChiTietSP
            // 
            MaChiTietSP.DataPropertyName = "MaChiTietSanPham";
            dataGridViewCellStyle34.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle34.SelectionForeColor = Color.White;
            MaChiTietSP.DefaultCellStyle = dataGridViewCellStyle34;
            MaChiTietSP.HeaderText = "Mã Chi Tiết";
            MaChiTietSP.MinimumWidth = 8;
            MaChiTietSP.Name = "MaChiTietSP";
            // 
            // TenSanPham
            // 
            dataGridViewCellStyle35.Font = new Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle35.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle35.SelectionForeColor = Color.White;
            TenSanPham.DefaultCellStyle = dataGridViewCellStyle35;
            TenSanPham.HeaderText = "Tên Sản Phẩm";
            TenSanPham.MinimumWidth = 8;
            TenSanPham.Name = "TenSanPham";
            // 
            // MauSac
            // 
            MauSac.DataPropertyName = "MaMauSac";
            dataGridViewCellStyle36.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle36.SelectionForeColor = Color.White;
            MauSac.DefaultCellStyle = dataGridViewCellStyle36;
            MauSac.HeaderText = "Màu sắc";
            MauSac.MinimumWidth = 8;
            MauSac.Name = "MauSac";
            // 
            // KichCo
            // 
            KichCo.DataPropertyName = "MaKichCo";
            dataGridViewCellStyle37.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle37.SelectionForeColor = Color.White;
            KichCo.DefaultCellStyle = dataGridViewCellStyle37;
            KichCo.HeaderText = "Kích cở";
            KichCo.MinimumWidth = 8;
            KichCo.Name = "KichCo";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuongNhap";
            dataGridViewCellStyle38.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle38.SelectionForeColor = Color.White;
            SoLuong.DefaultCellStyle = dataGridViewCellStyle38;
            SoLuong.HeaderText = "Số lượng nhập";
            SoLuong.MinimumWidth = 8;
            SoLuong.Name = "SoLuong";
            // 
            // DonVi
            // 
            DonVi.DataPropertyName = "DonVi";
            dataGridViewCellStyle39.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle39.SelectionForeColor = Color.White;
            DonVi.DefaultCellStyle = dataGridViewCellStyle39;
            DonVi.HeaderText = "Đơn vị";
            DonVi.MinimumWidth = 8;
            DonVi.Name = "DonVi";
            // 
            // TienNhap
            // 
            TienNhap.DataPropertyName = "TienNhap";
            dataGridViewCellStyle40.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle40.SelectionForeColor = Color.White;
            TienNhap.DefaultCellStyle = dataGridViewCellStyle40;
            TienNhap.HeaderText = "Giá nhập";
            TienNhap.MinimumWidth = 8;
            TienNhap.Name = "TienNhap";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle41.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle41.SelectionForeColor = Color.White;
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle41;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 8;
            ThanhTien.Name = "ThanhTien";
            // 
            // Xoa
            // 
            Xoa.DataPropertyName = "Xoa";
            dataGridViewCellStyle42.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.NullValue = resources.GetObject("dataGridViewCellStyle42.NullValue");
            dataGridViewCellStyle42.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle42.SelectionForeColor = Color.White;
            Xoa.DefaultCellStyle = dataGridViewCellStyle42;
            Xoa.HeaderText = "Xóa";
            Xoa.Image = Properties.Resources.Delete;
            Xoa.MinimumWidth = 8;
            Xoa.Name = "Xoa";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(labelTenSanPham);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(txtMaChiTietSanPham);
            groupBox2.Controls.Add(danhSachChiTietSanPham);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboxDonVi);
            groupBox2.Controls.Add(slNhap);
            groupBox2.Controls.Add(txtGiaNhap);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Font = new Font("Segoe UI Variable Text", 9F);
            groupBox2.ForeColor = SystemColors.ControlText;
            groupBox2.Location = new Point(12, 120);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1191, 448);
            groupBox2.TabIndex = 130;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Sản Phẩm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI Variable Display", 10F);
            txtTimKiem.Location = new Point(124, 34);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(302, 34);
            txtTimKiem.TabIndex = 147;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // labelTenSanPham
            // 
            labelTenSanPham.AutoSize = true;
            labelTenSanPham.Font = new Font("Segoe UI Variable Display", 10F);
            labelTenSanPham.ForeColor = SystemColors.ControlText;
            labelTenSanPham.Location = new Point(25, 37);
            labelTenSanPham.Name = "labelTenSanPham";
            labelTenSanPham.Size = new Size(93, 27);
            labelTenSanPham.TabIndex = 146;
            labelTenSanPham.Text = "Tìm Kiếm";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumSeaGreen;
            btnThem.Font = new Font("Segoe UI Variable Text", 9F);
            btnThem.ForeColor = SystemColors.ButtonHighlight;
            btnThem.Image = Properties.Resources.Add_Product;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(1051, 380);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(119, 55);
            btnThem.TabIndex = 144;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtMaChiTietSanPham
            // 
            txtMaChiTietSanPham.Font = new Font("Segoe UI Variable Display", 10F);
            txtMaChiTietSanPham.Location = new Point(242, 389);
            txtMaChiTietSanPham.Name = "txtMaChiTietSanPham";
            txtMaChiTietSanPham.ReadOnly = true;
            txtMaChiTietSanPham.Size = new Size(92, 34);
            txtMaChiTietSanPham.TabIndex = 143;
            // 
            // danhSachChiTietSanPham
            // 
            danhSachChiTietSanPham.AllowUserToAddRows = false;
            danhSachChiTietSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachChiTietSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachChiTietSanPham.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle43.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = SystemColors.Control;
            dataGridViewCellStyle43.Font = new Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle43.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle43.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle43.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = DataGridViewTriState.True;
            danhSachChiTietSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle43;
            danhSachChiTietSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachChiTietSanPham.Columns.AddRange(new DataGridViewColumn[] { MaChiTietSanPham, MaSanPham, MaMauSac, MaKichCo, SoLuongTon });
            danhSachChiTietSanPham.Location = new Point(18, 82);
            danhSachChiTietSanPham.Name = "danhSachChiTietSanPham";
            danhSachChiTietSanPham.RowHeadersWidth = 62;
            danhSachChiTietSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachChiTietSanPham.Size = new Size(1152, 290);
            danhSachChiTietSanPham.TabIndex = 105;
            danhSachChiTietSanPham.CellContentClick += danhSachChiTietSanPham_CellContentClick;
            // 
            // MaChiTietSanPham
            // 
            MaChiTietSanPham.DataPropertyName = "MaChiTietSanPham";
            dataGridViewCellStyle44.BackColor = Color.White;
            dataGridViewCellStyle44.NullValue = null;
            dataGridViewCellStyle44.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle44.SelectionForeColor = Color.White;
            MaChiTietSanPham.DefaultCellStyle = dataGridViewCellStyle44;
            MaChiTietSanPham.HeaderText = "Mã chi tiết";
            MaChiTietSanPham.MinimumWidth = 8;
            MaChiTietSanPham.Name = "MaChiTietSanPham";
            // 
            // MaSanPham
            // 
            MaSanPham.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaSanPham.DataPropertyName = "MaSanPham";
            dataGridViewCellStyle45.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle45.SelectionForeColor = Color.White;
            MaSanPham.DefaultCellStyle = dataGridViewCellStyle45;
            MaSanPham.HeaderText = "Sản phẩm";
            MaSanPham.MinimumWidth = 8;
            MaSanPham.Name = "MaSanPham";
            // 
            // MaMauSac
            // 
            MaMauSac.DataPropertyName = "MaMauSac";
            dataGridViewCellStyle46.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle46.SelectionForeColor = Color.White;
            MaMauSac.DefaultCellStyle = dataGridViewCellStyle46;
            MaMauSac.HeaderText = "Màu sắc";
            MaMauSac.MinimumWidth = 8;
            MaMauSac.Name = "MaMauSac";
            // 
            // MaKichCo
            // 
            MaKichCo.DataPropertyName = "MaKichCo";
            dataGridViewCellStyle47.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle47.SelectionForeColor = Color.White;
            MaKichCo.DefaultCellStyle = dataGridViewCellStyle47;
            MaKichCo.HeaderText = "Kích cỡ";
            MaKichCo.MinimumWidth = 8;
            MaKichCo.Name = "MaKichCo";
            // 
            // SoLuongTon
            // 
            SoLuongTon.DataPropertyName = "SoLuongTon";
            dataGridViewCellStyle48.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle48.SelectionForeColor = Color.White;
            SoLuongTon.DefaultCellStyle = dataGridViewCellStyle48;
            SoLuongTon.HeaderText = "Số lượng tồn";
            SoLuongTon.MinimumWidth = 8;
            SoLuongTon.Name = "SoLuongTon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 10F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(124, 392);
            label2.Name = "label2";
            label2.Size = new Size(112, 27);
            label2.TabIndex = 142;
            label2.Text = "Mã Chi Tiết";
            // 
            // comboxDonVi
            // 
            comboxDonVi.FormattingEnabled = true;
            comboxDonVi.Items.AddRange(new object[] { "Bộ", "Cái", "Đôi" });
            comboxDonVi.Location = new Point(628, 390);
            comboxDonVi.Name = "comboxDonVi";
            comboxDonVi.Size = new Size(113, 32);
            comboxDonVi.TabIndex = 141;
            // 
            // slNhap
            // 
            slNhap.Location = new Point(459, 391);
            slNhap.Name = "slNhap";
            slNhap.Size = new Size(69, 31);
            slNhap.TabIndex = 140;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Font = new Font("Segoe UI Variable Display", 10F);
            txtGiaNhap.Location = new Point(859, 387);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.ReadOnly = true;
            txtGiaNhap.Size = new Size(153, 34);
            txtGiaNhap.TabIndex = 139;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Variable Display", 10F);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(361, 390);
            label11.Name = "label11";
            label11.Size = new Size(92, 27);
            label11.TabIndex = 136;
            label11.Text = "Số lượng";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Variable Display", 10F);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(763, 390);
            label13.Name = "label13";
            label13.Size = new Size(90, 27);
            label13.TabIndex = 138;
            label13.Text = "Giá nhập";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Variable Display", 10F);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(553, 390);
            label12.Name = "label12";
            label12.Size = new Size(69, 27);
            label12.TabIndex = 137;
            label12.Text = "Đơn vị";
            // 
            // labelGiaNhap
            // 
            labelGiaNhap.AutoSize = true;
            labelGiaNhap.BackColor = SystemColors.Control;
            labelGiaNhap.Font = new Font("Segoe UI Variable Display", 10F);
            labelGiaNhap.ForeColor = SystemColors.ControlText;
            labelGiaNhap.Location = new Point(24, 208);
            labelGiaNhap.Name = "labelGiaNhap";
            labelGiaNhap.Size = new Size(108, 27);
            labelGiaNhap.TabIndex = 124;
            labelGiaNhap.Text = "Ngày nhập";
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = SystemColors.Control;
            txtTongTien.Font = new Font("Segoe UI Variable Display", 10F);
            txtTongTien.ForeColor = Color.Red;
            txtTongTien.Location = new Point(24, 313);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(302, 34);
            txtTongTien.TabIndex = 123;
            txtTongTien.Text = "0";
            // 
            // labelGiaSanPham
            // 
            labelGiaSanPham.AutoSize = true;
            labelGiaSanPham.BackColor = SystemColors.Control;
            labelGiaSanPham.Font = new Font("Segoe UI Variable Display", 10F);
            labelGiaSanPham.ForeColor = SystemColors.ControlText;
            labelGiaSanPham.Location = new Point(24, 283);
            labelGiaSanPham.Name = "labelGiaSanPham";
            labelGiaSanPham.Size = new Size(95, 27);
            labelGiaSanPham.TabIndex = 122;
            labelGiaSanPham.Text = "Tổng tiền";
            // 
            // comboxNhaCungCap
            // 
            comboxNhaCungCap.Font = new Font("Segoe UI Variable Display", 10F);
            comboxNhaCungCap.FormattingEnabled = true;
            comboxNhaCungCap.Location = new Point(24, 149);
            comboxNhaCungCap.Name = "comboxNhaCungCap";
            comboxNhaCungCap.Size = new Size(302, 35);
            comboxNhaCungCap.TabIndex = 123;
            comboxNhaCungCap.SelectedIndexChanged += comboxNhaCungCap_SelectedIndexChanged;
            comboxNhaCungCap.SelectedValueChanged += comboxNhaCungCap_SelectedValueChanged;
            // 
            // txtNgayNhap
            // 
            txtNgayNhap.BackColor = SystemColors.Control;
            txtNgayNhap.Font = new Font("Segoe UI Variable Display", 10F);
            txtNgayNhap.ForeColor = SystemColors.ControlText;
            txtNgayNhap.Location = new Point(24, 238);
            txtNgayNhap.Name = "txtNgayNhap";
            txtNgayNhap.ReadOnly = true;
            txtNgayNhap.Size = new Size(302, 34);
            txtNgayNhap.TabIndex = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonLuuPhieuNhap);
            groupBox1.Controls.Add(txtTenNhanVien);
            groupBox1.Controls.Add(comboxNhaCungCap);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNgayNhap);
            groupBox1.Controls.Add(labelGiaNhap);
            groupBox1.Controls.Add(txtTongTien);
            groupBox1.Controls.Add(labelGiaSanPham);
            groupBox1.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(1209, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 448);
            groupBox1.TabIndex = 129;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Phiếu Nhập";
            // 
            // buttonLuuPhieuNhap
            // 
            buttonLuuPhieuNhap.BackColor = Color.MediumSeaGreen;
            buttonLuuPhieuNhap.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold);
            buttonLuuPhieuNhap.ForeColor = SystemColors.ButtonHighlight;
            buttonLuuPhieuNhap.Location = new Point(24, 376);
            buttonLuuPhieuNhap.Name = "buttonLuuPhieuNhap";
            buttonLuuPhieuNhap.Size = new Size(302, 54);
            buttonLuuPhieuNhap.TabIndex = 129;
            buttonLuuPhieuNhap.Text = "Lưu ";
            buttonLuuPhieuNhap.UseVisualStyleBackColor = false;
            buttonLuuPhieuNhap.Click += buttonLuuPhieuNhap_Click;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.BackColor = SystemColors.Control;
            txtTenNhanVien.Font = new Font("Segoe UI Variable Display", 10F);
            txtTenNhanVien.ForeColor = SystemColors.ControlText;
            txtTenNhanVien.Location = new Point(24, 71);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.ReadOnly = true;
            txtTenNhanVien.Size = new Size(302, 34);
            txtTenNhanVien.TabIndex = 129;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI Variable Display", 10F);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(24, 41);
            label5.Name = "label5";
            label5.Size = new Size(117, 27);
            label5.TabIndex = 128;
            label5.Text = "Người nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 10F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(24, 119);
            label1.Name = "label1";
            label1.Size = new Size(134, 27);
            label1.TabIndex = 122;
            label1.Text = "Nhà cung cấp";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1587, 100);
            panel1.TabIndex = 132;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(691, 32);
            label3.Name = "label3";
            label3.Size = new Size(187, 37);
            label3.TabIndex = 1;
            label3.Text = "PHIẾU NHẬP";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(danhSachChiTietPhieuNhap);
            groupBox3.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            groupBox3.Location = new Point(12, 584);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1547, 346);
            groupBox3.TabIndex = 133;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chi Tiết Phiếu";
            // 
            // NhapHangModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1587, 957);
            Controls.Add(groupBox3);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "NhapHangModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhapHangModule";
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietPhieuNhap).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)slNhap).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView danhSachChiTietPhieuNhap;
        private GroupBox groupBox2;
        private Button btnThem;
        public TextBox txtMaChiTietSanPham;
        public DataGridView danhSachChiTietSanPham;
        private DataGridViewTextBoxColumn MaChiTietSanPham;
        private DataGridViewTextBoxColumn MaSanPham;
        private DataGridViewTextBoxColumn MaMauSac;
        private DataGridViewTextBoxColumn MaKichCo;
        private DataGridViewTextBoxColumn SoLuongTon;
        private Label label2;
        private ComboBox comboxDonVi;
        private NumericUpDown slNhap;
        public TextBox txtGiaNhap;
        private Label label11;
        private Label label13;
        private Label label12;
        private Label labelGiaNhap;
        public TextBox txtTongTien;
        private Label labelGiaSanPham;
        public ComboBox comboxNhaCungCap;
        public TextBox txtNgayNhap;
        private GroupBox groupBox1;
        private Button buttonLuuPhieuNhap;
        public TextBox txtTenNhanVien;
        private Label label5;
        private Label label1;
        public TextBox txtTimKiem;
        private Label labelTenSanPham;
        private Panel panel1;
        private Label label3;
        private GroupBox groupBox3;
        private DataGridViewTextBoxColumn MaChiTietSP;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn MauSac;
        private DataGridViewTextBoxColumn KichCo;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn TienNhap;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewImageColumn Xoa;
    }
}