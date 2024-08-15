using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan_LTCSDL
{
    public partial class FormThongTinCaNhan : Form
    {
        public FormThongTinCaNhan(string userName)
        {
            InitializeComponent();
            LoadThongTinCaNhan(userName);
            txtCCCD.Enabled = false;
        }
        string Password;
        public void LoadThongTinCaNhan(string username)
        {
            NhanVien staff = NhanVienDAL.Instance.LoadThongTinNhanVienTheoUsername(username);
            lbUserName.Text = txtUserName.Text = staff.TenDangNhap;
            lbTenNV.Text = txtTenNV.Text = staff.Ten;
            txtLoaiNhanVien.Text = LoaiNhanVienDAL.Instance.LayLoaiNhanVienTheoTenDangNhap(username).Name;
            txtCCCD.Text = staff.CCCD.ToString();
            txtSoDienThoai.Text = staff.SDT.ToString();
            txtDiaChi.Text = staff.DiaChi;
            dpkNgaySinh.Value = staff.NgaySinh;
            cbGioiTinh.Text = staff.GioiTinh;
            txtNgayVaoLam.Text = staff.NgayBatDauLam.ToShortDateString();
            Password = staff.MatKhau;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuuThayDoiTTTK_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text!=String.Empty)
            {
                NhanVienDAL.Instance.CapNhatTenNhanVien(txtUserName.Text, txtTenNV.Text);
                MessageBox.Show("Cập nhật thông tin tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadThongTinCaNhan(txtUserName.Text);
            }
            else
                MessageBox.Show("Tên hiển thị không hợp lệ.\nVui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLuuTDBaoMat_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text ==Password&&txtMatKhauMoi.Text!=String.Empty&&txtXacNhanMK.Text!=String.Empty)
            {
                if (txtMatKhauMoi.Text==txtXacNhanMK.Text)
                {
                    NhanVienDAL.Instance.CapNhatPass(txtUserName.Text, txtMatKhauMoi.Text);
                    MessageBox.Show("Cập nhật mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatKhau.Text = txtMatKhauMoi.Text = txtXacNhanMK.Text = String.Empty;
                    LoadThongTinCaNhan(txtUserName.Text);
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không hợp lệ.\nVui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhauMoi.Text = txtXacNhanMK.Text = String.Empty;
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không hợp lệ.\nVui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Text=txtMatKhauMoi.Text = txtXacNhanMK.Text = String.Empty;
            }
        }

        private void btnLuuTDThongTin_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text != String.Empty && txtSoDienThoai.Text!=String.Empty && cbGioiTinh.Text!=string.Empty && dpkNgaySinh.Value<DateTime.Now.Date)
            {
                if (NhanVienDAL.Instance.CheckCCCDNhanVien(txtCCCD.Text))
                {
                    
                    NhanVienDAL.Instance.CapNhatThongTinNhanVien(txtUserName.Text, txtDiaChi.Text, int.Parse(txtSoDienThoai.Text), txtCCCD.Text, dpkNgaySinh.Value, cbGioiTinh.Text);
                    MessageBox.Show("Cập nhật thông tin cơ bản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThongTinCaNhan(txtUserName.Text);
                }
                else
                    MessageBox.Show("Thẻ căn cước/ CMND không tồn tại.\nVui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Thông tin cơ bản không hợp lệ.\nVui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
