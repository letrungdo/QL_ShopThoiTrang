using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_ShopThoiTrang.Properties;
using System.Data.Sql;
using System.Data.SqlClient;
using LOGIC;
using System.Configuration;
using System.IO;

namespace QL_ShopThoiTrang
{
    public partial class frm_Config : Form
    {
        public frm_Config()
        {
            InitializeComponent();
        }
       
        private SqlConnection conn;

        private void frm_Config_Load(object sender, EventArgs e)
        {
            
            //load saved
            cbo_ServerName.Text = Settings.Default.serverName;
            cbo_DbName.Text = Settings.Default.dbName;

            //init auth
            cbo_Auth.Items.Add("Windows Authentication");
            cbo_Auth.Items.Add("SQL Server Authentication");
            cbo_Auth.SelectedIndex = 1;

            //load user, pass saved
            txt_User.Text = Settings.Default.users;
            txt_Pass.Text = Settings.Default.pass;
            if (txt_User.Text != string.Empty)
                chk_rememberPass.Checked = true;
        }

        private void cbo_ServerName_DropDown(object sender, EventArgs e)
        {
            //get server name
            DataTable table = SqlDataSourceEnumerator.Instance.GetDataSources();

            foreach (DataRow server in table.Rows)
            {
                cbo_ServerName.Items.Add(string.Format(@"{0}\{1}",
                                              server[table.Columns["ServerName"]],
                                              server[table.Columns["InstanceName"]]));
            }
        }
        

        private void cbo_DbName_DropDown(object sender, EventArgs e)
        {
            if (cbo_ServerName.Text == "")
            {
                MessageBox.Show("Chưa chọn tên máy chủ");
                return;
            }

            string winAuth = @"Data Source=" + cbo_ServerName.Text + ";Initial Catalog=master;Integrated Security=True";
            string sqlAuth = @"Data Source=" + cbo_ServerName.Text + ";Initial Catalog=master; User ID =" + txt_User.Text + "; Password = " + txt_Pass.Text + "";
            //kiểm tra kiểu xác thực


            if (cbo_Auth.SelectedIndex == 0)
            {
                conn = new SqlConnection(winAuth);

                try
                {
                    if (conn != null && conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        
                    }
                }
                catch
                {
                    MessageBox.Show("Cấu hình máy chủ không đúng");
                    return;
                }
            }
            else
            {
                //check null user, pass
                if (txt_User.Text == "" || txt_Pass.Text == "")
                {
                    MessageBox.Show("Chưa nhập user hoặc pass");
                    return;
                }

                conn = new SqlConnection(sqlAuth);

                try
                {
                    if (conn != null && conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                }
                catch
                {
                    MessageBox.Show("Cấu hình máy chủ không đúng");
                    return;
                }
            }
            //----------------
            try
            {
                SqlDataAdapter daDb_Name = new SqlDataAdapter("SELECT name FROM sys.databases", conn);
                DataSet dsDb_Name = new DataSet();
                daDb_Name.Fill(dsDb_Name);
                cbo_DbName.DataSource = dsDb_Name.Tables[0];
                cbo_DbName.DisplayMember = "name";
                cbo_DbName.ValueMember = "name";

            }
            catch 
            {
                return;
            }
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {

            string final = @"Data Source=" + Settings.Default.serverName + ";Initial Catalog=" + Settings.Default.dbName + "; User ID =" + Settings.Default.users + "; Password = " + Settings.Default.pass + "";

            
            //Cập nhật connectString trong file QL_ShopThoiTrang.exe.Config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["QL_ShopThoiTrang.Properties.Settings.QL_ShopThoiTrangConnectionString"].ConnectionString = final;
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");


            //Cập nhật connectString trong file DATA.exe.Config
            Configuration config2 = ConfigurationManager.OpenExeConfiguration(Path.Combine("DATA.exe"));//"DATA.exe"
            config2.ConnectionStrings.ConnectionStrings["DATA.Properties.Settings.QL_ShopThoiTrangConnectionString"].ConnectionString = final;//
            config2.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");


            //
            Settings.Default.serverName = cbo_ServerName.Text;
            Settings.Default.users = txt_User.Text;
            Settings.Default.pass = txt_Pass.Text;
            Settings.Default.connectString = final;
            Settings.Default.Save();
            
            MessageBox.Show("Kết nối thành công!");

        }

        private void cbo_Auth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_Auth.SelectedIndex == 0)
            {
                txt_User.Enabled = false;
                txt_Pass.Enabled = false;
                chk_rememberPass.Enabled = false;
            }
            else
            {
                txt_User.Enabled = true;
                txt_Pass.Enabled = true;
                chk_rememberPass.Enabled = true;
            }
        }

        private void frm_Config_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Ghi nhớ tên đăng nhập và pass
            if (chk_rememberPass.Checked)
            {

                Settings.Default.users = txt_User.Text;
                Settings.Default.pass = txt_Pass.Text;
                Settings.Default.Save();
            }
            else
            {
                Settings.Default.users = "";
                Settings.Default.pass = "";
                Settings.Default.Save();
            }

            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                return;
            }

            MessageBox.Show("Cần khởi chạy lại chương trình để cập nhật chuỗi kết nối!");
            Application.Restart();
        }

        private void cbo_DbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //save db Name
            Settings.Default.dbName = cbo_DbName.Text;
            Settings.Default.Save();
        }

        private void frm_Config_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
