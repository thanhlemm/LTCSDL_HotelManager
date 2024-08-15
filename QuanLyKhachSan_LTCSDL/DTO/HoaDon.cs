using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        
        private string id;
        private string idPhieuNhanPhong;
        private string userName;
        private DateTime ngayTao;
        private int giaPhong;
        private int giaDichVu;
        private int tongTien;
        private int giamGia;
        private int idTrangThaiHoaDon;
        public HoaDon(DataRow data)
        {
            Id = data["ID"].ToString();
            IDPhieuNhanPhong = data["IDPhieuNhanPhong"].ToString();
            TenDangNhap = data["TenDangNhapNV"].ToString();
            NgayTao = (DateTime)data["NgayTao"];
            GiaPhong = (int)data["GiaPhong"];
            GiaDichVu = (int)data["GiaDichVu"];
            TongTien = (int)data["TongTien"];
            GiamGia = (int)data["GiamGia"];
            IDTrangThaiHoaDon = (int)data["IDTrangThaiHoaDon"];
        }

        public string Id { get => id; set => id = value; }
        public string IDPhieuNhanPhong { get => idPhieuNhanPhong; set => idPhieuNhanPhong = value; }
        public string TenDangNhap { get => userName; set => userName = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public int GiaPhong { get => giaPhong; set => giaPhong = value; }
        public int GiaDichVu { get => giaDichVu; set => giaDichVu = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public int GiamGia { get => giamGia; set => giamGia = value; }
        public int IDTrangThaiHoaDon { get => idTrangThaiHoaDon; set => idTrangThaiHoaDon = value; }
    }
}
