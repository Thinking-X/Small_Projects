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
    class RoleDAO
    {
        public RoleDAO()
        {
            Conn = DBHelper.Connect();
        }
        SqlConnection Conn;
        SqlTransaction Tran = null;
        public DataTable SelectAllRole()
        {
            string select = "select * from Roles";
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool Insert_Role(Roles role)
        {
            string insert = String.Format("insert into Roles values('{0}','{1}')", role.RoleNum
                , role.RoleName);
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
        public bool Delete_Role(string roleNum)
        {
            string delete = String.Format("delete Roles where roleNum = '{0}'", roleNum);
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
        public bool Update_Role(Roles role)
        {
            string update = String.Format("update Roles set roleName = '{0}' where  roleNum = '{1}'", role.RoleName,role.RoleNum);
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
        public DataTable Select_Role(string prop, string val, bool flag)
        {
            string select;
            if (flag)
            {
                select = String.Format("select * from Roles where {0} = '{1}'", prop, val);
            }
            else
            {
                select = String.Format("select {0} from Roles", prop);
            }
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
