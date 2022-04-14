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
    public partial class Form1 : Form
    {
        private Form activeForm;
        private Button currentButton;      
        ThaoTac.frmLogin frmDN = new ThaoTac.frmLogin();
        
        public Form1()
        {
            InitializeComponent();
        }
        void HienNV(bool a)
        {
            btnDangXuat.Enabled = a;
            btnDoiMK.Enabled = a;
            btnDatVe.Visible = a;
            btnRapChieu.Visible = a;
            btnPhongChieu.Visible = a;
            btnLichChieu.Visible = a;
            btnQLPhim.Visible = a;
            btnLuongNV.Visible = a;
            btnNhanVien.Visible = a;
            btnThuPhim.Visible = a;
            btnThang.Visible = a;
            btnDatDoAn.Visible = a;
            btnDoanhThuNam.Visible = a;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            OpenChildForm(new ThaoTac.frmTrangChu(), null);
            btnTrangChu.BackColor = Color.PaleTurquoise;
            try
            {
                btnDangNhap.Image = Image.FromFile(Application.StartupPath + "\\Images\\Icon\\login.png");
                btnDangXuat.Image = Image.FromFile(Application.StartupPath + "\\Images\\Icon\\logout.png");
                btnThoat.Image = Image.FromFile(Application.StartupPath + "\\Images\\Icon\\btnExit.png");
                btnDoiMK.Image = Image.FromFile(Application.StartupPath + "\\Images\\Icon\\password.png");
            }
            catch
            {

            }
            btnDangNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangNhap.TextAlign = ContentAlignment.MiddleRight;
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.TextAlign = ContentAlignment.MiddleRight;
            btnDoiMK.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoiMK.TextAlign = ContentAlignment.MiddleRight;
            HienNV(false);

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            label1.Text = childForm.Text;
            this.panelTC.Controls.Add(childForm);
            this.panelTC.Tag = childForm;
            //childForm.BringToFront();
            childForm.Show();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.PaleTurquoise;
                    currentButton.ForeColor = Color.Black;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in gbButton.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Cornsilk;
                    previousBtn.ForeColor = Color.Black;
                }
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmDN.ShowDialog();
            if (frmDN.kiemTra == 1)
            {
                btnDangNhap.Enabled = false;
                btnDangNhap.Text = frmDN.Ten;
                btnDangNhap.AutoSize = true;
                if (frmDN.Chuc == "Quản Lý")
                {
                    HienNV(true);
                    OpenChildForm(new ThaoTac.frmTrangChu(), sender);
                }
                if (frmDN.Chuc == "Bán Vé")
                {
                    HienNV(false);
                    btnDatVe.Visible = true;
                    btnDatDoAn.Visible = true;
                    btnDangXuat.Enabled = true;
                    OpenChildForm(new ThaoTac.frmTrangChu(), sender);
                }
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnDangNhap.Enabled = true;
                frmDN = new ThaoTac.frmLogin();
                HienNV(false);
                btnDangNhap.Text = "Đăng nhập";
                OpenChildForm(new ThaoTac.frmTrangChu(), sender);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {          
            ThaoTac.frmNhapLaiMK doiMK = new ThaoTac.frmNhapLaiMK(frmDN.Ma);
            doiMK.Show();
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThaoTac.frmTrangChu(), sender);  
        }

        private void btnPhim_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThaoTac.frmPhim(frmDN.kiemTra), sender);
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThaoTac.frmDatVe(""), sender);
        }

        private void btnRapChieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLy.frmRapChieuPhim(), sender);
        }

        private void btnPhongChieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLy.frmPhongChieuPhim(), sender);
        }

        private void btnLichChieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLy.frmLichChieuPhim(), sender);
        }

        private void btnQLPhim_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLy.frmThongTinPhim(), sender);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLy.frmThongTinNV(), sender);
        }

        private void btnLuongNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLy.frmLuongNV(), sender);
        }
        private void btnDoanhThuNam_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe.DoanhThuNam(), sender);
        }
        private void btnThang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe.DoanhThu(), sender);
        }

        private void btnThuPhim_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe.DoanhThuTheoPhim(), sender);
        }
        private void btnDatDoAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLy.frmHDDA(), sender);
        }

        
    }
}
