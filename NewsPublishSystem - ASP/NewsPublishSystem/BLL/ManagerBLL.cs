using NewsPublishSystem.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using YtvcBasic.SqlDao;

namespace NewsPublishSystem.BLL
{
    public class ManagerBLL
    {
        SqlConnection conn;
        public ManagerBLL()
        {
            conn = DBHelper.Connect();
        }
        public int CountManager(Hashtable Manager)
        {
            int result;
            string strSql = @"select count(*) from [Manager] where Phone=@Phone and Pwd=@Pwd";
            try
            {
                conn.Open();
                Dao d = new Dao(conn, null);
                result = (int)d.Scalar(strSql, Manager);
            }
            catch
            {
                result = 0;
            }
            finally
            {
                if (conn != null) conn.Close();
            }
            return result;
        }
    }
}