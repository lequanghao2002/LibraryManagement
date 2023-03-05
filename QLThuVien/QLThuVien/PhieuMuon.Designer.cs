
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
            this.tcPhieuMuon = new System.Windows.Forms.TabControl();
            this.tpTaoPhieu = new System.Windows.Forms.TabPage();
            this.btLuu = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvTaoPM = new System.Windows.Forms.DataGridView();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.cboMaDG = new System.Windows.Forms.ComboBox();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.lbNgayMuon = new System.Windows.Forms.Label();
            this.lbMaDG = new System.Windows.Forms.Label();
            this.lbMaPM1 = new System.Windows.Forms.Label();
            this.tpChiTieuPhieu = new System.Windows.Forms.TabPage();
            this.chbDaTra = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvChiTietPM = new System.Windows.Forms.DataGridView();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.cboMaPM = new System.Windows.Forms.ComboBox();
            this.cboMaSach = new System.Windows.Forms.ComboBox();
            this.lbDaTra = new System.Windows.Forms.Label();
            this.lbNgayTra = new System.Windows.Forms.Label();
            this.lbMaSach = new System.Windows.Forms.Label();
            this.lbMaPM2 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btQuayVe = new System.Windows.Forms.Button();
            this.tcPhieuMuon.SuspendLayout();
            this.tpTaoPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaoPM)).BeginInit();
            this.tpChiTieuPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPM)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPhieuMuon
            // 
            this.tcPhieuMuon.Controls.Add(this.tpTaoPhieu);
            this.tcPhieuMuon.Controls.Add(this.tpChiTieuPhieu);
            this.tcPhieuMuon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcPhieuMuon.Location = new System.Drawing.Point(12, 12);
            this.tcPhieuMuon.Name = "tcPhieuMuon";
            this.tcPhieuMuon.SelectedIndex = 0;
            this.tcPhieuMuon.Size = new System.Drawing.Size(660, 400);
            this.tcPhieuMuon.TabIndex = 0;
            // 
            // tpTaoPhieu
            // 
            this.tpTaoPhieu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpTaoPhieu.Controls.Add(this.btLuu);
            this.tpTaoPhieu.Controls.Add(this.btSua);
            this.tpTaoPhieu.Controls.Add(this.btXoa);
            this.tpTaoPhieu.Controls.Add(this.btThem);
            this.tpTaoPhieu.Controls.Add(this.dgvTaoPM);
            this.tpTaoPhieu.Controls.Add(this.dtpNgayMuon);
            this.tpTaoPhieu.Controls.Add(this.cboMaDG);
            this.tpTaoPhieu.Controls.Add(this.txtMaPM);
            this.tpTaoPhieu.Controls.Add(this.lbNgayMuon);
            this.tpTaoPhieu.Controls.Add(this.lbMaDG);
            this.tpTaoPhieu.Controls.Add(this.lbMaPM1);
            this.tpTaoPhieu.Location = new System.Drawing.Point(4, 25);
            this.tpTaoPhieu.Name = "tpTaoPhieu";
            this.tpTaoPhieu.Padding = new System.Windows.Forms.Padding(3);
            this.tpTaoPhieu.Size = new System.Drawing.Size(652, 371);
            this.tpTaoPhieu.TabIndex = 0;
            this.tpTaoPhieu.Text = "Tạo phiếu";
            // 
            // btLuu
            // 
            this.btLuu.AutoSize = true;
            this.btLuu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(557, 320);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 26);
            this.btLuu.TabIndex = 7;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.AutoSize = true;
            this.btSua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(557, 270);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 26);
            this.btSua.TabIndex = 6;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.AutoSize = true;
            this.btXoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(557, 220);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 26);
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.AutoSize = true;
            this.btThem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(557, 170);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 26);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // dgvTaoPM
            // 
            this.dgvTaoPM.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvTaoPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaoPM.Location = new System.Drawing.Point(20, 150);
            this.dgvTaoPM.Name = "dgvTaoPM";
            this.dgvTaoPM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaoPM.Size = new System.Drawing.Size(500, 200);
            this.dgvTaoPM.TabIndex = 8;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Location = new System.Drawing.Point(150, 93);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(160, 22);
            this.dtpNgayMuon.TabIndex = 3;
            // 
            // cboMaDG
            // 
            this.cboMaDG.FormattingEnabled = true;
            this.cboMaDG.Location = new System.Drawing.Point(150, 54);
            this.cboMaDG.Name = "cboMaDG";
            this.cboMaDG.Size = new System.Drawing.Size(160, 24);
            this.cboMaDG.TabIndex = 2;
            // 
            // txtMaPM
            // 
            this.txtMaPM.Location = new System.Drawing.Point(150, 17);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(160, 22);
            this.txtMaPM.TabIndex = 1;
            // 
            // lbNgayMuon
            // 
            this.lbNgayMuon.AutoSize = true;
            this.lbNgayMuon.Location = new System.Drawing.Point(18, 96);
            this.lbNgayMuon.Name = "lbNgayMuon";
            this.lbNgayMuon.Size = new System.Drawing.Size(82, 16);
            this.lbNgayMuon.TabIndex = 0;
            this.lbNgayMuon.Text = "Ngày mượn:";
            // 
            // lbMaDG
            // 
            this.lbMaDG.AutoSize = true;
            this.lbMaDG.Location = new System.Drawing.Point(18, 58);
            this.lbMaDG.Name = "lbMaDG";
            this.lbMaDG.Size = new System.Drawing.Size(76, 16);
            this.lbMaDG.TabIndex = 0;
            this.lbMaDG.Text = "Mã độc giả:";
            // 
            // lbMaPM1
            // 
            this.lbMaPM1.AutoSize = true;
            this.lbMaPM1.Location = new System.Drawing.Point(18, 20);
            this.lbMaPM1.Name = "lbMaPM1";
            this.lbMaPM1.Size = new System.Drawing.Size(105, 16);
            this.lbMaPM1.TabIndex = 0;
            this.lbMaPM1.Text = "Mã phiếu mượn:";
            // 
            // tpChiTieuPhieu
            // 
            this.tpChiTieuPhieu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpChiTieuPhieu.Controls.Add(this.chbDaTra);
            this.tpChiTieuPhieu.Controls.Add(this.button1);
            this.tpChiTieuPhieu.Controls.Add(this.button2);
            this.tpChiTieuPhieu.Controls.Add(this.button3);
            this.tpChiTieuPhieu.Controls.Add(this.button4);
            this.tpChiTieuPhieu.Controls.Add(this.dgvChiTietPM);
            this.tpChiTieuPhieu.Controls.Add(this.dtpNgayTra);
            this.tpChiTieuPhieu.Controls.Add(this.cboMaPM);
            this.tpChiTieuPhieu.Controls.Add(this.cboMaSach);
            this.tpChiTieuPhieu.Controls.Add(this.lbDaTra);
            this.tpChiTieuPhieu.Controls.Add(this.lbNgayTra);
            this.tpChiTieuPhieu.Controls.Add(this.lbMaSach);
            this.tpChiTieuPhieu.Controls.Add(this.lbMaPM2);
            this.tpChiTieuPhieu.Location = new System.Drawing.Point(4, 25);
            this.tpChiTieuPhieu.Name = "tpChiTieuPhieu";
            this.tpChiTieuPhieu.Padding = new System.Windows.Forms.Padding(3);
            this.tpChiTieuPhieu.Size = new System.Drawing.Size(652, 371);
            this.tpChiTieuPhieu.TabIndex = 1;
            this.tpChiTieuPhieu.Text = "Chi tiết phiếu";
            // 
            // chbDaTra
            // 
            this.chbDaTra.AutoSize = true;
            this.chbDaTra.Location = new System.Drawing.Point(467, 64);
            this.chbDaTra.Name = "chbDaTra";
            this.chbDaTra.Size = new System.Drawing.Size(15, 14);
            this.chbDaTra.TabIndex = 4;
            this.chbDaTra.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(558, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(558, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(558, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 26);
            this.button3.TabIndex = 6;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(558, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 26);
            this.button4.TabIndex = 5;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dgvChiTietPM
            // 
            this.dgvChiTietPM.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvChiTietPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPM.Location = new System.Drawing.Point(21, 120);
            this.dgvChiTietPM.Name = "dgvChiTietPM";
            this.dgvChiTietPM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietPM.Size = new System.Drawing.Size(500, 233);
            this.dgvChiTietPM.TabIndex = 9;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Location = new System.Drawing.Point(467, 22);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(160, 22);
            this.dtpNgayTra.TabIndex = 3;
            // 
            // cboMaPM
            // 
            this.cboMaPM.FormattingEnabled = true;
            this.cboMaPM.Location = new System.Drawing.Point(158, 21);
            this.cboMaPM.Name = "cboMaPM";
            this.cboMaPM.Size = new System.Drawing.Size(160, 24);
            this.cboMaPM.TabIndex = 1;
            // 
            // cboMaSach
            // 
            this.cboMaSach.FormattingEnabled = true;
            this.cboMaSach.Location = new System.Drawing.Point(158, 59);
            this.cboMaSach.Name = "cboMaSach";
            this.cboMaSach.Size = new System.Drawing.Size(160, 24);
            this.cboMaSach.TabIndex = 2;
            // 
            // lbDaTra
            // 
            this.lbDaTra.AutoSize = true;
            this.lbDaTra.Location = new System.Drawing.Point(377, 63);
            this.lbDaTra.Name = "lbDaTra";
            this.lbDaTra.Size = new System.Drawing.Size(47, 16);
            this.lbDaTra.TabIndex = 0;
            this.lbDaTra.Text = "Đã trả:";
            // 
            // lbNgayTra
            // 
            this.lbNgayTra.AutoSize = true;
            this.lbNgayTra.Location = new System.Drawing.Point(377, 25);
            this.lbNgayTra.Name = "lbNgayTra";
            this.lbNgayTra.Size = new System.Drawing.Size(61, 16);
            this.lbNgayTra.TabIndex = 0;
            this.lbNgayTra.Text = "Ngày trả:";
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.Location = new System.Drawing.Point(26, 63);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(62, 16);
            this.lbMaSach.TabIndex = 0;
            this.lbMaSach.Text = "Mã sách:";
            // 
            // lbMaPM2
            // 
            this.lbMaPM2.AutoSize = true;
            this.lbMaPM2.Location = new System.Drawing.Point(26, 25);
            this.lbMaPM2.Name = "lbMaPM2";
            this.lbMaPM2.Size = new System.Drawing.Size(105, 16);
            this.lbMaPM2.TabIndex = 0;
            this.lbMaPM2.Text = "Mã phiếu mượn:";
            // 
            // btThoat
            // 
            this.btThoat.AutoSize = true;
            this.btThoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Image = global::QLThuVien.Properties.Resources.icons8_close_24;
            this.btThoat.Location = new System.Drawing.Point(122, 435);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(89, 30);
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
            this.btQuayVe.Location = new System.Drawing.Point(12, 435);
            this.btQuayVe.Name = "btQuayVe";
            this.btQuayVe.Size = new System.Drawing.Size(89, 30);
            this.btQuayVe.TabIndex = 1;
            this.btQuayVe.Text = "Quay về";
            this.btQuayVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuayVe.UseVisualStyleBackColor = true;
            this.btQuayVe.Click += new System.EventHandler(this.btQuayVe_Click);
            // 
            // frmPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(684, 481);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btQuayVe);
            this.Controls.Add(this.tcPhieuMuon);
            this.Name = "frmPhieuMuon";
            this.Text = "Phiếu mượn";
            this.Load += new System.EventHandler(this.frmPhieuMuon_Load);
            this.tcPhieuMuon.ResumeLayout(false);
            this.tpTaoPhieu.ResumeLayout(false);
            this.tpTaoPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaoPM)).EndInit();
            this.tpChiTieuPhieu.ResumeLayout(false);
            this.tpChiTieuPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcPhieuMuon;
        private System.Windows.Forms.TabPage tpTaoPhieu;
        private System.Windows.Forms.DataGridView dgvTaoPM;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.ComboBox cboMaDG;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.Label lbNgayMuon;
        private System.Windows.Forms.Label lbMaDG;
        private System.Windows.Forms.Label lbMaPM1;
        private System.Windows.Forms.TabPage tpChiTieuPhieu;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvChiTietPM;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.ComboBox cboMaSach;
        private System.Windows.Forms.Label lbNgayTra;
        private System.Windows.Forms.Label lbMaSach;
        private System.Windows.Forms.Label lbMaPM2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btQuayVe;
        private System.Windows.Forms.ComboBox cboMaPM;
        private System.Windows.Forms.CheckBox chbDaTra;
        private System.Windows.Forms.Label lbDaTra;
    }
}