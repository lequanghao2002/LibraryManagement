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
    public partial class frmThongTinTG : Form
    {
        ModifyTacGia modifyTacGia;
        TacGia tacGia;

        public frmThongTinTG()
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
            txtMaTG.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
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

        private void frmThongTinTG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_QuanLyThuVienDataSet.TacGia' table. You can move, or remove it, as needed.
            this.tacGiaTableAdapter.Fill(this.dB_QuanLyThuVienDataSet.TacGia);
            loadData();

            modifyTacGia = new ModifyTacGia();
            try
            {
                dgvThongTinTG.DataSource = modifyTacGia.getAllTacGia();
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
            txtMaTG.Text = modifyTacGia.createID();

            btThem.Enabled = false;
            btXoa.Enabled = false;
            btLuu.Enabled = true;
            btSua.Text = "Hủy";
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa tác giả có mã số "
                + txtMaTG.Text + "",
                "Thông báo",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string id = dgvThongTinTG.SelectedRows[0].Cells[0].Value.ToString();

                if (modifyTacGia.delete(id))
                {
                    frmThongTinTG_Load(sender, e);
                    resetData();
                }
                else
                {
                    MessageBox.Show("Không thể xóa tác giả này",
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
                if (txtHoTen.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Bạn chưa điền họ tên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtDiaChi.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Bạn chưa điền địa chỉ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtDienThoai.Text == string.Empty)
                {
                    MessageBox.Show("Bạn chưa điền số điện thoại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtDienThoai.Text.Length < 10 || txtDienThoai.Text.Length > 11)
                {
                    MessageBox.Show("Bạn điền số điện thoại không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string id = this.txtMaTG.Text;
                    string name = this.txtHoTen.Text;
                    string address = this.txtDiaChi.Text;
                    string phoneNumber = this.txtDienThoai.Text;

                    tacGia = new TacGia(id, name, address, phoneNumber);

                    if (modifyTacGia.update(tacGia))
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None
                            );

                        frmThongTinTG_Load(sender, e);
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
            if (txtHoTen.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền họ tên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtDiaChi.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền địa chỉ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtDienThoai.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền số điện thoại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtDienThoai.Text.Length < 10 || txtDienThoai.Text.Length > 11)
            {
                MessageBox.Show("Bạn điền số điện thoại không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string id = this.txtMaTG.Text;
                string name = this.txtHoTen.Text;
                string address = this.txtDiaChi.Text;
                string phoneNumber = this.txtDienThoai.Text;

                tacGia = new TacGia(id, name,address, phoneNumber);

                if (modifyTacGia.insert(tacGia))
                {
                    MessageBox.Show("Thêm tác giả thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None
                        );
                    frmThongTinTG_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không thể thêm tác giả",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }

        private void dgvThongTinTG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData();

            int index = e.RowIndex;
            
            if(index >= 0)
            {
                DataGridViewRow rowActive = this.dgvThongTinTG.Rows[index];
                txtMaTG.Text = rowActive.Cells[0].Value.ToString();
                txtHoTen.Text = rowActive.Cells[1].Value.ToString();
                txtDiaChi.Text = rowActive.Cells[2].Value.ToString();
                txtDienThoai.Text = rowActive.Cells[3].Value.ToString();
            }
            
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}