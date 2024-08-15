using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class KhachHangDAL
    {
        private static KhachHangDAL instance;
        private KhachHangDAL() { }
        public static KhachHangDAL Instance
        {
            get { if (instance == null) instance = new KhachHangDAL(); return instance; }
            private set => instance = value;
        }
        //=========================================CHECK=========================================
        public bool CheckCCCD(string cccd) //FormDatPhong
        {
            string query = "CheckCCCDCoTonTaiKhong @idCard";
            int count = DBConnect.Instance.ExecuteQuery(query, new object[] { cccd }).Rows.Count;
            return count > 0;
        }

        //=========================================LẤY=========================================
        public KhachHang LayThongTinTheoCCCD(string cccd) //FormDatPhong
        {
            string query = "CheckCCCDCoTonTaiKhong @idCard";
            KhachHang khachhang = new KhachHang(DBConnect.Instance.ExecuteQuery(query, new object[] { cccd }).Rows[0]);
            return khachhang;

        }

        public DataTable LoadDSKhachHang()//FormQLKhachHang
        {
            string query = "LoadDSKhachHang";
            return DBConnect.Instance.ExecuteQuery(query);
        }

        public DataTable TimKiemKhachHang(string text, int phoneNumber) //FormQLKhachHang 
        {
            string query = "TimKiemKhachHang @string , @int";
            return DBConnect.Instance.ExecuteQuery(query, new object[] { text, phoneNumber });
        }

        //=========================================THÊM=========================================
        public bool ThemKhachHang(string id, string cccd, string ten, DateTime ngaysinh, string diachi, int sdt, string gioitinh)  //FormDatPhong
        {
            string query = "exec ThemKhachHang  @ID , @idCard , @name , @dateOfBirth , @address , @phoneNumber , @sex";
            return DBConnect.Instance.ExecuteNoneQuery(query, new object[] { id, cccd, ten, ngaysinh, diachi, sdt, gioitinh })>0;
        }

        public bool ThemKhachHang(KhachHang khachhang)
        {
            return ThemKhachHang(khachhang.Id, khachhang.CCCD, khachhang.Ten, khachhang.NgaySinh, khachhang.DiaChi, khachhang.SDT, khachhang.GioiTinh);
        }
        
        //=========================================CẬP NHẬT=========================================
        //FormChiTietDatPhong
        public bool CapNhatKhachHang(string id, string ten, string cccd, int sdt, DateTime dateOfBirth, string diachi, string gioiTinh) //FormChiTietDatPhong
        {
            string query = "CapNhatKhachHang @id , @name , @cccd , @phoneNumber , @dateOfBirth , @address , @sex";
            return DBConnect.Instance.ExecuteNoneQuery(query, new object[] { id, ten, cccd, sdt, dateOfBirth, diachi, gioiTinh })>0;
        
        }

        public bool CapNhatKhachHang(KhachHang khmoi, KhachHang khcu)
        {
            string query = "CapNhatKhachHang_FormQL @id , @customerName  ," +
                            " @CCCDNow , @address , @dateOfBirth , " +
                            "@phoneNumber , @sex , @CCCDPre"; 
            object[] parameter = new object[] {khmoi.Id, khmoi.Ten, khmoi.CCCD,
                                    khmoi.DiaChi, khmoi.NgaySinh, khmoi.SDT,
                                    khmoi.GioiTinh, khcu.CCCD};
            return DBConnect.Instance.ExecuteNoneQuery(query, parameter) > 0;
        }

        //=========================================XOÁ=========================================
        public bool XoaKhachHang(string cccd) //FormChiTietDatPhong //FormQLKhachHang
        {
            string query = "XoaKhachHang @cccd";
            return DBConnect.Instance.ExecuteNoneQuery(query, new object[] { cccd}) > 0;
        }
    }
}
