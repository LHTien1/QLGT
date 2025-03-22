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

namespace QuanLyGiaoThong1
{
    public partial class FormThongKePhuongTien : Form
    {
        private string connectionString = "Data Source=LAPTOP-7CN4T6IO\\SQLEXPRESS01;Initial Catalog=QuanLyGiaoThong;Integrated Security=True";

        public FormThongKePhuongTien()
        {
            InitializeComponent();
        }

 
         

            private void FormThongKePhuongTien_Load(object sender, EventArgs e)
            {
                TaiDuLieuThongKe();
            }

            private void TaiDuLieuThongKe()
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                    SELECT LoaiPT AS [Loại phương tiện], COUNT(*) AS [Số lượng]
                    FROM PhuongTienGiaoThong
                    GROUP BY LoaiPT
                    ORDER BY COUNT(*) DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvThongKe.DataSource = dt;
                }
            }

        private void btnTaiDuLieu_Click(object sender, EventArgs e)
        {
                TaiDuLieuThongKe();
            }

        private void btnDong_Click(object sender, EventArgs e)
        {
                this.Close();
            }

        private void dgvThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }


     


