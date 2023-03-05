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
    public partial class frmPhieuMuon : Form
    {
        public frmPhieuMuon()
        {
            InitializeComponent();
        }

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            dtpNgayMuon.Format = DateTimePickerFormat.Short;
            dtpNgayTra.Format = DateTimePickerFormat.Short;
        }

        private void btQuayVe_Click(object sender, EventArgs e)
        {
            Form f = new frmTrangChu();
            f.Show();
            this.Hide();
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