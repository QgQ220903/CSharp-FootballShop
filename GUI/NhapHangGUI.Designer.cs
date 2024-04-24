namespace GUI
{
    partial class NhapHangGUI
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapHangGUI));
            danhSachPhieuNhap = new DataGridView();
            MaPhieuNhap = new DataGridViewTextBoxColumn();
            MaNhaCungCap = new DataGridViewTextBoxColumn();
            MaNhanVien = new DataGridViewTextBoxColumn();
            NgayNhap = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            ChiTiet = new DataGridViewImageColumn();
            panel1 = new Panel();
            label1 = new Label();
            btnShowDialog = new Button();
            comboBoxNhanVien = new ComboBox();
            label2 = new Label();
            btnTimKiem = new Button();
            dateKetThuc = new DateTimePicker();
            dateBatDau = new DateTimePicker();
            lbKetThuc = new Label();
            lbBatDau = new Label();
            btnLamMoi = new Button();
            ((System.ComponentModel.ISupportInitialize)danhSachPhieuNhap).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // danhSachPhieuNhap
            // 
            danhSachPhieuNhap.AllowUserToAddRows = false;
            danhSachPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachPhieuNhap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachPhieuNhap.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachPhieuNhap.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            danhSachPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            danhSachPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { MaPhieuNhap, MaNhaCungCap, MaNhanVien, NgayNhap, TongTien, ChiTiet });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            danhSachPhieuNhap.DefaultCellStyle = dataGridViewCellStyle8;
            danhSachPhieuNhap.Location = new Point(0, 96);
            danhSachPhieuNhap.Name = "danhSachPhieuNhap";
            danhSachPhieuNhap.RowHeadersWidth = 62;
            danhSachPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachPhieuNhap.Size = new Size(1600, 660);
            danhSachPhieuNhap.TabIndex = 12;
            danhSachPhieuNhap.CellContentClick += danhSachPhieuNhap_CellContentClick;
            // 
            // MaPhieuNhap
            // 
            MaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            MaPhieuNhap.DefaultCellStyle = dataGridViewCellStyle2;
            MaPhieuNhap.HeaderText = "Mã phiếu nhập";
            MaPhieuNhap.MinimumWidth = 8;
            MaPhieuNhap.Name = "MaPhieuNhap";
            // 
            // MaNhaCungCap
            // 
            MaNhaCungCap.DataPropertyName = "MaNhaCungCap";
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            MaNhaCungCap.DefaultCellStyle = dataGridViewCellStyle3;
            MaNhaCungCap.HeaderText = "Nhà cung cấp";
            MaNhaCungCap.MinimumWidth = 8;
            MaNhaCungCap.Name = "MaNhaCungCap";
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            MaNhanVien.DefaultCellStyle = dataGridViewCellStyle4;
            MaNhanVien.HeaderText = "Nhân viên";
            MaNhanVien.MinimumWidth = 8;
            MaNhanVien.Name = "MaNhanVien";
            // 
            // NgayNhap
            // 
            NgayNhap.DataPropertyName = "NgayNhap";
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            NgayNhap.DefaultCellStyle = dataGridViewCellStyle5;
            NgayNhap.HeaderText = "Ngày nhập";
            NgayNhap.MinimumWidth = 8;
            NgayNhap.Name = "NgayNhap";
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            TongTien.DefaultCellStyle = dataGridViewCellStyle6;
            TongTien.HeaderText = "Tổng tiền";
            TongTien.MinimumWidth = 8;
            TongTien.Name = "TongTien";
            // 
            // ChiTiet
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = resources.GetObject("dataGridViewCellStyle7.NullValue");
            dataGridViewCellStyle7.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            ChiTiet.DefaultCellStyle = dataGridViewCellStyle7;
            ChiTiet.HeaderText = "Chi tiết";
            ChiTiet.Image = Properties.Resources.Detail;
            ChiTiet.MinimumWidth = 8;
            ChiTiet.Name = "ChiTiet";
            ChiTiet.Resizable = DataGridViewTriState.True;
            ChiTiet.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 100);
            panel1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(691, 32);
            label1.Name = "label1";
            label1.Size = new Size(187, 37);
            label1.TabIndex = 1;
            label1.Text = "PHIẾU NHẬP";
            // 
            // btnShowDialog
            // 
            btnShowDialog.BackColor = Color.MediumSeaGreen;
            btnShowDialog.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold);
            btnShowDialog.ForeColor = SystemColors.ButtonHighlight;
            btnShowDialog.Location = new Point(1399, 776);
            btnShowDialog.Name = "btnShowDialog";
            btnShowDialog.Size = new Size(189, 65);
            btnShowDialog.TabIndex = 27;
            btnShowDialog.Text = "Thêm";
            btnShowDialog.UseVisualStyleBackColor = false;
            btnShowDialog.Click += btnShowDialog_Click;
            // 
            // comboBoxNhanVien
            // 
            comboBoxNhanVien.Font = new Font("Segoe UI Variable Text", 10F);
            comboBoxNhanVien.FormattingEnabled = true;
            comboBoxNhanVien.Location = new Point(691, 793);
            comboBoxNhanVien.Name = "comboBoxNhanVien";
            comboBoxNhanVien.Size = new Size(326, 35);
            comboBoxNhanVien.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(691, 763);
            label2.Name = "label2";
            label2.Size = new Size(102, 27);
            label2.TabIndex = 42;
            label2.Text = "Nhân Viên";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.MediumSeaGreen;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(1039, 791);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(130, 37);
            btnTimKiem.TabIndex = 41;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dateKetThuc
            // 
            dateKetThuc.CalendarFont = new Font("Segoe UI", 10F);
            dateKetThuc.Font = new Font("Segoe UI Variable Display", 10F);
            dateKetThuc.Format = DateTimePickerFormat.Short;
            dateKetThuc.Location = new Point(365, 794);
            dateKetThuc.Name = "dateKetThuc";
            dateKetThuc.Size = new Size(300, 34);
            dateKetThuc.TabIndex = 40;
            // 
            // dateBatDau
            // 
            dateBatDau.CalendarFont = new Font("Segoe UI", 10F);
            dateBatDau.Font = new Font("Segoe UI Variable Display", 10F);
            dateBatDau.Format = DateTimePickerFormat.Short;
            dateBatDau.Location = new Point(47, 794);
            dateBatDau.Name = "dateBatDau";
            dateBatDau.Size = new Size(300, 34);
            dateBatDau.TabIndex = 39;
            // 
            // lbKetThuc
            // 
            lbKetThuc.AutoSize = true;
            lbKetThuc.Font = new Font("Segoe UI Variable Display", 10F);
            lbKetThuc.ForeColor = Color.MediumSeaGreen;
            lbKetThuc.Location = new Point(365, 764);
            lbKetThuc.Name = "lbKetThuc";
            lbKetThuc.Size = new Size(88, 27);
            lbKetThuc.TabIndex = 38;
            lbKetThuc.Text = "Kết Thúc";
            // 
            // lbBatDau
            // 
            lbBatDau.AutoSize = true;
            lbBatDau.Font = new Font("Segoe UI Variable Display", 10F);
            lbBatDau.ForeColor = Color.MediumSeaGreen;
            lbBatDau.Location = new Point(47, 764);
            lbBatDau.Name = "lbBatDau";
            lbBatDau.Size = new Size(85, 27);
            lbBatDau.TabIndex = 37;
            lbBatDau.Text = " Bắt Đầu";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.MediumSeaGreen;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(1186, 791);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(130, 37);
            btnLamMoi.TabIndex = 44;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // NhapHangGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(btnLamMoi);
            Controls.Add(comboBoxNhanVien);
            Controls.Add(label2);
            Controls.Add(btnTimKiem);
            Controls.Add(dateKetThuc);
            Controls.Add(dateBatDau);
            Controls.Add(lbKetThuc);
            Controls.Add(lbBatDau);
            Controls.Add(btnShowDialog);
            Controls.Add(panel1);
            Controls.Add(danhSachPhieuNhap);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "NhapHangGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhapHangGUI";
            ((System.ComponentModel.ISupportInitialize)danhSachPhieuNhap).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView danhSachPhieuNhap;
        private Panel panel1;
        private Label label1;
        public Button btnShowDialog;
        private DataGridViewTextBoxColumn MaPhieuNhap;
        private DataGridViewTextBoxColumn MaNhaCungCap;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn NgayNhap;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewImageColumn ChiTiet;
        public ComboBox comboBoxNhanVien;
        private Label label2;
        private Button btnTimKiem;
        public DateTimePicker dateKetThuc;
        public DateTimePicker dateBatDau;
        public Label lbKetThuc;
        public Label lbBatDau;
        private Button btnLamMoi;
    }
}