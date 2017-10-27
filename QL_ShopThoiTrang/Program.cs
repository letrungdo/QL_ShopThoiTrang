using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ShopThoiTrang
{
    static class Program
    {
        //public static frm_Main mainForm = null;
        //public static frm_Login loginForm = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Login());

            //loginForm = new frm_Login();
            //Application.Run(loginForm);

            //Application.Run(new QL_KiemKe.frmTonKho());
            //Application.Run(new Account.frmThemNguoiDung());
        }
    }
}
