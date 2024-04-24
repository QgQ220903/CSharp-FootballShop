namespace GUI
{
    partial class HoaDonGUI
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
            panel1 = new Panel();
            label1 = new Label();
            danhSachHoaDon = new DataGridView();
            MaHoaDon = new DataGridViewTextBoxColumn();
            KhachHang = new DataGridViewTextBoxColumn();
            NhanVien = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            ChiTiet = new DataGridViewImageColumn();
            dateKetThuc = new DateTimePicker();
            dateBatDau = new DateTimePicker();
            lbKetThuc = new Label();
            lbBatDau = new Label();
            btnTimKiem = new Button();
            btnLamMoi = new Button();
            comboBoxNhanVien = new ComboBox();
            label2 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachHoaDon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 100);
            panel1.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(717, 33);
            label1.Name = "label1";
            label1.Size = new Size(151, 37);
            label1.TabIndex = 1;
            label1.Text = "HÓA ĐƠN";
            // 
            // danhSachHoaDon
            // 
            danhSachHoaDon.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            danhSachHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            danhSachHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachHoaDon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachHoaDon.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            danhSachHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            danhSachHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachHoaDon.Columns.AddRange(new DataGridViewColumn[] { MaHoaDon, KhachHang, NhanVien, NgayLap, TongTien, ChiTiet });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            danhSachHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            danhSachHoaDon.Location = new Point(0, 97);
            danhSachHoaDon.Name = "danhSachHoaDon";
            danhSachHoaDon.ReadOnly = true;
            danhSachHoaDon.RowHeadersWidth = 62;
            danhSachHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachHoaDon.Size = new Size(1600, 660);
            danhSachHoaDon.TabIndex = 28;
            danhSachHoaDon.CellContentClick += danhSachHoaDon_CellContentClick;
            // 
            // MaHoaDon
            // 
            MaHoaDon.HeaderText = "Mã Hóa Đơn";
            MaHoaDon.MinimumWidth = 8;
            MaHoaDon.Name = "MaHoaDon";
            MaHoaDon.ReadOnly = true;
            // 
            // KhachHang
            // 
            KhachHang.HeaderText = "Khách Hàng";
            KhachHang.MinimumWidth = 8;
            KhachHang.Name = "KhachHang";
            KhachHang.ReadOnly = true;
            // 
            // NhanVien
            // 
            NhanVien.HeaderText = "Nhân Viên";
            NhanVien.MinimumWidth = 8;
            NhanVien.Name = "NhanVien";
            NhanVien.ReadOnly = true;
            // 
            // NgayLap
            // 
            NgayLap.HeaderText = "Ngày Lập";
            NgayLap.MinimumWidth = 8;
            NgayLap.Name = "NgayLap";
            NgayLap.ReadOnly = true;
            // 
            // TongTien
            // 
            TongTien.HeaderText = "Tổng Tiền";
            TongTien.MinimumWidth = 8;
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            // 
            // ChiTiet
            // 
            ChiTiet.DataPropertyName = "ChiTiet";
            ChiTiet.HeaderText = "Chi Tiết";
            ChiTiet.Image = Properties.Resources.Detail;
            ChiTiet.MinimumWidth = 8;
            ChiTiet.Name = "ChiTiet";
            ChiTiet.ReadOnly = true;
            ChiTiet.Resizable = DataGridViewTriState.True;
            ChiTiet.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dateKetThuc
            // 
            dateKetThuc.CalendarFont = new Font("Segoe UI", 10F);
            dateKetThuc.Font = new Font("Segoe UI Variable Display", 10F);
            dateKetThuc.Format = DateTimePickerFormat.Short;
            dateKetThuc.Location = new Point(348, 795);
            dateKetThuc.Name = "dateKetThuc";
            dateKetThuc.Size = new Size(300, 34);
            dateKetThuc.TabIndex = 32;
            // 
            // dateBatDau
            // 
            dateBatDau.CalendarFont = new Font("Segoe UI", 10F);
            dateBatDau.Font = new Font("Segoe UI Variable Display", 10F);
            dateBatDau.Format = DateTimePickerFormat.Short;
            dateBatDau.Location = new Point(30, 795);
            dateBatDau.Name = "dateBatDau";
            dateBatDau.Size = new Size(300, 34);
            dateBatDau.TabIndex = 31;
            // 
            // lbKetThuc
            // 
            lbKetThuc.AutoSize = true;
            lbKetThuc.Font = new Font("Segoe UI Variable Display", 10F);
            lbKetThuc.ForeColor = Color.MediumSeaGreen;
            lbKetThuc.Location = new Point(348, 765);
            lbKetThuc.Name = "lbKetThuc";
            lbKetThuc.Size = new Size(88, 27);
            lbKetThuc.TabIndex = 30;
            lbKetThuc.Text = "Kết Thúc";
            // 
            // lbBatDau
            // 
            lbBatDau.AutoSize = true;
            lbBatDau.Font = new Font("Segoe UI Variable Display", 10F);
            lbBatDau.ForeColor = Color.MediumSeaGreen;
            lbBatDau.Location = new Point(30, 765);
            lbBatDau.Name = "lbBatDau";
            lbBatDau.Size = new Size(85, 27);
            lbBatDau.TabIndex = 29;
            lbBatDau.Text = " Bắt Đầu";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.MediumSeaGreen;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(1025, 796);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(130, 37);
            btnTimKiem.TabIndex = 33;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.MediumSeaGreen;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(1171, 797);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(125, 35);
            btnLamMoi.TabIndex = 34;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // comboBoxNhanVien
            // 
            comboBoxNhanVien.Font = new Font("Segoe UI Variable Text", 10F);
            comboBoxNhanVien.FormattingEnabled = true;
            comboBoxNhanVien.Location = new Point(674, 798);
            comboBoxNhanVien.Name = "comboBoxNhanVien";
            comboBoxNhanVien.Size = new Size(326, 35);
            comboBoxNhanVien.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(674, 768);
            label2.Name = "label2";
            label2.Size = new Size(102, 27);
            label2.TabIndex = 35;
            label2.Text = "Nhân Viên";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // HoaDonGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(comboBoxNhanVien);
            Controls.Add(label2);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTimKiem);
            Controls.Add(dateKetThuc);
            Controls.Add(dateBatDau);
            Controls.Add(lbKetThuc);
            Controls.Add(lbBatDau);
            Controls.Add(danhSachHoaDon);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HoaDonGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HoaDonGUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView danhSachHoaDon;
        public DateTimePicker dateKetThuc;
        public DateTimePicker dateBatDau;
        public Label lbKetThuc;
        public Label lbBatDau;
        private Button btnTimKiem;
        private DataGridViewTextBoxColumn MaHoaDon;
        private DataGridViewTextBoxColumn KhachHang;
        private DataGridViewTextBoxColumn NhanVien;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewImageColumn ChiTiet;
        private Button btnLamMoi;
        public ComboBox comboBoxNhanVien;
        private Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
    }
}