using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
namespace BTL.ThaoTac
{
    public partial class frmNhapLaiMK : Form
    {
        Classes.MaHoa mh = new Classes.MaHoa();
        Classes.DataProcess dtbase = new Classes.DataProcess();
        string username = "";
        public frmNhapLaiMK(string tmp)
        {
            InitializeComponent();
            username = tmp;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có đồng ý đổi mật khẩu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtMKMoi.Text == txtNhapLai.Text)
                {
                    string SauMaHoa = mh.GetHash(txtMKMoi.Text);
                    dtbase.updateData("update NhanVien set MatKhau = '" + SauMaHoa + "' where MaNhanVien = '" + username + "' ");
                    MessageBox.Show("Thay đổi thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("mật khẩu mới không giống nhau, hãy nhập lại");
                }
            }
        }
    }
}
