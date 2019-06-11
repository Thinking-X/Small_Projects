using NewsPublishSystem.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using YtvcBasic.SqlDao;

namespace NewsPublishSystem.BLL
{
    public class UserBLL
    {
        public Hashtable SelectUser(Hashtable h)
        {
            Hashtable result = new Hashtable();
            string strSql = @"select * from [User] where UserID=@UserID and pwd=@Pwd";
            SqlConnection conn = DBHelper.Connect();
            try
            {
                conn.Open();
                Dao dao = new Dao(conn, null);
                result = dao.QueryOne(strSql, h);
            }
            catch
            {
                result = null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return result;
        }
        public bool ValidateLogon(Hashtable h)
        {
            int result;
            string strSql = @"select Count(*) from [User] where UserID=@UserID and Pwd=@Pwd";
            SqlConnection conn = DBHelper.Connect();
            try
            {
                conn.Open();
                Dao dao = new Dao(conn, null);
                result = (int)dao.Scalar(strSql, h);
            }
            catch
            {
                result = -1;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            if (result == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool JudgeExist(Hashtable h)
        {
            int result;
            string strSql = @"select Count(*) from [User] where UserID=@UserID";
            SqlConnection conn = DBHelper.Connect();
            try
            {
                conn.Open();
                Dao dao = new Dao(conn, null);
                result = (int)dao.Scalar(strSql, h);
            }
            catch
            {
                result = -1;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            if (result == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool InsertUser(Hashtable h)
        {
            int result = 0;
            string strSql = "INSERT INTO [User] VALUES (@UserID, @Email, @Pwd, @Gender, @Birthdate)";
            SqlConnection conn = DBHelper.Connect();
            try
            {
                conn.Open();
                Dao dao = new Dao(conn, null);
                result = dao.NonQuery(strSql, h);
            }
            catch
            {
                result = 0;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            if (result == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public List<Hashtable> RecordPartUser(Hashtable h)
        {
            List<Hashtable> result = new List<Hashtable>();
            string strSql = @"select * from (select ROW_NUMBER() over(order by UserID) as RowNo,* from [User]) as part where RowNo between @start and @end";
            //RowNo between @start and @end
            //RowNo >= @start and RowNo<= @end
            SqlConnection conn = DBHelper.Connect();
            try
            {
                conn.Open();
                Dao d = new Dao(conn, null);
                result = d.Query(strSql, h);
            }
            catch
            {
                result = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return result;
        }
        public object CountUser()
        {
            object result = new object();
            string strSql = @"select count(*) from [User]";
            SqlConnection conn = DBHelper.Connect();
            try
            {
                conn.Open();
                Dao d = new Dao(conn, null);
                result = d.Scalar(strSql, null);
            }
            catch
            {
                result = null;
            }
            finally
            {
                if (conn != null) conn.Close();
            }
            return result;
        }
    }
}