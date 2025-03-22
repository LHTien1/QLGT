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
    public partial class FormTuyenDuong : Form
    {
        private string connectionString = "Data Source=LAPTOP-7CN4T6IO\\SQLEXPRESS01;Initial Catalog=QuanLyGiaoThong;Integrated Security=True";

        public FormTuyenDuong()
        {
            InitializeComponent();
        }

            // 🔹 Chuỗi kết nối SQL Server


            // 🟢 Load dữ liệu tuyến đường
            private void FormTuyenDuong_Load(object sender, EventArgs e)
            {
                LoadData();
            }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM TuyenDuong"; // Lấy dữ liệu từ bảng TuyenDuong
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvTuyenDuong.DataSource = dt; // Gán dữ liệu vào DataGridView

                    // Nếu có dữ liệu, hiển thị dòng đầu tiên lên TextBox
                    if (dt.Rows.Count > 0)
                    {
                        dgvTuyenDuong.Rows[0].Selected = true; // Chọn dòng đầu tiên
                        HienThiThongTinLenTextBox(0); // Hiển thị lên TextBox
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiThongTinLenTextBox(int rowIndex)
        {
            if (dgvTuyenDuong.Rows.Count > 0 && rowIndex >= 0)
            {
                txtMaTuyen.Text = dgvTuyenDuong.Rows[rowIndex].Cells["MaTuyen"].Value?.ToString();
                txtTenTuyen.Text = dgvTuyenDuong.Rows[rowIndex].Cells["TenTuyen"].Value?.ToString();
                txtLoaiTuyen.Text = dgvTuyenDuong.Rows[rowIndex].Cells["LoaiTuyen"].Value?.ToString();
                txtMaNguoiPhuTrach.Text = dgvTuyenDuong.Rows[rowIndex].Cells["MaNguoiPhuTrach"].Value?.ToString();
            }
        }



        // 🟢 Thêm tuyến đường
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTuyen.Text) || string.IsNullOrWhiteSpace(txtMaNguoiPhuTrach.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem MaNguoiPhuTrach có tồn tại trong bảng NguoiDan không
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string checkQuery = "SELECT COUNT(*) FROM NguoiDan WHERE MaNguoiDan = @MaNguoiDan";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MaNguoiDan", txtMaNguoiPhuTrach.Text.Trim());

                conn.Open();
                int count = (int)checkCmd.ExecuteScalar();
                conn.Close();

                if (count == 0)
                {
                    MessageBox.Show("Mã Người Dân không tồn tại! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO TuyenDuong (MaTuyen, TenTuyen, LoaiTuyen, MaNguoiPhuTrach) " +
                                   "VALUES (@MaTuyen, @TenTuyen, @LoaiTuyen, @MaNguoiPhuTrach)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaTuyen", txtMaTuyen.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenTuyen", txtTenTuyen.Text.Trim());
                    cmd.Parameters.AddWithValue("@LoaiTuyen", txtLoaiTuyen.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaNguoiPhuTrach", txtMaNguoiPhuTrach.Text.Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // 🟢 Sửa tuyến đường
        private void btnSua_Click(object sender, EventArgs e) 
        {
            if (string.IsNullOrWhiteSpace(txtMaTuyen.Text))
            {
                MessageBox.Show("Vui lòng nhập mã tuyến!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Kiểm tra MaTuyen có tồn tại không
                string checkTuyen = "SELECT COUNT(*) FROM TuyenDuong WHERE MaTuyen = @MaTuyen";
                SqlCommand cmdCheckTuyen = new SqlCommand(checkTuyen, conn);
                cmdCheckTuyen.Parameters.AddWithValue("@MaTuyen", txtMaTuyen.Text);
                int countTuyen = (int)cmdCheckTuyen.ExecuteScalar();

                if (countTuyen == 0)
                {
                    MessageBox.Show("Mã tuyến không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra MaNguoiPhuTrach có tồn tại không
                string checkNguoi = "SELECT COUNT(*) FROM NguoiDan WHERE MaNguoiDan = @MaNguoiPhuTrach";
                SqlCommand cmdCheckNguoi = new SqlCommand(checkNguoi, conn);
                cmdCheckNguoi.Parameters.AddWithValue("@MaNguoiPhuTrach", txtMaNguoiPhuTrach.Text);
                int countNguoi = (int)cmdCheckNguoi.ExecuteScalar();

                if (countNguoi == 0)
                {
                    MessageBox.Show("Mã Người Phụ Trách không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cập nhật dữ liệu
                string query = "UPDATE TuyenDuong SET TenTuyen=@TenTuyen, LoaiTuyen=@LoaiTuyen, MaNguoiPhuTrach=@MaNguoiPhuTrach WHERE MaTuyen=@MaTuyen";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaTuyen", txtMaTuyen.Text.Trim());
                cmd.Parameters.AddWithValue("@TenTuyen", txtTenTuyen.Text.Trim());
                cmd.Parameters.AddWithValue("@LoaiTuyen", txtLoaiTuyen.Text.Trim());
                cmd.Parameters.AddWithValue("@MaNguoiPhuTrach", txtMaNguoiPhuTrach.Text.Trim());

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cập nhật tuyến đường thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }


        // 🟢 Xóa tuyến đường
        private void btnXoa_Click_1(object sender, EventArgs e)

        {
            if (string.IsNullOrWhiteSpace(txtMaTuyen.Text))
            {
                MessageBox.Show("Vui lòng chọn tuyến đường để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem MaTuyen có phải là số không (nếu MaTuyen là INT trong DB)
            if (!int.TryParse(txtMaTuyen.Text.Trim(), out int maTuyen))
            {
                MessageBox.Show("Mã tuyến không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tuyến đường này?",
                                                  "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM TuyenDuong WHERE MaTuyen = @MaTuyen";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaTuyen", maTuyen);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa tuyến đường thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtMaTuyen.Clear();  // Xóa ô nhập sau khi xóa thành công
                            LoadData(); // Cập nhật lại danh sách
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã tuyến để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        // 🟢 Tìm kiếm tuyến đường
        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM TuyenDuong WHERE TenTuyen LIKE @TenTuyen";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@TenTuyen", "%" + txtTenTuyen.Text + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvTuyenDuong.DataSource = dt;
                }
            }

        // 🟢 Khi chọn dòng trong DataGridView, hiển thị lên TextBox
        private void dgvTuyenDuong_CellContentClick(object sender, DataGridViewCellEventArgs e)     
        {
            if (e.RowIndex >= 0)
            {
                txtMaTuyen.Text = dgvTuyenDuong.Rows[e.RowIndex].Cells["MaTuyen"].Value?.ToString();
                txtTenTuyen.Text = dgvTuyenDuong.Rows[e.RowIndex].Cells["TenTuyen"].Value?.ToString();
                txtLoaiTuyen.Text = dgvTuyenDuong.Rows[e.RowIndex].Cells["LoaiTuyen"].Value?.ToString();
                txtMaNguoiPhuTrach.Text = dgvTuyenDuong.Rows[e.RowIndex].Cells["MaNguoiPhuTrach"].Value?.ToString();
            }
        }

        private void dgvTuyenDuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                HienThiThongTinLenTextBox(e.RowIndex);
            }
        }


    }
}

