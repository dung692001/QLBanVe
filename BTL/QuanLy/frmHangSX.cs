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
    public partial class frmHangSX : Form
    {
        Classes.DataProcess data = new Classes.DataProcess();
        public frmHangSX()
        {
            InitializeComponent();
        }
        void LOAD_DATA_HangSX()
        {
            DataTable dtHangSX = data.SelectData("Select * from HangSX");
            dgvHangSX.DataSource = dtHangSX;
        }
        void RESET_DATA()
        {
            txtMa.Text = "";
            txtTen.Text = "";
        }
        private void frmHangSX_Load(object sender, EventArgs e)
        {
            LOAD_DATA_HangSX();
            dgvHangSX.Columns[0].HeaderText = "Mã hãng SX";
            dgvHangSX.Columns[1].HeaderText = "Tên hãng SX";

            dgvHangSX.Columns[0].Width = 100;
            dgvHangSX.Columns[1].Width = 200;


            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = false;
           
        }

        private void dgvHangSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvHangSX.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvHangSX.CurrentRow.Cells[1].Value.ToString();

            
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
                DataTable dtloai = data.SelectData("select * from HangSX where MaHangSX='" + txtMa.Text + "'");
                if (dtloai.Rows.Count > 0) MessageBox.Show("Hãng sản xuất đã có, mời bạn nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    string sqlInsert = "Insert into HangSX values('" + txtMa.Text + "',N'" + txtTen.Text + "')";
                    data.SelectData(sqlInsert);
                    LOAD_DATA_HangSX();
                    RESET_DATA();
                }
            }
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
                string sqlDelete = "Delete from HangSX where MaHangSX='" + txtMa.Text + "'";
                data.updateData(sqlDelete);
                LOAD_DATA_HangSX();
                RESET_DATA();
            }
            btnLamMoi.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "") MessageBox.Show("Bạn chưa nhập đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (MessageBox.Show("Bạn có muốn thay đổi hãng sản xuất mã " + txtMa.Text.Trim() + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sqlUpdate = "Update HangSX set TenHangSX=N'" + txtTen.Text + "' where MaHangSX='" + txtMa.Text + "'";
                    data.updateData(sqlUpdate);
                    RESET_DATA();
                    LOAD_DATA_HangSX();
                }
            }
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = true;
            // btnSua.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }

        
    }
}
