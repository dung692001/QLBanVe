using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BTL.Classes
{
    class DataProcess
    {
        //CHuỗi kết nối
        string ConnectString = "Data Source=LAPTOP-FBMKAQ20\\KTEAM;Initial Catalog=QLPhim;Integrated Security=True;Connection Timeout=3600";
        //Mở kết nối
        SqlConnection sqlConnect = null;
        //Phương thức mở kết nối
        void OpenConnect()
        {
            sqlConnect = new SqlConnection(ConnectString);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }
        //Phương thức đóng kết nối
        void CloseConnect()
        {
            sqlConnect = new SqlConnection(ConnectString);
            if (sqlConnect.State != ConnectionState.Closed)
                sqlConnect.Close();
            sqlConnect.Dispose();
        }
        //Phương thức thực hiện câu lệnh SQL dạng select trả về 1 database
        public DataTable SelectData(string sqlSelect)
        {
            DataTable dtResult = new DataTable();
            OpenConnect();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, sqlConnect);
            //sqlData.CommandTimeout = 0;
            sqlData.Fill(dtResult);
            CloseConnect();
            sqlData.Dispose();
            return dtResult;
        }
        //Phương thức thực hiện thay đổi kiểu dữ liệu: insert, update, delete
        public void updateData(string sql)
        {
            OpenConnect();
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConnect;
            sqlComm.CommandText = sql;
            //sqlComm.CommandTimeout = 0;
            sqlComm.ExecuteNonQuery();         
            CloseConnect();
            sqlComm.Dispose();
        }
    }
}
