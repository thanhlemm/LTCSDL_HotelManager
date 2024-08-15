using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        SqlCommand command;
        SqlConnection getConnect;
        SqlDataAdapter adapter;
        DataTable data;
        private static DBConnect instance;

        private void getConnectData()
        {
            getConnect = new SqlConnection(@"Data Source=LEVANTAN;Initial Catalog=QLKS_LTCSDL_2;Integrated Security=True");
            getConnect.Open();

        }
        //closeConnect SQL
        private void closeConnectData()
        {
            getConnect.Close();
            getConnect.Dispose();
        }
        private void AddParameter(string query, object[] parameter, SqlCommand command)
        {
            if (parameter != null)
            {
                string[] listParameter = query.Split(' ');
                int i = 0;
                foreach (string item in listParameter)
                {
                    if (item.Contains("@"))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        ++i;
                    }
                }
            }
        }
        //thực thi một câu truy vấn SQL và trả về kết quả dưới dạng một đối tượng DataTable.
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {

            getConnectData();
            command = new SqlCommand(query, getConnect);
            AddParameter(query, parameter, command);
            adapter = new SqlDataAdapter(command);
            data = new DataTable();
            adapter.Fill(data);

            closeConnectData();
            return data;
        }
        //Thực hiện sql insert update delete
        //thực hiện các câu lệnh SQL không trả về kết quả (trả về số dòng bị ảnh hưởng trong cơ sở dữ liệu)
        public int ExecuteNoneQuery(string query, object[] parameter = null)
        {
            int dt = 0;
            getConnectData();
            command = new SqlCommand(query, getConnect);
            AddParameter(query, parameter, command);
            dt = command.ExecuteNonQuery();
            closeConnectData();

            return dt;
        }

        //.trả về một giá trị đơn lẻ, do đó cần được chuyển đổi sang kiểu dữ liệu phù hợp.
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = new object();
            getConnectData();
            command = new SqlCommand(query, getConnect);
            AddParameter(query, parameter, command);
            data = command.ExecuteScalar();
            closeConnectData();

            return data;
        }
        
        public static DBConnect Instance
        {
            get { if (instance == null) instance = new DBConnect(); return instance; }
            private set => instance = value;
        }
        private DBConnect() { }
    }
}
