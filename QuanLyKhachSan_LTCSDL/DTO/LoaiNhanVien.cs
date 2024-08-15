using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiNhanVien
    {
        private string id;
        private string tenloai;
        public LoaiNhanVien(DataRow dataRow)
        {
            Id = dataRow["ID"].ToString();
            Name = dataRow["TenLoai"].ToString();
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => tenloai; set => tenloai = value; }
    }
}
