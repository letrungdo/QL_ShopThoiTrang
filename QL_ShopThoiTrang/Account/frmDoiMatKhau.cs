using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using DATA;
using LOGIC;

namespace QL_ShopThoiTrang.Account
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        
        ConnectDB da = new ConnectDB();//kết nối db
        PasswordEncrypt pass = new PasswordEncrypt();


        //public string getMD5Password(string pass)//mã hóa mật khẩu sang MD5
        //{
        //    string md5Pass = "";
        //    byte[] mang = System.Text.Encoding.UTF8.GetBytes(pass);

        //    MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        //    mang = md5.ComputeHash(mang);

        //    foreach (byte b in mang)
        //    {
        //        md5Pass += b.ToString("x2");//Nếu là "X2" thì kết quả sẽ tự chuyển sang ký tự in Hoa
        //    }

        //    return md5Pass;
        //}
        
        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            da.Connect();
            string selectMK = "select Password from NhanVien where Username='" + frm_Main.tenDangNhap + "'";
            SqlDataReader dr = da.ExecuteReader(selectMK);
            if (dr.Read())
            {
                
                if (pass.Encrypt(txtMKC.Text,"LeTrungDo") == dr["Password"].ToString())
                {
                    if (txtMKM.Text == txtXacNhanMKM.Text)
                    {
                        dr.Close();
                        string updateMK = "update NhanVien set Password='" + pass.Encrypt(txtMKM.Text, "LeTrungDo") + "' WHERE Username='" + frm_Main.tenDangNhap + "'";
                        da.ExecuteNonQuery(updateMK);
                        MessageBox.Show("Cập nhật mật khẩu thành công");
                    }
                    else MessageBox.Show("Nhập mật khẩu mới không khớp");
                }
                else
                    MessageBox.Show("Sai mật khẩu cũ");
            }
            da.Disconnet();
        }
    }
}
