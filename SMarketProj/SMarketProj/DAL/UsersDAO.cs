using SMarketProj.PublicClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMarketProj.DAL
{
    class UsersDAO
    {
        public UsersDAO()
        {
            Conn = DBHelper.Connect();
        }
        SqlConnection Conn;
        SqlTransaction Tran = null;

        public bool Proving(Users user)
        {
            //string Sentence = String.Format("select count(*) from Users where RoleNum='{0}' and UserNum='{1}' and UserPwd= '{2}'", user.RoleNum,user.UserNum,user.UserPwd);
            string Sentence = "select count(*) from Users where RoleNum=@rnum and UserNum=@unum and UserPwd= @pwd";
            Conn.Open();
            SqlCommand CMD = new SqlCommand(Sentence,Conn,Tran);
            CMD.Parameters.AddWithValue("@rnum", user.RoleNum);
            CMD.Parameters.AddWithValue("@unum", user.UserNum);
            CMD.Parameters.AddWithValue("@pwd", user.UserPwd);
            if ((int)CMD.ExecuteScalar() == 1)
            {
                Conn.Close();
                return true;
            }
            else
            {
                Conn.Close();
                return false;
            }
        }
        public DataTable SelectAllUser()
        {
            string select = "select * from Users";
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool Insert_user(Users user)
        {
            string insert = String.Format("insert into Users values('{0}','{1}','{1}')", user.RoleNum,user.UserNum,user.UserPwd);
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
        public bool Delete_user(string UserNum)
        {
            string delete = String.Format("delete Users where UserNum = '{0}'", UserNum);
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
        public bool Update_user(Users user)
        {
            string update = String.Format("update Users set UserPwd = '{0}' where RoleNum = '{1}' and UserNum = '{2}'", user.UserPwd,  user.RoleNum, user.UserNum);
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
        public DataTable Select_User(string prop, string val, bool flag)
        {
            string select;
            if (flag)
            {
                select = String.Format("select * from Users where {0} = '{1}'", prop, val);
            }
            else
            {
                select = String.Format("select {0} from Users", prop);
            }
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
