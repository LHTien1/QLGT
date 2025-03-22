namespace QuanLyGiaoThong1
{
    partial class FormSuCoGiaoThong
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
            this.dgvSuCo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNguyenNhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpThoiGianXayRa = new System.Windows.Forms.DateTimePicker();
            this.txtMucDoAnhHuong = new System.Windows.Forms.TextBox();
            this.txtLoaiSuCo = new System.Windows.Forms.TextBox();
            this.txtMaSuCo = new System.Windows.Forms.TextBox();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuCo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(617, 64);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 23);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sữa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(617, 102);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(617, 143);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(89, 23);
            this.btnTimKiem.TabIndex = 16;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(617, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 23);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // dgvSuCo
            // 
            this.dgvSuCo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuCo.Location = new System.Drawing.Point(12, 244);
            this.dgvSuCo.Name = "dgvSuCo";
            this.dgvSuCo.RowHeadersWidth = 51;
            this.dgvSuCo.RowTemplate.Height = 24;
            this.dgvSuCo.Size = new System.Drawing.Size(735, 191);
            this.dgvSuCo.TabIndex = 20;
            this.dgvSuCo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuCo_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.txtNguyenNhan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.dtpThoiGianXayRa);
            this.panel1.Controls.Add(this.txtMucDoAnhHuong);
            this.panel1.Controls.Add(this.txtLoaiSuCo);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtMaSuCo);
            this.panel1.Controls.Add(this.txtViTri);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 178);
            this.panel1.TabIndex = 23;
            // 
            // txtNguyenNhan
            // 
            this.txtNguyenNhan.Location = new System.Drawing.Point(438, 128);
            this.txtNguyenNhan.Name = "txtNguyenNhan";
            this.txtNguyenNhan.Size = new System.Drawing.Size(112, 22);
            this.txtNguyenNhan.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(309, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nguyên nhân";
            // 
            // dtpThoiGianXayRa
            // 
            this.dtpThoiGianXayRa.Location = new System.Drawing.Point(92, 128);
            this.dtpThoiGianXayRa.Name = "dtpThoiGianXayRa";
            this.dtpThoiGianXayRa.Size = new System.Drawing.Size(200, 22);
            this.dtpThoiGianXayRa.TabIndex = 32;
            // 
            // txtMucDoAnhHuong
            // 
            this.txtMucDoAnhHuong.Location = new System.Drawing.Point(358, 68);
            this.txtMucDoAnhHuong.Name = "txtMucDoAnhHuong";
            this.txtMucDoAnhHuong.Size = new System.Drawing.Size(149, 22);
            this.txtMucDoAnhHuong.TabIndex = 31;
            // 
            // txtLoaiSuCo
            // 
            this.txtLoaiSuCo.Location = new System.Drawing.Point(335, 6);
            this.txtLoaiSuCo.Name = "txtLoaiSuCo";
            this.txtLoaiSuCo.Size = new System.Drawing.Size(112, 22);
            this.txtLoaiSuCo.TabIndex = 30;
            // 
            // txtMaSuCo
            // 
            this.txtMaSuCo.Location = new System.Drawing.Point(107, 12);
            this.txtMaSuCo.Name = "txtMaSuCo";
            this.txtMaSuCo.Size = new System.Drawing.Size(111, 22);
            this.txtMaSuCo.TabIndex = 29;
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(61, 65);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(112, 22);
            this.txtViTri.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(10, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Thời Gian";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(245, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Loại sự cố";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(206, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mức độ ảnh hưởng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Vị trí";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã Sự Cố";
            // 
            // FormSuCoGiaoThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSuCo);
            this.Name = "FormSuCoGiaoThong";
            this.Text = "FormSuCoGiaoThong";
            this.Load += new System.EventHandler(this.FormSuCoGiaoThong_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuCo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvSuCo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNguyenNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpThoiGianXayRa;
        private System.Windows.Forms.TextBox txtMucDoAnhHuong;
        private System.Windows.Forms.TextBox txtLoaiSuCo;
        private System.Windows.Forms.TextBox txtMaSuCo;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}