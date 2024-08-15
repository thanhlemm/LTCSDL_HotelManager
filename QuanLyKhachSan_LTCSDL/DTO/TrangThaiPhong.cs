using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrangThaiPhong
    {
        private string id;
        private string trangthai;
        public string TrangThai { get => trangthai; set => trangthai = value; }
        public string Id { get => id; set => id = value; }


        public TrangThaiPhong() { }
        public TrangThaiPhong(string id, string trangthai)
        {
            this.Id = id;
            this.TrangThai = trangthai;
        }
        public TrangThaiPhong(DataRow row)
        {
            this.Id = row["ID"].ToString();
            this.TrangThai = row["TrangThai"].ToString();
        }

        public bool Equals(TrangThaiPhong ttp)
        {
            return this.trangthai == ttp.trangthai;
        }
    }
}
