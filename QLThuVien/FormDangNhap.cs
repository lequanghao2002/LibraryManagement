using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(280, 480);
            this.MaximumSize = new System.Drawing.Size(280, 480);

            this.AcceptButton = btDangNhap;
            txtMatKhau.PasswordChar = '•';
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btDangNhap.PerformClick();
            }
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (txtDangNhap.Text == "admin" && txtMatKhau.Text == "123")
            {
                Form f = new frmTrangChu();
                f.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult ThongBaoThoat;
            ThongBaoThoat = (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (ThongBaoThoat == DialogResult.Yes)
                Application.Exit();
        }
    }
}