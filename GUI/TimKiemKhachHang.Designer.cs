namespace GUI
{
    partial class TimKiemKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemKhachHang));
            txtSoDienThoai = new TextBox();
            txtTen = new TextBox();
            label2 = new Label();
            Tên = new Label();
            dgvKhachHang = new DataGridView();
            MaKhachHang = new DataGridViewTextBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            Chon = new DataGridViewImageColumn();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Segoe UI Variable Text", 10F);
            txtSoDienThoai.Location = new Point(663, 44);
            txtSoDienThoai.Margin = new Padding(4, 5, 4, 5);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(232, 34);
            txtSoDienThoai.TabIndex = 9;
            txtSoDienThoai.TextChanged += txtSoDienThoai_TextChanged;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI Variable Text", 10F);
            txtTen.Location = new Point(246, 44);
            txtTen.Margin = new Padding(4, 5, 4, 5);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(207, 34);
            txtTen.TabIndex = 8;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(527, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 27);
            label2.TabIndex = 11;
            label2.Text = "Số điện thoại";
            // 
            // Tên
            // 
            Tên.AutoSize = true;
            Tên.Font = new Font("Segoe UI Variable Text", 10F);
            Tên.ForeColor = Color.MediumSeaGreen;
            Tên.Location = new Point(167, 47);
            Tên.Margin = new Padding(4, 0, 4, 0);
            Tên.Name = "Tên";
            Tên.Size = new Size(71, 27);
            Tên.TabIndex = 10;
            Tên.Text = "Họ tên";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKhachHang.BackgroundColor = Color.White;
            dgvKhachHang.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKhachHang, TenKhachHang, SoDienThoai, Chon });
            dgvKhachHang.Location = new Point(12, 113);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.RowTemplate.Height = 24;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(1238, 521);
            dgvKhachHang.TabIndex = 12;
            dgvKhachHang.CellContentClick += dgvKhachHang_CellContentClick;
            // 
            // MaKhachHang
            // 
            MaKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaKhachHang.DataPropertyName = "MaKhachHang";
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            MaKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            MaKhachHang.HeaderText = "Mã Khách Hàng";
            MaKhachHang.MinimumWidth = 6;
            MaKhachHang.Name = "MaKhachHang";
            // 
            // TenKhachHang
            // 
            TenKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenKhachHang.DataPropertyName = "TenKhachHang";
            dataGridViewCellStyle4.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            TenKhachHang.DefaultCellStyle = dataGridViewCellStyle4;
            TenKhachHang.HeaderText = "Tên Khách Hàng";
            TenKhachHang.MinimumWidth = 6;
            TenKhachHang.Name = "TenKhachHang";
            // 
            // SoDienThoai
            // 
            SoDienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoDienThoai.DataPropertyName = "SoDienThoai";
            dataGridViewCellStyle5.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            SoDienThoai.DefaultCellStyle = dataGridViewCellStyle5;
            SoDienThoai.HeaderText = "Số Điện Thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // Chon
            // 
            Chon.DataPropertyName = "Chon";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = resources.GetObject("dataGridViewCellStyle6.NullValue");
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            Chon.DefaultCellStyle = dataGridViewCellStyle6;
            Chon.HeaderText = "Chọn";
            Chon.Image = Properties.Resources.Appoint;
            Chon.MinimumWidth = 8;
            Chon.Name = "Chon";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumSeaGreen;
            btnThem.Font = new Font("Segoe UI Variable Text Semibold", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(936, 37);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(127, 46);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // TimKiemKhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 646);
            Controls.Add(btnThem);
            Controls.Add(dgvKhachHang);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtTen);
            Controls.Add(label2);
            Controls.Add(Tên);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TimKiemKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TimKiemKhachHang";
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtSoDienThoai;
        public TextBox txtTen;
        private Label label2;
        private Label Tên;
        public DataGridView dgvKhachHang;
        public Button btnThem;
        private DataGridViewTextBoxColumn MaKhachHang;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewImageColumn Chon;
    }
}