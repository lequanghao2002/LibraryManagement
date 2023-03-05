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
    public partial class FormTimKiemPhieuMuon : Form
    {
        ModifyCTPhieuMuon modifyCTPhieuMuon;
        public FormTimKiemPhieuMuon()
        {
            InitializeComponent();
        }

        private void FormTimKiemPhieuMuon_Load(object sender, EventArgs e, string id = null)
        {
            // TODO: This line of code loads data into the 'dB_QuanLyThuVienDataSet.CTPhieuMuon' table. You can move, or remove it, as needed.
            //this.cTPhieuMuonTableAdapter.Fill(this.dB_QuanLyThuVienDataSet.CTPhieuMuon);

            modifyCTPhieuMuon = new ModifyCTPhieuMuon();

            try
            {
                dgvTimKiemPhieuMuon.DataSource = modifyCTPhieuMuon.getAllCTPhieuMuonTheoDG(id);
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

        private void btTim_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Bạn cần điền mã độc giả để tìm kiếm", "Thông báo");
            }
            else
            {
                string idDG = txtTimKiem.Text;
                FormTimKiemPhieuMuon_Load(sender, e, idDG);

                if(modifyCTPhieuMuon.getAllCTPhieuMuonTheoDG(idDG).Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy mã độc giả: " + idDG, "Thông báo");
                }
                else
                {
                    FormTimKiemPhieuMuon_Load(sender, e, idDG);
                }
            }
        }

        private void FormTimKiemPhieuMuon_Load(object sender, EventArgs e)
        {
            modifyCTPhieuMuon = new ModifyCTPhieuMuon();
        }
    }
}
