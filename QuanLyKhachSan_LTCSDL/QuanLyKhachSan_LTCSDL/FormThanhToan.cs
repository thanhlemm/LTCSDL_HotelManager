using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyKhachSan_LTCSDL
{
    public partial class FormThanhToan : Form
    {
        string NhanVienThanhToan;
        int tongTien = 0;
        int id = 1;
        public FormThanhToan(string userName)
        {
            NhanVienThanhToan = userName;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            LoadDSLoaiPhong();
            LoadButtonDanhSachPhong();
            LoadDSLoaidichVu();
        }

        public void Pay(string idHoaDon, int giamGia)
        {
            HoaDonDAL.Instance.CapNhatHoaDon_GiaPhong(idHoaDon);
            HoaDonDAL.Instance.CapNhatHoaDon_GiamGia(idHoaDon, giamGia);
            HoaDonDAL.Instance.CapNhathoaDon_GiaDichVu(idHoaDon);
        }

        //Lấy danh sách loại dịch vụ
        public void LoadDSLoaidichVu()
        {
            cbLoaiDichVu.DataSource = LoaiDichVuDAL.Instance.LayDSLoaiDichVu();
            cbLoaiDichVu.DisplayMember = "TenLoaiDichVu";
        }
        //lấy danh sách dịch vụ 
        public void LoadDSDichVu(string idServiceType)
        {
            cbDichVu.DataSource = DichVuDAL.Instance.LoadDichVuTheoLoaiDichVu(idServiceType);
            cbDichVu.DisplayMember = "TenDichVu";
        }

        //hiển thị hóa đơn phòng
        public void ShowHoaDonPhong(string idPhong)
        {
            CultureInfo cultureInfo = new CultureInfo("vi-vn");
            listViewHoaDonTienPhong.Items.Clear();
            if (HoaDonDAL.Instance.CheckHoaDonPhongDaNhan(idPhong))
            {
                DataRow data = HoaDonDAL.Instance.ShowHoaDonPhong(idPhong);

                ListViewItem listViewItem = new ListViewItem(data["Tên phòng"].ToString());

                ListViewItem.ListViewSubItem subItem1 = new ListViewItem.ListViewSubItem(listViewItem, ((int)data["Đơn giá"]).ToString("c0", cultureInfo));
                ListViewItem.ListViewSubItem subItem2 = new ListViewItem.ListViewSubItem(listViewItem, ((DateTime)data["Ngày nhận"]).ToString().Split(' ')[0]);
                ListViewItem.ListViewSubItem subItem3 = new ListViewItem.ListViewSubItem(listViewItem, ((DateTime)data["Ngày trả"]).ToString().Split(' ')[0]);
                ListViewItem.ListViewSubItem subItem4 = new ListViewItem.ListViewSubItem(listViewItem, ((int)data["Tiền phòng"]).ToString("c0", cultureInfo));
                int roomPrice = (int)data["Tiền phòng"];
                ListViewItem.ListViewSubItem subItem5 = new ListViewItem.ListViewSubItem(listViewItem, roomPrice.ToString("c0", cultureInfo));

                tongTien += roomPrice;

                listViewItem.SubItems.Add(subItem1);
                listViewItem.SubItems.Add(subItem2);
                listViewItem.SubItems.Add(subItem3);
                listViewItem.SubItems.Add(subItem4);
                listViewItem.SubItems.Add(subItem5);

                listViewHoaDonTienPhong.Items.Add(listViewItem);
            }
        }
        public void LoadDSLoaiPhong()
        {
            List<LoaiPhong> roomTypes = LoaiPhongDAL.Instance.LoadDanhSachLoaiPhong();
            switch (roomTypes.Count)
            {
                case 0:
                    {
                        Color1.Visible = Color2.Visible = Color3.Visible = Color4.Visible = Color5.Visible = false;
                        lbLoaiPhong1.Visible = lbLoaiPhong2.Visible = lbLoaiPhong3.Visible = lbLoaiPhong4.Visible = lbLoaiPhong5.Visible = false;
                        break;
                    }
                case 1:
                    {
                        lbLoaiPhong1.Text = roomTypes[0].TenLoaiPhong;
                        Color2.Visible = Color3.Visible = Color4.Visible = Color5.Visible = false;
                        lbLoaiPhong2.Visible = lbLoaiPhong3.Visible = lbLoaiPhong4.Visible = lbLoaiPhong5.Visible = false;
                        break;
                    }
                case 2:
                    {
                        lbLoaiPhong1.Text = roomTypes[0].TenLoaiPhong;
                        lbLoaiPhong2.Text= roomTypes[1].TenLoaiPhong;
                        Color3.Visible = Color4.Visible = Color5.Visible = false;
                        lbLoaiPhong3.Visible = lbLoaiPhong4.Visible = lbLoaiPhong5.Visible = false;
                        break;
                    }
                case 3:
                    {
                        lbLoaiPhong1.Text = roomTypes[0].TenLoaiPhong;
                        lbLoaiPhong2.Text = roomTypes[1].TenLoaiPhong;
                        lbLoaiPhong3.Text = roomTypes[2].TenLoaiPhong;
                        Color4.Visible = Color5.Visible = false;
                        lbLoaiPhong4.Visible = lbLoaiPhong5.Visible = false;
                        break;
                    }
                case 4:
                    {
                        lbLoaiPhong1.Text = roomTypes[0].TenLoaiPhong;
                        lbLoaiPhong2.Text = roomTypes[1].TenLoaiPhong;
                        lbLoaiPhong3.Text = roomTypes[2].TenLoaiPhong;
                        lbLoaiPhong4.Text = roomTypes[3].TenLoaiPhong;
                        Color5.Visible = false;
                        lbLoaiPhong5.Visible = false;
                        break;
                    }
            }
        }

        public void DrawControl(Phong room, System.Windows.Forms.Button button)
        {
            string idRoomTypeName = LoaiPhongDAL.Instance.LayLoaiPhongTheoIDPhong(room.ID).ID;
            switch (idRoomTypeName)
            {
                case "LP001     ":
                    {
                        button.BackColor = System.Drawing.Color.Tomato;
                        break;
                    }
                case "LP002     ":
                    {
                        button.BackColor = System.Drawing.Color.Violet;
                        break;
                    }
                case "LP003     ":
                    {
                        button.BackColor = System.Drawing.Color.DeepSkyBlue;
                        break;
                    }
                case "LP004     ":
                    {
                        button.BackColor = System.Drawing.Color.LimeGreen;
                        break;
                    }
                default:
                    {
                        button.BackColor = System.Drawing.Color.Gray;
                        break;
                    }
            }
        }
        // thêm button vào trong flowLayoutRooms
        public void LoadButtonDanhSachPhong()
        {
            flowLayoutPhong.Controls.Clear();
            listViewHoaDonTienPhong.Items.Clear();
            List<Phong> rooms = PhongDAL.Instance.LoadDSPhongDaNhan();
            foreach (Phong item in rooms)
            {
                System.Windows.Forms.Button button = new System.Windows.Forms.Button();
                button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.ForeColor = System.Drawing.Color.White;
                button.Size = new System.Drawing.Size(110, 95);
                button.Margin= new System.Windows.Forms.Padding(1, 1, 1, 1);

                button.Tag = item;
                button.Text =item.TenPhong;
                button.Click += Button_Click;

                DrawControl(item, button);

                flowLayoutPhong.Controls.Add(button);
            }
        }
        //Hiển thị hóa đơn dịch vụ
        public void ShowHoaDonDichVu(string idRoom)
        {
            listViewHoaDonDichVu.Items.Clear();
            DataTable dataTable = HoaDonDAL.Instance.ShowHoaDonDichVu(idRoom);
            CultureInfo cultureInfo = new CultureInfo("vi-vn");
            int _totalPrice = 0;
            foreach (DataRow item in dataTable.Rows)
            {
                ListViewItem listViewItem = new ListViewItem(id.ToString());
                id++;

                ListViewItem.ListViewSubItem subItem1 = new ListViewItem.ListViewSubItem(listViewItem, item["Tên dịch vụ"].ToString());
                ListViewItem.ListViewSubItem subItem2 = new ListViewItem.ListViewSubItem(listViewItem, ((int)item["Đơn giá"]).ToString("c0", cultureInfo));
                ListViewItem.ListViewSubItem subItem3 = new ListViewItem.ListViewSubItem(listViewItem, ((int)item["Số lượng"]).ToString());
                ListViewItem.ListViewSubItem subItem4 = new ListViewItem.ListViewSubItem(listViewItem, ((int)item["Thành tiền"]).ToString("c0", cultureInfo));


                _totalPrice+= (int)item["Thành tiền"];

                listViewItem.SubItems.Add(subItem1);
                listViewItem.SubItems.Add(subItem2);
                listViewItem.SubItems.Add(subItem3);
                listViewItem.SubItems.Add(subItem4);

                listViewHoaDonDichVu.Items.Add(listViewItem);
            }
            tongTien += _totalPrice;

            ListViewItem listViewItemTotalPrice = new ListViewItem();
            ListViewItem.ListViewSubItem subItemTotalPrice = new ListViewItem.ListViewSubItem(listViewItemTotalPrice, _totalPrice.ToString("c0", cultureInfo));
            ListViewItem.ListViewSubItem _subItem1 = new ListViewItem.ListViewSubItem(listViewItemTotalPrice, "");
            ListViewItem.ListViewSubItem _subItem2 = new ListViewItem.ListViewSubItem(listViewItemTotalPrice, "");
            ListViewItem.ListViewSubItem _subItem3 = new ListViewItem.ListViewSubItem(listViewItemTotalPrice, "");
            listViewItemTotalPrice.SubItems.Add(_subItem1);
            listViewItemTotalPrice.SubItems.Add(_subItem2);
            listViewItemTotalPrice.SubItems.Add(_subItem3);
            listViewItemTotalPrice.SubItems.Add(subItemTotalPrice);
            listViewHoaDonDichVu.Items.Add(listViewItemTotalPrice);

            id = 1;
        }

        //thêm bill
        //
        public void ThemHoaDonDichVu(string idPhong, string idDichVu, int soLuong)
        {
            if (HoaDonDAL.Instance.CheckHoaDonPhongDaNhan(idPhong))
            {
                //Đã tồn tại Bill
                if (!ChiTietHoaDonDAL.Instance.CheckDichVu_ChiTietHoaDon(idPhong, idDichVu))
                {
                    //Chưa tồn tại BillDetails
                    if (soLuong > 0)
                    {
                        string idBill = HoaDonDAL.Instance.LayIDHoaDonTheoIDPhong(idPhong);
                        ChiTietHoaDonDAL.Instance.ThemChiTietHoaDon(idBill, idDichVu, soLuong);
                    }
                    else
                        MessageBox.Show(this, "Số lượng không hợp lệ.\nVui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //ĐÃ tồn tại BillDetails
                    string idBill = HoaDonDAL.Instance.LayIDHoaDonTheoIDPhong(idPhong);
                    ChiTietHoaDonDAL.Instance.CapNhatChiTietHoaDon(idBill, idDichVu, soLuong);
                }
            }
            else
            {
                //Chưa tồn tại Bill
                if (soLuong > 0)
                {
                    string idReceiveRoom = PhieuNhanPhongDAL.Instance.LayIDPhieuNhanPhongTheoIDPhong(idPhong);
                    string idbill = LayIDTuDongDAL.Instance.TuDong_ID("HoaDon","ID");
                    HoaDonDAL.Instance.ThemHoaDon(idbill, idReceiveRoom, NhanVienThanhToan);
                    //string idBill = HoaDonDAL.Instance.Lay();
                    ChiTietHoaDonDAL.Instance.ThemChiTietHoaDon(idbill, idDichVu, soLuong);
                }
                else
                    MessageBox.Show(this, "Số lượng không hợp lệ.\nVui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //=========================================SỰ KIỆN====================================

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Phong room = flowLayoutPhong.Tag as Phong;
            if (MessageBox.Show("Bạn có chắc chắn thanh toán cho "  +room.TenPhong+ " không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string idHoaDon = HoaDonDAL.Instance.LayIDHoaDonTheoIDPhong(room.ID);
                Pay(idHoaDon, int.Parse(numericUpDown1.Value.ToString()));
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                listViewHoaDonTienPhong.Items.Clear();
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            listViewHoaDonTienPhong.Items.Clear();
            tongTien = 0;
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            flowLayoutPhong.Tag = button.Tag;
            button.BackColor = System.Drawing.Color.SteelBlue;
            foreach (var item in flowLayoutPhong.Controls)
            {
                if (item != button)
                    DrawControl((item as System.Windows.Forms.Button).Tag as Phong, item as System.Windows.Forms.Button);
            }
            Phong room = button.Tag as Phong;
            ShowHoaDonDichVu(room.ID);
            if (!HoaDonDAL.Instance.CheckHoaDonPhongDaNhan(room.ID))
            {
                string idPhieuNhanPhong = PhieuNhanPhongDAL.Instance.LayIDPhieuNhanPhongTheoIDPhong(room.ID);
                string idHoaDon = LayIDTuDongDAL.Instance.TuDong_ID("HoaDon", "ID");
                HoaDonDAL.Instance.ThemHoaDon(idHoaDon, idPhieuNhanPhong, NhanVienThanhToan);
            }
            HoaDonDAL.Instance.CapNhatHoaDon_GiaPhong(HoaDonDAL.Instance.LayIDHoaDonTheoIDPhong(room.ID));

            ShowHoaDonPhong(room.ID);

            txtTongTien.Text = tongTien.ToString("c0", new CultureInfo("vi-vn"));
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            tongTien = 0;
            Phong room = flowLayoutPhong.Tag as Phong;
            ThemHoaDonDichVu(room.ID, (cbDichVu.SelectedItem as DichVu).Id, int.Parse(numSoLuong.Value.ToString()));
            ShowHoaDonDichVu(room.ID);
            numSoLuong.Value = 1;

            ShowHoaDonPhong(room.ID);
            txtTongTien.Text = tongTien.ToString("c0", new CultureInfo("vi-vn"));
        }

        private void cbLoaiDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDSDichVu((cbLoaiDichVu.SelectedItem as LoaiDichVu).Id);
        }

        private void cbDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("vi-vn");
            if (cbDichVu.SelectedItem != null)
                txtGia.Text = (cbDichVu.SelectedItem as DichVu).GiaDichVu.ToString("c0", cultureInfo);
        }
    }
}
