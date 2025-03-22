namespace QuanLyGiaoThong1
{
    partial class FormTuyenDuong
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
            this.dgvTuyenDuong = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaNguoiPhuTrach = new System.Windows.Forms.TextBox();
            this.txtTenTuyen = new System.Windows.Forms.TextBox();
            this.txtLoaiTuyen = new System.Windows.Forms.TextBox();
            this.txtMaTuyen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyenDuong)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTuyenDuong
            // 
            this.dgvTuyenDuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuyenDuong.Location = new System.Drawing.Point(12, 215);
            this.dgvTuyenDuong.Name = "dgvTuyenDuong";
            this.dgvTuyenDuong.RowHeadersWidth = 51;
            this.dgvTuyenDuong.RowTemplate.Height = 24;
            this.dgvTuyenDuong.Size = new System.Drawing.Size(618, 239);
            this.dgvTuyenDuong.TabIndex = 0;
            this.dgvTuyenDuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuyenDuong_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(509, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(509, 49);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sữa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(509, 85);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(509, 114);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.txtMaNguoiPhuTrach);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTenTuyen);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.txtLoaiTuyen);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.txtMaTuyen);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 172);
            this.panel1.TabIndex = 13;
            // 
            // txtMaNguoiPhuTrach
            // 
            this.txtMaNguoiPhuTrach.Location = new System.Drawing.Point(341, 95);
            this.txtMaNguoiPhuTrach.Name = "txtMaNguoiPhuTrach";
            this.txtMaNguoiPhuTrach.Size = new System.Drawing.Size(130, 22);
            this.txtMaNguoiPhuTrach.TabIndex = 16;
            // 
            // txtTenTuyen
            // 
            this.txtTenTuyen.Location = new System.Drawing.Point(334, 24);
            this.txtTenTuyen.Name = "txtTenTuyen";
            this.txtTenTuyen.Size = new System.Drawing.Size(137, 22);
            this.txtTenTuyen.TabIndex = 15;
            // 
            // txtLoaiTuyen
            // 
            this.txtLoaiTuyen.Location = new System.Drawing.Point(107, 92);
            this.txtLoaiTuyen.Name = "txtLoaiTuyen";
            this.txtLoaiTuyen.Size = new System.Drawing.Size(95, 22);
            this.txtLoaiTuyen.TabIndex = 14;
            // 
            // txtMaTuyen
            // 
            this.txtMaTuyen.Location = new System.Drawing.Point(97, 24);
            this.txtMaTuyen.Name = "txtMaTuyen";
            this.txtMaTuyen.Size = new System.Drawing.Size(126, 22);
            this.txtMaTuyen.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(218, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Người phụ trách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(246, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên Tuyến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(14, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Loại Tuyến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã tuyến";
            // 
            // FormTuyenDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTuyenDuong);
            this.Name = "FormTuyenDuong";
            this.Text = "FormTuyenDuong";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyenDuong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTuyenDuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaNguoiPhuTrach;
        private System.Windows.Forms.TextBox txtTenTuyen;
        private System.Windows.Forms.TextBox txtLoaiTuyen;
        private System.Windows.Forms.TextBox txtMaTuyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}