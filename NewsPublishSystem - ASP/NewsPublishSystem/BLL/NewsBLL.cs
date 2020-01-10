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
    public class NewsBLL
    {
        SqlConnection conn;
        public NewsBLL()
        {
            conn = DBHelper.Connect();
        }
        public List<Hashtable> SelectAllNews()
        {
            List<Hashtable> result = new List<Hashtable>();
            string strSql = @"select * from [News] where AuditState='通过'";         
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

        public object CountNews()
        {
            object result = new object();
            string strSql = @"select count(*) from [News] where AuditState='通过'";
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
        public List<Hashtable> PartRecord(Hashtable h)//表审核通过的记录
        {
            List<Hashtable> result = new List<Hashtable>();
            string strSql = @"select * from (select ROW_NUMBER() over(order by NewsID desc) as RowNo,* from [News] where AuditState='通过') as part where RowNo between @start and @end";
            //RowNo between @start and @end
            //RowNo >= @start and RowNo<= @end
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
        public List<Hashtable> PartRecordALL(Hashtable h)//表的所有记录
        {
            List<Hashtable> result = new List<Hashtable>();
            string strSql = @"select * from (select ROW_NUMBER() over(order by NewsID desc) as RowNo,* from [News]) as part where RowNo between @start and @end";
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
        public List<Hashtable> LatestRecord()
        {
            List<Hashtable> result = new List<Hashtable>();
            string strSql = @"select top 10 * from [News] where AuditState='通过' order by NewsID desc";
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
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return result;
        }
        public Hashtable OneRecord(Hashtable h)
        {
            Hashtable result = new Hashtable();
            string strSql = @"select * from [News] where NewsID = @NewsID and AuditState='通过'";
            try
            {
                conn.Open();
                Dao d = new Dao(conn, null);
                result = d.QueryOne(strSql, h);
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
        
        public Hashtable OneOtherRecord(Hashtable h)//只包含审核通过的
        {
            Hashtable result = new Hashtable();
            string strSql = @"select Title,StyleName,NewsSource,Pic,NewsContent from [News], [Style] where Style.StyleID = News.StyleID and NewsID = @NewsID and AuditState='通过'";
            try
            {
                conn.Open();
                Dao d = new Dao(conn, null);
                result = d.QueryOne(strSql, h);
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
        public Hashtable OneOtherRecordALL(Hashtable h)//包含全部的
        {
            Hashtable result = new Hashtable();
            string strSql = @"select Title,StyleName,NewsSource,Pic,NewsContent,AuditState,RejectReason from [News], [Style] where Style.StyleID = News.StyleID and NewsID = @NewsID";
            try
            {
                conn.Open();
                Dao d = new Dao(conn, null);
                result = d.QueryOne(strSql, h);
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
        public List<Hashtable> SelectRecord(Hashtable h)
        {
            List<Hashtable> result = new List<Hashtable>();
            string strSql = @"select * from [News] where Title Like +'%'+@Keyword+'%' and AuditState='通过'";
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
        public bool UpdateVerify(Hashtable h)
        {
            int result;
            string strSql = @"UPDATE News SET AuditState = @AuditState, RejectReason = @RejectReason WHERE NewsID = @NewsID";
            try
            {
                conn.Open();
                Dao d = new Dao(conn, null);
                result = d.NonQuery(strSql, h);
            }
            catch
            {
                result = -1;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            if(result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 插入一条新闻，先判断审核状态，默认通过
        /// </summary>
        /// <param name="hRecord"></param>
        /// <returns></returns>
        public bool InsetRecord(Hashtable hRecord)//默认通过
        {
            string strSql = "insert News(StyleID, ManagerID, Title, NewsContent, Pic, NewsSource, AuditState)values(@StyleID, @ManagerID, @Title, @NewsContent, @Pic, @NewsSource, @AuditState)";
            int result = 0;
            try
            {
                conn.Open();
                Dao d = new Dao(conn, null);
                result = d.NonQuery(strSql, hRecord);
            }
            catch
            {
                result = 0;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            if(result == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 更改一条新闻，先判断审核状态，默认通过
        /// </summary>
        /// <param name="hRecord"></param>
        /// <returns></returns>
        public bool UpdateRecord(Hashtable hRecord)
        {
            string strSql = "UPDATE News SET StyleID = @StyleID,ManagerID = @ManagerID,Title = @Title,NewsContent = @NewsContent,Pic = @Pic,NewsSource = @NewsSource,PublishTime = GETDATE() WHERE NewsID = @NewsID";
            int result = 0;
            try
            {
                conn.Open();
                Dao d = new Dao(conn, null);
                result = d.NonQuery(strSql, hRecord);
            }
            catch
            {
                result = 0;
            }
            finally
            {
                if (conn != null)
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
        public bool DeleteRecord(Hashtable hRecord)
        {
            string strSql = "delete News where NewsID=@NewsID";
            int result = 0;
            try
            {
                conn.Open();
                Dao d = new Dao(conn, null);
                result = d.NonQuery(strSql, hRecord);
            }
            catch
            {
                result = 0;
            }
            finally
            {
                if (conn != null)
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
    }
}