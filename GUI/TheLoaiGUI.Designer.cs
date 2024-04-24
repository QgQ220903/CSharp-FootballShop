namespace GUI
{
    partial class TheLoaiGUI
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label2 = new Label();
            txtTimKiem = new TextBox();
            btnShowDialog = new Button();
            panel1 = new Panel();
            label1 = new Label();
            danhSachTheLoai = new DataGridView();
            MaTheLoai = new DataGridViewTextBoxColumn();
            TenTheLoai = new DataGridViewTextBoxColumn();
            Xoa = new DataGridViewImageColumn();
            Sua = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachTheLoai).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(12, 783);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 19;
            label2.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimKiem.Location = new Point(133, 781);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(295, 39);
            txtTimKiem.TabIndex = 18;
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
            btnShowDialog.TabIndex = 17;
            btnShowDialog.Text = "Thêm";
            btnShowDialog.UseVisualStyleBackColor = false;
            btnShowDialog.Click += btnShowDialog_Click;
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
            label1.Location = new Point(702, 35);
            label1.Name = "label1";
            label1.Size = new Size(140, 37);
            label1.TabIndex = 1;
            label1.Text = "THỂ LOẠI";
            // 
            // danhSachTheLoai
            // 
            danhSachTheLoai.AllowUserToAddRows = false;
            danhSachTheLoai.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            danhSachTheLoai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            danhSachTheLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachTheLoai.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachTheLoai.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachTheLoai.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            danhSachTheLoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            danhSachTheLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachTheLoai.Columns.AddRange(new DataGridViewColumn[] { MaTheLoai, TenTheLoai, Xoa, Sua });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            danhSachTheLoai.DefaultCellStyle = dataGridViewCellStyle6;
            danhSachTheLoai.Location = new Point(0, 98);
            danhSachTheLoai.Name = "danhSachTheLoai";
            danhSachTheLoai.ReadOnly = true;
            danhSachTheLoai.RowHeadersWidth = 62;
            danhSachTheLoai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachTheLoai.Size = new Size(1600, 660);
            danhSachTheLoai.TabIndex = 26;
            danhSachTheLoai.CellContentClick += danhSachTheLoai_CellContentClick;
            // 
            // MaTheLoai
            // 
            MaTheLoai.DataPropertyName = "MaTheLoai";
            MaTheLoai.HeaderText = "Mã Thể Loại";
            MaTheLoai.MinimumWidth = 8;
            MaTheLoai.Name = "MaTheLoai";
            MaTheLoai.ReadOnly = true;
            // 
            // TenTheLoai
            // 
            TenTheLoai.DataPropertyName = "TenTheLoai";
            TenTheLoai.HeaderText = "Tên Thể Loại";
            TenTheLoai.MinimumWidth = 8;
            TenTheLoai.Name = "TenTheLoai";
            TenTheLoai.ReadOnly = true;
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
            // TheLoaiGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(danhSachTheLoai);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(btnShowDialog);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TheLoaiGUI";
            Text = "TheLoaiGUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachTheLoai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtTimKiem;
        public Button btnShowDialog;
        private Panel panel1;
        private Label label1;
        public DataGridView danhSachTheLoai;
        private DataGridViewTextBoxColumn MaTheLoai;
        private DataGridViewTextBoxColumn TenTheLoai;
        private DataGridViewImageColumn Xoa;
        private DataGridViewImageColumn Sua;
    }
}