namespace GUI
{
    partial class SanPhamGUI
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
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            danhSachSanPham = new DataGridView();
            MaSanPham = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            MaTheLoai = new DataGridViewTextBoxColumn();
            MaNhaCungCap = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            GiaNhap = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            Xoa = new DataGridViewImageColumn();
            Sua = new DataGridViewImageColumn();
            ChiTiet = new DataGridViewImageColumn();
            label2 = new Label();
            txtTimKiem = new TextBox();
            btnShowDialog = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachSanPham).BeginInit();
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
            panel1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(690, 33);
            label1.Name = "label1";
            label1.Size = new Size(168, 37);
            label1.TabIndex = 1;
            label1.Text = "SẢN PHẨM";
            // 
            // danhSachSanPham
            // 
            danhSachSanPham.AllowUserToAddRows = false;
            danhSachSanPham.AllowUserToOrderColumns = true;
            danhSachSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            danhSachSanPham.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachSanPham.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.Control;
            dataGridViewCellStyle16.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            danhSachSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            danhSachSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachSanPham.Columns.AddRange(new DataGridViewColumn[] { MaSanPham, TenSanPham, MaTheLoai, MaNhaCungCap, GiaBan, GiaNhap, SoLuongTon, Xoa, Sua, ChiTiet });
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = SystemColors.Window;
            dataGridViewCellStyle20.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle20.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle20.SelectionForeColor = Color.White;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            danhSachSanPham.DefaultCellStyle = dataGridViewCellStyle20;
            danhSachSanPham.GridColor = SystemColors.WindowText;
            danhSachSanPham.Location = new Point(0, 99);
            danhSachSanPham.Name = "danhSachSanPham";
            danhSachSanPham.ReadOnly = true;
            danhSachSanPham.RowHeadersWidth = 62;
            danhSachSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachSanPham.Size = new Size(1600, 660);
            danhSachSanPham.TabIndex = 19;
            danhSachSanPham.CellContentClick += danhSachSanPham_CellContentClick;
            // 
            // MaSanPham
            // 
            MaSanPham.DataPropertyName = "MaSanPham";
            MaSanPham.HeaderText = "Mã sản phẩm";
            MaSanPham.MinimumWidth = 8;
            MaSanPham.Name = "MaSanPham";
            MaSanPham.ReadOnly = true;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 8;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // MaTheLoai
            // 
            MaTheLoai.DataPropertyName = "MaTheLoai";
            MaTheLoai.HeaderText = "Thể loại";
            MaTheLoai.MinimumWidth = 8;
            MaTheLoai.Name = "MaTheLoai";
            MaTheLoai.ReadOnly = true;
            // 
            // MaNhaCungCap
            // 
            MaNhaCungCap.DataPropertyName = "MaNhaCungCap";
            MaNhaCungCap.HeaderText = "Nhà cung cấp";
            MaNhaCungCap.MinimumWidth = 8;
            MaNhaCungCap.Name = "MaNhaCungCap";
            MaNhaCungCap.ReadOnly = true;
            // 
            // GiaBan
            // 
            GiaBan.DataPropertyName = "GiaBan";
            GiaBan.HeaderText = "Giá bán";
            GiaBan.MinimumWidth = 8;
            GiaBan.Name = "GiaBan";
            GiaBan.ReadOnly = true;
            // 
            // GiaNhap
            // 
            GiaNhap.DataPropertyName = "GiaNhap";
            GiaNhap.HeaderText = "Giá nhập";
            GiaNhap.MinimumWidth = 8;
            GiaNhap.Name = "GiaNhap";
            GiaNhap.ReadOnly = true;
            // 
            // SoLuongTon
            // 
            SoLuongTon.DataPropertyName = "SoLuongTon";
            SoLuongTon.HeaderText = "Số lượng tồn";
            SoLuongTon.MinimumWidth = 8;
            SoLuongTon.Name = "SoLuongTon";
            SoLuongTon.ReadOnly = true;
            // 
            // Xoa
            // 
            Xoa.DataPropertyName = "Xoa";
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.NullValue = null;
            Xoa.DefaultCellStyle = dataGridViewCellStyle17;
            Xoa.HeaderText = "Xóa";
            Xoa.Image = Properties.Resources.Delete;
            Xoa.MinimumWidth = 8;
            Xoa.Name = "Xoa";
            Xoa.ReadOnly = true;
            // 
            // Sua
            // 
            Sua.DataPropertyName = "Sua";
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.NullValue = null;
            Sua.DefaultCellStyle = dataGridViewCellStyle18;
            Sua.HeaderText = "Sửa";
            Sua.Image = Properties.Resources.Edit;
            Sua.MinimumWidth = 8;
            Sua.Name = "Sua";
            Sua.ReadOnly = true;
            // 
            // ChiTiet
            // 
            ChiTiet.DataPropertyName = "ChiTiet";
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.NullValue = null;
            ChiTiet.DefaultCellStyle = dataGridViewCellStyle19;
            ChiTiet.HeaderText = "Chi tiết";
            ChiTiet.Image = Properties.Resources.Detail;
            ChiTiet.MinimumWidth = 8;
            ChiTiet.Name = "ChiTiet";
            ChiTiet.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(12, 784);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 25;
            label2.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimKiem.Location = new Point(133, 782);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(295, 39);
            txtTimKiem.TabIndex = 24;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnShowDialog
            // 
            btnShowDialog.BackColor = Color.MediumSeaGreen;
            btnShowDialog.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold);
            btnShowDialog.ForeColor = SystemColors.ButtonHighlight;
            btnShowDialog.Location = new Point(1398, 765);
            btnShowDialog.Name = "btnShowDialog";
            btnShowDialog.Size = new Size(190, 70);
            btnShowDialog.TabIndex = 23;
            btnShowDialog.Text = "Thêm";
            btnShowDialog.UseVisualStyleBackColor = false;
            btnShowDialog.Click += btnShowDialog_Click;
            // 
            // SanPhamGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(btnShowDialog);
            Controls.Add(danhSachSanPham);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SanPhamGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SanPhamGUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        public DataGridView danhSachSanPham;
        private Label label2;
        private TextBox txtTimKiem;
        public Button btnShowDialog;
        private DataGridViewTextBoxColumn MaSanPham;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn MaTheLoai;
        private DataGridViewTextBoxColumn MaNhaCungCap;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn GiaNhap;
        private DataGridViewTextBoxColumn SoLuongTon;
        private DataGridViewImageColumn Xoa;
        private DataGridViewImageColumn Sua;
        private DataGridViewImageColumn ChiTiet;
    }
}