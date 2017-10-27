using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTab;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using LOGIC;
using DATA;
using System.Configuration;
using System.IO;

namespace QL_ShopThoiTrang
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
            //
            xtraTabControl_Main.LookAndFeel.UseDefaultLookAndFeel = false;
            xtraTabControl_Main.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logout == 1)//đăng xuất sẽ 0 thông báo
                return;

            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                return;
            }
            if (MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
            else Application.Exit();
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Account.frm_QL_NhanVien frmNhanVien = new Account.frm_QL_NhanVien();
            //frmNhanVien.Show();
        }


        public static string tenDangNhap = string.Empty;//
        //---------------------------------------------------------------------
        private void frm_Main_Load(object sender, EventArgs e)
        {
            try
            {
                xtraTabControl_Main.BackgroundImage = Image.FromFile(Properties.Settings.Default.hinhNen);
            }
            catch (Exception)
            {
                //chưa chọn ảnh nền, hoặc đã bị xóa
            }


            // TODO: This line of code loads data into the 'dataSet_QL_NguoiDung.QL_PhanQuyen' table. You can move, or remove it, as needed.
            this.qL_PhanQuyenTableAdapter.Fill(this.dataSet_QL_NguoiDung.QL_PhanQuyen);
            // TODO: This line of code loads data into the 'dataSet_QL_NguoiDung.QL_NV_NhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NV_NhomNguoiDungTableAdapter.Fill(this.dataSet_QL_NguoiDung.QL_NV_NhomNguoiDung);
            

            tenDangNhap = this.Tag.ToString();//Lấy tên đăng nhập
            barHeader_tenDangNhap.Caption = tenDangNhap;

            //Tự động ẩn group rỗng
            ribbonControl_Main.AutoHideEmptyItems = true;


            try
            {

                //phân quyền đăng nhập//==========================================================================
                DataTable tbQL_NV_NhomNguoiDung = dataSet_QL_NguoiDung.Tables["QL_NV_NhomNguoiDung"];

                //Dùng LINQ lấy mã nhóm của user
                IEnumerable<DataRow> layMaNhom =
                    from order in tbQL_NV_NhomNguoiDung.AsEnumerable()
                    where order.Field<string>("Username") == tenDangNhap
                    select order;
                DataTable tbNhom = layMaNhom.CopyToDataTable<DataRow>();
                //------------------------------

                List<string> nhomND = new List<string>();
                foreach (DataRow row in tbNhom.Rows)
                {
                    nhomND.Add(row["MaNhom"].ToString());
                }


                //get quyền user trên màn hình
                DataTable tbQL_PhanQuyen = dataSet_QL_NguoiDung.Tables["QL_PhanQuyen"];
                foreach (string maNhom in nhomND)
                {
                    //Dùng LINQ 
                    IEnumerable<DataRow> layTenManHinh =
                        from order in tbQL_PhanQuyen.AsEnumerable()
                        where order.Field<string>("MaNhom") == maNhom
                        select order;
                    DataTable tbQuyen = layTenManHinh.CopyToDataTable<DataRow>();

                    foreach (DataRow mh in tbQuyen.Rows)
                    {
                        FindMenuPhanQuyen(ribbonControl_Main, mh[1].ToString(), Convert.ToBoolean(mh[2].ToString()));//Lấy mã màn hình so với Tag của Item
                    }
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //Người dùng chưa được phân quyền
            }
            //-----------------------------------------------------------------------------------------------------------------------------
        }
        
        private void FindMenuPhanQuyen(RibbonControl ribbon, string name, bool pEnable)
        {
            foreach (BarItem item in ribbon.Items)
            {
                
                if (string.Equals(name, item.Tag))
                {
                    item.Enabled = pEnable;
                    if (pEnable)
                    {
                        item.Visibility = BarItemVisibility.Always;
                        item.Tag = "";//k0 duyệt lại để xét quyền nữa
                    }
                    else item.Visibility = BarItemVisibility.Never;
                }
                
            }
        }
        

        //--------------------------------------------------------------------------
        public void TabCreating(XtraTabControl TabControl, string Text, Form Form)
        {
            int Index = KiemTraTonTai(TabControl, Text);
            if (Index >= 0)
            {
                TabControl.SelectedTabPage = TabControl.TabPages[Index];
                TabControl.SelectedTabPage.Text = Text;

            }
            else
            {
                XtraTabPage xtraTabPage = new XtraTabPage { Text = Text };
                TabControl.TabPages.Add(xtraTabPage);
                TabControl.SelectedTabPage = xtraTabPage;

                Form.TopLevel = false;
                Form.Parent = xtraTabPage;
                //  Form.MdiParent = this;
                Form.Show();
                Form.Dock = DockStyle.Fill;
            }
        }
        static int KiemTraTonTai(XtraTabControl TabControlName, string TabName)
        {
            int temp = -1;
            for (int i = 0; i < TabControlName.TabPages.Count; i++)
            {
                if (TabControlName.TabPages[i].Text == TabName)
                {
                    temp = i;
                    break;
                }
            }
            return temp;
        }

        private void xtraTabControl_Main_CloseButtonClick(object sender, EventArgs e)
        {
            xtraTabControl_Main.TabPages.RemoveAt(xtraTabControl_Main.SelectedTabPageIndex);//đóng tab đang chọn
        }


        private void barButton_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if( XtraMessageBox.Show("Xác nhận thoát khỏi chương trình?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void barButton_DoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Account.frmDoiMatKhau f = new Account.frmDoiMatKhau();
            f.ShowDialog();
        }
        

        int logout = 0;
        private void barButton_Logout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logout = 1;//kiểm tra đăng xuất
            this.Hide();
            
            frm_Login f = new frm_Login();
            f.Show();
            f.getLogout(sender, e);
        }

        private void barButton_ThemNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Account.frmThemNguoiDung f = new Account.frmThemNguoiDung();
            f.FormBorderStyle = FormBorderStyle.None;
            TabCreating(xtraTabControl_Main, "Thêm người dùng", f);
        }

        private void barButton_ThemNguoiDungVaoNhom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Account.frmThemNguoiDungVaoNhom f = new Account.frmThemNguoiDungVaoNhom();
            f.FormBorderStyle = FormBorderStyle.None;
            TabCreating(xtraTabControl_Main, "Thêm người dùng vào nhóm", f);
        }

        private void barButton_PhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Account.frmPhanQuyen f = new Account.frmPhanQuyen();
            f.FormBorderStyle = FormBorderStyle.None;
            TabCreating(xtraTabControl_Main, "Phân quyền", f);
        }

        private void barButton_HoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QL_BanHang.frmHoaDon_BanHang frmHoaDon = new QL_BanHang.frmHoaDon_BanHang();
            frmHoaDon.FormBorderStyle = FormBorderStyle.None;
            frmHoaDon.tenNV = tenDangNhap;
            TabCreating(xtraTabControl_Main, "Hóa đơn bán hàng", frmHoaDon);
        }

        private void barButton_QLBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (logout == 1)//đăng xuất sẽ 0 đóng hoàn toàn app
                return;
            Application.Exit();//stop all form
        }

        private void barButtonMatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.frmMatHang frm = new DanhMuc.frmMatHang();
            frm.FormBorderStyle = FormBorderStyle.None;
            TabCreating(xtraTabControl_Main, "Danh mục mặt hàng", frm);
        }

        private void nhaCc_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.frmNhaCungCap frm = new DanhMuc.frmNhaCungCap();
            frm.FormBorderStyle = FormBorderStyle.None;
            TabCreating(xtraTabControl_Main, "Danh mục nhà cung cấp", frm);
        }

        private void phucHoi_barButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Sys.frmRestoreDB f = new Sys.frmRestoreDB();
            f.ShowDialog();
        }

        private void saoLuu_barButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Sys.frmBackupDB f = new Sys.frmBackupDB();            
            f.ShowDialog();
        }

        private void xoaDuLieu_barButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Sys.frmEraseDB f = new Sys.frmEraseDB();
            f.ShowDialog();
        }

        private void thayHinhNen_barButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.hinhNen = openFileDialog1.FileName;
                Properties.Settings.Default.Save();
                xtraTabControl_Main.BackgroundImage = Image.FromFile(Properties.Settings.Default.hinhNen);
            }
        }

        private void btnTonKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            QL_KiemKe.frmTonKho f = new QL_KiemKe.frmTonKho();
            f.FormBorderStyle = FormBorderStyle.None;
            TabCreating(xtraTabControl_Main, "TỒN KHO", f);
        }
    }
}
