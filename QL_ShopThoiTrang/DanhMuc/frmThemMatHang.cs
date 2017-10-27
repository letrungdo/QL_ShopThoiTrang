using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGIC;

namespace QL_ShopThoiTrang.DanhMuc
{
    public partial class frmThemMatHang : Form
    {
        public frmThemMatHang()
        {
            InitializeComponent();
        }
        string MaMH, MaLoai, Dvt, MaNH;
        public void getMaMatHang(string maMH, string maLoai, string dvt, string maNH)//get mã mặt hàng từ gridview khi sửa
        {
            MaMH = maMH;
            MaLoai = maLoai;
            Dvt = dvt;
            MaNH = maNH;
        }

        private void frmThemMatHang_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dataSet_MatHang.LoaiMatHang' table. You can move, or remove it, as needed.
            this.loaiMatHangTableAdapter.Fill(this.dataSet_MatHang.LoaiMatHang);
            // TODO: This line of code loads data into the 'dataSet_MatHang.DM_NhanHieu' table. You can move, or remove it, as needed.
            this.dM_NhanHieuTableAdapter.Fill(this.dataSet_MatHang.DM_NhanHieu);
            // TODO: This line of code loads data into the 'dataSet_MatHang.DonViTinh' table. You can move, or remove it, as needed.
            this.donViTinhTableAdapter.Fill(this.dataSet_MatHang.DonViTinh);
            if (this.Text == "SỬA MẶT HÀNG")
            {
                this.matHangTableAdapter.FillBy_MaMH(this.dataSet_MatHang.MatHang, MaMH);

                loaiMatHangComboBox.SelectedValue = MaLoai;

                dM_NhanHieuComboBox.SelectedValue = MaNH;
                donViTinhComboBox.SelectedValue = Dvt;

                loaiMatHangComboBox.Enabled = false;
            }
            else
            {
                loaiMatHangComboBox.Text = "";
                dM_NhanHieuComboBox.Text = "";
                donViTinhComboBox.Text = "";
            }

        }
        public event EventHandler Luu_Click;//gọi sự kiện load lại form dưới khi lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (this.Text == "THÊM MẶT HÀNG")
            {

                TaoMaTuDong taoMaTuDong = new TaoMaTuDong();
                //tạo mã mặt hàng tự động
                string maMatHang = taoMaTuDong.taoMa_MatHang(loaiMatHangComboBox.SelectedValue.ToString());

                //kiểm tra trùng
                if (matHangTableAdapter.KiemTraKhoaChinh(maMatHang) == 1)
                {
                    MessageBox.Show("Đã tồn tại");
                    return;
                }

                matHangTableAdapter.Them(maMatHang, dM_NhanHieuComboBox.SelectedValue.ToString(), loaiMatHangComboBox.SelectedValue.ToString(),
                    donViTinhComboBox.SelectedValue.ToString(), tenMHTextEdit.Text,
                    (double)giaVonSpinEdit.Value, (double)giaBanSiSpinEdit.Value, (double)giaBanLeSpinEdit.Value,
                    xuatXuTextEdit.Text, chatLieuTextEdit.Text,
                    danhChoTextEdit.Text, kichThuocTextEdit.Text, moTaTextEdit.Text);
                if (this.Luu_Click != null)
                    Luu_Click(sender, e);
                MessageBox.Show("Thêm thành công!");
            }
            else//Lưu
            {
                matHangTableAdapter.Sua(dM_NhanHieuComboBox.SelectedValue.ToString(), donViTinhComboBox.SelectedValue.ToString(),
                    tenMHTextEdit.Text,(double)giaVonSpinEdit.Value, (double)giaBanSiSpinEdit.Value, (double)giaBanLeSpinEdit.Value,
                   xuatXuTextEdit.Text, chatLieuTextEdit.Text, danhChoTextEdit.Text, kichThuocTextEdit.Text, moTaTextEdit.Text, MaMH);

                if (this.Luu_Click != null)
                    Luu_Click(sender, e);
                MessageBox.Show("Lưu thành công!");
            }

                
        }
    }
}
