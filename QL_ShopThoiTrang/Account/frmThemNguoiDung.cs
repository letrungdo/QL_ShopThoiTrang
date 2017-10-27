using System;
using System.Windows.Forms;
using LOGIC;

namespace QL_ShopThoiTrang.Account
{
    public partial class frmThemNguoiDung : Form
    {
        PasswordEncrypt pass = new PasswordEncrypt();
        public frmThemNguoiDung()
        {
            InitializeComponent();
        }

        private void Lưu_Click(object sender, EventArgs e)
        {

            if (nhanVienTableAdapter.kiemTraKhoaChinh(usernameTextBox.Text) != 0)
            {
                MessageBox.Show("Người dùng đã tồn tại");

                //thêm cập nhật
                //nhanVienTableAdapter.CapNhat(..........)

                return;
            }
            
            string maHoaMatKhau = pass.Encrypt(passwordTextBox.Text, "LeTrungDo");

            nhanVienTableAdapter.ThemNhanVien(usernameTextBox.Text, maHoaMatKhau, tenNVTextBox.Text,
                dienThoaiTextBox.Text, diaChiTextBox.Text, gioiTinhTextBox.Text, ngayVaoLamDateTimePicker.Value,
                ngaySinhDateTimePicker.Value, queQuanTextBox.Text, soCMNDTextBox.Text);
            MessageBox.Show("Thành công");
            
            //-----------------------------------------------------------------------------------------------

            
        }

        

        private void frmThemNguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_QL_NguoiDung.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dataSet_QL_NguoiDung.NhanVien);

        }
    }
}
