using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
    
        private string id;
        private string cccd;
        private string ten;
        private DateTime ngaySinh;
        private string diaChi;
        private int sdt;
        private string gioiTinh;
        public KhachHang() { }

        public KhachHang(string id, string cccd, string ten, string diachi, int sdt, string gt, DateTime ngaysinh)
        {
            this.Id = id;
            this.CCCD = cccd;
            this.Ten = ten;
            this.NgaySinh = ngaysinh;
            this.DiaChi = diachi;
            this.SDT = sdt;
            this.GioiTinh = gt;
        }
        public KhachHang(DataRow row) //Phương thức này sử dụng dữ liệu từ DataRow để khởi tạo đối tượng KhachHang. 
        {
            this.Id= row["id"].ToString();
            this.CCCD = row["CCCD"].ToString();
            this.Ten = row["Ten"].ToString();
            this.NgaySinh = (DateTime)row["NgaySinh"];
            this.DiaChi = row["DiaChi"].ToString();
            this.SDT = (int)row["SDT"];
            this.GioiTinh = row["GioiTinh"].ToString();
        }
        public override bool Equals(object obj) //kiểm tra xem đối tượng KhachHang hiện tại có bằng với đối tượng obj không
        {
            return this.Equals(obj as KhachHang);
        }
        public bool Equals(KhachHang customerPre) //FormQLKhachHang: kiểm tra xem các thuộc tính của đối tượng KhachHang hiện tại có bằng với các thuộc tính của đối tượng customerPre không
        {
            if (customerPre == null)
                return false;
            if (this.cccd != customerPre.cccd) return false;
            if (this.ten != customerPre.ten) return false;
            if (this.ngaySinh != customerPre.ngaySinh) return false;
            if (this.diaChi != customerPre.diaChi) return false;
            if (this.sdt != customerPre.sdt) return false;
            if (this.gioiTinh != customerPre.gioiTinh) return false;
            return true;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int SDT { get => sdt; set => sdt = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string CCCD { get => cccd; set => cccd = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Id { get => id; set => id = value; }
    }
}
