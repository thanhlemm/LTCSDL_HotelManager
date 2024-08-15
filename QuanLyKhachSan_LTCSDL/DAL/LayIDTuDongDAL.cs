using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LayIDTuDongDAL
    {
        private static LayIDTuDongDAL instance;
        public static LayIDTuDongDAL Instance
        {
            get { if (instance == null) instance = new LayIDTuDongDAL(); return instance; }
            private set => instance = value;
        }
        //=========================================LẤY=========================================
        public string LayIDTuDong(string table, string nameID)
        {
            string query = "CapIDTuDong @table , @nameID";
            return (string)DBConnect.Instance.ExecuteScalar(query, new object[] { table, nameID });
        }

        //-----------Tự cấp số ID
        public string TuDong_ID(string table, string nameID)
        {
            string id, newid;
            id = LayIDTuDong(table, nameID);
            string TienTo;
            int HauTo;
            TienTo = id.Substring(0, 2);
            HauTo = int.Parse(id.Substring(2).ToString());
            HauTo++;
            if (HauTo < 10)
            {
                newid = string.Concat(TienTo, "00", HauTo.ToString());
            }
            else
            {
                if (HauTo < 100)
                {
                    newid = string.Concat(TienTo, "0", HauTo.ToString());

                }
                else
                {
                    newid = string.Concat(TienTo, HauTo.ToString());
                }
            }
            return newid;
        }
        
        private LayIDTuDongDAL() { }
    }
}
