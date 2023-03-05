using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmThongTinDG : Form
    {

        Modify modify;
        public frmThongTinDG()
        {
            InitializeComponent();
        }

        private void frmThongTinDG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_QuanLyThuVienDataSet.DocGia' table. You can move, or remove it, as needed.
            this.docGiaTableAdapter.Fill(this.dB_QuanLyThuVienDataSet.DocGia);
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgayTao.Format = DateTimePickerFormat.Time;
            dtpNgayHet.Format = DateTimePickerFormat.Short;

            modify = new Modify();
            try
            {
                dgvThongTinDG.DataSource = modify.getAllDocGia();
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

        private void btThem_Click(object sender, EventArgs e)
        {
            
        }
    }
}