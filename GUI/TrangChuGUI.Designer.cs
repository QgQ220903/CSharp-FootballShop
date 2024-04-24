namespace GUI
{
    partial class TrangChuGUI
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
            sideBar = new FlowLayoutPanel();
            panel1 = new Panel();
            picNhanVien = new PictureBox();
            lbTenNhanVien = new Label();
            lbNhomQuyen = new Label();
            containerPanel = new Panel();
            sideBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNhanVien).BeginInit();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.MediumSeaGreen;
            sideBar.Controls.Add(panel1);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(280, 904);
            sideBar.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(picNhanVien);
            panel1.Controls.Add(lbTenNhanVien);
            panel1.Controls.Add(lbNhomQuyen);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 86);
            panel1.TabIndex = 6;
            // 
            // picNhanVien
            // 
            picNhanVien.Image = Properties.Resources.Employee;
            picNhanVien.Location = new Point(0, 0);
            picNhanVien.Name = "picNhanVien";
            picNhanVien.Size = new Size(84, 85);
            picNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
            picNhanVien.TabIndex = 6;
            picNhanVien.TabStop = false;
            // 
            // lbTenNhanVien
            // 
            lbTenNhanVien.AutoSize = true;
            lbTenNhanVien.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbTenNhanVien.ForeColor = SystemColors.ButtonHighlight;
            lbTenNhanVien.Location = new Point(90, 49);
            lbTenNhanVien.Name = "lbTenNhanVien";
            lbTenNhanVien.Size = new Size(129, 24);
            lbTenNhanVien.TabIndex = 5;
            lbTenNhanVien.Text = "Quách Gia Quy";
            // 
            // lbNhomQuyen
            // 
            lbNhomQuyen.AutoSize = true;
            lbNhomQuyen.Font = new Font("Segoe UI Variable Text Semibold", 9F, FontStyle.Bold);
            lbNhomQuyen.ForeColor = SystemColors.ButtonHighlight;
            lbNhomQuyen.Location = new Point(90, 15);
            lbNhomQuyen.Name = "lbNhomQuyen";
            lbNhomQuyen.Size = new Size(74, 24);
            lbNhomQuyen.TabIndex = 4;
            lbNhomQuyen.Text = "Quản lý";
            // 
            // containerPanel
            // 
            containerPanel.BackgroundImage = Properties.Resources.trangchu;
            containerPanel.BackgroundImageLayout = ImageLayout.Stretch;
            containerPanel.Dock = DockStyle.Fill;
            containerPanel.Location = new Point(280, 0);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(1598, 904);
            containerPanel.TabIndex = 2;
            containerPanel.Paint += containerPanel_Paint;
            // 
            // TrangChuGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1878, 904);
            Controls.Add(containerPanel);
            Controls.Add(sideBar);
            Name = "TrangChuGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrangChuGUI";
            sideBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sideBar;
        private Panel panel1;
        private PictureBox picNhanVien;
        private Label lbTenNhanVien;
        private Label lbNhomQuyen;
        private Panel containerPanel;
    }
}