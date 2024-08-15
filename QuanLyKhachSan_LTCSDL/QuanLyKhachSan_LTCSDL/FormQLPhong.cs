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
using System.Xml.Linq;
using DAL;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyKhachSan_LTCSDL
{
    public partial class FormQLPhong : Form
    {
        public FormQLPhong()
        {
            InitializeComponent();
            LoadDSLoaiPhong();
            LoadDSTrangThaiPhong();
            LoadDSPhong(PhongDAL.Instance.LoadDSPhong());
            dataGridViewPhong.SelectionChanged += DataGridViewPhong_SelectionChanged;
            cbMaPhong.DisplayMember = "ID";
            dataGridViewPhong.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
        }
        
        private void LoadDSPhong(DataTable table)
        {
            BindingSource source = new BindingSource();
            source.DataSource = table;
            dataGridViewPhong.DataSource = source;
            cbMaPhong.DataSource = source;
        }
        private void LoadDSTrangThaiPhong()
        {
            DataTable table = TrangThaiPhongDAL.Instance.LoadTrangThaiPhong();
            cbTrangThaiPhong.DataSource = table;
            cbTrangThaiPhong.DisplayMember = "TrangThai";
            if (table.Rows.Count > 0)
                cbTrangThaiPhong.SelectedIndex = 0;
        }
        private void LoadDSLoaiPhong()
        {
            DataTable table = LoaiPhongDAL.Instance.LoadLoaiPhong();
            cbLoaiPhong.DataSource = table;
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
            if (table.Rows.Count > 0)
                cbLoaiPhong.SelectedIndex = 0;
            txtSoNguoiToiDa.DataBindings.Add(new Binding("Text", cbLoaiPhong.DataSource, "SoLuongNguoi"));
        }
        private DataTable LayPhongKhiTim()
        {
            if (int.TryParse(txtTimPhong.Text, out int id))
                return PhongDAL.Instance.Tim(txtTimPhong.Text, id);
            else
                return PhongDAL.Instance.Tim(txtTimPhong.Text, 0);
        }

        private Phong LayPhongHienTai(string id)
        {
            Phong room = new Phong();
            room.ID = id;
            room.TenPhong = txtTenPhong.Text;
            int index = cbLoaiPhong.SelectedIndex;
            room.IDTrangThaiPhong = 1;
            room.IDLoaiPhong = ((DataTable)cbLoaiPhong.DataSource).Rows[index]["ID"].ToString();
            return room;
        }
        private Phong LayPhongHienTai()
        {
            Phong room = new Phong();
            room.ID = cbMaPhong.Text;
            room.TenPhong = txtTenPhong.Text;
            int index = cbLoaiPhong.SelectedIndex;
            room.IDTrangThaiPhong = 1;
            room.IDLoaiPhong = ((DataTable)cbLoaiPhong.DataSource).Rows[index]["ID"].ToString();
            return room;
        }
        private LoaiPhong LayLoaiPhongHienTai()
        {
            LoaiPhong roomtype = new LoaiPhong();
            roomtype.TenLoaiPhong = cbLoaiPhong.Text;
            roomtype.Gia = int.Parse(txtGiaPhong.Text);
            roomtype.SoLuongNguoi = int.Parse(txtSoNguoiToiDa.Text);
            int index = cbLoaiPhong.SelectedIndex;
            roomtype.ID = ((DataTable)cbLoaiPhong.DataSource).Rows[index]["ID"].ToString();
            return roomtype;
        }
        
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm phòng mới?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
                if (txtTenPhong.Text == String.Empty && cbLoaiPhong.Text == String.Empty)
                {
                    MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string id = LayIDTuDongDAL.Instance.TuDong_ID("Phong", "ID");
                Phong roomNow = LayPhongHienTai(id);
                if (PhongDAL.Instance.ThemPhong(roomNow))
                {
                    txtTenPhong.Text = string.Empty;
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Phòng này đã tồn tại(Trùng mã  phòng)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void DataGridViewPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPhong.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewPhong.SelectedRows[0];
                txtTenPhong.Text = row.Cells["TenPhong"].Value.ToString();
                cbLoaiPhong.Text = row.Cells["TenLoaiPhong"].Value.ToString();
                cbTrangThaiPhong.SelectedIndex = (int)row.Cells["IDTrangThaiPhong"].Value - 1;
                Phong room = new Phong(((DataRowView)row.DataBoundItem).Row);
                groupBox2.Tag = room;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbLoaiPhong.SelectedIndex;

            if (((DataTable)cbLoaiPhong.DataSource).Rows[index]["GiaPhong"].ToString().Contains("."))
                return;
            txtGiaPhong.Text = ((int)((DataTable)cbLoaiPhong.DataSource).Rows[index]["GiaPhong"]).ToString("C0", CultureInfo.CreateSpecificCulture("vi-VN"));
        }

        private void btnCapNhatPhong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật lại phòng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
                if (cbMaPhong.Text == string.Empty)
                {
                    MessageBox.Show("Phòng này chưa tồn tại\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                if (txtTenPhong.Text == String.Empty && cbLoaiPhong.Text == String.Empty && cbTrangThaiPhong.Text ==String.Empty)
                    {
                        MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        Phong roomPre = groupBox2.Tag as Phong;


                        Phong roomNow = LayPhongHienTai();
                        if (roomNow.Equals(roomPre))
                        {
                            MessageBox.Show("Bạn chưa thay đổi dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            bool check = PhongDAL.Instance.CapNhatPhong(roomNow);
                            if (check)
                            {
                                MessageBox.Show("Cập Nhật Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                groupBox2.Tag = roomNow;

                            }
                            else
                                MessageBox.Show("Phòng này chưa tồn tại\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
            cbMaPhong.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            txtTimPhong.Text = txtTimPhong.Text.Trim();
            if (txtTimPhong.Text != string.Empty)
            {
                txtTenPhong.Text = string.Empty;

                LoadDSPhong(LayPhongKhiTim());
            }
        }

        //Sửa tên loại phòng, giá phòng
        private void btnSuaLoaiPhong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật loại phòng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
                if (cbLoaiPhong.Text == String.Empty && txtGiaPhong.Text == String.Empty)
                {
                    MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    LoaiPhong roomTypePre = groupBox2.Tag as LoaiPhong;

                    LoaiPhong roomTypeNow = LayLoaiPhongHienTai();
                    if (roomTypeNow.Equals(roomTypePre))
                        MessageBox.Show("Bạn chưa thay đổi dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        bool check = LoaiPhongDAL.Instance.CapNhatLoaiPhong(roomTypeNow, roomTypePre);
                        if (check)
                        {
                            MessageBox.Show("Cập nhật thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            groupBox2.Tag = roomTypeNow;
                        }
                        else
                            MessageBox.Show("Loại phòng này chưa tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                }
            cbLoaiPhong.Focus();
        }

        private void dataGridViewPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Chọn toàn bộ hàng tại vị trí RowIndex
            dataGridViewPhong.Rows[e.RowIndex].Selected = true;
        }
    }
}
