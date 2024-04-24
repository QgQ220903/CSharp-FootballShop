namespace GUI
{
    partial class NhomQuyenModule
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
            danhSachChucNang = new DataGridView();
            TenChucNang = new DataGridViewTextBoxColumn();
            Thêm = new DataGridViewCheckBoxColumn();
            Sửa = new DataGridViewCheckBoxColumn();
            Xóa = new DataGridViewCheckBoxColumn();
            Xem = new DataGridViewCheckBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            txtTenNhomQuyen = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)danhSachChucNang).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // danhSachChucNang
            // 
            danhSachChucNang.AllowUserToAddRows = false;
            danhSachChucNang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachChucNang.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachChucNang.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            danhSachChucNang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            danhSachChucNang.ColumnHeadersHeight = 34;
            danhSachChucNang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            danhSachChucNang.Columns.AddRange(new DataGridViewColumn[] { TenChucNang, Thêm, Sửa, Xóa, Xem });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            danhSachChucNang.DefaultCellStyle = dataGridViewCellStyle2;
            danhSachChucNang.Location = new Point(12, 198);
            danhSachChucNang.Name = "danhSachChucNang";
            danhSachChucNang.RowHeadersWidth = 62;
            danhSachChucNang.SelectionMode = DataGridViewSelectionMode.CellSelect;
            danhSachChucNang.Size = new Size(1329, 512);
            danhSachChucNang.TabIndex = 6;
            danhSachChucNang.CellContentClick += danhSachChucNang_CellContentClick;
            // 
            // TenChucNang
            // 
            TenChucNang.DataPropertyName = "TenChucNang";
            TenChucNang.HeaderText = "Tên Chức Năng";
            TenChucNang.MinimumWidth = 8;
            TenChucNang.Name = "TenChucNang";
            // 
            // Thêm
            // 
            Thêm.HeaderText = "Thêm";
            Thêm.MinimumWidth = 8;
            Thêm.Name = "Thêm";
            Thêm.Resizable = DataGridViewTriState.True;
            Thêm.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Sửa
            // 
            Sửa.HeaderText = "Sửa";
            Sửa.MinimumWidth = 8;
            Sửa.Name = "Sửa";
            // 
            // Xóa
            // 
            Xóa.HeaderText = "Xóa";
            Xóa.MinimumWidth = 8;
            Xóa.Name = "Xóa";
            Xóa.Resizable = DataGridViewTriState.True;
            Xóa.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Xem
            // 
            Xem.HeaderText = "Xem";
            Xem.MinimumWidth = 8;
            Xem.Name = "Xem";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnThem);
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Controls.Add(btnThoat);
            flowLayoutPanel1.Location = new Point(967, 716);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(374, 68);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumSeaGreen;
            btnThem.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold);
            btnThem.ForeColor = SystemColors.ButtonHighlight;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(180, 60);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Orange;
            btnSua.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold);
            btnSua.ForeColor = SystemColors.ButtonHighlight;
            btnSua.Location = new Point(189, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(180, 60);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(3, 69);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(180, 60);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtTenNhomQuyen
            // 
            txtTenNhomQuyen.Font = new Font("Segoe UI Variable Display", 10F);
            txtTenNhomQuyen.Location = new Point(568, 144);
            txtTenNhomQuyen.Name = "txtTenNhomQuyen";
            txtTenNhomQuyen.Size = new Size(326, 34);
            txtTenNhomQuyen.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(399, 147);
            label2.Name = "label2";
            label2.Size = new Size(163, 27);
            label2.TabIndex = 7;
            label2.Text = "Tên Nhóm Quyền";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1353, 100);
            panel1.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(554, 35);
            label1.Name = "label1";
            label1.Size = new Size(211, 37);
            label1.TabIndex = 1;
            label1.Text = "NHÓM QUYỀN";
            // 
            // NhomQuyenModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 799);
            Controls.Add(panel1);
            Controls.Add(danhSachChucNang);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtTenNhomQuyen);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "NhomQuyenModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhomQuyenModule";
            ((System.ComponentModel.ISupportInitialize)danhSachChucNang).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView danhSachChucNang;
        private DataGridViewTextBoxColumn TenChucNang;
        private DataGridViewCheckBoxColumn Thêm;
        private DataGridViewCheckBoxColumn Sửa;
        private DataGridViewCheckBoxColumn Xóa;
        private DataGridViewCheckBoxColumn Xem;
        private FlowLayoutPanel flowLayoutPanel1;
        public Button btnThem;
        public Button btnSua;
        public Button btnThoat;
        public TextBox txtTenNhomQuyen;
        private Label label2;
        private Panel panel1;
        private Label label1;
    }
}