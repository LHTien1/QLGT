using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyGiaoThong1
{
    public partial class FormBaoCao : Form
    {
        private string connectionString = "Data Source=LAPTOP-7CN4T6IO\\SQLEXPRESS01;Initial Catalog=QuanLyGiaoThong;Integrated Security=True";
        public FormBaoCao()
        {
            InitializeComponent();
        }




        // 🟢 Sự kiện khi nhấn nút "Thống Kê"
        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // 📝 Truy vấn thống kê số lượng sự cố theo loại
                    string query = "SELECT LoaiSuCo, COUNT(*) AS SoLuong FROM SuCoGiaoThong GROUP BY LoaiSuCo";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Hiển thị dữ liệu lên DataGridView
                    dgvBaoCao.DataSource = dt;

                    // Vẽ biểu đồ thống kê
                    chartThongKe.Series.Clear();
                    Series series = new Series("Sự Cố Giao Thông");
                    series.ChartType = SeriesChartType.Column; // Cột đứng (Column Chart)

                    foreach (DataRow row in dt.Rows)
                    {
                        series.Points.AddXY(row["LoaiSuCo"].ToString(), Convert.ToInt32(row["SoLuong"]));
                    }

                    chartThongKe.Series.Add(series);
                }
            }

        private void dgvBaoCao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

