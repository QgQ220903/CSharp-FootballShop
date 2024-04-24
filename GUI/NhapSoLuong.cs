using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class NhapSoLuong : Form
    {
        public int SoLuong { get; set; }

        public NhapSoLuong()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CheckError check = new CheckError();
            // Lấy số lượng từ TextBox
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng sản phẩm");
            }
            else if (!check.IsNumeric(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập số");
            }
            else
            {
                int soLuong = Convert.ToInt32(txtSoLuong.Text);
                if (soLuong < 0 || soLuong == 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng sản phẩm lớn hơn 0");
                }
                else
                {
                    this.SoLuong = soLuong;
                    this.Dispose();

                }

            }
        }
    }
}
