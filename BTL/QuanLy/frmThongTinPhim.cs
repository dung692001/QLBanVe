using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.QuanLy
{
    public partial class frmThongTinPhim : Form
    {
        Classes.DataProcess data = new Classes.DataProcess();
        Classes.Function func = new Classes.Function();
        string imageName;
        string MaHang, MaNuoc, MaTL;
        string videoPath;
        string videoTitle;
        public frmThongTinPhim()
        {
            InitializeComponent();
        }
        /*
         * Các hàm LOAD dữ liệu
         */
        void LOADDATA_PHIM()
        {
            string sqlSelect = "Select * From ThongTin_Phim ";
            // string sqlSelect = "exec ProcedureLayThongTinPhim";

            DataTable dtPhim = data.SelectData(sqlSelect);
            dgvPhim.DataSource = dtPhim;



            dgvPhim.Columns[15].Visible = false;
            dgvPhim.Columns[16].Visible = false;
            dgvPhim.Columns[17].Visible = false;
        }
        void Load_HangPhim()
        {
            string sqlSelect = "select MaHangSX,TenHangSX from HangSX";
            cboHangSX.DataSource = data.SelectData(sqlSelect);
            cboHangSX.DisplayMember = "TenHangSX";
            cboHangSX.ValueMember = "MaHangSX";
            cboHangSX.Text = "";
        }
        void Load_TheLoaiPhim()
        {
            string sqlSelect = "select MaTheLoai,TenTheLoai from TheLoai";
            cboTheLoai.DataSource = data.SelectData(sqlSelect);
            cboTheLoai.DisplayMember = "TenTheLoai";
            cboTheLoai.ValueMember = "MaTheLoai";
            cboTheLoai.Text = "";
        }
        void Load_NuocSX()
        {
            string sqlSelect = "select NuocSX,TenNuocSX from NuocSanXuat";
            cboNuocSX.DataSource = data.SelectData(sqlSelect);
            cboNuocSX.DisplayMember = "TenNuocSX";
            cboNuocSX.ValueMember = "NuocSX";
            cboNuocSX.Text = "";
        }
        /*
         * Hàm reset Thông tin
         */
        void RESET_ThongTinPhim()
        {
            txtMaPhim.Text = "";
            txtTenPhim.Text = "";
            cboTheLoai.Text = "";
            // cboTheLoai.SelectedIndex = -1;
            // cboNuocSX.SelectedIndex = -1;
            cboNuocSX.Text = "";
            // cboHangSX.SelectedIndex = -1;
            cboHangSX.Text = "";
            txtDD.Text = "";
            txtNuChinh.Text = "";
            txtNamChinh.Text = "";
            txtGhiChu.Text = "";
            txtNamSX.Text = "";
            txtThoiLuong.Text = "";
            dateNgayChieu.Text = "";
            dateNgayKT.Text = "";
            txtTongCP.Text = "";
            
            txtMaPhim.Focus();
            picPhim.Image = null;
            Trailer.URL = null;
            cboHangSX.Text = "Chọn Hãng ";
            cboNuocSX.Text = "Chọn nước";
            cboTheLoai.Text = "Chọn thể loại";
        }
        /*
         * Các hàm check kí tự nhập vào
         */
        void KeyPress_NhapSo(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) < Convert.ToInt32('0') || Convert.ToInt32(e.KeyChar) > Convert.ToInt32('9'))
                && Convert.ToInt32(e.KeyChar) != 8)
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void KeyPress_NhapChu(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn không được nhập số hay bất cứ kí tự đặc biệt nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmThongTinPhim_Load(object sender, EventArgs e)
        {
            /*
             * Load Dữ liệu
             */
            LOADDATA_PHIM();
            Load_HangPhim();
            Load_NuocSX();
            Load_TheLoaiPhim();

            cboHangSX.Text = "Chọn Hãng ";
            cboNuocSX.Text = "Chọn nước";
            cboTheLoai.Text = "Chọn thể loại";

            btnLamMoi.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThemPhim.Enabled = false;
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            String[] pathImage;
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "JPEG Images|*.jpg|All Files|*.*";
            dlgOpen.InitialDirectory = Application.StartupPath.ToString() + "\\Images\\AnhPhim";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picPhim.Image = Image.FromFile(dlgOpen.FileName);
                pathImage = dlgOpen.FileName.Split('\\');
                imageName = pathImage[pathImage.Length - 1];
            }
        }

        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            if ( txtTenPhim.Text == "" || cboHangSX.Text == "" || cboNuocSX.Text == "" || cboTheLoai.Text == "" ||
               txtDD.Text == "" || txtNuChinh.Text == "" || txtNamChinh.Text == "" || txtNamSX.Text == "" || dateNgayChieu.Text == "" || dateNgayKT.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string sqlSelect = "Select * from Phim where MaPhim= '" + txtMaPhim.Text + "'";
                DataTable dtPhim = data.SelectData(sqlSelect);
                if (dtPhim.Rows.Count > 0) MessageBox.Show("Mã Phim " + txtMaPhim.Text.Trim() + " đã có, mời bạn nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    string sqlInsert1 = "exec InsertThongTinPhim'" + txtMaPhim.Text + "', N'" + txtTenPhim.Text + "', '" + MaNuoc + "', '" + MaHang + "', '" + MaTL + "', N'" + txtDD.Text + "', N'" + txtNuChinh.Text + "', N'"
                            + txtNamChinh.Text + "', N'" + txtGhiChu.Text + "', " + int.Parse(txtNamSX.Text) + ", " + int.Parse(txtThoiLuong.Text) + ", '" + dateNgayChieu.Text + "', '"
                            + dateNgayKT.Text + "', " + float.Parse(txtTongCP.Text) + ", N'" + imageName + "', N'" + videoTitle + "'";
                    data.updateData(sqlInsert1);
                    LOADDATA_PHIM();
                    RESET_ThongTinPhim();
                    

                }
            }
        }

      
        private void dgvPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            txtMaPhim.Text = dgvPhim.CurrentRow.Cells[0].Value.ToString();
            txtTenPhim.Text = dgvPhim.CurrentRow.Cells[1].Value.ToString(); cboNuocSX.Text = "";
            cboNuocSX.SelectedText = dgvPhim.CurrentRow.Cells[2].Value.ToString(); cboHangSX.Text = "";
            cboHangSX.SelectedText = dgvPhim.CurrentRow.Cells[3].Value.ToString();
            cboTheLoai.Text = "";
            cboTheLoai.SelectedText = dgvPhim.CurrentRow.Cells[4].Value.ToString(); 
            txtDD.Text = dgvPhim.CurrentRow.Cells[5].Value.ToString();
            txtNuChinh.Text = dgvPhim.CurrentRow.Cells[6].Value.ToString();
            txtNamChinh.Text = dgvPhim.CurrentRow.Cells[7].Value.ToString();
            txtGhiChu.Text = dgvPhim.CurrentRow.Cells[8].Value.ToString();
            txtNamSX.Text = dgvPhim.CurrentRow.Cells[9].Value.ToString();
            txtThoiLuong.Text = dgvPhim.CurrentRow.Cells[10].Value.ToString();
            dateNgayChieu.Text = dgvPhim.CurrentRow.Cells[11].Value.ToString();
            dateNgayKT.Text = dgvPhim.CurrentRow.Cells[12].Value.ToString();
            txtTongCP.Text = dgvPhim.CurrentRow.Cells[13].Value.ToString(); 
            try
            {
                imageName = dgvPhim.CurrentRow.Cells[14].Value.ToString();
                picPhim.Image = Image.FromFile(Application.StartupPath.ToString() + "\\Images\\AnhPhim\\" + imageName);
                videoTitle = dgvPhim.CurrentRow.Cells[18].Value.ToString();
                
                Trailer.URL = Application.StartupPath.ToString() + "\\Trailer\\" + videoTitle;
            }
            catch
            { }
            MaNuoc = dgvPhim.CurrentRow.Cells[15].Value.ToString();
            MaHang = dgvPhim.CurrentRow.Cells[16].Value.ToString();
            MaTL = dgvPhim.CurrentRow.Cells[17].Value.ToString(); btnSua.Enabled = true;
            btnLamMoi.Enabled = true;
            btnThemPhim.Enabled = false;
            btnXoa.Enabled = true;
        }






        private void cboNuocSX_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MaNuoc = cboNuocSX.SelectedValue.ToString();
        }

        private void cboHangSX_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MaHang = cboHangSX.SelectedValue.ToString();
        }

        private void cboTheLoai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MaTL = cboTheLoai.SelectedValue.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhim.Text == "") MessageBox.Show("Bạn chưa chọn phim để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            if (MessageBox.Show("Bạn có muốn xóa phim " + txtMaPhim.Text.Trim() + " không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sqlDelete = "exec DeleteThongTinPhim '" + txtMaPhim.Text + "'";
                data.updateData(sqlDelete);
                LOADDATA_PHIM();
                RESET_ThongTinPhim();
                btnThemPhim.Enabled = true;
                btnLamMoi.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;


            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string sqlSelect = "Select MaPhim,TenPhim,TenNuocSX,TenHangSX,TenTheLoai,DaoDien,NuDienVienChinh," +
                 "NamDienVienChinh,NoiDungChinh,NamSX,ThoiLuong,NgayKhoiChieu,NgayKetThuc,TongChiPhi,Anh," +
                 "Phim.MaNuocSX,Phim.MaHang,Phim.MaTheLoai,trailer " +
                                  "from Phim join HangSX on HangSX.MaHangSX= Phim.MaHang " +
                                  "join NuocSanXuat on NuocSanXuat.NuocSX=Phim.MaNuocSX " +
                                  "join Theloai on Theloai.MaTheLoai=Phim.MaTheLoai " +
                                  "where Phim.MaPhim is not null ";
            if (txtTimKiem.Text != "")
                sqlSelect += " and Phim.MaPhim like '%" + txtTimKiem.Text + "%' or Phim.MaPhim Like '%" + txtTimKiem.Text + "%' or TenPhim Like '%" + txtTimKiem.Text + "%'";
            dgvPhim.DataSource = data.SelectData(sqlSelect);

        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            frmLoaiPhim lp = new frmLoaiPhim();
            lp.ShowDialog();
            Load_TheLoaiPhim();
        }

        private void btnNuocSX_Click(object sender, EventArgs e)
        {
            frmNuocSX nuocsx = new frmNuocSX();
            nuocsx.ShowDialog();
            Load_NuocSX();
        }

        private void btnHangSX_Click(object sender, EventArgs e)
        {
            frmHangSX hangsx = new frmHangSX();
            hangsx.ShowDialog();
            Load_HangPhim();
        }

       

        private void btnOpenTrailer_Click(object sender, EventArgs e)
        {
            OpenFileDialog  open = new OpenFileDialog();
            open.Filter = "Mp4 files|*.mp4|All File|*.*";
            open.InitialDirectory = Application.StartupPath.ToString() + "\\Trailer";
            open.Multiselect = false;
            open.Title = "Open";
            if (open.ShowDialog() == DialogResult.OK)
            {
                videoPath = open.FileName;
                videoTitle = open.SafeFileName;
                Trailer.URL = videoPath;
            }
        }

      

        private void btnThemMa_Click(object sender, EventArgs e)
        {
            txtMaPhim.Text = func.SinhMaTuDong("Phim", "Film", "MaPhim");
            btnThemMa.Enabled = false;
            btnThemPhim.Enabled = true;
            btnLamMoi.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnPhimAnKhach_Click(object sender, EventArgs e)
        {

            if (txtTimKiem.Text == "")
            {
                LOADDATA_PHIM();
            }
            else
            {
                DataTable dt = data.SelectData("Select * from func_PhimAnKhach('" + txtTimKiem.Text + "')");
                dgvPhim.DataSource = dt;
            }
        }

      

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (txtTenPhim.Text == "" || cboHangSX.Text == "" || cboNuocSX.Text == "" || cboTheLoai.Text == "" ||
                txtDD.Text == "" || txtNuChinh.Text == "" || txtNamChinh.Text == "" || txtNamSX.Text == "" || dateNgayChieu.Text == "" || dateNgayKT.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (MessageBox.Show("Bạn có chắc chắc muốn sửa  dữ liệu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                string sqlUpdate = "exec UpdateThongTinPhim '" + txtMaPhim.Text + "', N'" + txtTenPhim.Text + "', '" + MaNuoc + "', '" + MaHang + "', '" + MaTL + "', N'" + txtDD.Text + "', N'" + txtNuChinh.Text + "', N'"
                            + txtNamChinh.Text + "', N'" + txtGhiChu.Text + "', " + int.Parse(txtNamSX.Text) + ", " + int.Parse(txtThoiLuong.Text) + ", '" + dateNgayChieu.Text + "', '"
                            + dateNgayKT.Text + "', " + float.Parse(txtTongCP.Text)  + ", N'" + imageName + "',N'"+videoTitle+"'";
                data.updateData(sqlUpdate);
                LOADDATA_PHIM();
                RESET_ThongTinPhim();
                btnLamMoi.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThemPhim.Enabled = true;
            }


        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            RESET_ThongTinPhim();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThemPhim.Enabled = true;
            btnThemMa.Enabled = true;

        }
    }
}
