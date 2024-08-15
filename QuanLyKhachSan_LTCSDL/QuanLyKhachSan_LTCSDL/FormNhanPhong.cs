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
    public partial class FormNhanPhong : Form
    {
        List<string> ListIDCustomer = new List<string>();
        string IDPhieuDatPhong;
        DateTime ngayNhan;
        public FormNhanPhong(string idPhieuDP)
        {
            IDPhieuDatPhong = idPhieuDP;
            InitializeComponent();
            LoadData();

            //Lấy dữ liệu từ FormDatPhong sang
            DataRow dataRow = PhieuDatPhongDAL.Instance.ShowThongTinDatPhong(IDPhieuDatPhong);
            txtHoTen.Text = dataRow["Ten"].ToString();
            txtCCCD.Text = dataRow["CCCD"].ToString();
            txtLoaiPhong.Text = dataRow["TenLoaiPhong"].ToString();
            cbLoaiPhong.Text= dataRow["TenLoaiPhong"].ToString();//*
            txtNgayNhan.Text = dataRow["NgayNhan"].ToString().Split(' ')[0];
            ngayNhan = (DateTime)dataRow["NgayNhan"];
            txtNgayTra.Text = dataRow["NgayTra"].ToString().Split(' ')[0];
            txtSoLuongNguoi.Text= dataRow["SoLuongNguoi"].ToString();
            txtGia.Text= dataRow["GiaPhong"].ToString();
        }
        public FormNhanPhong()
        {
            InitializeComponent();
            LoadData();

        }
        public void LoadData()
        {
            LoadDSLoaiPhong();
            LoadThongTinNhanPhong();
        }
        public void LoadDSLoaiPhong()
        {
            List<LoaiPhong> rooms = LoaiPhongDAL.Instance.LoadDanhSachLoaiPhong();
            cbLoaiPhong.DataSource = rooms;
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
        }
        public void LoadPhongTrong(string idLoaiPhong)
        {
            List<Phong> rooms = PhongDAL.Instance.LoadPhongTrong(idLoaiPhong);
            cbPhong.DataSource = rooms;
            cbPhong.DisplayMember = "TenPhong";
        }
        public void LoadThongTinNhanPhong()
        {
            dataGridViewNhanPhong.DataSource = PhieuNhanPhongDAL.Instance.LoadThongTinNhanPhong();
        }
      //=========================================SỰ KIỆN====================================
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLoaiPhong.Text = (cbLoaiPhong.SelectedItem as LoaiPhong).TenLoaiPhong;
            LoadPhongTrong((cbLoaiPhong.SelectedItem as LoaiPhong).ID);
        }

        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenPhong.Text = cbPhong.Text;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtIDDatPhong.Text!=string.Empty)
            {
                if (PhieuDatPhongDAL.Instance.CheckIDPhieuDP(txtIDDatPhong.Text))
                {
                    btnTimKiem.Tag = txtIDDatPhong.Text;

                    DataRow dataRow = PhieuDatPhongDAL.Instance.ShowThongTinDatPhong(txtIDDatPhong.Text);
                    txtHoTen.Text = dataRow["Ten"].ToString();
                    txtCCCD.Text = dataRow["CCCD"].ToString();
                    txtLoaiPhong.Text = dataRow["TenLoaiPhong"].ToString();
                    cbLoaiPhong.Text= dataRow["TenLoaiPhong"].ToString();//*
                    txtNgayNhan.Text = dataRow["NgayNhan"].ToString().Split(' ')[0];
                    ngayNhan = (DateTime)dataRow["NgayNhan"];
                    txtNgayTra.Text = dataRow["NgayTra"].ToString().Split(' ')[0];
                    txtSoLuongNguoi.Text= dataRow["SoLuongNguoi"].ToString();
                    txtGia.Text= dataRow["GiaPhong"].ToString();
                }
                else
                    MessageBox.Show("Mã đặt phòng này đã nhận phòng.\nVui lòng nhập mã đặt phòng khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn nhận phòng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtTenPhong.Text != string.Empty && txtLoaiPhong.Text != string.Empty && txtHoTen.Text != string.Empty && txtCCCD.Text != string.Empty && txtNgayNhan.Text != string.Empty && txtNgayTra.Text != string.Empty && txtSoLuongNguoi.Text != string.Empty && txtGia.Text != string.Empty)
                {
                    if (ngayNhan == DateTime.Now.Date)
                    {
                        string idPhieuDP;
                        if (IDPhieuDatPhong != "") idPhieuDP = IDPhieuDatPhong;
                        else idPhieuDP = txtIDDatPhong.Text;
                        string idPhong = (cbPhong.SelectedItem as Phong).ID;
                        string idPhieuNhanPHong = LayIDTuDongDAL.Instance.TuDong_ID("PhieuNhanPhong", "ID");
                        if (PhieuNhanPhongDAL.Instance.ThemPhieuNhanPhong(idPhieuNhanPHong, idPhieuDP, idPhong))
                        {
                            
                            MessageBox.Show("Nhận phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadPhongTrong((cbLoaiPhong.SelectedItem as LoaiPhong).ID);
                        }
                        else
                            MessageBox.Show("Tạo phiếu nhận phòng thất bại.\nVui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Ngày nhận phòng không hợp lệ.\nVui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearData();
                    LoadThongTinNhanPhong();
                }
                else
                    MessageBox.Show("Vui lòng nhập lại đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ClearData()
        {
            txtHoTen.Text = txtCCCD.Text = txtLoaiPhong.Text = txtNgayNhan.Text = txtNgayTra.Text = txtSoLuongNguoi.Text = txtGia.Text = string.Empty;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
