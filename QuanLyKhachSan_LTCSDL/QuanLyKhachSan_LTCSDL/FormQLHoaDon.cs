using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using DAL;
using DTO;
using System.Globalization;
using System.Reflection;

namespace QuanLyKhachSan_LTCSDL
{
    public partial class FormQLHoaDon : Form
    {
        public FormQLHoaDon()
        {
            InitializeComponent();
            dataGridViewHoaDon.Font = new Font("Segoe UI", 9.75F);
            LoadDSHoaDon(HoaDonDAL.Instance.LoadDSHoaDon());
            cbID.DisplayMember = "ID";
            cbTimKiemHoaDon.SelectedIndex = 0;
        }


        //Load
        private void LoadDSHoaDon(DataTable table)
        {
            BindingSource source = new BindingSource();
            //ChangePrice(table);
            source.DataSource = table;
            dataGridViewHoaDon.DataSource = source;
            cbID.DataSource = source;

            txtNgayTao.DataBindings.Clear();
            txtTenPhong.DataBindings.Clear();
            txtDonGia.DataBindings.Clear();
            txtTrangThai.DataBindings.Clear();
            txtNhanVienTao.DataBindings.Clear();
            txtGiamGia.DataBindings.Clear();
            textThanhTien.DataBindings.Clear();

            txtNgayTao.DataBindings.Add("Text", source, "NgayTao");
            txtTenPhong.DataBindings.Add("Text", source, "TenPhong");
            txtDonGia.DataBindings.Add("Text", source, "TongTien");
            txtTrangThai.DataBindings.Add("Text", source, "TrangThai");
            txtNhanVienTao.DataBindings.Add("Text", source, "TenDangNhapNV");
            txtGiamGia.DataBindings.Add("Text", source, "GiamGia");
            textThanhTien.DataBindings.Add("Text", source, "ThanhTien");


        }

        //Lay
       

        private DataTable LayTimKiemHoaDon(string text, int mode)
        {
            return HoaDonDAL.Instance.TimKiemHoaDon(text, mode);
        }

        private void btnTimKiemHoaDon_Click(object sender, EventArgs e)
        {
            txtTimKiemHoaDon.Text = txtTimKiemHoaDon.Text.Trim();
            if (txtTimKiemHoaDon.Text != string.Empty)
            {
                txtNgayTao.Text = string.Empty;
                txtTenPhong.Text = string.Empty;
                txtDonGia.Text = string.Empty;
                txtTrangThai.Text = string.Empty;
                txtNhanVienTao.Text = string.Empty;

                LoadDSHoaDon(LayTimKiemHoaDon(txtTimKiemHoaDon.Text, cbTimKiemHoaDon.SelectedIndex));
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            //if (dataGridViewHoaDon.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow row = dataGridViewHoaDon.SelectedRows[0];
            //    txtNgayTao.Text = row.Cells[NgayTao.Name].Value.ToString();
            //    txtTrangThai.Text = row.Cells[TrangThai.Name].Value.ToString();
            //    txtTenPhong.Text = row.Cells[TenPhong.Name].Value.ToString();
            //    txtDonGia.Text = row.Cells[TongTien.Name].Value.ToString();
            //    txtGiamGia.Text = row.Cells[GiamGia.Name].Value as string;
            //    txtNhanVienTao.Text = row.Cells[TenDangNhapNV.Name].Value.ToString();
            //    textThanhTien.Text = row.Cells[ThanhTien.Name].Value.ToString();
                
            //}
        }
    }
}
