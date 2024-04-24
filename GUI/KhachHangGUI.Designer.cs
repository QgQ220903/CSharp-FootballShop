namespace GUI
{
    partial class KhachHangGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHangGUI));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            dgvKhachHang = new DataGridView();
            label2 = new Label();
            txtTimKiem = new TextBox();
            btnShowDialog = new Button();
            MaKhachHang = new DataGridViewTextBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            xoa = new DataGridViewImageColumn();
            sua = new DataGridViewImageColumn();
            giaodich = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
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
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(686, 33);
            label1.Name = "label1";
            label1.Size = new Size(204, 37);
            label1.TabIndex = 1;
            label1.Text = "KHÁCH HÀNG";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Text", 10F);
            dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKhachHang.BackgroundColor = Color.White;
            dgvKhachHang.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKhachHang, TenKhachHang, SoDienThoai, xoa, sua, giaodich });
            dgvKhachHang.Location = new Point(0, 97);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.RowTemplate.Height = 24;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(1600, 660);
            dgvKhachHang.TabIndex = 6;
            dgvKhachHang.CellContentClick += dgvKhachHang_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(12, 782);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 28;
            label2.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimKiem.Location = new Point(133, 780);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(295, 39);
            txtTimKiem.TabIndex = 27;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnShowDialog
            // 
            btnShowDialog.BackColor = Color.MediumSeaGreen;
            btnShowDialog.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold);
            btnShowDialog.ForeColor = SystemColors.ButtonHighlight;
            btnShowDialog.Location = new Point(1398, 763);
            btnShowDialog.Name = "btnShowDialog";
            btnShowDialog.Size = new Size(190, 70);
            btnShowDialog.TabIndex = 26;
            btnShowDialog.Text = "Thêm";
            btnShowDialog.UseVisualStyleBackColor = false;
            btnShowDialog.Click += btnShowDialog_Click;
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
            // xoa
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = resources.GetObject("dataGridViewCellStyle6.NullValue");
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            xoa.DefaultCellStyle = dataGridViewCellStyle6;
            xoa.HeaderText = "Xóa";
            xoa.Image = Properties.Resources.Delete;
            xoa.MinimumWidth = 6;
            xoa.Name = "xoa";
            xoa.Resizable = DataGridViewTriState.True;
            xoa.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // sua
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle7.NullValue = resources.GetObject("dataGridViewCellStyle7.NullValue");
            dataGridViewCellStyle7.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            sua.DefaultCellStyle = dataGridViewCellStyle7;
            sua.HeaderText = "Sửa";
            sua.Image = Properties.Resources.Edit;
            sua.MinimumWidth = 6;
            sua.Name = "sua";
            sua.Resizable = DataGridViewTriState.True;
            // 
            // giaodich
            // 
            giaodich.DataPropertyName = "giaodich";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = resources.GetObject("dataGridViewCellStyle8.NullValue");
            dataGridViewCellStyle8.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            giaodich.DefaultCellStyle = dataGridViewCellStyle8;
            giaodich.HeaderText = "Giao Dịch";
            giaodich.Image = Properties.Resources.Transaction;
            giaodich.MinimumWidth = 8;
            giaodich.Name = "giaodich";
            // 
            // KhachHangGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(btnShowDialog);
            Controls.Add(panel1);
            Controls.Add(dgvKhachHang);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KhachHangGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KhachHangGUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        public DataGridView dgvKhachHang;
        private Label label2;
        private TextBox txtTimKiem;
        public Button btnShowDialog;
        private DataGridViewTextBoxColumn MaKhachHang;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewImageColumn xoa;
        private DataGridViewImageColumn sua;
        private DataGridViewImageColumn giaodich;
    }
}