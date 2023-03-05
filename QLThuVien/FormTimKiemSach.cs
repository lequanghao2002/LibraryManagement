using QLThuVien.Modify;
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
    public partial class frmTimKiemSach : Form
    {
        ModifySach modifySach;
        public frmTimKiemSach()
        {
            InitializeComponent();
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

        private void frmTimKiemSach_Load(object sender, EventArgs e, string id = null, string ten = null)
        {
            // TODO: This line of code loads data into the 'dB_QuanLyThuVienDataSet.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.dB_QuanLyThuVienDataSet.Sach);

            modifySach = new ModifySach();
            try
            {
                if (id != null)
                {
                    dgvTimKiemSach.DataSource = modifySach.getAllSach(id: id);
                }
                else if (ten != null)
                {
                    dgvTimKiemSach.DataSource = modifySach.getAllSach(ten: ten);

                }
                else
                {
                    dgvTimKiemSach.DataSource = modifySach.getAllSach();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message,
                    "Lỗi kết nối",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (rdoMaSach.Checked)
            {
                string maDG = txtTimKiem.Text;
                frmTimKiemSach_Load(sender, e, id: maDG);
            }
            else if (rdoTenSach.Checked)
            {
                string tenDG = txtTimKiem.Text;
                frmTimKiemSach_Load(sender, e, ten: tenDG);
            }
        }

        private void frmTimKiemSach_Load(object sender, EventArgs e)
        {
            modifySach = new ModifySach();
            try
            {
                dgvTimKiemSach.DataSource = modifySach.getAllSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message,
                    "Lỗi kết nối",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
    }
}