using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        private string idHoaDon;
        private string idDichVu;
        private int soLuong;
        private int tongTien;
        public ChiTietHoaDon(DataRow data)
        {
            IDHoaDon = data["IDHoaDon"].ToString();
            IDDichVu = data["IDDichVu"].ToString();
            SoLuong = (int)data["SoLuong"];
            TongTien = (int)data["TongTien"];
        }
        public string IDHoaDon { get => idHoaDon; set => idHoaDon = value; }
        public string IDDichVu { get => idDichVu; set => idDichVu = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
    }
}
