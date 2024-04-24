namespace GUI
{
    partial class ThuocTinhGUI
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
            tabControl1 = new TabControl();
            TheLoaiGUI = new TabPage();
            MauSacGUI = new TabPage();
            KichCoGUI = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TheLoaiGUI);
            tabControl1.Controls.Add(MauSacGUI);
            tabControl1.Controls.Add(KichCoGUI);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1600, 900);
            tabControl1.TabIndex = 1;
            // 
            // TheLoaiGUI
            // 
            TheLoaiGUI.Location = new Point(4, 34);
            TheLoaiGUI.Name = "TheLoaiGUI";
            TheLoaiGUI.Padding = new Padding(3);
            TheLoaiGUI.Size = new Size(1592, 862);
            TheLoaiGUI.TabIndex = 0;
            TheLoaiGUI.Text = "Thể Loại";
            TheLoaiGUI.UseVisualStyleBackColor = true;
            // 
            // MauSacGUI
            // 
            MauSacGUI.Location = new Point(4, 34);
            MauSacGUI.Name = "MauSacGUI";
            MauSacGUI.Padding = new Padding(3);
            MauSacGUI.Size = new Size(1592, 862);
            MauSacGUI.TabIndex = 1;
            MauSacGUI.Text = "Màu Sắc";
            MauSacGUI.UseVisualStyleBackColor = true;
            // 
            // KichCoGUI
            // 
            KichCoGUI.Location = new Point(4, 34);
            KichCoGUI.Name = "KichCoGUI";
            KichCoGUI.Padding = new Padding(3);
            KichCoGUI.Size = new Size(1592, 862);
            KichCoGUI.TabIndex = 2;
            KichCoGUI.Text = "Kích Cỡ";
            KichCoGUI.UseVisualStyleBackColor = true;
            // 
            // ThuocTinhGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThuocTinhGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThuocTinhGUI";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TheLoaiGUI;
        private TabPage MauSacGUI;
        private TabPage KichCoGUI;
    }
}