namespace GUI
{
    partial class KichCoGUI
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            danhSachKichCo = new DataGridView();
            MaKichCo = new DataGridViewTextBoxColumn();
            TenKichCo = new DataGridViewTextBoxColumn();
            Xoa = new DataGridViewImageColumn();
            Sua = new DataGridViewImageColumn();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtTimKiem = new TextBox();
            btnShowDialog = new Button();
            ((System.ComponentModel.ISupportInitialize)danhSachKichCo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // danhSachKichCo
            // 
            danhSachKichCo.AllowUserToAddRows = false;
            danhSachKichCo.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            danhSachKichCo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            danhSachKichCo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachKichCo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachKichCo.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachKichCo.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            danhSachKichCo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            danhSachKichCo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachKichCo.Columns.AddRange(new DataGridViewColumn[] { MaKichCo, TenKichCo, Xoa, Sua });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            danhSachKichCo.DefaultCellStyle = dataGridViewCellStyle9;
            danhSachKichCo.Location = new Point(0, 98);
            danhSachKichCo.Name = "danhSachKichCo";
            danhSachKichCo.ReadOnly = true;
            danhSachKichCo.RowHeadersWidth = 62;
            danhSachKichCo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachKichCo.Size = new Size(1600, 660);
            danhSachKichCo.TabIndex = 20;
            danhSachKichCo.CellContentClick += danhSachKichCo_CellContentClick;
            // 
            // MaKichCo
            // 
            MaKichCo.DataPropertyName = "MaKichCo";
            MaKichCo.HeaderText = "Mã Kích Cỡ";
            MaKichCo.MinimumWidth = 8;
            MaKichCo.Name = "MaKichCo";
            MaKichCo.ReadOnly = true;
            // 
            // TenKichCo
            // 
            TenKichCo.DataPropertyName = "TenKichCo";
            TenKichCo.HeaderText = "Tên Kích Cỡ";
            TenKichCo.MinimumWidth = 8;
            TenKichCo.Name = "TenKichCo";
            TenKichCo.ReadOnly = true;
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
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 100);
            panel1.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(722, 32);
            label1.Name = "label1";
            label1.Size = new Size(129, 37);
            label1.TabIndex = 1;
            label1.Text = "KÍCH CỠ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(12, 783);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 27;
            label2.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimKiem.Location = new Point(133, 781);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(295, 39);
            txtTimKiem.TabIndex = 26;
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
            btnShowDialog.TabIndex = 25;
            btnShowDialog.Text = "Thêm";
            btnShowDialog.UseVisualStyleBackColor = false;
            btnShowDialog.Click += btnShowDialog_Click;
            // 
            // KichCoGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(btnShowDialog);
            Controls.Add(danhSachKichCo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KichCoGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KichCoGUI";
            ((System.ComponentModel.ISupportInitialize)danhSachKichCo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView danhSachKichCo;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtTimKiem;
        public Button btnShowDialog;
        private DataGridViewTextBoxColumn MaKichCo;
        private DataGridViewTextBoxColumn TenKichCo;
        private DataGridViewImageColumn Xoa;
        private DataGridViewImageColumn Sua;
    }
}