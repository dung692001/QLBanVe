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
    public partial class frmLoaiPhim : Form
    {
        Classes.DataProcess data = new Classes.DataProcess();
        public frmLoaiPhim()
        {
            InitializeComponent();
        }
        void LOAD_DATA_LP()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            DataTable dtLoaiPhim = data.SelectData("Select * from Theloai");
            dgvLoaiPhim.DataSource = dtLoaiPhim;
        }
        void RESET_DATA()
        {
            txtMa.Text = "";
            txtTen.Text = "";
        }
        private void frmLoaiPhim_Load(object sender, EventArgs e)
        {
            LOAD_DATA_LP();
            dgvLoaiPhim.Columns[0].HeaderText = "Mã thể loại";
            dgvLoaiPhim.Columns[1].HeaderText = "Tên thể loại";

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = false;
          
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "" || txtTen.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DataTable dtloai = data.SelectData("select * from Theloai where MaTheLoai='" + txtMa.Text + "'");
                if (dtloai.Rows.Count > 0) MessageBox.Show("Loại phim đã có, mời bạn nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    string sqlInsert = "Insert into Theloai values('" + txtMa.Text + "',N'" + txtTen.Text + "')";
                    data.SelectData(sqlInsert);
                    LOAD_DATA_LP();
                    RESET_DATA();
                }
            }



        }

        private void dgvLoaiPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvLoaiPhim.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvLoaiPhim.CurrentRow.Cells[1].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLamMoi.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "") MessageBox.Show("Bạn chưa nhập đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (MessageBox.Show("Bạn có muốn thay đổi loại phim mã " + txtMa.Text.Trim() + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sqlUpdate = "Update Theloai set TenTheLoai=N'" + txtTen.Text + "' where MaTheLoai='" + txtMa.Text + "'";
                    data.updateData(sqlUpdate);
                    RESET_DATA();
                    LOAD_DATA_LP();
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
            if (MessageBox.Show("Bạn có muốn xóa loại phim mã " + txtMa.Text.Trim() + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "Delete from Theloai where MaTheLoai='" + txtMa.Text + "'";
                data.updateData(sqlDelete);
                LOAD_DATA_LP();
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
