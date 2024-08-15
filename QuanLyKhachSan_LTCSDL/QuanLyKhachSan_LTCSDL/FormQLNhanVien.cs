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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace QuanLyKhachSan_LTCSDL
{
    public partial class FormQLNhanVien : Form
    {
        public FormQLNhanVien()
        {
            InitializeComponent();
            LoadDSLoaiNhanVien();
            LoadDSNhanVien(LayDSNhanVien());
            dataGridViewNhanVien.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
        }

        private bool CheckTrueDate(DateTime date1, DateTime date2)
        {
            if (date2.Subtract(date1).Days < 6574)
                return false;
            return true;
        }

        private bool CheckTuoi()
        {
            if (!CheckTrueDate(dateNgaySinh.Value, DateTime.Now))
            {
                MessageBox.Show("Ngày sinh không hợp lệ (Tuổi phải lớn hơn 18)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                if (!CheckTrueDate(dateNgaySinh.Value, dateNgayBatDauLam.Value))
            {
                MessageBox.Show("Ngày vào làm không hợp lệ (Lớn hơn 18 tuổi)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private NhanVien LayNhanVienHienTai()
        {
            NhanVien NhanVien = new NhanVien();

            NhanVien.TenDangNhap = txtTenDangNhap.Text.ToLower();
            int index = cbLoaiNhanVien.SelectedIndex;
            string IDLoaiNhanVien = LayIDTuDongDAL.Instance.TuDong_ID("LoaiNhanVien", "ID"); ;
            cbLoaiNhanVien.SelectedItem = IDLoaiNhanVien;
            NhanVien.IDLoaiNhanVien = ((DataTable)cbLoaiNhanVien.DataSource).Rows[index]["ID"].ToString();
            NhanVien.Ten = txtTen.Text;
            NhanVien.CCCD = txtCCCD.Text;
            NhanVien.GioiTinh = cbGioiTinh.Text;
            NhanVien.NgaySinh = dateNgaySinh.Value;
            NhanVien.SDT = int.Parse(txtSDT.Text);
            NhanVien.DiaChi = txtDiaChi.Text;
            NhanVien.NgayBatDauLam = dateNgayBatDauLam.Value;
            return NhanVien;
        }

        private DataTable LayTimKiemNhanVien()
        {
            if (int.TryParse(txtTimKiem.Text, out int phoneNumber))
                return NhanVienDAL.Instance.TimKiemNhanVien(txtTimKiem.Text, phoneNumber);
            else
                return NhanVienDAL.Instance.TimKiemNhanVien(txtTimKiem.Text, -1);
        }


        //Load DS
        private void LoadDSNhanVien(DataTable table)
        {
            BindingSource source = new BindingSource();
            source.DataSource = table;
            dataGridViewNhanVien.DataSource = source;
            //bindingStaff.BindingSource = source;
        }
        private void LoadDSLoaiNhanVien()
        {
            cbGioiTinh.SelectedIndex = 0;
            DataTable table = LoaiNhanVienDAL.Instance.LoadDSLoaiNhanVien();
            cbLoaiNhanVien.DataSource = table;
            cbLoaiNhanVien.DisplayMember = "TenLoai";
            if (table.Rows.Count > 0)
                cbLoaiNhanVien.SelectedIndex = 0;
        }



        //Lấy DS
        private DataTable LayDSNhanVien()
        {
            return NhanVienDAL.Instance.LoadDSNhanVien();
        }
       
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = txtTimKiem.Text.Trim();
            if (txtTimKiem.Text != string.Empty)
            {
                txtTenDangNhap.Text = string.Empty;
                txtTen.Text = string.Empty;
                txtCCCD.Text = string.Empty;
                txtSDT.Text = string.Empty;
                txtDiaChi.Text = string.Empty;

                LoadDSNhanVien(LayTimKiemNhanVien());
            }
        }

        private void dataGridViewNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewNhanVien.SelectedRows[0];
                txtTenDangNhap.Text = row.Cells[TenDangNhap.Name].Value as string;
                txtDiaChi.Text = row.Cells[DiaChi.Name].Value as string;
                txtTen.Text = row.Cells[Ten.Name].Value as string;
                txtSDT.Text = row.Cells[SDT.Name].Value.ToString();
                txtCCCD.Text = row.Cells[CCCD.Name].Value as string;
                dateNgaySinh.Text = row.Cells[NgaySinh.Name].Value as string;
                dateNgayBatDauLam.Text = row.Cells[NgayBatDauLam.Name].Value as string;
                cbGioiTinh.Text = row.Cells[GioiTinh.Name].Value as string;
                cbLoaiNhanVien.SelectedItem = row.Cells[LoaiNhanVien.Name].Value as string;
            }
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewNhanVien.Rows[e.RowIndex].Selected = true;
        }

        private void btnDatLaiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn đặt lại mật khẩu với tên đăng nhập " + txtTenDangNhap.Text + " không?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        bool check = NhanVienDAL.Instance.CapNhatPass(txtTenDangNhap.Text, "123");
                        if (check)
                        {
                            MessageBox.Show("Đặt lại mật khẩu thành công\nMật khẩu mặt định là: 123", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Không thể đặt lại mật khẩu (Tên đăng nhập chưa tồn tại)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi không xác định", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không được để trống tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật nhân viên này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                if (CheckTuoi())
                {
                    
                    if (txtTenDangNhap.Text == string.Empty && cbLoaiNhanVien.Text == string.Empty && txtCCCD.Text == string.Empty && cbGioiTinh.Text ==string.Empty && txtSDT.Text ==string.Empty && txtDiaChi.Text == string.Empty)
                    {
                        MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        NhanVien accountPre = groupNhanVien.Tag as NhanVien;
                        try
                        {
                            NhanVien nvHienTai = LayNhanVienHienTai();
                            if (nvHienTai.Equals(accountPre))
                            {
                                MessageBox.Show("Bạn chưa thay đổi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                bool check = NhanVienDAL.Instance.CapNhatNhanVien(nvHienTai);
                                if (check)
                                {
                                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    groupNhanVien.Tag = nvHienTai;
                                    LoadDSLoaiNhanVien();
                                    LoadDSNhanVien(LayDSNhanVien());
                                }
                                else
                                {
                                    if (nvHienTai.TenDangNhap == accountPre.TenDangNhap)
                                        MessageBox.Show("Không thể cập nhật(Trùng số chứng minh nhân dân)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    else
                                        MessageBox.Show("Không thể cập nhật(Tài khoản chưa tồn tại)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Lỗi không xác định", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm nhân viên mới không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {

                if (CheckTuoi())
                {
                    if (txtTenDangNhap.Text != string.Empty && txtTen.Text != string.Empty && cbLoaiNhanVien.Text != string.Empty && txtCCCD.Text != string.Empty && cbGioiTinh.Text !=string.Empty && txtSDT.Text !=string.Empty && txtDiaChi.Text != string.Empty)
                    {
                       
                        NhanVien nvHienTai = LayNhanVienHienTai();
                        nvHienTai.MatKhau = "123";
                        if (NhanVienDAL.Instance.ThemNhanVien(nvHienTai))
                        {
                            MessageBox.Show("Thêm Thành Công\n Mật khẩu mặc đinh cho tài khảon " + txtTenDangNhap.Text +
                                ": 123", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDSLoaiNhanVien();
                            LoadDSNhanVien(LayDSNhanVien());
                        }
                        else
                            MessageBox.Show("Nhân Viên Đã Tồn Tại(Trùng tên đăng nhập hoặc Số CMND)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        
                    }
                    else
                    {
                        MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
