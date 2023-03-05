
namespace QLThuVien
{
    partial class frmTimKiemSach
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
            this.btThoat = new System.Windows.Forms.Button();
            this.btQuayVe = new System.Windows.Forms.Button();
            this.dgvTimKiemSach = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGiaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theLoaiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaXuatBanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_QuanLyThuVienDataSet = new QLThuVien.DB_QuanLyThuVienDataSet();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdoTenSach = new System.Windows.Forms.RadioButton();
            this.rdoMaSach = new System.Windows.Forms.RadioButton();
            this.sachTableAdapter = new QLThuVien.DB_QuanLyThuVienDataSetTableAdapters.SachTableAdapter();
            this.btTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QuanLyThuVienDataSet)).BeginInit();
            this.SuspendLayout();
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
            // dgvTimKiemSach
            // 
            this.dgvTimKiemSach.AutoGenerateColumns = false;
            this.dgvTimKiemSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimKiemSach.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTimKiemSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiemSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.tacGiaIDDataGridViewTextBoxColumn,
            this.theLoaiIDDataGridViewTextBoxColumn,
            this.nhaXuatBanIDDataGridViewTextBoxColumn});
            this.dgvTimKiemSach.DataSource = this.sachBindingSource;
            this.dgvTimKiemSach.Location = new System.Drawing.Point(21, 110);
            this.dgvTimKiemSach.Name = "dgvTimKiemSach";
            this.dgvTimKiemSach.RowHeadersWidth = 51;
            this.dgvTimKiemSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimKiemSach.Size = new System.Drawing.Size(485, 200);
            this.dgvTimKiemSach.TabIndex = 4;
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
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "Sach";
            this.sachBindingSource.DataSource = this.dB_QuanLyThuVienDataSet;
            // 
            // dB_QuanLyThuVienDataSet
            // 
            this.dB_QuanLyThuVienDataSet.DataSetName = "DB_QuanLyThuVienDataSet";
            this.dB_QuanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(201, 38);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(160, 22);
            this.txtTimKiem.TabIndex = 2;
            // 
            // rdoTenSach
            // 
            this.rdoTenSach.AutoSize = true;
            this.rdoTenSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoTenSach.Location = new System.Drawing.Point(31, 60);
            this.rdoTenSach.Margin = new System.Windows.Forms.Padding(2);
            this.rdoTenSach.Name = "rdoTenSach";
            this.rdoTenSach.Size = new System.Drawing.Size(130, 20);
            this.rdoTenSach.TabIndex = 1;
            this.rdoTenSach.Text = "Tìm theo tên sách";
            this.rdoTenSach.UseVisualStyleBackColor = true;
            // 
            // rdoMaSach
            // 
            this.rdoMaSach.AutoSize = true;
            this.rdoMaSach.Checked = true;
            this.rdoMaSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoMaSach.Location = new System.Drawing.Point(31, 26);
            this.rdoMaSach.Margin = new System.Windows.Forms.Padding(2);
            this.rdoMaSach.Name = "rdoMaSach";
            this.rdoMaSach.Size = new System.Drawing.Size(130, 20);
            this.rdoMaSach.TabIndex = 0;
            this.rdoMaSach.TabStop = true;
            this.rdoMaSach.Text = "Tìm theo mã sách";
            this.rdoMaSach.UseVisualStyleBackColor = true;
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // btTim
            // 
            this.btTim.AutoSize = true;
            this.btTim.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.Location = new System.Drawing.Point(390, 36);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 26);
            this.btTim.TabIndex = 3;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // frmTimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(527, 381);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.rdoTenSach);
            this.Controls.Add(this.rdoMaSach);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btQuayVe);
            this.Controls.Add(this.dgvTimKiemSach);
            this.Name = "frmTimKiemSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm sách";
            this.Load += new System.EventHandler(this.frmTimKiemSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QuanLyThuVienDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btQuayVe;
        private System.Windows.Forms.DataGridView dgvTimKiemSach;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdoTenSach;
        private System.Windows.Forms.RadioButton rdoMaSach;
        private DB_QuanLyThuVienDataSet dB_QuanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private DB_QuanLyThuVienDataSetTableAdapters.SachTableAdapter sachTableAdapter;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacGiaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theLoaiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaXuatBanIDDataGridViewTextBoxColumn;
    }
}