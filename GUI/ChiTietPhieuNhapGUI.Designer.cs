namespace GUI
{
    partial class ChiTietPhieuNhapGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietPhieuNhapGUI));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            printPreviewDialog1 = new PrintPreviewDialog();
            lbTongTien = new Label();
            button1 = new Button();
            btnThem = new Button();
            ThanhTien = new DataGridViewTextBoxColumn();
            TienNhap = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            KichCo = new DataGridViewTextBoxColumn();
            MauSac = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            MaPhieuNhap = new DataGridViewTextBoxColumn();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            MaChiTietSP = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel1 = new Panel();
            labelGiaSanPham = new Label();
            lbNhaCungCap = new Label();
            lbNguoiNhap = new Label();
            lbNgayNhap = new Label();
            lbMaPhieu = new Label();
            label3 = new Label();
            label5 = new Label();
            label1 = new Label();
            labelGiaNhap = new Label();
            groupBox1 = new GroupBox();
            danhSachChiTietPhieuNhap = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietPhieuNhap).BeginInit();
            SuspendLayout();
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
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold);
            lbTongTien.ForeColor = Color.Red;
            lbTongTien.Location = new Point(144, 631);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(79, 32);
            lbTongTien.TabIndex = 142;
            lbTongTien.Text = "label9";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1232, 616);
            button1.Name = "button1";
            button1.Size = new Size(140, 64);
            button1.TabIndex = 141;
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
            btnThem.Location = new Point(978, 616);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(248, 64);
            btnThem.TabIndex = 140;
            btnThem.Text = "Xuất File PDF";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle1;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 8;
            ThanhTien.Name = "ThanhTien";
            // 
            // TienNhap
            // 
            TienNhap.DataPropertyName = "TienNhap";
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            TienNhap.DefaultCellStyle = dataGridViewCellStyle2;
            TienNhap.HeaderText = "Giá nhập";
            TienNhap.MinimumWidth = 8;
            TienNhap.Name = "TienNhap";
            // 
            // DonVi
            // 
            DonVi.DataPropertyName = "DonVi";
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            DonVi.DefaultCellStyle = dataGridViewCellStyle3;
            DonVi.HeaderText = "Đơn vị";
            DonVi.MinimumWidth = 8;
            DonVi.Name = "DonVi";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuongNhap";
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            SoLuong.DefaultCellStyle = dataGridViewCellStyle4;
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 8;
            SoLuong.Name = "SoLuong";
            // 
            // KichCo
            // 
            KichCo.DataPropertyName = "MaKichCo";
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            KichCo.DefaultCellStyle = dataGridViewCellStyle5;
            KichCo.HeaderText = "Kích cở";
            KichCo.MinimumWidth = 8;
            KichCo.Name = "KichCo";
            // 
            // MauSac
            // 
            MauSac.DataPropertyName = "MaMauSac";
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            MauSac.DefaultCellStyle = dataGridViewCellStyle6;
            MauSac.HeaderText = "Màu sắc";
            MauSac.MinimumWidth = 8;
            MauSac.Name = "MauSac";
            // 
            // TenSanPham
            // 
            dataGridViewCellStyle7.Font = new Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle7.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            TenSanPham.DefaultCellStyle = dataGridViewCellStyle7;
            TenSanPham.HeaderText = "Tên Sản Phẩm";
            TenSanPham.MinimumWidth = 8;
            TenSanPham.Name = "TenSanPham";
            // 
            // MaPhieuNhap
            // 
            MaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            dataGridViewCellStyle8.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            MaPhieuNhap.DefaultCellStyle = dataGridViewCellStyle8;
            MaPhieuNhap.HeaderText = "Mã Phiếu Nhập";
            MaPhieuNhap.MinimumWidth = 8;
            MaPhieuNhap.Name = "MaPhieuNhap";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // MaChiTietSP
            // 
            MaChiTietSP.DataPropertyName = "MaChiTietSanPham";
            dataGridViewCellStyle9.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            MaChiTietSP.DefaultCellStyle = dataGridViewCellStyle9;
            MaChiTietSP.HeaderText = "Mã Chi Tiết";
            MaChiTietSP.MinimumWidth = 8;
            MaChiTietSP.Name = "MaChiTietSP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(534, 27);
            label2.Name = "label2";
            label2.Size = new Size(278, 37);
            label2.TabIndex = 1;
            label2.Text = "Chi Tiết Phiếu Nhập";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1384, 91);
            panel1.TabIndex = 138;
            // 
            // labelGiaSanPham
            // 
            labelGiaSanPham.AutoSize = true;
            labelGiaSanPham.BackColor = SystemColors.Control;
            labelGiaSanPham.Font = new Font("Segoe UI Variable Display", 10F);
            labelGiaSanPham.ForeColor = SystemColors.ControlText;
            labelGiaSanPham.Location = new Point(43, 635);
            labelGiaSanPham.Name = "labelGiaSanPham";
            labelGiaSanPham.Size = new Size(95, 27);
            labelGiaSanPham.TabIndex = 136;
            labelGiaSanPham.Text = "Tổng tiền";
            // 
            // lbNhaCungCap
            // 
            lbNhaCungCap.AutoSize = true;
            lbNhaCungCap.Font = new Font("Segoe UI Variable Text", 10F);
            lbNhaCungCap.Location = new Point(870, 112);
            lbNhaCungCap.Name = "lbNhaCungCap";
            lbNhaCungCap.Size = new Size(65, 27);
            lbNhaCungCap.TabIndex = 135;
            lbNhaCungCap.Text = "label8";
            // 
            // lbNguoiNhap
            // 
            lbNguoiNhap.AutoSize = true;
            lbNguoiNhap.Font = new Font("Segoe UI Variable Text", 10F);
            lbNguoiNhap.Location = new Point(870, 47);
            lbNguoiNhap.Name = "lbNguoiNhap";
            lbNguoiNhap.Size = new Size(65, 27);
            lbNguoiNhap.TabIndex = 134;
            lbNguoiNhap.Text = "label7";
            // 
            // lbNgayNhap
            // 
            lbNgayNhap.AutoSize = true;
            lbNgayNhap.Font = new Font("Segoe UI Variable Text", 10F);
            lbNgayNhap.Location = new Point(190, 112);
            lbNgayNhap.Name = "lbNgayNhap";
            lbNgayNhap.Size = new Size(65, 27);
            lbNgayNhap.TabIndex = 133;
            lbNgayNhap.Text = "label6";
            // 
            // lbMaPhieu
            // 
            lbMaPhieu.AutoSize = true;
            lbMaPhieu.Font = new Font("Segoe UI Variable Text", 10F);
            lbMaPhieu.Location = new Point(190, 47);
            lbMaPhieu.Name = "lbMaPhieu";
            lbMaPhieu.Size = new Size(65, 27);
            lbMaPhieu.TabIndex = 132;
            lbMaPhieu.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI Variable Display", 10F);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(67, 47);
            label3.Name = "label3";
            label3.Size = new Size(93, 27);
            label3.TabIndex = 131;
            label3.Text = "Mã Phiếu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI Variable Display", 10F);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(715, 47);
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
            label1.Location = new Point(715, 112);
            label1.Name = "label1";
            label1.Size = new Size(134, 27);
            label1.TabIndex = 122;
            label1.Text = "Nhà cung cấp";
            // 
            // labelGiaNhap
            // 
            labelGiaNhap.AutoSize = true;
            labelGiaNhap.BackColor = SystemColors.Control;
            labelGiaNhap.Font = new Font("Segoe UI Variable Display", 10F);
            labelGiaNhap.ForeColor = SystemColors.ControlText;
            labelGiaNhap.Location = new Point(65, 112);
            labelGiaNhap.Name = "labelGiaNhap";
            labelGiaNhap.Size = new Size(108, 27);
            labelGiaNhap.TabIndex = 124;
            labelGiaNhap.Text = "Ngày nhập";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbNhaCungCap);
            groupBox1.Controls.Add(lbNguoiNhap);
            groupBox1.Controls.Add(lbNgayNhap);
            groupBox1.Controls.Add(lbMaPhieu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(labelGiaNhap);
            groupBox1.Location = new Point(12, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1360, 174);
            groupBox1.TabIndex = 137;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // danhSachChiTietPhieuNhap
            // 
            danhSachChiTietPhieuNhap.AllowUserToAddRows = false;
            danhSachChiTietPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachChiTietPhieuNhap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachChiTietPhieuNhap.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            danhSachChiTietPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            danhSachChiTietPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachChiTietPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { MaChiTietSP, MaPhieuNhap, TenSanPham, MauSac, KichCo, SoLuong, DonVi, TienNhap, ThanhTien });
            danhSachChiTietPhieuNhap.Location = new Point(12, 300);
            danhSachChiTietPhieuNhap.Name = "danhSachChiTietPhieuNhap";
            danhSachChiTietPhieuNhap.RowHeadersWidth = 62;
            danhSachChiTietPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachChiTietPhieuNhap.Size = new Size(1360, 306);
            danhSachChiTietPhieuNhap.TabIndex = 139;
            // 
            // ChiTietPhieuNhapGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 691);
            Controls.Add(lbTongTien);
            Controls.Add(button1);
            Controls.Add(btnThem);
            Controls.Add(panel1);
            Controls.Add(labelGiaSanPham);
            Controls.Add(groupBox1);
            Controls.Add(danhSachChiTietPhieuNhap);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChiTietPhieuNhapGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChiTietPhieuNhapGUI";
            Load += ChiTietPhieuNhapGUI_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietPhieuNhap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PrintPreviewDialog printPreviewDialog1;
        private Label lbTongTien;
        public Button button1;
        public Button btnThem;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewTextBoxColumn TienNhap;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn KichCo;
        private DataGridViewTextBoxColumn MauSac;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn MaPhieuNhap;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataGridViewTextBoxColumn MaChiTietSP;
        private Label label2;
        private Panel panel1;
        private Label labelGiaSanPham;
        private Label lbNhaCungCap;
        private Label lbNguoiNhap;
        private Label lbNgayNhap;
        private Label lbMaPhieu;
        private Label label3;
        private Label label5;
        private Label label1;
        private Label labelGiaNhap;
        private GroupBox groupBox1;
        private DataGridView danhSachChiTietPhieuNhap;
    }
}