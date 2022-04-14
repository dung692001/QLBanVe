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
    public partial class frmThongTinNV : Form
    {
        Classes.DataProcess data = new Classes.DataProcess();
        Classes.Function func = new Classes.Function();
        Classes.MaHoa mh = new Classes.MaHoa();
        string imageName;
        string marap;
        public frmThongTinNV()
        {
            InitializeComponent();
        }
        void Load_DATA_NhanVien()
        {
            string sqlSelect = "Select * from ThongTin_NhanVien";
            DataTable dtNhanVien = data.SelectData(sqlSelect);
            dgvNhanVien.DataSource = dtNhanVien;

            dgvNhanVien.Columns[13].Visible = false;
        }
        void Load_RapPhim()
        {
            string sqlSelect = "select MaRap,TenRap from RapPhim";
            cboRap.DataSource = data.SelectData(sqlSelect);
            cboRap.DisplayMember = "TenRap";
            cboRap.ValueMember = "MaRap";
            cboRap.Text = "";
        }
        void Reset_NhanVien()
        {
            //cboRap.SelectedIndex = -1;
            cboRap.Text = "";
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSCMND.Text = "";
            txtEmail.Text = "";
            txtDC.Text = "";
            txtDT.Text = "";
            cboChucVu.Text = "";
            cboChucVu.SelectedIndex = -1;
            dateNS.Value = DateTime.Parse("01/01/2000");
            dateNVL.Value = DateTime.Today;
            picAnh.Image = null;
            txtMatKhau.Text = "";
            //  picAnh.Invalidate();


        }
        private void frmThongTinNV_Load(object sender, EventArgs e)
        {
            Load_DATA_NhanVien();
            Load_RapPhim();

            if (cboRap.Text == "") cboRap.Text = "Chọn rạp phim";
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Tên rạp phim";
            dgvNhanVien.Columns[3].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns[4].HeaderText = "Giới tính";
            dgvNhanVien.Columns[5].HeaderText = "Số CMND";
            dgvNhanVien.Columns[6].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[7].HeaderText = "Điện thoại";
            dgvNhanVien.Columns[8].HeaderText = "Email";
            dgvNhanVien.Columns[9].HeaderText = "Chức vụ";
            dgvNhanVien.Columns[10].HeaderText = "Ngày vào làm";
            dgvNhanVien.Columns[11].HeaderText = "Tên Ảnh";
            dgvNhanVien.Columns[12].HeaderText = "Mật khẩu";

            btnSua.Enabled = false;
            btnThemNV.Enabled = false;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = false;
           
        }
        

        private void btnAnh_Click(object sender, EventArgs e)
        {
            String[] pathImage;
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "JPEG Images|*.jpg|All Files|*.*";
            dlgOpen.InitialDirectory = Application.StartupPath.ToString() + "\\Images\\NhanVien";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                pathImage = dlgOpen.FileName.Split('\\');
                imageName = pathImage[pathImage.Length - 1];
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset_NhanVien();
            rdoNam.Checked = false;
            rdoNu.Checked = false;

            txtMaNV.Enabled = true;
            cboRap.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThemNV.Enabled = true;
            btnThemMa.Enabled = true;
        }


        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string GT = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();

            txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            cboRap.Text = "";
            cboRap.SelectedText = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            marap = dgvNhanVien.CurrentRow.Cells[13].Value.ToString();
            dateNS.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();


            if (GT == "Nam") rdoNam.Checked = true;
            else rdoNu.Checked = true;

            txtSCMND.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtDC.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            txtDT.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
            txtEmail.Text = dgvNhanVien.CurrentRow.Cells[8].Value.ToString();
            cboChucVu.Text = dgvNhanVien.CurrentRow.Cells[9].Value.ToString();
            dateNVL.Text = dgvNhanVien.CurrentRow.Cells[10].Value.ToString();
            txtMatKhau.Text = dgvNhanVien.CurrentRow.Cells[12].Value.ToString();
            try
            {
                imageName = dgvNhanVien.CurrentRow.Cells[11].Value.ToString();
                picAnh.Image = Image.FromFile(Application.StartupPath.ToString() + "\\Images\\NhanVien\\" + imageName);
            }
            catch
            {

            }
            txtMaNV.Enabled = false;
            // cboRap.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThemNV.Enabled = false;
            btnLamMoi.Enabled = true;
        }
        bool Check_NV()
        {
            string sqlSelect = "Select * from NhanVien where MaNhanVien= '" + txtMaNV.Text + "'";
            DataTable dtNhanVien = data.SelectData(sqlSelect);
            if (dtNhanVien.Rows.Count > 0) return false;
            else return true;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string SauMaHoa = mh.GetHash(txtMatKhau.Text.ToString());
            if (cboRap.SelectedIndex == -1 || txtMaNV.Text == "" || txtTenNV.Text == "" ||
                txtSCMND.Text == "" || txtEmail.Text == "" || txtDT.Text == "" || txtDC.Text == "" || cboChucVu.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu, mời bạn kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (Check_NV() == false) MessageBox.Show("Nhân viên mã " + txtMaNV.Text.Trim() + " đã có, mời bạn nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    string GT;
                    if (rdoNam.Checked == true) GT = "Nam";
                    else GT = "Nữ";
                    string sqlInsert = "Insert into NhanVien(MaNhanVien ,TenNhanVien, MaRap ,NgaySinh,GioiTinh,SoCMND,DiaChi,DienThoai,Email,ChucVu,NgayVaoLam,Anh,MatKhau) values('" + txtMaNV.Text + "',N'" + txtTenNV.Text + "','" + cboRap.SelectedValue.ToString() + "','" + dateNS.Value + "'" +
                        ",N'" + GT + "','" + txtSCMND.Text + "',N'" + txtDC.Text + "','" + txtDT.Text + "','" + txtEmail.Text + "',N'" + cboChucVu.Text + "','" + dateNVL.Value + "','" + imageName + "','" + SauMaHoa + "')";
                    // string sql = "exec '"+txtMaNV.Text+"', ";
                    // marap = cboRap.SelectedValue.ToString();
                    data.updateData(sqlInsert);
                    Load_DATA_NhanVien();
                    Reset_NhanVien();




                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string SauMaHoa = mh.GetHash(txtMatKhau.Text.ToString());
            if (txtTenNV.Text == "" || txtSCMND.Text == "" || txtEmail.Text == "" || txtDT.Text == "" || txtDC.Text == "" || cboChucVu.Text == "")
                MessageBox.Show("Bạn chưa thêm đủ dữ liệu, mời bạn kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (MessageBox.Show("Bạn có muốn thay đổi thông tin nhân viên mã " + txtMaNV.Text.Trim() + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;
                string GT;
                if (rdoNam.Checked == true) GT = "Nam";
                else GT = "Nữ";

                string sqlUpdate = "Update NhanVien set TenNhanVien= N'" + txtTenNV.Text + "',MaRap='" + marap + "',NgaySinh='" + dateNS.Text + "',GioiTinh=N'" + GT + "',SoCMND='" + txtSCMND.Text + "',DiaChi=N'" + txtDC.Text + "',DienThoai='" + txtDT.Text + "',Email='" + txtEmail.Text + "',ChucVu=N'" + cboChucVu.Text + "',NgayVaoLam='" + dateNVL.Text + "',Anh= '" + imageName + "',MatKhau='" + SauMaHoa + "' where MaNhanVien = '" + txtMaNV.Text + "'";
                data.updateData(sqlUpdate);
                Load_DATA_NhanVien();
                Reset_NhanVien();
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sqlSelect = "Select MaNhanVien,TenNhanVien,TenRap,NgaySinh,GioiTinh,SoCMND,NhanVien.DiaChi,NhanVien.DienThoai,Email,ChucVu,NgayVaoLam,Anh from NhanVien join RapPhim on NhanVien.MaRap= RapPhim.MaRap where MaNhanVien is not null";
            if (txtTimKiem.Text != "")
                sqlSelect += " and MaNhanVien like '%" + txtTimKiem.Text + "%' or TenNhanVien Like '%" + txtTimKiem.Text + "%' or TenRap Like '%" + txtTimKiem.Text + "%'";
            dgvNhanVien.DataSource = data.SelectData(sqlSelect);
        }

        void KeyPress_NhapChu(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn không được nhập số hay bất cứ kí tự đặc biệt nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "") MessageBox.Show("Bạn chưa chọn nhân viên nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa nhân viên mã " + txtMaNV.Text.Trim() + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string sqpDelete = "Delete from NhanVien where MaNhanVien = '" + txtMaNV.Text + "' ";

                    data.updateData(sqpDelete);
                    Load_DATA_NhanVien();
                    Reset_NhanVien();
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
            }
        }

        private void cboRap_SelectionChangeCommitted(object sender, EventArgs e)
        {
            marap = cboRap.SelectedValue.ToString();
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnThemRap_Click(object sender, EventArgs e)
        {
            QuanLy.frmRapChieuPhim rf = new QuanLy.frmRapChieuPhim();
            rf.FormBorderStyle = FormBorderStyle.None;
            rf.ShowDialog();
        }

        private void btnThemMa_Click(object sender, EventArgs e)
        {
            
            txtMaNV.Text = func.SinhMaTuDong("NhanVien", "NV", "MaNhanVien");
            btnThemNV.Enabled = true;
            btnThemMa.Enabled = false;
            btnLamMoi.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

     
    }
}
