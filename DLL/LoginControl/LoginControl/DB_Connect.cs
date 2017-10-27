using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginControl
{
    public class DB_Connect
    {
        private SqlConnection conn;
        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }


        public DB_Connect(string s)
        {
            conn = new SqlConnection(s);
        }

        public void Connect()
        {
            if (conn != null && conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void Disconnet()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        public int Check_Config(string connectString)
        {
            if (connectString == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tại
            SqlConnection _Sqlconn = new SqlConnection(connectString);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;// Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2;// Chuỗi cấu hình không phù hợp.
            }
        }


    }
}
