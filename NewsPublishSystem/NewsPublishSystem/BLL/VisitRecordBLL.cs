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
    public class VisitRecordBLL
    {
        SqlConnection conn;
        public VisitRecordBLL()
        {
            conn = DBHelper.Connect();
        }

        public List<Hashtable> SelectPart()
        {
            List<Hashtable> result = new List<Hashtable>();
            string strSql = @"select * from [VisitRecord]";
            try
            {
                conn.Open();
                Dao d = new Dao(conn, null);
                result = d.Query(strSql, null);
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