namespace GUI
{
    partial class NhanVienModule
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
            picNhanVien = new PictureBox();
            label5 = new Label();
            txtSoDienThoai = new TextBox();
            label4 = new Label();
            txtTuoi = new TextBox();
            label3 = new Label();
            txtTenNhanVien = new TextBox();
            label2 = new Label();
            btnChonAnh = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 100);
            panel1.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(114, 33);
            label1.Name = "label1";
            label1.Size = new Size(155, 37);
            label1.TabIndex = 1;
            label1.Text = "Nhân Viên";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnThem);
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Controls.Add(btnThoat);
            flowLayoutPanel1.Location = new Point(32, 679);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(326, 57);
            flowLayoutPanel1.TabIndex = 36;
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
            // picNhanVien
            // 
            picNhanVien.BorderStyle = BorderStyle.FixedSingle;
            picNhanVien.Image = Properties.Resources.Employee;
            picNhanVien.Location = new Point(98, 424);
            picNhanVien.Name = "picNhanVien";
            picNhanVien.Size = new Size(171, 177);
            picNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
            picNhanVien.TabIndex = 35;
            picNhanVien.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text", 10F);
            label5.ForeColor = Color.MediumSeaGreen;
            label5.Location = new Point(46, 394);
            label5.Name = "label5";
            label5.Size = new Size(93, 27);
            label5.TabIndex = 34;
            label5.Text = "Hình Ảnh";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Segoe UI Variable Display", 10F);
            txtSoDienThoai.Location = new Point(41, 336);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(308, 34);
            txtSoDienThoai.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text", 10F);
            label4.ForeColor = Color.MediumSeaGreen;
            label4.Location = new Point(41, 306);
            label4.Name = "label4";
            label4.Size = new Size(133, 27);
            label4.TabIndex = 32;
            label4.Text = "Số Điện Thoại";
            // 
            // txtTuoi
            // 
            txtTuoi.Font = new Font("Segoe UI Variable Display", 10F);
            txtTuoi.Location = new Point(41, 242);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(308, 34);
            txtTuoi.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 10F);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(41, 212);
            label3.Name = "label3";
            label3.Size = new Size(50, 27);
            label3.TabIndex = 30;
            label3.Text = "Tuổi";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Font = new Font("Segoe UI Variable Display", 10F);
            txtTenNhanVien.Location = new Point(41, 158);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(308, 34);
            txtTenNhanVien.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(41, 128);
            label2.Name = "label2";
            label2.Size = new Size(98, 27);
            label2.TabIndex = 28;
            label2.Text = "Họ Và Tên";
            // 
            // btnChonAnh
            // 
            btnChonAnh.BackColor = Color.DodgerBlue;
            btnChonAnh.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold);
            btnChonAnh.ForeColor = SystemColors.ButtonHighlight;
            btnChonAnh.Location = new Point(98, 607);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(171, 51);
            btnChonAnh.TabIndex = 26;
            btnChonAnh.Text = "Chọn Ảnh";
            btnChonAnh.UseVisualStyleBackColor = false;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // NhanVienModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 762);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(picNhanVien);
            Controls.Add(label5);
            Controls.Add(txtSoDienThoai);
            Controls.Add(label4);
            Controls.Add(txtTuoi);
            Controls.Add(label3);
            Controls.Add(txtTenNhanVien);
            Controls.Add(label2);
            Controls.Add(btnChonAnh);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "NhanVienModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhanVienModule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picNhanVien).EndInit();
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
        public PictureBox picNhanVien;
        private Label label5;
        public TextBox txtSoDienThoai;
        private Label label4;
        public TextBox txtTuoi;
        private Label label3;
        public TextBox txtTenNhanVien;
        private Label label2;
        public Button btnChonAnh;
    }
}