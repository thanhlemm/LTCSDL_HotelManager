using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiDichVuDAL
    {
        private static LoaiDichVuDAL instance;
        public static LoaiDichVuDAL Instance
        {
            get { if (instance == null) instance = new LoaiDichVuDAL(); return instance; }
            private set => instance = value;
        }

        public List<LoaiDichVu> LayDSLoaiDichVu()
        {
            string query = "select * from LoaiDichVu";
            List<LoaiDichVu> serviceTypes = new List<LoaiDichVu>();
            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                LoaiDichVu serviceType = new LoaiDichVu(item);
                serviceTypes.Add(serviceType);
            }
            return serviceTypes;
        }
    }
}
