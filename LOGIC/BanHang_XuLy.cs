using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIC
{
    public class BanHang_XuLy
    {
        public string layMaHoaDonMoi(int loai = -1)

        {
            if (loai < 0 || loai > 1)
                MessageBox.Show("Loại thu chi không đúng");
            string tt = loai == 0 ? "T" : "C";
            string s ="";
            try
            {
               return s = "HD"+DateTime.Now.ToString("yyMMdd") + tt + layMaHoaDon();
            }
            catch (Exception)
            {
              return  s = "Lỗi lấy mã hóa đơn" ;
            }

        }
        private string layMaHoaDon()
        {
            ConnectDB cnn = new ConnectDB();
            cnn.Connect();
            string sqlq = "select count(MaThuChi) from ThuChi where NgayThuChi = GetDate()";
            var curid = cnn.ExecuteScalar(sqlq);
            long id = 0;
            long.TryParse(curid.ToString(), out id);
            id++;
            cnn.Disconnet();
            return id.ToString("000");


        }
    }
}
