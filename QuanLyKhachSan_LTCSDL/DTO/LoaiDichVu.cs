using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiDichVu
    {
        private string id;
        private string tenLoaiDichVu;
        public LoaiDichVu() { }
        public LoaiDichVu(DataRow dataRow)
        {
            Id = dataRow["ID"].ToString();
            TenLoaiDichVu = dataRow["TenLoaiDichVu"].ToString();
        }
        public bool Equals(LoaiDichVu loaiDichVuTruoc)
        {
            return this.tenLoaiDichVu == loaiDichVuTruoc.tenLoaiDichVu;
        }
        public string Id { get => id; set => id = value; }
        public string TenLoaiDichVu { get => tenLoaiDichVu; set => tenLoaiDichVu = value; }
    }
}
