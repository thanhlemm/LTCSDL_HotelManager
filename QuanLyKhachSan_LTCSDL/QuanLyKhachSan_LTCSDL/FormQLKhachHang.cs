using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyKhachSan_LTCSDL
{
    public partial class FormQLKhachHang : Form
    {
        public FormQLKhachHang()    
        {
            InitializeComponent();
            cbTimKiemKhachHang.SelectedIndex = 3;
            LoadDSKhachHang(LayDSKhachHang());
            cbGioiTinh.SelectedIndex = 0;
            cbIDKhachHang.DisplayMember = "ID";
            dataGridViewKhachHang.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
        }

        private bool CheckTrueDate(DateTime date1, DateTime date2)
        {
            if (date2.Subtract(date1).Days < 6574)
                return false;
            return true;
        }

        //kiểm tra ngày sinh nhỏ hơn ngày hiện tại
        private bool CheckTuoi()
        {
            if (DateTime.Now.Subtract(dateNgaySinh.Value).Days <= 0)
                return false;
            else return true;
        }

        //Load
        private void LoadDSKhachHang(DataTable table)
        {
            BindingSource source = new BindingSource();
            source.DataSource = table;
            dataGridViewKhachHang.DataSource = source;
            cbIDKhachHang.DataSource = source;
        }


        private KhachHang LayDSKhachHangHienTai()
        {
            KhachHang khachhang = new KhachHang();
            khachhang.Id = cbIDKhachHang.Text;
            khachhang.CCCD = txtCCCD.Text;
            khachhang.Ten = txtHoTen.Text;
            khachhang.GioiTinh = cbGioiTinh.Text;
            khachhang.SDT = int.Parse(txtSDT.Text);
            khachhang.NgaySinh = dateNgaySinh.Value;
            khachhang.DiaChi = txtDiaChi.Text;
            return khachhang;
        }

        //Lay
        private DataTable LayDSKhachHang()
        {
            return KhachHangDAL.Instance.LoadDSKhachHang();
        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm khách hàng mới?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                if (CheckTuoi())
                {
                    if (txtSDT.Text==string.Empty || txtHoTen.Text==string.Empty || txtCCCD.Text==string.Empty ||  txtDiaChi.Text==string.Empty)
                    {
                        MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    

                    KhachHang khachhang = LayDSKhachHangHienTai();
                    khachhang.Id = LayIDTuDongDAL.Instance.TuDong_ID("KhachHang", "ID");
                    if (!KhachHangDAL.Instance.CheckCCCD(txtCCCD.Text))
                    {
                            if (KhachHangDAL.Instance.ThemKhachHang(khachhang))
                        {
                            
                            MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtHoTen.Text = string.Empty;
                            txtDiaChi.Text = string.Empty;
                            txtCCCD.Text = string.Empty;
                            txtSDT.Text = string.Empty;
                            LoadDSKhachHang(LayDSKhachHang());
                        }
                    }
                    else
                        MessageBox.Show("Khách Hàng đã tồn tại\nTrùng số chứng minh nhân dân", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    
                }
                else
                    MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewKhachHang.SelectedRows[0];
                txtHoTen.Text = row.Cells["Ten"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                cbGioiTinh.SelectedItem = row.Cells["GioiTinh"].Value;
                dateNgaySinh.Value = (DateTime)row.Cells["NgaySinh"].Value;
                KhachHang khachhang = new KhachHang(((DataRowView)row.DataBoundItem).Row);
                groupQLKhachHang.Tag = khachhang;
            }
        }

        private void dataGridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewKhachHang.Rows[e.RowIndex].Selected = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKhachHang.Text = txtTimKhachHang.Text.Trim();
            if (txtTimKhachHang.Text != string.Empty)
            {
                txtDiaChi.Text = string.Empty;
                txtHoTen.Text = string.Empty;
                txtCCCD.Text = string.Empty;
                txtSDT.Text = string.Empty;

                string @string = txtTimKhachHang.Text;
                int mode = cbTimKiemKhachHang.SelectedIndex;
                LoadDSKhachHang(KhachHangDAL.Instance.TimKiemKhachHang(@string, mode));
            }
        }

        private void btnCapNhatKH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật khách hàng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                if (CheckTuoi())
                {
                    if (cbIDKhachHang.Text == string.Empty)
                    {
                        MessageBox.Show("Khách hàng này chưa tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    if (txtSDT.Text == string.Empty ||txtHoTen.Text == string.Empty || txtCCCD.Text == string.Empty ||txtDiaChi.Text == string.Empty )
                    {
                        MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        KhachHang khcu = groupQLKhachHang.Tag as KhachHang;
                        try
                        {
                            KhachHang khmoi = LayDSKhachHangHienTai();
                            if (khmoi.Equals(khcu))
                                MessageBox.Show("Bạn chưa thay đổi dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else
                            {
                                bool check = KhachHangDAL.Instance.CapNhatKhachHang(khmoi, khcu);
                                if (check)
                                {
                                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    groupQLKhachHang.Tag = khmoi;
                                    int index = dataGridViewKhachHang.SelectedRows[0].Index;
                                    LoadDSKhachHang(LayDSKhachHang());
                                    cbIDKhachHang.SelectedIndex = index;
                                }
                                else
                                    MessageBox.Show("Khách hàng này đã tồn tại(Trùng số chứng minh nhân dân)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Lỗi câp nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    cbIDKhachHang.Focus();

                }
                else
                    MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_XoaKhachHang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa khách hàng!\nBạn có muốn tiếp tục?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                try
                {
                    if (KhachHangDAL.Instance.CheckCCCD(txtCCCD.Text))
                    {
                        KhachHangDAL.Instance.XoaKhachHang(txtCCCD.Text);
                        MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Xóa khách hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch{
                MessageBox.Show("Khách hàng này đã đặt phòng! Không thể xoá", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
