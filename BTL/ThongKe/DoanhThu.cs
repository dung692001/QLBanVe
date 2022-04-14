using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace BTL.ThongKe
{
    public partial class DoanhThu : Form
    {
        Classes.DataProcess dtBase = new Classes.DataProcess();
        string thang;
        DataTable dtDoanhThu;
        public DoanhThu()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            dgvDoanhThu.DataSource = dtBase.SelectData("Select Ve.MaVe , TienVe , NgayChieu  from Ve join BuoiChieu on Ve.MaBuoiChieu = BuoiChieu.MaBuoiChieu " +
                " where month(NgayChieu) = month('" + DateTime.Now + "')");
        }

        private double tongTien()
        {
            double sum = 0;
            for (int i = 0; i < dgvDoanhThu.Rows.Count - 1; i++)
            {
                sum += double.Parse(dgvDoanhThu.Rows[i].Cells[1].Value.ToString());
            }
            return sum;
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvDoanhThu.Columns[0].HeaderText = "Mã Vé";
            dgvDoanhThu.Columns[1].HeaderText = "Tiền Vé";
            dgvDoanhThu.Columns[2].HeaderText = "Ngày Lập";

            txtDoanhThu.Text = tongTien().ToString();

            //string x = dtBase.procDoanhThuThang(11);
            //txtDoanhThu.Text = x;
            if (txtThang.Text == "")
            {
                thang = DateTime.Now.Month.ToString();
            }
            else
            {
                thang = txtThang.Text;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sqlSelect = "Select Ve.MaVe , TienVe , NgayChieu  from Ve join BuoiChieu on Ve.MaBuoiChieu = BuoiChieu.MaBuoiChieu ";
            if (txtThang.Text.Trim() != "")
            {
                sqlSelect += "where month(NgayChieu) = '" + txtThang.Text + "'";
                dgvDoanhThu.DataSource = dtBase.SelectData(sqlSelect);

                txtDoanhThu.Text = tongTien().ToString();
                thang = txtThang.Text;
                if (dgvDoanhThu.Rows.Count <= 1)
                {
                    MessageBox.Show("Không tìm doanh thu tháng " + txtThang.Text);

                }
            }
            else
            {
                LoadData();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            dtDoanhThu = (DataTable)dgvDoanhThu.DataSource;

            if (dtDoanhThu.Rows.Count > 0)
            {
                //Khai báo và khởi tạo các đối tượng
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

                //Định dạng chung
                Excel.Range tieude = (Excel.Range)exSheet.Cells[1, 1];
                tieude.Font.Size = 12;
                tieude.Font.Bold = true;
                tieude.Font.Color = Color.Blue;
                tieude.Value = "DOANH THU THÁNG " + thang;


                exSheet.get_Range("A4:D4").Font.Bold = true;
                exSheet.get_Range("A4:D4").Font.Color = Color.Red;
                exSheet.get_Range("A4:D4").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("A4").Value = "STT";
                exSheet.get_Range("B4").Value = "Mã Vé";
                exSheet.get_Range("C4").Value = "Tiền Vé";
                exSheet.get_Range("D4").Value = "Ngày Lập";
                exSheet.get_Range("D4").ColumnWidth = 20;

                //In dữ liệu
                for (int i = 0; i < dtDoanhThu.Rows.Count; i++)
                {
                    exSheet.get_Range("A" + (i + 5).ToString() + ":E" + (i + 8).ToString()).Font.Bold = false;
                    exSheet.get_Range("A" + (i + 5).ToString() + ":E" + (i + 8).ToString()).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    exSheet.get_Range("A" + (i + 5).ToString()).Value = (i + 1).ToString();
                    exSheet.get_Range("B" + (i + 5).ToString()).Value = dtDoanhThu.Rows[i]["MaVe"].ToString();
                    exSheet.get_Range("C" + (i + 5).ToString()).Value = dtDoanhThu.Rows[i]["TienVe"].ToString();

                    exSheet.get_Range("D" + (i + 5).ToString()).Value = ((DateTime)dtDoanhThu.Rows[i]["NgayChieu"]).ToString();
                }
                exSheet.get_Range("A" + (dtDoanhThu.Rows.Count + 7).ToString()).Value = "Tổng doanh thu ";
                exSheet.get_Range("A" + (dtDoanhThu.Rows.Count + 7).ToString() + ":B" + (dtDoanhThu.Rows.Count + 7).ToString()).Merge(true);
                exSheet.get_Range("C" + (dtDoanhThu.Rows.Count + 7).ToString()).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("C" + (dtDoanhThu.Rows.Count + 7).ToString()).Value = txtDoanhThu.Text;
                exSheet.Name = "Doanh Thu Thang";
                exBook.Activate(); //Kích hoạt file Excel
                                   //Thiết lập các thuộc tính của SaveFileDialog
                dlgSave.Filter = "Excel Document(*.xls)|*.xls |Word Document(*.doc) | *.doc | All files(*.*) | *.* ";
                dlgSave.FilterIndex = 1;
                dlgSave.AddExtension = true;
                dlgSave.DefaultExt = ".xls";

                if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    exBook.SaveAs(dlgSave.FileName.ToString());//Lưu file Excel
                exApp.Quit();//Thoát khỏi ứng dụng
            }
            else
                MessageBox.Show("Không có danh sách doanh thu để in");
        }
    }
}
