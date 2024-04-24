namespace GUI
{
    partial class KhachHangModule
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
            panel2 = new Panel();
            text = new Label();
            label1 = new Label();
            txtSoDienThoai = new TextBox();
            txtTen = new TextBox();
            label2 = new Label();
            Tên = new Label();
            btnSua = new Button();
            btnHuyBo = new Button();
            btnThem = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 100);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(text);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(407, 100);
            panel2.TabIndex = 10;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            text.ForeColor = SystemColors.ButtonHighlight;
            text.Location = new Point(104, 32);
            text.Margin = new Padding(4, 0, 4, 0);
            text.Name = "text";
            text.Size = new Size(207, 37);
            text.TabIndex = 0;
            text.Text = "KHÁCH HÀNG";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(107, 32);
            label1.Name = "label1";
            label1.Size = new Size(204, 37);
            label1.TabIndex = 1;
            label1.Text = "KHÁCH HÀNG";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Segoe UI Variable Text", 10F);
            txtSoDienThoai.Location = new Point(44, 249);
            txtSoDienThoai.Margin = new Padding(4, 5, 4, 5);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(324, 34);
            txtSoDienThoai.TabIndex = 2;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI Variable Text", 10F);
            txtTen.Location = new Point(44, 158);
            txtTen.Margin = new Padding(4, 5, 4, 5);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(324, 34);
            txtTen.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(44, 212);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 27);
            label2.TabIndex = 7;
            label2.Text = "Số điện thoại";
            // 
            // Tên
            // 
            Tên.AutoSize = true;
            Tên.Font = new Font("Segoe UI Variable Text", 10F);
            Tên.ForeColor = Color.MediumSeaGreen;
            Tên.Location = new Point(44, 121);
            Tên.Margin = new Padding(4, 0, 4, 0);
            Tên.Name = "Tên";
            Tên.Size = new Size(71, 27);
            Tên.TabIndex = 6;
            Tên.Text = "Họ tên";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Orange;
            btnSua.Font = new Font("Segoe UI Variable Text Semibold", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(182, 5);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(170, 60);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.Red;
            btnHuyBo.Font = new Font("Segoe UI Variable Text Semibold", 10F, FontStyle.Bold);
            btnHuyBo.ForeColor = Color.White;
            btnHuyBo.Location = new Point(4, 75);
            btnHuyBo.Margin = new Padding(4, 5, 4, 5);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(170, 60);
            btnHuyBo.TabIndex = 3;
            btnHuyBo.Text = "Thoát";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumSeaGreen;
            btnThem.Font = new Font("Segoe UI Variable Text Semibold", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(4, 5);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(170, 60);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnThem);
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Controls.Add(btnHuyBo);
            flowLayoutPanel1.Location = new Point(25, 308);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(359, 72);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // KhachHangModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 418);
            Controls.Add(txtSoDienThoai);
            Controls.Add(panel1);
            Controls.Add(txtTen);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Tên);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "KhachHangModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KhachHangModule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label text;
        private Label label1;
        private Label label2;
        private Label Tên;
        private Button btnHuyBo;
        private FlowLayoutPanel flowLayoutPanel1;
        public Button btnThem;
        public Button btnSua;
        public TextBox txtSoDienThoai;
        public TextBox txtTen;
    }
}