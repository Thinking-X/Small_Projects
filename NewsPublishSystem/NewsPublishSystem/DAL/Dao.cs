using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

/***************************************************************************************** 
 * 适用于MS_SQLSERVER数据库的数据操作类 
 * .Net FrameWork4.0
 * Dao版本2.0 日期：2016-03-20
 * 以Hashtable为基础，执行Sql命令。
 * 
 * Dao版本2.1 日期：2016-07-06
 * 增加Query的泛型方法；
 * 增加QueryOne的泛型方法；
 * 查询可以使用自定义实体类返回数据；
 * 查询前需要提供表结构和实体类的映射关系；
 * 如果没有提供关系，将按列名和属性名一致进行映射。
 *****************************************************************************************/

namespace YtvcBasic.SqlDao
{
    /// <summary>
    /// 在MS_SQLSERVER数据库执行Sql命令的Dao类
    /// </summary>
    public class Dao
    {
        public Dao()
        {
            this._Connection = null;
            this._Transaction = null;
            InitMaps();
        } 

        //映射关系集合
        private static Hashtable maps = new Hashtable();
        //映射关系初始化
        private void InitMaps()
        {
            //如果映射关系已经装载，返回。
            if (Dao.maps.Keys.Count == 0) return;
            //进行装载
            Hashtable map = null;
            /* *************************************************************
             * 以下以User类为例的映射关系装置代码示例，
             * 需要用户根据项目自行定义编辑修改，
             * key：属性, value：列，
             * 映射关系名（映射关系集合的key）和类名相同。
             ***************************************************************/
            map = new Hashtable();
            map.Add("KHID", "KHID");     
            map.Add("PHONE", "PHONE");
            map.Add("PWD", "PWD");
            map.Add("XM", "XM");
            map.Add("XB", "XB");
            map.Add("BZ_DJ", "BZ_DJ");
            map.Add("BZ_KY", "BZ_KY");
            map.Add("DZ", "DZ");
            map.Add("EMAIL", "EMAIL");
            maps.Add("User", map);
            //
        }

        private SqlConnection _Connection;
        /// <summary>
        /// 设置或获取Dao使用的数据连接
        /// </summary>
        public SqlConnection Connection
        {
            get { return _Connection; }
            set { _Connection = value; }
        }
        private SqlTransaction _Transaction;
        /// <summary>
        /// 设置或获取数据连接使用的事务对象
        /// </summary>
        public SqlTransaction Transaction
        {
            get { return _Transaction; }
            set { _Transaction = value; }
        }

        /// <summary>
        /// Dao对象初始化
        /// </summary>
        /// <param name="con">数据连接对象</param>
        /// <param name="tran">事务对象</param>
        public Dao(SqlConnection con, SqlTransaction tran)
        {
            this._Connection = con;
            this._Transaction = tran;
            InitMaps();
        }

        /// <summary>
        /// 执行Sql非查询命令
        /// </summary>
        /// <param name="sqlText">Sql命令文本</param>
        /// <param name="param">命令参数集合，无参数为null</param>
        /// <returns>执行成功与否（0：失败，1：成功）</returns>
        public int NonQuery(String sqlText, Hashtable param)
        {
            int result = 0;
            //初始化命令对象
            SqlCommand cmd = new SqlCommand(sqlText, _Connection, _Transaction);
            try
            {
                if (param != null)
                {
                    //为命令对象添加参数
                    foreach (String key in param.Keys)
                    {
                        cmd.Parameters.AddWithValue(key, param[key]);
                    }     
                }
                //执行SQL命令
                cmd.ExecuteNonQuery();
                result = 1;
            }
            catch (Exception e)
            {
                String msg = e.Message;
            }
            finally
            {
                cmd.Dispose();
            }
            return result;
        }

        /// <summary>
        /// 执行Sql查询命令
        /// </summary>
        /// <param name="sqlText">Sql命令文本</param>
        /// <param name="param">命令参数集合</param>
        /// <returns>查询结果的记录集合</returns>
        public List<Hashtable> Query(String sqlText, Hashtable param)
        {
            List<Hashtable> result = new List<Hashtable>();
            SqlCommand cmd = new SqlCommand(sqlText, _Connection, _Transaction);
            SqlDataReader dr = null;
            try
            {
                if (param != null)
                {
                    foreach (String key in param.Keys)
                        cmd.Parameters.AddWithValue(key, param[key]);
                }
                dr = cmd.ExecuteReader();
                Hashtable record = null;
                while (dr.Read())
                {
                    //读取一行记录，转换成为Hashtable对象
                    record = new Hashtable();
                    for (int i = 0; i < dr.FieldCount; i++) record.Add(dr.GetName(i), dr.GetValue(i));
                    //将Hashtable对象（读取的记录）放入集合
                    result.Add(record);
                }
            }
            catch (Exception e)
            {
                String msg = e.Message;
                result = new List<Hashtable>();
            }
            finally
            {
                if (dr != null)
                {
                    if (!dr.IsClosed) dr.Close();
                    dr.Dispose();
                }
                cmd.Dispose();
            }
            return result;
        }

        /// <summary>
        /// 执行Sql查询命令，只返回一条记录
        /// </summary>
        /// <param name="sqlText">Sql命令文本</param>
        /// <param name="param">命令参数集合</param>
        /// <returns>查询到的记录</returns>
        public Hashtable QueryOne(String sqlText, Hashtable param)
        {
            List<Hashtable> records = Query(sqlText, param);
            if (records.Count >= 1) return records[0];
            else return null;
        }

        /// <summary>
        /// 执行Sql查询命令，只返回单值
        /// </summary>
        /// <param name="sqlText">Sql命令文本</param>
        /// <param name="param">命令参数集合</param>
        /// <returns>查询到的单值</returns>
        public object Scalar(String sqlText, Hashtable param)
        {
            object result = null;
            SqlCommand cmd = new SqlCommand(sqlText, _Connection, _Transaction);
            try
            {
                if (param != null)
                {
                    foreach (String key in param.Keys)
                    {
                        cmd.Parameters.AddWithValue(key, param[key]);                     
                    }
                        
                }
                result = cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                String msg = e.Message;
            }
            finally
            {
                cmd.Dispose();
            }
            return result;
        }

        /// <summary>
        /// 执行Sql查询命令
        /// </summary>
        /// <typeparam name="T">实体类</typeparam>
        /// <param name="sqlText">Sql命令文本</param>
        /// <param name="param">命令参数集合</param>
        /// <returns>查询结果的记录集合</returns>
        public List<T> Query<T>(String sqlText, Hashtable param) where T : new()
        {
            List<T> result = new List<T>();
            SqlCommand cmd = new SqlCommand(sqlText, _Connection, _Transaction);
            SqlDataReader dr = null;
            try
            {
                if (param != null)
                {
                    foreach (String key in param.Keys)
                        cmd.Parameters.AddWithValue(key, param[key]);
                }
                dr = cmd.ExecuteReader();

                T record = default(T);
                Type type = typeof(T);                                //获取T的说明。   
                PropertyInfo[] pis = type.GetProperties();            //获取T的所有属性。
                Hashtable map = (Hashtable)Dao.maps[type.Name];       //获取映射关系。           
                //读取数据
                while (dr.Read())
                {
                    //读取一行记录，转换成为T对象
                    record = new T();
                    if (map == null)   //没有映射关系的,默认属性名和列名一致
                    {
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            //查找列名在T类型中对应属性的说明
                            for (int j = 0; j < pis.Length; j++)
                            {
                                //找到后，使用反射设置T对应属性的值
                                if (pis[j].Name.ToUpper() == dr.GetName(i).ToUpper())
                                    pis[j].SetValue(record, dr.GetValue(i), null);
                            }
                        }
                    }
                    else //有映射关系
                    {
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            //根据映射关系，查找列名在T类型中对应属性名
                            foreach (String key in map.Keys)
                            {
                                if (map[key].ToString().ToUpper() == dr.GetName(i).ToUpper())
                                {
                                    //查找该属性的说明
                                    for (int j = 0; j < pis.Length; j++)
                                    {
                                        //找到后，设置T对应属性的值
                                        if (pis[j].Name.ToUpper() == key.ToUpper())
                                            pis[j].SetValue(record, dr.GetValue(i), null);
                                    }
                                }
                            }
                        }
                    }
                    //将T对象（读取的记录）放入集合
                    result.Add(record);
                }
            }
            catch (Exception e)
            {
                String msg = e.Message;
                result = new List<T>();
            }
            finally
            {
                if (dr != null)
                {
                    if (!dr.IsClosed) dr.Close();
                    dr.Dispose();
                }
                cmd.Dispose();
            }
            return result;
        }

        /// <summary>
        /// 执行Sql查询命令，只返回一条记录
        /// </summary>
        /// <typeparam name="T">实体类</typeparam>
        /// <param name="sqlText">Sql命令文本</param>
        /// <param name="param">命令参数集合</param>
        /// <returns>查询到的记录</returns>
        public T QueryOne<T>(String sqlText, Hashtable param) where T : new()
        {
            List<T> records = Query<T>(sqlText, param);
            if (records.Count >= 1) return records[0];
            else return default(T);
        }

    }
}
