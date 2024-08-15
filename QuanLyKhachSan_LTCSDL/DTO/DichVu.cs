using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVu
    {
        string id;
        string tenDichVu;
        string idLoaiDichVu;
        int giaDichVu;
        public DichVu() { }
        public DichVu(DataRow data)
        {
            Id = data["ID"].ToString();
            TenDichVu = data["TenDichVu"].ToString();
            IDLoaiDichVu = data["IDLoaiDichVu"].ToString();
            GiaDichVu = (int)data["GiaDichVu"];
        }
        public bool Equals(DichVu dichVuTruoc)
        {
            if (dichVuTruoc == null) return false;
            if (dichVuTruoc.idLoaiDichVu != this.idLoaiDichVu) return false;
            if (dichVuTruoc.tenDichVu != this.tenDichVu) return false;
            if (dichVuTruoc.giaDichVu != this.giaDichVu) return false;
            return true;
        }
        public string Id { get => id; set => id = value; }
        public string TenDichVu { get => tenDichVu; set => tenDichVu = value; }
        public string IDLoaiDichVu { get => idLoaiDichVu; set => idLoaiDichVu = value; }
        public int GiaDichVu { get => giaDichVu; set => giaDichVu = value; }
    }
}
