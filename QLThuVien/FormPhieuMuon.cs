using QLThuVien.Model;
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
    public partial class frmPhieuMuon : Form
    {
        ModifyPhieuMuon modifyPhieuMuon;
        PhieuMuon phieuMuon;

        ModifyCTPhieuMuon modifyCTPhieuMuon;
        CTPhieuMuon cTPhieuMuon;
        public frmPhieuMuon()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            btThem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btLuu.Enabled = false;

            btSua.Text = "Sửa";
        }
        public void loadData2()
        {
            btMuon.Enabled = true;
            btGiaHan.Enabled = true;
            btTraSach.Enabled = true;
            btLuu2.Enabled = false;

            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;
            dtpNgayTra.Text = dtpNgayMuon.Value.AddDays(7).ToString();

            btGiaHan.Text = "Gia Hạn";
        }

        public void resetData()
        {
            txtMaPM.Text = string.Empty;
        }

        public void resetData2()
        {
            txtGhiChu.Text = string.Empty;
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;
            dtpNgayTra.Text = dtpNgayMuon.Value.AddDays(7).ToString();
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

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_QuanLyThuVienDataSet.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.dB_QuanLyThuVienDataSet.Sach);
            // TODO: This line of code loads data into the 'dB_QuanLyThuVienDataSet.CTPhieuMuon' table. You can move, or remove it, as needed.
            this.cTPhieuMuonTableAdapter.Fill(this.dB_QuanLyThuVienDataSet.CTPhieuMuon);
            // TODO: This line of code loads data into the 'dB_QuanLyThuVienDataSet.PhieuMuon' table. You can move, or remove it, as needed.
            this.phieuMuonTableAdapter.Fill(this.dB_QuanLyThuVienDataSet.PhieuMuon);
            // TODO: This line of code loads data into the 'dB_QuanLyThuVienDataSet.DocGia' table. You can move, or remove it, as needed.
            this.docGiaTableAdapter.Fill(this.dB_QuanLyThuVienDataSet.DocGia);

            loadData();
            loadData2();

            modifyPhieuMuon = new ModifyPhieuMuon();
            modifyCTPhieuMuon = new ModifyCTPhieuMuon();

            try
            {
                dgvTaoPM.DataSource = modifyPhieuMuon.getAllPhieuMuon();
                dgvChiTietPM.DataSource = modifyCTPhieuMuon.getAllCTPhieuMuon();
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

        private void btThem_Click(object sender, EventArgs e)
        {
            resetData();
            txtMaPM.Text = modifyPhieuMuon.createID();

            btThem.Enabled = false;
            btXoa.Enabled = false;
            btLuu.Enabled = true;
            btSua.Text = "Hủy";
        }

        private void btMuon_Click(object sender, EventArgs e)
        {
            resetData2();

            btMuon.Enabled = false;
            btTraSach.Enabled = false;
            btLuu2.Enabled = true;
            btGiaHan.Text = "Hủy";
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa phiếu mượn có mã số "
                + txtMaPM.Text + "",
                "Thông báo",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string id = dgvTaoPM.SelectedRows[0].Cells[0].Value.ToString();

                if (modifyPhieuMuon.delete(id))
                {
                    frmPhieuMuon_Load(sender, e);
                    resetData();
                }
                else
                {
                    MessageBox.Show("Không thể xóa phiếu mượn này",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }

        private void btTraSach_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận trả sách có mã số "
                + dgvChiTietPM.SelectedRows[0].Cells[1].Value.ToString() + " của mã phiếu mượn: " + dgvChiTietPM.SelectedRows[0].Cells[0].Value.ToString(),
                "Thông báo",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string idPhieuMuon = dgvChiTietPM.SelectedRows[0].Cells[0].Value.ToString();
                string idSach = dgvChiTietPM.SelectedRows[0].Cells[1].Value.ToString();

                if (modifyCTPhieuMuon.delete(idPhieuMuon, idSach))
                {
                    MessageBox.Show("Trả sách thành công", "Thông báo");
                    frmPhieuMuon_Load(sender, e);
                    resetData2();
                }
                else
                {
                    MessageBox.Show("Không thể trả sách này",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (btSua.Text == "Hủy")
            {
                resetData();

                btThem.Enabled = true;
                btSua.Text = "Sửa";
                btXoa.Enabled = true;
                btLuu.Enabled = false;
            }
            else
            {
                string id = this.txtMaPM.Text;
                string dg_id = this.cboMaDG.SelectedValue.ToString();

                phieuMuon = new PhieuMuon(id, dg_id);

                if (modifyPhieuMuon.update(phieuMuon))
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None
                        );

                    frmPhieuMuon_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật dữ liệu",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }

        //hhh
        private void btGiaHan_Click(object sender, EventArgs e)
        {
            if (btGiaHan.Text == "Hủy")
            {
                resetData2();

                btMuon.Enabled = true;
                btGiaHan.Text = "Sửa";
                btTraSach.Enabled = true;
                btLuu2.Enabled = false;
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "Xác nhận gia hạn mã sách " + cboMaSach.Text + " của mã phiếu mượn " + cboMaPM.Text + " thêm 7 ngày",
                    "Thông báo",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DateTime giaHan2 = (DateTime)dgvChiTietPM.SelectedRows[0].Cells[3].Value;

                    //DateTime giaHan = dtpNgayTra.Value.AddDays(7);
                    DateTime giaHan = giaHan2.AddDays(7);
                    string id_sach = cboMaSach.Text;
                    string id_phieuMuon = cboMaPM.Text;

                    if (modifyCTPhieuMuon.update(giaHan, id_sach, id_phieuMuon))
                    {
                        MessageBox.Show("Gia hạn thành công",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None
                            );

                        frmPhieuMuon_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không thể gia hạn",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                    }
                }
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {

            string id = this.txtMaPM.Text;
            string dg_id = this.cboMaDG.SelectedValue.ToString();

            phieuMuon = new PhieuMuon(id, dg_id);

            if (modifyPhieuMuon.insert(phieuMuon))
            {
                MessageBox.Show("Thêm phiếu mượn thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None
                    );
                frmPhieuMuon_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không thể thêm phiếu mượn",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void btLuu2_Click(object sender, EventArgs e)
        {
            

            string pm_id = this.cboMaPM.Text;
            string s_id = this.cboMaSach.Text;
            DateTime borrowingDate = dtpNgayMuon.Value;
            DateTime appointmentDate = dtpNgayTra.Value;
            string note = txtGhiChu.Text;

            cTPhieuMuon = new CTPhieuMuon(pm_id, s_id, borrowingDate, appointmentDate, note);

            if (modifyCTPhieuMuon.checkMuonSach(pm_id) == false)
            {
                MessageBox.Show("Mỗi độc giả chỉ được mượn tối đa 3 quyển sách",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None
                    );
                frmPhieuMuon_Load(sender, e);

            }
            else if (modifyCTPhieuMuon.insert(cTPhieuMuon))
            {
                MessageBox.Show("Mượn sách thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None
                    );

                frmPhieuMuon_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không thể mượn sách",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void dgvTaoPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData();

            int index = e.RowIndex;

            if (index >= 0)
            {
                DataGridViewRow rowActive = this.dgvTaoPM.Rows[index];
                txtMaPM.Text = rowActive.Cells[0].Value.ToString();

                cboMaDG.Text = rowActive.Cells[1].Value.ToString();

                string docGiaText = modifyPhieuMuon.getDocGiaByID(rowActive.Cells[1].Value.ToString());
                cboTenDG.Text = docGiaText;
            }
        }

        private void dtpNgayMuon_ValueChanged(object sender, EventArgs e)
        {
            dtpNgayTra.Text = dtpNgayMuon.Value.AddDays(7).ToString();

        }

        private void dgvChiTietPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData2();

            int index = e.RowIndex;

            if (index >= 0)
            {
                DataGridViewRow rowActive = this.dgvChiTietPM.Rows[index];
                cboMaPM.Text = rowActive.Cells[0].Value.ToString();

                cboMaSach.Text = rowActive.Cells[1].Value.ToString();

                string sachText = modifyCTPhieuMuon.getSachByID(rowActive.Cells[1].Value.ToString());
                cboTenSach.Text = sachText;

                dtpNgayMuon.Text = rowActive.Cells[2].Value.ToString();
                dtpNgayTra.Text = rowActive.Cells[3].Value.ToString();

                txtGhiChu.Text = rowActive.Cells[4].Value.ToString();
            }
        }
    }
}