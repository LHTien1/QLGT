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
    public partial class FormPhuongTien : Form
    {
        // 🔹 Chuỗi kết nối SQL Server
        private string connectionString = "Data Source=LAPTOP-7CN4T6IO\\SQLEXPRESS01;Initial Catalog=QuanLyGiaoThong;Integrated Security=True";

        public FormPhuongTien()
        {
            InitializeComponent();
            LoadDataForComboBoxes();
            LoadDataToGrid(); // Hiển thị dữ liệu trong bảng
        }

        private void LoadDataForComboBoxes()
        {
            cboLoaiPT.Items.Clear(); // Xóa dữ liệu cũ
            cboHangSX.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Truy vấn Loại Phương Tiện
                    string queryLoaiPT = "SELECT TenLoaiPhuongTien FROM LoaiPhuongTien";
                    using (SqlCommand cmdLoaiPT = new SqlCommand(queryLoaiPT, conn))
                    using (SqlDataReader readerLoaiPT = cmdLoaiPT.ExecuteReader())
                    {
                        while (readerLoaiPT.Read())
                        {
                            cboLoaiPT.Items.Add(readerLoaiPT["TenLoaiPhuongTien"].ToString());
                        }
                    }

                    // Truy vấn Hãng Sản Xuất
                    string queryHangSX = "SELECT TenHangSX FROM HangSanXuat";
                    using (SqlCommand cmdHangSX = new SqlCommand(queryHangSX, conn))
                    using (SqlDataReader readerHangSX = cmdHangSX.ExecuteReader())
                    {
                        while (readerHangSX.Read())
                        {
                            cboHangSX.Items.Add(readerHangSX["TenHangSX"].ToString());
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Lỗi SQL: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
            private void LoadDataToGrid()
            {
            string query = "SELECT LoaiPhuongTien, HangSanXuat, BienSo, MaChuSoHuu, NamSanXuat, BaoHiem, NgayHetHanBaoHiem FROM PhuongTienGiaoThong";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open(); // 🔴 Đảm bảo mở kết nối trước khi fill dữ liệu

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPhuongTien.DataSource = dt;
                }
            }
        }


        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đầu vào
                if (string.IsNullOrWhiteSpace(txtBienSo.Text) || string.IsNullOrWhiteSpace(cboLoaiPT.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO PhuongTienGiaoThong (BienSo, LoaiPT, MaChuSoHuu, HangSanXuat, NamSanXuat, BaoHiem, NgayHetHanBaoHiem) " +
                                   "VALUES (@BienSo, @LoaiPT, @MaChuSoHuu, @HangSanXuat, @NamSanXuat, @BaoHiem, @NgayHetHanBaoHiem)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BienSo", txtBienSo.Text);
                        cmd.Parameters.AddWithValue("@LoaiPT", cboLoaiPT.Text);
                        cmd.Parameters.AddWithValue("@MaChuSoHuu", txtMaChuSoHuu.Text);
                        cmd.Parameters.AddWithValue("@HangSanXuat", cboHangSX.Text);
                        cmd.Parameters.AddWithValue("@NamSanXuat", int.Parse(txtNamSX.Text)); // Chuyển sang kiểu số
                        cmd.Parameters.AddWithValue("@BaoHiem", txtBaoHiem.Text);
                        cmd.Parameters.AddWithValue("@NgayHetHanBaoHiem", dtpNgayHetHanBaoHiem.Value);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Thêm phương tiện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataForComboBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Năm sản xuất phải là số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🟢 Sửa phương tiện
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE PhuongTienGiaoThong SET LoaiPT=@LoaiPT, MaChuSoHuu=@MaChuSoHuu, HangSanXuat=@HangSanXuat, " +
                                   "NamSanXuat=@NamSanXuat, BaoHiem=@BaoHiem, NgayHetHanBaoHiem=@NgayHetHanBaoHiem WHERE BienSo=@BienSo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BienSo", txtBienSo.Text);
                        cmd.Parameters.AddWithValue("@LoaiPT", cboLoaiPT.Text);
                        cmd.Parameters.AddWithValue("@MaChuSoHuu", txtMaChuSoHuu.Text);
                        cmd.Parameters.AddWithValue("@HangSanXuat", cboHangSX.Text);
                        cmd.Parameters.AddWithValue("@NamSanXuat", int.Parse(txtNamSX.Text));
                        cmd.Parameters.AddWithValue("@BaoHiem", txtBaoHiem.Text);
                        cmd.Parameters.AddWithValue("@NgayHetHanBaoHiem", dtpNgayHetHanBaoHiem.Value);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Cập nhật phương tiện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataForComboBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy phương tiện để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Năm sản xuất phải là số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🟢 Xóa phương tiện
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phương tiện này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM PhuongTienGiaoThong WHERE BienSo=@BienSo";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@BienSo", txtBienSo.Text);

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa phương tiện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDataForComboBoxes();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy phương tiện để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 🟢 Tìm kiếm phương tiện
        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM PhuongTienGiaoThong WHERE LoaiPT LIKE @LoaiPT";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@LoaiPT", "%" + cboLoaiPT.Text + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPhuongTien.DataSource = dt;
                }
            }

        // 🟢 Khi chọn dòng trong DataGridView, hiển thị lên TextBox
        private void dgvPhuongTien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra dòng hợp lệ
            {
                DataGridViewRow row = dgvPhuongTien.Rows[e.RowIndex];

                // Lấy giá trị từ DataGridView
                string loaiPT = row.Cells["LoaiPhuongTien"].Value?.ToString();
                string hangSX = row.Cells["HangSanXuat"].Value?.ToString();

                // Kiểm tra và thêm giá trị vào ComboBox nếu chưa tồn tại
                if (!string.IsNullOrEmpty(loaiPT) && !cboLoaiPT.Items.Contains(loaiPT))
                {
                    cboLoaiPT.Items.Add(loaiPT);
                }
                cboLoaiPT.Text = loaiPT ?? "Không có dữ liệu";

                if (!string.IsNullOrEmpty(hangSX) && !cboHangSX.Items.Contains(hangSX))
                {
                    cboHangSX.Items.Add(hangSX);
                }
                cboHangSX.Text = hangSX ?? "Không có dữ liệu";

                // Gán các giá trị khác
                txtBienSo.Text = row.Cells["BienSo"].Value?.ToString();
                txtMaChuSoHuu.Text = row.Cells["MaChuSoHuu"].Value?.ToString();
                txtNamSX.Text = row.Cells["NamSanXuat"].Value?.ToString();
                txtBaoHiem.Text = row.Cells["BaoHiem"].Value?.ToString();

                // Kiểm tra giá trị ngày
                if (row.Cells["NgayHetHanBaoHiem"].Value != DBNull.Value)
                {
                    dtpNgayHetHanBaoHiem.Value = Convert.ToDateTime(row.Cells["NgayHetHanBaoHiem"].Value);
                }
                else
                {
                    dtpNgayHetHanBaoHiem.Value = DateTime.Now;
                }
            }
        }





        // 🟢 Load dữ liệu phương tiện
        private void FormPhuongTien_Load(object sender, EventArgs e)
        {
      
   
            // Populate Loại PT ComboBox
            cboLoaiPT.Items.AddRange(new string[] { "Ô tô", "Xe máy", "Xe tải", "Xe đạp" });

            // Populate Hãng SX ComboBox
            cboHangSX.Items.AddRange(new string[] { "Toyota", "Honda", "Isuzu", "Yamaha" });
        }
    }

}


