using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string userName;
        private string tenNV;
        private string matKhau;
        private string idLoaiNV;
        private string cccd;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private int sdt;
        private DateTime ngayLam;

        public string TenDangNhap { get => userName; set => userName = value; }
        public string Ten { get => tenNV; set => tenNV = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string IDLoaiNhanVien { get => idLoaiNV; set => idLoaiNV = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int SDT { get => sdt; set => sdt = value; }
        public DateTime NgayBatDauLam { get => ngayLam; set => ngayLam = value; }
        public string CCCD { get => cccd; set => cccd = value; }

        public NhanVien() { }
        public NhanVien(string userName, string tennv, string matkhau, string loainv, string cccd, DateTime ngaysinh, string gioitinh, string diachi, int sdt, DateTime ngaylam)
        {
            this.TenDangNhap = userName;
            this.Ten = tennv;
            this.MatKhau = matkhau;
            this.IDLoaiNhanVien = loainv;
            this.NgaySinh = ngaysinh;
            this.GioiTinh = gioitinh;
            this.DiaChi = diachi;
            this.SDT = sdt;
            this.NgayBatDauLam = ngaylam;
            this.CCCD = cccd;
        }
        public NhanVien(DataRow row)
        {
            this.TenDangNhap = row["TenDangNhap"].ToString();
            this.Ten = row["Ten"].ToString();
            this.IDLoaiNhanVien = row["IDLoaiNhanVien"].ToString();
            this.NgaySinh = (DateTime)row["NgaySinh"];
            this.GioiTinh = row["GioiTinh"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.SDT = (int)row["SDT"];
            this.NgayBatDauLam = (DateTime)row["NgayBatDauLam"];
            this.CCCD = (string)row["CCCD"];
            this.MatKhau = row["MatKhau"].ToString();

        }
    }
}
