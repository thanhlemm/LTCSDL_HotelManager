using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyKhachSan_LTCSDL
{
    public partial class FormDatPhong : Form
    {
        string idphieudp;
        public FormDatPhong()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            LoadLoaiPhong();
            LoadDate();
            LoadSoDem();
            LoadDSPhieuDP();
        }
        //Lấy danh sách loại phòng
        public void LoadLoaiPhong()
        {
            cbLoaiPhong.DataSource= LoaiPhongDAL.Instance.LoadDanhSachLoaiPhong();
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
        }
        
        //LoadDate
        public void LoadDate()
        {
            dpkNgaySinh.Value = new DateTime(2003, 12, 02);
            dpkNgayNhan.Value = DateTime.Now;
            dpkNgayTra.Value = DateTime.Now.AddDays(1);
        }
        //Tính ngày 
        public void LoadSoDem()
        {
            txtSoDem.Text = (dpkNgayTra.Value.Date - dpkNgayNhan.Value.Date).Days.ToString();
        }
        public void LoadDSPhieuDP()
        {
            dataGridViewDatPhong.DataSource = PhieuDatPhongDAL.Instance.LoadDanhSachDP(DateTime.Now.Date);
        }
        public void ClearData()
        {
            txtCCCD.Text = txtHoTen.Text = txtDiaChi.Text = txtSoDienThoai.Text = String.Empty;
            LoadDate();
        }

        private void btnHuyDatPhong_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnDongDatPhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoaiPhong roomType = LoaiPhongDAL.Instance.LoadThongTinLoaiPhong((cbLoaiPhong.SelectedItem as LoaiPhong).ID);
            txtIDLoaiPhong.Text = roomType.ID.ToString();
            txtTenLoaiPhong.Text = roomType.TenLoaiPhong;
            CultureInfo cultureInfo = new CultureInfo("vi-vn");
            txtGiaPhong.Text = roomType.Gia.ToString("c0", cultureInfo);
            txtSoLuong.Text = roomType.SoLuongNguoi.ToString();
        }
       
        private void dpkNgayNhan_ValueChanged(object sender, EventArgs e)
        {
            if (dpkNgayNhan.Value <= DateTime.Now)
                LoadDate();
            if (dpkNgayTra.Value <= dpkNgayNhan.Value)
                LoadDate();
            LoadSoDem();
        }

        private void dpkNgayTra_ValueChanged(object sender, EventArgs e)
        {
            if (dpkNgayTra.Value < DateTime.Now)
                LoadDate();
            if (dpkNgayTra.Value <= dpkNgayNhan.Value)
                LoadDate();
            LoadSoDem();
        }

        private void dataGridViewDatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cell = e.RowIndex;
            idphieudp = dataGridViewDatPhong[0, cell].Value.ToString();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đặt phòng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtCCCD.Text != String.Empty && txtHoTen.Text != String.Empty && txtDiaChi.Text != String.Empty && txtSoDienThoai.Text != String.Empty)
                {
                    if (!KhachHangDAL.Instance.CheckCCCD(txtCCCD.Text))
                    {
                        txtIDKhachHang.Text =LayIDTuDongDAL.Instance.TuDong_ID("KhachHang", "ID");

                        KhachHangDAL.Instance.ThemKhachHang(txtIDKhachHang.Text, txtCCCD.Text, txtHoTen.Text, dpkNgaySinh.Value, txtDiaChi.Text, int.Parse(txtSoDienThoai.Text), cbGioiTinh.Text);
                    }
                    string idphieudp = LayIDTuDongDAL.Instance.TuDong_ID("PhieuDatPhong", "ID");
                    PhieuDatPhongDAL.Instance.ThemPhieuDP(idphieudp, KhachHangDAL.Instance.LayThongTinTheoCCCD(txtCCCD.Text).Id, (cbLoaiPhong.SelectedItem as LoaiPhong).ID, dpkNgayNhan.Value, dpkNgayTra.Value, DateTime.Now);
                    MessageBox.Show("Đặt phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    LoadDSPhieuDP();
                    if (checkNhanPhong.Checked)
                    {

                        FormNhanPhong fReceiveRoom = new FormNhanPhong(PhieuDatPhongDAL.Instance.LayIDPhieuDP(DateTime.Now.Date, idphieudp));
                        this.Hide();
                        fReceiveRoom.ShowDialog();
                        this.Show();

                    }
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChiTietDatPhong_Click(object sender, EventArgs e)
        {
            string idPhieuDP = dataGridViewDatPhong.SelectedRows[0].Cells[0].Value.ToString();
            string cccd = dataGridViewDatPhong.SelectedRows[0].Cells[2].Value.ToString();
            FormChiTietDatPhong f = new FormChiTietDatPhong(idPhieuDP, cccd);
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadDSPhieuDP();
        }
       
        private void txtCCCD_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            KhachHang customer = KhachHangDAL.Instance.LayThongTinTheoCCCD(txtCCCD.Text);
            txtCCCD.Text = customer.CCCD.ToString();
            txtHoTen.Text = customer.Ten;
            txtDiaChi.Text = customer.DiaChi;
            dpkNgaySinh.Value = customer.NgaySinh;
            cbGioiTinh.Text = customer.GioiTinh;
            txtSoDienThoai.Text = customer.SDT.ToString();
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            idphieudp =dataGridViewDatPhong.SelectedRows[0].Cells[0].Value.ToString();
            if (PhieuDatPhongDAL.Instance.CheckIDPhieuDP(idphieudp))
            {
                FormNhanPhong f = new FormNhanPhong(PhieuDatPhongDAL.Instance.LayIDPhieuDP(DateTime.Now.Date, idphieudp));
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Phiếu đặt phòng này đã được nhận phòng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Check nhập số
        private void txtSoDem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
