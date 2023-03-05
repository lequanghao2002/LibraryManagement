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
    public partial class frmThongTinDG : Form
    {
        ModifyDocGia modifyDocGia;
        DocGia docGia;
        public frmThongTinDG()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            btThem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btLuu.Enabled = false;
            dtpNgaySinh.Value = DateTime.Now;
            dtpNgayTao.Value = DateTime.Now;
            dtpNgayHet.Text = dtpNgayTao.Value.AddYears(1).ToString();

            btSua.Text = "Sửa";
        }

        public void resetData() {
            txtMaDG.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            dtpNgaySinh.Value = DateTime.Now;
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            txtDiaChi.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            dtpNgayTao.Value = DateTime.Now;
        }

        private void frmThongTinDG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_QuanLyThuVienDataSet.DocGia' table. You can move, or remove it, as needed.
            this.docGiaTableAdapter.Fill(this.dB_QuanLyThuVienDataSet.DocGia);
            loadData();

            modifyDocGia = new ModifyDocGia();
            try
            {
                dgvThongTinDG.DataSource = modifyDocGia.getAllDocGia();
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
        private void btThem_Click(object sender, EventArgs e)
        {
            resetData();
            txtMaDG.Text = modifyDocGia.createID(); 

            btThem.Enabled = false;
            btXoa.Enabled = false;
            btLuu.Enabled = true;
            btSua.Text = "Hủy";
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa độc giả có mã số " 
                + txtMaDG.Text + "", 
                "Thông báo", 
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string id = dgvThongTinDG.SelectedRows[0].Cells[0].Value.ToString();

                if (modifyDocGia.delete(id))
                {
                    frmThongTinDG_Load(sender, e);
                    resetData();
                }
                else
                {
                    MessageBox.Show("Không thể xóa độc giả",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            if(btSua.Text == "Hủy")
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
                else if (dtpNgaySinh.Value.Year > DateTime.Now.Year)
                {
                    MessageBox.Show("Bạn điền ngày sinh không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if ((DateTime.Now.Year - dtpNgaySinh.Value.Year) < 16)
                {
                    MessageBox.Show("Tuổi phải >= 16 mới được tạo thẻ độc giả", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (rdoNam.Checked == false && rdoNu.Checked == false)
                {
                    MessageBox.Show("Bạn chưa chọn giới tính", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    string id = this.txtMaDG.Text;
                    string name = this.txtHoTen.Text;
                    DateTime dateOfBirth = this.dtpNgaySinh.Value;
                    string sex = (rdoNam.Checked ? rdoNam.Text : rdoNu.Text);
                    string address = this.txtDiaChi.Text;
                    string phoneNumber = this.txtDienThoai.Text;
                    DateTime dateCreated = this.dtpNgayTao.Value;
                    DateTime dateExpiration = this.dtpNgayHet.Value;

                    docGia = new DocGia(id, name, dateOfBirth, sex, address, phoneNumber, dateCreated, dateExpiration);

                    if (modifyDocGia.update(docGia))
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None
                            );

                        frmThongTinDG_Load(sender, e);
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

        private bool checkDateTime()
        {
            if (dtpNgaySinh.Value.Year > DateTime.Now.Year)
            {
                return false; 
            }
            else if (dtpNgaySinh.Value.Year < DateTime.Now.Year)
            {
                return true;
            }
            else
            {
                if (dtpNgaySinh.Value.Month > DateTime.Now.Month)
                {
                    return false;
                }
                else if (dtpNgaySinh.Value.Month < DateTime.Now.Month)
                {
                    return true;
                }
                else
                {
                    if (dtpNgaySinh.Value.Day > DateTime.Now.Day)
                    {
                        return false;
                    }
                    else if (dtpNgaySinh.Value.Day < DateTime.Now.Day)
                    {
                        return true;
                    }
                    else
                    {
                        return true;
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
            else if (checkDateTime() == false)
            {
                MessageBox.Show("Bạn điền ngày sinh không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((DateTime.Now.Year - dtpNgaySinh.Value.Year) < 16)
            {
                MessageBox.Show("Tuổi phải >= 16", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rdoNam.Checked == false && rdoNu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string id = this.txtMaDG.Text;
                string name = this.txtHoTen.Text;
                DateTime dateOfBirth = this.dtpNgaySinh.Value;
                string sex = (rdoNam.Checked ? rdoNam.Text : rdoNu.Text);
                string address = this.txtDiaChi.Text;
                string phoneNumber = this.txtDienThoai.Text;
                DateTime dateCreated = this.dtpNgayTao.Value;
                DateTime dateExpiration = this.dtpNgayHet.Value;

                docGia = new DocGia(id, name, dateOfBirth, sex, address, phoneNumber, dateCreated, dateExpiration);

                if (modifyDocGia.insert(docGia))
                {
                    MessageBox.Show("Thêm độc giả thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None
                        );
                    frmThongTinDG_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không thể thêm độc giả",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult ThongBaoThoat;
            ThongBaoThoat = (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (ThongBaoThoat == DialogResult.Yes)
                Application.Exit();
        }
        private void dtpNgayTao_ValueChanged(object sender, EventArgs e)
        {
            dtpNgayHet.Text = dtpNgayTao.Value.AddYears(1).ToString();
        }
        private void dgvThongTinDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData();

            int index = e.RowIndex;

            if (index >= 0)
            {
                DataGridViewRow rowActive = this.dgvThongTinDG.Rows[index];
                txtMaDG.Text = rowActive.Cells[0].Value.ToString();
                txtHoTen.Text = rowActive.Cells[1].Value.ToString();
                dtpNgaySinh.Text = rowActive.Cells[2].Value.ToString();
                if (rowActive.Cells[3].Value.ToString() == "Nam")
                {
                    rdoNam.Checked = true;
                    rdoNu.Checked = false;
                }
                else
                {
                    rdoNu.Checked = true;
                    rdoNam.Checked = false;
                }
                txtDiaChi.Text = rowActive.Cells[4].Value.ToString();
                txtDienThoai.Text = rowActive.Cells[5].Value.ToString();
                dtpNgayTao.Text = rowActive.Cells[6].Value.ToString();
                dtpNgayHet.Text = rowActive.Cells[7].Value.ToString();
            }
        }
        private void txtDienThoai_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}