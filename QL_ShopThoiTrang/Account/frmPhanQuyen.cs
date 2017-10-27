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
    public partial class frmPhanQuyen : Form
    {
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void qL_NhomNguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NhomNguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_QL_NguoiDung);

        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_QL_NguoiDung.QL_PhanQuyen' table. You can move, or remove it, as needed.
            this.qL_PhanQuyenTableAdapter.Fill(this.dataSet_QL_NguoiDung.QL_PhanQuyen);
            // TODO: This line of code loads data into the 'dataSet_QL_NguoiDung.QL_NhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NhomNguoiDungTableAdapter.Fill(this.dataSet_QL_NguoiDung.QL_NhomNguoiDung);

        }

        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maNhom = qL_NhomNguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString();

            for(int i = 0; i < phanQuyen_DKDataGridView.Rows.Count; i++)
            {
                string maMH = phanQuyen_DKDataGridView.Rows[i].Cells[0].Value.ToString();
                bool coQuyen = false;
                try
                {
                    coQuyen = bool.Parse(phanQuyen_DKDataGridView.Rows[i].Cells[2].Value.ToString());
                }
                catch
                {
                    //trường hợp null
                    coQuyen = false;
                }
                int? kq = qL_PhanQuyenTableAdapter.kiemTraKhoaChinh(maNhom, maMH);
                if(kq == null || kq == 0)
                {
                    //thêm
                    qL_PhanQuyenTableAdapter.Them(maNhom, maMH, coQuyen);
                }
                else
                {
                    if(qL_PhanQuyenTableAdapter.kiemTraTonTai(maNhom, maMH, false) == 1 && coQuyen == true)
                        qL_PhanQuyenTableAdapter.CapNhat(coQuyen, maNhom, maMH);

                    else if (qL_PhanQuyenTableAdapter.kiemTraTonTai(maNhom, maMH, true) == 1 && coQuyen == false)
                        qL_PhanQuyenTableAdapter.CapNhat(coQuyen, maNhom, maMH);
                    
                }
            }

            //this.Validate();
            //this.qL_NhomNguoiDungBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.dataSet_QL_NguoiDung);
        }

        private void qL_NhomNguoiDungDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.phanQuyen_DKTableAdapter.Fill_DK(this.dataSet_QL_NguoiDung.PhanQuyen_DK, qL_NhomNguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString());


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
