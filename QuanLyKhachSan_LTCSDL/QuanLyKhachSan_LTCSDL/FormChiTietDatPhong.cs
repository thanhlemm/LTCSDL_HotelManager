using DAL;
using DTO;
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
    public partial class FormChiTietDatPhong : Form
    {
        string idPhieuDP;
        string cccd;
        public FormChiTietDatPhong(string _idPhieuDP, string _cccd)
        {
            idPhieuDP = _idPhieuDP;
            cccd = _cccd;
            InitializeComponent();
            LoadLoaiPhong();
            LoadData();
            LoadSoDem();
            txtIDDatPhong.Text = _idPhieuDP.ToString();
        }
        public void LoadLoaiPhong()
        {
            cbLoaiPhong.DataSource = LoaiPhongDAL.Instance.LoadDanhSachLoaiPhong();
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
        }
        public void LoadData()
        {
            DataRow data = PhieuDatPhongDAL.Instance.ShowThongTinDatPhong(idPhieuDP);
            dpkNgayNhan.Value = (DateTime)data["NgayNhan"];
            dpkNgayTra.Value = (DateTime)data["NgayTra"];

            cbLoaiPhong.Text = LoaiPhongDAL.Instance.LayLoaiPhongTheoIDPhieuDP(idPhieuDP).TenLoaiPhong;

            //Hiện lên form
            KhachHang kh = KhachHangDAL.Instance.LayThongTinTheoCCCD(cccd);
            txtCCCD.Text = kh.CCCD.ToString();
            txtHoTen.Text = kh.Ten;
            txtDiaChi.Text = kh.DiaChi;
            dpkNgaySinh.Value = kh.NgaySinh;
            cbGioiTinh.Text = kh.GioiTinh;
            txtSDT.Text = kh.SDT.ToString();
        }
        public void LoadSoDem()
        {
            txtSoDem.Text = (dpkNgayTra.Value.Date - dpkNgayNhan.Value.Date).Days.ToString();
        }

        //=========================================SỰ KIỆN====================================
        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dpkNgayNhan_ValueChanged(object sender, EventArgs e)
        {
            if (dpkNgayNhan.Value <= DateTime.Now)
                LoadData();
            if (dpkNgayTra.Value <= dpkNgayNhan.Value)
                LoadData();
            LoadSoDem();
        }

        private void dpkNgayTra_ValueChanged(object sender, EventArgs e)
        {
            if (dpkNgayTra.Value < DateTime.Now)
                LoadData();
            if (dpkNgayTra.Value <= dpkNgayNhan.Value)
                LoadData();
            LoadSoDem();
        }

        private void btnCapNhatKH_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != string.Empty && txtCCCD.Text != string.Empty && txtDiaChi.Text != string.Empty && txtSDT.Text != string.Empty)
            {
                //Kiểm tra IDCard có trùng không
                if (KhachHangDAL.Instance.CheckCCCD(txtCCCD.Text) || txtCCCD.Text == cccd)
                {
                    string idKH = KhachHangDAL.Instance.LayThongTinTheoCCCD(cccd).Id; //lấy cccd từ FormDatPhong
                    KhachHangDAL.Instance.CapNhatKhachHang(idKH, txtHoTen.Text, txtCCCD.Text, int.Parse(txtSDT.Text), dpkNgaySinh.Value, txtDiaChi.Text, cbGioiTinh.Text);

                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Thẻ căn cước/ CMND không hợp lệ.\nVui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            LoadData();
        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            PhieuDatPhongDAL.Instance.CapNhatPhieuDatPhong(idPhieuDP, (cbLoaiPhong.SelectedItem as LoaiPhong).ID, dpkNgayNhan.Value, dpkNgayTra.Value);
            MessageBox.Show("Cập nhật thông tin đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void btnXoaPhieuDP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa phiếu đặt phòng!\nBạn có muốn tiếp tục?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                if (PhieuDatPhongDAL.Instance.CheckIDPhieuDP(idPhieuDP))
                {
                    PhieuDatPhongDAL.Instance.XoaPhieuDatPhong(idPhieuDP);
                    MessageBox.Show("Xóa phiếu đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Xóa phiếu đặt phòng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
