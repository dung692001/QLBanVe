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
    public partial class frmLichChieuPhim : Form
    {
        Classes.DataProcess dtBase = new Classes.DataProcess();
        Classes.Functions ft = new Classes.Functions();
        public frmLichChieuPhim()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            dgvLichChieu.DataSource = dtBase.SelectData("Select MaBuoiChieu , RapPhim.TenRap , PhongChieu.TenPhong , Phim.TenPhim , BuoiChieu.NgayChieu ," +
                "BuoiChieu.GioChieu from BuoiChieu join RapPhim on BuoiChieu.MaRap = RapPhim.MaRap join PhongChieu on BuoiChieu.MaPhong = PhongChieu.MaPhong " +
                "join Phim on BuoiChieu.MaPhim = Phim.MaPhim");
        }

        void ResetValue()
        {
            txtMaBC.Text = "";
            cboRap.Text = "";
            cboPhong.Text = "";
            cboPhim.Text = "";
            cboGio.Text = "";
            dtpNgay.Value = DateTime.Today;
        }

        private void frmLichChieuPhim_Load(object sender, EventArgs e)
        {
            //Đổ dữ liệu ra các comboBox
            DataTable dtRap = dtBase.SelectData("Select * from RapPhim");

            ft.FillCombo(cboRap, dtRap, "TenRap", "MaRap");

            DataTable dtPhim = dtBase.SelectData("Select * from Phim");
            ft.FillCombo(cboPhim, dtPhim, "TenPhim", "MaPhim");

            LoadData();
            dgvLichChieu.Columns[0].HeaderText = "Mã Buổi Chiếu";
            dgvLichChieu.Columns[1].HeaderText = "Tên Rạp Phim";
            dgvLichChieu.Columns[2].HeaderText = "Tên Phòng Chiếu";
            dgvLichChieu.Columns[3].HeaderText = "Tên Phim";
            dgvLichChieu.Columns[4].HeaderText = "Ngày Chiếu";
            dgvLichChieu.Columns[5].HeaderText = "Giờ Chiếu";
            dgvLichChieu.Columns[1].Width = 150;
            dgvLichChieu.Columns[3].Width = 180;

            ResetValue();
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTim.Enabled = false;
        }

        private void cboRap_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtPhong = dtBase.SelectData("Select PhongChieu.MaPhong , TenPhong from PhongChieu where MaRap = '" + cboRap.SelectedValue.ToString() + "'");
            if (dtPhong.Rows.Count == 0)
            {
                cboPhong.DisplayMember = "";
            }
            ft.FillCombo(cboPhong, dtPhong, "TenPhong", "MaPhong");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaBC.Text = ft.SinhMaTuDong("BuoiChieu", "BC", "MaBuoiChieu");
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvLichChieu.Rows.Count - 1; i++)
            {
                if (dgvLichChieu.Rows[i].Cells[1].Value.ToString() == cboRap.Text &&
                   dgvLichChieu.Rows[i].Cells[2].Value.ToString() == cboPhong.Text &&
                   //dgvLichChieu.Rows[i].Cells[3].Value.ToString() == cboPhim.Text &&
                   (DateTime)dgvLichChieu.Rows[i].Cells[4].Value == dtpNgay.Value &&
                   dgvLichChieu.Rows[i].Cells[5].Value.ToString() == cboGio.Text)
                {
                    MessageBox.Show("Thời gian này đã chiếu phim");
                    return;
                }
            }
            int gia;
            if (cboRap.Text == "" || cboPhong.Text == "" || cboPhim.Text == "" || cboGio.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu");
                return;
            }
            if (int.Parse(cboGio.Text) < 17)
            {
                gia = 70000;
            }
            else
            {
                gia = 90000;
            }
            string sqlInsert = "Insert into BuoiChieu values('" + txtMaBC.Text + "' , '" + cboPhim.SelectedValue.ToString() + "' , '" + cboRap.SelectedValue.ToString() + "' ," +
                "'" + cboPhong.SelectedValue.ToString() + "' , '" + dtpNgay.Value.ToString("yyyy-MM-dd") + "' , '" + cboGio.Text + "','" + gia + "',null,null)";
            dtBase.updateData(sqlInsert);

            MessageBox.Show("THÊM THÀNH CÔNG");
            LoadData();
            ResetValue();
            btnThem.Enabled = true;
        }

        private void dgvLichChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaBC.Text = dgvLichChieu.CurrentRow.Cells[0].Value.ToString();
                cboRap.Text = dgvLichChieu.CurrentRow.Cells[1].Value.ToString();
                cboPhong.Text = dgvLichChieu.CurrentRow.Cells[2].Value.ToString();
                cboPhim.Text = dgvLichChieu.CurrentRow.Cells[3].Value.ToString();
                dtpNgay.Value = (DateTime)dgvLichChieu.CurrentRow.Cells[4].Value;
                cboGio.Text = dgvLichChieu.CurrentRow.Cells[5].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
                btnLuu.Enabled = false;
            }
            catch
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvLichChieu.Rows.Count - 1; i++)
            {
                if (dgvLichChieu.Rows[i].Cells[1].Value.ToString() == cboRap.Text &&
                   dgvLichChieu.Rows[i].Cells[2].Value.ToString() == cboPhong.Text &&
                   //dgvLichChieu.Rows[i].Cells[3].Value.ToString() == cboPhim.Text &&
                   (DateTime)dgvLichChieu.Rows[i].Cells[4].Value == dtpNgay.Value &&
                   dgvLichChieu.Rows[i].Cells[5].Value.ToString() == cboGio.Text)
                {
                    MessageBox.Show("Thời gian này đã chiếu phim");
                    return;
                }
            }
            string sqlUpdate = "Update BuoiChieu set ";
            sqlUpdate += "MaRap = '" + cboRap.SelectedValue.ToString() + "' , ";
            sqlUpdate += "MaPhong = '" + cboPhong.SelectedValue.ToString() + "' , ";
            sqlUpdate += "MaPhim = '" + cboPhim.SelectedValue.ToString() + "' , ";
            sqlUpdate += "NgayChieu = '" + dtpNgay.Value.ToString("yyyy-MM-dd") + "' ,";
            sqlUpdate += "GioChieu = '" + cboGio.Text + "' ";
            sqlUpdate += " where MaBuoiChieu = N'" + txtMaBC.Text + "'";
            dtBase.updateData(sqlUpdate);
            LoadData();
            ResetValue();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Xóa",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtBase.updateData("delete BuoiChieu where MaBuoiChieu='" + txtMaBC.Text + "'");
                LoadData();
                ResetValue();
            }
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sqlSelect = "Select MaBuoiChieu , RapPhim.TenRap , PhongChieu.TenPhong , Phim.TenPhim , BuoiChieu.NgayChieu ," +
                "BuoiChieu.GioChieu from BuoiChieu join RapPhim on BuoiChieu.MaRap = RapPhim.MaRap join PhongChieu on BuoiChieu.MaPhong = PhongChieu.MaPhong " +
                "join Phim on BuoiChieu.MaPhim = Phim.MaPhim where MaBuoiChieu is not null ";
            if (txtTim.Text.Trim() != "")
            {
                sqlSelect += " and (MaBuoiChieu like '%" + txtTim.Text + "%' or RapPhim.TenRap like N'%" + txtTim.Text + "%' " +
                    "or PhongChieu.TenPhong  like N'%" + txtTim.Text + "%' or Phim.TenPhim  like N'%" + txtTim.Text + "%')";
                dgvLichChieu.DataSource = dtBase.SelectData(sqlSelect);
            }
            else
            {
                LoadData();
            }

        }

        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            btnTim.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLy.frmPhongChieuPhim pc = new QuanLy.frmPhongChieuPhim();
            pc.ShowDialog();
            DataTable dtPhong = dtBase.SelectData("Select PhongChieu.MaPhong , TenPhong from PhongChieu where MaRap = '" + cboRap.SelectedValue.ToString() + "'");
            ft.FillCombo(cboPhong, dtPhong, "TenPhong", "MaPhong");
            cboPhong.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLy.frmRapChieuPhim rc = new QuanLy.frmRapChieuPhim();
            rc.ShowDialog();
            DataTable dtRap = dtBase.SelectData("Select MaRap , TenRap from RapPhim ");
            ft.FillCombo(cboRap, dtRap, "TenRap", "MaRap");
            cboRap.Text = "";
        }
    }
}
