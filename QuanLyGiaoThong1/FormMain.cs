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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_Layout(object sender, LayoutEventArgs e)
        {

        }
        // Xử lý đăng xuất
        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 frmLogin = new Form1();
                frmLogin.Show();
            }
        }

        // Xử lý thoát chương trình
        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Mở Form Quản Lý Tuyến Đường

        private void tuyếnĐườngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTuyenDuong());
        }

        // Mở Form Quản Lý Nhân Viên
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhanViencs());
        }


        // Mở Form Quản Lý Phương Tiện
        private void phươngTiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPhuongTien());
        }

        // Mở Form Quản Lý Sự Cố Giao Thông
        private void sựCốGiaoThôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSuCoGiaoThong());
        }

        // Hàm mở form con trong panelContent
        private void OpenChildForm(Form childForm)
        {
            panelContent.Controls.Clear();
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            childForm.Show();
        }

        private void thốngKêSựCốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCao frmThongKeSuCo = new FormBaoCao();
            frmThongKeSuCo.Show();
        }

        private void thốngKêPhươngTiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormThongKePhuongTien frmThongKePhuongTien = new FormThongKePhuongTien();
            frmThongKePhuongTien.Show();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần mềm Quản Lý Giao Thông - Phiên bản 1.0\nTác giả: Nhóm Phát Triển", "Giới Thiệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
             FormHuongDan frmHuongDan = new FormHuongDan();
    frmHuongDan.Show();
        }


     
        

        
  
    }
}
    

