
namespace QLThuVien
{
    partial class frmTimKiemDG
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
            this.dgvTimKiemDG = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_QuanLyThuVienDataSet = new QLThuVien.DB_QuanLyThuVienDataSet();
            this.btThoat = new System.Windows.Forms.Button();
            this.btQuayVe = new System.Windows.Forms.Button();
            this.rdoMaDG = new System.Windows.Forms.RadioButton();
            this.rdoTenDG = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.docGiaTableAdapter = new QLThuVien.DB_QuanLyThuVienDataSetTableAdapters.DocGiaTableAdapter();
            this.fKPhieuMuonDocGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuMuonTableAdapter = new QLThuVien.DB_QuanLyThuVienDataSetTableAdapters.PhieuMuonTableAdapter();
            this.docGiaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QuanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhieuMuonDocGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTimKiemDG
            // 
            this.dgvTimKiemDG.AutoGenerateColumns = false;
            this.dgvTimKiemDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTimKiemDG.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTimKiemDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiemDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn,
            this.ngayTaoDataGridViewTextBoxColumn,
            this.ngayHetDataGridViewTextBoxColumn});
            this.dgvTimKiemDG.DataSource = this.docGiaBindingSource;
            this.dgvTimKiemDG.Location = new System.Drawing.Point(21, 110);
            this.dgvTimKiemDG.Name = "dgvTimKiemDG";
            this.dgvTimKiemDG.RowHeadersWidth = 51;
            this.dgvTimKiemDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimKiemDG.Size = new System.Drawing.Size(485, 200);
            this.dgvTimKiemDG.TabIndex = 4;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Mã Độc Giả";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 90;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Họ Tên";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.Width = 140;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới Tính";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.Width = 80;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 160;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "Số Điện Thoại";
            this.soDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            // 
            // ngayTaoDataGridViewTextBoxColumn
            // 
            this.ngayTaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ngayTaoDataGridViewTextBoxColumn.DataPropertyName = "NgayTao";
            this.ngayTaoDataGridViewTextBoxColumn.HeaderText = "Ngày Tạo";
            this.ngayTaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTaoDataGridViewTextBoxColumn.Name = "ngayTaoDataGridViewTextBoxColumn";
            this.ngayTaoDataGridViewTextBoxColumn.Width = 90;
            // 
            // ngayHetDataGridViewTextBoxColumn
            // 
            this.ngayHetDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ngayHetDataGridViewTextBoxColumn.DataPropertyName = "NgayHet";
            this.ngayHetDataGridViewTextBoxColumn.HeaderText = "Ngày Hết Hạn";
            this.ngayHetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayHetDataGridViewTextBoxColumn.Name = "ngayHetDataGridViewTextBoxColumn";
            // 
            // docGiaBindingSource
            // 
            this.docGiaBindingSource.DataMember = "DocGia";
            this.docGiaBindingSource.DataSource = this.dB_QuanLyThuVienDataSet;
            // 
            // dB_QuanLyThuVienDataSet
            // 
            this.dB_QuanLyThuVienDataSet.DataSetName = "DB_QuanLyThuVienDataSet";
            this.dB_QuanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btThoat
            // 
            this.btThoat.AutoSize = true;
            this.btThoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Image = global::QLThuVien.Properties.Resources.icons8_close_24;
            this.btThoat.Location = new System.Drawing.Point(131, 332);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(89, 30);
            this.btThoat.TabIndex = 6;
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
            this.btQuayVe.Location = new System.Drawing.Point(21, 332);
            this.btQuayVe.Name = "btQuayVe";
            this.btQuayVe.Size = new System.Drawing.Size(89, 30);
            this.btQuayVe.TabIndex = 5;
            this.btQuayVe.Text = "Quay về";
            this.btQuayVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuayVe.UseVisualStyleBackColor = true;
            this.btQuayVe.Click += new System.EventHandler(this.btQuayVe_Click);
            // 
            // rdoMaDG
            // 
            this.rdoMaDG.AutoSize = true;
            this.rdoMaDG.Checked = true;
            this.rdoMaDG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMaDG.Location = new System.Drawing.Point(31, 26);
            this.rdoMaDG.Margin = new System.Windows.Forms.Padding(2);
            this.rdoMaDG.Name = "rdoMaDG";
            this.rdoMaDG.Size = new System.Drawing.Size(144, 20);
            this.rdoMaDG.TabIndex = 0;
            this.rdoMaDG.TabStop = true;
            this.rdoMaDG.Text = "Tìm theo mã độc giả";
            this.rdoMaDG.UseVisualStyleBackColor = true;
            // 
            // rdoTenDG
            // 
            this.rdoTenDG.AutoSize = true;
            this.rdoTenDG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoTenDG.Location = new System.Drawing.Point(31, 60);
            this.rdoTenDG.Margin = new System.Windows.Forms.Padding(2);
            this.rdoTenDG.Name = "rdoTenDG";
            this.rdoTenDG.Size = new System.Drawing.Size(162, 20);
            this.rdoTenDG.TabIndex = 1;
            this.rdoTenDG.Text = "Tìm theo họ tên độc giả";
            this.rdoTenDG.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(221, 38);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(160, 22);
            this.txtTimKiem.TabIndex = 2;
            // 
            // docGiaTableAdapter
            // 
            this.docGiaTableAdapter.ClearBeforeFill = true;
            // 
            // fKPhieuMuonDocGiaBindingSource
            // 
            this.fKPhieuMuonDocGiaBindingSource.DataMember = "FK_PhieuMuon_DocGia";
            this.fKPhieuMuonDocGiaBindingSource.DataSource = this.docGiaBindingSource;
            // 
            // phieuMuonTableAdapter
            // 
            this.phieuMuonTableAdapter.ClearBeforeFill = true;
            // 
            // docGiaBindingSource1
            // 
            this.docGiaBindingSource1.DataMember = "DocGia";
            this.docGiaBindingSource1.DataSource = this.dB_QuanLyThuVienDataSet;
            // 
            // btTim
            // 
            this.btTim.AutoSize = true;
            this.btTim.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.Location = new System.Drawing.Point(410, 36);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 26);
            this.btTim.TabIndex = 3;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // frmTimKiemDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(527, 381);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.rdoTenDG);
            this.Controls.Add(this.rdoMaDG);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btQuayVe);
            this.Controls.Add(this.dgvTimKiemDG);
            this.Name = "frmTimKiemDG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm độc giả";
            this.Load += new System.EventHandler(this.frmTimKiemDG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QuanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhieuMuonDocGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTimKiemDG;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btQuayVe;
        private System.Windows.Forms.RadioButton rdoMaDG;
        private System.Windows.Forms.RadioButton rdoTenDG;
        private System.Windows.Forms.TextBox txtTimKiem;
        private DB_QuanLyThuVienDataSet dB_QuanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource docGiaBindingSource;
        private DB_QuanLyThuVienDataSetTableAdapters.DocGiaTableAdapter docGiaTableAdapter;
        private System.Windows.Forms.BindingSource fKPhieuMuonDocGiaBindingSource;
        private DB_QuanLyThuVienDataSetTableAdapters.PhieuMuonTableAdapter phieuMuonTableAdapter;
        private System.Windows.Forms.BindingSource docGiaBindingSource1;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetDataGridViewTextBoxColumn;
    }
}