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
    public partial class frmThongTinSach : Form
    {
        ModifySach modifySach;
        Sach sach;
        public frmThongTinSach()
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

        public void resetData()
        {
            txtMaSach.Text = string.Empty;
            txtTenSach.Text = string.Empty;
            txtGiaSach.Text = string.Empty;
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

        private void frmThongTinSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_QuanLyThuVienDataSet.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.dB_QuanLyThuVienDataSet.Sach);
            // TODO: This line of code loads data into the 'dB_QuanLyThuVienDataSet.NhaXuatBan' table. You can move, or remove it, as needed.
            this.nhaXuatBanTableAdapter.Fill(this.dB_QuanLyThuVienDataSet.NhaXuatBan);
            // TODO: This line of code loads data into the 'dB_QuanLyThuVienDataSet.TheLoai' table. You can move, or remove it, as needed.
            this.theLoaiTableAdapter.Fill(this.dB_QuanLyThuVienDataSet.TheLoai);
            // TODO: This line of code loads data into the 'dB_QuanLyThuVienDataSet.TacGia' table. You can move, or remove it, as needed.
            this.tacGiaTableAdapter.Fill(this.dB_QuanLyThuVienDataSet.TacGia);

            loadData();
            modifySach = new ModifySach();
            try
            {
                dgvThongTinSach.DataSource = modifySach.getAllSach();
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
            txtMaSach.Text = modifySach.createID();

            btThem.Enabled = false;
            btXoa.Enabled = false;
            btLuu.Enabled = true;
            btSua.Text = "Hủy";
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa sách có mã số "
                + txtMaSach.Text + "",
                "Thông báo",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string id = dgvThongTinSach.SelectedRows[0].Cells[0].Value.ToString();

                if (modifySach.delete(id))
                {
                    frmThongTinSach_Load(sender, e);
                    resetData();
                }
                else
                {
                    MessageBox.Show("Không thể xóa sách này",
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
                if (txtTenSach.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Bạn chưa điền tên sách", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtGiaSach.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Bạn chưa điền giá", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string id = this.txtMaSach.Text;
                    string name = this.txtTenSach.Text;
                    double price = double.Parse(this.txtGiaSach.Text);
                    string tg_id = this.cboTacGia.SelectedValue.ToString();
                    string tl_id = this.cboTheLoai.SelectedValue.ToString();
                    string nxb_id = this.cboNhaXB.SelectedValue.ToString();

                    sach = new Sach(id, name, price, tg_id, tl_id, nxb_id);

                    if (modifySach.update(sach))
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None
                            );

                        frmThongTinSach_Load(sender, e);
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
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền tên sách", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtGiaSach.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền giá", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string id = this.txtMaSach.Text;
                string name = this.txtTenSach.Text;
                double price = double.Parse(this.txtGiaSach.Text);
                string tg_id = this.cboTacGia.SelectedValue.ToString();
                string tl_id = this.cboTheLoai.SelectedValue.ToString();
                string nxb_id = this.cboNhaXB.SelectedValue.ToString();

                sach = new Sach(id, name, price, tg_id, tl_id, nxb_id);

                if (modifySach.insert(sach))
                {
                    MessageBox.Show("Thêm sách thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None
                        );
                    frmThongTinSach_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không thể thêm sách",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }

        private void dgvThongTinSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData();

            int index = e.RowIndex;
            
            if(index >= 0)
            {
                DataGridViewRow rowActive = this.dgvThongTinSach.Rows[index];
                txtMaSach.Text = rowActive.Cells[0].Value.ToString();
                txtTenSach.Text = rowActive.Cells[1].Value.ToString();
                txtGiaSach.Text = rowActive.Cells[2].Value.ToString();

                string tacGiaText = modifySach.getTacGiaByID(rowActive.Cells[3].Value.ToString());
                cboTacGia.Text = tacGiaText;

                string theLoaiText = modifySach.getTheLoaiByID(rowActive.Cells[4].Value.ToString());
                cboTheLoai.Text = theLoaiText;

                string nxbText = modifySach.getNxbByID(rowActive.Cells[5].Value.ToString());
                cboNhaXB.Text = nxbText;
            }
        }

        private void txtGiaSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}