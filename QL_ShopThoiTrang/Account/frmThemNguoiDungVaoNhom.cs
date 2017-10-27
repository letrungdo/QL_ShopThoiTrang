using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ShopThoiTrang.Account
{
    public partial class frmThemNguoiDungVaoNhom : Form
    {
        public frmThemNguoiDungVaoNhom()
        {
            InitializeComponent();
        }

        private void qL_NV_NhomNguoiDungDKBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NV_NhomNguoiDungDKBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_QL_NguoiDung);

        }
        
        private void frmThemNguoiDungVaoNhom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_QL_NguoiDung.NhanVien_Nhom_DK' table. You can move, or remove it, as needed.
            this.nhanVien_Nhom_DKTableAdapter.Fill_DK(this.dataSet_QL_NguoiDung.NhanVien_Nhom_DK);
            // TODO: This line of code loads data into the 'dataSet_QL_NguoiDung.QL_NhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NhomNguoiDungTableAdapter.Fill(this.dataSet_QL_NguoiDung.QL_NhomNguoiDung);
            loadDK();
        }

        private void qL_NhomNguoiDungComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDK();
        }

        void loadDK()
        {
            if(qL_NhomNguoiDungComboBox.SelectedValue !=null)
            try
            {
                this.qL_NV_NhomNguoiDungDKTableAdapter.Fill_DK(this.dataSet_QL_NguoiDung.QL_NV_NhomNguoiDungDK, qL_NhomNguoiDungComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.nhanVien_Nhom_DKTableAdapter.Fill_DK(this.dataSet_QL_NguoiDung.NhanVien_Nhom_DK);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string username = nhanVien_Nhom_DKDataGridView.CurrentRow.Cells[0].Value.ToString();
            string maNhom = qL_NhomNguoiDungComboBox.SelectedValue.ToString();
            //kiểm tra trùng khóa chính
            int? kq = qL_NV_NhomNguoiDungDKTableAdapter.kiemTraTonTai(username, maNhom).Value;
            if (kq == null || kq == 0)
            {
                //// lưu và hiển thị thông tin qua phải 
                qL_NV_NhomNguoiDungDKTableAdapter.Them(username, maNhom);

                loadDK();//load lại
            }
            else
            {
                MessageBox.Show("Đã tồn tại");
            }
            
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(qL_NV_NhomNguoiDungDKDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn người dùng");
                return;
            }

            string username = qL_NV_NhomNguoiDungDKDataGridView.CurrentRow.Cells[0].Value.ToString();
            string maNhom = qL_NV_NhomNguoiDungDKDataGridView.CurrentRow.Cells[1].Value.ToString();

            qL_NV_NhomNguoiDungDKTableAdapter.Xoa(username, maNhom);
            loadDK();//load lại
        }
    }
}
