using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhong
    {
        private string id;
        private string tenLoaiPhong;
        private int gia;
        private int soLuongNguoi;
        public LoaiPhong() { }
        public LoaiPhong(string id, string tenLoaiPhong, int gia, int soLuongNguoi)
        {
            this.ID = id;
            this.TenLoaiPhong = tenLoaiPhong;
            this.Gia = gia;
            this.SoLuongNguoi = soLuongNguoi;
        }
        public LoaiPhong(DataRow row)
        {
            this.ID = row["ID"].ToString();
            this.TenLoaiPhong = row["TenLoaiPhong"].ToString();
            this.Gia = (int)row["GiaPhong"];
            this.SoLuongNguoi= (int)row["SoLuongNguoi"];
        }
        public bool Equals(LoaiPhong loaiPhongtruoc)
        {
            if (loaiPhongtruoc == null) return false;
            if (this.tenLoaiPhong != loaiPhongtruoc.tenLoaiPhong) return false;
            if (this.gia != loaiPhongtruoc.gia) return false;
            if (this.soLuongNguoi != loaiPhongtruoc.soLuongNguoi) return false;
            return true;
        }
        public string ID { get => id; set => id = value; }
        public string TenLoaiPhong { get => tenLoaiPhong; set => tenLoaiPhong = value; }
        public int Gia { get => gia; set => gia = value; }
        public int SoLuongNguoi { get => soLuongNguoi; set => soLuongNguoi = value; }
    }
}
