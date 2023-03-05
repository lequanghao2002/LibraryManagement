
namespace QLThuVien
{
    partial class frmTheLoai
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
            this.btLuu = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvTheLoai = new System.Windows.Forms.DataGridView();
            this.lbMaTL = new System.Windows.Forms.Label();
            this.lbTenTL = new System.Windows.Forms.Label();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btQuayVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // btLuu
            // 
            this.btLuu.AutoSize = true;
            this.btLuu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(390, 280);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 26);
            this.btLuu.TabIndex = 6;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.AutoSize = true;
            this.btSua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(390, 230);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 26);
            this.btSua.TabIndex = 5;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.AutoSize = true;
            this.btXoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(390, 180);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 26);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.AutoSize = true;
            this.btThem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(390, 130);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 26);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // dgvTheLoai
            // 
            this.dgvTheLoai.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheLoai.Location = new System.Drawing.Point(20, 110);
            this.dgvTheLoai.Name = "dgvTheLoai";
            this.dgvTheLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheLoai.Size = new System.Drawing.Size(330, 200);
            this.dgvTheLoai.TabIndex = 7;
            // 
            // lbMaTL
            // 
            this.lbMaTL.AutoSize = true;
            this.lbMaTL.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTL.Location = new System.Drawing.Point(20, 25);
            this.lbMaTL.Name = "lbMaTL";
            this.lbMaTL.Size = new System.Drawing.Size(76, 16);
            this.lbMaTL.TabIndex = 0;
            this.lbMaTL.Text = "Mã thể loại:";
            // 
            // lbTenTL
            // 
            this.lbTenTL.AutoSize = true;
            this.lbTenTL.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTL.Location = new System.Drawing.Point(20, 63);
            this.lbTenTL.Name = "lbTenTL";
            this.lbTenTL.Size = new System.Drawing.Size(79, 16);
            this.lbTenTL.TabIndex = 0;
            this.lbTenTL.Text = "Tên thể loại:";
            // 
            // txtMaTL
            // 
            this.txtMaTL.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTL.Location = new System.Drawing.Point(130, 22);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(140, 22);
            this.txtMaTL.TabIndex = 1;
            // 
            // txtTenTL
            // 
            this.txtTenTL.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTL.Location = new System.Drawing.Point(130, 60);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(140, 22);
            this.txtTenTL.TabIndex = 2;
            // 
            // btThoat
            // 
            this.btThoat.AutoSize = true;
            this.btThoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Image = global::QLThuVien.Properties.Resources.icons8_close_24;
            this.btThoat.Location = new System.Drawing.Point(130, 330);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(89, 30);
            this.btThoat.TabIndex = 9;
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
            this.btQuayVe.Location = new System.Drawing.Point(20, 330);
            this.btQuayVe.Name = "btQuayVe";
            this.btQuayVe.Size = new System.Drawing.Size(89, 30);
            this.btQuayVe.TabIndex = 8;
            this.btQuayVe.Text = "Quay về";
            this.btQuayVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuayVe.UseVisualStyleBackColor = true;
            this.btQuayVe.Click += new System.EventHandler(this.btQuayVe_Click);
            // 
            // frmTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(484, 381);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btQuayVe);
            this.Controls.Add(this.txtTenTL);
            this.Controls.Add(this.txtMaTL);
            this.Controls.Add(this.lbTenTL);
            this.Controls.Add(this.lbMaTL);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dgvTheLoai);
            this.Name = "frmTheLoai";
            this.Text = "Thể loại";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgvTheLoai;
        private System.Windows.Forms.Label lbMaTL;
        private System.Windows.Forms.Label lbTenTL;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.TextBox txtTenTL;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btQuayVe;
    }
}