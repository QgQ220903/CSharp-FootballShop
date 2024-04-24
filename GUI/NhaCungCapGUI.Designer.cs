namespace GUI
{
    partial class NhaCungCapGUI
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
            danhSachNhaCungCap = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtTimKiem = new TextBox();
            btnShowDialog = new Button();
            MaNhaCungCap = new DataGridViewTextBoxColumn();
            TenNhaCungCap = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            Xoa = new DataGridViewImageColumn();
            Sua = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)danhSachNhaCungCap).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // danhSachNhaCungCap
            // 
            danhSachNhaCungCap.AllowUserToAddRows = false;
            danhSachNhaCungCap.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            danhSachNhaCungCap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            danhSachNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachNhaCungCap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachNhaCungCap.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachNhaCungCap.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            danhSachNhaCungCap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            danhSachNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachNhaCungCap.Columns.AddRange(new DataGridViewColumn[] { MaNhaCungCap, TenNhaCungCap, DiaChi, SoDienThoai, Xoa, Sua });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            danhSachNhaCungCap.DefaultCellStyle = dataGridViewCellStyle3;
            danhSachNhaCungCap.Location = new Point(0, 96);
            danhSachNhaCungCap.Name = "danhSachNhaCungCap";
            danhSachNhaCungCap.ReadOnly = true;
            danhSachNhaCungCap.RowHeadersWidth = 62;
            danhSachNhaCungCap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachNhaCungCap.Size = new Size(1600, 660);
            danhSachNhaCungCap.TabIndex = 20;
            danhSachNhaCungCap.CellContentClick += danhSachNhaCungCap_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 100);
            panel1.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(651, 33);
            label1.Name = "label1";
            label1.Size = new Size(229, 37);
            label1.TabIndex = 1;
            label1.Text = "NHÀ CUNG CẤP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(12, 781);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 28;
            label2.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimKiem.Location = new Point(133, 779);
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
            btnShowDialog.Location = new Point(1398, 762);
            btnShowDialog.Name = "btnShowDialog";
            btnShowDialog.Size = new Size(190, 70);
            btnShowDialog.TabIndex = 26;
            btnShowDialog.Text = "Thêm";
            btnShowDialog.UseVisualStyleBackColor = false;
            btnShowDialog.Click += btnShowDialog_Click;
            // 
            // MaNhaCungCap
            // 
            MaNhaCungCap.DataPropertyName = "MaNhaCungCap";
            MaNhaCungCap.HeaderText = "Mã nhà cung cấp";
            MaNhaCungCap.MinimumWidth = 8;
            MaNhaCungCap.Name = "MaNhaCungCap";
            MaNhaCungCap.ReadOnly = true;
            // 
            // TenNhaCungCap
            // 
            TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            TenNhaCungCap.HeaderText = "Tên nhà cung cấp";
            TenNhaCungCap.MinimumWidth = 8;
            TenNhaCungCap.Name = "TenNhaCungCap";
            TenNhaCungCap.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 8;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.MinimumWidth = 8;
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.ReadOnly = true;
            // 
            // Xoa
            // 
            Xoa.HeaderText = "Xóa";
            Xoa.Image = Properties.Resources.Delete;
            Xoa.MinimumWidth = 8;
            Xoa.Name = "Xoa";
            Xoa.ReadOnly = true;
            // 
            // Sua
            // 
            Sua.HeaderText = "Sửa";
            Sua.Image = Properties.Resources.Edit;
            Sua.MinimumWidth = 8;
            Sua.Name = "Sua";
            Sua.ReadOnly = true;
            // 
            // NhaCungCapGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(btnShowDialog);
            Controls.Add(panel1);
            Controls.Add(danhSachNhaCungCap);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NhaCungCapGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhaCungCapGUI";
            ((System.ComponentModel.ISupportInitialize)danhSachNhaCungCap).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView danhSachNhaCungCap;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtTimKiem;
        public Button btnShowDialog;
        private DataGridViewTextBoxColumn MaNhaCungCap;
        private DataGridViewTextBoxColumn TenNhaCungCap;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewImageColumn Xoa;
        private DataGridViewImageColumn Sua;
    }
}