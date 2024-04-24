namespace GUI
{
    partial class ChiTietSanPhamGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietSanPhamGUI));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            btnSua = new Button();
            btnThemChiTietSanPham = new Button();
            label7 = new Label();
            anhSanPham = new PictureBox();
            comboxKichCo = new ComboBox();
            label1 = new Label();
            comboxMauSac = new ComboBox();
            label2 = new Label();
            txtMaSanPham = new TextBox();
            label3 = new Label();
            txtTenSanPham = new TextBox();
            labelTenSanPham = new Label();
            danhSachChiTietSanPham = new DataGridView();
            MaChiTietSanPham = new DataGridViewTextBoxColumn();
            MaSanPham = new DataGridViewTextBoxColumn();
            MaMauSac = new DataGridViewTextBoxColumn();
            MaKichCo = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            Xoa = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)anhSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietSanPham).BeginInit();
            SuspendLayout();
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Orange;
            btnSua.Font = new Font("Segoe UI Variable Text Semibold", 10F, FontStyle.Bold);
            btnSua.ForeColor = SystemColors.Control;
            btnSua.Location = new Point(1132, 115);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(187, 63);
            btnSua.TabIndex = 97;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThemChiTietSanPham
            // 
            btnThemChiTietSanPham.BackColor = Color.MediumSeaGreen;
            btnThemChiTietSanPham.Font = new Font("Segoe UI Variable Text Semibold", 10F, FontStyle.Bold);
            btnThemChiTietSanPham.ForeColor = SystemColors.Control;
            btnThemChiTietSanPham.Location = new Point(1132, 36);
            btnThemChiTietSanPham.Name = "btnThemChiTietSanPham";
            btnThemChiTietSanPham.Size = new Size(187, 63);
            btnThemChiTietSanPham.TabIndex = 96;
            btnThemChiTietSanPham.Text = "Thêm chi tiết";
            btnThemChiTietSanPham.UseVisualStyleBackColor = false;
            btnThemChiTietSanPham.Click += btnThemChiTietSanPham_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Variable Display", 10F);
            label7.ForeColor = Color.MediumSeaGreen;
            label7.Location = new Point(869, 23);
            label7.Name = "label7";
            label7.Size = new Size(100, 27);
            label7.TabIndex = 95;
            label7.Text = "Chọn Ảnh";
            // 
            // anhSanPham
            // 
            anhSanPham.Image = (Image)resources.GetObject("anhSanPham.Image");
            anhSanPham.Location = new Point(869, 51);
            anhSanPham.Name = "anhSanPham";
            anhSanPham.Size = new Size(122, 127);
            anhSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            anhSanPham.TabIndex = 94;
            anhSanPham.TabStop = false;
            anhSanPham.Click += anhSanPham_Click;
            // 
            // comboxKichCo
            // 
            comboxKichCo.Font = new Font("Segoe UI Variable Display", 10F);
            comboxKichCo.FormattingEnabled = true;
            comboxKichCo.Location = new Point(440, 130);
            comboxKichCo.Name = "comboxKichCo";
            comboxKichCo.Size = new Size(302, 35);
            comboxKichCo.TabIndex = 93;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 10F);
            label1.ForeColor = Color.MediumSeaGreen;
            label1.Location = new Point(440, 102);
            label1.Name = "label1";
            label1.Size = new Size(77, 27);
            label1.TabIndex = 92;
            label1.Text = "Kích cở";
            // 
            // comboxMauSac
            // 
            comboxMauSac.Font = new Font("Segoe UI Variable Display", 10F);
            comboxMauSac.FormattingEnabled = true;
            comboxMauSac.Location = new Point(440, 51);
            comboxMauSac.Name = "comboxMauSac";
            comboxMauSac.Size = new Size(302, 35);
            comboxMauSac.TabIndex = 91;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 10F);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(440, 23);
            label2.Name = "label2";
            label2.Size = new Size(85, 27);
            label2.TabIndex = 90;
            label2.Text = "Màu sắc";
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Font = new Font("Segoe UI Variable Display", 10F);
            txtMaSanPham.Location = new Point(26, 51);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.ReadOnly = true;
            txtMaSanPham.Size = new Size(302, 34);
            txtMaSanPham.TabIndex = 89;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 10F);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(26, 21);
            label3.Name = "label3";
            label3.Size = new Size(130, 27);
            label3.TabIndex = 88;
            label3.Text = "Mã sản phẩm";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Font = new Font("Segoe UI Variable Display", 10F);
            txtTenSanPham.Location = new Point(26, 130);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.ReadOnly = true;
            txtTenSanPham.Size = new Size(302, 34);
            txtTenSanPham.TabIndex = 87;
            // 
            // labelTenSanPham
            // 
            labelTenSanPham.AutoSize = true;
            labelTenSanPham.Font = new Font("Segoe UI Variable Display", 10F);
            labelTenSanPham.ForeColor = Color.MediumSeaGreen;
            labelTenSanPham.Location = new Point(26, 100);
            labelTenSanPham.Name = "labelTenSanPham";
            labelTenSanPham.Size = new Size(131, 27);
            labelTenSanPham.TabIndex = 86;
            labelTenSanPham.Text = "Tên sản phẩm";
            // 
            // danhSachChiTietSanPham
            // 
            danhSachChiTietSanPham.AllowUserToAddRows = false;
            danhSachChiTietSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            danhSachChiTietSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachChiTietSanPham.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachChiTietSanPham.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            danhSachChiTietSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            danhSachChiTietSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachChiTietSanPham.Columns.AddRange(new DataGridViewColumn[] { MaChiTietSanPham, MaSanPham, MaMauSac, MaKichCo, HinhAnh, SoLuongTon, Xoa });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            danhSachChiTietSanPham.DefaultCellStyle = dataGridViewCellStyle9;
            danhSachChiTietSanPham.Location = new Point(12, 193);
            danhSachChiTietSanPham.Name = "danhSachChiTietSanPham";
            danhSachChiTietSanPham.RowHeadersWidth = 62;
            danhSachChiTietSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachChiTietSanPham.Size = new Size(1322, 565);
            danhSachChiTietSanPham.TabIndex = 85;
            danhSachChiTietSanPham.CellContentClick += danhSachChiTietSanPham_CellContentClick;
            // 
            // MaChiTietSanPham
            // 
            MaChiTietSanPham.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaChiTietSanPham.DataPropertyName = "MaChiTietSanPham";
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            MaChiTietSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            MaChiTietSanPham.HeaderText = "Mã chi tiết";
            MaChiTietSanPham.MinimumWidth = 8;
            MaChiTietSanPham.Name = "MaChiTietSanPham";
            // 
            // MaSanPham
            // 
            MaSanPham.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaSanPham.DataPropertyName = "MaSanPham";
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            MaSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            MaSanPham.HeaderText = "Sản phẩm";
            MaSanPham.MinimumWidth = 8;
            MaSanPham.Name = "MaSanPham";
            // 
            // MaMauSac
            // 
            MaMauSac.DataPropertyName = "MaMauSac";
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            MaMauSac.DefaultCellStyle = dataGridViewCellStyle4;
            MaMauSac.HeaderText = "Màu sắc";
            MaMauSac.MinimumWidth = 8;
            MaMauSac.Name = "MaMauSac";
            MaMauSac.Width = 119;
            // 
            // MaKichCo
            // 
            MaKichCo.DataPropertyName = "MaKichCo";
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            MaKichCo.DefaultCellStyle = dataGridViewCellStyle5;
            MaKichCo.HeaderText = "Kích cỡ";
            MaKichCo.MinimumWidth = 8;
            MaKichCo.Name = "MaKichCo";
            MaKichCo.Width = 111;
            // 
            // HinhAnh
            // 
            HinhAnh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HinhAnh.DataPropertyName = "HinhAnh";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            HinhAnh.DefaultCellStyle = dataGridViewCellStyle6;
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            HinhAnh.MinimumWidth = 8;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.Resizable = DataGridViewTriState.True;
            HinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // SoLuongTon
            // 
            SoLuongTon.DataPropertyName = "SoLuongTon";
            dataGridViewCellStyle7.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            SoLuongTon.DefaultCellStyle = dataGridViewCellStyle7;
            SoLuongTon.HeaderText = "Số lượng tồn";
            SoLuongTon.MinimumWidth = 8;
            SoLuongTon.Name = "SoLuongTon";
            SoLuongTon.Width = 163;
            // 
            // Xoa
            // 
            Xoa.DataPropertyName = "Xóa";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            Xoa.DefaultCellStyle = dataGridViewCellStyle8;
            Xoa.HeaderText = "Xóa";
            Xoa.Image = (Image)resources.GetObject("Xoa.Image");
            Xoa.MinimumWidth = 8;
            Xoa.Name = "Xoa";
            Xoa.Resizable = DataGridViewTriState.True;
            Xoa.SortMode = DataGridViewColumnSortMode.Automatic;
            Xoa.Width = 82;
            // 
            // ChiTietSanPhamGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 779);
            Controls.Add(btnSua);
            Controls.Add(btnThemChiTietSanPham);
            Controls.Add(label7);
            Controls.Add(anhSanPham);
            Controls.Add(comboxKichCo);
            Controls.Add(label1);
            Controls.Add(comboxMauSac);
            Controls.Add(label2);
            Controls.Add(txtMaSanPham);
            Controls.Add(label3);
            Controls.Add(txtTenSanPham);
            Controls.Add(labelTenSanPham);
            Controls.Add(danhSachChiTietSanPham);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChiTietSanPhamGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChiTietSanPhamGUI";
            ((System.ComponentModel.ISupportInitialize)anhSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnSua;
        public Button btnThemChiTietSanPham;
        private Label label7;
        public PictureBox anhSanPham;
        public ComboBox comboxKichCo;
        private Label label1;
        public ComboBox comboxMauSac;
        private Label label2;
        public TextBox txtMaSanPham;
        private Label label3;
        public TextBox txtTenSanPham;
        private Label labelTenSanPham;
        public DataGridView danhSachChiTietSanPham;
        private DataGridViewTextBoxColumn MaChiTietSanPham;
        private DataGridViewTextBoxColumn MaSanPham;
        private DataGridViewTextBoxColumn MaMauSac;
        private DataGridViewTextBoxColumn MaKichCo;
        private DataGridViewImageColumn HinhAnh;
        private DataGridViewTextBoxColumn SoLuongTon;
        private DataGridViewImageColumn Xoa;
    }
}