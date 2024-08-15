using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TrangThaiPhongDAL
    {
        private static TrangThaiPhongDAL instance;
        private TrangThaiPhongDAL() { }
        public static TrangThaiPhongDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TrangThaiPhongDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable LoadTrangThaiPhong()
        {
            return DBConnect.Instance.ExecuteQuery("LoadTrangThaiPhong");
        }
    }
}
