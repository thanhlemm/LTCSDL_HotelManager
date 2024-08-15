using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietHoaDonDAL
    {
        private static ChiTietHoaDonDAL instance;
        public static ChiTietHoaDonDAL Instance
        {
            get { if (instance == null) instance = new ChiTietHoaDonDAL(); return instance; }
            private set => instance = value;
        }
        //=========================================CHECK=========================================
        public bool CheckDichVu_ChiTietHoaDon(string idRoom, string idService)// >0 dịch vụ đã có chi tiết hóa đơn, chỉ cần update lại thôi, <0 tạo chi tiết hóa đơn
        {
            string query = "CheckDichVu_ChiTietHoaDon @idRoom , @idservice";
            return DBConnect.Instance.ExecuteQuery(query, new object[] { idRoom, idService }).Rows.Count > 0;
        }

        //=========================================THÊM=========================================
        public bool ThemChiTietHoaDon(string idBill, string idService, int count)
        {
            string query = "ThemChiTietHoaDon @idBill , @idService , @count";
            return DBConnect.Instance.ExecuteNoneQuery(query, new object[] { idBill, idService, count }) > 0;
        }

        //=========================================CẬP NHẬT=========================================
        public bool CapNhatChiTietHoaDon(string idBill, string idService, int _count)
        {
            string query = "CapNhatChiTietHoaDon @idBill , @idService , @_count";
            return DBConnect.Instance.ExecuteNoneQuery(query, new object[] { idBill, idService, _count }) > 0;
        }
        
    }
}
