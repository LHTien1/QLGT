﻿using System;
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
    public partial class FormNhanViencs : Form
    {        // 🔹 Chuỗi kết nối SQL Server
        private string connectionString = "Data Source=LAPTOP-7CN4T6IO\\SQLEXPRESS01;Initial Catalog=QuanLyGiaoThong;Integrated Security=True";

        public FormNhanViencs()
        {
            InitializeComponent();
        }
            // 🟢 Load dữ liệu nhân viên
            private void FormNhanVien_Load(object sender, EventArgs e)
            {
                LoadData();
            }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NhanVien";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvNhanVien.DataSource = dt;

                // Chọn dòng đầu tiên nếu có dữ liệu
                if (dgvNhanVien.Rows.Count > 0)
                {
                    dgvNhanVien.Rows[0].Selected = true;
                    HienThiThongTinTuDong(0);
                }
            }
        }
        private void HienThiThongTinTuDong(int rowIndex)
        {
            if (rowIndex >= 0 && dgvNhanVien.Rows.Count > rowIndex)
            {
                txtMaNV.Text = dgvNhanVien.Rows[rowIndex].Cells["MaNV"].Value.ToString();
                txtHoTen.Text = dgvNhanVien.Rows[rowIndex].Cells["HoTen"].Value.ToString();
                txtMaTuyen.Text = dgvNhanVien.Rows[rowIndex].Cells["MaTuyen"].Value.ToString();
            }
        }


        // 🟢 Thêm nhân viên
        private void btnThem_Click(object sender, EventArgs e)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO NhanVien (MaNV, HoTen, MaTuyen) VALUES (@MaNV, @HoTen, @MaTuyen)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@MaTuyen", txtMaTuyen.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }

        // 🟢 Sửa nhân viên
        private void btnSua_Click(object sender, EventArgs e)
        {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE NhanVien SET HoTen=@HoTen, MaTuyen=@MaTuyen WHERE MaNV=@MaNV";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@MaTuyen", txtMaTuyen.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }

        // 🟢 Xóa nhân viên
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM NhanVien WHERE MaNV=@MaNV";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
            }

        // 🟢 Tìm kiếm nhân viên
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM NhanVien WHERE HoTen LIKE @HoTen";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@HoTen", "%" + txtHoTen.Text + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvNhanVien.DataSource = dt;
                }
            }

        // 🟢 Khi chọn dòng trong DataGridView, hiển thị lên TextBox
        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0)
                {
                    txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                    txtHoTen.Text = dgvNhanVien.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                    txtMaTuyen.Text = dgvNhanVien.Rows[e.RowIndex].Cells["MaTuyen"].Value.ToString();
                }
            if (e.RowIndex >= 0)
            {
                HienThiThongTinTuDong(e.RowIndex);
            }
        }

        
        
    }
   
}



