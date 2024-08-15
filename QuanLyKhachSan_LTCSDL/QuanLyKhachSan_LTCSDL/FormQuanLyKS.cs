using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace QuanLyKhachSan_LTCSDL
{
    public partial class FormQuanLyKS : Form
    {
        private string userName;
        public FormQuanLyKS()
        {
            InitializeComponent();
        }
        public FormQuanLyKS(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }
       

        private bool CheckAccess(string idLoaiNV)
        {
            return NhanVienDAL.Instance.CheckAccess(userName, idLoaiNV);
        }

        //=========================================SỰ KIỆN====================================

        private void btnAccountProfile_Click(object sender, EventArgs e)
        {
            FormThongTinCaNhan f = new FormThongTinCaNhan(userName);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Hide();
                FormDangNhap f = new FormDangNhap();
                f.ShowDialog();
                this.Show();    

        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            if (CheckAccess("CD001     "))
            {
                Hide();
                FormQLPhong f = new FormQLPhong();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Bạn không quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if (CheckAccess("CD001     "))
            {
                Hide();
                FormQLKhachHang f = new FormQLKhachHang();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Bạn không quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (CheckAccess("CD001     "))
            {
                Hide();
                FormQLNhanVien f = new FormQLNhanVien();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Bạn không quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (CheckAccess("CD001     "))
            {
                Hide();
                FormQLHoaDon f = new FormQLHoaDon();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Bạn không quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gunabtnDatPhong_Click(object sender, EventArgs e)
        {
            if (CheckAccess("CD002     "))
            {
                Hide();
                FormDatPhong f = new FormDatPhong();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Bạn không quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gunabtnNhanPhong_Click(object sender, EventArgs e)
        {
            if (CheckAccess("CD002     "))
            {
                Hide();
                FormNhanPhong f = new FormNhanPhong();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Bạn không quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gunabtnThanhToan_Click(object sender, EventArgs e)
        {
            if (CheckAccess("CD002     "))
            {
                Hide();
                FormThanhToan f = new FormThanhToan(userName);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Bạn không quyền truy cập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
