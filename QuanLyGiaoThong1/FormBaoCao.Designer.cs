namespace QuanLyGiaoThong1
{
    partial class FormBaoCao
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Location = new System.Drawing.Point(12, 81);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.RowHeadersWidth = 51;
            this.dgvBaoCao.RowTemplate.Height = 24;
            this.dgvBaoCao.Size = new System.Drawing.Size(741, 130);
            this.dgvBaoCao.TabIndex = 0;
            this.dgvBaoCao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaoCao_CellContentClick);
            // 
            // chartThongKe
            // 
            chartArea5.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend5);
            this.chartThongKe.Location = new System.Drawing.Point(12, 226);
            this.chartThongKe.Name = "chartThongKe";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartThongKe.Series.Add(series5);
            this.chartThongKe.Size = new System.Drawing.Size(755, 310);
            this.chartThongKe.TabIndex = 1;
            this.chartThongKe.Text = "chart1";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(12, 25);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(130, 32);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click_1);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(713, 542);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 35);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.chartThongKe);
            this.Controls.Add(this.dgvBaoCao);
            this.Name = "FormBaoCao";
            this.Text = "FormBaoCao";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnDong;
    }
}