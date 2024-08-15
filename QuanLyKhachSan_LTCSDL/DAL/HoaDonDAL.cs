using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL
    {
        private static HoaDonDAL instance;
        public static HoaDonDAL Instance
        {
            get { if (instance == null) instance = new HoaDonDAL(); return instance; }
            private set => instance = value;
        }

        //=========================================CHECK=========================================
        
            public bool CheckHoaDonPhongDaNhan(string idRoom)// > 0 Tồn tại Bill
        {
            string query = "CheckTrangThaiHoaDon_Phong @idRoom";
            return DBConnect.Instance.ExecuteQuery(query, new object[] { idRoom }).Rows.Count > 0;
        }

        //=========================================LẤY=========================================
        public DataRow ShowHoaDonPhong(string idRoom) //FormThanhToan
        {
            string query = "ShowHoaDonPhong @getToday , @idRoom";
            return DBConnect.Instance.ExecuteQuery(query, new object[] { DateTime.Now.Date, idRoom }).Rows[0];
        }
        public DataTable ShowHoaDonDichVu(string idRoom)//FormThanhToan
        {
            string query = "ShowHoaDonDichVu @idRoom";
            return DBConnect.Instance.ExecuteQuery(query, new object[] { idRoom });
        }
        public string LayIDHoaDonTheoIDPhong(string idRoom)
        {
            string query = "LayIDHoaDonTheoIDPhong @idRoom";
            DataRow dataRow = DBConnect.Instance.ExecuteQuery(query, new object[] { idRoom }).Rows[0];
            HoaDon bill = new HoaDon(dataRow);
            return bill.Id;
        }

        public DataTable LoadDSHoaDon()//FormQLHoaDon
        {
            string query = "LoadDSHoaDon";
            return DBConnect.Instance.ExecuteQuery(query);
        }

        public DataTable TimKiemHoaDon(string text, int mode)
        {
            string query = "TimKiemHoaDon @string , @mode";
            return DBConnect.Instance.ExecuteQuery(query, new object[] { text, mode });
        }

        //=========================================THÊM=========================================
        public bool ThemHoaDon(string id, string idReceiveRoom, string staffSetUp) //FormThanhToan
        {
            string query = "ThemHoaDon @id , @idReceiveRoom , @staff";
            return DBConnect.Instance.ExecuteNoneQuery(query, new object[] { id, idReceiveRoom, staffSetUp }) > 0;
        }

        //=========================================CẬP NHẬT=========================================
        public bool CapNhatHoaDon_GiaPhong(string idBill) //FormThanhToan
        {
            string query = "CapNhatHoaDon_GiaPhong @idBill";
            return DBConnect.Instance.ExecuteNoneQuery(query, new object[] { idBill }) > 0;
        }

        public bool CapNhatHoaDon_GiamGia(string idBill, int discount) //FormThanhToan
        {
            string query = "CapNhatHoaDon_GiamGia @idBill , @discount";
            return DBConnect.Instance.ExecuteNoneQuery(query, new object[] { idBill, discount }) > 0;
        }
        public bool CapNhathoaDon_GiaDichVu(string idBill)
        {
            string query = "CapNhatHoaDon_GiaDichVu @idBill";
            return DBConnect.Instance.ExecuteNoneQuery(query, new object[] { idBill }) > 0;
        }


        //=========================================XOÁ=========================================

    }
}
