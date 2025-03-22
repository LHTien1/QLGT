using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaoThong1
{
    public partial class FormHuongDan : Form
    {
        public FormHuongDan()
        {
            InitializeComponent();
        }



        private void FormHuongDan_Load_1(object sender, EventArgs e)
        {
                // Nội dung hướng dẫn sử dụng phần mềm
                richTextBox1.Text =
                    "📌 HƯỚNG DẪN SỬ DỤNG PHẦN MỀM QUẢN LÝ GIAO THÔNG\n\n" +
                    "1️⃣ **Đăng nhập**:\n   - Nhập tài khoản & mật khẩu rồi bấm [Đăng nhập].\n\n" +
                    "2️⃣ **Quản lý Tuyến Đường**:\n   - Thêm/Sửa/Xóa tuyến đường.\n\n" +
                    "3️⃣ **Quản lý Nhân Viên**:\n   - Xem danh sách nhân viên phụ trách tuyến đường.\n\n" +
                    "4️⃣ **Quản lý Phương Tiện**:\n   - Quản lý danh sách phương tiện giao thông.\n\n" +
                    "5️⃣ **Quản lý Sự Cố Giao Thông**:\n   - Ghi nhận và xử lý sự cố trên đường.\n\n" +
                    "6️⃣ **Báo cáo & Thống kê**:\n   - Xem báo cáo tổng hợp về phương tiện & sự cố.\n\n" +
                    "📞 **Hỗ trợ kỹ thuật**: Liên hệ admin để biết thêm chi tiết.";
            }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
            }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        
    }
    }

