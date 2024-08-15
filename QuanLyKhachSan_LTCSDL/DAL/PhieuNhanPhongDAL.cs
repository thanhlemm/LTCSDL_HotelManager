using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuNhanPhongDAL
    {
        private static PhieuNhanPhongDAL instance;
        public static PhieuNhanPhongDAL Instance
        {
            get { if (instance == null) instance = new PhieuNhanPhongDAL(); return instance; }
            private set => instance = value;
        }
        //=========================================CHECK=========================================
        public bool CheckPhieuDatPhong(string id) //FormDatPhong, FormNhanPhong
        {
            string query = "CheckPhieuDatPhong @idBookRoom";
            int count = DBConnect.Instance.ExecuteQuery(query, new object[] { id }).Rows.Count;
            return count > 0;
        }

        //=========================================LẤY=========================================
        public string LayIDPhieuNhanPhongHienTai() //FormNhanPhong: Để thêm id phiếu nhận phòng mới được tạo vào chi tiết phiếu nhận phòng ThemChiTietNhanPhong(string idPhieuNhanPhong, string idKhachHang)
        {
            string query = "LayIDPhieuNhanPhongHienTai";
            return (string)DBConnect.Instance.ExecuteScalar(query);
        }

        public DataTable LoadThongTinNhanPhong() //FormNhanPhong: Load lên dataGridView
        {
            string query = "LoadPhieuNhanPhongTheoNgayNhanPhong @date";
            return DBConnect.Instance.ExecuteQuery(query, new object[] { DateTime.Now.Date });
        }

        public string LayIDPhieuNhanPhongTheoIDPhong(string idRoom) //FormThanhToan: để thanh toán
        {
            string query = "LayIDPhieuNhanPhongTheoIDPhong @idRoom";
            DataTable dataTable = DBConnect.Instance.ExecuteQuery(query, new object[] { idRoom });
            PhieuNhanPhong receiveRoom = new PhieuNhanPhong(dataTable.Rows[0]);
            return receiveRoom.Id;
        }
        //=========================================THÊM=========================================
        public bool ThemPhieuNhanPhong(string id, string idBookRoom, string idRoom) //FormNhanPhong
        {
            string query = "ThemPhieuNhanPhong @id , @idBookRoom , @idRoom";
            int SoLuong = DBConnect.Instance.ExecuteNoneQuery(query, new object[] { id, idBookRoom, idRoom });
            return SoLuong > 0;
        }

        //=========================================CẬP NHẬT=========================================


        //=========================================XOÁ=========================================


       

    }
}
