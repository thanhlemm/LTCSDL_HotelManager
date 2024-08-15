using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuDatPhongDAL
    {
        private static PhieuDatPhongDAL instance;
        private PhieuDatPhongDAL() { }
        public static PhieuDatPhongDAL Instance
        {
            get { if (instance == null) instance = new PhieuDatPhongDAL(); return instance; }
            private set => instance = value;
        }

        //=========================================CHECK====================================
        public bool CheckIDPhieuDP(string idPhieuDP) //FormChiTietDatPhong, FormNhanPhong
        {
            string query = "CheckIDPhieuDatPhong @idBookRoom , @dateNow";
            DataTable dataTable = DBConnect.Instance.ExecuteQuery(query, new object[] { idPhieuDP, DateTime.Now.Date });
            return dataTable.Rows.Count > 0;
        }

        //=========================================LẤY====================================
        public DataTable LoadDanhSachDP(DateTime dateTime) //FormDatPhong: Load lên dataGridView
        {
            string query = "LayDSDatPhongTheoNgay @date";
            return DBConnect.Instance.ExecuteQuery(query, new object[] { dateTime });

        }
        public string LayIDPhieuDP(DateTime dateTime, string idPhieuDP) //FormDatPhong: để truyền vào FormNhanPhong id phiếu đặt phòng theo ngày
        {
            string query = "LayDSDatPhongTheoIDNgay @date , @idbookroom";
            DataRow dataRow = DBConnect.Instance.ExecuteQuery(query, new object[] { dateTime, idPhieuDP }).Rows[0];
            return (string)dataRow["Mã đặt phòng"];
        }

        public DataRow ShowThongTinDatPhong(string idPhieuDP) //FormNhanPhong
        {
            string query = "ShowThongTinPhieuDatPhong @idBookRoom";
            return DBConnect.Instance.ExecuteQuery(query, new object[] { idPhieuDP }).Rows[0];
        }

        //=========================================THÊM====================================
        public bool ThemPhieuDP(string id, string idKhachHang, string idLoaiPhong, DateTime ngaynhan, DateTime ngaytra, DateTime ngaydat)
        //FormDatPhong
        {
            string query = "ThemPhieuDP @ID , @idCustomer , @idRoomType , @datecheckin , @datecheckout , @datebookroom";
            return DBConnect.Instance.ExecuteNoneQuery(query, new object[] { id, idKhachHang, idLoaiPhong, ngaynhan, ngaytra, ngaydat }) > 0;
        }

        //=========================================CẬP NHẬT====================================
        public bool CapNhatPhieuDatPhong(string id, string idLoaiPhong, DateTime ngaynhan, DateTime ngaytra)
        //FormChiTietDatPhong
        {
            string query = "CapNhatPhieuDatPhong @id , @idRoomType , @dateCheckIn , @datecheckOut";
            return DBConnect.Instance.ExecuteNoneQuery(query, new object[] { id, idLoaiPhong, ngaynhan, ngaytra }) > 0;
        }

        //=========================================XOÁ====================================
        public bool XoaPhieuDatPhong(string id)
        //FormChiTietDatPhong
        {
            string query = "XoaPhieuDatPhong @id";
            return DBConnect.Instance.ExecuteNoneQuery(query, new object[] { id }) > 0;
        }

        
    }
}
