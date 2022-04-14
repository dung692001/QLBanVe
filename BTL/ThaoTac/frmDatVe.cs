using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.ThaoTac
{
    public partial class frmDatVe : Form
    {
        string rap, phim, ngay, gio, sqlSelect, sqlLayBCTG, maBC, anh, MaPhim, tmp = "";
        string[] sqlInsert = new string[300];
        int TongGhe = 0, count = 0;
        string a = "Insert into Ve(MaVe, MaBuoiChieu, HangGhe, SoGhe) values ";
        Button btn;
        Classes.DataProcess dtbase = new Classes.DataProcess();
        DataTable dtGhe = new DataTable();
        DataTable dtVe = new DataTable();
        public frmDatVe(string ma)
        {
            InitializeComponent();
            MaPhim = ma;
        }
        void hienThiPhim()
        {
            cboPhim.DataSource = dtbase.SelectData("Select MaPhim, TenPhim from Phim ");
            cboPhim.DisplayMember = "TenPhim";
            cboPhim.ValueMember = "MaPhim";         
            cboPhim.Text = "";
            ThayPhim();          
            //cboRap.Enabled = true;


        }
        void hienThiRap(string a)
        {
            cboRap.Enabled = true;
            cboRap.DataSource = dtbase.SelectData("select distinct  RapPhim.MaRap, TenRap from RapPhim join BuoiChieu on RapPhim.MaRap = BuoiChieu.MaRap where MaPhim like '%" + a + "%'");
            cboRap.DisplayMember = "TenRap";
            cboRap.ValueMember = "MaRap";
            cboRap.Text = "";         
            if (cboRap.SelectedIndex != -1)
            {
                ThayRap();
                
                //cboNgay.Enabled = false;      
            }
            else
            {
                MessageBox.Show("Phim chưa được chiếu tại rạp nào");
                cboRap.Enabled = false;
                cboNgay.Enabled = false;
                cboGio.Enabled = false;
                cboNgay.Text = "";
                cboGio.Text = "";
            }

        }

        void hienThiNgay(string a, string b)
        {
            cboNgay.Enabled = true;
            cboNgay.DataSource = dtbase.SelectData("Select distinct NgayChieu from BuoiChieu where MaRap like '%" + a + "%' and MaPhim like '%" + b + "%'");
            cboNgay.DisplayMember = "NgayChieu";
            cboNgay.ValueMember = "NgayChieu";
            cboNgay.Text = "";       
            if (cboNgay.SelectedIndex != -1)
            {
                ThayNgay();
                
                //cboGio.Enabled = false;
            }
            else
            {
                //MessageBox.Show("Phim chưa được chiếu tại rạp này");
                cboNgay.Enabled = false;
            }


        }
        void hienThiGio(string a, string b, string c)
        {
            cboGio.Enabled = true;
            cboGio.DataSource = dtbase.SelectData("Select distinct GioChieu from BuoiChieu where  MaRap like '%" + a + "%' and MaPhim like '%" + b + "%' and NgayChieu like '%" + c + "%'");
            cboGio.DisplayMember = "GioChieu";
            cboGio.ValueMember = "GioChieu";
            cboGio.Text = "";
            if (cboGio.SelectedIndex != -1)
            {
                ThayGio();
            }
            else
            {
                cboGio.Enabled = false;
            }
        }
        void ThayRap()
        {
            rap = cboRap.SelectedValue.ToString();
        }

        void ThayPhim()
        {
            phim = cboPhim.SelectedValue.ToString();
        }

        void ThayNgay()
        {
            string x = cboNgay.SelectedValue.ToString();
            string[] y = x.Split(' ');
            string[] z = y[0].Split('/');
            if (z[0].Length == 1)
                z[0] = '0' + z[0];
            if (z[1].Length == 1)
                z[1] = '0' + z[1];
            ngay = z[2] + '-' + z[0] + "-" + z[1];

        }

        void ThayGio()
        {
            gio = cboGio.SelectedValue.ToString();
        }

        private void cboPhim_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            ThayPhim();
            LayAnh(phim);
            picAnh.Image = Image.FromFile(Application.StartupPath + "\\Images\\AnhPhim\\" + anh);
            cboRap.Enabled = false;
            cboNgay.Enabled = false;
            cboGio.Enabled = false;
            cboNgay.Text = "";
            cboGio.Text = "";
            tmp = "";
            hienThiRap(phim);
            gbGhe.Controls.Clear();
        }
        private void cboRap_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            ThayRap();
            cboGio.Enabled = false;
            cboGio.Text = "";
            tmp = "";
            hienThiNgay(rap, phim);
            //hienThiGio(rap, phim, ngay);
            //loadData(rap, phim, ngay, gio);
            gbGhe.Controls.Clear();
        }


        private void cboNgay_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ThayNgay();
            tmp = "";
            hienThiGio(rap, phim, ngay);
            //loadData(rap, phim, ngay, gio);
            gbGhe.Controls.Clear();
        } 

        private void cboGio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            if (gio != tmp)
            {
                ThayGio();
                loadData(rap, phim, ngay, gio);
                LayMaBuoiChieuTongGhe(rap, phim, ngay, gio);       
                //MessageBox.Show(TongGhe.ToString());
                //TongGhe = int.Parse(dgvThongTin.Rows[0].Cells[9].Value.ToString());           
                sqlInsert = new string[300];
                //MessageBox.Show(gbGhe.Size.ToString());
                ResetGhe();
                
            }
            tmp = gio;
        }

        void LayMaBuoiChieuTongGhe(string rap, string phim, string ngay, string gio)
        {
            sqlLayBCTG = "select BuoiChieu.MaBuoiChieu, TongGhe "
            + " from Phim join BuoiChieu on Phim.MaPhim = BuoiChieu.MaPhim "
            + " join PhongChieu on BuoiChieu.MaPhong = PhongChieu.MaPhong "
            + "Where BuoiChieu.MaRap like '%" + rap + "%'" + " and BuoiChieu.MaPhim like '%" + phim + "%'"
            + " and NgayChieu like '%" + ngay + "%'" + " and GioChieu like '%" + gio + "%'";
            DataTable dtBC = dtbase.SelectData(sqlLayBCTG);
            TongGhe = int.Parse(dtBC.Rows[0]["TongGhe"].ToString());
            maBC = dtBC.Rows[0]["MaBuoiChieu"].ToString();

        }
        void LayAnh(string phim)
        {
            string sqlLayAnh = "Select Anh from Phim where MaPhim = N'" + phim.Trim() + "'";
            //MessageBox.Show(sqlLayAnh);
            DataTable dtAnh = dtbase.SelectData(sqlLayAnh);
            anh = dtAnh.Rows[0]["Anh"].ToString();
            //MessageBox.Show(anh);
        }

        void loadData(string rap, string phim, string ngay, string gio)
        {
            sqlSelect = "select MaVe, TenPhim, NgayChieu, GioChieu, HangGhe, SoGhe, LoaiGhe, TienVe, TongGhe "
            + " from Phim join BuoiChieu on Phim.MaPhim = BuoiChieu.MaPhim "
            + " join Ve on BuoiChieu.MaBuoiChieu = Ve.MaBuoiChieu "
            + " join PhongChieu on BuoiChieu.MaPhong = PhongChieu.MaPhong "
            + "Where BuoiChieu.MaRap like '%" + rap + "%'" + " and BuoiChieu.MaPhim like '%" + phim + "%'"
            + " and NgayChieu like '%" + ngay + "%'" + " and GioChieu like '%" + gio + "%'";
            dtVe = dtbase.SelectData(sqlSelect);
            dgvThongTin.DataSource = dtVe;
        }
        private void frmDatVe_Load(object sender, EventArgs e)
        {
            loadData(rap, phim, ngay, gio);
            if(MaPhim == "")
            {
                hienThiPhim();
                cboRap.Enabled = false;             
            }
            else
            {             
                cboPhim.DataSource = dtbase.SelectData("Select MaPhim, TenPhim from Phim where MaPhim = '" + MaPhim + "'");
                cboPhim.DisplayMember = "TenPhim";
                cboPhim.ValueMember = "MaPhim";
                string ten;
                ten = cboPhim.Text;
                phim = cboPhim.SelectedValue.ToString();
                LayAnh(phim);
                picAnh.Image = Image.FromFile(Application.StartupPath + "\\Images\\AnhPhim\\" + anh);
                hienThiRap(phim);
                cboPhim.DataSource = dtbase.SelectData("Select MaPhim, TenPhim from Phim ");
                cboPhim.DisplayMember = "TenPhim";
                cboPhim.ValueMember = "MaPhim";
                cboPhim.Text = ten;
            }
                cboNgay.Enabled = false;
                cboGio.Enabled = false;         
            dgvThongTin.Columns[0].HeaderText = "Mã vé";
            dgvThongTin.Columns[1].HeaderText = "Tên phim";
            dgvThongTin.Columns[2].HeaderText = "Ngày chiếu";
            dgvThongTin.Columns[3].HeaderText = "Giờ chiếu";
            dgvThongTin.Columns[4].HeaderText = "Hàng ghế";
            dgvThongTin.Columns[5].HeaderText = "Số ghế";
            dgvThongTin.Columns[6].HeaderText = "Loại ghế";
            dgvThongTin.Columns[7].HeaderText = "Tiền vé";
            dgvThongTin.Columns[8].HeaderText = "Tổng ghế";

            dgvThongTin.Columns[0].Width = 75;
            dgvThongTin.Columns[1].Width = 100;
            dgvThongTin.Columns[2].Width = 75;
            dgvThongTin.Columns[3].Width = 50;
            dgvThongTin.Columns[4].Width = 50;
            dgvThongTin.Columns[5].Width = 50;
            dgvThongTin.Columns[6].Width = 50;
            dgvThongTin.Columns[7].Width = 75;
            dgvThongTin.Columns[8].Width = 75;
        }

        void KhoiTaoGhe(int TongGhe)
        {
            
            int dem = 1;
            string tenGhe = "";
            string HangGhe = "";
            
            for (int i =0; i < TongGhe / 10;i++)
            {
                tenGhe = "" + Convert.ToChar(i + 65);
                Console.WriteLine(tenGhe);
                for (int j = 0; j < 10; j++)
                {                   
                    btn = new Button();                
                    HangGhe = (j + 1).ToString();
                    btn.Location = new System.Drawing.Point(40 + 60 * j, 35 + 55 * i);
                    btn.Name = dem.ToString();
                    btn.Size = new System.Drawing.Size(40, 40);
                    //btn.TabIndex = 0;
                    btn.Text = tenGhe + HangGhe;
                    //btn.UseVisualStyleBackColor = true;
                    if (kiemTraGhe(tenGhe, HangGhe) == false)
                        btn.BackColor = Color.White;
                    else
                        btn.BackColor = Color.Gray;
                    btn.Click += new EventHandler(button_Click);
                    gbGhe.Controls.Add(btn);
                    dem++;
                    if (dem > TongGhe)
                        break;
                }
                if (dem > TongGhe)
                    break;
            }
        }

        bool kiemTraGhe(string i, string j)
        {
            //MessageBox.Show("check");
            string sqlKiemTraGhe = sqlSelect + " and HangGhe = '" + i + "' and SoGhe = " + j;
            dtGhe = dtbase.SelectData(sqlKiemTraGhe);
            if (dtGhe.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        void button_Click(object sender, EventArgs e)
        {
            /*object sender là đối tượng phát sinh ra event để sử dụng nó phải ép kiểu 
             ở đây button gửi event nên button là sender nên phải ép kiểu */
            Button btn = sender as Button;
            if (btn.BackColor == Color.Gray)
            {
                MessageBox.Show("Ghế này đã được chọn");
            }
            else if (btn.BackColor == Color.White)
            {
                int So;
                btn.BackColor = Color.Orange;
                //MessageBox.Show(dem.ToString());
                char[] tach = btn.Text.ToCharArray();
                try
                {
                    So = int.Parse(btn.Name);
                }
                catch
                {
                    MessageBox.Show("Lỗi rồi!");
                }
                So = int.Parse(btn.Name);
                //MessageBox.Show(So.ToString());
                if (tach.Length == 2)
                    sqlInsert[So] += a + "('" + maBC.Trim() + "VP" + So.ToString() + "', '" + maBC.Trim() + "', '" + tach[0].ToString() + "', '" + tach[1].ToString() + "')";
                else
                    sqlInsert[So] += a + "('" + maBC.Trim() + "VP" + So.ToString() + "', '" + maBC.Trim() + "', '" + tach[0].ToString() + "', '" + tach[1].ToString() + tach[2].ToString() + "')";
                //MessageBox.Show(sqlInsert[So]);
                count++;
            }
            else if (btn.BackColor == Color.Orange)
            {
                int So;
                btn.BackColor = Color.White;
                try
                {
                    So = int.Parse(btn.Name);
                }
                catch
                {
                    MessageBox.Show("Lỗi rồi!");
                }
                So = int.Parse(btn.Name);
                sqlInsert[So] = null;
                count--;
            }

        }
        private void btnDat_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                MessageBox.Show("Bạn chưa chọn ghế nào!");
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn đặt vé không?", "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string them = "";
                    for (int i = 1; i <= TongGhe; i++)
                    {
                        if (sqlInsert[i] != null)
                            them += sqlInsert[i] + " ";
                            //MessageBox.Show(sqlInsert[i]);
                    }
                    dtbase.updateData(them);
                    loadData(rap, phim, ngay, gio);
                    sqlInsert = new string[300];
                    tmp = "";
                    ResetGhe();
                    
                }

            }

        }
        private void btnBoChon_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                MessageBox.Show("Bạn chưa chọn ghế nào!");
            }
            else if (MessageBox.Show("Bạn muốn bỏ chọn hết tất cả các ghế?", "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ResetGhe();
                sqlInsert = new string[300];
            };
        }

        void ResetGhe()
        {
            count = 0;
            gbGhe.Controls.Clear();           
            KhoiTaoGhe(TongGhe);
        }
    }
}
