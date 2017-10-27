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
using System.IO;

namespace QL_ShopThoiTrang.Sys
{
    public partial class frmBackupDB : Form
    {
        
        public frmBackupDB()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            DB_Manager bk = new DB_Manager();
            bk.BackupDB(txtPath.Text, "QL_ShopThoiTrang", new frmHelp());
            
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.Title = "Đặt tên và chọn đường dẫn lưu database";
            saveFileDialog1.Filter = "Backup Files|*.bak|All Files|*.*";
            string sfdname = saveFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = Path.GetFullPath(saveFileDialog1.FileName);
            }
            
        }

        private void frmBackupDB_Load(object sender, EventArgs e)
        {
           

        }


    }
}
