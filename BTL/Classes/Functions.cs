using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Classes
{
    class Functions
    {
        DataProcess dataBase = new DataProcess();
        public string SinhMaTuDong(string TenBang, string MaBatDau, string TruongMa)
        {
            int id = 00;
            bool dung = false;
            string ma = "";
            DataTable dm = new DataTable();
            while (dung == false)
            {
                dm = dataBase.SelectData("Select * from " + TenBang + " where " + TruongMa + "='" + MaBatDau + id.ToString() + "'");
                if (dm.Rows.Count == 0)
                {
                    dung = true;
                }
                else
                {
                    id++;
                    dung = false;
                }
            }
            ma = MaBatDau + id.ToString();
            return ma;
        }

        public void FillCombo(ComboBox cbCombo, DataTable dtTable, string displayMember, string value)
        {
            cbCombo.DataSource = dtTable;
            cbCombo.DisplayMember = displayMember;
            cbCombo.ValueMember = value;
        }
    }
}
