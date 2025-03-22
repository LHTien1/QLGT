namespace QuanLyGiaoThong1
{
    partial class FormPhuongTien
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
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvPhuongTien = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgayHetHanBaoHiem = new System.Windows.Forms.DateTimePicker();
            this.txtLoaiPT = new System.Windows.Forms.TextBox();
            this.txtHangSX = new System.Windows.Forms.TextBox();
            this.txtBaoHiem = new System.Windows.Forms.TextBox();
            this.txtNamSX = new System.Windows.Forms.TextBox();
            this.txtMaChuSoHuu = new System.Windows.Forms.TextBox();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuongTien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(605, 66);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sữa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(605, 111);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(605, 153);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(89, 23);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(605, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // dgvPhuongTien
            // 
            this.dgvPhuongTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuongTien.Location = new System.Drawing.Point(12, 228);
            this.dgvPhuongTien.Name = "dgvPhuongTien";
            this.dgvPhuongTien.RowHeadersWidth = 51;
            this.dgvPhuongTien.RowTemplate.Height = 24;
            this.dgvPhuongTien.Size = new System.Drawing.Size(757, 210);
            this.dgvPhuongTien.TabIndex = 19;
            this.dgvPhuongTien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuongTien_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.dtpNgayHetHanBaoHiem);
            this.panel1.Controls.Add(this.txtLoaiPT);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.txtHangSX);
            this.panel1.Controls.Add(this.txtBaoHiem);
            this.panel1.Controls.Add(this.txtNamSX);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtMaChuSoHuu);
            this.panel1.Controls.Add(this.txtBienSo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 199);
            this.panel1.TabIndex = 21;
            // 
            // dtpNgayHetHanBaoHiem
            // 
            this.dtpNgayHetHanBaoHiem.Location = new System.Drawing.Point(124, 151);
            this.dtpNgayHetHanBaoHiem.Name = "dtpNgayHetHanBaoHiem";
            this.dtpNgayHetHanBaoHiem.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayHetHanBaoHiem.TabIndex = 34;
            // 
            // txtLoaiPT
            // 
            this.txtLoaiPT.Location = new System.Drawing.Point(388, 12);
            this.txtLoaiPT.Name = "txtLoaiPT";
            this.txtLoaiPT.Size = new System.Drawing.Size(162, 22);
            this.txtLoaiPT.TabIndex = 32;
            // 
            // txtHangSX
            // 
            this.txtHangSX.Location = new System.Drawing.Point(388, 60);
            this.txtHangSX.Name = "txtHangSX";
            this.txtHangSX.Size = new System.Drawing.Size(162, 22);
            this.txtHangSX.TabIndex = 33;
            // 
            // txtBaoHiem
            // 
            this.txtBaoHiem.Location = new System.Drawing.Point(388, 121);
            this.txtBaoHiem.Name = "txtBaoHiem";
            this.txtBaoHiem.Size = new System.Drawing.Size(162, 22);
            this.txtBaoHiem.TabIndex = 31;
            // 
            // txtNamSX
            // 
            this.txtNamSX.Location = new System.Drawing.Point(91, 111);
            this.txtNamSX.Name = "txtNamSX";
            this.txtNamSX.Size = new System.Drawing.Size(162, 22);
            this.txtNamSX.TabIndex = 30;
            // 
            // txtMaChuSoHuu
            // 
            this.txtMaChuSoHuu.Location = new System.Drawing.Point(124, 60);
            this.txtMaChuSoHuu.Name = "txtMaChuSoHuu";
            this.txtMaChuSoHuu.Size = new System.Drawing.Size(162, 22);
            this.txtMaChuSoHuu.TabIndex = 29;
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(91, 12);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(162, 22);
            this.txtBienSo.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Ivory;
            this.label8.Location = new System.Drawing.Point(296, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Bảo Hiểm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Ivory;
            this.label5.Location = new System.Drawing.Point(19, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mã chủ sở Hữu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Ivory;
            this.label6.Location = new System.Drawing.Point(324, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Loại PT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(19, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ngày hết hạn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(17, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Năm Sx";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Ivory;
            this.label7.Location = new System.Drawing.Point(318, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Hãng SX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Biển số";
            // 
            // FormPhuongTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPhuongTien);
            this.Name = "FormPhuongTien";
            this.Text = "FormPhuongTien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuongTien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvPhuongTien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHanBaoHiem;
        private System.Windows.Forms.TextBox txtLoaiPT;
        private System.Windows.Forms.TextBox txtHangSX;
        private System.Windows.Forms.TextBox txtBaoHiem;
        private System.Windows.Forms.TextBox txtNamSX;
        private System.Windows.Forms.TextBox txtMaChuSoHuu;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}