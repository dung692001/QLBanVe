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
    public partial class frmPhongChieuPhim : Form
    {
        Classes.DataProcess dtBase = new Classes.DataProcess();
        Classes.Functions ft = new Classes.Functions();
        public frmPhongChieuPhim()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            dgvPhong.DataSource = dtBase.SelectData("Select MaPhong , TenPhong , RapPhim.TenRap  , PhongChieu.TongGhe from PhongChieu join RapPhim " +
                "on PhongChieu.MaRap = RapPhim.MaRap");

        }

        private void PhongChieuPhim_Load(object sender, EventArgs e)
        {
            //đỔ vào listbox
            lstTenRap.DataSource = dtBase.SelectData("Select * from RapPhim");
            lstTenRap.DisplayMember = "TenRap";
            lstTenRap.ValueMember = "MaRap";

            LoadData();
            dgvPhong.Dock = DockStyle.Fill;
            dgvPhong.Columns[0].HeaderText = "Mã Phòng";
            dgvPhong.Columns[1].HeaderText = "Tên Phòng";
            dgvPhong.Columns[2].HeaderText = "Tên Rạp";
            dgvPhong.Columns[3].HeaderText = "Tổng Số Ghế";
            dgvPhong.Columns[2].Width = 150;
            dgvPhong.Height = 1000;
            ResetValue();
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTim.Enabled = false;
        }

        void ResetValue()
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtTongGhe.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = ft.SinhMaTuDong("PhongChieu", "PC", "MaPhong");
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int a;
            string sqlInsert;
            if (txtTenPhong.Text == "")
            {
                MessageBox.Show("Không được để trống!");
            }

            if (!int.TryParse(txtTongGhe.Text, out a))
            {
                MessageBox.Show("Tổng ghế phải là số");
                txtTongGhe.Text = "";
                txtTongGhe.Focus();
                return;
            }

            //Ktra có trùng mã không?
            sqlInsert = "Insert into PhongChieu values('" + txtMaPhong.Text + "', '" + lstTenRap.SelectedValue.ToString() + "' ,N'" + txtTenPhong.Text + "','" + txtTongGhe.Text + "')";
            dtBase.updateData(sqlInsert);
            LoadData();
            ResetValue();
            btnThem.Enabled = true;

        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhong.Text = dgvPhong.CurrentRow.Cells[0].Value.ToString();
            txtTenPhong.Text = dgvPhong.CurrentRow.Cells[1].Value.ToString();
            lstTenRap.Text = dgvPhong.CurrentRow.Cells[2].Value.ToString();
            txtTongGhe.Text = dgvPhong.CurrentRow.Cells[3].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void lstTenRap_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPhong.DataSource = dtBase.SelectData("Select MaPhong , TenPhong , RapPhim.TenRap  , PhongChieu.TongGhe from PhongChieu join RapPhim " +
              "on PhongChieu.MaRap = RapPhim.MaRap where RapPhim.MaRap = '" + lstTenRap.SelectedValue.ToString() + "' ");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Xóa",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtBase.updateData("delete PhongChieu where MaPhong='" + txtMaPhong.Text + "'");
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlUpdate = " Update PhongChieu set ";
            sqlUpdate += "TenPhong = N'" + txtTenPhong.Text + "',";
            sqlUpdate += "MaRap = '" + lstTenRap.SelectedValue.ToString() + "', ";
            sqlUpdate += "TongGhe = '" + txtTongGhe.Text + "' ";
            sqlUpdate += "where MaPhong = '" + txtMaPhong.Text + "'";
            
            dtBase.updateData(sqlUpdate);
            LoadData();
            ResetValue();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sqlSelect = "Select MaPhong , TenPhong , RapPhim.TenRap  , PhongChieu.TongGhe from PhongChieu join RapPhim " +
                "on PhongChieu.MaRap = RapPhim.MaRap where MaPhong is not null";
            if (txtTim.Text.Trim() != "")
            {
                sqlSelect += " and (MaPhong like '%" + txtTim.Text + "%' or TenPhong like '%" + txtTim.Text + "%' or TenRap like '%" + txtTim.Text + "%')";
                dgvPhong.DataSource = dtBase.SelectData(sqlSelect);
            }
        }

        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            btnTim.Enabled = true;
        }

    }
}
