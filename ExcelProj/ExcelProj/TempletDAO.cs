using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelProj
{
    class TempletDAO
    {
        SqlConnection Conn;
        public TempletDAO()
        {
            Conn = DBHelper.Connect();
        }
        public DataTable SelectAll()
        {
            string select = "select * from sheet1";
            SqlCommand CMD = new SqlCommand(select, Conn);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            DataTable Data = new DataTable();
            adapter.Fill(Data);
            return Data;
        }
        public int UpdateOneSortState(string code)
        {
            string update = String.Format("update sheet1 set SortState = '是' where Code = '{0}'", code);
            Conn.Open();
            SqlCommand CMD = new SqlCommand(update, Conn);
            int result;
            try
            {
                result = CMD.ExecuteNonQuery();
            }
            catch
            {
                result = 0;
            }
            Conn.Close();
            return result;
        }
        public int SelectOneCode(string code)
        {
            string select = String.Format("select Count(*) from sheet1 where Code = '{0}'", code);
            Conn.Open();
            SqlCommand CMD = new SqlCommand(select, Conn);
            int result;
            try
            {
                result = (int)CMD.ExecuteScalar();
            }
            catch
            {
                result = 0;
            }           
            Conn.Close();
            return result;
        }
        public int SelectOneQuantity(string Code)
        {
            string select = String.Format("select Quantity from sheet1 where Code = '{0}'", Code);
            Conn.Open();
            SqlCommand CMD = new SqlCommand(select, Conn);
            int result;
            try
            {
                result = (int)CMD.ExecuteScalar();
            }
            catch
            {
                result = -1;
            }
            Conn.Close();
            return result;
        }
        public int SelectOneSortedQuan(string Code)
        {
            string select = String.Format("select SortedQuan from sheet1 where Code = '{0}'", Code);
            Conn.Open();
            SqlCommand CMD = new SqlCommand(select, Conn);
            int result;
            try
            {
                result = (int)CMD.ExecuteScalar();
            }
            catch
            {
                result = -1;
            }
            Conn.Close();
            return result;
        }
        public int UpdateOneSortedQuan(int SortedQuan, string Code)
        {
            string update = String.Format("update sheet1 set SortedQuan = {0} where Code = '{1}'", SortedQuan, Code);
            Conn.Open();
            SqlCommand CMD = new SqlCommand(update, Conn);
            int result;
            try
            {
                result = CMD.ExecuteNonQuery();
            }
            catch
            {
                result = 0;
            }
            Conn.Close();
            return result;
        }
        public int SelectMaxAreaCode()
        {
            string select = "select AreaCode from sheet1";
            Conn.Open();
            SqlCommand CMD = new SqlCommand(select, Conn);
            SqlDataReader reader = CMD.ExecuteReader();
            List<int> list = new List<int>();
            while(reader.Read())
            {
                int areaCode;
                areaCode = Convert.ToInt32(reader[0]);
                list.Add(areaCode);
            }
            Conn.Close();
            return list.Max();
        }
        public bool CreateTaskConfigTable()
        {          
            string create = "create table TaskConfig([ID] nvarchar(20),[Name] nvarchar(255), [Status] nvarchar(20), [BeginNum] int, [EndNum] int,primary key(ID,Name))";
            Conn.Open();
            SqlCommand CMD = new SqlCommand(create, Conn);
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
        public int InsertTaskConfig(TaskConfig task)
        {
            string insert = String.Format("insert into TaskConfig values('{0}','{1}','{2}',{3},{4})", task.ID, task.Name, task.Status, task.BeginNum, task.EndNum);
            Conn.Open();
            SqlCommand CMD = new SqlCommand(insert, Conn);
            int result;
            try
            {
                result = CMD.ExecuteNonQuery();
            }
            catch
            {
                result = 0;
            }
            Conn.Close();
            return result;
        }
        public DataTable SelectAll_()
        {
            string select = "select * from TaskConfig";
            SqlCommand CMD = new SqlCommand(select, Conn);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            DataTable Data = new DataTable();
            adapter.Fill(Data);
            return Data;
        }
    }
}
