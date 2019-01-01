using StudentApp.PublicClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.DAL
{
    class StudentDAO
    {
        public StudentDAO()
        {
            con = DBHelper.Connect();
        }
        SqlConnection con;
        SqlTransaction tran = null;
        //tran.Commit();//如果所有操作都完成，必须提交事务。
        //tran.Rollback();//如果有一个操作失败，整个任务回滚
        public List<Student> Deliver(SqlDataReader reader)
        {
            List<Student> list = new List<Student>();
            while (reader.Read())
            {
                Student stu = new Student();
                stu.Sid = reader["Sid"].ToString();
                if (!(reader["Sname"] is DBNull))
                {
                    stu.Sname = reader["Sname"].ToString();
                }
                if (!(reader["Sex"] is DBNull))
                {
                    stu.Sex = reader["Sex"].ToString();
                }               
                if (!(reader["ClassName"] is DBNull))
                {
                    stu.ClassName = reader["ClassName"].ToString();
                }
                if (!(reader["Birthdate"] is DBNull))
                {
                    stu.Birthdate = Convert.ToDateTime(reader["Birthdate"]);
                }
                if (!(reader["AScores"] is DBNull))
                {
                    stu.AScores = Convert.ToDecimal(reader["AScores"]);
                }
                list.Add(stu);
            }
            return list;
        }       
        public List<Student> DisplayTableStu()
        {
            string Sentence = "select * from student";
            SqlCommand cmd = new SqlCommand(Sentence, con, tran);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> list = Deliver(reader);
            con.Close();
            return list;          
        }
        public int GainSumline()//获取表的总行数
        {
            string Sentence = "select count(*) from student";
            SqlCommand cmd = new SqlCommand(Sentence, con, tran);
            con.Open();
            int sum = (int)cmd.ExecuteScalar();
            con.Close();
            return sum;
        }
        public List<Student> DisplayPage(int LineNum, int i)
        {    
            string Sentence = String.Format("select * from (select ROW_NUMBER() over(order by sid) as RowNo, * from student) as part where RowNo between ({0}*({1}-1)+1) and ({2}*{3})", LineNum, i, LineNum, i);
            SqlCommand cmd = new SqlCommand(Sentence, con, tran);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> list = Deliver(reader);   
            con.Close();
            return list;
        }
        public bool Insert_Stu(Student stu)
        {
            string insert = string.Format("insert into student values('{0}', '{1}', '{2}', '{3}', '{4}', {5})", stu.Sid, stu.Sname, stu.Sex, stu.Birthdate, stu.ClassName, stu.AScores);
            SqlCommand cmd = new SqlCommand(insert, con, tran);
            con.Open();
            bool result = false;
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    result = true;
                }
            }
            catch
            {
                result = false;
            }         
            con.Close();
            return result;
        }
        public bool Delete_Stu(string Id)
        {
            string delete = String.Format("delete student where sid = '{0}'", Id);
            SqlCommand cmd = new SqlCommand(delete, con, tran);
            con.Open();
            bool result = false;
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    result = true;
                }
            }
            catch
            {
                result = false;
            }
            con.Close();
            return result;
        }
        public bool Update_Stu(Student stu)
        {
            string update = string.Format("update student set sname = '{0}', sex = '{1}', birthdate = '{2}', ClassName = '{3}', ascores = {4} where sid = '{5}'", stu.Sname, stu.Sex, stu.Birthdate, stu.ClassName, stu.AScores, stu.Sid);
            SqlCommand cmd = new SqlCommand(update, con, tran);     
            con.Open();
            bool result = false;
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    result = true;
                }
            }
            catch
            {
                result = false;
            }
            con.Close();
            return result;
        }
        public DataTable Select_Stu1(string Prop)
        {
            string select = "select " + Prop + " from student";
            SqlCommand cmd = new SqlCommand(select, con, tran);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable Data = new DataTable();
            adapter.Fill(Data);
            return Data;
        }
        public List<Student> Select_Stu2(string Prop, string Val)
        {
            string select = "select * from student where " + Prop + " like " + "'%" + Val + "%'";
            SqlCommand cmd = new SqlCommand(select, con, tran);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> list = Deliver(reader);
            con.Close();
            return list;
        }
        public List<Student> Select_Stu3(string Prop, string Scor1, string Scor2)
        {
            string select = String.Format("select * from student where {0} between {1} and {2}", Prop, Convert.ToInt32(Scor1), Convert.ToInt32(Scor2));
            SqlCommand cmd = new SqlCommand(select, con, tran);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> list = Deliver(reader);
            con.Close();
            return list;
        }
    }
}

