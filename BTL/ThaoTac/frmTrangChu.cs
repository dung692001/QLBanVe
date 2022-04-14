using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.ThaoTac
{
    public partial class frmTrangChu : Form
    {
        Classes.DataProcess dtbase = new Classes.DataProcess();
        string connectString = "select TenPhim, Anh from phim";
        string poster_rap = "";
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            DataTable dtPhim = dtbase.SelectData(connectString);           
            string[] anh = new string[15];
            for (int i = 0; i < dtPhim.Rows.Count; i++)
            {
                anh[i] = dtPhim.Rows[i]["Anh"].ToString();
            }
            try
            {
                poster_rap = "lottle_cinema.jpg";
                picAnhLottle.Image = Image.FromFile(Application.StartupPath + "\\Images\\Khac\\" + poster_rap);
                picAnh1.Image = Image.FromFile(Application.StartupPath + "\\Images\\AnhPhim\\" + anh[0]);
                picAnh2.Image = Image.FromFile(Application.StartupPath + "\\Images\\AnhPhim\\" + anh[1]);
                picAnh3.Image = Image.FromFile(Application.StartupPath + "\\Images\\AnhPhim\\" + anh[2]);
                picAnh4.Image = Image.FromFile(Application.StartupPath + "\\Images\\AnhPhim\\" + anh[3]);
                picAnh5.Image = Image.FromFile(Application.StartupPath + "\\Images\\AnhPhim\\" + anh[4]);
                picAnh6.Image = Image.FromFile(Application.StartupPath + "\\Images\\AnhPhim\\" + anh[5]);
                picAnh7.Image = Image.FromFile(Application.StartupPath + "\\Images\\AnhPhim\\" + anh[6]);
                picAnh8.Image = Image.FromFile(Application.StartupPath + "\\Images\\AnhPhim\\" + anh[7]);
                picAnh9.Image = Image.FromFile(Application.StartupPath + "\\Images\\AnhPhim\\" + anh[8]);
                picAnh10.Image = Image.FromFile(Application.StartupPath + "\\Images\\AnhPhim\\" + anh[9]);
            }
            catch
            {

            }
        }


    }
}
