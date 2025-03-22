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
            LoadComboBoxData();
            }
        private void LoadComboBoxData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Nạp dữ liệu cho Loại Sự Cố
                    string queryLoaiSuCo = "SELECT DISTINCT LoaiSuCo FROM SuCoGiaoThong";
                    SqlCommand cmdLoaiSuCo = new SqlCommand(queryLoaiSuCo, conn);
                    SqlDataReader readerLoaiSuCo = cmdLoaiSuCo.ExecuteReader();
                    cboLoaiSuCo.Items.Clear();
                    while (readerLoaiSuCo.Read())
                    {
                        cboLoaiSuCo.Items.Add(readerLoaiSuCo["LoaiSuCo"].ToString());
                    }
                    readerLoaiSuCo.Close();

                    // Nạp dữ liệu cho Mức Độ Ảnh Hưởng
                    string queryMucDoAnhHuong = "SELECT DISTINCT MucDoAnhHuong FROM SuCoGiaoThong";
                    SqlCommand cmdMucDoAnhHuong = new SqlCommand(queryMucDoAnhHuong, conn);
                    SqlDataReader readerMucDoAnhHuong = cmdMucDoAnhHuong.ExecuteReader();
                    cboMucDoAnhHuong.Items.Clear();
                    while (readerMucDoAnhHuong.Read())
                    {
                        cboMucDoAnhHuong.Items.Add(readerMucDoAnhHuong["MucDoAnhHuong"].ToString());
                    }
                    readerMucDoAnhHuong.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
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
                    cmd.Parameters.AddWithValue("@LoaiSuCo", cboLoaiSuCo.Text);
                    cmd.Parameters.AddWithValue("@ThoiGianXayRa", dtpThoiGianXayRa.Value);
                    cmd.Parameters.AddWithValue("@ViTri", txtViTri.Text);
                    cmd.Parameters.AddWithValue("@MucDoAnhHuong", cboMucDoAnhHuong.Text);
                    cmd.Parameters.AddWithValue("@NguyenNhan", txtNguyenNhan.Text);
                  

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                        MessageBox.Show("Thêm sự cố thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không thể thêm sự cố!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    LoadComboBoxData();
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
                    cmd.Parameters.AddWithValue("@LoaiSuCo", cboLoaiSuCo.Text);
                    cmd.Parameters.AddWithValue("@ThoiGianXayRa", dtpThoiGianXayRa.Value);
                    cmd.Parameters.AddWithValue("@ViTri", txtViTri.Text);
                    cmd.Parameters.AddWithValue("@MucDoAnhHuong", cboMucDoAnhHuong.Text);
                    cmd.Parameters.AddWithValue("@NguyenNhan", txtNguyenNhan.Text);
                  

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                        MessageBox.Show("Cập nhật sự cố thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không tìm thấy sự cố để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    LoadComboBoxData();
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
                        {
                            MessageBox.Show("Xóa sự cố thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Xóa trắng các ô nhập
                            txtMaSuCo.Clear();
                            cboLoaiSuCo.SelectedIndex = -1;
                            txtViTri.Clear();
                            cboMucDoAnhHuong.SelectedIndex = -1;
                            txtNguyenNhan.Clear();
                            dtpThoiGianXayRa.Value = DateTime.Now;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sự cố để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        LoadComboBoxData();
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
                List<string> conditions = new List<string>();
                SqlCommand cmd = new SqlCommand();

                if (!string.IsNullOrEmpty(cboLoaiSuCo.Text))
                {
                    conditions.Add("LoaiSuCo LIKE @LoaiSuCo");
                    cmd.Parameters.AddWithValue("@LoaiSuCo", "%" + cboLoaiSuCo.Text + "%");
                }
                if (!string.IsNullOrEmpty(cboMucDoAnhHuong.Text))
                {
                    conditions.Add("MucDoAnhHuong LIKE @MucDoAnhHuong");
                    cmd.Parameters.AddWithValue("@MucDoAnhHuong", "%" + cboMucDoAnhHuong.Text + "%");
                }
                if (!string.IsNullOrEmpty(txtViTri.Text))
                {
                    conditions.Add("ViTri LIKE @ViTri");
                    cmd.Parameters.AddWithValue("@ViTri", "%" + txtViTri.Text + "%");
                }

                string query = "SELECT * FROM SuCoGiaoThong";
                if (conditions.Count > 0)
                {
                    query += " WHERE " + string.Join(" AND ", conditions);
                }

                cmd.CommandText = query;
                cmd.Connection = conn;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSuCo.DataSource = dt;
            }
        }


        // 🟢 Khi chọn dòng trong DataGridView, hiển thị lên TextBox
        private void dgvSuCo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ số dòng hợp lệ
            {
                DataGridViewRow row = dgvSuCo.Rows[e.RowIndex]; // Lấy dòng được chọn

                // Gán dữ liệu từ dòng vào các ô nhập liệu
                txtMaSuCo.Text = row.Cells["MaSuCo"].Value?.ToString() ?? "Không có dữ liệu";
                cboLoaiSuCo.Text = row.Cells["LoaiSuCo"].Value?.ToString() ?? "Không có dữ liệu";
                txtViTri.Text = row.Cells["ViTri"].Value?.ToString() ?? "Không có dữ liệu";
                cboMucDoAnhHuong.Text = row.Cells["MucDoAnhHuong"].Value?.ToString() ?? "Không có dữ liệu";

                // Xử lý thời gian
                if (row.Cells["ThoiGianXayRa"].Value != null)
                {
                    dtpThoiGianXayRa.Value = (DateTime)row.Cells["ThoiGianXayRa"].Value;
                }
                else
                {
                    dtpThoiGianXayRa.Value = DateTime.Now; // Giá trị mặc định nếu không có thời gian
                }

                // Nguyên nhân
                txtNguyenNhan.Text = row.Cells["NguyenNhan"].Value?.ToString() ?? "Không có dữ liệu";
            }
        }


        private void FormSuCoGiaoThong_Load_1(object sender, EventArgs e)
        {
            // Danh sách loại sự cố
            cboLoaiSuCo.Items.Add("Tai nạn");
            cboLoaiSuCo.Items.Add("Ùn tắc");
            cboLoaiSuCo.Items.Add("Sụt lún");
            // Thêm các mức độ ảnh hưởng vào ComboBox
            cboMucDoAnhHuong.Items.Add("Nhẹ");
            cboMucDoAnhHuong.Items.Add("Trung bình");
            cboMucDoAnhHuong.Items.Add("Nghiêm trọng");

        }
        private void LoadMucDoAnhHuong()
        {
            List<string> mucDoAnhHuong = new List<string>
    {
        "Nhẹ",
        "Trung bình",
        "Nghiêm trọng"
    };

            cboMucDoAnhHuong.DataSource = mucDoAnhHuong; // Gán dữ liệu cho ComboBox
        }
        private void LoadLoaiSuCo()
        {
            List<string> loaiSuCo = new List<string>(); // Tạo danh sách dữ liệu
            loaiSuCo.Add("Tai nạn");
            loaiSuCo.Add("Ùn tắc");
            loaiSuCo.Add("Sụt lún");

            cboLoaiSuCo.DataSource = loaiSuCo; // Gán nguồn dữ liệu cho ComboBox
        }
        private void LoadLoaiSuCoFromDatabase()
        {
            string query = "SELECT TenLoaiSuCo FROM LoaiSuCo"; // Truy vấn dữ liệu
            using (SqlConnection conn = new SqlConnection("your_connection_string"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cboLoaiSuCo.Items.Add(reader["TenLoaiSuCo"].ToString());
                }
            }
        }
      

      
       
    }
    }

