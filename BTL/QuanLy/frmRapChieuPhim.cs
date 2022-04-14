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
    public partial class frmRapChieuPhim : Form
    {
        Classes.DataProcess dtBase = new Classes.DataProcess();
        Classes.Functions ft = new Classes.Functions();
        public frmRapChieuPhim()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            dgvRap.DataSource = dtBase.SelectData("Select RapPhim.MaRap , TenRap , RapPhim.DiaChi ,RapPhim.DienThoai , SoPhong , TongSoGhe  from RapPhim ");
        }

        void ResetValue()
        {
            txtMaRap.Text = "";
            txtTenRap.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtSoPhong.Text = "";
            txtSoGhe.Text = "";
        }

        private void RapChieuPhim_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvRap.Columns[0].HeaderText = "Mã Rạp";
            dgvRap.Columns[1].HeaderText = "Tên Rạp";
            dgvRap.Columns[2].HeaderText = "Địa Chỉ";
            dgvRap.Columns[3].HeaderText = "Điện Thoại";
            dgvRap.Columns[4].HeaderText = "Tổng Số Phòng";
            dgvRap.Columns[5].HeaderText = "Tổng Số Ghế";

            dgvRap.Columns[0].Width = 80;
            dgvRap.Columns[1].Width = 150;
            dgvRap.Columns[2].Width = 200;
            dgvRap.Columns[3].Width = 80;
            dgvRap.Columns[4].Width = 80;
            dgvRap.Columns[5].Width = 80;


            ResetValue();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTim.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaRap.Text = ft.SinhMaTuDong("RapPhim", "RP", "MaRap");
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
        }
        void check()
        {
            int a;
            if (txtMaRap.Text == "" || txtTenRap.Text == "" || txtDiaChi.Text == "" ||
                txtDienThoai.Text == "" || txtSoPhong.Text == "" || txtSoGhe.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu");
                return;
            }
            if (!int.TryParse(txtDienThoai.Text, out a))
            {
                MessageBox.Show("Điện thoại phải là số");
                txtDienThoai.Text = "";
                txtDienThoai.Focus();
                return;
            }
            if (!int.TryParse(txtSoPhong.Text, out a))
            {
                MessageBox.Show("Số phòng phải là số");
                txtSoPhong.Text = "";
                txtSoPhong.Focus();
                return;
            }
            if (!int.TryParse(txtSoGhe.Text, out a))
            {
                MessageBox.Show("Số ghế phải là số");
                txtSoGhe.Text = "";
                txtSoGhe.Focus();
                return;
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            DataTable dtRap;
            string sqlInsert;
            check();

            //Ktra có trùng mã không?
            dtRap = dtBase.SelectData("Select * from RapPhim where MaRap = '" + txtMaRap.Text + "'");
            if (dtRap.Rows.Count > 0)
            {
                MessageBox.Show("Mã rạp này đã có, mời bạn nhập mã khác");
                txtMaRap.Focus();
                return;
            }
            sqlInsert = "Insert into RapPhim values('" + txtMaRap.Text + "', N'" + txtTenRap.Text + "', N'" + txtDiaChi.Text + "','" + txtDienThoai.Text + "','" + txtSoPhong.Text + "','" + txtSoGhe.Text + "')";
            dtBase.updateData(sqlInsert);
            LoadData();
            btnThem.Enabled = true;
            ResetValue();
        }

        private void dgvRap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaRap.Text = dgvRap.CurrentRow.Cells[0].Value.ToString();
            txtTenRap.Text = dgvRap.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvRap.CurrentRow.Cells[2].Value.ToString();
            txtDienThoai.Text = dgvRap.CurrentRow.Cells[3].Value.ToString();
            txtSoPhong.Text = dgvRap.CurrentRow.Cells[4].Value.ToString();
            txtSoGhe.Text = dgvRap.CurrentRow.Cells[5].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            check();
            string sqlUpdate = " Update RapPhim set ";
            sqlUpdate += "TenRap = N'" + txtTenRap.Text + "',";
            sqlUpdate += "DiaChi = N'" + txtDiaChi.Text + "',";
            sqlUpdate += "DienThoai = '" + txtDienThoai.Text + "',";
            sqlUpdate += "SoPhong = '" + txtSoPhong.Text + "',";
            sqlUpdate += "TongSoGhe = '" + txtSoGhe.Text + "' ";
            sqlUpdate += "where MaRap = '" + txtMaRap.Text + "'";
            dtBase.updateData(sqlUpdate);
            LoadData();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            ResetValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Xóa",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtBase.updateData("delete RapPhim where MaRap = '" + txtMaRap.Text + "'");
                LoadData();
                ResetValue();
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            btnThem.Enabled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sqlSelect = "Select * from RapPhim where MaRap is not null ";
            if (txtTim.Text.Trim() != "")
            {
                sqlSelect += " and (MaRap like '%" + txtTim.Text + "%' or TenRap like '%" + txtTim.Text + "%')";
                dgvRap.DataSource = dtBase.SelectData(sqlSelect);
            }
        }

        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            btnTim.Enabled = true;
        }
    }
}
