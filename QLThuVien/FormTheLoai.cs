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
    public partial class frmTheLoai : Form
    {
        ModifyTheLoai modifyTheLoai;
        TheLoai theLoai;
        public frmTheLoai()
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
            txtMaTL.Text = string.Empty;
            txtTenTL.Text = string.Empty;
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

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_QuanLyThuVienDataSet.TheLoai' table. You can move, or remove it, as needed.
            this.theLoaiTableAdapter.Fill(this.dB_QuanLyThuVienDataSet.TheLoai);
            loadData();

            modifyTheLoai = new ModifyTheLoai();
            try
            {
                dgvTheLoai.DataSource = modifyTheLoai.getAllTheLoai();
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
            txtMaTL.Text = modifyTheLoai.createID();

            btThem.Enabled = false;
            btXoa.Enabled = false;
            btLuu.Enabled = true;
            btSua.Text = "Hủy";
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa thể loại có mã số "
                + txtMaTL.Text + "",
                "Thông báo",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string id = dgvTheLoai.SelectedRows[0].Cells[0].Value.ToString();

                if (modifyTheLoai.delete(id))
                {
                    frmTheLoai_Load(sender, e);
                    resetData();
                }
                else
                {
                    MessageBox.Show("Không thể xóa thể loại này",
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
                if (txtTenTL.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Bạn chưa điền tên thể loại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string id = this.txtMaTL.Text;
                    string name = this.txtTenTL.Text;

                    theLoai = new TheLoai(id, name);

                    if (modifyTheLoai.update(theLoai))
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None
                            );

                        frmTheLoai_Load(sender, e);
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
            if (txtTenTL.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền họ tên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string id = this.txtMaTL.Text;
                string name = this.txtTenTL.Text;

                theLoai = new TheLoai(id, name);

                if (modifyTheLoai.insert(theLoai))
                {
                    MessageBox.Show("Thêm thể loại thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None
                        );
                    frmTheLoai_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không thể thêm thể loại",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }

        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData();

            int index = e.RowIndex;
            
            if(index >= 0 )
            {
                DataGridViewRow rowActive = this.dgvTheLoai.Rows[index];
                txtMaTL.Text = rowActive.Cells[0].Value.ToString();
                txtTenTL.Text = rowActive.Cells[1].Value.ToString();
            }
        }
    }
}
