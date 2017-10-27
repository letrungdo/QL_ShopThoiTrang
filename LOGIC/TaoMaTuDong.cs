using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using System.Data.SqlClient;

namespace LOGIC
{
    public class TaoMaTuDong
    {

        ConnectDB da = new ConnectDB();
        public string taoMa_MatHang(string maLoai)//mã bắt đầu = 2 ký tự của mã loại mặt hàng
        {
            //lấy 2 ký tự đầu trong mã loại mặt hàng.
            string twoChar = maLoai.Substring(0, 2);

            string nextID = getNextID(twoChar,"MatHang", "MaMH").ToString("00000000");

            return twoChar + nextID;

        }

        //
        public int getNextID(string prefixID, string tenBang, string key)
        {
            da.Connect();
            string sl = String.Format("SELECT TOP 1 {0} FROM {1} where {2} like '{3}%' ORDER BY {4} DESC", key, tenBang, key, prefixID, key);

            SqlCommand cmd = new SqlCommand(sl, da.Conn);

            string lastID = (string)cmd.ExecuteScalar();

            da.Disconnet();

            if (lastID == null)
            {
                return 1; 
            }
            int nextID = int.Parse(lastID.Remove(0, prefixID.Length)) + 1;
            
            return nextID;
        }

        public string taoMa_DVT()//5 ký tự
        {
            string nextID = getNextID("DV", "DonViTinh", "MaDVT").ToString("000");

            return "DV" + nextID;

        }
        public string taoMa_NhanHieu()//5 ký tự
        {
            string nextID = getNextID("NH", "DM_NhanHieu", "MaNH").ToString("000");

            return "NH" + nextID;

        }

    }
}
