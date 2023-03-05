
namespace QLThuVien
{
    partial class frmThongTinSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.lbNgayTao = new System.Windows.Forms.Label();
            this.lbGiaSach = new System.Windows.Forms.Label();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbMaSach = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btQuayVe = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvThongTinSach = new System.Windows.Forms.DataGridView();
            this.txtGiaSach = new System.Windows.Forms.TextBox();
            this.cboTacGia = new System.Windows.Forms.ComboBox();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.cboNhaXB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSach)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(175, 69);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(212, 26);
            this.txtTenSach.TabIndex = 2;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(175, 22);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(212, 26);
            this.txtMaSach.TabIndex = 1;
            // 
            // lbNgayTao
            // 
            this.lbNgayTao.AutoSize = true;
            this.lbNgayTao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTao.Location = new System.Drawing.Point(524, 119);
            this.lbNgayTao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayTao.Name = "lbNgayTao";
            this.lbNgayTao.Size = new System.Drawing.Size(109, 19);
            this.lbNgayTao.TabIndex = 0;
            this.lbNgayTao.Text = "Nhà xuất bản:";
            // 
            // lbGiaSach
            // 
            this.lbGiaSach.AutoSize = true;
            this.lbGiaSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaSach.Location = new System.Drawing.Point(44, 119);
            this.lbGiaSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGiaSach.Name = "lbGiaSach";
            this.lbGiaSach.Size = new System.Drawing.Size(79, 19);
            this.lbGiaSach.TabIndex = 0;
            this.lbGiaSach.Text = "Giá sách:";
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDienThoai.Location = new System.Drawing.Point(524, 73);
            this.lbDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(71, 19);
            this.lbDienThoai.TabIndex = 0;
            this.lbDienThoai.Text = "Thể loại:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(44, 73);
            this.lbHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(81, 19);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Tên sách:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(524, 26);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(68, 19);
            this.lbDiaChi.TabIndex = 0;
            this.lbDiaChi.Text = "Tác giả:";
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSach.Location = new System.Drawing.Point(44, 26);
            this.lbMaSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(76, 19);
            this.lbMaSach.TabIndex = 0;
            this.lbMaSach.Text = "Mã sách:";
            // 
            // btThoat
            // 
            this.btThoat.AutoSize = true;
            this.btThoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Image = global::QLThuVien.Properties.Resources.icons8_close_24;
            this.btThoat.Location = new System.Drawing.Point(180, 484);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(119, 37);
            this.btThoat.TabIndex = 13;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btQuayVe
            // 
            this.btQuayVe.AutoSize = true;
            this.btQuayVe.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuayVe.Image = global::QLThuVien.Properties.Resources.icons8_left_24;
            this.btQuayVe.Location = new System.Drawing.Point(33, 484);
            this.btQuayVe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQuayVe.Name = "btQuayVe";
            this.btQuayVe.Size = new System.Drawing.Size(119, 37);
            this.btQuayVe.TabIndex = 12;
            this.btQuayVe.Text = "Quay về";
            this.btQuayVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuayVe.UseVisualStyleBackColor = true;
            this.btQuayVe.Click += new System.EventHandler(this.btQuayVe_Click);
            // 
            // btLuu
            // 
            this.btLuu.AutoSize = true;
            this.btLuu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(780, 410);
            this.btLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(100, 32);
            this.btLuu.TabIndex = 10;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.AutoSize = true;
            this.btSua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(780, 348);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 32);
            this.btSua.TabIndex = 9;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.AutoSize = true;
            this.btXoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(780, 287);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 32);
            this.btXoa.TabIndex = 8;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.AutoSize = true;
            this.btThem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(780, 225);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 32);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // dgvThongTinSach
            // 
            this.dgvThongTinSach.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvThongTinSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinSach.Location = new System.Drawing.Point(33, 201);
            this.dgvThongTinSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvThongTinSach.Name = "dgvThongTinSach";
            this.dgvThongTinSach.RowHeadersWidth = 51;
            this.dgvThongTinSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongTinSach.Size = new System.Drawing.Size(693, 246);
            this.dgvThongTinSach.TabIndex = 11;
            // 
            // txtGiaSach
            // 
            this.txtGiaSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaSach.Location = new System.Drawing.Point(175, 116);
            this.txtGiaSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGiaSach.Name = "txtGiaSach";
            this.txtGiaSach.Size = new System.Drawing.Size(212, 26);
            this.txtGiaSach.TabIndex = 3;
            // 
            // cboTacGia
            // 
            this.cboTacGia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTacGia.FormattingEnabled = true;
            this.cboTacGia.Location = new System.Drawing.Point(655, 21);
            this.cboTacGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTacGia.Name = "cboTacGia";
            this.cboTacGia.Size = new System.Drawing.Size(212, 26);
            this.cboTacGia.TabIndex = 4;
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(655, 68);
            this.cboTheLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(212, 26);
            this.cboTheLoai.TabIndex = 5;
            // 
            // cboNhaXB
            // 
            this.cboNhaXB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhaXB.FormattingEnabled = true;
            this.cboNhaXB.Location = new System.Drawing.Point(655, 114);
            this.cboNhaXB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNhaXB.Name = "cboNhaXB";
            this.cboNhaXB.Size = new System.Drawing.Size(212, 26);
            this.cboNhaXB.TabIndex = 6;
            // 
            // frmThongTinSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(912, 543);
            this.Controls.Add(this.cboNhaXB);
            this.Controls.Add(this.cboTheLoai);
            this.Controls.Add(this.cboTacGia);
            this.Controls.Add(this.txtGiaSach);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.lbNgayTao);
            this.Controls.Add(this.lbGiaSach);
            this.Controls.Add(this.lbDienThoai);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbMaSach);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btQuayVe);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dgvThongTinSach);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmThongTinSach";
            this.Text = "Thông tin sách";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label lbNgayTao;
        private System.Windows.Forms.Label lbGiaSach;
        private System.Windows.Forms.Label lbDienThoai;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbMaSach;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btQuayVe;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgvThongTinSach;
        private System.Windows.Forms.TextBox txtGiaSach;
        private System.Windows.Forms.ComboBox cboTacGia;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.ComboBox cboNhaXB;
    }
}