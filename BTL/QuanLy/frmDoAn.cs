using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmDoAn : Form
    {
        Classes.DataProcess data=new Classes.DataProcess();
        Classes.Function func= new Classes.Function();
        string imageName;
        public frmDoAn()
        {
            InitializeComponent();
        }
        void LOAD_DATA()
        {
            DataTable dtDoAn = data.SelectData("Select * from DoAn");
            dgvDoAn.DataSource = dtDoAn;
        }
        void Reset_Data()
        {
            txtGia.Text = "";
            cboSize.Text = "Chọn size đồ ăn";
            txtMaDA.Text = "";
            txtTenDA.Text = "";
            picDoAn.Image = null;
        }
        private void frmDoAn_Load(object sender, EventArgs e)
        {
            LOAD_DATA();
           
            dgvDoAn.Columns[0].HeaderText = "Mã đồ ăn";
            dgvDoAn.Columns[1].HeaderText = "Size";
            dgvDoAn.Columns[2].HeaderText = "Tên đồ ăn";
            dgvDoAn.Columns[3].HeaderText = "Giá";
            dgvDoAn.Columns[4].HeaderText = "Ảnh";

            btnLamLai.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThemMa.Enabled = true;
            
            
        }

        private void btnThemMa_Click(object sender, EventArgs e)
        {
            
            txtMaDA.Text = func.SinhMaTuDong("DoAn", "DA", "MaDoAn");
            btnThemMa.Enabled = false;
            btnLuu.Enabled = true;
            btnLamLai.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            String[] pathImage;
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "PNG Images|*.png|All Files|*.*";
            dlgOpen.InitialDirectory = Application.StartupPath.ToString() + "\\Images\\DoAn";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picDoAn.Image = Image.FromFile(dlgOpen.FileName);
                pathImage = dlgOpen.FileName.Split('\\');
                imageName = pathImage[pathImage.Length - 1];
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTenDA.Text =="" || txtGia.Text =="" )
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu, mời bạn kiểm tra lại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                string sqlInsert = "Insert into DoAn values('"+txtMaDA.Text+"','"+cboSize.Text+"',N'"+txtTenDA.Text+"','"+ float.Parse( txtGia.Text)+"','"+imageName+"')";
                 data.SelectData(sqlInsert);
                LOAD_DATA();
                Reset_Data();
                btnLamLai.Enabled = false;
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThemMa.Enabled = true;

            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            Reset_Data();
            btnThemMa.Enabled = true;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled=false;
            btnLamLai.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaDA.Text == "") {
                MessageBox.Show("Bạn chưa chọn đồ ăn nào để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn sửa đồ ăn có mã " + txtMaDA.Text.Trim() + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;
                string sqlUpdate = "Update DoAn set TenDoAn=N'" + txtTenDA.Text + "',Gia='" + float.Parse(txtGia.Text) + "',Anh='" + imageName + "' where MaDoAn = '"+txtMaDA.Text+"' ";
                data.updateData(sqlUpdate);
                LOAD_DATA();
                Reset_Data();

                btnLamLai.Enabled = false;
                btnLuu.Enabled = false;
                btnSua.Enabled=false;
                btnXoa.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDA.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn đồ ăn nào để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa đồ ăn có mã " + txtMaDA.Text.Trim()+  " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;
                string sqlDelete = "Delete from DoAn where MaDoAn='"+txtMaDA.Text+"'";
                data.updateData(sqlDelete);
                LOAD_DATA();
                Reset_Data();

                btnLamLai.Enabled = false;
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void dgvDoAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDA.Text = dgvDoAn.CurrentRow.Cells[0].Value.ToString();
            cboSize.Text = dgvDoAn.CurrentRow.Cells[1].Value.ToString();
            txtTenDA.Text = dgvDoAn.CurrentRow.Cells[2].Value.ToString();
       
            txtGia.Text = dgvDoAn.CurrentRow.Cells[3].Value.ToString();
            try
            {
                imageName = dgvDoAn.CurrentRow.Cells[4].Value.ToString();
                picDoAn.Image = Image.FromFile(Application.StartupPath.ToString() + "\\Images\\DoAn\\" + imageName);
            }
            catch
            {

            }
            btnLamLai.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThemMa.Enabled = false;
        }
    }
}
