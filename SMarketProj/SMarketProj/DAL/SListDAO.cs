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
    class SListDAO
    {
        public SListDAO()
        {
            Conn = DBHelper.Connect();
        }       
        SqlConnection Conn;
        SqlTransaction Tran = null;
        public DataTable SelectAllList()
        {
            string select = "select * from SaleList";
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool Insert_List(SaleList SList)
        {
            string insert = String.Format("insert into SaleList values('{0}','{1}',{2})", SList.SaleTabNum, SList.ProdNum, SList.SaleQuantity);
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
        public bool Delete_List(string SaleTabNum, string ProdNum)
        {
            string delete = String.Format("delete SaleList where SaleTabNum = '{0}' and ProdNum = '{1}'", SaleTabNum, ProdNum);
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
        public bool Update_List(SaleList SList)
        {
            string update = String.Format("update SaleList set SaleQuantity = {0} where SaleTabNum = '{1}' and ProdNum = '{1}'", SList.SaleQuantity, SList.SaleTabNum, SList.ProdNum);
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
        public DataTable Select_List(string prop, string val, bool flag)
        {
            string select;
            if (flag)
            {
                select = String.Format("select * from SaleList where {0} = '{1}'", prop, val);
            }
            else
            {
                select = String.Format("select {0} from SaleList", prop);
            }
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
