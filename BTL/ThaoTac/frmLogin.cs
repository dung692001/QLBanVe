using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace BTL.ThaoTac
{


    public partial class frmLogin : Form
    {
        Classes.DataProcess dtbase = new Classes.DataProcess();
        Classes.MaHoa mh = new Classes.MaHoa();
        public int kiemTra = 0;
        public string Ten = "";
        public string Chuc = "";
        public string Ma = "";
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "" || txtMK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập hoặc mật khẩu");
            }
            else
            {          
                string SauMaHoa = mh.GetHash(txtMK.Text.ToString());
                //MessageBox.Show(SauMaHoa);
                DataTable dtUser = dtbase.SelectData("select MaNhanVien, TenNhanVien, MatKhau, ChucVu from NhanVien " +
                    "where MaNhanVien = '" + txtTenDN.Text + "' and MatKhau = '" + SauMaHoa.Trim() + "'");
                if (dtUser.Rows.Count > 0)
                {
                    kiemTra = 1;
                    Ten = dtUser.Rows[0]["TenNhanVien"].ToString();
                    Chuc = dtUser.Rows[0]["ChucVu"].ToString();
                    Ma = dtUser.Rows[0]["MaNhanVien"].ToString();
                    txtTenDN.Text = "";
                    txtMK.Text = "";
                    //MessageBox.Show(Ma);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!!");
                    txtTenDN.Focus();
                }
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenDN.Text = "";
            txtMK.Text = "";
        }

        private void lbQuen_Click(object sender, EventArgs e)
        {
            frmSendCode sc = new frmSendCode();
            sc.Show();
            //this.Close();
            
        }

    }
}
