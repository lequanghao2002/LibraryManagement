
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
            this.components = new System.ComponentModel.Container();
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
            this.sachBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_QuanLyThuVienDataSet = new QLThuVien.DB_QuanLyThuVienDataSet();
            this.txtGiaSach = new System.Windows.Forms.TextBox();
            this.cboTacGia = new System.Windows.Forms.ComboBox();
            this.tacGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.theLoaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboNhaXB = new System.Windows.Forms.ComboBox();
            this.nhaXuatBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacGiaTableAdapter = new QLThuVien.DB_QuanLyThuVienDataSetTableAdapters.TacGiaTableAdapter();
            this.theLoaiTableAdapter = new QLThuVien.DB_QuanLyThuVienDataSetTableAdapters.TheLoaiTableAdapter();
            this.nhaXuatBanTableAdapter = new QLThuVien.DB_QuanLyThuVienDataSetTableAdapters.NhaXuatBanTableAdapter();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sachTableAdapter = new QLThuVien.DB_QuanLyThuVienDataSetTableAdapters.SachTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGiaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theLoaiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaXuatBanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QuanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaXuatBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(131, 56);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(160, 22);
            this.txtTenSach.TabIndex = 2;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(131, 18);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(160, 22);
            this.txtMaSach.TabIndex = 1;
            // 
            // lbNgayTao
            // 
            this.lbNgayTao.AutoSize = true;
            this.lbNgayTao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTao.Location = new System.Drawing.Point(393, 97);
            this.lbNgayTao.Name = "lbNgayTao";
            this.lbNgayTao.Size = new System.Drawing.Size(89, 16);
            this.lbNgayTao.TabIndex = 0;
            this.lbNgayTao.Text = "Nhà xuất bản:";
            // 
            // lbGiaSach
            // 
            this.lbGiaSach.AutoSize = true;
            this.lbGiaSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaSach.Location = new System.Drawing.Point(33, 97);
            this.lbGiaSach.Name = "lbGiaSach";
            this.lbGiaSach.Size = new System.Drawing.Size(64, 16);
            this.lbGiaSach.TabIndex = 0;
            this.lbGiaSach.Text = "Giá sách:";
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDienThoai.Location = new System.Drawing.Point(393, 59);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(57, 16);
            this.lbDienThoai.TabIndex = 0;
            this.lbDienThoai.Text = "Thể loại:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(33, 59);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(65, 16);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Tên sách:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(393, 21);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(54, 16);
            this.lbDiaChi.TabIndex = 0;
            this.lbDiaChi.Text = "Tác giả:";
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSach.Location = new System.Drawing.Point(33, 21);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(62, 16);
            this.lbMaSach.TabIndex = 0;
            this.lbMaSach.Text = "Mã sách:";
            // 
            // btThoat
            // 
            this.btThoat.AutoSize = true;
            this.btThoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Image = global::QLThuVien.Properties.Resources.icons8_close_24;
            this.btThoat.Location = new System.Drawing.Point(135, 393);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(89, 30);
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
            this.btQuayVe.Location = new System.Drawing.Point(25, 393);
            this.btQuayVe.Name = "btQuayVe";
            this.btQuayVe.Size = new System.Drawing.Size(89, 30);
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
            this.btLuu.Location = new System.Drawing.Point(585, 333);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 26);
            this.btLuu.TabIndex = 10;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btSua
            // 
            this.btSua.AutoSize = true;
            this.btSua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(585, 283);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 26);
            this.btSua.TabIndex = 9;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.AutoSize = true;
            this.btXoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(585, 233);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 26);
            this.btXoa.TabIndex = 8;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.AutoSize = true;
            this.btThem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(585, 183);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 26);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dgvThongTinSach
            // 
            this.dgvThongTinSach.AutoGenerateColumns = false;
            this.dgvThongTinSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinSach.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvThongTinSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.tacGiaIDDataGridViewTextBoxColumn,
            this.theLoaiIDDataGridViewTextBoxColumn,
            this.nhaXuatBanIDDataGridViewTextBoxColumn});
            this.dgvThongTinSach.DataSource = this.sachBindingSource1;
            this.dgvThongTinSach.Location = new System.Drawing.Point(25, 163);
            this.dgvThongTinSach.Name = "dgvThongTinSach";
            this.dgvThongTinSach.RowHeadersWidth = 51;
            this.dgvThongTinSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongTinSach.Size = new System.Drawing.Size(520, 200);
            this.dgvThongTinSach.TabIndex = 11;
            this.dgvThongTinSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinSach_CellClick);
            // 
            // sachBindingSource1
            // 
            this.sachBindingSource1.DataMember = "Sach";
            this.sachBindingSource1.DataSource = this.dB_QuanLyThuVienDataSet;
            // 
            // dB_QuanLyThuVienDataSet
            // 
            this.dB_QuanLyThuVienDataSet.DataSetName = "DB_QuanLyThuVienDataSet";
            this.dB_QuanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtGiaSach
            // 
            this.txtGiaSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaSach.Location = new System.Drawing.Point(131, 94);
            this.txtGiaSach.Name = "txtGiaSach";
            this.txtGiaSach.Size = new System.Drawing.Size(160, 22);
            this.txtGiaSach.TabIndex = 3;
            this.txtGiaSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaSach_KeyPress);
            // 
            // cboTacGia
            // 
            this.cboTacGia.DataSource = this.tacGiaBindingSource;
            this.cboTacGia.DisplayMember = "HoTen";
            this.cboTacGia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTacGia.FormattingEnabled = true;
            this.cboTacGia.Location = new System.Drawing.Point(491, 17);
            this.cboTacGia.Name = "cboTacGia";
            this.cboTacGia.Size = new System.Drawing.Size(160, 24);
            this.cboTacGia.TabIndex = 4;
            this.cboTacGia.ValueMember = "ID";
            // 
            // tacGiaBindingSource
            // 
            this.tacGiaBindingSource.DataMember = "TacGia";
            this.tacGiaBindingSource.DataSource = this.dB_QuanLyThuVienDataSet;
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.DataSource = this.theLoaiBindingSource;
            this.cboTheLoai.DisplayMember = "Ten";
            this.cboTheLoai.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(491, 55);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(160, 24);
            this.cboTheLoai.TabIndex = 5;
            this.cboTheLoai.ValueMember = "ID";
            // 
            // theLoaiBindingSource
            // 
            this.theLoaiBindingSource.DataMember = "TheLoai";
            this.theLoaiBindingSource.DataSource = this.dB_QuanLyThuVienDataSet;
            // 
            // cboNhaXB
            // 
            this.cboNhaXB.DataSource = this.nhaXuatBanBindingSource;
            this.cboNhaXB.DisplayMember = "Ten";
            this.cboNhaXB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhaXB.FormattingEnabled = true;
            this.cboNhaXB.Location = new System.Drawing.Point(491, 93);
            this.cboNhaXB.Name = "cboNhaXB";
            this.cboNhaXB.Size = new System.Drawing.Size(160, 24);
            this.cboNhaXB.TabIndex = 6;
            this.cboNhaXB.ValueMember = "ID";
            // 
            // nhaXuatBanBindingSource
            // 
            this.nhaXuatBanBindingSource.DataMember = "NhaXuatBan";
            this.nhaXuatBanBindingSource.DataSource = this.dB_QuanLyThuVienDataSet;
            // 
            // tacGiaTableAdapter
            // 
            this.tacGiaTableAdapter.ClearBeforeFill = true;
            // 
            // theLoaiTableAdapter
            // 
            this.theLoaiTableAdapter.ClearBeforeFill = true;
            // 
            // nhaXuatBanTableAdapter
            // 
            this.nhaXuatBanTableAdapter.ClearBeforeFill = true;
            // 
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "Sach";
            this.sachBindingSource.DataSource = this.dB_QuanLyThuVienDataSet;
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Mã Sách";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 80;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên Sách";
            this.tenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.Width = 120;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.giaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            this.giaDataGridViewTextBoxColumn.Width = 80;
            // 
            // tacGiaIDDataGridViewTextBoxColumn
            // 
            this.tacGiaIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tacGiaIDDataGridViewTextBoxColumn.DataPropertyName = "TacGia_ID";
            this.tacGiaIDDataGridViewTextBoxColumn.HeaderText = "Mã Tác Giả";
            this.tacGiaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tacGiaIDDataGridViewTextBoxColumn.Name = "tacGiaIDDataGridViewTextBoxColumn";
            this.tacGiaIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // theLoaiIDDataGridViewTextBoxColumn
            // 
            this.theLoaiIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.theLoaiIDDataGridViewTextBoxColumn.DataPropertyName = "TheLoai_ID";
            this.theLoaiIDDataGridViewTextBoxColumn.HeaderText = "Mã Thể Loại";
            this.theLoaiIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.theLoaiIDDataGridViewTextBoxColumn.Name = "theLoaiIDDataGridViewTextBoxColumn";
            this.theLoaiIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // nhaXuatBanIDDataGridViewTextBoxColumn
            // 
            this.nhaXuatBanIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nhaXuatBanIDDataGridViewTextBoxColumn.DataPropertyName = "NhaXuatBan_ID";
            this.nhaXuatBanIDDataGridViewTextBoxColumn.HeaderText = "Mã NXB";
            this.nhaXuatBanIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nhaXuatBanIDDataGridViewTextBoxColumn.Name = "nhaXuatBanIDDataGridViewTextBoxColumn";
            this.nhaXuatBanIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // frmThongTinSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(684, 441);
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
            this.Name = "frmThongTinSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sách";
            this.Load += new System.EventHandler(this.frmThongTinSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QuanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaXuatBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
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
        private DB_QuanLyThuVienDataSet dB_QuanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource tacGiaBindingSource;
        private DB_QuanLyThuVienDataSetTableAdapters.TacGiaTableAdapter tacGiaTableAdapter;
        private System.Windows.Forms.BindingSource theLoaiBindingSource;
        private DB_QuanLyThuVienDataSetTableAdapters.TheLoaiTableAdapter theLoaiTableAdapter;
        private System.Windows.Forms.BindingSource nhaXuatBanBindingSource;
        private DB_QuanLyThuVienDataSetTableAdapters.NhaXuatBanTableAdapter nhaXuatBanTableAdapter;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private DB_QuanLyThuVienDataSetTableAdapters.SachTableAdapter sachTableAdapter;
        private System.Windows.Forms.BindingSource sachBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacGiaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theLoaiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaXuatBanIDDataGridViewTextBoxColumn;
    }
}