using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATA;
using System.Diagnostics;
using System.IO;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace LOGIC
{
    public class DB_Manager
    {
        ConnectDB con = new ConnectDB();

        public void BackupDB(string path, string dbName, Form fHelp)
        {
            if (path == String.Empty)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn lưu file backup!");
                return;
            }
            try
            {
                con.Connect();
                string query = @"Backup Database "+dbName+" To Disk = N'" + path + "'";
                con.ExecuteNonQuery(query);
                con.Disconnet();

                MessageBox.Show("Backup thành công!");
                Process.Start(Path.GetDirectoryName(path));//mở thư mục mới lưu file

            }
            catch
            {

                DialogResult result = MessageBox.Show("Bạn không có quyền ghi file ở đây!", "Thất bại", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    fHelp.ShowDialog();
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
        }

        public void RestoreDB(string path, string dbName, PercentCompleteEventHandler DbRestore_PercentComplete, ServerMessageEventHandler DbRestore_Complete)
        {
            if (path == String.Empty)
            {
                MessageBox.Show("Vui lòng chọn file backup!");
                return;
            }
            try
            {
                ConnectDB con = new ConnectDB();

                Server dbServer = new Server(new ServerConnection(con.Conn));


                Restore dbRestore = new Restore() { Database = dbName, Action = RestoreActionType.Database, ReplaceDatabase = true, NoRecovery = false };

                // Kill all processes
                dbServer.KillAllProcesses(dbRestore.Database);
                // Set single-user mode
                Database db = dbServer.Databases[dbRestore.Database];
                // db.DatabaseOptions.UserAccess=true;
                db.Alter(TerminationClause.RollbackTransactionsImmediately);
                // Detach database
                dbServer.DetachDatabase(dbRestore.Database, false);

                dbRestore.Devices.AddDevice(path, DeviceType.File);
                dbRestore.PercentComplete += DbRestore_PercentComplete;
                dbRestore.Complete += DbRestore_Complete;
                dbRestore.SqlRestoreAsync(dbServer);

                //---------------------------CODE thủ công-------------------------------------------------------------------------------
                //con.Connect();
                //con.ExecuteNonQuery("Use master");
                //con.ExecuteNonQuery("Alter database QL_ShopThoiTrang set offline with rollback immediate");
                //con.ExecuteNonQuery(@"RESTORE DATABASE QL_ShopThoiTrang FROM DISK = N'" + txtPath.Text + "'");
                //con.ExecuteNonQuery("Alter database QL_ShopThoiTrang set online");
                //con.Disconnet();
                //----------------------------------------------------------------------------------------------------------

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
