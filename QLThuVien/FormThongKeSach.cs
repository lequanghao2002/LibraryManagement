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
    public partial class frmThongKeSach : Form
    {
        ModifySach modifySach;
        public frmThongKeSach()
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

        private void frmThongKeSach_Load(object sender, EventArgs e, int check)
        {
            // TODO: This line of code loads data into the 'dB_QuanLyThuVienDataSet.Sach' table. You can move, or remove it, as needed.
            //this.sachTableAdapter.Fill(this.dB_QuanLyThuVienDataSet.Sach);
            modifySach = new ModifySach();
            try
            {
                if(check == 1)
                {
                    dgvThongKeSach.DataSource = modifySach.getAllSachDangMuon();
                }
                else if (check == 2)
                {
                    dgvThongKeSach.DataSource = modifySach.getAllSachTreHan();
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

        private void btThongKe_Click(object sender, EventArgs e)
        {
            if(cboThongKe.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn loại thống kê");
            }
            else if(cboThongKe.Text == "Sách đang mượn")
            {
                frmThongKeSach_Load(sender, e, 1);
            }
            else if (cboThongKe.Text == "Sách trễ hạn")
            {
                frmThongKeSach_Load(sender, e, 2);
            }
        }
    }
}