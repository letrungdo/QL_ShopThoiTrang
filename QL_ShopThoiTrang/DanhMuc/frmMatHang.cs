using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using LOGIC;
using DATA;
using System.Data.SqlClient;

namespace QL_ShopThoiTrang.DanhMuc
{
    public partial class frmMatHang : Form
    {
        ConnectDB da = new ConnectDB();
        public frmMatHang()
        {
            InitializeComponent();

            //màu sắc gridview
            matHang_AllDataGridView.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            matHang_AllDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
            
        }



        public void frmMatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_MatHang.MatHang' table. You can move, or remove it, as needed.
            this.matHangTableAdapter.Fill(this.dataSet_MatHang.MatHang);
            // TODO: This line of code loads data into the 'dataSet_MatHang.MatHang_All' table. You can move, or remove it, as needed.
            this.matHang_AllTableAdapter.Fill_DK(this.dataSet_MatHang.MatHang_All);
            // TODO: This line of code loads data into the 'dataSet_MatHang.DM_NhanHieu' table. You can move, or remove it, as needed.
            this.dM_NhanHieuTableAdapter.Fill(this.dataSet_MatHang.DM_NhanHieu);
            // TODO: This line of code loads data into the 'dataSet_MatHang.DonViTinh' table. You can move, or remove it, as needed.
            this.donViTinhTableAdapter.Fill(this.dataSet_MatHang.DonViTinh);
            
            // TODO: This line of code loads data into the 'dataSet_MatHang.LoaiMatHang' table. You can move, or remove it, as needed.
            this.loaiMatHangTableAdapter.Fill(this.dataSet_MatHang.LoaiMatHang);
            
            treeView1.ImageList = imageList1;//
            xl.loadTreeView(treeView1, dataSet_MatHang, "LoaiMatHang", "MaLoaiMH", "TenLoaiMH", "HinhAnh", imageList1);
        }
        LOGIC.DM_MatHang.HandleMatHang xl = new LOGIC.DM_MatHang.HandleMatHang();
        
        //-----------------------------------------
        void loadLoaiMatHang(object sender, EventArgs e)//load loại mặt hàng
        {
            frmMatHang_Load(sender, e);
            xl.loadTreeView(treeView1, dataSet_MatHang, "LoaiMatHang", "MaLoaiMH", "TenLoaiMH", "HinhAnh", imageList1);
        }
        void loadDonViTinh(object sender, EventArgs e)
        {
            frmMatHang_Load(sender, e);
            xl.loadTreeView(treeView1, dataSet_MatHang, "DonViTinh", "MaDVT", "TenDVT", "HinhAnh", imageList1);
        }
        void loadNhanHieu(object sender, EventArgs e)
        {
            frmMatHang_Load(sender, e);
            xl.loadTreeView(treeView1, dataSet_MatHang, "DM_NhanHieu", "MaNH", "TenNH", "HinhAnh", imageList1);
        }
        //-------------------------------------------
        private void them_toolStripButton_Click(object sender, EventArgs e)
        {
            if (xtraTabPage_Left.Text == "Loại mặt hàng")
            {
                frmLoaiMatHang frm = new frmLoaiMatHang();
                frm.Text = "THÊM LOẠI MẶT HÀNG";
                frm.Luu_Click += new EventHandler(loadLoaiMatHang);
                frm.ShowDialog();
            }
            else if(xtraTabPage_Left.Text == "Đơn vị tính")
            {
                frmDonViTinh frm = new frmDonViTinh();
                frm.Text = "THÊM ĐƠN VỊ TÍNH";
                frm.Luu_Click += new EventHandler(loadDonViTinh);
                frm.ShowDialog();
            }
            else
            {
                frmNhanHieu frm = new frmNhanHieu();
                frm.Text = "THÊM NHÃN HIỆU";
                frm.Luu_Click += new EventHandler(loadNhanHieu);
                frm.ShowDialog();
            }
        }

        private void loạiMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadLoaiMatHang(sender, e);
            xtraTabPage_Left.Text = "Loại mặt hàng";
        }

        private void đơnVịTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadDonViTinh(sender, e);
            xtraTabPage_Left.Text = "Đơn vị tính";
        }

        private void nhãnHiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadNhanHieu(sender, e);
            xtraTabPage_Left.Text = "Nhãn hiệu";
        }

        private void Sua_toolStripButton_Click(object sender, EventArgs e)
        {
            if (xtraTabPage_Left.Text == "Loại mặt hàng")
            {
                frmLoaiMatHang frm = new frmLoaiMatHang();
                //get hình
                byte[] img = null;
                try
                {
                    foreach (DataRow row in dataSet_MatHang.Tables["LoaiMatHang"].Rows)
                    {
                        if (row["MaLoaiMH"].ToString() == treeView1.SelectedNode.Name)
                            img = (byte[])row["HinhAnh"];
                    }
                }
                catch
                {
                    //chưa set hình
                }
                Image_Converter toImage = new Image_Converter();
                

                frm.getData(treeView1.SelectedNode.Text, treeView1.SelectedNode.Name, toImage.loadImageFromDB(img));//truyền dữ liệu
                frm.Text = "SỬA LOẠI MẶT HÀNG";
                frm.Luu_Click += new EventHandler(loadLoaiMatHang);
                frm.ShowDialog();
            }
            else if (xtraTabPage_Left.Text == "Đơn vị tính")
            {
                frmDonViTinh frm = new frmDonViTinh();
                //get hình
                byte[] img = null;
                try
                {
                    foreach (DataRow row in dataSet_MatHang.Tables["DonViTinh"].Rows)
                    {
                        if (row["MaDVT"].ToString() == treeView1.SelectedNode.Name)
                            img = (byte[])row["HinhAnh"];
                    }
                }
                catch
                {
                    //chưa set hình
                }
                Image_Converter toImage = new Image_Converter();

                string ghiChu = "";
                try
                {
                    da.Connect();
                    string ghiChuDVT = "select ghichu from DonViTinh where madvt = '" + treeView1.SelectedNode.Name + "'";
                    SqlDataReader dr = da.ExecuteReader(ghiChuDVT);

                    if (dr.Read())
                    {
                        ghiChu = dr["ghichu"].ToString();
                    }
                    dr.Close();
                    da.Disconnet();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                frm.getData(treeView1.SelectedNode.Name, treeView1.SelectedNode.Text, ghiChu, toImage.loadImageFromDB(img));//truyền dữ liệu
                frm.Luu_Click += new EventHandler(loadDonViTinh);
                frm.Text = "SỬA ĐƠN VỊ TÍNH";
                frm.ShowDialog();
            }
            else
            {
                frmNhanHieu frm = new frmNhanHieu();
                //get hình
                byte[] img = null;
                try
                {
                    foreach (DataRow row in dataSet_MatHang.Tables["dm_nhanhieu"].Rows)
                    {
                        if (row["manh"].ToString() == treeView1.SelectedNode.Name)
                            img = (byte[])row["HinhAnh"];
                    }
                }
                catch
                {
                    //chưa set hình
                }
                Image_Converter toImage = new Image_Converter();
                string ghiChu = "";
                try
                {
                    da.Connect();
                    string ghiChuDVT = "select ghichu from dm_nhanhieu where manh = '" + treeView1.SelectedNode.Name + "'";
                    SqlDataReader dr = da.ExecuteReader(ghiChuDVT);

                    if (dr.Read())
                    {
                        ghiChu = dr["ghichu"].ToString();
                    }
                    dr.Close();
                    da.Disconnet();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                frm.getData(treeView1.SelectedNode.Name, treeView1.SelectedNode.Text, ghiChu, toImage.loadImageFromDB(img));//truyền dữ liệu
                frm.Luu_Click += new EventHandler(loadNhanHieu);
                frm.Text = "SỬA NHÃN HIỆU";
                frm.ShowDialog();
            }
        }

        

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (xtraTabPage_Left.Text == "Loại mặt hàng")
            {
                this.matHang_AllTableAdapter.FillBy_MaLoaiMH(this.dataSet_MatHang.MatHang_All, e.Node.Name);//lọc bởi mã loại mặt hàng
                
            }
            else if (xtraTabPage_Left.Text == "Đơn vị tính")
            {
                this.matHang_AllTableAdapter.FillBy_DVT(this.dataSet_MatHang.MatHang_All, e.Node.Name);//lọc bởi DVT
            }
            else
            {
                this.matHang_AllTableAdapter.FillBy_MaNH(this.dataSet_MatHang.MatHang_All, e.Node.Name);//lọc bởi mã nhãn hiệu
            }
        }

        private void lamMoi_toolStripButton_Click(object sender, EventArgs e)
        {
            if (xtraTabPage_Left.Text == "Loại mặt hàng")
            {
                loadLoaiMatHang(sender, e);

            }
            else if (xtraTabPage_Left.Text == "Đơn vị tính")
            {
                loadDonViTinh(sender, e);
            }
            else
            {
                loadNhanHieu(sender, e);
            }
            
        }

        private void txtLoc_TextChanged(object sender, EventArgs e)
        {
            this.matHang_AllTableAdapter.FillBy_All(this.dataSet_MatHang.MatHang_All, txtLoc.Text);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            matHang_AllDataGridView.Rows[0].DefaultCellStyle.BackColor = Color.Green;
                //RowsDefaultCellStyle.BackColor = Color.Green;
            //AlternatingRowsDefaultCellStyle.BackColor = Color.Green;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemMatHang f = new frmThemMatHang();
            f.Text = "THÊM MẶT HÀNG";
            f.Luu_Click += new EventHandler(frmMatHang_Load);
            f.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemMatHang f = new frmThemMatHang();
            f.Text = "SỬA MẶT HÀNG";
            try
            {
                string maMH = matHang_AllDataGridView.CurrentRow.Cells["MAMH"].Value.ToString();
                string maLoai = matHang_AllDataGridView.CurrentRow.Cells["MaLoaiMH"].Value.ToString();
                string dvt = matHang_AllDataGridView.CurrentRow.Cells["MaDVT"].Value.ToString();
                string maNH = matHang_AllDataGridView.CurrentRow.Cells["maNH"].Value.ToString();
                f.getMaMatHang(maMH, maLoai, dvt, maNH);//truyền mã mặt hàng khi sửa
            }
            catch
            {
                MessageBox.Show("Chưa chọn mặt hàng");
                return;
            }

            f.Luu_Click += new EventHandler(frmMatHang_Load);
            f.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (matHang_AllDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Không có mặt hàng nào để xóa");
                return;
            }
            
            string maMH = matHang_AllDataGridView.CurrentRow.Cells["MAMH"].Value.ToString();
                
            matHangTableAdapter.Xoa(maMH);

            this.matHang_AllTableAdapter.Fill_DK(this.dataSet_MatHang.MatHang_All);//load lại

            MessageBox.Show("Xóa thành công");
        }

        private void btnRac_Click(object sender, EventArgs e)
        {
            if (matHang_AllTableAdapter.xemXoa() == 0)
                MessageBox.Show("Không có mặt hàng nào bị xóa");
            matHang_AllTableAdapter.FillBy_DaXoa(this.dataSet_MatHang.MatHang_All);
        }
    }
}
