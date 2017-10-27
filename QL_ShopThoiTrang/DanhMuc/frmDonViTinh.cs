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
    public partial class frmDonViTinh : Form
    {
        public frmDonViTinh()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_MatHang.DonViTinh' table. You can move, or remove it, as needed.
            this.donViTinhTableAdapter.Fill(this.dataSet_MatHang.DonViTinh);

        }
        string ma = "";
        public void getData(string ma, string ten, string note, Image img)//tuyền dữ liệu
        {
            txtTenDVT.Text = ten;
            richTextBox_ghiChu.Text = note;
            pictureBoxHinh.Image = img;
            this.ma = ma;
        }

        public event EventHandler Luu_Click;//gọi sự kiện load lại form dưới khi lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            Image_Converter image = new Image_Converter();
            if (this.Text == "SỬA ĐƠN VỊ TÍNH")
            {
                donViTinhTableAdapter.Sua(txtTenDVT.Text, image.getByteImage(pictureBoxHinh), richTextBox_ghiChu.Text, ma);
                if (this.Luu_Click != null)
                    Luu_Click(sender, e);
                MessageBox.Show("Sửa thành công!");
            }
            else//Thêm
            {
                //kiểm tra khóa
                if (donViTinhTableAdapter.KT_KhoaChinh(ma) == 1)
                {
                    MessageBox.Show("Mã ĐVT đã có!");
                    return;
                }

                TaoMaTuDong taoMaTuDong = new TaoMaTuDong();
                //tạo mã ĐVT tự động
                string maDVT = taoMaTuDong.taoMa_DVT();

                donViTinhTableAdapter.Them(maDVT, txtTenDVT.Text, image.getByteImage(pictureBoxHinh),richTextBox_ghiChu.Text);
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
