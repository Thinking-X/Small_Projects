using StudentApp.PublicClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.DAL
{
    class CustomDAO
    {
        public CustomDAO()
        {
            con = DBHelper.Connect();
        }
        SqlConnection con;
        SqlTransaction tran = null;
        public List<All> Deliver(SqlDataReader reader)
        {
            List<All> list = new List<All>();
            while (reader.Read())
            {
                All all = new All();

                all.Sid = reader["Sid"].ToString();
                if (!(reader["Sname"] is DBNull))
                {
                    all.Sname = reader["Sname"].ToString();
                }
                if (!(reader["Sex"] is DBNull))
                {
                    all.Sex = reader["Sex"].ToString();
                }
                if (!(reader["ClassName"] is DBNull))
                {
                    all.ClassName = reader["ClassName"].ToString();
                }
                if (!(reader["Birthdate"] is DBNull))
                {
                    all.Birthdate = Convert.ToDateTime(reader["Birthdate"]);
                }
                if (!(reader["AScores"] is DBNull))
                {
                    all.AScores = Convert.ToDecimal(reader["AScores"]);
                }

                if (!(reader["No"] is DBNull))
                {
                    all.No = Convert.ToInt32(reader["No"]);
                }
                all.Cid = reader["Cid"].ToString();
                if (!(reader["Cname"] is DBNull))
                {
                    all.Cname = reader["Cname"].ToString();
                }
                if (!(reader["Credit"] is DBNull))
                {
                    all.Credit = Convert.ToDecimal(reader["Credit"]);
                }

                if (!(reader["Scores"] is DBNull))
                {
                    all.Scores = Convert.ToDecimal(reader["Scores"]);
                }
                list.Add(all);
            }
            return list;
        }
        public List<All> SelectAll_SC()
        {
            string select = String.Format("select sc.SID, sname, sex, ClassName, Birthdate, Ascores, No, sc.CID, Cname, Credit, Scores from student, course, sc  where sc.SID = Student.SID and sc.CID = Course.CID");
            SqlCommand cmd = new SqlCommand(select, con, tran);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<All> list = Deliver(reader);
            con.Close();
            return list;
        }
        public List<All> SelectAll_Stu()
        {
            string select = String.Format("select T.SID,sname,sex,ClassName,Birthdate,Ascores,No,course.CID,Cname,Credit,Scores from(select sname, sex, Birthdate, Ascores, student.SID, ClassName, Scores, CID from Student left outer join sc on student.SID = sc.SID) as T left outer join Course on T.CID = Course.CID");
            SqlCommand cmd = new SqlCommand(select, con, tran);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<All> list = Deliver(reader);
            con.Close();
            return list;
        }
        public List<All> SelectAll_Cour()
        {
            string select = String.Format("select Student.SID,sname,sex,ClassName,Birthdate,Ascores,No,T.CID,Cname,Credit,Scores from(select course.CID, Cname, No, Credit, Scores, sc.SID from Course left outer join sc on Course.CID = sc.CID) as T left outer join Student on T.SID = Student.SID");
            SqlCommand cmd = new SqlCommand(select, con, tran);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<All> list = Deliver(reader);
            con.Close();
            return list;
        }
    }
}
