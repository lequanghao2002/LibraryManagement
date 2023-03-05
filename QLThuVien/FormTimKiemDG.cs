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
    public partial class frmTimKiemDG : Form
    {
        ModifyDocGia modifyDocGia;

        public frmTimKiemDG()
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

        private void frmTimKiemDG_Load(object sender, EventArgs e, string id = null, string ten = null)
        {
            // TODO: This line of code loads data into the 'dB_QuanLyThuVienDataSet.PhieuMuon' table. You can move, or remove it, as needed.
            this.phieuMuonTableAdapter.Fill(this.dB_QuanLyThuVienDataSet.PhieuMuon);
            // TODO: This line of code loads data into the 'dB_QuanLyThuVienDataSet.DocGia' table. You can move, or remove it, as needed.
            this.docGiaTableAdapter.Fill(this.dB_QuanLyThuVienDataSet.DocGia);

            modifyDocGia = new ModifyDocGia();
            try
            {
                if(id != null)
                {
                    dgvTimKiemDG.DataSource = modifyDocGia.getAllDocGia(id: id);
                }
                else if(ten != null)
                {
                    dgvTimKiemDG.DataSource = modifyDocGia.getAllDocGia(ten: ten);

                }
                else
                {
                    dgvTimKiemDG.DataSource = modifyDocGia.getAllDocGia();
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
            if(rdoMaDG.Checked)
            {
                string maDG = txtTimKiem.Text;
                frmTimKiemDG_Load(sender, e, id: maDG);
            }
            else if(rdoTenDG.Checked)
            {
                string tenDG = txtTimKiem.Text;
                frmTimKiemDG_Load(sender, e, ten: tenDG);
            }
        }

        private void frmTimKiemDG_Load(object sender, EventArgs e)
        {
            modifyDocGia = new ModifyDocGia();
            try
            {
                dgvTimKiemDG.DataSource = modifyDocGia.getAllDocGia();
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