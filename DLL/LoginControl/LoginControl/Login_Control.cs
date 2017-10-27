using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Data.SqlClient;
using static LoginControl.Check_Login;

namespace LoginControl
{
    public partial class Login_Control : UserControl
    {
        DB_Connect con;
        Check_Login login = new Check_Login();
        public string publicKey = "LeTrungDo";

        public string connectString = "";
        public string tableName = "";//tên bảng người dùng
        public string colUser = "";//tên cột tên đăng nhập
        public string colPass = "";//tên cột mật khẩu

       
        public string username = "";
        public string password = "";
        public Form frmMain = new Form();
        public Form frmLogin = new Form();
        public Form frmConfig = new Form();


        public Login_Control()
        {
            InitializeComponent();
        }
        
        public static string Encrypt(string value, string publickKey)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }
            byte[] bytesIn = Encoding.UTF8.GetBytes(value);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] bytesKey = Encoding.UTF8.GetBytes(publickKey);
            Array.Resize(ref bytesKey, des.Key.Length);
            Array.Resize(ref bytesKey, des.IV.Length);
            des.Key = bytesKey;
            des.IV = bytesKey;
            MemoryStream msOut = new MemoryStream();
            ICryptoTransform desdecrypt = des.CreateEncryptor();
            CryptoStream cryptStreem = new CryptoStream(msOut, desdecrypt,
            CryptoStreamMode.Write);
            cryptStreem.Write(bytesIn, 0, bytesIn.Length);
            cryptStreem.FlushFinalBlock();
            byte[] bytesOut = msOut.ToArray();
            cryptStreem.Close();
            msOut.Close();
            return Convert.ToBase64String(bytesOut);
        }
        

        private void btn_Login_Click(object sender, EventArgs e)
        {
            con = new DB_Connect(connectString);

            if (txt_User.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập tên đăng nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_Pass.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            int kq = con.Check_Config(connectString); //hàm Check_Config() 
            if (kq == 0)
            {
                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmConfig.Show();
            }
            if (kq == 2)
            {
                MessageBox.Show("Cấu hình máy chủ không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmConfig.Show();
            }
        }

        void ProcessLogin()
        {
            LoginResult result = login.Check_User(tableName, colUser, txt_User.Text,colPass, Encrypt(txt_Pass.Text,publicKey), connectString);

            if (result == LoginResult.Invalid)
            {
                // Wrong username or passif (result == LoginResult.Invalid)

                MessageBox.Show("Sai tên đăng nhập Hoặc mật khẩu");
                return;
            }
            //Account had been disabled
            else if (result == LoginResult.Disabled)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            frmMain.Tag = txt_User.Text;//lấy tên đăng nhập
            frmMain.Show();

            frmLogin.Hide();

            //Ghi nhớ tên đăng nhập và pass

            if (chk_SaveInfo.Checked)
            {
                username = txt_User.Text;
                password = txt_Pass.Text;
            }
            else
            {
                username = "";
                password = "";
            }

            con.Disconnet();
        }
            
    }
}
