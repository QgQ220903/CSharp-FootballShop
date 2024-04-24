namespace GUI
{
    partial class NhaCungCapModule
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
            txtSoDienThoai = new TextBox();
            label4 = new Label();
            txtDiaChi = new TextBox();
            label3 = new Label();
            txtNhaCungCap = new TextBox();
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
            panel1.Size = new Size(410, 100);
            panel1.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(94, 33);
            label1.Name = "label1";
            label1.Size = new Size(204, 37);
            label1.TabIndex = 1;
            label1.Text = "Nhà Cung Cấp";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnThem);
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Controls.Add(btnThoat);
            flowLayoutPanel1.Location = new Point(45, 418);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(326, 60);
            flowLayoutPanel1.TabIndex = 41;
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
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Segoe UI Variable Display", 10F);
            txtSoDienThoai.Location = new Point(45, 353);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(323, 34);
            txtSoDienThoai.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text", 10F);
            label4.ForeColor = Color.MediumSeaGreen;
            label4.Location = new Point(42, 323);
            label4.Name = "label4";
            label4.Size = new Size(133, 27);
            label4.TabIndex = 39;
            label4.Text = "Số Điện Thoại";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI Variable Display", 10F);
            txtDiaChi.Location = new Point(45, 259);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(323, 34);
            txtDiaChi.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 10F);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(42, 229);
            label3.Name = "label3";
            label3.Size = new Size(74, 27);
            label3.TabIndex = 37;
            label3.Text = "Địa Chỉ";
            // 
            // txtNhaCungCap
            // 
            txtNhaCungCap.Font = new Font("Segoe UI Variable Display", 10F);
            txtNhaCungCap.Location = new Point(45, 173);
            txtNhaCungCap.Name = "txtNhaCungCap";
            txtNhaCungCap.Size = new Size(323, 34);
            txtNhaCungCap.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(42, 143);
            label2.Name = "label2";
            label2.Size = new Size(172, 27);
            label2.TabIndex = 35;
            label2.Text = "Tên Nhà Cung Cấp";
            // 
            // NhaCungCapModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 520);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtSoDienThoai);
            Controls.Add(label4);
            Controls.Add(txtDiaChi);
            Controls.Add(label3);
            Controls.Add(txtNhaCungCap);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "NhaCungCapModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhaCungCapModule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Panel panel1;
        public Label label1;
        public FlowLayoutPanel flowLayoutPanel1;
        public Button btnThem;
        public Button btnSua;
        public Button btnThoat;
        public TextBox txtSoDienThoai;
        public Label label4;
        public TextBox txtDiaChi;
        public Label label3;
        public TextBox txtNhaCungCap;
        public Label label2;
    }
}