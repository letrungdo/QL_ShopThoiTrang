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

namespace QL_ShopThoiTrang.DanhMuc
{
    public partial class frmNhanHieu : Form
    {
        public frmNhanHieu()
        {
            InitializeComponent();
        }
       
        private void frmNhanHieu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_MatHang.DM_NhanHieu' table. You can move, or remove it, as needed.
            this.dM_NhanHieuTableAdapter.Fill(this.dataSet_MatHang.DM_NhanHieu);

        }
        string ma = "";
        public void getData(string ma, string ten, string note, Image img)//tuyền dữ liệu
        {
            this.ma = ma;
            txtTenNH.Text = ten;
            richTextBox_ghiChu.Text = note;
            pictureBoxHinh.Image = img;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public event EventHandler Luu_Click;//gọi sự kiện load lại form dưới khi lưu

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            Image_Converter image = new Image_Converter();
            if (this.Text == "SỬA NHÃN HIỆU")
            {
                dM_NhanHieuTableAdapter.Sua(ma, image.getByteImage(pictureBoxHinh), richTextBox_ghiChu.Text);
                
                if(this.Luu_Click != null)
                    Luu_Click(sender, e);

                MessageBox.Show("Sửa thành công!");
            }
            else//Thêm
            {
                //kiểm tra khóa
                if (dM_NhanHieuTableAdapter.KT_KhoaChinh(ma) == 1)
                {
                    MessageBox.Show("Mã nhãn hiệu đã có!");
                    return;
                }

                TaoMaTuDong taoMaTuDong = new TaoMaTuDong();
                //tạo mã ĐVT tự động
                string maNH = taoMaTuDong.taoMa_NhanHieu();

                dM_NhanHieuTableAdapter.Them(maNH, txtTenNH.Text, image.getByteImage(pictureBoxHinh), richTextBox_ghiChu.Text);

                if (this.Luu_Click != null)
                    Luu_Click(sender, e);

                MessageBox.Show("Thêm thành công!");
            }

            
        }

        private void pictureBoxHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialogImage img = new OpenFileDialogImage();
            pictureBoxHinh.Image = img.getHinh(openFileDialog1);
        }
    }
}
