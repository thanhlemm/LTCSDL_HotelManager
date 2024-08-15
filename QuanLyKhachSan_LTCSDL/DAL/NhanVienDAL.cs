using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        private static NhanVienDAL instance;
        public static NhanVienDAL Instance
        {
            get { if (instance == null) instance = new NhanVienDAL(); return instance; }
            private set => instance = value;
        }

  

        //=========================================CHECK====================================
        //---------Check quyền tài khoản dựa trên id loại nhân viên
        public bool CheckAccess(string username, string idloainv) //FormQuanLyKS
        {
            string query = "CheckTaiKhoan @username , @idloainv";
            return !(DBConnect.Instance.ExecuteScalar(query, new object[] { username, idloainv }) is null);
        }

        //kiểm tra cmnd có tồn tại hay không
        public bool CheckCCCDNhanVien(string cccd)
        {
            string query = "CheckCCCDNhanVien @idCard";
            return DBConnect.Instance.ExecuteQuery(query, new object[] { cccd }).Rows.Count > 0;
        }

        //=========================================LẤY====================================
        public bool Login(string userName, string passWord) //FormDangNhap: Lấy thông tin đăng nhập từ csdl
        {
            string query = "Login @userName , @passWord";
            DataTable data = DBConnect.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return data.Rows.Count>0;
        }

        
        public NhanVien LoadThongTinNhanVienTheoUsername(string username) //FormThongTinCaNhan: Load thông tin cá nhân theo tên đăng nhập
        {
            //string query = "LayLoaiNhanVienTheoTenDangNhap @username";
            //DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            string query = "select * from NhanVien where TenDangNhap='" + username + "'";
            DataTable dataTable = DBConnect.Instance.ExecuteQuery(query);
            NhanVien NhanVien = new NhanVien(dataTable.Rows[0]);
            return NhanVien;
        }

        public DataTable LoadDSNhanVien() //FormQLNhanVien
        {
            string query = "LoadDSNhanVien";
            return DBConnect.Instance.ExecuteQuery(query);
        }

        public DataTable TimKiemNhanVien(string @string, int SDT) //FormQLNhanVien
        {
            string query = "TimKiemNhanVien @string , @int";
            return DBConnect.Instance.ExecuteQuery(query, new object[] { @string, SDT });
        }

        //=========================================THÊM====================================
        public bool ThemNhanVien(NhanVien nv) //FormQLNhanVien
        {
            string query = "EXEC ThemNhanVien @user , @name , @pass , @idStaffType , @idCard , @dateOfBirth , @sex , @address , @phoneNumber , @startDay";
            object[] parameter = new object[] {nv.TenDangNhap, nv.Ten, nv.MatKhau, nv.IDLoaiNhanVien,
                                               nv.CCCD, nv.NgaySinh, nv.GioiTinh,
                                                nv.DiaChi, nv.SDT, nv.NgayBatDauLam};
            return DBConnect.Instance.ExecuteNoneQuery(query, parameter) > 0;
        }

        //=========================================CẬP NHẬT====================================
        //cập nhật tên hiển thị -- FormThongTinCaNhan
        public bool CapNhatTenNhanVien(string username, string ten)
        {
            string query = "CapNhatTenNhanVien @username , @name";
            return DBConnect.Instance.ExecuteNoneQuery(query, new object[] { username, ten }) > 0;
        }

        //cập nhật pass -- FormQLNhanVien, FormThongTinCaNhan
        public bool CapNhatPass(string username, string password)
        {
            string query = "CapNhatPassword @username , @password";
            return DBConnect.Instance.ExecuteNoneQuery(query, new object[] { username, password }) > 0;
        }

        //cập nhật thông tin -- Form thong tin ca nhan
        public bool CapNhatThongTinNhanVien(string username, string dc, int phonenumber, string cccd, DateTime ngaysinh, string gioiTinh)
        {
            string query = "CapNhatThongTinNhanVien @username , @address , @phonenumber , @idcard , @dateOfBirth , @sex";
            return DBConnect.Instance.ExecuteNoneQuery(query, new object[] { username, dc, phonenumber, cccd, ngaysinh, gioiTinh }) > 0;
        }

        //Cập nhật nhân viên -- FormQLNhanVien
        public bool CapNhatNhanVien(NhanVien nv)
        {
            string query = "EXEC CapNhatNhanVien @user , @name , @idStaffType , @idCard , @dateOfBirth , @sex , @address , @phoneNumber , @startDay";
            object[] parameter = new object[] {nv.TenDangNhap, nv.Ten, nv.IDLoaiNhanVien,
                                               nv.CCCD, nv.NgaySinh, nv.GioiTinh,
                                                nv.DiaChi, nv.SDT, nv.NgayBatDauLam};
            return DBConnect.Instance.ExecuteNoneQuery(query, parameter) > 0;
        }

        //=========================================XOÁ====================================


    }
}
