using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phong
    {
        private string id;
        private string ten;
        private string idLoaiPhong;
        private int idTrangThaiPhong;
        public Phong() { }
        public Phong(string id, string ten, string idloaiphong, int idtrangthai)
        {
            this.ID = id;
            this.TenPhong = ten;
            this.IDLoaiPhong = idloaiphong;
            this.IDTrangThaiPhong = idtrangthai;
        }
        public Phong(DataRow row)
        {
            this.ID = row["ID"].ToString();
            this.TenPhong =row["TenPhong"].ToString();
            this.IDLoaiPhong =row["IDLoaiPhong"].ToString();
            this.IDTrangThaiPhong = (int)row["IDTrangThaiPhong"];
        }
        public bool Equals(Phong roomPre)
        {
            if (roomPre == null) return false;
            if (roomPre.id != this.id) return false;
            if (roomPre.ten != this.ten) return false;
            if (roomPre.idLoaiPhong != this.idLoaiPhong) return false;
            if (roomPre.idTrangThaiPhong != this.idTrangThaiPhong) return false;
            return true;
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Phong);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public string ID { get => id; set => id = value; }
        public string TenPhong { get => ten; set => ten = value; }
        public string IDLoaiPhong { get => idLoaiPhong; set => idLoaiPhong = value; }
        public int IDTrangThaiPhong { get => idTrangThaiPhong; set => idTrangThaiPhong = value; }
    }
}
