using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiNhanVienDAL
    {
        private static LoaiNhanVienDAL instance;
        public static LoaiNhanVienDAL Instance
        {
            get { if (instance == null) instance = new LoaiNhanVienDAL(); return instance; }
            private set => instance = value;
        }

        //=========================================CHECK=========================================


        //=========================================LẤY=========================================
        public LoaiNhanVien LayLoaiNhanVienTheoTenDangNhap(string username) //FormThongTinCaNhan: 
        {
            string query = "LayLoaiNhanVienTheoTenDangNhap @username";
            LoaiNhanVien staffType = new LoaiNhanVien(DBConnect.Instance.ExecuteQuery(query, new object[] { username }).Rows[0]);
            return staffType;
        }

        public DataTable LoadDSLoaiNhanVien() //FormQLNhanVien: load danh sách lên
        {
            string query = "LoadDSLoaiNhanVien";
            return DBConnect.Instance.ExecuteQuery(query);
        }

        //=========================================THÊM=========================================


        //=========================================CẬP NHẬT=========================================


        //=========================================XOÁ=========================================



    }
}
