using DATA;
using LOGIC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ShopThoiTrang.QL_BanHang
{
    public partial class frmHoaDon_BanHang : Form
    {
        public frmHoaDon_BanHang()
        {
            InitializeComponent();
           
            
        }
        public string tenNV = string.Empty;

        private void frmHoaDon_BanHang_Load(object sender, EventArgs e)
        {
            BanHang_XuLy bhxl = new BanHang_XuLy();
            txt_MaHD.Text = bhxl.layMaHoaDonMoi(0);
            ConnectDB cnn = new ConnectDB();
            cnn.Connect();
            string sql = "select TenNV from NhanVien where username = '" + tenNV +@"'";
            var ten = cnn.ExecuteScalar(sql);
            cnn.Disconnet();
            txt_tenNV.Text = ten.ToString();
        }
    }
}
