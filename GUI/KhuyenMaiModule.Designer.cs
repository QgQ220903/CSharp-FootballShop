namespace GUI
{
    partial class KhuyenMaiModule
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
            dateKetThuc = new DateTimePicker();
            dateBatDau = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            txtDieuKien = new TextBox();
            label3 = new Label();
            txtMucKhuyenMai = new TextBox();
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
            panel1.Size = new Size(419, 100);
            panel1.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(118, 33);
            label1.Name = "label1";
            label1.Size = new Size(177, 37);
            label1.TabIndex = 0;
            label1.Text = "Khuyến Mãi";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnThem);
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Controls.Add(btnThoat);
            flowLayoutPanel1.Location = new Point(46, 526);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(326, 60);
            flowLayoutPanel1.TabIndex = 37;
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
            // dateKetThuc
            // 
            dateKetThuc.CalendarFont = new Font("Segoe UI", 10F);
            dateKetThuc.Font = new Font("Segoe UI Variable Display", 10F);
            dateKetThuc.Format = DateTimePickerFormat.Short;
            dateKetThuc.Location = new Point(57, 465);
            dateKetThuc.Name = "dateKetThuc";
            dateKetThuc.Size = new Size(300, 34);
            dateKetThuc.TabIndex = 36;
            // 
            // dateBatDau
            // 
            dateBatDau.CalendarFont = new Font("Segoe UI", 10F);
            dateBatDau.Font = new Font("Segoe UI Variable Display", 10F);
            dateBatDau.Format = DateTimePickerFormat.Short;
            dateBatDau.Location = new Point(57, 366);
            dateBatDau.Name = "dateBatDau";
            dateBatDau.Size = new Size(300, 34);
            dateBatDau.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 10F);
            label4.ForeColor = Color.MediumSeaGreen;
            label4.Location = new Point(57, 435);
            label4.Name = "label4";
            label4.Size = new Size(88, 27);
            label4.TabIndex = 34;
            label4.Text = "Kết Thúc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 10F);
            label5.ForeColor = Color.MediumSeaGreen;
            label5.Location = new Point(57, 336);
            label5.Name = "label5";
            label5.Size = new Size(85, 27);
            label5.TabIndex = 33;
            label5.Text = " Bắt Đầu";
            // 
            // txtDieuKien
            // 
            txtDieuKien.Font = new Font("Segoe UI", 10F);
            txtDieuKien.Location = new Point(57, 265);
            txtDieuKien.Name = "txtDieuKien";
            txtDieuKien.Size = new Size(306, 34);
            txtDieuKien.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 10F);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(57, 235);
            label3.Name = "label3";
            label3.Size = new Size(95, 27);
            label3.TabIndex = 31;
            label3.Text = "Điều Kiện";
            // 
            // txtMucKhuyenMai
            // 
            txtMucKhuyenMai.Font = new Font("Segoe UI", 10F);
            txtMucKhuyenMai.Location = new Point(57, 166);
            txtMucKhuyenMai.Name = "txtMucKhuyenMai";
            txtMucKhuyenMai.Size = new Size(306, 34);
            txtMucKhuyenMai.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 10F);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(57, 136);
            label2.Name = "label2";
            label2.Size = new Size(160, 27);
            label2.TabIndex = 28;
            label2.Text = "Mức Khuyến Mãi";
            // 
            // KhuyenMaiModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 619);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dateKetThuc);
            Controls.Add(dateBatDau);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtDieuKien);
            Controls.Add(label3);
            Controls.Add(txtMucKhuyenMai);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "KhuyenMaiModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KhuyenMaiModule";
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
        public DateTimePicker dateKetThuc;
        public DateTimePicker dateBatDau;
        public Label label4;
        public Label label5;
        public TextBox txtDieuKien;
        public Label label3;
        public TextBox txtMucKhuyenMai;
        public Label label2;
    }
}