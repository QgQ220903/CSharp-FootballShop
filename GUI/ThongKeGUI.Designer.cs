namespace GUI
{
    partial class ThongKeGUI
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pageDoanhThu = new TabPage();
            lbTongLoiNhuan = new Label();
            label16 = new Label();
            lbTongChiPhi = new Label();
            label14 = new Label();
            lbTongDoanhThu = new Label();
            label11 = new Label();
            doanhThuTheoNgay = new DataGridView();
            Ngay = new DataGridViewTextBoxColumn();
            DoanhThu = new DataGridViewTextBoxColumn();
            ChiPhi = new DataGridViewTextBoxColumn();
            LoiNhuan = new DataGridViewTextBoxColumn();
            btnDoanhThuTheoNgay = new Button();
            dateKetThuc = new DateTimePicker();
            label10 = new Label();
            dateBatDau = new DateTimePicker();
            label9 = new Label();
            pageTongQuan = new TabPage();
            tabControl2 = new TabControl();
            tabPage1 = new TabPage();
            danhSachBanChay = new DataGridView();
            MaChiTietSanPham = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            label15 = new Label();
            comboxLocSpTon = new ComboBox();
            danhSachSPTon = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            MauSac = new DataGridViewTextBoxColumn();
            KichCo = new DataGridViewTextBoxColumn();
            slTon = new DataGridViewTextBoxColumn();
            label12 = new Label();
            panel3 = new Panel();
            lbPhieuNhap = new Label();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            panel2 = new Panel();
            lbHoaDonBan = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            panel1 = new Panel();
            lbDoanhThu = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            pageDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doanhThuTheoNgay).BeginInit();
            pageTongQuan.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachBanChay).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachSPTon).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // pageDoanhThu
            // 
            pageDoanhThu.Controls.Add(lbTongLoiNhuan);
            pageDoanhThu.Controls.Add(label16);
            pageDoanhThu.Controls.Add(lbTongChiPhi);
            pageDoanhThu.Controls.Add(label14);
            pageDoanhThu.Controls.Add(lbTongDoanhThu);
            pageDoanhThu.Controls.Add(label11);
            pageDoanhThu.Controls.Add(doanhThuTheoNgay);
            pageDoanhThu.Controls.Add(btnDoanhThuTheoNgay);
            pageDoanhThu.Controls.Add(dateKetThuc);
            pageDoanhThu.Controls.Add(label10);
            pageDoanhThu.Controls.Add(dateBatDau);
            pageDoanhThu.Controls.Add(label9);
            pageDoanhThu.Location = new Point(4, 34);
            pageDoanhThu.Name = "pageDoanhThu";
            pageDoanhThu.Padding = new Padding(3);
            pageDoanhThu.Size = new Size(1592, 862);
            pageDoanhThu.TabIndex = 0;
            pageDoanhThu.Text = "Doanh Thu";
            pageDoanhThu.UseVisualStyleBackColor = true;
            // 
            // lbTongLoiNhuan
            // 
            lbTongLoiNhuan.AutoSize = true;
            lbTongLoiNhuan.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTongLoiNhuan.ForeColor = Color.MediumSeaGreen;
            lbTongLoiNhuan.Location = new Point(1352, 791);
            lbTongLoiNhuan.Name = "lbTongLoiNhuan";
            lbTongLoiNhuan.Size = new Size(24, 27);
            lbTongLoiNhuan.TabIndex = 32;
            lbTongLoiNhuan.Text = "0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1208, 793);
            label16.Name = "label16";
            label16.Size = new Size(138, 25);
            label16.TabIndex = 31;
            label16.Text = "Tổng Lợi Nhuận";
            // 
            // lbTongChiPhi
            // 
            lbTongChiPhi.AutoSize = true;
            lbTongChiPhi.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTongChiPhi.ForeColor = Color.MediumSeaGreen;
            lbTongChiPhi.Location = new Point(781, 791);
            lbTongChiPhi.Name = "lbTongChiPhi";
            lbTongChiPhi.Size = new Size(24, 27);
            lbTongChiPhi.TabIndex = 30;
            lbTongChiPhi.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(663, 793);
            label14.Name = "label14";
            label14.Size = new Size(112, 25);
            label14.TabIndex = 29;
            label14.Text = "Tổng Chi Phí";
            // 
            // lbTongDoanhThu
            // 
            lbTongDoanhThu.AutoSize = true;
            lbTongDoanhThu.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTongDoanhThu.ForeColor = Color.MediumSeaGreen;
            lbTongDoanhThu.Location = new Point(246, 793);
            lbTongDoanhThu.Name = "lbTongDoanhThu";
            lbTongDoanhThu.Size = new Size(24, 27);
            lbTongDoanhThu.TabIndex = 28;
            lbTongDoanhThu.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(95, 793);
            label11.Name = "label11";
            label11.Size = new Size(145, 25);
            label11.TabIndex = 27;
            label11.Text = "Tổng Doanh Thu";
            // 
            // doanhThuTheoNgay
            // 
            doanhThuTheoNgay.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            doanhThuTheoNgay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            doanhThuTheoNgay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            doanhThuTheoNgay.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            doanhThuTheoNgay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            doanhThuTheoNgay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doanhThuTheoNgay.Columns.AddRange(new DataGridViewColumn[] { Ngay, DoanhThu, ChiPhi, LoiNhuan });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            doanhThuTheoNgay.DefaultCellStyle = dataGridViewCellStyle3;
            doanhThuTheoNgay.Location = new Point(21, 178);
            doanhThuTheoNgay.Name = "doanhThuTheoNgay";
            doanhThuTheoNgay.RowHeadersWidth = 62;
            doanhThuTheoNgay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            doanhThuTheoNgay.Size = new Size(1550, 587);
            doanhThuTheoNgay.TabIndex = 26;
            // 
            // Ngay
            // 
            Ngay.HeaderText = "Ngày";
            Ngay.MinimumWidth = 8;
            Ngay.Name = "Ngay";
            // 
            // DoanhThu
            // 
            DoanhThu.HeaderText = "Doanh thu";
            DoanhThu.MinimumWidth = 8;
            DoanhThu.Name = "DoanhThu";
            // 
            // ChiPhi
            // 
            ChiPhi.HeaderText = "Chi phí";
            ChiPhi.MinimumWidth = 8;
            ChiPhi.Name = "ChiPhi";
            // 
            // LoiNhuan
            // 
            LoiNhuan.HeaderText = "Lợi Nhuận";
            LoiNhuan.MinimumWidth = 8;
            LoiNhuan.Name = "LoiNhuan";
            // 
            // btnDoanhThuTheoNgay
            // 
            btnDoanhThuTheoNgay.Location = new Point(1459, 90);
            btnDoanhThuTheoNgay.Name = "btnDoanhThuTheoNgay";
            btnDoanhThuTheoNgay.Size = new Size(112, 34);
            btnDoanhThuTheoNgay.TabIndex = 25;
            btnDoanhThuTheoNgay.Text = "Xem";
            btnDoanhThuTheoNgay.UseVisualStyleBackColor = true;
            btnDoanhThuTheoNgay.Click += btnDoanhThuTheoNgay_Click;
            // 
            // dateKetThuc
            // 
            dateKetThuc.Format = DateTimePickerFormat.Short;
            dateKetThuc.Location = new Point(1127, 93);
            dateKetThuc.Name = "dateKetThuc";
            dateKetThuc.Size = new Size(300, 31);
            dateKetThuc.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1123, 65);
            label10.Name = "label10";
            label10.Size = new Size(88, 25);
            label10.TabIndex = 24;
            label10.Text = "Đến ngày";
            // 
            // dateBatDau
            // 
            dateBatDau.Format = DateTimePickerFormat.Short;
            dateBatDau.Location = new Point(805, 93);
            dateBatDau.Name = "dateBatDau";
            dateBatDau.Size = new Size(300, 31);
            dateBatDau.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(801, 65);
            label9.Name = "label9";
            label9.Size = new Size(76, 25);
            label9.TabIndex = 22;
            label9.Text = "Từ ngày";
            // 
            // pageTongQuan
            // 
            pageTongQuan.Controls.Add(tabControl2);
            pageTongQuan.Controls.Add(label12);
            pageTongQuan.Controls.Add(panel3);
            pageTongQuan.Controls.Add(panel2);
            pageTongQuan.Controls.Add(panel1);
            pageTongQuan.Location = new Point(4, 34);
            pageTongQuan.Name = "pageTongQuan";
            pageTongQuan.Padding = new Padding(3);
            pageTongQuan.Size = new Size(1592, 862);
            pageTongQuan.TabIndex = 1;
            pageTongQuan.Text = "Tổng Quan";
            pageTongQuan.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Controls.Add(tabPage2);
            tabControl2.Location = new Point(60, 244);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1471, 576);
            tabControl2.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(danhSachBanChay);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1463, 538);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bán chạy nhất";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // danhSachBanChay
            // 
            danhSachBanChay.AllowUserToAddRows = false;
            danhSachBanChay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachBanChay.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachBanChay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachBanChay.Columns.AddRange(new DataGridViewColumn[] { MaChiTietSanPham, TenSanPham, SoLuongBan });
            danhSachBanChay.Location = new Point(6, 6);
            danhSachBanChay.Name = "danhSachBanChay";
            danhSachBanChay.RowHeadersWidth = 62;
            danhSachBanChay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachBanChay.Size = new Size(1451, 526);
            danhSachBanChay.TabIndex = 0;
            // 
            // MaChiTietSanPham
            // 
            MaChiTietSanPham.HeaderText = "Mã chi tiết";
            MaChiTietSanPham.MinimumWidth = 8;
            MaChiTietSanPham.Name = "MaChiTietSanPham";
            // 
            // TenSanPham
            // 
            TenSanPham.HeaderText = "Sản phẩm";
            TenSanPham.MinimumWidth = 8;
            TenSanPham.Name = "TenSanPham";
            // 
            // SoLuongBan
            // 
            SoLuongBan.HeaderText = "Số lượng bán";
            SoLuongBan.MinimumWidth = 8;
            SoLuongBan.Name = "SoLuongBan";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(comboxLocSpTon);
            tabPage2.Controls.Add(danhSachSPTon);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1463, 538);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tồn kho";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1098, 24);
            label15.Name = "label15";
            label15.Size = new Size(80, 25);
            label15.TabIndex = 14;
            label15.Text = "Lọc theo";
            // 
            // comboxLocSpTon
            // 
            comboxLocSpTon.FormattingEnabled = true;
            comboxLocSpTon.Items.AddRange(new object[] { "Hết hàng", "Gần hết hàng", "Tất cả" });
            comboxLocSpTon.Location = new Point(1181, 21);
            comboxLocSpTon.Name = "comboxLocSpTon";
            comboxLocSpTon.Size = new Size(276, 33);
            comboxLocSpTon.TabIndex = 13;
            comboxLocSpTon.SelectedValueChanged += comboxLocSpTon_SelectedValueChanged;
            // 
            // danhSachSPTon
            // 
            danhSachSPTon.AllowUserToAddRows = false;
            danhSachSPTon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachSPTon.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachSPTon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachSPTon.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, MauSac, KichCo, slTon });
            danhSachSPTon.Location = new Point(6, 69);
            danhSachSPTon.Name = "danhSachSPTon";
            danhSachSPTon.RowHeadersWidth = 62;
            danhSachSPTon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachSPTon.Size = new Size(1451, 463);
            danhSachSPTon.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Mã chi tiết";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Sản phẩm";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // MauSac
            // 
            MauSac.HeaderText = "Màu sắc";
            MauSac.MinimumWidth = 8;
            MauSac.Name = "MauSac";
            // 
            // KichCo
            // 
            KichCo.HeaderText = "Kích cỡ";
            KichCo.MinimumWidth = 8;
            KichCo.Name = "KichCo";
            // 
            // slTon
            // 
            slTon.HeaderText = "Số lượng tồn";
            slTon.MinimumWidth = 8;
            slTon.Name = "slTon";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label12.Location = new Point(695, 209);
            label12.Name = "label12";
            label12.Size = new Size(137, 32);
            label12.TabIndex = 11;
            label12.Text = "SẢN PHẨM";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumSeaGreen;
            panel3.Controls.Add(lbPhieuNhap);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(1141, 36);
            panel3.Name = "panel3";
            panel3.Size = new Size(386, 127);
            panel3.TabIndex = 9;
            // 
            // lbPhieuNhap
            // 
            lbPhieuNhap.AutoSize = true;
            lbPhieuNhap.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbPhieuNhap.ForeColor = Color.White;
            lbPhieuNhap.Location = new Point(83, 69);
            lbPhieuNhap.Name = "lbPhieuNhap";
            lbPhieuNhap.Size = new Size(56, 32);
            lbPhieuNhap.TabIndex = 3;
            lbPhieuNhap.Text = "000";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Invoice;
            pictureBox3.Location = new Point(8, 25);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(69, 71);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.ForeColor = Color.White;
            label6.Location = new Point(83, 30);
            label6.Name = "label6";
            label6.Size = new Size(171, 27);
            label6.TabIndex = 1;
            label6.Text = "Phiếu nhập hàng";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(lbHoaDonBan);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(603, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(417, 127);
            panel2.TabIndex = 8;
            // 
            // lbHoaDonBan
            // 
            lbHoaDonBan.AutoSize = true;
            lbHoaDonBan.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbHoaDonBan.ForeColor = Color.White;
            lbHoaDonBan.Location = new Point(83, 69);
            lbHoaDonBan.Name = "lbHoaDonBan";
            lbHoaDonBan.Size = new Size(56, 32);
            lbHoaDonBan.TabIndex = 3;
            lbHoaDonBan.Text = "000";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Bill;
            pictureBox2.Location = new Point(8, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.White;
            label4.Location = new Point(83, 30);
            label4.Name = "label4";
            label4.Size = new Size(187, 27);
            label4.TabIndex = 1;
            label4.Text = "Hóa đơn bán hàng";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(lbDoanhThu);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(60, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 127);
            panel1.TabIndex = 7;
            // 
            // lbDoanhThu
            // 
            lbDoanhThu.AutoSize = true;
            lbDoanhThu.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbDoanhThu.ForeColor = Color.White;
            lbDoanhThu.Location = new Point(83, 69);
            lbDoanhThu.Name = "lbDoanhThu";
            lbDoanhThu.Size = new Size(196, 32);
            lbDoanhThu.TabIndex = 3;
            lbDoanhThu.Text = "10.000.000 VND";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Money;
            pictureBox1.Location = new Point(8, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(83, 30);
            label1.Name = "label1";
            label1.Size = new Size(162, 27);
            label1.TabIndex = 1;
            label1.Text = "Tổng doanh thu";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(pageTongQuan);
            tabControl1.Controls.Add(pageDoanhThu);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1600, 900);
            tabControl1.TabIndex = 7;
            // 
            // ThongKeGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThongKeGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThongKeGUI";
            pageDoanhThu.ResumeLayout(false);
            pageDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doanhThuTheoNgay).EndInit();
            pageTongQuan.ResumeLayout(false);
            pageTongQuan.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)danhSachBanChay).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachSPTon).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage pageSanPham;
        private TabPage pageDoanhThu;
        private TabPage pageTongQuan;
        private Panel panel1;
        private Label lbDoanhThu;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private Label lbTongLoiNhuan;
        private Label label16;
        private Label lbTongChiPhi;
        private Label label14;
        private Label lbTongDoanhThu;
        private Label label11;
        private DataGridView doanhThuTheoNgay;
        private DataGridViewTextBoxColumn Ngay;
        private DataGridViewTextBoxColumn DoanhThu;
        private DataGridViewTextBoxColumn ChiPhi;
        private DataGridViewTextBoxColumn LoiNhuan;
        private Button btnDoanhThuTheoNgay;
        private DateTimePicker dateKetThuc;
        private Label label10;
        private DateTimePicker dateBatDau;
        private Label label9;
        private Panel panel3;
        private Label lbPhieuNhap;
        private PictureBox pictureBox3;
        private Label label6;
        private Panel panel2;
        private Label lbHoaDonBan;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label12;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private DataGridView danhSachBanChay;
        private DataGridViewTextBoxColumn MaChiTietSanPham;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuongBan;
        private TabPage tabPage2;
        private Button btnTimKiem;
        private ComboBox comboxTimKiem;
        private Label label13;
        private TextBox txtTimKiem;
        public DataGridView danhSachChiTietSanPham;
        private DataGridViewTextBoxColumn MaSanPham;
        private DataGridViewTextBoxColumn MaMauSac;
        private DataGridViewTextBoxColumn MaKichCo;
        private DataGridViewTextBoxColumn SoLuongTon;
        private DataGridView danhSachSPTon;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn MauSac;
        private DataGridViewTextBoxColumn KichCo;
        private DataGridViewTextBoxColumn slTon;
        private ComboBox comboxLocSpTon;
        private Label label15;
    }
}