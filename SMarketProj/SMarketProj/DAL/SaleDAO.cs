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
    class SaleDAO
    {
        public SaleDAO()
        {
            Conn = DBHelper.Connect();
        }
        SqlConnection Conn;
        SqlTransaction Tran = null;
        public DataTable SelectAllSale()
        {
            string select = "select * from SaleDetail";
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool Insert_Sale(SaleDetail Sale)
        {
            string insert = String.Format("insert into SaleDetail values('{0}','{1}','{2}',{3})", Sale.SaleTabNum, Sale.SaleDate, Sale.MemNum,Sale.SaleTotal);
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
        public bool Delete_Sale(string SaleTabNum)
        {
            string delete = String.Format("delete SaleDetail where SaleTabNum = '{0}'", SaleTabNum);
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
        public bool Update_Sale(SaleDetail Sale)
        {
            string update = String.Format("update SaleDetail set SaleDate = '{0}', MemNum = '{1}', SaleTotal = {2} where  SaleTabNum = '{3}'", Sale.SaleDate, Sale.MemNum, Sale.SaleTotal, Sale.SaleTabNum);
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
        public DataTable Select_Sale(string prop, string val, bool flag)
        {
            string select;
            if (flag)
            {
                select = String.Format("select * from SaleDetail where {0} = '{1}'", prop, val);
            }
            else
            {
                select = String.Format("select {0} from SaleDetail", prop);
            }
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
