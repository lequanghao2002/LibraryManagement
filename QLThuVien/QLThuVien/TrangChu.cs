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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.MaximumSize = new System.Drawing.Size(600, 400);
        }

        private void độcGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new frmThongTinDG();
            f.Show();
            this.Hide();
        }

        private void sáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new frmThongTinSach();
            f.Show();
            this.Hide();
        }

        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmPhieuMuon();
            f.Show();
            this.Hide();
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmTheLoai();
            f.Show();
            this.Hide();
        }
    }
}