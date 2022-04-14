using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace BTL.ThaoTac
{
    public partial class frmSendCode : Form
    {
        Classes.DataProcess dtbase = new Classes.DataProcess();
        string Email;
        string randomCode;
        private static string username;
        public frmSendCode()
        {
            InitializeComponent();
        }

        private void frmSendCode_Load(object sender, EventArgs e)
        {
            
        }
        bool KiemTraMaNV(string a)
        {
            DataTable dtUser = dtbase.SelectData("Select MaNhanVien,Email from NhanVien where MaNhanVien = '" + a + "'");         
            if(dtUser.Rows.Count <= 0)
            {              
                return false;
            }
            else
            {
                Email = dtUser.Rows[0]["Email"].ToString();
                return true;
            }
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if(KiemTraMaNV(txtMaNV.Text) == true )
            {
                string from, pass, noiDung;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();                     
                from = "SendCode69@gmail.com";
                pass = "085325dung";
                noiDung = "Mã của bạn là " + randomCode;          
                string subject = "Mã để tạo lại mật khẩu";
                MailMessage message = new MailMessage(from, Email, subject, noiDung);
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                 smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Gửi code thành công");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }         
            }
            else
            {
                MessageBox.Show("không tồn tại nhân nhiên có mã là " );
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if(randomCode == (txtCode.Text).ToString())
            {
                username = txtMaNV.Text;
                frmNhapLaiMK rp = new frmNhapLaiMK(username);
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Sai code");
            }
        }
    }
}
