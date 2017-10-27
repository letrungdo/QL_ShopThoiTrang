using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class ConnectDB
    {
        private SqlConnection conn;
        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        public string GetConnectString()
        {
            return Properties.Settings.Default.QL_ShopThoiTrangConnectionString;
        }

        public ConnectDB()
        {
            conn = new SqlConnection(Properties.Settings.Default.QL_ShopThoiTrangConnectionString);
        }

        public ConnectDB(string connectString)
        {
            conn = new SqlConnection(connectString);
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
        
        /// thực hiện câu lệnh truy vấn bảng dữ liệu
        public SqlDataReader ExecuteReader(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteReader();
        }

        /// thực hiện câu lệnh truy vấn không trả về giá trị (update insert)
        public int ExecuteNonQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteNonQuery();
        }

        /// thực hiện nhưng câu lệnh trả về đơn giá trị
        public object ExecuteScalar(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteScalar();
        }
    }
}
