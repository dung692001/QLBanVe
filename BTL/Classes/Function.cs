using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BTL.Classes
{
    class Function

    {
        Classes.DataProcess dataBase = new Classes.DataProcess();
        public string SinhMaTuDong(string TenBang, string MaBatDau, string TruongMa)
        {
            int id = 0;
            bool dung = false;
            string ma = "";
            string keyy="";
            DataTable dt = new DataTable();
            while (dung == false)
            {
                if (id < 10) keyy = "0";
                else keyy = "";
                dt = dataBase.SelectData("Select * from " + TenBang + " where " + TruongMa + "='" + MaBatDau +keyy+ id.ToString() + "'");
                if (dt.Rows.Count == 0)
                {
                    dung = true;
                }
                else
                {
                    id++;
                    dung = false;
                }
            }

          
            ma = MaBatDau + keyy+ id.ToString();
            
            return ma;
        }
        public void FillCombo(ComboBox cbCombo, DataTable dtTable, string displayMenber, string value)
        {
            cbCombo.DataSource = dtTable;
            cbCombo.DisplayMember = displayMenber;
            cbCombo.ValueMember = value;
        }
        
        string[] mNumText = "Không;Một;Hai;Ba;Bốn;Năm;Sáu;Bảy;Tám;Chín".Split(';');
        
        private string DocHangChuc(double so, bool daydu)
        {
            string chuoi = "";
           
            Int64 chuc = Convert.ToInt64(Math.Floor((double)(so / 10)));
           
            Int64 donvi = (Int64)so % 10;
           
            if (chuc > 1)
            {
                chuoi = " " + mNumText[chuc] + " Mươi";
                if (donvi == 1)
                {
                    chuoi += " Mốt";
                }
            }
            else if (chuc == 1)
            {
                chuoi = " Mười";
                if (donvi == 1)
                {
                    chuoi += " Một";
                }
            }
            else if (daydu && donvi > 0)
            {
                chuoi = " Lẻ";
            }
            if (donvi == 5 && chuc >= 1)
            {
                chuoi += " Lăm";
            }
            else if (donvi > 1 || (donvi == 1 && chuc == 0))
            {
                chuoi += " " + mNumText[donvi];
            }
            return chuoi;
        }
        private string DocHangTram(double so, bool daydu)
        {
            string chuoi = "";
           
            Int64 tram = Convert.ToInt64(Math.Floor((double)so / 100));
           
            so = so % 100;
            if (daydu || tram > 0)
            {
                chuoi = " " + mNumText[tram] + " Trăm";
                chuoi += DocHangChuc(so, true);
            }
            else
            {
                chuoi = DocHangChuc(so, false);
            }
            return chuoi;
        }
        private string DocHangTrieu(double so, bool daydu)
        {
            string chuoi = "";
           
            Int64 trieu = Convert.ToInt64(Math.Floor((double)so / 1000000));
           
            so = so % 1000000;
            if (trieu > 0)
            {
                chuoi = DocHangTram(trieu, daydu) + " Triệu";
                daydu = true;
            }
          
            Int64 nghin = Convert.ToInt64(Math.Floor((double)so / 1000));
           
            so = so % 1000;
            if (nghin > 0)
            {
                chuoi += DocHangTram(nghin, daydu) + " Nghìn";
                daydu = true;
            }
            if (so > 0)
            {
                chuoi += DocHangTram(so, daydu);
            }
            return chuoi;
        }
        public string ChuyenSoSangChuoi(double so)
        {
            if (so == 0)
                return mNumText[0];
            string chuoi = "", hauto = "";
            Int64 ty;
            do
            {
                
                ty = Convert.ToInt64(Math.Floor((double)so / 1000000000));
            
                so = so % 1000000000;
                if (ty > 0)
                {
                    chuoi = DocHangTrieu(so, true) + hauto + chuoi;
                }
                else
                {
                    chuoi = DocHangTrieu(so, false) + hauto + chuoi;
                }
                hauto = " Tỷ";
            } while (ty > 0);
            return chuoi + " Đồng";
        }
    }
}
