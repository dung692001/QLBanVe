using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace BTL.QuanLy
{
    public partial class frmLuongNV : Form
    {
        Classes.DataProcess data = new Classes.DataProcess();
        DataTable dtLuong;
        Classes.Function Func_So_Chu = new Classes.Function();
        string dc, sdt, tenrap;
        public frmLuongNV()
        {
            InitializeComponent();
        }
        void LOAD_VIEW()
        {
            dtLuong = data.SelectData("Select * from BangLuongNV");
            dgvLuongNV.DataSource = dtLuong;
            dgvLuongNV.Columns[7].Visible = false;
            dgvLuongNV.Columns[8].Visible = false;
            dgvLuongNV.Columns[9].Visible = false;
            dgvLuongNV.Columns[10].Visible = false;

        }
        void LOAD_RAP()
        {
            string sqlSelect = "select MaRap,TenRap from RapPhim";
            cboMaRap.DataSource = data.SelectData(sqlSelect);
            cboMaRap.DisplayMember = "TenRap";
            cboMaRap.ValueMember = "MaRap";
            cboMaRap.Text = "";
        }

        private void frmLuongNV_Load(object sender, EventArgs e)
        {
            //  if(cboMaRap.Text=="")
            LOAD_VIEW();
            LOAD_RAP();


            dgvLuongNV.Columns[0].HeaderText = "Mã nhân viên";
            dgvLuongNV.Columns[1].HeaderText = "Tên nhân viên";
            dgvLuongNV.Columns[2].HeaderText = "Chức vụ";
            dgvLuongNV.Columns[3].HeaderText = "Thâm niên";
            dgvLuongNV.Columns[4].HeaderText = "Trợ cấp";
            dgvLuongNV.Columns[5].HeaderText = "Phụ cấp thâm niên";
            dgvLuongNV.Columns[6].HeaderText = "Lương";

            dgvLuongNV.Columns[1].Width = 150;
            dgvLuongNV.Columns[5].Width = 150;

            string sqlTongTien = "select Sum(Luong) as TongLuong from BangLuongNV";
          
            DataTable luong = data.SelectData(sqlTongTien);
            txtTongTien.Text = luong.Rows[0]["TongLuong"].ToString();

            lblTongTien.Text = Func_So_Chu.ChuyenSoSangChuoi(double.Parse(txtTongTien.Text));

           
           
        }


        private void dgvLuongNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Luong = "Nhân viên mã ";
            Luong += dgvLuongNV.CurrentRow.Cells[0].Value.ToString().Trim();
            Luong += " - " + dgvLuongNV.CurrentRow.Cells[1].Value.ToString().Trim();
            Luong += " có Lương = " + dgvLuongNV.CurrentRow.Cells[6].Value.ToString().Trim();
            lblLuongNV.Text = Luong;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void dgvLuongNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();

            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            exSheet.Name = "Lương nhân viên";

            //Định dạng chung
            Excel.Range tenCuaHang = (Excel.Range)exSheet.Cells[1, 1];
            tenCuaHang.Font.Size = 12;
            tenCuaHang.Font.Bold = true;
            tenCuaHang.Font.Color = Color.Purple;
            tenCuaHang.Value = tenrap;

            Excel.Range dcRapPhim = (Excel.Range)exSheet.Cells[2, 1];
            exSheet.get_Range("A2:H2").Merge(true);
            dcRapPhim.Font.Size = 13;
            dcRapPhim.Font.Bold = true;
            dcRapPhim.Font.Color = Color.Purple;
            dcRapPhim.Value = "Địa chỉ: " + dc;

            Excel.Range dtRapPhim = (Excel.Range)exSheet.Cells[3, 1];
            dtRapPhim.Font.Size = 12;
            dtRapPhim.Font.Bold = true;
            dtRapPhim.Font.Color = Color.Purple;
            dtRapPhim.Value = "Điện thoại: " + sdt;

            Excel.Range header = (Excel.Range)exSheet.Cells[5, 4];
            exSheet.get_Range("D5:G5").Merge(true);
            header.Font.Size = 18;
            header.Font.Bold = true;
            header.Font.Color = Color.Red;
            header.Value = "BẢNG LƯƠNG NHÂN VIÊN";

            Excel.Range TongTien = (Excel.Range)exSheet.Cells[dtLuong.Rows.Count + 9, 7];
            //  exSheet.get_Range("D5:F5").Merge(true);
            TongTien.Font.Size = 13;
            TongTien.Font.Bold = true;
            TongTien.Font.Color = Color.Black;
            TongTien.Value = "Tổng tiền: ";

            Excel.Range Money = (Excel.Range)exSheet.Cells[dtLuong.Rows.Count + 9, 8];
            //exSheet.get_Range("H18:I18").Merge(true);
            Money.Font.Size = 13;
            Money.Font.Bold = true;
            Money.Font.Color = Color.Red;
            Money.Value = txtTongTien.Text;

            Excel.Range ChuTien = (Excel.Range)exSheet.Cells[dtLuong.Rows.Count + 10, 7];
            //exSheet.get_Range("G19:K19").Merge(true);
            ChuTien.Font.Size = 13;
            ChuTien.Font.Bold = true;
            ChuTien.Font.Color = Color.Red;
            ChuTien.Value = Func_So_Chu.ChuyenSoSangChuoi(double.Parse(txtTongTien.Text));


            //Định dạng tiêu đề bảng
            exSheet.get_Range("A7:H7").Font.Bold = true;
            exSheet.get_Range("A7:H7").HorizontalAlignment =
            Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exSheet.get_Range("A7").Value = "STT";
            exSheet.get_Range("B7").Value = "Mã Nhân Viên";
            exSheet.get_Range("B7").ColumnWidth = 20;
            exSheet.get_Range("C7").Value = "Tên Nhân Viên";
            exSheet.get_Range("C7").ColumnWidth = 25;
            exSheet.get_Range("D7").Value = "Chức vụ";
            exSheet.get_Range("E7").Value = "Thâm Niên(TN)";
            exSheet.get_Range("E7").ColumnWidth = 13;
            exSheet.get_Range("F7").Value = "Trợ cấp";
            exSheet.get_Range("G7").Value = "Phụ cấp TN";
            exSheet.get_Range("G7").ColumnWidth = 15;
            exSheet.get_Range("H7").Value = "Lương";
            exSheet.get_Range("H7").ColumnWidth = 20;


            //In dữ liệu
            for (int i = 0; i < dtLuong.Rows.Count; i++)
            {
                exSheet.get_Range("A" + (i + 8).ToString() + ":G" + (i + 8).ToString()).Font.Bold = false;
                exSheet.get_Range("A" + (i + 8).ToString()).Value = (i + 1).ToString();
                exSheet.get_Range("B" + (i + 8).ToString()).Value = dtLuong.Rows[i]["MaNhanVien"].ToString();
                exSheet.get_Range("C" + (i + 8).ToString()).Value =
                 dtLuong.Rows[i]["TenNhanVien"].ToString();
                exSheet.get_Range("D" + (i + 8).ToString()).Value =
                dtLuong.Rows[i]["ChucVu"].ToString();
                exSheet.get_Range("E" + (i + 8).ToString()).Value =
                dtLuong.Rows[i]["ThamNien"].ToString();
                exSheet.get_Range("F" + (i + 8).ToString()).Value =
                dtLuong.Rows[i]["TroCap"].ToString();
                exSheet.get_Range("G" + (i + 8).ToString()).Value =
                 dtLuong.Rows[i]["PhuCapThamNien"].ToString();
                exSheet.get_Range("H" + (i + 8).ToString()).Value =
               dtLuong.Rows[i]["Luong"].ToString();
            }
            /* exSheet.get_Range("D5:F5").Style.Fill.BackgroundColor.SetColor(Color.Red);
             var fill = cell.Style.Fill;
             fill.PatternType = ExcelFillStyle.Solid;
             fill.BackgroundColor.SetColor(.System.Drawing.ColorLightBlue);*/

            //exSheet.Range["D5:F5"].Style.Color = Color.SpringGreen;

            exBook.Activate(); //Kích hoạt file Excel
                               //Thiết lập các thuộc tính của SaveFileDialog
            dlgSave.Filter = "Excel Document(*.csv)|*.csv|Word Document(*.doc)| *.doc | All files(*.*) | *.* ";
            dlgSave.FilterIndex = 1;
            dlgSave.AddExtension = true;
            // dlgSave.DefaultExt = ".xls";
            dlgSave.DefaultExt = ".csv";
            if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                exBook.SaveAs(dlgSave.FileName.ToString());//Lưu file Excel
            exApp.Quit();//Thoát khỏi ứng dụng
        }




        private void cboMaRap_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtLuong = data.SelectData("Select * from BangLuongNV WHERE RP like '" + cboMaRap.SelectedValue.ToString() + "'");
            dgvLuongNV.DataSource = dtLuong;

            tenrap = dtLuong.Rows[0]["TenRap"].ToString();
            dc = dtLuong.Rows[0]["DiaChi"].ToString();
            sdt = dtLuong.Rows[0]["DienThoai"].ToString();
            string sqlTongTien = "select Sum(Luong) as TongLuong from BangLuongNV where RP like '" + cboMaRap.SelectedValue.ToString() + "'";
            DataTable luong = data.SelectData(sqlTongTien);
            txtTongTien.Text = luong.Rows[0]["TongLuong"].ToString();
            lblTongTien.Text = Func_So_Chu.ChuyenSoSangChuoi(double.Parse(txtTongTien.Text));
        }
    }
}
