using frmDangNhap.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDangNhap
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tendn = textBox1.Text;
            var mk = textBox2.Text;
            TaiKhoan
                taikhoan;
            taikhoan = TaiKhoan.Get(tendn, mk);

            if (taikhoan == null)
            {
                MessageBox.Show($"Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show($"Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

    }
}
