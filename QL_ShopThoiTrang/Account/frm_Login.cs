using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATA;
using DevExpress.XtraBars;

namespace QL_ShopThoiTrang
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            
        }
        
        public void frm_Login_Load(object sender, EventArgs e)
        {
            
            userControl_login.connectString = Properties.Settings.Default.QL_ShopThoiTrangConnectionString;

            userControl_login.publicKey = "LeTrungDo";//thay đổi khóa mã hóa ở đây

            userControl_login.tableName = "NhanVien";//change Table name here
            userControl_login.colUser = "Username";
            userControl_login.colPass = "Password";
            userControl_login.frmMain = new frm_Main();// open form main
            userControl_login.frmLogin = this;//Hide form login

            frm_Config frm = new frm_Config();

            userControl_login.frmConfig = frm;

            //nhấn enter để login k0 cần nhấn nút đăng nhập
            this.AcceptButton = userControl_login.btn_Login;

            //load thông tin đăng nhập
            userControl_login.txt_Pass.Text = Properties.Settings.Default.Password;
            userControl_login.txt_User.Text = Properties.Settings.Default.Username;
            
        }
        
        public void getLogout(object sender, ItemClickEventArgs e)//logout thì xóa thông tin login
        {
            userControl_login.txt_Pass.ResetText();
            userControl_login.txt_User.ResetText();
        }

        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //lưu thông tin đăng nhập
            Properties.Settings.Default.Password = userControl_login.password;
            Properties.Settings.Default.Username = userControl_login.username;
            Properties.Settings.Default.Save();

            //
            Application.Exit();
        }
    }
}
