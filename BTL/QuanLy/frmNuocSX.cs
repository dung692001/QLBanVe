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
    public partial class frmNuocSX : Form
    {
        Classes.DataProcess data = new Classes.DataProcess();
        public frmNuocSX()
        {
            InitializeComponent();
        }
        void LOAD_DATA_NuocSX()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            DataTable dtNuocSX = data.SelectData("Select * from NuocSanXuat");
            dgvNuocSX.DataSource = dtNuocSX;
        }
        void RESET_DATA()
        {
            txtMa.Text = "";
            txtTen.Text = "";
        }
        private void frmNuocSX_Load(object sender, EventArgs e)
        {
            LOAD_DATA_NuocSX();
            dgvNuocSX.Columns[0].HeaderText = "Mã nước SX";
            dgvNuocSX.Columns[1].HeaderText = "Tên nước SX";

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = false;
            //btnThem.Image = Image.FromFile(Application.StartupPath.ToString() + "\\Images\\Icon\\add.png");
            //btnSua.Image = Image.FromFile(Application.StartupPath.ToString() + "\\Images\\Icon\\edit.png");
            //btnLamMoi.Image = Image.FromFile(Application.StartupPath.ToString() + "\\Images\\Icon\\reset.png");
            //btnThoat.Image = Image.FromFile(Application.StartupPath.ToString() + "\\Images\\Icon\\btnExit.png");
            //btnXoa.Image = Image.FromFile(Application.StartupPath.ToString() + "\\Images\\Icon\\delete.png");
        }

        private void dgvNuocSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvNuocSX.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvNuocSX.CurrentRow.Cells[1].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLamMoi.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "" || txtTen.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DataTable dtloai = data.SelectData("select * from NuocSanXuat where NuocSX='" + txtMa.Text + "'");
                if (dtloai.Rows.Count > 0) MessageBox.Show("Nước sản xuất đã có, mời bạn nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    string sqlInsert = "Insert into NuocSanXuat values('" + txtMa.Text + "',N'" + txtTen.Text + "')";
                    data.SelectData(sqlInsert);
                    LOAD_DATA_NuocSX();
                    RESET_DATA();
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "") MessageBox.Show("Bạn chưa nhập đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (MessageBox.Show("Bạn có muốn thay đổi nước sản xuất mã " + txtMa.Text.Trim() + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sqlUpdate = "Update NuocSanXuat set TenNuocSX=N'" + txtTen.Text + "' where NuocSX='" + txtMa.Text + "'";
                    data.updateData(sqlUpdate);
                    RESET_DATA();
                    LOAD_DATA_NuocSX();
                }
            }
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = true;
            // btnSua.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            RESET_DATA();
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nước có mã " + txtMa.Text.Trim() + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "Delete from NuocSanXuat where NuocSX='" + txtMa.Text + "'";
                data.updateData(sqlDelete);
                LOAD_DATA_NuocSX();
                RESET_DATA();
            }
            btnLamMoi.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }
    }
}
