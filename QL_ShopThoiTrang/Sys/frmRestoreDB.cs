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
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace QL_ShopThoiTrang.Sys
{
    public partial class frmRestoreDB : Form
    {
        public frmRestoreDB()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            lblPer.Visible = true;
            lblStatus.Visible = true;

            DB_Manager rs = new DB_Manager();
            rs.RestoreDB(txtPath.Text, "QL_ShopThoiTrang", DbRestore_PercentComplete, DbRestore_Complete);
            
        }

        private void DbRestore_Complete(object sender, ServerMessageEventArgs e)
        {
            if(e.Error !=null)
            {
                lblStatus.Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = e.Error.Message;
                });
            }
                
        }

        private void DbRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = e.Percent;
                progressBar1.Update();
            });
            lblPer.Invoke((MethodInvoker)delegate
            {
                lblPer.Text = $"{e.Percent}%";
            });
        }
    }
}
