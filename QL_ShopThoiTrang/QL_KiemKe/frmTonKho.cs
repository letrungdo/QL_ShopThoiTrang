using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATA.LINQ_SQL;
using System.Data.Linq;
using LOGIC;

namespace QL_ShopThoiTrang.QL_KiemKe
{
    public partial class frmTonKho : Form
    {
        public frmTonKho()
        {
            InitializeComponent();
        }
        HangDataContext db = new HangDataContext();
        private void frmTonKho_Load(object sender, EventArgs e)
        {

            loadFull();
            loadGridView();

            loadTreeView();
        }

        void loadFull()
        {
            var tt = db.MatHangs
                .Join(db.LoaiMatHangs, a => a.MaLoaiMH, b => b.MaLoaiMH, (a, b) => new { a, b })
                .Join(db.DM_NhanHieus, c => c.a.MaNH, d => d.MaNH, (c, d) => new { c, d })
                .Join(db.DonViTinhs, h => h.c.a.MaDVT, f => f.MaDVT, (h, f) => new { h, f })
                .Select(x => new {
                    MaMH = x.h.c.a.MaMH,
                    TenMH = x.h.c.a.TenMH,
                    TenLoaiMH = x.h.c.b.TenLoaiMH,
                    TenNH = x.h.d.TenNH,
                    TenDVT = x.f.TenDVT,
                    TonKho = x.h.c.a.TonKho,
                    ChatLieu = x.h.c.a.ChatLieu,
                    XuatXu = x.h.c.a.XuatXu,
                    DanhCho = x.h.c.a.DanhCho,
                    GiaBanLe = x.h.c.a.GiaBanLe,
                    GiaBanSi = x.h.c.a.GiaBanSi,
                    GiaKM = x.h.c.a.GiaKM,
                    GiaVon = x.h.c.a.GiaVon,
                    KichThuoc = x.h.c.a.KichThuoc,
                    MoTa = x.h.c.a.MoTa
                });


            dataGridView1.DataSource = tt;
        }
        void loadTreeView()
        {
            treeView1.Nodes.Clear();
            treeView1.ImageList = imageList1;
            treeView1.Nodes.Add("All", "Tấc cả", 0, 0);
            foreach (var row in db.LoaiMatHangs)
            {
                
                try
                {
                    Image_Converter image = new Image_Converter();

                    //gán tên mã cho image và load img lên từ DB
                    imageList1.Images.Add(row.MaLoaiMH, image.loadImageFromDB(row.HinhAnh.ToArray()));//Binary to byte[]

                    //mã, tên, tên ảnh trong imageList
                    treeView1.Nodes.Add(row.MaLoaiMH, row.TenLoaiMH, row.MaLoaiMH, row.MaLoaiMH);
                }
                catch
                {
                    //Lỗi do chưa đặt ảnh cho danh mục => đặt ảnh mặt định cho nó ở imageList - Index = 0
                    treeView1.Nodes.Add(row.MaLoaiMH, row.TenLoaiMH, 0, 0);
                }
            }
        }
        void loadGridView()
        {
            
            
            dataGridView1.Columns["MaMH"].HeaderText = "Mã mặt hàng";
            dataGridView1.Columns["TenMH"].HeaderText = "Tên mặt hàng";
            dataGridView1.Columns["TenLoaiMH"].HeaderText = "Tên loại mặt hàng";
            dataGridView1.Columns["TenNH"].HeaderText = "Tên nhãn hiệu";
            dataGridView1.Columns["TenDVT"].HeaderText = "Tên đơn vị tính";
            dataGridView1.Columns["TonKho"].HeaderText = "Tồn kho";
            dataGridView1.Columns["ChatLieu"].HeaderText = "Chất liệu";
            dataGridView1.Columns["XuatXu"].HeaderText = "Xuất xứ";
            dataGridView1.Columns["DanhCho"].HeaderText = "Dành cho";
            dataGridView1.Columns["GiaBanLe"].HeaderText = "Giá bán lẻ";
            dataGridView1.Columns["GiaBanSi"].HeaderText = "Giá bán sỉ";
            dataGridView1.Columns["GiaKM"].HeaderText = "Giá khuyến mãi";
            dataGridView1.Columns["GiaVon"].HeaderText = "Giá vốn";
            dataGridView1.Columns["KichThuoc"].HeaderText = "Kích thước";
            dataGridView1.Columns["MoTa"].HeaderText = "Mô tả";


            dataGridView1.Columns["TonKho"].HeaderCell.Style.BackColor = Color.Green;
            dataGridView1.Columns["TonKho"].HeaderCell.Style.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;


            dataGridView1.Columns["TonKho"].DefaultCellStyle.BackColor = Color.LightGreen;
            //dataGridView1.Columns["TonKho"].DefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if((int)row.Cells["TonKho"].Value < 10)
                    row.Cells["TonKho"].Style.BackColor = Color.Red;

            }

        }
        

        private void txtTim_Click(object sender, EventArgs e)
        {
            txtTim.Text = "";
            txtTim.ForeColor = Color.Black;

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var tt = db.MatHangs
                .Join(db.LoaiMatHangs, a => a.MaLoaiMH, b => b.MaLoaiMH, (a, b) => new { a, b })
                .Join(db.DM_NhanHieus, c => c.a.MaNH, d => d.MaNH, (c, d) => new { c, d })
                .Join(db.DonViTinhs, h => h.c.a.MaDVT, f => f.MaDVT, (h, f) => new { h, f })
                .Where(o => o.f.TenDVT.Contains(txtTim.Text) || o.h.c.a.MaMH.Contains(txtTim.Text) 
                || o.h.c.a.TenMH.Contains(txtTim.Text) ||o.h.c.b.TenLoaiMH.Contains(txtTim.Text) 
                || o.h.d.TenNH.Contains(txtTim.Text)
                || o.h.c.a.ChatLieu.Contains(txtTim.Text) || o.h.c.a.XuatXu.Contains(txtTim.Text) 
                || o.h.c.a.DanhCho.Contains(txtTim.Text)
                ||o.h.c.a.KichThuoc.Contains(txtTim.Text) 
                || o.h.c.a.MoTa.Contains(txtTim.Text))
                .Select(x => new
                {
                    MaMH = x.h.c.a.MaMH,
                    TenMH = x.h.c.a.TenMH,
                    TenLoaiMH = x.h.c.b.TenLoaiMH,
                    TenNH = x.h.d.TenNH,
                    TenDVT = x.f.TenDVT,
                    TonKho = x.h.c.a.TonKho,
                    ChatLieu = x.h.c.a.ChatLieu,
                    XuatXu = x.h.c.a.XuatXu,
                    DanhCho = x.h.c.a.DanhCho,
                    GiaBanLe = x.h.c.a.GiaBanLe,
                    GiaBanSi = x.h.c.a.GiaBanSi,
                    GiaKM = x.h.c.a.GiaKM,
                    GiaVon = x.h.c.a.GiaVon,
                    KichThuoc = x.h.c.a.KichThuoc,
                    MoTa = x.h.c.a.MoTa
                });
            
                

            dataGridView1.DataSource = tt;
            loadGridView();
        }

        private void txtTim_Enter(object sender, EventArgs e)
        {
            txtTim_Click(sender, e);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtTu.Text) || String.IsNullOrEmpty(txtDen.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá trị");
                return;
            }
            var tt = db.MatHangs
                .Join(db.LoaiMatHangs, a => a.MaLoaiMH, b => b.MaLoaiMH, (a, b) => new { a, b })
                .Join(db.DM_NhanHieus, c => c.a.MaNH, d => d.MaNH, (c, d) => new { c, d })
                .Join(db.DonViTinhs, h => h.c.a.MaDVT, f => f.MaDVT, (h, f) => new { h, f })
                .Where(o => o.h.c.a.TonKho >= int.Parse(txtTu.Text) && o.h.c.a.TonKho <= int.Parse(txtDen.Text))
                .Select(x => new
                {
                    MaMH = x.h.c.a.MaMH,
                    TenMH = x.h.c.a.TenMH,
                    TenLoaiMH = x.h.c.b.TenLoaiMH,
                    TenNH = x.h.d.TenNH,
                    TenDVT = x.f.TenDVT,
                    TonKho = x.h.c.a.TonKho,
                    ChatLieu = x.h.c.a.ChatLieu,
                    XuatXu = x.h.c.a.XuatXu,
                    DanhCho = x.h.c.a.DanhCho,
                    GiaBanLe = x.h.c.a.GiaBanLe,
                    GiaBanSi = x.h.c.a.GiaBanSi,
                    GiaKM = x.h.c.a.GiaKM,
                    GiaVon = x.h.c.a.GiaVon,
                    KichThuoc = x.h.c.a.KichThuoc,
                    MoTa = x.h.c.a.MoTa
                });

            dataGridView1.DataSource = tt;
            loadGridView();
        }
        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "All")
            {
                loadFull();
                
            }
            else
            {
                var tt = db.MatHangs
                    .Join(db.LoaiMatHangs, a => a.MaLoaiMH, b => b.MaLoaiMH, (a, b) => new { a, b })
                    .Join(db.DM_NhanHieus, c => c.a.MaNH, d => d.MaNH, (c, d) => new { c, d })
                    .Join(db.DonViTinhs, h => h.c.a.MaDVT, f => f.MaDVT, (h, f) => new { h, f })
                    .Where(o => o.h.c.b.MaLoaiMH == e.Node.Name)
                    .Select(x => new
                    {
                        MaMH = x.h.c.a.MaMH,
                        TenMH = x.h.c.a.TenMH,
                        TenLoaiMH = x.h.c.b.TenLoaiMH,
                        TenNH = x.h.d.TenNH,
                        TenDVT = x.f.TenDVT,
                        TonKho = x.h.c.a.TonKho,
                        ChatLieu = x.h.c.a.ChatLieu,
                        XuatXu = x.h.c.a.XuatXu,
                        DanhCho = x.h.c.a.DanhCho,
                        GiaBanLe = x.h.c.a.GiaBanLe,
                        GiaBanSi = x.h.c.a.GiaBanSi,
                        GiaKM = x.h.c.a.GiaKM,
                        GiaVon = x.h.c.a.GiaVon,
                        KichThuoc = x.h.c.a.KichThuoc,
                        MoTa = x.h.c.a.MoTa
                    });
                dataGridView1.DataSource = tt;
            }

            
            loadGridView();
        }
    }
}
