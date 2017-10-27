using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace LOGIC//k0 thực thi được qua project khác
{
    public class UpdateConnectStringEXE
    {
        public void updateCS(string conNameEXE, string con)
        {
            //Cập nhật connectString trong file QL_ShopThoiTrang.exe.Config

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.ConnectionStrings.ConnectionStrings[conNameEXE].ConnectionString = con;
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public void updateCS_DLL(string conNameEXE, string localEXE, string con)
        {
            //Cập nhật connectString trong file DATA.exe.Config

            Configuration config = ConfigurationManager.OpenExeConfiguration(Path.Combine(localEXE));//"DATA.exe"

            config.ConnectionStrings.ConnectionStrings[conNameEXE].ConnectionString = con;//"QL_ShopThoiTrang.Properties.Settings.QL_ShopThoiTrangConnectionString"
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");

        }

    }
}
