namespace GUI
{
    partial class TaiKhoanModule
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
            panel1 = new Panel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboBoxNhomQuyen = new ComboBox();
            label3 = new Label();
            comboBoxNhanVien = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 100);
            panel1.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(123, 32);
            label1.Name = "label1";
            label1.Size = new Size(145, 37);
            label1.TabIndex = 1;
            label1.Text = "Tài Khoản";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnThem);
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Controls.Add(btnThoat);
            flowLayoutPanel1.Location = new Point(37, 508);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(326, 60);
            flowLayoutPanel1.TabIndex = 26;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumSeaGreen;
            btnThem.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold);
            btnThem.ForeColor = SystemColors.ButtonHighlight;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(157, 51);
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
            btnSua.Location = new Point(166, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(157, 51);
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
            btnThoat.Location = new Point(3, 60);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(157, 51);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI Variable Display", 10F);
            txtMatKhau.Location = new Point(37, 436);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(326, 34);
            txtMatKhau.TabIndex = 34;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI Variable Display", 10F);
            txtTenDangNhap.Location = new Point(37, 345);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(326, 34);
            txtTenDangNhap.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text", 10F);
            label4.ForeColor = Color.MediumSeaGreen;
            label4.Location = new Point(37, 406);
            label4.Name = "label4";
            label4.Size = new Size(96, 27);
            label4.TabIndex = 32;
            label4.Text = "Mật Khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text", 10F);
            label5.ForeColor = Color.MediumSeaGreen;
            label5.Location = new Point(37, 315);
            label5.Name = "label5";
            label5.Size = new Size(146, 27);
            label5.TabIndex = 31;
            label5.Text = "Tên Đăng Nhập";
            // 
            // comboBoxNhomQuyen
            // 
            comboBoxNhomQuyen.Font = new Font("Segoe UI Variable Text", 10F);
            comboBoxNhomQuyen.FormattingEnabled = true;
            comboBoxNhomQuyen.Location = new Point(37, 254);
            comboBoxNhomQuyen.Name = "comboBoxNhomQuyen";
            comboBoxNhomQuyen.Size = new Size(326, 35);
            comboBoxNhomQuyen.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 10F);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(37, 224);
            label3.Name = "label3";
            label3.Size = new Size(129, 27);
            label3.TabIndex = 29;
            label3.Text = "Nhóm Quyền";
            // 
            // comboBoxNhanVien
            // 
            comboBoxNhanVien.Font = new Font("Segoe UI Variable Text", 10F);
            comboBoxNhanVien.FormattingEnabled = true;
            comboBoxNhanVien.Location = new Point(37, 163);
            comboBoxNhanVien.Name = "comboBoxNhanVien";
            comboBoxNhanVien.Size = new Size(326, 35);
            comboBoxNhanVien.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(37, 133);
            label2.Name = "label2";
            label2.Size = new Size(102, 27);
            label2.TabIndex = 27;
            label2.Text = "Nhân Viên";
            // 
            // TaiKhoanModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 607);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(comboBoxNhomQuyen);
            Controls.Add(label3);
            Controls.Add(comboBoxNhanVien);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TaiKhoanModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaiKhoanModule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        public Button btnThem;
        public Button btnSua;
        public Button btnThoat;
        public TextBox txtMatKhau;
        public TextBox txtTenDangNhap;
        private Label label4;
        private Label label5;
        public ComboBox comboBoxNhomQuyen;
        private Label label3;
        public ComboBox comboBoxNhanVien;
        private Label label2;
    }
}