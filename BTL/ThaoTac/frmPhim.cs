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
    public partial class frmPhim : Form
    {
        Form1 frm = new Form1();
        Button button1 = new Button();
        Classes.DataProcess dtbase = new Classes.DataProcess();
        //ThaoTac.frmLogin frmDN = new ThaoTac.frmLogin();
        //string MaPhim;
        string connectString = "Select MaPhim, TenPhim, TenNuocSX, TenHangSX, TenTheLoai, DaoDien, ThoiLuong, NamSX, NuDienVienChinh, NamDienVienChinh, Anh, Trailer"
                    + " from Phim join NuocSanXuat on Phim.MaNuocSX=NuocSanXuat.NuocSX"
                     + " join HangSX on Phim.MaHang = HangSX.MaHangSX"
                        + " join Theloai on Phim.MaTheLoai = Theloai.MaTheLoai";
        string imageName = "";
        string TrailerName = "";
        string MaPhim = "";
        public frmPhim(int kt)
        {
            InitializeComponent();
            btnDatVePhim.Visible = false;          
            if (kt == 1)
            {
                btnDatVePhim.Visible = true;
            }
        }

        void loadDataHH()
        {
            DataTable dtPhim = dtbase.SelectData(connectString);        
            dgvPhim.DataSource = dtPhim;
            
        }

        private void frmPhim_Load(object sender, EventArgs e)
        {
            loadDataHH();
                    
            dgvPhim.Columns[0].HeaderText = "Mã phim";
            dgvPhim.Columns[1].HeaderText = "Tên phim";
            dgvPhim.Columns[2].HeaderText = "Tên nước SX";
            dgvPhim.Columns[3].HeaderText = "Tên Hãng";
            dgvPhim.Columns[4].HeaderText = "Thể loại";
            dgvPhim.Columns[5].HeaderText = "Đạo diễn";
            dgvPhim.Columns[6].HeaderText = "Thời lượng";
            dgvPhim.Columns[7].HeaderText = "Năm sản xuất";
            dgvPhim.Columns[8].HeaderText = "Nữ chính";
            dgvPhim.Columns[9].HeaderText = "Nam chính";
            dgvPhim.Columns[10].HeaderText = "Ảnh";

            dgvPhim.Columns[0].Width = 60;
            dgvPhim.Columns[1].Width = 150;
            dgvPhim.Columns[2].Width = 75;
            dgvPhim.Columns[3].Width = 75;
            dgvPhim.Columns[4].Width = 75;
            dgvPhim.Columns[5].Width = 75;
            dgvPhim.Columns[6].Width = 75;
            dgvPhim.Columns[7].Width = 75;
            dgvPhim.Columns[8].Width = 75;
            dgvPhim.Columns[9].Width = 75;
            dgvPhim.Columns[10].Width = 75;
            dgvPhim.Columns[11].Width = 75;
        }

        private void dgvPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhim.Text = dgvPhim.CurrentRow.Cells[0].Value.ToString();
            MaPhim = dgvPhim.CurrentRow.Cells[0].Value.ToString();
            txtTenPhim.Text = dgvPhim.CurrentRow.Cells[1].Value.ToString();
            txtQuocGia.Text = dgvPhim.CurrentRow.Cells[2].Value.ToString();
            txtHang.Text = dgvPhim.CurrentRow.Cells[3].Value.ToString();
            txtTheLoai.Text = dgvPhim.CurrentRow.Cells[4].Value.ToString();
            txtDaoDien.Text = dgvPhim.CurrentRow.Cells[5].Value.ToString();
            txtThoiLuong.Text = dgvPhim.CurrentRow.Cells[6].Value.ToString();
            txtNamSX.Text = dgvPhim.CurrentRow.Cells[7].Value.ToString();
            txtNuChinh.Text = dgvPhim.CurrentRow.Cells[8].Value.ToString();
            txtNamChinh.Text = dgvPhim.CurrentRow.Cells[9].Value.ToString();
            try
            {
                // Application.StartupPath.ToString() là đường dẫn đến chỗ project 
                imageName = dgvPhim.CurrentRow.Cells[10].Value.ToString();
                picAnhPhim.Image = Image.FromFile(Application.StartupPath.ToString() + "\\Images\\AnhPhim\\" + imageName);
                TrailerName = Application.StartupPath.ToString() + "\\Trailer\\" + dgvPhim.CurrentRow.Cells[11].Value.ToString(); ;
            }
            catch
            {

            }
                    
            //WM1.fullScreen = true;
            WM1.URL = TrailerName;
            
        }

        private void btnDatVePhim_Click(object sender, EventArgs e)
        {
            ThaoTac.frmDatVe formDatVe = new ThaoTac.frmDatVe(MaPhim);
            formDatVe.TopLevel = false;
            formDatVe.FormBorderStyle = FormBorderStyle.None;
            formDatVe.Dock = DockStyle.Fill;
            //label1.Text = formDatVe.Text
            this.pnDatVe.Controls.Add(formDatVe);   
            this.pnDatVe.Tag = formDatVe;          
            groupBox1.Dock = DockStyle.None;
            pnTrailer.Dock = DockStyle.None;
            pnDatVe.Dock = DockStyle.Fill;
            //formDatVe.BringToFront();       
            pnDatVe.Visible = true;
            formDatVe.Show();                
            WM1.Visible = false;
            WM1.close();
            //MessageBox.Show(MaPhim);
        }

    }
}
