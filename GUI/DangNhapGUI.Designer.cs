namespace GUI
{
    partial class DangNhapGUI
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            chkHienThiMatKhau = new CheckBox();
            txtTenDangNhap = new TextBox();
            label2 = new Label();
            btnDangNhap = new Button();
            txtMatKhau = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.dangnhap;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(506, 499);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(chkHienThiMatKhau);
            panel1.Controls.Add(txtTenDangNhap);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(505, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 499);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            label1.ForeColor = Color.MediumSeaGreen;
            label1.Location = new Point(148, 59);
            label1.Name = "label1";
            label1.Size = new Size(187, 37);
            label1.TabIndex = 15;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // chkHienThiMatKhau
            // 
            chkHienThiMatKhau.AutoSize = true;
            chkHienThiMatKhau.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            chkHienThiMatKhau.Location = new Point(52, 317);
            chkHienThiMatKhau.Name = "chkHienThiMatKhau";
            chkHienThiMatKhau.Size = new Size(192, 31);
            chkHienThiMatKhau.TabIndex = 14;
            chkHienThiMatKhau.Text = "Hiển thị mật khẩu";
            chkHienThiMatKhau.UseVisualStyleBackColor = true;
            chkHienThiMatKhau.CheckedChanged += chkHienThiMatKhau_CheckedChanged;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI Variable Text", 10F);
            txtTenDangNhap.Location = new Point(52, 162);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(377, 34);
            txtTenDangNhap.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(52, 132);
            label2.Name = "label2";
            label2.Size = new Size(140, 27);
            label2.TabIndex = 9;
            label2.Text = "Tên đăng nhập";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.MediumSeaGreen;
            btnDangNhap.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDangNhap.ForeColor = SystemColors.ButtonHighlight;
            btnDangNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangNhap.Location = new Point(52, 380);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(377, 58);
            btnDangNhap.TabIndex = 12;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI Variable Text", 10F);
            txtMatKhau.Location = new Point(52, 265);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(377, 34);
            txtMatKhau.TabIndex = 10;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 10F);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(52, 235);
            label3.Name = "label3";
            label3.Size = new Size(94, 27);
            label3.TabIndex = 11;
            label3.Text = "Mật khẩu";
            // 
            // DangNhapGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 499);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DangNhapGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhapGUI";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private CheckBox chkHienThiMatKhau;
        private TextBox txtTenDangNhap;
        private Label label2;
        private Button btnDangNhap;
        private TextBox txtMatKhau;
        private Label label3;
        private Label label1;
    }
}