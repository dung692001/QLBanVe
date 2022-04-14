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
    public partial class frmHDDA : Form
    {
        Classes.DataProcess data = new Classes.DataProcess();
        Classes.Function func = new Classes.Function();
        DataTable dt=new DataTable();
        DataTable dataExcel;
        string dc, sdt, tenrap;
        public frmHDDA()
        {
            InitializeComponent();
        }
        void HienThiHhoaDon()
        {
            string sql = "Select CTHoaDonBanDoAn.MaDoAn as MaDoAn ,TenDoAn," +
                "Size ,SoLuong ,Gia ,ThanhTien  " +
                "from CTHoaDonBanDoAn join DoAn on CTHoaDonBanDoAn.MaDoAn = DoAn.MaDoAn where MaHD='" + txtMaHD.Text + "'";
             dt = data.SelectData(sql);
            dgvHoaDon.DataSource = dt;
           
        }
        void LOAD_CBO()
        {
            DataTable dtNhanVien = data.SelectData("Select * from NhanVien");
            DataTable dtDoAN= data.SelectData("Select * from DoAn");
            DataTable dtHoaDon = data.SelectData("Select * from HoaDonBanDoAn ");

           func.FillCombo(cboMaNV, dtNhanVien, "MaNhanVien", "MaNhanVien");
            func.FillCombo(cboMaDA, dtDoAN, "MaDoAn", "MaDoAn");
            func.FillCombo(cboMaHD, dtHoaDon, "MaHD", "MaHD");

        }
        void ResetValues()
        {
            txtMaHD.Text = "";
            txtTenDA.Text = "";
            txtTenNV.Text = "";
            txtThanhTien.Text = "";
            txtTongTien.Text = "";
            dtpNgayban.Value=DateTime.Now;
            cboMaNV.Text = "Chọn mã NV";
            cboMaDA.Text = "Chọn mã đồ ăn";
            txtSize.Text = "";
            txtDonGia.Text = "";
            txtSize.Text = "";

        }
        private void frmHDDA_Load(object sender, EventArgs e)
        {
            LOAD_CBO();
            HienThiHhoaDon();

            dgvHoaDon.Columns[0].HeaderText = "Mã đồ ăn";
            dgvHoaDon.Columns[1].HeaderText = "Tên đồ ăn";
            dgvHoaDon.Columns[2].HeaderText = "Size"; 
            dgvHoaDon.Columns[3].HeaderText = "Số lượng";
            dgvHoaDon.Columns[4].HeaderText = "Giá";
            dgvHoaDon.Columns[5].HeaderText = "Thành tiền";


            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnIn.Enabled = false;
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtNV = data.SelectData("Select * from NhanVien where MaNhanVien='" + cboMaNV.SelectedValue.ToString() + "'");
                txtTenNV.Text = dtNV.Rows[0]["TenNhanVien"].ToString();
                dataExcel = data.SelectData("select NhanVien.MaNhanVien, TenRap,RapPhim.DiaChi as DiaChi,RapPhim.DienThoai as DienThoai from HoaDonBanDoAn join NhanVien on HoaDonBanDoAn.MaNhanVien=NhanVien.MaNhanVien join RapPhim on RapPhim.MaRap=NhanVien.MaRap where NhanVien.MaNhanVien='" + cboMaNV.SelectedValue.ToString() + "'");
                dc = dataExcel.Rows[0]["DiaChi"].ToString();
                sdt= dataExcel.Rows[0]["DienThoai"].ToString();
                tenrap= dataExcel.Rows[0]["TenRap"].ToString();

            }
            catch { }
        }

        private void cboMaDA_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtDA = data.SelectData("Select * from DoAn where MaDoAn='" + cboMaDA.SelectedValue.ToString() + "'");
                txtTenDA.Text = dtDA.Rows[0]["TenDoAn"].ToString();
                txtSize.Text= dtDA.Rows[0]["Size"].ToString();
                txtDonGia.Text = dtDA.Rows[0]["Gia"].ToString();
                txtThanhTien.Text = "";
                txtSoLuong.Text = "";
               
                
            }catch {
               // txtTenDA.Text = "";
                
            }
        }
        double TinhTien()
        {
            double gia=0;
            int sl=0; 
          
            gia = double.Parse(txtDonGia.Text);
            if (txtSoLuong.Text.Trim() == "") sl = 0;
            else sl = int.Parse(txtSoLuong.Text);

            return sl * gia;
        }

       

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = TinhTien().ToString();
        }

        private void btnThemMaHD_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = func.SinhMaTuDong("HoaDonBanDoAn", "HDB", "MaHD");
            btnThemMaHD.Enabled = true;
            txtSize.Text = "";
            txtTenDA.Text = "";
            txtTenNV.Text = "";
            txtThanhTien.Text = "";
            txtTongTien.Text = "";
            dtpNgayban.Value = DateTime.Now;
            cboMaNV.Text = "Chọn mã NV";
            cboMaDA.Text = "Chọn mã đồ ăn";
            txtSize.Text = "";
            txtDonGia.Text = "";
            HienThiHhoaDon();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnIn.Enabled = true;
            cboMaNV.Enabled = true;

            // LOAD_CBO();
           
            DataTable dtHoaDon = data.SelectData("Select * from HoaDonBanDoAn ");

           
            func.FillCombo(cboMaHD, dtHoaDon, "MaHD", "MaHD");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaHD.Text=="" || txtTenNV.Text==" "|| txtTenDA.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu, mời bạn kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(txtSoLuong.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn số lượng đồ ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            float TongTien = 0;
            int sl = 0;
            float thanhtien = 0;
            /*
            * HÓA ĐƠN BÁN ĐỒ ĂN
            */
            string sqlHDB="";
            string sqlCTHDB="";
            DataTable dtHDB = data.SelectData("Select * from HoaDonBanDoAn where MaHD='" + txtMaHD.Text + "'");
            if (dtHDB.Rows.Count == 0)
            {
                
                TongTien = float.Parse(txtThanhTien.Text);
                txtTongTien.Text = TongTien.ToString();
                sl = int.Parse(txtSoLuong.Text);
                thanhtien =  float.Parse(txtThanhTien.Text);
                sqlHDB = "Exec sp_InsertOrUpdateHDBDA '" + txtMaHD.Text + "','" + cboMaNV.SelectedValue.ToString() + "','" + dtpNgayban.Text + "','" + TongTien + "'";
                sqlCTHDB = "Exec sp_InsertOrUpdateCTHDBDA '" + txtMaHD.Text + "','" + cboMaDA.SelectedValue.ToString() + "','" + sl + "','" + thanhtien + "'";
            }
            else
            {
                                /*
                                * Chi Tiet HÓA ĐƠN BÁN ĐỒ ĂN
                                */
                DataTable dtCTHDB = data.SelectData("Select * from CTHoaDonBanDoAn where MaHD='" + txtMaHD.Text + "' and MaDoAn='"+cboMaDA.SelectedValue.ToString()+"'");
                if (dtCTHDB.Rows.Count <= 0)
                {
                    TongTien = float.Parse(txtTongTien.Text) + float.Parse(txtThanhTien.Text);
                    txtTongTien.Text = TongTien.ToString();
                    sl = int.Parse(txtSoLuong.Text);
                    thanhtien = float.Parse(txtThanhTien.Text);
                    sqlHDB = "Exec sp_InsertOrUpdateHDBDA '" + txtMaHD.Text + "','" + cboMaNV.SelectedValue.ToString() + "','" + dtpNgayban.Text + "','" + TongTien + "'";
                    sqlCTHDB = "Exec sp_InsertOrUpdateCTHDBDA '" + txtMaHD.Text + "','" + cboMaDA.SelectedValue.ToString() + "','" + sl + "','" + thanhtien + "'";

                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn thêm số lượng của đồ ăn " + txtTenDA.Text.Trim() + " Size: " + txtSize.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                   // {
                        int vt = 0;
                        for(int i = 0; i < dtCTHDB.Rows.Count; i++)
                        
                            if (cboMaDA.SelectedValue.ToString() == dtCTHDB.Rows[i]["MaDoAn"])
                            {
                                vt = i;
                                return;
                            }
                      
                            int sl1 = int.Parse(dtCTHDB.Rows[vt]["SoLuong"].ToString());
                            float thanhtien1 = float.Parse(dtCTHDB.Rows[vt]["ThanhTien"].ToString());
                            sl += sl1 + int.Parse(txtSoLuong.Text);
                            thanhtien = thanhtien1 + float.Parse(txtThanhTien.Text);
                            TongTien = float.Parse(txtTongTien.Text) + thanhtien - thanhtien1;

                           // txtSoLuong.Text = "";
                            //txtThanhTien.Text = "";
                            txtTongTien.Text = TongTien.ToString();

                        sqlHDB = "Exec sp_InsertOrUpdateHDBDA '" + txtMaHD.Text + "','" + cboMaNV.SelectedValue.ToString() + "','" + dtpNgayban.Text + "','" + TongTien + "'";
                        sqlCTHDB = "Exec sp_InsertOrUpdateCTHDBDA '" + txtMaHD.Text + "','" + cboMaDA.SelectedValue.ToString() + "','" + sl + "','" + thanhtien + "'";


                   // }
                }
            }
            cboMaDA.Enabled = true;
            cboMaNV.Enabled = false;
            btnThemMaHD.Enabled = true;
           
            data.SelectData(sqlHDB);
            data.SelectData(sqlCTHDB);
            HienThiHhoaDon();

            cboMaDA.Text = "Chọn đồ ăn";
            txtTenDA.Text = "";
            txtThanhTien.Text = "";
            txtSoLuong.Text = "";
            txtSize.Text = "";
            txtDonGia.Text = "";

        }

        private void dgvHoaDon_DoubleClick(object sender, EventArgs e)

        {
            string mada = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
           // MessageBox.Show(dataHDB.Rows[0]["TongTien"].ToString());

            if (MessageBox.Show("Bạn có muốn xóa đồ ăn có mã" + mada.Trim() + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlXoa = "Delete From CTHoaDonBanDoAn where MaHD='" + txtMaHD.Text + "' and MaDoAn='" + mada + "'";
                data.SelectData(sqlXoa);
                string sql = "Exec sp_UpdateHDBDA'" + txtMaHD.Text + "','" + mada + "'";
                data.SelectData(sql);
                txtTongTien.Text = (float.Parse(txtTongTien.Text)- float.Parse( dgvHoaDon.CurrentRow.Cells[5].Value.ToString())).ToString();
                HienThiHhoaDon();

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboMaHD.SelectedIndex == -1)
                MessageBox.Show("Bạn chưa chọn hóa đơn nào ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else
            {
                DataTable dtHoaDon = data.SelectData("Select * from HoaDonBanDoAn where MaHD='" + cboMaHD.SelectedValue.ToString() + "'");
                txtMaHD.Text = cboMaHD.SelectedValue.ToString();
                cboMaNV.Text = dtHoaDon.Rows[0]["MaNhanVien"].ToString();
                txtTongTien.Text = dtHoaDon.Rows[0]["TongTien"].ToString();
                string sql = "Select CTHoaDonBanDoAn.MaDoAn as MaDoAn ,TenDoAn," +
                "Size ,SoLuong ,Gia ,ThanhTien  " +
                "from CTHoaDonBanDoAn join DoAn on CTHoaDonBanDoAn.MaDoAn = DoAn.MaDoAn where MaHD='" + cboMaHD.SelectedValue.ToString() + "'";

                dgvHoaDon.DataSource = data.SelectData(sql);
                btnHuy.Enabled = true;
                btnIn.Enabled = true;
            }
          }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            data.updateData("Delete from CTHoaDonBanDoAn  where MaHD='" + txtMaHD.Text + "'");
            data.updateData("Delete from HoaDonBanDoAn  where MaHD='" + txtMaHD.Text + "'");
            HienThiHhoaDon();
            ResetValues();
            cboMaNV.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnIn.Enabled = false;
            DataTable dtHoaDon = data.SelectData("Select * from HoaDonBanDoAn ");
            func.FillCombo(cboMaHD, dtHoaDon, "MaHD", "MaHD");
        }
        void KeyPress_NhapChu(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn không được nhập số hay bất cứ kí tự đặc biệt nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            frmThongTinNV frm = new frmThongTinNV();
            frm.ShowDialog();
            DataTable dtNhanVien = data.SelectData("Select * from NhanVien");
            func.FillCombo(cboMaNV, dtNhanVien, "MaNhanVien", "MaNhanVien");
          
        }

        private void btnThemDoAn_Click(object sender, EventArgs e)
        {
            frmDoAn frm = new frmDoAn();
            frm.ShowDialog();
          
            DataTable dtDoAN = data.SelectData("Select * from DoAn");
            func.FillCombo(cboMaDA, dtDoAN, "MaDoAn", "MaDoAn");
            
        }

        void KeyPress_NhapSo(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) < Convert.ToInt32('0') || Convert.ToInt32(e.KeyChar) > Convert.ToInt32('9'))
                && Convert.ToInt32(e.KeyChar) != 8)
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            HienThiHhoaDon();
            SaveFileDialog dlgSave = new SaveFileDialog();

            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            exSheet.Name = "Hóa Đơn Bán Đồ Ăn";

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

            Excel.Range manv = (Excel.Range)exSheet.Cells[4, 1];
            manv.Font.Size = 12;
            manv.Font.Bold = true;
            manv.Font.Color = Color.Purple;
            manv.Value = "Nhân viên: " + txtTenNV.Text;

            Excel.Range header = (Excel.Range)exSheet.Cells[6, 4];
            exSheet.get_Range("D5:H5").Merge(true);
            header.Font.Size = 18;
            header.Font.Bold = true;
            header.Font.Color = Color.Red;
            header.Value = "Chi Tiết Hóa Đơn Mua Hàng";

            Excel.Range TongTien = (Excel.Range)exSheet.Cells[dt.Rows.Count + 10, 6];
            //  exSheet.get_Range("D5:F5").Merge(true);
            TongTien.Font.Size = 13;
            TongTien.Font.Bold = true;
            TongTien.Font.Color = Color.Black;
            TongTien.Value = "Tổng tiền: ";

            Excel.Range Money = (Excel.Range)exSheet.Cells[dt.Rows.Count + 10, 7];
            exSheet.get_Range("H18:I18").Merge(true);
            Money.Font.Size = 13;
            Money.Font.Bold = true;
            Money.Font.Color = Color.Red;
            Money.Value = txtTongTien.Text;

            //Định dạng tiêu đề bảng
            exSheet.get_Range("A7:H7").Font.Bold = true;
            exSheet.get_Range("A7:H7").HorizontalAlignment =
            Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exSheet.get_Range("A7").Value = "STT";
            exSheet.get_Range("B7").Value = "Mã đồ ăn";
            exSheet.get_Range("C7").Value = "Tên đồ ăn";
            exSheet.get_Range("C7").ColumnWidth = 20;
            exSheet.get_Range("D7").Value = "Size";
            exSheet.get_Range("D7").ColumnWidth = 10;
            exSheet.get_Range("E7").Value = "Số lượng";
            exSheet.get_Range("F7").Value = "Giá";
            exSheet.get_Range("F7").ColumnWidth = 13;
            exSheet.get_Range("G7").Value = "Thành tiền";
            exSheet.get_Range("G7").ColumnWidth = 25;



            //In dữ liệu
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                exSheet.get_Range("A" + (i + 9).ToString() + ":G" + (i + 9).ToString()).Font.Bold = false;
                exSheet.get_Range("A" + (i + 9).ToString()).Value = (i + 1).ToString();
                exSheet.get_Range("B" + (i + 9).ToString()).Value = dt.Rows[i]["MaDoAn"].ToString();
                exSheet.get_Range("C" + (i + 9).ToString()).Value =
                 dt.Rows[i]["TenDoAn"].ToString();
                exSheet.get_Range("D" + (i + 9).ToString()).Value =
                dt.Rows[i]["Size"].ToString();
                exSheet.get_Range("E" + (i + 9).ToString()).Value =
                dt.Rows[i]["SoLuong"].ToString();
                exSheet.get_Range("F" + (i + 9).ToString()).Value =
                dt.Rows[i]["Gia"].ToString();
                exSheet.get_Range("G" + (i + 9).ToString()).Value =
                 dt.Rows[i]["ThanhTien"].ToString();
              
            }
          
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
    }
}
