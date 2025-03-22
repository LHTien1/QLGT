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
    public partial class FormSuCoGiaoThong : Form
    {
        private string connectionString = "Data Source=LAPTOP-7CN4T6IO\\SQLEXPRESS01;Initial Catalog=QuanLyGiaoThong;Integrated Security=True";
        public FormSuCoGiaoThong()
        {
            InitializeComponent();
        }

   
   
   

            // 🟢 Load dữ liệu sự cố
            private void FormSuCoGiaoThong_Load(object sender, EventArgs e)
            {
                LoadData();
            }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM SuCoGiaoThong"; // Đảm bảo bảng có cột 'ThoiGianXayRa'
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // In danh sách cột từ DataTable
                foreach (DataColumn col in dt.Columns)
                {
                    Console.WriteLine($"Cột từ SQL: {col.ColumnName}");
                }

                dgvSuCo.DataSource = dt;
            }
        }


        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSuCo.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Sự Cố!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO SuCoGiaoThong (MaSuCo, LoaiSuCo, ViTri, MucDoAnhHuong, NguyenNhan, ThoiGianXayRa) " +
                                   "VALUES (@MaSuCo, @LoaiSuCo, @ViTri, @MucDoAnhHuong, @NguyenNhan, @ThoiGianXayRa)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@MaSuCo", int.TryParse(txtMaSuCo.Text, out int maSuCo) ? maSuCo : throw new Exception("Mã sự cố phải là số!"));
                    cmd.Parameters.AddWithValue("@LoaiSuCo", txtLoaiSuCo.Text);
                    cmd.Parameters.AddWithValue("@ViTri", txtViTri.Text);
                    cmd.Parameters.AddWithValue("@MucDoAnhHuong", txtMucDoAnhHuong.Text);
                    cmd.Parameters.AddWithValue("@NguyenNhan", txtNguyenNhan.Text);
                    cmd.Parameters.AddWithValue("@ThoiGianXayRa", dtpThoiGianXayRa.Value);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                        MessageBox.Show("Thêm sự cố thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không thể thêm sự cố!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // 🟢 Sửa sự cố
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSuCo.Text))
            {
                MessageBox.Show("Vui lòng chọn một sự cố để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE SuCoGiaoThong SET LoaiSuCo=@LoaiSuCo, ViTri=@ViTri, MucDoAnhHuong=@MucDoAnhHuong, " +
                                   "NguyenNhan=@NguyenNhan, ThoiGianXayRa=@ThoiGianXayRa WHERE MaSuCo=@MaSuCo";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@MaSuCo", int.TryParse(txtMaSuCo.Text, out int maSuCo) ? maSuCo : throw new Exception("Mã sự cố phải là số!"));
                    cmd.Parameters.AddWithValue("@LoaiSuCo", txtLoaiSuCo.Text);
                    cmd.Parameters.AddWithValue("@ViTri", txtViTri.Text);
                    cmd.Parameters.AddWithValue("@MucDoAnhHuong", txtMucDoAnhHuong.Text);
                    cmd.Parameters.AddWithValue("@NguyenNhan", txtNguyenNhan.Text);
                    cmd.Parameters.AddWithValue("@ThoiGianXayRa", dtpThoiGianXayRa.Value);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                        MessageBox.Show("Cập nhật sự cố thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không tìm thấy sự cố để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // 🟢 Xóa sự cố
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSuCo.Text))
            {
                MessageBox.Show("Vui lòng chọn một sự cố để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sự cố này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM SuCoGiaoThong WHERE MaSuCo=@MaSuCo";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaSuCo", int.TryParse(txtMaSuCo.Text, out int maSuCo) ? maSuCo : throw new Exception("Mã sự cố phải là số!"));

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (rowsAffected > 0)
                            MessageBox.Show("Xóa sự cố thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Không tìm thấy sự cố để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // 🟢 Tìm kiếm sự cố
        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM SuCoGiaoThong WHERE LoaiSuCo LIKE @LoaiSuCo";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@LoaiSuCo", "%" + txtLoaiSuCo.Text + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSuCo.DataSource = dt;
                }
            }

        // 🟢 Khi chọn dòng trong DataGridView, hiển thị lên TextBox
        private void dgvSuCo_CellContentClick(object sender, DataGridViewCellEventArgs e)        {
            if (e.RowIndex >= 0)
            {
                txtMaSuCo.Text = dgvSuCo.Rows[e.RowIndex].Cells["MaSuCo"].Value?.ToString();
                txtLoaiSuCo.Text = dgvSuCo.Rows[e.RowIndex].Cells["LoaiSuCo"].Value?.ToString();
                txtViTri.Text = dgvSuCo.Rows[e.RowIndex].Cells["ViTri"].Value?.ToString();
                txtMucDoAnhHuong.Text = dgvSuCo.Rows[e.RowIndex].Cells["MucDoAnhHuong"].Value?.ToString();

                // Kiểm tra cột có tồn tại trước khi truy cập
                if (dgvSuCo.Columns.Contains("NguyenNhan") && dgvSuCo.Rows[e.RowIndex].Cells["NguyenNhan"].Value != null)
                {
                    txtNguyenNhan.Text = dgvSuCo.Rows[e.RowIndex].Cells["NguyenNhan"].Value.ToString();
                }
                else
                {
                    txtNguyenNhan.Text = "Không có dữ liệu";
                }

                if (dgvSuCo.Columns.Contains("ThoiGianXayRa") && dgvSuCo.Rows[e.RowIndex].Cells["ThoiGianXayRa"].Value != null)
                {
                    dtpThoiGianXayRa.Value = Convert.ToDateTime(dgvSuCo.Rows[e.RowIndex].Cells["ThoiGianXayRa"].Value);
                }
                else
                {
                    dtpThoiGianXayRa.Value = DateTime.Now; // Gán giá trị mặc định
                }
            }
        }


        private void FormSuCoGiaoThong_Load_1(object sender, EventArgs e)
        {

        }

        

        

        

    }
    }

