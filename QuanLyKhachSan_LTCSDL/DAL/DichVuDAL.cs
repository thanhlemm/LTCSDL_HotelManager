using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DichVuDAL
    {
        private static DichVuDAL instance;
        public static DichVuDAL Instance
        {
            get { if (instance == null) instance = new DichVuDAL(); return instance; }
            private set => instance = value;
        }
        public List<DichVu> LoadDichVuTheoLoaiDichVu(string idServiceType)
        {
            List<DichVu> services = new List<DichVu>();
            string query = "LoadDichVuTheoLoaiDichVu @idServiceType";
            DataTable dataTable = DBConnect.Instance.ExecuteQuery(query, new object[] { idServiceType });
            foreach (DataRow item in dataTable.Rows)
            {
                DichVu service = new DichVu(item);
                services.Add(service);
            }
            return services;
        }
       

    }
}
