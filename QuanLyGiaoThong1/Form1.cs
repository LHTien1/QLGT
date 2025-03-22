using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyGiaoThong1
{
    public partial class Form1 : Form
    {
        // 🔹 Connection String (Cập nhật lại đúng tên SQL Server của bạn)
        private string connectionString = "Data Source=LAPTOP-7CN4T6IO\\SQLEXPRESS01;Initial Catalog=QuanLyGiaoThong;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        // 🔹 Kiểm tra kết nối SQL
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(connectionString))
        //        {
        //            conn.Open();
        //            lblThongBao.Text = "Kết nối CSDL thành công!";
        //            lblThongBao.ForeColor = System.Drawing.Color.Green;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        lblThongBao.Text = "Lỗi kết nối CSDL!";
        //        lblThongBao.ForeColor = System.Drawing.Color.Red;
        //        MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        // 🔹 Xử lý sự kiện đăng nhập
        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (taiKhoan == "" || matKhau == "")
            {
                lblThongBao.Text = "Vui lòng nhập đầy đủ thông tin!";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (KiemTraDangNhap(taiKhoan, matKhau))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 🔹 Mở FormMain
                FormMain frmMain = new FormMain();
                frmMain.Show();
                this.Hide(); // Ẩn form đăng nhập
            }
            else
            {
                lblThongBao.Text = "Sai tài khoản hoặc mật khẩu!";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
            }
        }

        // 🔹 Hàm kiểm tra tài khoản từ CSDL
        private bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Kiểm tra trong CSDL
                string query = "SELECT COUNT(*) FROM NguoiDung WHERE TaiKhoan=@TaiKhoan AND MatKhau=@MatKhau";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Nếu có tài khoản, trả về true
                }
            }
        }

        // 🔹 Thoát chương trình
        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btndk_Click(object sender, EventArgs e)
        {

        }

    
   
    }
}
