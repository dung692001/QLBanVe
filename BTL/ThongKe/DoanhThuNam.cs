using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.ThongKe
{
    public partial class DoanhThuNam : Form
    {
        Classes.DataProcess dtbase = new Classes.DataProcess();
        private int nam = DateTime.Now.Year;
        double[] doanhThu = new double[13];
        public DoanhThuNam()
        {
            InitializeComponent();
            
        }
        void LoadBD(string nam)
        {
            this.ChartDoanhThuNam.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            for (int i=1;i<=12;i++)
            {
                DataTable dtBD = dtbase.SelectData("Select ISNULL(Sum(TienVe),0) " +
                                    "from Ve join BuoiChieu on Ve.MaBuoiChieu = BuoiChieu.MaBuoiChieu " +
                                    "Where MONTH(NgayChieu) = " + i.ToString() + " and Year(NgayChieu) = " + nam);
                doanhThu[i] = double.Parse(dtBD.Rows[0][0].ToString());               
                
            }
            for(int i = 1; i <= 4; i++)
            {
                double TongDoanhThu = doanhThu[i * 3] + doanhThu[i * 3 - 1] + doanhThu[i * 3 - 2];
                ChartDoanhThuNam.Series["Doanh thu"].Points.AddXY("Quý " + i.ToString(), TongDoanhThu);
                ChartDoanhThuNam.Series["Doanh thu"].Points[i-1].Label = TongDoanhThu.ToString();
            }
            
        }

        private void DoanhThuNam_Load(object sender, EventArgs e)
        {
            cboNam.DataSource = dtbase.SelectData("Select distinct Year(NgayChieu) as Nam from BuoiChieu ");
            cboNam.DisplayMember = "Nam";
            cboNam.ValueMember = "Nam";
            cboNam.Text = "";
            
            
        }

        private void cboNam_SelectionChangeCommitted(object sender, EventArgs e)
        {                    
            ChartDoanhThuNam.Series["Doanh thu"].Points.Clear();
            string nam = cboNam.SelectedValue.ToString();
            LoadBD(nam); 
        }
    }
}
