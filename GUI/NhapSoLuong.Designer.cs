namespace GUI
{
    partial class NhapSoLuong
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
            btnThem = new Button();
            label2 = new Label();
            txtSoLuong = new TextBox();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumSeaGreen;
            btnThem.ForeColor = SystemColors.ButtonHighlight;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(328, 59);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(132, 42);
            btnThem.TabIndex = 23;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 9F);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(27, 37);
            label2.Name = "label2";
            label2.Size = new Size(129, 24);
            label2.TabIndex = 22;
            label2.Text = "Nhập số lượng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuong.Font = new Font("Segoe UI Variable Text", 10F);
            txtSoLuong.Location = new Point(27, 64);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(295, 34);
            txtSoLuong.TabIndex = 21;
            // 
            // NhapSoLuong
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 144);
            Controls.Add(btnThem);
            Controls.Add(label2);
            Controls.Add(txtSoLuong);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "NhapSoLuong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhapSoLuong";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Label label2;
        public TextBox txtSoLuong;
    }
}