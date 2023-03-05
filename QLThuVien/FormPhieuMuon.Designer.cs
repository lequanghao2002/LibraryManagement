
namespace QLThuVien
{
    partial class frmPhieuMuon
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
            this.tcPhieuMuon = new System.Windows.Forms.TabControl();
            this.tpTaoPhieu = new System.Windows.Forms.TabPage();
            this.cboTenDG = new System.Windows.Forms.ComboBox();
            this.docGiaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_QuanLyThuVienDataSet = new QLThuVien.DB_QuanLyThuVienDataSet();
            this.cboMaDG = new System.Windows.Forms.ComboBox();
            this.btLuu = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvTaoPM = new System.Windows.Forms.DataGridView();
            this.phieuMuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.lbNgayMuon = new System.Windows.Forms.Label();
            this.lbMaDG = new System.Windows.Forms.Label();
            this.lbMaPM1 = new System.Windows.Forms.Label();
            this.tpChiTieuPhieu = new System.Windows.Forms.TabPage();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btLuu2 = new System.Windows.Forms.Button();
            this.btGiaHan = new System.Windows.Forms.Button();
            this.btTraSach = new System.Windows.Forms.Button();
            this.btMuon = new System.Windows.Forms.Button();
            this.dgvChiTietPM = new System.Windows.Forms.DataGridView();
            this.phieuMuonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sachIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTPhieuMuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.cboMaPM = new System.Windows.Forms.ComboBox();
            this.cboTenSach = new System.Windows.Forms.ComboBox();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboMaSach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNgayTra = new System.Windows.Forms.Label();
            this.lbMaSach = new System.Windows.Forms.Label();
            this.lbMaPM2 = new System.Windows.Forms.Label();
            this.phieuMuonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.docGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btThoat = new System.Windows.Forms.Button();
            this.btQuayVe = new System.Windows.Forms.Button();
            this.docGiaTableAdapter = new QLThuVien.DB_QuanLyThuVienDataSetTableAdapters.DocGiaTableAdapter();
            this.phieuMuonTableAdapter = new QLThuVien.DB_QuanLyThuVienDataSetTableAdapters.PhieuMuonTableAdapter();
            this.fKPhieuMuonDocGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTPhieuMuonTableAdapter = new QLThuVien.DB_QuanLyThuVienDataSetTableAdapters.CTPhieuMuonTableAdapter();
            this.cTPhieuMuonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sachTableAdapter = new QLThuVien.DB_QuanLyThuVienDataSetTableAdapters.SachTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docGiaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcPhieuMuon.SuspendLayout();
            this.tpTaoPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QuanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaoPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuMuonBindingSource)).BeginInit();
            this.tpChiTieuPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuMuonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuMuonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhieuMuonDocGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuMuonBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPhieuMuon
            // 
            this.tcPhieuMuon.Controls.Add(this.tpTaoPhieu);
            this.tcPhieuMuon.Controls.Add(this.tpChiTieuPhieu);
            this.tcPhieuMuon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcPhieuMuon.Location = new System.Drawing.Point(16, 15);
            this.tcPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcPhieuMuon.Name = "tcPhieuMuon";
            this.tcPhieuMuon.SelectedIndex = 0;
            this.tcPhieuMuon.Size = new System.Drawing.Size(880, 492);
            this.tcPhieuMuon.TabIndex = 0;
            // 
            // tpTaoPhieu
            // 
            this.tpTaoPhieu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpTaoPhieu.Controls.Add(this.cboTenDG);
            this.tpTaoPhieu.Controls.Add(this.cboMaDG);
            this.tpTaoPhieu.Controls.Add(this.btLuu);
            this.tpTaoPhieu.Controls.Add(this.btSua);
            this.tpTaoPhieu.Controls.Add(this.btXoa);
            this.tpTaoPhieu.Controls.Add(this.btThem);
            this.tpTaoPhieu.Controls.Add(this.dgvTaoPM);
            this.tpTaoPhieu.Controls.Add(this.txtMaPM);
            this.tpTaoPhieu.Controls.Add(this.lbNgayMuon);
            this.tpTaoPhieu.Controls.Add(this.lbMaDG);
            this.tpTaoPhieu.Controls.Add(this.lbMaPM1);
            this.tpTaoPhieu.Location = new System.Drawing.Point(4, 27);
            this.tpTaoPhieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpTaoPhieu.Name = "tpTaoPhieu";
            this.tpTaoPhieu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpTaoPhieu.Size = new System.Drawing.Size(872, 461);
            this.tpTaoPhieu.TabIndex = 0;
            this.tpTaoPhieu.Text = "Tạo phiếu mượn";
            // 
            // cboTenDG
            // 
            this.cboTenDG.DataSource = this.docGiaBindingSource1;
            this.cboTenDG.DisplayMember = "HoTen";
            this.cboTenDG.Enabled = false;
            this.cboTenDG.FormattingEnabled = true;
            this.cboTenDG.Location = new System.Drawing.Point(213, 119);
            this.cboTenDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTenDG.Name = "cboTenDG";
            this.cboTenDG.Size = new System.Drawing.Size(212, 26);
            this.cboTenDG.TabIndex = 3;
            this.cboTenDG.ValueMember = "HoTen";
            // 
            // docGiaBindingSource1
            // 
            this.docGiaBindingSource1.DataMember = "DocGia";
            this.docGiaBindingSource1.DataSource = this.dB_QuanLyThuVienDataSet;
            // 
            // dB_QuanLyThuVienDataSet
            // 
            this.dB_QuanLyThuVienDataSet.DataSetName = "DB_QuanLyThuVienDataSet";
            this.dB_QuanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboMaDG
            // 
            this.cboMaDG.DataSource = this.docGiaBindingSource1;
            this.cboMaDG.DisplayMember = "ID";
            this.cboMaDG.FormattingEnabled = true;
            this.cboMaDG.Location = new System.Drawing.Point(213, 73);
            this.cboMaDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaDG.Name = "cboMaDG";
            this.cboMaDG.Size = new System.Drawing.Size(212, 26);
            this.cboMaDG.TabIndex = 2;
            this.cboMaDG.ValueMember = "ID";
            // 
            // btLuu
            // 
            this.btLuu.AutoSize = true;
            this.btLuu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(739, 394);
            this.btLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(100, 36);
            this.btLuu.TabIndex = 7;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btSua
            // 
            this.btSua.AutoSize = true;
            this.btSua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(739, 332);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 36);
            this.btSua.TabIndex = 6;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.AutoSize = true;
            this.btXoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(739, 271);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 36);
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.AutoSize = true;
            this.btThem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(739, 209);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 36);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dgvTaoPM
            // 
            this.dgvTaoPM.AutoGenerateColumns = false;
            this.dgvTaoPM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaoPM.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvTaoPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaoPM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.docGiaIDDataGridViewTextBoxColumn});
            this.dgvTaoPM.DataSource = this.phieuMuonBindingSource;
            this.dgvTaoPM.Location = new System.Drawing.Point(32, 174);
            this.dgvTaoPM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTaoPM.Name = "dgvTaoPM";
            this.dgvTaoPM.RowHeadersWidth = 51;
            this.dgvTaoPM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaoPM.Size = new System.Drawing.Size(667, 261);
            this.dgvTaoPM.TabIndex = 8;
            this.dgvTaoPM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaoPM_CellClick);
            // 
            // phieuMuonBindingSource
            // 
            this.phieuMuonBindingSource.DataMember = "PhieuMuon";
            this.phieuMuonBindingSource.DataSource = this.dB_QuanLyThuVienDataSet;
            // 
            // txtMaPM
            // 
            this.txtMaPM.Enabled = false;
            this.txtMaPM.Location = new System.Drawing.Point(213, 27);
            this.txtMaPM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(212, 26);
            this.txtMaPM.TabIndex = 1;
            // 
            // lbNgayMuon
            // 
            this.lbNgayMuon.AutoSize = true;
            this.lbNgayMuon.Location = new System.Drawing.Point(35, 124);
            this.lbNgayMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayMuon.Name = "lbNgayMuon";
            this.lbNgayMuon.Size = new System.Drawing.Size(96, 19);
            this.lbNgayMuon.TabIndex = 0;
            this.lbNgayMuon.Text = "Tên độc giả";
            // 
            // lbMaDG
            // 
            this.lbMaDG.AutoSize = true;
            this.lbMaDG.Location = new System.Drawing.Point(35, 78);
            this.lbMaDG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaDG.Name = "lbMaDG";
            this.lbMaDG.Size = new System.Drawing.Size(96, 19);
            this.lbMaDG.TabIndex = 0;
            this.lbMaDG.Text = "Mã độc giả:";
            // 
            // lbMaPM1
            // 
            this.lbMaPM1.AutoSize = true;
            this.lbMaPM1.Location = new System.Drawing.Point(35, 31);
            this.lbMaPM1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaPM1.Name = "lbMaPM1";
            this.lbMaPM1.Size = new System.Drawing.Size(130, 19);
            this.lbMaPM1.TabIndex = 0;
            this.lbMaPM1.Text = "Mã phiếu mượn:";
            // 
            // tpChiTieuPhieu
            // 
            this.tpChiTieuPhieu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpChiTieuPhieu.Controls.Add(this.txtGhiChu);
            this.tpChiTieuPhieu.Controls.Add(this.btLuu2);
            this.tpChiTieuPhieu.Controls.Add(this.btGiaHan);
            this.tpChiTieuPhieu.Controls.Add(this.btTraSach);
            this.tpChiTieuPhieu.Controls.Add(this.btMuon);
            this.tpChiTieuPhieu.Controls.Add(this.dgvChiTietPM);
            this.tpChiTieuPhieu.Controls.Add(this.dtpNgayTra);
            this.tpChiTieuPhieu.Controls.Add(this.dtpNgayMuon);
            this.tpChiTieuPhieu.Controls.Add(this.cboMaPM);
            this.tpChiTieuPhieu.Controls.Add(this.cboTenSach);
            this.tpChiTieuPhieu.Controls.Add(this.cboMaSach);
            this.tpChiTieuPhieu.Controls.Add(this.label1);
            this.tpChiTieuPhieu.Controls.Add(this.lbGhiChu);
            this.tpChiTieuPhieu.Controls.Add(this.label2);
            this.tpChiTieuPhieu.Controls.Add(this.lbNgayTra);
            this.tpChiTieuPhieu.Controls.Add(this.lbMaSach);
            this.tpChiTieuPhieu.Controls.Add(this.lbMaPM2);
            this.tpChiTieuPhieu.Location = new System.Drawing.Point(4, 27);
            this.tpChiTieuPhieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpChiTieuPhieu.Name = "tpChiTieuPhieu";
            this.tpChiTieuPhieu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpChiTieuPhieu.Size = new System.Drawing.Size(872, 461);
            this.tpChiTieuPhieu.TabIndex = 1;
            this.tpChiTieuPhieu.Text = "Chi tiết phiếu mượn";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(623, 121);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(212, 26);
            this.txtGhiChu.TabIndex = 6;
            // 
            // btLuu2
            // 
            this.btLuu2.AutoSize = true;
            this.btLuu2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu2.Location = new System.Drawing.Point(739, 394);
            this.btLuu2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLuu2.Name = "btLuu2";
            this.btLuu2.Size = new System.Drawing.Size(100, 36);
            this.btLuu2.TabIndex = 10;
            this.btLuu2.Text = "Lưu";
            this.btLuu2.UseVisualStyleBackColor = true;
            this.btLuu2.Click += new System.EventHandler(this.btLuu2_Click);
            // 
            // btGiaHan
            // 
            this.btGiaHan.AutoSize = true;
            this.btGiaHan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGiaHan.Location = new System.Drawing.Point(739, 332);
            this.btGiaHan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btGiaHan.Name = "btGiaHan";
            this.btGiaHan.Size = new System.Drawing.Size(104, 36);
            this.btGiaHan.TabIndex = 9;
            this.btGiaHan.Text = "Gia Hạn";
            this.btGiaHan.UseVisualStyleBackColor = true;
            this.btGiaHan.Click += new System.EventHandler(this.btGiaHan_Click);
            // 
            // btTraSach
            // 
            this.btTraSach.AutoSize = true;
            this.btTraSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTraSach.Location = new System.Drawing.Point(739, 271);
            this.btTraSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btTraSach.Name = "btTraSach";
            this.btTraSach.Size = new System.Drawing.Size(113, 36);
            this.btTraSach.TabIndex = 8;
            this.btTraSach.Text = "Trả Sách";
            this.btTraSach.UseVisualStyleBackColor = true;
            this.btTraSach.Click += new System.EventHandler(this.btTraSach_Click);
            // 
            // btMuon
            // 
            this.btMuon.AutoSize = true;
            this.btMuon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMuon.Location = new System.Drawing.Point(739, 209);
            this.btMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btMuon.Name = "btMuon";
            this.btMuon.Size = new System.Drawing.Size(100, 36);
            this.btMuon.TabIndex = 7;
            this.btMuon.Text = "Mượn ";
            this.btMuon.UseVisualStyleBackColor = true;
            this.btMuon.Click += new System.EventHandler(this.btMuon_Click);
            // 
            // dgvChiTietPM
            // 
            this.dgvChiTietPM.AutoGenerateColumns = false;
            this.dgvChiTietPM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietPM.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvChiTietPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phieuMuonIDDataGridViewTextBoxColumn,
            this.sachIDDataGridViewTextBoxColumn,
            this.ngayMuonDataGridViewTextBoxColumn,
            this.ngayTraDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.dgvChiTietPM.DataSource = this.cTPhieuMuonBindingSource;
            this.dgvChiTietPM.Location = new System.Drawing.Point(32, 174);
            this.dgvChiTietPM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvChiTietPM.Name = "dgvChiTietPM";
            this.dgvChiTietPM.RowHeadersWidth = 51;
            this.dgvChiTietPM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietPM.Size = new System.Drawing.Size(667, 261);
            this.dgvChiTietPM.TabIndex = 11;
            this.dgvChiTietPM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPM_CellClick);
            // 
            // phieuMuonIDDataGridViewTextBoxColumn
            // 
            this.phieuMuonIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.phieuMuonIDDataGridViewTextBoxColumn.DataPropertyName = "PhieuMuon_ID";
            this.phieuMuonIDDataGridViewTextBoxColumn.HeaderText = "Mã Phiếu Mượn";
            this.phieuMuonIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phieuMuonIDDataGridViewTextBoxColumn.Name = "phieuMuonIDDataGridViewTextBoxColumn";
            this.phieuMuonIDDataGridViewTextBoxColumn.Width = 140;
            // 
            // sachIDDataGridViewTextBoxColumn
            // 
            this.sachIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sachIDDataGridViewTextBoxColumn.DataPropertyName = "Sach_ID";
            this.sachIDDataGridViewTextBoxColumn.HeaderText = "Mã Sách";
            this.sachIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sachIDDataGridViewTextBoxColumn.Name = "sachIDDataGridViewTextBoxColumn";
            this.sachIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // ngayMuonDataGridViewTextBoxColumn
            // 
            this.ngayMuonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ngayMuonDataGridViewTextBoxColumn.DataPropertyName = "NgayMuon";
            this.ngayMuonDataGridViewTextBoxColumn.HeaderText = "Ngày Mượn";
            this.ngayMuonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayMuonDataGridViewTextBoxColumn.Name = "ngayMuonDataGridViewTextBoxColumn";
            this.ngayMuonDataGridViewTextBoxColumn.Width = 120;
            // 
            // ngayTraDataGridViewTextBoxColumn
            // 
            this.ngayTraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ngayTraDataGridViewTextBoxColumn.DataPropertyName = "NgayTra";
            this.ngayTraDataGridViewTextBoxColumn.HeaderText = "Ngày Trả";
            this.ngayTraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTraDataGridViewTextBoxColumn.Name = "ngayTraDataGridViewTextBoxColumn";
            this.ngayTraDataGridViewTextBoxColumn.Width = 125;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi Chú";
            this.ghiChuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.Width = 120;
            // 
            // cTPhieuMuonBindingSource
            // 
            this.cTPhieuMuonBindingSource.DataMember = "CTPhieuMuon";
            this.cTPhieuMuonBindingSource.DataSource = this.dB_QuanLyThuVienDataSet;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTra.Enabled = false;
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(623, 74);
            this.dtpNgayTra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(212, 26);
            this.dtpNgayTra.TabIndex = 5;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon.Location = new System.Drawing.Point(623, 27);
            this.dtpNgayMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(212, 26);
            this.dtpNgayMuon.TabIndex = 4;
            this.dtpNgayMuon.ValueChanged += new System.EventHandler(this.dtpNgayMuon_ValueChanged);
            // 
            // cboMaPM
            // 
            this.cboMaPM.DataSource = this.phieuMuonBindingSource;
            this.cboMaPM.DisplayMember = "ID";
            this.cboMaPM.FormattingEnabled = true;
            this.cboMaPM.Location = new System.Drawing.Point(211, 26);
            this.cboMaPM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMaPM.Name = "cboMaPM";
            this.cboMaPM.Size = new System.Drawing.Size(212, 26);
            this.cboMaPM.TabIndex = 1;
            // 
            // cboTenSach
            // 
            this.cboTenSach.DataSource = this.sachBindingSource;
            this.cboTenSach.DisplayMember = "Ten";
            this.cboTenSach.FormattingEnabled = true;
            this.cboTenSach.Location = new System.Drawing.Point(211, 119);
            this.cboTenSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTenSach.Name = "cboTenSach";
            this.cboTenSach.Size = new System.Drawing.Size(212, 26);
            this.cboTenSach.TabIndex = 3;
            // 
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "Sach";
            this.sachBindingSource.DataSource = this.dB_QuanLyThuVienDataSet;
            // 
            // cboMaSach
            // 
            this.cboMaSach.DataSource = this.sachBindingSource;
            this.cboMaSach.DisplayMember = "ID";
            this.cboMaSach.FormattingEnabled = true;
            this.cboMaSach.Location = new System.Drawing.Point(211, 73);
            this.cboMaSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMaSach.Name = "cboMaSach";
            this.cboMaSach.Size = new System.Drawing.Size(212, 26);
            this.cboMaSach.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách:";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(493, 124);
            this.lbGhiChu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(66, 19);
            this.lbGhiChu.TabIndex = 0;
            this.lbGhiChu.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày trả:";
            // 
            // lbNgayTra
            // 
            this.lbNgayTra.AutoSize = true;
            this.lbNgayTra.Location = new System.Drawing.Point(493, 31);
            this.lbNgayTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayTra.Name = "lbNgayTra";
            this.lbNgayTra.Size = new System.Drawing.Size(101, 19);
            this.lbNgayTra.TabIndex = 0;
            this.lbNgayTra.Text = "Ngày mượn:";
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.Location = new System.Drawing.Point(35, 78);
            this.lbMaSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(76, 19);
            this.lbMaSach.TabIndex = 0;
            this.lbMaSach.Text = "Mã sách:";
            // 
            // lbMaPM2
            // 
            this.lbMaPM2.AutoSize = true;
            this.lbMaPM2.Location = new System.Drawing.Point(35, 31);
            this.lbMaPM2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaPM2.Name = "lbMaPM2";
            this.lbMaPM2.Size = new System.Drawing.Size(130, 19);
            this.lbMaPM2.TabIndex = 0;
            this.lbMaPM2.Text = "Mã phiếu mượn:";
            // 
            // phieuMuonBindingSource1
            // 
            this.phieuMuonBindingSource1.DataMember = "PhieuMuon";
            this.phieuMuonBindingSource1.DataSource = this.dB_QuanLyThuVienDataSet;
            // 
            // docGiaBindingSource
            // 
            this.docGiaBindingSource.DataMember = "DocGia";
            this.docGiaBindingSource.DataSource = this.dB_QuanLyThuVienDataSet;
            // 
            // btThoat
            // 
            this.btThoat.AutoSize = true;
            this.btThoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Image = global::QLThuVien.Properties.Resources.icons8_close_24;
            this.btThoat.Location = new System.Drawing.Point(163, 535);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(119, 37);
            this.btThoat.TabIndex = 2;
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
            this.btQuayVe.Location = new System.Drawing.Point(16, 535);
            this.btQuayVe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQuayVe.Name = "btQuayVe";
            this.btQuayVe.Size = new System.Drawing.Size(119, 37);
            this.btQuayVe.TabIndex = 1;
            this.btQuayVe.Text = "Quay về";
            this.btQuayVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuayVe.UseVisualStyleBackColor = true;
            this.btQuayVe.Click += new System.EventHandler(this.btQuayVe_Click);
            // 
            // docGiaTableAdapter
            // 
            this.docGiaTableAdapter.ClearBeforeFill = true;
            // 
            // phieuMuonTableAdapter
            // 
            this.phieuMuonTableAdapter.ClearBeforeFill = true;
            // 
            // fKPhieuMuonDocGiaBindingSource
            // 
            this.fKPhieuMuonDocGiaBindingSource.DataMember = "FK_PhieuMuon_DocGia";
            this.fKPhieuMuonDocGiaBindingSource.DataSource = this.docGiaBindingSource;
            // 
            // cTPhieuMuonTableAdapter
            // 
            this.cTPhieuMuonTableAdapter.ClearBeforeFill = true;
            // 
            // cTPhieuMuonBindingSource1
            // 
            this.cTPhieuMuonBindingSource1.DataMember = "CTPhieuMuon";
            this.cTPhieuMuonBindingSource1.DataSource = this.dB_QuanLyThuVienDataSet;
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Mã Phiếu Mượn";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 140;
            // 
            // docGiaIDDataGridViewTextBoxColumn
            // 
            this.docGiaIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.docGiaIDDataGridViewTextBoxColumn.DataPropertyName = "DocGia_ID";
            this.docGiaIDDataGridViewTextBoxColumn.HeaderText = "Mã Độc Giả";
            this.docGiaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.docGiaIDDataGridViewTextBoxColumn.Name = "docGiaIDDataGridViewTextBoxColumn";
            this.docGiaIDDataGridViewTextBoxColumn.Width = 140;
            // 
            // frmPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(912, 592);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btQuayVe);
            this.Controls.Add(this.tcPhieuMuon);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mượn trả sách";
            this.Load += new System.EventHandler(this.frmPhieuMuon_Load);
            this.tcPhieuMuon.ResumeLayout(false);
            this.tpTaoPhieu.ResumeLayout(false);
            this.tpTaoPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QuanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaoPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuMuonBindingSource)).EndInit();
            this.tpChiTieuPhieu.ResumeLayout(false);
            this.tpChiTieuPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuMuonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuMuonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhieuMuonDocGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuMuonBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcPhieuMuon;
        private System.Windows.Forms.TabPage tpTaoPhieu;
        private System.Windows.Forms.DataGridView dgvTaoPM;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.Label lbNgayMuon;
        private System.Windows.Forms.Label lbMaDG;
        private System.Windows.Forms.Label lbMaPM1;
        private System.Windows.Forms.TabPage tpChiTieuPhieu;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btLuu2;
        private System.Windows.Forms.Button btGiaHan;
        private System.Windows.Forms.Button btTraSach;
        private System.Windows.Forms.Button btMuon;
        private System.Windows.Forms.DataGridView dgvChiTietPM;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.ComboBox cboMaSach;
        private System.Windows.Forms.Label lbNgayTra;
        private System.Windows.Forms.Label lbMaSach;
        private System.Windows.Forms.Label lbMaPM2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btQuayVe;
        private System.Windows.Forms.ComboBox cboMaPM;
        private DB_QuanLyThuVienDataSet dB_QuanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource docGiaBindingSource;
        private DB_QuanLyThuVienDataSetTableAdapters.DocGiaTableAdapter docGiaTableAdapter;
        private System.Windows.Forms.BindingSource phieuMuonBindingSource;
        private DB_QuanLyThuVienDataSetTableAdapters.PhieuMuonTableAdapter phieuMuonTableAdapter;
        private System.Windows.Forms.BindingSource fKPhieuMuonDocGiaBindingSource;
        private System.Windows.Forms.ComboBox cboMaDG;
        private System.Windows.Forms.BindingSource docGiaBindingSource1;
        private System.Windows.Forms.ComboBox cboTenDG;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.ComboBox cboTenSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource cTPhieuMuonBindingSource;
        private DB_QuanLyThuVienDataSetTableAdapters.CTPhieuMuonTableAdapter cTPhieuMuonTableAdapter;
        private System.Windows.Forms.BindingSource cTPhieuMuonBindingSource1;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private DB_QuanLyThuVienDataSetTableAdapters.SachTableAdapter sachTableAdapter;
        private System.Windows.Forms.BindingSource phieuMuonBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phieuMuonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sachIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docGiaIDDataGridViewTextBoxColumn;
    }
}