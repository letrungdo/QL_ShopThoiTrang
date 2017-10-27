using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGIC;
using DATA;

namespace QL_ShopThoiTrang.DanhMuc
{
    public partial class frmLoaiMatHang : Form
    {
        ConnectDB da = new ConnectDB();

        public frmLoaiMatHang()
        {
            InitializeComponent();
        }

        private void frmLoaiMatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_MatHang.LoaiMatHang' table. You can move, or remove it, as needed.
            this.loaiMatHangTableAdapter.Fill(this.dataSet_MatHang.LoaiMatHang);

            if(this.Text == "SỬA LOẠI MẶT HÀNG")
            {
                txtMa.ReadOnly = true;
            }
            else//Thêm
            {
                
            }

        }
        
        public void getData(string ten, string ma, Image img)//tuyền dữ liệu
        {
            txtTen.Text = ten;
            txtMa.Text = ma;
            pictureBoxHinh.Image = img;
        }

        public event EventHandler Luu_Click;//gọi sự kiện load lại form dưới khi lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            Image_Converter image = new Image_Converter();
            if (this.Text == "SỬA LOẠI MẶT HÀNG")
            {
                loaiMatHangTableAdapter.Sua(txtTen.Text, image.getByteImage(pictureBoxHinh), txtMa.Text);
                if (this.Luu_Click != null)
                    Luu_Click(sender, e);
                MessageBox.Show("Sửa thành công!");
            }
            else//Thêm
            {
                //kiểm tra khóa
                if (loaiMatHangTableAdapter.KT_KhoaChinh(txtMa.Text) == 1)
                {
                    MessageBox.Show("Mã loại đã có!");
                    return;
                }

                loaiMatHangTableAdapter.Them(txtMa.Text, txtTen.Text, image.getByteImage(pictureBoxHinh));
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            this.Text = "THÊM LOẠI MẶT HÀNG";
            resetTxt();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            loaiMatHangTableAdapter.Xoa(txtMa.Text);

            resetTxt();

            MessageBox.Show("Xóa thành công!");
        }
        void resetTxt()
        {
            txtMa.ResetText();
            txtTen.ResetText();
        }
    }
}
