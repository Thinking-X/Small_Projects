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
    class ProdDAO
    {
        public ProdDAO()
        {
            Conn = DBHelper.Connect();
        }
        SqlConnection Conn;
        SqlTransaction Tran = null;

        public List<Product> Deliver(SqlDataReader reader)
        {
            List<Product> list = new List<Product>();
            while(reader.Read())
            {
                Product product = new Product();
                if(!(reader["ProdNum"] is DBNull))
                {
                    product.ProdNum = reader["ProdNum"].ToString(); 
                }
                if (!(reader["ProdName"] is DBNull))
                {
                    product.ProdName = reader["ProdName"].ToString();
                }
                if (!(reader["Quantity"] is DBNull))
                {
                    product.Quantity = Convert.ToInt32(reader["Quantity"]);
                }
                if (!(reader["BuyPrice"] is DBNull))
                {
                    product.BuyPrice = Convert.ToDecimal(reader["BuyPrice"]);
                }
                if (!(reader["SalePrice"] is DBNull))
                {
                    product.SalePrice = Convert.ToDecimal(reader["SalePrice"]);
                }
                list.Add(product);
            }
            return list;
        }
        public List<Product> SelectAllProd()
        {
            string select = "select * from Product";
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            Conn.Open();
            SqlDataReader reader = CMD.ExecuteReader();
            List<Product> list = Deliver(reader);
            Conn.Close();
            return list;
        }
        //public DataTable SelectAllProd()
        //{
        //    string select = "select * from Product";
        //    SqlCommand CMD = new SqlCommand(select, Conn, Tran);
        //    SqlDataAdapter adapter = new SqlDataAdapter(CMD);
        //    //DataSet data = new DataSet();
        //    //adapter.Fill(data, "T");
        //    //return data.Tables;
        //    DataTable Table = new DataTable();
        //    adapter.Fill(Table);
        //    return Table;
        //}
        public DataTable SelectPartProd()
        {
            string select = "select ProdNum, ProdName from Product";
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            //DataSet data = new DataSet();
            //adapter.Fill(data, "T");
            //return data.Tables;
            DataTable Table = new DataTable();
            adapter.Fill(Table);
            return Table;
        }
        public bool Insert_Prod(Product prod)
        {
            string insert = String.Format("insert into Product values('{0}','{1}',{2},{3},{4})", prod.ProdNum
                , prod.ProdName, prod.Quantity, prod.BuyPrice, prod.SalePrice);
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
        public bool Delete_Prod(string ProdNum)
        {
            string delete = String.Format("delete Product where ProdNum = '{0}'", ProdNum);
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
        public bool Update_Prod(Product prod)
        {
            string update = String.Format("update Product set ProdName = '{0}', Quantity = {1}, BuyPrice = {2}, SalePrice = {3} where ProdNum = '{4}'", prod.ProdName, prod.Quantity, prod.BuyPrice, prod.SalePrice,prod.ProdNum);
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
        public DataTable Select_Prod(string prop, string val, bool flag)
        {
            string select;
            if(flag)
            {
                select = String.Format("select * from Product where {0} = '{1}'", prop, val);
            }
            else
            {
                select = String.Format("select {0} from Product", prop);
            }
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public int GetProdQuan(string ProdNum)
        {
            string select = String.Format("select Quantity from Product where ProdNum = '{0}'", ProdNum);
            Conn.Open();
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            int Quan = (int)CMD.ExecuteScalar();
            Conn.Close();
            return Quan;
        }
        public bool UpdateQuan(int Quan, string ProdNum)
        {
            string update = String.Format("update Product set Quantity = {0} where ProdNum = '{1}'", GetProdQuan(ProdNum) - Quan, ProdNum);
            Conn.Open();
            SqlCommand CMD = new SqlCommand(update, Conn, Tran);
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
    }
}
