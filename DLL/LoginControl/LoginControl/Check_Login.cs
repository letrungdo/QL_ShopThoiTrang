using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace LoginControl
{
    public class Check_Login
    {
        public enum LoginResult
        {
            /// <summary>
            /// Wrong username or password
            /// </summary>
            Invalid,
            /// <summary>
            /// User had been disabled
            /// </summary>
            Disabled,
            /// <summary>
            /// Loging success
            /// </summary>
            Success
        }

        public LoginResult Check_User(string tableName, string colUser, string pUser,string colPass, string pPass, string connectString)
        {
            string selectString = string.Format("SELECT * FROM {0} WHERE {1}='{2}' and {3}='{4}'",
                   tableName, colUser, pUser, colPass, pPass);

            SqlDataAdapter daUser = new SqlDataAdapter(selectString, connectString);
            DataTable dt = new DataTable();
            daUser.Fill(dt);

            if (dt.Rows.Count == 0)
                return LoginResult.Invalid;// User không tồn tại
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
            {
                return LoginResult.Disabled;// Không hoạt động
            }
            return LoginResult.Success;// Đăng nhập thành công
        }
    }
}
