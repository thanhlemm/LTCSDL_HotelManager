using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhongDAL
    {
        private static PhongDAL instance;
        public static PhongDAL Instance
        {
            get { if (instance==null) instance=new PhongDAL(); return instance; }
            private set => instance = value;
        }
        //=========================================TÌM=========================================
        public DataTable Tim(string text, int id)
        {
            string query = "TimPhong @string , @id";
            return DBConnect.Instance.ExecuteQuery(query, new object[] { text, id });
        }

        //=========================================CHECK=========================================


        //=========================================LẤY=========================================
        public List<Phong> LoadPhongTrong(string idLoaiPhong) //FormNhanPhong: Load danh sách phòng trống vào combobox
        {
            List<Phong> rooms = new List<Phong>();
            string query = "LoadPhongTrong @idRoomType";
            DataTable data = DBConnect.Instance.ExecuteQuery(query, new object[] { idLoaiPhong });
            foreach (DataRow item in data.Rows)
            {
                Phong room = new Phong(item);
                rooms.Add(room);
            }
            return rooms;
        }
        public List<Phong> LoadDSPhongDaNhan()
        {
            string query = "LoadDSPhongThanhToan @getToday";
            List<Phong> rooms = new List<Phong>();
            DataTable data = DBConnect.Instance.ExecuteQuery(query, new object[] { DateTime.Now.Date });
            foreach (DataRow item in data.Rows)
            {
                Phong room = new Phong(item);
                rooms.Add(room);
            }
            return rooms;
        }

        public DataTable LoadDSPhong()
        {
            return DBConnect.Instance.ExecuteQuery("LoadDSPhong");
        }

        //=========================================THÊM=========================================
        public bool ThemPhong(Phong phongHienTai)
        {
            return ThemPhong(phongHienTai.ID, phongHienTai.TenPhong, phongHienTai.IDLoaiPhong, phongHienTai.IDTrangThaiPhong);
        }
        public bool ThemPhong(string id, string tenPhong, string idLoaiPhong, int idTrangThaiPhong)
        {
            string query = "ThemPhong @id , @nameRoom , @idRoomType , @idStatusRoom";
            return DBConnect.Instance.ExecuteNoneQuery(query, new object[] { id, tenPhong, idLoaiPhong, idTrangThaiPhong }) > 0;
        }

        //=========================================CẬP NHẬT=========================================
        public bool CapNhatPhong(Phong roomNow) //FormQLPhong: Sau khi cập nhật phòng thì phải cập nhật lun khách hàng của phòng cũ
        {
            string query = "CapNhatPhong  @id , @nameRoom , @idRoomType , @idStatusRoom";
            return DBConnect.Instance.ExecuteNoneQuery(query, new object[] { roomNow.ID, roomNow.TenPhong, roomNow.IDLoaiPhong, roomNow.IDTrangThaiPhong }) > 0;
        }

        //=========================================XOÁ=========================================
    }
}
