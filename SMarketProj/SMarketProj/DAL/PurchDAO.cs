using SMarketProj.PublicClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMarketProj.DAL
{
    class PurchDAO
    {
        public PurchDAO()
        {
            Conn = DBHelper.Connect();
        }
        SqlConnection Conn;
        SqlTransaction Tran = null;
        public DataTable SelectAllPurch()
        {
            string select = "select * from PurchaseDetail";
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool Insert_Purch(PurchaseDetail Purch)
        {
            string insert = String.Format("insert into PurchaseDetail values('{0}','{1}','{2}',{3},{4})", Purch.PurcTabNum, Purch.PurcDate, Purch.PordNum, Purch.PurcQuan, Purch.PurcTotal);
            SqlCommand CMD = new SqlCommand(insert, Conn, Tran);
            Conn.Open();
            bool result = true;
            try
            {
                CMD.ExecuteNonQuery();
            }
            catch
            {
                result = false;
            }
            Conn.Close();
            return result;
        }
        public bool Delete_Purch(string PurcTabNum)
        {
            string delete = String.Format("delete PurchaseDetail where PurcTabNum = '{0}'", PurcTabNum);
            SqlCommand CMD = new SqlCommand(delete, Conn, Tran);
            Conn.Open();
            bool result = true;
            try
            {
                CMD.ExecuteNonQuery();
            }
            catch
            {
                result = false;
            }
            Conn.Close();
            return result;
        }
        public bool Update_Purch(PurchaseDetail Purch)
        {
            string update = String.Format("update PurchaseDetail set PurcDate = '{0}', PordNum = '{1}', PurcQuan = {2}, PurcTotal = {3} where PurcTabNum = '{4}'", Purch.PurcDate, Purch.PordNum, Purch.PurcQuan, Purch.PurcTotal, Purch.PurcTabNum);
            SqlCommand CMD = new SqlCommand(update, Conn, Tran);
            Conn.Open();
            bool result = true;
            try
            {
                CMD.ExecuteNonQuery();
            }
            catch
            {
                result = false;
            }
            Conn.Close();
            return result;
        }
        public DataTable Select_Purch(string prop, string val, bool flag)
        {
            string select;
            if (flag)
            {
                select = String.Format("select * from PurchaseDetail where {0} = '{1}'", prop, val);
            }
            else
            {
                select = String.Format("select {0} from PurchaseDetail", prop);
            }
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
