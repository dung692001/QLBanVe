using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ThaoTac.frmTrangChu());
            //Application.Run(new ThaoTac.frmDatVe(""));
            //Application.Run(new QuanLy.frmThongTinPhim());
            //Application.Run(new QuanLy.frmHDDA());
            //Application.Run(new QuanLy.frmThongTinNV());
            //Application.Run(new QuanLy.frmLuongNV());
            //Application.Run(new ThongKe.DoanhThu());
            //Application.Run(new ThongKe.DoanhThuTheoPhim());
            //Application.Run(new ThaoTac.frmLogin());
            //Application.Run(new ThaoTac.frmPhim(1));
            //Application.Run(new QuanLy.frmLichChieuPhim());
            //Application.Run(new QuanLy.frmRapChieuPhim());
            //Application.Run(new ThongKe.DoanhThuNam());
             Application.Run(new Form1());
            //Application.Run(new ThongKe.InVe());
        }
    }
}
