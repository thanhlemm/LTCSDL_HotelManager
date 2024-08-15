using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuDatPhong
    {
        private string id;
        private string idKhachHang;
        private string idLoaiPhong;
        private DateTime ngayNhan;
        private DateTime ngayTra;
        private DateTime ngayDat;

        public PhieuDatPhong(string id, string idKhachHang, string idLoaiPhong, DateTime ngayNhan, DateTime ngayTra, DateTime ngayDat)
        {
            Id = id;
            IDKhachHang = idKhachHang;
            IDLoaiPhong = idLoaiPhong;
            NgayNhan = ngayNhan;
            NgayTra = ngayTra;
            NgayDat = ngayDat;
        }
        public PhieuDatPhong(DataRow row)
        {
            Id = row["ID"].ToString();
            IDKhachHang = row["IDKhachHang"].ToString();
            IDLoaiPhong = row["IDLoaiPhong"].ToString();
            NgayNhan = (DateTime)row["NgayNhan"];
            NgayTra = (DateTime)row["NhanTra"];
            NgayDat = (DateTime)row["NgayDatPhong"];
        }

        public string Id { get => id; set => id = value; }
        public string IDKhachHang { get => idKhachHang; set => idKhachHang = value; }
        public string IDLoaiPhong { get => idLoaiPhong; set => idLoaiPhong = value; }
        public DateTime NgayNhan { get => ngayNhan; set => ngayNhan = value; }
        public DateTime NgayTra { get => ngayTra; set => ngayTra = value; }
        public DateTime NgayDat { get => ngayDat; set => ngayDat = value; }
    }

}
