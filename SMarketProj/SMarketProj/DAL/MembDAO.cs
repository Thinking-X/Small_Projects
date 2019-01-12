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
    class MembDAO
    {
        public MembDAO()
        {
            Conn = DBHelper.Connect();
        }
        SqlConnection Conn;
        SqlTransaction Tran = null;

        public List<Member> Deliver(SqlDataReader reader)
        {
            List<Member> list = new List<Member>();
            while (reader.Read())
            {
                Member member = new Member();
                if (!(reader["MemNum"] is DBNull))
                {
                    member.MemNum = reader["MemNum"].ToString();
                }
                if (!(reader["MemPwd"] is DBNull))
                {
                    member.MemPwd = reader["MemPwd"].ToString();
                }
                if (!(reader["Grade"] is DBNull))
                {
                    member.Grade = Convert.ToInt32(reader["Grade"]);
                }
                if (!(reader["MemName"] is DBNull))
                {
                    member.MemName = reader["MemName"].ToString();
                }
                if (!(reader["Gender"] is DBNull))
                {
                    member.Gender = reader["Gender"].ToString();
                }
                if (!(reader["IdNum"] is DBNull))
                {
                    member.IdNum = reader["IdNum"].ToString();
                }
                if (!(reader["FAddress"] is DBNull))
                {
                    member.FAddress = reader["FAddress"].ToString();
                }
                list.Add(member);
            }
            return list;
        }
        public List<Member> SelectAllMemb()
        {
            string select = "select * from Member";
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            Conn.Open();
            SqlDataReader reader = CMD.ExecuteReader();
            List<Member> list = Deliver(reader);
            Conn.Close();
            return list;
        }
        public bool Insert_Memb(Member memb)
        {
            string insert = String.Format("insert into Member values('{0}','{1}',{2},'{3}','{4}','{5}','{6}')", memb.MemNum,memb.MemPwd, memb.Grade,memb.MemName,memb.Gender,memb.IdNum,memb.FAddress);
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
        public bool Delete_Memb(string MemNum)
        {
            string delete = String.Format("delete Member where MemNum = '{0}'", MemNum);
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
        public bool Update_Memb(Member memb)
        {
            string update = String.Format("update Member set MemPwd = '{0}', Grade = {1}, MemName = '{2}', Gender = '{3}', FAddress = '{4}'  where MemNum = '{5}' and IdNum = '{6}'", memb.MemPwd, memb.Grade, memb.MemName, memb.Gender, memb.FAddress, memb.MemNum, memb.IdNum);
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
        public int Select_MembGrade(string MemNum)
        {
            string select = String.Format("select Grade from Member where MemNum = '{0}'", MemNum);
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            Conn.Open();
            int Grade = (int)CMD.ExecuteScalar();
            Conn.Close();
            return Grade;
        }
        public Member Select_MembInfo(string MemNum)
        {
            string select = String.Format("select * from Member where MemNum = '{0}'", MemNum);
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            Conn.Open();
            SqlDataReader reader = CMD.ExecuteReader();
            Member member = new Member();
            while (reader.Read())
            {
                if(!(reader["MemNum"] is DBNull))
                {
                    member.MemNum = reader["MemNum"].ToString();
                }
                if (!(reader["MemPwd"] is DBNull))
                {
                    member.MemPwd = reader["MemPwd"].ToString();
                }
                if (!(reader["Grade"] is DBNull))
                {
                    member.Grade = Convert.ToInt32(reader["Grade"]);
                }
                if (!(reader["MemName"] is DBNull))
                {
                    member.MemName = reader["MemName"].ToString();
                }
                if (!(reader["Gender"] is DBNull))
                {
                    member.Gender = reader["Gender"].ToString();
                }
                if (!(reader["IdNum"] is DBNull))
                {
                    member.IdNum = reader["IdNum"].ToString();
                }
                if (!(reader["FAddress"] is DBNull))
                {
                    member.FAddress = reader["FAddress"].ToString();
                }   
            }
            Conn.Close();
            return member;
        }
        public DataTable Select_Memb(string prop, string val, bool flag)
        {
            string select;
            if (flag)
            {
                select = String.Format("select * from Member where {0} = '{1}'", prop, val);
            }
            else
            {
                select = String.Format("select {0} from Member", prop);
            }
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool UpdateGrade(int Grade, string MemNum)
        {
            string update = String.Format("update Member set Grade = {0} where MemNum = '{1}'", Grade, MemNum);
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
        public Member Select_OneMemb(string UserNum)
        {
            string select = String.Format("select * from Member where MemNum = '{0}'", UserNum);
            Conn.Open();
            SqlCommand CMD = new SqlCommand(select,Conn,Tran);
            SqlDataReader reder = CMD.ExecuteReader();
            Member member = new Member();
            while (reder.Read())
            {
                member.MemNum = reder["MemNum"].ToString();
                member.MemPwd = reder["MemPwd"].ToString();
                if(!(reder["Grade"] is DBNull))
                {
                    member.Grade = Convert.ToInt32(reder["Grade"]);
                }               
                if(!(reder["MemName"] is DBNull))
                {
                    member.MemName = reder["MemName"].ToString();
                }             
                if(!(reder["Gender"] is DBNull))
                {
                    member.Gender = reder["Gender"].ToString();
                }
                member.IdNum = reder["IdNum"].ToString();
                if(!(reder["FAddress"] is DBNull))
                {
                    member.FAddress = reder["FAddress"].ToString();
                }
            }
            Conn.Close();
            return member;
        }
        public DataTable ShoppingHistory(string MemNum)
        {
            string select = String.Format("select ProdName, SalePrice, SaleQuantity, SaleDate from SaleDetail, SaleList, Product where SaleDetail.SaleTabNum = SaleList.SaleTabNum and Product.ProdNum = SaleList.ProdNum and MemNum = '{0}'", MemNum);
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable Select_History(string UserNum, string prop, string val, bool flag)
        {
            string select;
            if (flag)
            {
                select = String.Format("select ProdName, SalePrice, SaleQuantity, SaleDate from SaleDetail, SaleList, Product where SaleDetail.SaleTabNum = SaleList.SaleTabNum and Product.ProdNum = SaleList.ProdNum and MemNum = '{0}' and {1} = '{2}'", UserNum, prop, val);
            }
            else
            {
                select = String.Format("select {0} from SaleDetail, SaleList, Product where SaleDetail.SaleTabNum = SaleList.SaleTabNum and Product.ProdNum = SaleList.ProdNum and MemNum = '{1}'", prop, UserNum);
            }
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
