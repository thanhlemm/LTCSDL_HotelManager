using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhanPhong
    {
        private string id;
        private string idPhieuDatPhong;
        private string idPhong;
        public PhieuNhanPhong(DataRow row)
        {
            Id = row["ID"].ToString();
            IdPhieuDatPhong = row["IDPhieuDatPhong"].ToString();
            IdPhong = row["IDPhong"].ToString();
        }
        public string Id { get => id; set => id = value; }
        public string IdPhieuDatPhong { get => idPhieuDatPhong; set => idPhieuDatPhong = value; }
        public string IdPhong { get => idPhong; set => idPhong = value; }
    }
}
