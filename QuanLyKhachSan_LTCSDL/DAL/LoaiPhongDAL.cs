using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiPhongDAL
    {
        private static LoaiPhongDAL instance;
        public static LoaiPhongDAL Instance
        {
            get { if (instance == null) instance = new LoaiPhongDAL(); return instance; }
            private set => instance = value;
        }
        public LoaiPhongDAL() { }

        //=========================================LẤY=========================================
        public LoaiPhong LoadThongTinLoaiPhong(string id) // FormDatPhong: Load vào groupBox thông tin loại phòng
        {
            string query = "ThongTinLoaiPhong @id";
            DataTable data = DBConnect.Instance.ExecuteQuery(query, new object[] { id });
            LoaiPhong roomType = new LoaiPhong(data.Rows[0]);
            return roomType;
        }
        public List<LoaiPhong> LoadDanhSachLoaiPhong() // FormDatPhong: Load lên comboBox để chọn
        {
            string query = "select * from LoaiPhong";
            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            List<LoaiPhong> dsLoaiPhong = new List<LoaiPhong>();
            foreach (DataRow item in data.Rows)
            {
                LoaiPhong loaiPhong = new LoaiPhong(item);
                dsLoaiPhong.Add(loaiPhong);
            }
            return dsLoaiPhong;
        }
        public LoaiPhong LayLoaiPhongTheoIDPhieuDP(string idPhieuDP) // Form ChiTietDatPhong: Load lên tên loại phòng đã đặt theo id phiếu đặt phòng
        {
            string query = "LayLoaiPhongTheoIDPhieuDP @idBookRoom";
            DataTable data = DBConnect.Instance.ExecuteQuery(query, new object[] { idPhieuDP });
            LoaiPhong roomType = new LoaiPhong(data.Rows[0]);
            return roomType;
        }
        //lấy thông tin loại phòng theo phòng
        public LoaiPhong LayLoaiPhongTheoIDPhong(string idPhong) //FormThanhToan: để load các màu button loại phòng dựa theo id phòng
        {
            string query = "LayLoaiPhongTheoIDPhong @idRoom";
            DataTable data = DBConnect.Instance.ExecuteQuery(query, new object[] { idPhong });
            LoaiPhong roomType = new LoaiPhong(data.Rows[0]);
            return roomType;
        }

        public DataTable LoadLoaiPhong() //FormQLPhong
        {
            return DBConnect.Instance.ExecuteQuery("LoadLoaiPhong");
        }

        //=========================================CẬP NHẬT=========================================

        public bool CapNhatLoaiPhong(LoaiPhong roomNow, LoaiPhong roomPre)//FormQLPhong
        {
            string query = "CapNhatLoaiPhong @id , @name , @price , @limitPerson";
            return DBConnect.Instance.ExecuteNoneQuery(query, new object[] { roomNow.ID, roomNow.TenLoaiPhong, roomNow.Gia, roomNow.SoLuongNguoi }) > 0;
        }
    }
}
