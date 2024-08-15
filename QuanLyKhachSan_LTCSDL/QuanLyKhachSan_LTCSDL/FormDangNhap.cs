using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan_LTCSDL
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void gunabtnDangNhap_Click(object sender, EventArgs e)
        {
            if (NhanVienDAL.Instance.Login(txtID.Text, txtPass.Text))
            {

                FormQuanLyKS f = new FormQuanLyKS(txtID.Text);
                this.Hide();
                f.ShowDialog();

            }
            else
            {
                MessageBox.Show("Tên Đăng Nhập không tồn tại hoặc Mật Khẩu không đúng.\nVui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunabtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
