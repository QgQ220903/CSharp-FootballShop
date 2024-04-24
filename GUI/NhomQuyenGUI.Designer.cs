namespace GUI
{
    partial class NhomQuyenGUI
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
            danhSachNhomQuyen = new DataGridView();
            btnShowDialog = new Button();
            label2 = new Label();
            txtTimKiem = new TextBox();
            MaNhomQuyen = new DataGridViewTextBoxColumn();
            TenNhomQuyen = new DataGridViewTextBoxColumn();
            Xoa = new DataGridViewImageColumn();
            Sua = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachNhomQuyen).BeginInit();
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
            panel1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(661, 32);
            label1.Name = "label1";
            label1.Size = new Size(211, 37);
            label1.TabIndex = 1;
            label1.Text = "NHÓM QUYỀN";
            // 
            // danhSachNhomQuyen
            // 
            danhSachNhomQuyen.AllowUserToAddRows = false;
            danhSachNhomQuyen.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            danhSachNhomQuyen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            danhSachNhomQuyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachNhomQuyen.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachNhomQuyen.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachNhomQuyen.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            danhSachNhomQuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            danhSachNhomQuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachNhomQuyen.Columns.AddRange(new DataGridViewColumn[] { MaNhomQuyen, TenNhomQuyen, Xoa, Sua });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            danhSachNhomQuyen.DefaultCellStyle = dataGridViewCellStyle3;
            danhSachNhomQuyen.Location = new Point(0, 96);
            danhSachNhomQuyen.Name = "danhSachNhomQuyen";
            danhSachNhomQuyen.ReadOnly = true;
            danhSachNhomQuyen.RowHeadersWidth = 62;
            danhSachNhomQuyen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachNhomQuyen.Size = new Size(1600, 660);
            danhSachNhomQuyen.TabIndex = 27;
            danhSachNhomQuyen.CellContentClick += danhSachNhomQuyen_CellContentClick;
            // 
            // btnShowDialog
            // 
            btnShowDialog.BackColor = Color.MediumSeaGreen;
            btnShowDialog.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold);
            btnShowDialog.ForeColor = SystemColors.ButtonHighlight;
            btnShowDialog.Location = new Point(1398, 762);
            btnShowDialog.Name = "btnShowDialog";
            btnShowDialog.Size = new Size(190, 70);
            btnShowDialog.TabIndex = 29;
            btnShowDialog.Text = "Thêm";
            btnShowDialog.UseVisualStyleBackColor = false;
            btnShowDialog.Click += btnShowDialog_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(12, 781);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 32;
            label2.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimKiem.Location = new Point(133, 779);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(295, 39);
            txtTimKiem.TabIndex = 31;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // MaNhomQuyen
            // 
            MaNhomQuyen.DataPropertyName = "MaNhomQuyen";
            MaNhomQuyen.HeaderText = "Mã Nhóm Quyền";
            MaNhomQuyen.MinimumWidth = 8;
            MaNhomQuyen.Name = "MaNhomQuyen";
            MaNhomQuyen.ReadOnly = true;
            // 
            // TenNhomQuyen
            // 
            TenNhomQuyen.DataPropertyName = "TenNhomQuyen";
            TenNhomQuyen.HeaderText = "Tên Nhóm Quyền";
            TenNhomQuyen.MinimumWidth = 8;
            TenNhomQuyen.Name = "TenNhomQuyen";
            TenNhomQuyen.ReadOnly = true;
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
            // NhomQuyenGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(btnShowDialog);
            Controls.Add(danhSachNhomQuyen);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NhomQuyenGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhomQuyenGUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachNhomQuyen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        public DataGridView danhSachNhomQuyen;
        public Button btnShowDialog;
        private Label label2;
        private TextBox txtTimKiem;
        private DataGridViewTextBoxColumn MaNhomQuyen;
        private DataGridViewTextBoxColumn TenNhomQuyen;
        private DataGridViewImageColumn Xoa;
        private DataGridViewImageColumn Sua;
    }
}