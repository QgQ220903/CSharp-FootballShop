namespace GUI
{
    partial class SanPhamModule
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            comboxNhaCungCap = new ComboBox();
            lableNhaCungCap = new Label();
            comboxTheLoai = new ComboBox();
            labelTheLoai = new Label();
            txtGiaNhap = new TextBox();
            labelGiaNhap = new Label();
            txtTenSanPham = new TextBox();
            labelTenSanPham = new Label();
            panel1 = new Panel();
            label6 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnThem);
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Controls.Add(btnThoat);
            flowLayoutPanel1.Location = new Point(221, 349);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(390, 72);
            flowLayoutPanel1.TabIndex = 79;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumSeaGreen;
            btnThem.Font = new Font("Segoe UI Variable Text Semibold", 10F, FontStyle.Bold);
            btnThem.ForeColor = SystemColors.Control;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(187, 63);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Orange;
            btnSua.Font = new Font("Segoe UI Variable Text Semibold", 10F, FontStyle.Bold);
            btnSua.ForeColor = SystemColors.Control;
            btnSua.Location = new Point(196, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(187, 63);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Font = new Font("Segoe UI Variable Text Semibold", 10F, FontStyle.Bold);
            btnThoat.ForeColor = SystemColors.Control;
            btnThoat.Location = new Point(3, 72);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(187, 63);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // comboxNhaCungCap
            // 
            comboxNhaCungCap.Font = new Font("Segoe UI Variable Display", 10F);
            comboxNhaCungCap.FormattingEnabled = true;
            comboxNhaCungCap.Location = new Point(93, 284);
            comboxNhaCungCap.Name = "comboxNhaCungCap";
            comboxNhaCungCap.Size = new Size(302, 35);
            comboxNhaCungCap.TabIndex = 78;
            // 
            // lableNhaCungCap
            // 
            lableNhaCungCap.AutoSize = true;
            lableNhaCungCap.Font = new Font("Segoe UI Variable Display", 10F);
            lableNhaCungCap.ForeColor = Color.MediumSeaGreen;
            lableNhaCungCap.Location = new Point(93, 249);
            lableNhaCungCap.Name = "lableNhaCungCap";
            lableNhaCungCap.Size = new Size(134, 27);
            lableNhaCungCap.TabIndex = 77;
            lableNhaCungCap.Text = "Nhà cung cấp";
            // 
            // comboxTheLoai
            // 
            comboxTheLoai.Font = new Font("Segoe UI Variable Display", 10F);
            comboxTheLoai.FormattingEnabled = true;
            comboxTheLoai.Location = new Point(428, 187);
            comboxTheLoai.Name = "comboxTheLoai";
            comboxTheLoai.Size = new Size(302, 35);
            comboxTheLoai.TabIndex = 76;
            // 
            // labelTheLoai
            // 
            labelTheLoai.AutoSize = true;
            labelTheLoai.Font = new Font("Segoe UI Variable Display", 10F);
            labelTheLoai.ForeColor = Color.MediumSeaGreen;
            labelTheLoai.Location = new Point(428, 157);
            labelTheLoai.Name = "labelTheLoai";
            labelTheLoai.Size = new Size(80, 27);
            labelTheLoai.TabIndex = 75;
            labelTheLoai.Text = "Thể loại";
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Font = new Font("Segoe UI Variable Display", 10F);
            txtGiaNhap.Location = new Point(428, 285);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(302, 34);
            txtGiaNhap.TabIndex = 74;
            // 
            // labelGiaNhap
            // 
            labelGiaNhap.AutoSize = true;
            labelGiaNhap.Font = new Font("Segoe UI Variable Display", 10F);
            labelGiaNhap.ForeColor = Color.MediumSeaGreen;
            labelGiaNhap.Location = new Point(428, 255);
            labelGiaNhap.Name = "labelGiaNhap";
            labelGiaNhap.Size = new Size(90, 27);
            labelGiaNhap.TabIndex = 73;
            labelGiaNhap.Text = "Giá nhập";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Font = new Font("Segoe UI Variable Display", 10F);
            txtTenSanPham.Location = new Point(93, 187);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(302, 34);
            txtTenSanPham.TabIndex = 72;
            // 
            // labelTenSanPham
            // 
            labelTenSanPham.AutoSize = true;
            labelTenSanPham.Font = new Font("Segoe UI Variable Display", 10F);
            labelTenSanPham.ForeColor = Color.MediumSeaGreen;
            labelTenSanPham.Location = new Point(93, 157);
            labelTenSanPham.Name = "labelTenSanPham";
            labelTenSanPham.Size = new Size(131, 27);
            labelTenSanPham.TabIndex = 71;
            labelTenSanPham.Text = "Tên sản phẩm";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 100);
            panel1.TabIndex = 80;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(323, 31);
            label6.Name = "label6";
            label6.Size = new Size(147, 37);
            label6.TabIndex = 27;
            label6.Text = "Sản Phẩm";
            // 
            // SanPhamModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 477);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(comboxNhaCungCap);
            Controls.Add(lableNhaCungCap);
            Controls.Add(comboxTheLoai);
            Controls.Add(labelTheLoai);
            Controls.Add(txtGiaNhap);
            Controls.Add(labelGiaNhap);
            Controls.Add(txtTenSanPham);
            Controls.Add(labelTenSanPham);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SanPhamModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SanPhamModule";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        public Button btnThem;
        public Button btnSua;
        private Button btnThoat;
        public ComboBox comboxNhaCungCap;
        private Label lableNhaCungCap;
        public ComboBox comboxTheLoai;
        private Label labelTheLoai;
        public TextBox txtGiaNhap;
        private Label labelGiaNhap;
        public TextBox txtTenSanPham;
        private Label labelTenSanPham;
        private Panel panel1;
        private Label label6;
    }
}