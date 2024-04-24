namespace GUI
{
    partial class MauSacGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MauSacGUI));
            label2 = new Label();
            txtTimKiem = new TextBox();
            btnShowDialog = new Button();
            danhSachMauSac = new DataGridView();
            MaMauSac = new DataGridViewTextBoxColumn();
            TenMauSac = new DataGridViewTextBoxColumn();
            Xoa = new DataGridViewImageColumn();
            Sua = new DataGridViewImageColumn();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)danhSachMauSac).BeginInit();
            panel1.SuspendLayout();
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
            label2.TabIndex = 22;
            label2.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimKiem.Location = new Point(133, 781);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(295, 39);
            txtTimKiem.TabIndex = 21;
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
            btnShowDialog.TabIndex = 20;
            btnShowDialog.Text = "Thêm";
            btnShowDialog.UseVisualStyleBackColor = false;
            btnShowDialog.Click += btnShowDialog_Click;
            // 
            // danhSachMauSac
            // 
            danhSachMauSac.AllowUserToAddRows = false;
            danhSachMauSac.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            danhSachMauSac.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            danhSachMauSac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachMauSac.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachMauSac.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachMauSac.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            danhSachMauSac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            danhSachMauSac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachMauSac.Columns.AddRange(new DataGridViewColumn[] { MaMauSac, TenMauSac, Xoa, Sua });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            danhSachMauSac.DefaultCellStyle = dataGridViewCellStyle9;
            danhSachMauSac.Location = new Point(0, 98);
            danhSachMauSac.Name = "danhSachMauSac";
            danhSachMauSac.ReadOnly = true;
            danhSachMauSac.RowHeadersWidth = 62;
            danhSachMauSac.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachMauSac.Size = new Size(1600, 660);
            danhSachMauSac.TabIndex = 23;
            danhSachMauSac.CellContentClick += danhSachMauSac_CellContentClick;
            // 
            // MaMauSac
            // 
            MaMauSac.DataPropertyName = "MaMauSac";
            MaMauSac.HeaderText = "Mã Màu Sắc";
            MaMauSac.MinimumWidth = 8;
            MaMauSac.Name = "MaMauSac";
            MaMauSac.ReadOnly = true;
            // 
            // TenMauSac
            // 
            TenMauSac.DataPropertyName = "TenMauSac";
            TenMauSac.HeaderText = "Tên Màu Sắc";
            TenMauSac.MinimumWidth = 8;
            TenMauSac.Name = "TenMauSac";
            TenMauSac.ReadOnly = true;
            // 
            // Xoa
            // 
            Xoa.DataPropertyName = "Xoa";
            Xoa.HeaderText = "Xóa";
            Xoa.Image = (Image)resources.GetObject("Xoa.Image");
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
            Sua.Image = (Image)resources.GetObject("Sua.Image");
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
            panel1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(701, 31);
            label1.Name = "label1";
            label1.Size = new Size(144, 37);
            label1.TabIndex = 1;
            label1.Text = "MÀU SẮC";
            // 
            // MauSacGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(panel1);
            Controls.Add(danhSachMauSac);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(btnShowDialog);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MauSacGUI";
            Text = "MauSacGUI";
            ((System.ComponentModel.ISupportInitialize)danhSachMauSac).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtTimKiem;
        public Button btnShowDialog;
        public DataGridView danhSachMauSac;
        private DataGridViewTextBoxColumn MaMauSac;
        private DataGridViewTextBoxColumn TenMauSac;
        private DataGridViewImageColumn Xoa;
        private DataGridViewImageColumn Sua;
        private Panel panel1;
        private Label label1;
    }
}