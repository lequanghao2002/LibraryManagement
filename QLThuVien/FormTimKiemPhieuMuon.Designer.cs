namespace QLThuVien
{
    partial class FormTimKiemPhieuMuon
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btQuayVe = new System.Windows.Forms.Button();
            this.dgvTimKiemPhieuMuon = new System.Windows.Forms.DataGridView();
            this.phieuMuonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sachIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTPhieuMuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_QuanLyThuVienDataSet = new QLThuVien.DB_QuanLyThuVienDataSet();
            this.lbMaDG = new System.Windows.Forms.Label();
            this.cTPhieuMuonTableAdapter = new QLThuVien.DB_QuanLyThuVienDataSetTableAdapters.CTPhieuMuonTableAdapter();
            this.btTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemPhieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuMuonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QuanLyThuVienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(129, 23);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(160, 22);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btThoat
            // 
            this.btThoat.AutoSize = true;
            this.btThoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Image = global::QLThuVien.Properties.Resources.icons8_close_24;
            this.btThoat.Location = new System.Drawing.Point(131, 302);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(89, 30);
            this.btThoat.TabIndex = 5;
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
            this.btQuayVe.Location = new System.Drawing.Point(21, 302);
            this.btQuayVe.Name = "btQuayVe";
            this.btQuayVe.Size = new System.Drawing.Size(89, 30);
            this.btQuayVe.TabIndex = 4;
            this.btQuayVe.Text = "Quay về";
            this.btQuayVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuayVe.UseVisualStyleBackColor = true;
            this.btQuayVe.Click += new System.EventHandler(this.btQuayVe_Click);
            // 
            // dgvTimKiemPhieuMuon
            // 
            this.dgvTimKiemPhieuMuon.AutoGenerateColumns = false;
            this.dgvTimKiemPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimKiemPhieuMuon.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTimKiemPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiemPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phieuMuonIDDataGridViewTextBoxColumn,
            this.sachIDDataGridViewTextBoxColumn,
            this.ngayMuonDataGridViewTextBoxColumn,
            this.ngayTraDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.dgvTimKiemPhieuMuon.DataSource = this.cTPhieuMuonBindingSource;
            this.dgvTimKiemPhieuMuon.Location = new System.Drawing.Point(21, 80);
            this.dgvTimKiemPhieuMuon.Name = "dgvTimKiemPhieuMuon";
            this.dgvTimKiemPhieuMuon.RowHeadersWidth = 51;
            this.dgvTimKiemPhieuMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimKiemPhieuMuon.Size = new System.Drawing.Size(485, 200);
            this.dgvTimKiemPhieuMuon.TabIndex = 3;
            // 
            // phieuMuonIDDataGridViewTextBoxColumn
            // 
            this.phieuMuonIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.phieuMuonIDDataGridViewTextBoxColumn.DataPropertyName = "PhieuMuon_ID";
            this.phieuMuonIDDataGridViewTextBoxColumn.HeaderText = "Mã Phiếu Mượn";
            this.phieuMuonIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phieuMuonIDDataGridViewTextBoxColumn.Name = "phieuMuonIDDataGridViewTextBoxColumn";
            this.phieuMuonIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // sachIDDataGridViewTextBoxColumn
            // 
            this.sachIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sachIDDataGridViewTextBoxColumn.DataPropertyName = "Sach_ID";
            this.sachIDDataGridViewTextBoxColumn.HeaderText = "Mã Sách";
            this.sachIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sachIDDataGridViewTextBoxColumn.Name = "sachIDDataGridViewTextBoxColumn";
            // 
            // ngayMuonDataGridViewTextBoxColumn
            // 
            this.ngayMuonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ngayMuonDataGridViewTextBoxColumn.DataPropertyName = "NgayMuon";
            this.ngayMuonDataGridViewTextBoxColumn.HeaderText = "Ngày Mượn";
            this.ngayMuonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayMuonDataGridViewTextBoxColumn.Name = "ngayMuonDataGridViewTextBoxColumn";
            this.ngayMuonDataGridViewTextBoxColumn.Width = 90;
            // 
            // ngayTraDataGridViewTextBoxColumn
            // 
            this.ngayTraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ngayTraDataGridViewTextBoxColumn.DataPropertyName = "NgayTra";
            this.ngayTraDataGridViewTextBoxColumn.HeaderText = "Ngày Trả";
            this.ngayTraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTraDataGridViewTextBoxColumn.Name = "ngayTraDataGridViewTextBoxColumn";
            this.ngayTraDataGridViewTextBoxColumn.Width = 90;
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
            // dB_QuanLyThuVienDataSet
            // 
            this.dB_QuanLyThuVienDataSet.DataSetName = "DB_QuanLyThuVienDataSet";
            this.dB_QuanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbMaDG
            // 
            this.lbMaDG.AutoSize = true;
            this.lbMaDG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaDG.Location = new System.Drawing.Point(31, 26);
            this.lbMaDG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaDG.Name = "lbMaDG";
            this.lbMaDG.Size = new System.Drawing.Size(76, 16);
            this.lbMaDG.TabIndex = 0;
            this.lbMaDG.Text = "Mã độc giả:";
            // 
            // cTPhieuMuonTableAdapter
            // 
            this.cTPhieuMuonTableAdapter.ClearBeforeFill = true;
            // 
            // btTim
            // 
            this.btTim.AutoSize = true;
            this.btTim.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.Location = new System.Drawing.Point(318, 21);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 26);
            this.btTim.TabIndex = 2;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // FormTimKiemPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(527, 351);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.lbMaDG);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btQuayVe);
            this.Controls.Add(this.dgvTimKiemPhieuMuon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTimKiemPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm phiếu mượn của độc giả";
            this.Load += new System.EventHandler(this.FormTimKiemPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemPhieuMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuMuonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QuanLyThuVienDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btQuayVe;
        private System.Windows.Forms.DataGridView dgvTimKiemPhieuMuon;
        private System.Windows.Forms.Label lbMaDG;
        private DB_QuanLyThuVienDataSet dB_QuanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource cTPhieuMuonBindingSource;
        private DB_QuanLyThuVienDataSetTableAdapters.CTPhieuMuonTableAdapter cTPhieuMuonTableAdapter;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn phieuMuonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sachIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
    }
}