namespace GUI
{
    partial class ChiTietHoaDonGUI
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietHoaDonGUI));
            danhSachChiTietHoaDon = new DataGridView();
            MaChiTietHoaDon = new DataGridViewTextBoxColumn();
            MaHoaDon = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            MauSac = new DataGridViewTextBoxColumn();
            KichCo = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            lbMaNhanVien = new Label();
            lbMaKhachHang = new Label();
            lbNgayLap = new Label();
            lbMaHoaDon = new Label();
            label3 = new Label();
            label5 = new Label();
            label1 = new Label();
            labelGiaNhap = new Label();
            panel1 = new Panel();
            label2 = new Label();
            labelGiaSanPham = new Label();
            groupBox1 = new GroupBox();
            lbTongTien = new Label();
            button1 = new Button();
            btnThem = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDialog1 = new PrintDialog();
            printDocument2 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietHoaDon).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // danhSachChiTietHoaDon
            // 
            danhSachChiTietHoaDon.AllowUserToAddRows = false;
            danhSachChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachChiTietHoaDon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachChiTietHoaDon.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            danhSachChiTietHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            danhSachChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachChiTietHoaDon.Columns.AddRange(new DataGridViewColumn[] { MaChiTietHoaDon, MaHoaDon, TenSanPham, MauSac, KichCo, SoLuong, GiaBan, ThanhTien });
            danhSachChiTietHoaDon.Location = new Point(12, 299);
            danhSachChiTietHoaDon.Name = "danhSachChiTietHoaDon";
            danhSachChiTietHoaDon.RowHeadersWidth = 62;
            danhSachChiTietHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachChiTietHoaDon.Size = new Size(1360, 306);
            danhSachChiTietHoaDon.TabIndex = 146;
            // 
            // MaChiTietHoaDon
            // 
            MaChiTietHoaDon.DataPropertyName = "MaChiTietHoaDon";
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            MaChiTietHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            MaChiTietHoaDon.HeaderText = "Mã Chi Tiết";
            MaChiTietHoaDon.MinimumWidth = 8;
            MaChiTietHoaDon.Name = "MaChiTietHoaDon";
            // 
            // MaHoaDon
            // 
            MaHoaDon.DataPropertyName = "MaHoaDon";
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            MaHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            MaHoaDon.HeaderText = "Mã Hóa Đơn";
            MaHoaDon.MinimumWidth = 8;
            MaHoaDon.Name = "MaHoaDon";
            // 
            // TenSanPham
            // 
            dataGridViewCellStyle4.Font = new Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            TenSanPham.DefaultCellStyle = dataGridViewCellStyle4;
            TenSanPham.HeaderText = "Tên Sản Phẩm";
            TenSanPham.MinimumWidth = 8;
            TenSanPham.Name = "TenSanPham";
            // 
            // MauSac
            // 
            MauSac.DataPropertyName = "MaMauSac";
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            MauSac.DefaultCellStyle = dataGridViewCellStyle5;
            MauSac.HeaderText = "Màu sắc";
            MauSac.MinimumWidth = 8;
            MauSac.Name = "MauSac";
            // 
            // KichCo
            // 
            KichCo.DataPropertyName = "MaKichCo";
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            KichCo.DefaultCellStyle = dataGridViewCellStyle6;
            KichCo.HeaderText = "Kích cở";
            KichCo.MinimumWidth = 8;
            KichCo.Name = "KichCo";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuongNhap";
            dataGridViewCellStyle7.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            SoLuong.DefaultCellStyle = dataGridViewCellStyle7;
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 8;
            SoLuong.Name = "SoLuong";
            // 
            // GiaBan
            // 
            GiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle8.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            GiaBan.DefaultCellStyle = dataGridViewCellStyle8;
            GiaBan.HeaderText = "Giá Sản Phẩm";
            GiaBan.MinimumWidth = 8;
            GiaBan.Name = "GiaBan";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle9.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle9;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 8;
            ThanhTien.Name = "ThanhTien";
            // 
            // lbMaNhanVien
            // 
            lbMaNhanVien.AutoSize = true;
            lbMaNhanVien.Font = new Font("Segoe UI Variable Text", 10F);
            lbMaNhanVien.Location = new Point(909, 119);
            lbMaNhanVien.Name = "lbMaNhanVien";
            lbMaNhanVien.Size = new Size(65, 27);
            lbMaNhanVien.TabIndex = 135;
            lbMaNhanVien.Text = "label8";
            // 
            // lbMaKhachHang
            // 
            lbMaKhachHang.AutoSize = true;
            lbMaKhachHang.Font = new Font("Segoe UI Variable Text", 10F);
            lbMaKhachHang.Location = new Point(909, 54);
            lbMaKhachHang.Name = "lbMaKhachHang";
            lbMaKhachHang.Size = new Size(65, 27);
            lbMaKhachHang.TabIndex = 134;
            lbMaKhachHang.Text = "label7";
            // 
            // lbNgayLap
            // 
            lbNgayLap.AutoSize = true;
            lbNgayLap.Font = new Font("Segoe UI Variable Text", 10F);
            lbNgayLap.Location = new Point(235, 119);
            lbNgayLap.Name = "lbNgayLap";
            lbNgayLap.Size = new Size(65, 27);
            lbNgayLap.TabIndex = 133;
            lbNgayLap.Text = "label6";
            // 
            // lbMaHoaDon
            // 
            lbMaHoaDon.AutoSize = true;
            lbMaHoaDon.Font = new Font("Segoe UI Variable Text", 10F);
            lbMaHoaDon.Location = new Point(235, 54);
            lbMaHoaDon.Name = "lbMaHoaDon";
            lbMaHoaDon.Size = new Size(65, 27);
            lbMaHoaDon.TabIndex = 132;
            lbMaHoaDon.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI Variable Display", 10F);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(106, 54);
            label3.Name = "label3";
            label3.Size = new Size(123, 27);
            label3.TabIndex = 131;
            label3.Text = "Mã Hóa Đơn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI Variable Display", 10F);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(754, 54);
            label5.Name = "label5";
            label5.Size = new Size(118, 27);
            label5.TabIndex = 128;
            label5.Text = "Khách Hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 10F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(754, 119);
            label1.Name = "label1";
            label1.Size = new Size(102, 27);
            label1.TabIndex = 122;
            label1.Text = "Nhân Viên";
            // 
            // labelGiaNhap
            // 
            labelGiaNhap.AutoSize = true;
            labelGiaNhap.BackColor = SystemColors.Control;
            labelGiaNhap.Font = new Font("Segoe UI Variable Display", 10F);
            labelGiaNhap.ForeColor = SystemColors.ControlText;
            labelGiaNhap.Location = new Point(104, 119);
            labelGiaNhap.Name = "labelGiaNhap";
            labelGiaNhap.Size = new Size(95, 27);
            labelGiaNhap.TabIndex = 124;
            labelGiaNhap.Text = "Ngày Lập";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1384, 91);
            panel1.TabIndex = 145;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(526, 29);
            label2.Name = "label2";
            label2.Size = new Size(270, 37);
            label2.TabIndex = 1;
            label2.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // labelGiaSanPham
            // 
            labelGiaSanPham.AutoSize = true;
            labelGiaSanPham.BackColor = SystemColors.Control;
            labelGiaSanPham.Font = new Font("Segoe UI Variable Display", 10F);
            labelGiaSanPham.ForeColor = SystemColors.ControlText;
            labelGiaSanPham.Location = new Point(43, 634);
            labelGiaSanPham.Name = "labelGiaSanPham";
            labelGiaSanPham.Size = new Size(95, 27);
            labelGiaSanPham.TabIndex = 143;
            labelGiaSanPham.Text = "Tổng tiền";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbMaNhanVien);
            groupBox1.Controls.Add(lbMaKhachHang);
            groupBox1.Controls.Add(lbNgayLap);
            groupBox1.Controls.Add(lbMaHoaDon);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(labelGiaNhap);
            groupBox1.Location = new Point(12, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1360, 174);
            groupBox1.TabIndex = 144;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold);
            lbTongTien.ForeColor = Color.Red;
            lbTongTien.Location = new Point(144, 630);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(79, 32);
            lbTongTien.TabIndex = 149;
            lbTongTien.Text = "label9";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1232, 615);
            button1.Name = "button1";
            button1.Size = new Size(140, 64);
            button1.TabIndex = 148;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumSeaGreen;
            btnThem.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Image = Properties.Resources.Export_Pdf;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(978, 615);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(248, 64);
            btnThem.TabIndex = 147;
            btnThem.Text = "Xuất File PDF";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // ChiTietHoaDonGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 692);
            Controls.Add(danhSachChiTietHoaDon);
            Controls.Add(panel1);
            Controls.Add(labelGiaSanPham);
            Controls.Add(groupBox1);
            Controls.Add(lbTongTien);
            Controls.Add(button1);
            Controls.Add(btnThem);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChiTietHoaDonGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChiTietHoaDonGUI";
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietHoaDon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView danhSachChiTietHoaDon;
        private Label lbMaNhanVien;
        private Label lbMaKhachHang;
        private Label lbNgayLap;
        private Label lbMaHoaDon;
        private Label label3;
        private Label label5;
        private Label label1;
        private Label labelGiaNhap;
        private Panel panel1;
        private Label label2;
        private Label labelGiaSanPham;
        private GroupBox groupBox1;
        private Label lbTongTien;
        public Button button1;
        public Button btnThem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private DataGridViewTextBoxColumn MaChiTietHoaDon;
        private DataGridViewTextBoxColumn MaHoaDon;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn MauSac;
        private DataGridViewTextBoxColumn KichCo;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn ThanhTien;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument2;
    }
}