namespace GUI
{
    partial class TaiKhoanGUI
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
            panel1 = new Panel();
            label1 = new Label();
            danhSachTaiKhoan = new DataGridView();
            label2 = new Label();
            txtTimKiem = new TextBox();
            btnShowDialog = new Button();
            MaTaiKhoan = new DataGridViewTextBoxColumn();
            MaNhomQuyen = new DataGridViewTextBoxColumn();
            TenTaiKhoan = new DataGridViewTextBoxColumn();
            MatKhau = new DataGridViewTextBoxColumn();
            Xoa = new DataGridViewImageColumn();
            Sua = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachTaiKhoan).BeginInit();
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
            panel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(683, 32);
            label1.Name = "label1";
            label1.Size = new Size(172, 37);
            label1.TabIndex = 1;
            label1.Text = "TÀI KHOẢN";
            // 
            // danhSachTaiKhoan
            // 
            danhSachTaiKhoan.AllowUserToAddRows = false;
            danhSachTaiKhoan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            danhSachTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            danhSachTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachTaiKhoan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachTaiKhoan.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachTaiKhoan.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            danhSachTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            danhSachTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachTaiKhoan.Columns.AddRange(new DataGridViewColumn[] { MaTaiKhoan, MaNhomQuyen, TenTaiKhoan, MatKhau, Xoa, Sua });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            danhSachTaiKhoan.DefaultCellStyle = dataGridViewCellStyle3;
            danhSachTaiKhoan.Location = new Point(0, 98);
            danhSachTaiKhoan.Name = "danhSachTaiKhoan";
            danhSachTaiKhoan.ReadOnly = true;
            danhSachTaiKhoan.RowHeadersWidth = 62;
            danhSachTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachTaiKhoan.Size = new Size(1600, 660);
            danhSachTaiKhoan.TabIndex = 20;
            danhSachTaiKhoan.CellContentClick += danhSachTaiKhoan_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(12, 783);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 33;
            label2.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimKiem.Location = new Point(133, 781);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(295, 39);
            txtTimKiem.TabIndex = 32;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnShowDialog
            // 
            btnShowDialog.BackColor = Color.MediumSeaGreen;
            btnShowDialog.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold);
            btnShowDialog.ForeColor = SystemColors.ButtonHighlight;
            btnShowDialog.Location = new Point(1398, 764);
            btnShowDialog.Name = "btnShowDialog";
            btnShowDialog.Size = new Size(190, 70);
            btnShowDialog.TabIndex = 31;
            btnShowDialog.Text = "Thêm";
            btnShowDialog.UseVisualStyleBackColor = false;
            btnShowDialog.Click += btnShowDialog_Click;
            // 
            // MaTaiKhoan
            // 
            MaTaiKhoan.DataPropertyName = "MaTaiKhoan";
            MaTaiKhoan.HeaderText = "Mã Tài Khoản";
            MaTaiKhoan.MinimumWidth = 8;
            MaTaiKhoan.Name = "MaTaiKhoan";
            MaTaiKhoan.ReadOnly = true;
            // 
            // MaNhomQuyen
            // 
            MaNhomQuyen.DataPropertyName = "MaNhomQuyen";
            MaNhomQuyen.HeaderText = "Nhóm Quyền";
            MaNhomQuyen.MinimumWidth = 8;
            MaNhomQuyen.Name = "MaNhomQuyen";
            MaNhomQuyen.ReadOnly = true;
            // 
            // TenTaiKhoan
            // 
            TenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            TenTaiKhoan.HeaderText = "Tên Tài Khoản";
            TenTaiKhoan.MinimumWidth = 8;
            TenTaiKhoan.Name = "TenTaiKhoan";
            TenTaiKhoan.ReadOnly = true;
            // 
            // MatKhau
            // 
            MatKhau.DataPropertyName = "MatKhau";
            MatKhau.HeaderText = "Mật Khẩu";
            MatKhau.MinimumWidth = 8;
            MatKhau.Name = "MatKhau";
            MatKhau.ReadOnly = true;
            // 
            // Xoa
            // 
            Xoa.DataPropertyName = "Xoa";
            Xoa.HeaderText = "Xóa";
            Xoa.Image = Properties.Resources.Delete;
            Xoa.MinimumWidth = 8;
            Xoa.Name = "Xoa";
            Xoa.ReadOnly = true;
            Xoa.Resizable = DataGridViewTriState.True;
            Xoa.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Sua
            // 
            Sua.DataPropertyName = "Sua";
            Sua.HeaderText = "Sửa";
            Sua.Image = Properties.Resources.Edit;
            Sua.MinimumWidth = 8;
            Sua.Name = "Sua";
            Sua.ReadOnly = true;
            Sua.Resizable = DataGridViewTriState.True;
            Sua.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // TaiKhoanGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(btnShowDialog);
            Controls.Add(danhSachTaiKhoan);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "TaiKhoanGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaiKhoanGUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachTaiKhoan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        public DataGridView danhSachTaiKhoan;
        private Label label2;
        private TextBox txtTimKiem;
        public Button btnShowDialog;
        private DataGridViewTextBoxColumn MaTaiKhoan;
        private DataGridViewTextBoxColumn MaNhomQuyen;
        private DataGridViewTextBoxColumn TenTaiKhoan;
        private DataGridViewTextBoxColumn MatKhau;
        private DataGridViewImageColumn Xoa;
        private DataGridViewImageColumn Sua;
    }
}