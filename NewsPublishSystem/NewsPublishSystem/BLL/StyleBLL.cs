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
    public class StyleBLL
    {
        SqlConnection conn;
        public StyleBLL()
        {
            conn = DBHelper.Connect();
        }
        public List<Hashtable> SelectAllStyle()
        {
            List<Hashtable> result = new List<Hashtable>();
            string strSql = @"select * from [Style]";         
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

        //public object CountNews()
        //{
        //    object result = new object();
        //    string strSql = @"select count(*) from [Style]";
        //    try
        //    {
        //        conn.Open();
        //        Dao d = new Dao(conn, null);
        //        result = d.Scalar(strSql, null);
        //    }
        //    catch
        //    {
        //        result = null;
        //    }
        //    finally
        //    {
        //        if (conn != null) conn.Close();
        //    }
        //    return result;
        //}
        //public List<Hashtable> LatestRecord()
        //{
        //    List<Hashtable> result = new List<Hashtable>();
        //    string strSql = @"select top 10 * from [Style] order by NewsID desc";
        //    try
        //    {
        //        conn.Open();
        //        Dao d = new Dao(conn, null);
        //        result = d.Query(strSql, null);
        //    }
        //    catch
        //    {
        //        result = null;
        //    }
        //    finally
        //    {
        //        if (conn != null)
        //        {
        //            conn.Close();
        //        }
        //    }
        //    return result;
        //}
        //public Hashtable OneRecord(Hashtable h)
        //{
        //    Hashtable result = new Hashtable();
        //    string strSql = @"select * from [Style] where NewsID = @NewsID";
        //    try
        //    {
        //        conn.Open();
        //        Dao d = new Dao(conn, null);
        //        result = d.QueryOne(strSql, h);
        //    }
        //    catch
        //    {
        //        result = null;
        //    }
        //    finally
        //    {
        //        if (conn != null)
        //        {
        //            conn.Close();
        //        }
        //    }
        //    return result;
        //}
        //public List<Hashtable> SelectRecord(Hashtable h)
        //{
        //    List<Hashtable> result = new List<Hashtable>();
        //    string strSql = @"select * from [Style] where Title Like +'%'+@Keyword+'%'";
        //    try
        //    {
        //        conn.Open();
        //        Dao d = new Dao(conn, null);
        //        result = d.Query(strSql, h);
        //    }
        //    catch
        //    {
        //        result = null;
        //    }
        //    finally
        //    {
        //        if (conn != null)
        //        {
        //            conn.Close();
        //        }
        //    }
        //    return result;
        //}
        //public bool InsetRecord(Hashtable hRecord)
        //{
        //    string strSql = "insert News(StyleID, ManagerID, Title, NewsContent, Pic, NewsSource)values(@StyleID, @ManagerID, @Title, @NewsContent, @Pic, @NewsSource)";
        //    int result = 0;
        //    try
        //    {
        //        conn.Open();
        //        Dao d = new Dao(conn, null);
        //        result = d.NonQuery(strSql, hRecord);
        //    }
        //    catch
        //    {
        //        result = 0;
        //    }
        //    finally
        //    {
        //        if (conn != null)
        //        {
        //            conn.Close();
        //        }
        //    }
        //    if(result == 0)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
    }
}