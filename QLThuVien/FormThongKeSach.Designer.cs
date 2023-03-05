
namespace QLThuVien
{
    partial class frmThongKeSach
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
            this.cboThongKe = new System.Windows.Forms.ComboBox();
            this.dgvThongKeSach = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThoat = new System.Windows.Forms.Button();
            this.btQuayVe = new System.Windows.Forms.Button();
            this.dB_QuanLyThuVienDataSet = new QLThuVien.DB_QuanLyThuVienDataSet();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sachTableAdapter = new QLThuVien.DB_QuanLyThuVienDataSetTableAdapters.SachTableAdapter();
            this.btThongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QuanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboThongKe
            // 
            this.cboThongKe.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThongKe.FormattingEnabled = true;
            this.cboThongKe.Items.AddRange(new object[] {
            "Sách đang mượn",
            "Sách trễ hạn"});
            this.cboThongKe.Location = new System.Drawing.Point(31, 23);
            this.cboThongKe.Name = "cboThongKe";
            this.cboThongKe.Size = new System.Drawing.Size(160, 24);
            this.cboThongKe.TabIndex = 0;
            // 
            // dgvThongKeSach
            // 
            this.dgvThongKeSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeSach.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvThongKeSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ten,
            this.ID1,
            this.ID2,
            this.NgayMuon,
            this.NgayTra});
            this.dgvThongKeSach.Location = new System.Drawing.Point(21, 80);
            this.dgvThongKeSach.Name = "dgvThongKeSach";
            this.dgvThongKeSach.RowHeadersWidth = 51;
            this.dgvThongKeSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKeSach.Size = new System.Drawing.Size(485, 200);
            this.dgvThongKeSach.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã Sách";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 80;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Width = 120;
            // 
            // ID1
            // 
            this.ID1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID1.DataPropertyName = "ID1";
            this.ID1.HeaderText = "Mã Độc Giả";
            this.ID1.MinimumWidth = 6;
            this.ID1.Name = "ID1";
            this.ID1.Width = 90;
            // 
            // ID2
            // 
            this.ID2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID2.DataPropertyName = "ID2";
            this.ID2.HeaderText = "Mã Phiếu Mượn";
            this.ID2.MinimumWidth = 6;
            this.ID2.Name = "ID2";
            this.ID2.Width = 120;
            // 
            // NgayMuon
            // 
            this.NgayMuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày Mượn";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.Width = 90;
            // 
            // NgayTra
            // 
            this.NgayTra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày Trả";
            this.NgayTra.MinimumWidth = 6;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Width = 90;
            // 
            // btThoat
            // 
            this.btThoat.AutoSize = true;
            this.btThoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Image = global::QLThuVien.Properties.Resources.icons8_close_24;
            this.btThoat.Location = new System.Drawing.Point(131, 302);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(89, 30);
            this.btThoat.TabIndex = 4;
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
            this.btQuayVe.TabIndex = 3;
            this.btQuayVe.Text = "Quay về";
            this.btQuayVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuayVe.UseVisualStyleBackColor = true;
            this.btQuayVe.Click += new System.EventHandler(this.btQuayVe_Click);
            // 
            // dB_QuanLyThuVienDataSet
            // 
            this.dB_QuanLyThuVienDataSet.DataSetName = "DB_QuanLyThuVienDataSet";
            this.dB_QuanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btThongKe
            // 
            this.btThongKe.AutoSize = true;
            this.btThongKe.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongKe.Location = new System.Drawing.Point(220, 22);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(75, 26);
            this.btThongKe.TabIndex = 1;
            this.btThongKe.Text = "Thống kê";
            this.btThongKe.UseVisualStyleBackColor = true;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // frmThongKeSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(527, 351);
            this.Controls.Add(this.btThongKe);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btQuayVe);
            this.Controls.Add(this.dgvThongKeSach);
            this.Controls.Add(this.cboThongKe);
            this.Name = "frmThongKeSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê sách";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QuanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboThongKe;
        private System.Windows.Forms.DataGridView dgvThongKeSach;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btQuayVe;
        private DB_QuanLyThuVienDataSet dB_QuanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private DB_QuanLyThuVienDataSetTableAdapters.SachTableAdapter sachTableAdapter;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
    }
}