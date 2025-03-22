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
        }

 
 

            // 🟢 Load dữ liệu phương tiện
            private void FormPhuongTien_Load(object sender, EventArgs e)
            {
                LoadData();
            }

            private void LoadData()
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM PhuongTienGiaoThong";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPhuongTien.DataSource = dt;
                }
            }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đầu vào
                if (string.IsNullOrWhiteSpace(txtBienSo.Text) || string.IsNullOrWhiteSpace(txtLoaiPT.Text))
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
                        cmd.Parameters.AddWithValue("@LoaiPT", txtLoaiPT.Text);
                        cmd.Parameters.AddWithValue("@MaChuSoHuu", txtMaChuSoHuu.Text);
                        cmd.Parameters.AddWithValue("@HangSanXuat", txtHangSX.Text);
                        cmd.Parameters.AddWithValue("@NamSanXuat", int.Parse(txtNamSX.Text)); // Chuyển sang kiểu số
                        cmd.Parameters.AddWithValue("@BaoHiem", txtBaoHiem.Text);
                        cmd.Parameters.AddWithValue("@NgayHetHanBaoHiem", dtpNgayHetHanBaoHiem.Value);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Thêm phương tiện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
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
                        cmd.Parameters.AddWithValue("@LoaiPT", txtLoaiPT.Text);
                        cmd.Parameters.AddWithValue("@MaChuSoHuu", txtMaChuSoHuu.Text);
                        cmd.Parameters.AddWithValue("@HangSanXuat", txtHangSX.Text);
                        cmd.Parameters.AddWithValue("@NamSanXuat", int.Parse(txtNamSX.Text));
                        cmd.Parameters.AddWithValue("@BaoHiem", txtBaoHiem.Text);
                        cmd.Parameters.AddWithValue("@NgayHetHanBaoHiem", dtpNgayHetHanBaoHiem.Value);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Cập nhật phương tiện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
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
                                LoadData();
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
                    adapter.SelectCommand.Parameters.AddWithValue("@LoaiPT", "%" + txtLoaiPT.Text + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPhuongTien.DataSource = dt;
                }
            }

        // 🟢 Khi chọn dòng trong DataGridView, hiển thị lên TextBox
        private void dgvPhuongTien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0)
                {
                    txtBienSo.Text = dgvPhuongTien.Rows[e.RowIndex].Cells["BienSo"].Value.ToString();
                    txtLoaiPT.Text = dgvPhuongTien.Rows[e.RowIndex].Cells["LoaiPT"].Value.ToString();
                    txtMaChuSoHuu.Text = dgvPhuongTien.Rows[e.RowIndex].Cells["MaChuSoHuu"].Value.ToString();
                    txtHangSX.Text = dgvPhuongTien.Rows[e.RowIndex].Cells["HangSanXuat"].Value.ToString();
                    txtNamSX.Text = dgvPhuongTien.Rows[e.RowIndex].Cells["NamSanXuat"].Value.ToString();
                    txtBaoHiem.Text = dgvPhuongTien.Rows[e.RowIndex].Cells["BaoHiem"].Value.ToString();
                    dtpNgayHetHanBaoHiem.Value = Convert.ToDateTime(dgvPhuongTien.Rows[e.RowIndex].Cells["NgayHetHanBaoHiem"].Value);
                }
            }

    
    }
    }

