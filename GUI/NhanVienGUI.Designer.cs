namespace GUI
{
    partial class NhanVienGUI
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            danhSachNhanVien = new DataGridView();
            MaNhanVien = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            Tuoi = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            Xoa = new DataGridViewImageColumn();
            Sua = new DataGridViewImageColumn();
            label2 = new Label();
            txtTimKiem = new TextBox();
            btnShowDialog = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachNhanVien).BeginInit();
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
            panel1.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(691, 32);
            label1.Name = "label1";
            label1.Size = new Size(175, 37);
            label1.TabIndex = 1;
            label1.Text = "NHÂN VIÊN";
            // 
            // danhSachNhanVien
            // 
            danhSachNhanVien.AllowUserToAddRows = false;
            danhSachNhanVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            danhSachNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            danhSachNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachNhanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachNhanVien.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachNhanVien.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            danhSachNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            danhSachNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachNhanVien.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, TenNhanVien, Tuoi, SoDienThoai, HinhAnh, Xoa, Sua });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            danhSachNhanVien.DefaultCellStyle = dataGridViewCellStyle9;
            danhSachNhanVien.Location = new Point(0, 96);
            danhSachNhanVien.Name = "danhSachNhanVien";
            danhSachNhanVien.ReadOnly = true;
            danhSachNhanVien.RowHeadersWidth = 62;
            danhSachNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachNhanVien.Size = new Size(1600, 660);
            danhSachNhanVien.TabIndex = 26;
            danhSachNhanVien.CellContentClick += danhSachNhanVien_CellContentClick;
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Mã Nhân Viên";
            MaNhanVien.MinimumWidth = 8;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Tên Nhân Viên";
            TenNhanVien.MinimumWidth = 8;
            TenNhanVien.Name = "TenNhanVien";
            TenNhanVien.ReadOnly = true;
            // 
            // Tuoi
            // 
            Tuoi.DataPropertyName = "Tuoi";
            Tuoi.HeaderText = "Tuổi";
            Tuoi.MinimumWidth = 8;
            Tuoi.Name = "Tuoi";
            Tuoi.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số Điện Thoại";
            SoDienThoai.MinimumWidth = 8;
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.ReadOnly = true;
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình Ảnh";
            HinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            HinhAnh.MinimumWidth = 8;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.ReadOnly = true;
            HinhAnh.Resizable = DataGridViewTriState.True;
            HinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Xoa
            // 
            Xoa.DataPropertyName = "Xoa";
            Xoa.HeaderText = "Xóa";
            Xoa.Image = Properties.Resources.Delete;
            Xoa.MinimumWidth = 8;
            Xoa.Name = "Xoa";
            Xoa.ReadOnly = true;
            Xoa.Resizable = DataGridViewTriState.True;
            Xoa.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Sua
            // 
            Sua.DataPropertyName = "Sua";
            Sua.HeaderText = "Sửa";
            Sua.Image = Properties.Resources.Edit;
            Sua.MinimumWidth = 8;
            Sua.Name = "Sua";
            Sua.ReadOnly = true;
            Sua.Resizable = DataGridViewTriState.True;
            Sua.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(12, 781);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 30;
            label2.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimKiem.Location = new Point(133, 779);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(295, 39);
            txtTimKiem.TabIndex = 29;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnShowDialog
            // 
            btnShowDialog.BackColor = Color.MediumSeaGreen;
            btnShowDialog.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold);
            btnShowDialog.ForeColor = SystemColors.ButtonHighlight;
            btnShowDialog.Location = new Point(1398, 762);
            btnShowDialog.Name = "btnShowDialog";
            btnShowDialog.Size = new Size(190, 70);
            btnShowDialog.TabIndex = 28;
            btnShowDialog.Text = "Thêm";
            btnShowDialog.UseVisualStyleBackColor = false;
            btnShowDialog.Click += btnShowDialog_Click;
            // 
            // NhanVienGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(btnShowDialog);
            Controls.Add(danhSachNhanVien);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NhanVienGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhanVienGUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        public DataGridView danhSachNhanVien;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn Tuoi;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewImageColumn HinhAnh;
        private DataGridViewImageColumn Xoa;
        private DataGridViewImageColumn Sua;
        private Label label2;
        private TextBox txtTimKiem;
        public Button btnShowDialog;
    }
}