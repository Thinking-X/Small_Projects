using StudentApp.PublicClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp.DAL
{
    class PortrDAO
    {
        public PortrDAO()
        {
            conn = DBHelper.Connect();
        }
        SqlConnection conn;
        SqlTransaction tran = null;
        public bool Insert_Portr(Portrait Portr)
        {
            string insert = "insert into Portrait values(@ID,@imgfile)";
            SqlCommand CMD = new SqlCommand(insert,conn,tran);
            conn.Open();
            CMD.Parameters.AddWithValue("@ID", Portr.Stu_ID);
            CMD.Parameters.AddWithValue("@imgfile", Portr.Stu_Image);
            //SqlParameter par = new SqlParameter("@imgfile", SqlDbType.Image);
            //par.Value = Portr.Stu_Image;
            //CMD.Parameters.Add(par);
            int result = CMD.ExecuteNonQuery();
            conn.Close();
            if (result == 1)
            {
                return true;
            }
            return false;
        }
        public List<string> SelectAllSID()
        {
            string select = "select sid from Student";
            conn.Open();
            SqlCommand CMD = new SqlCommand(select, conn, tran);
            SqlDataReader reader =  CMD.ExecuteReader();
            List<String> list = new List<String>();
            while(reader.Read())
            {
                if (!(reader[0] is DBNull))
                {
                    String Sid = reader[0].ToString();
                    list.Add(Sid);
                }
            }
            conn.Close();
            return list;
        }
        public DataTable DisplayAllSID()
        {
            string select = "select sid from Student";
            SqlCommand CMD = new SqlCommand(select, conn, tran);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            DataTable Table = new DataTable();
            adapter.Fill(Table);
            return Table;
        }
        public int Select_SID(string sid)
        {
            string select = String.Format("select Count(*) from  Portrait where Stu_ID = '{0}'", sid);
            SqlCommand CMD = new SqlCommand(select, conn, tran);
            conn.Open();
            int result = (int)CMD.ExecuteScalar();
            conn.Close();
            return result; 
        }
        public byte[] DisplayImg(string sid)
        {
            string select = String.Format("select Stu_Image from Portrait where Stu_ID = '{0}'", sid);
            byte[] MyData = new byte[0];
            conn.Open();
            SqlCommand cmd = new SqlCommand(select,conn,tran);
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                if (!(sdr["Stu_Image"] is DBNull))
                {
                    MyData = (Byte[])sdr["Stu_Image"];
                }
            }      
            conn.Close();
            return MyData;
        }
        public Student SelectOneStu(string sid)
        {
            string select = String.Format("select * from student where sid = '{0}'", sid);
            conn.Open();
            SqlCommand CMD = new SqlCommand(select,conn,tran);
            SqlDataReader reader = CMD.ExecuteReader();
            Student stu = new Student();
            while(reader.Read())
            {
                if (!(reader["Sid"] is DBNull))
                {
                    stu.Sid = reader["SID"].ToString();
                }
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
            }
            conn.Close();
            return stu;
        }
        public bool Delete_Portr(string Sid)
        {
            string delete = String.Format("delete Portrait where Stu_ID = '{0}'", Sid);
            conn.Open();
            SqlCommand CMD = new SqlCommand(delete, conn, tran);
            int result = CMD.ExecuteNonQuery();
            conn.Close();
            if (result == 1)
            {
                return true;
            }
            return false;
        }
        public bool Update_Portr(Portrait portr)
        {
            string delete = @"update Portrait set Stu_Image =  @Stu_Image where Stu_ID = @Stu_ID";
            conn.Open();
            SqlCommand CMD = new SqlCommand(delete, conn, tran);
            CMD.Parameters.AddWithValue("@Stu_Image", portr.Stu_Image);
            CMD.Parameters.AddWithValue("@Stu_ID", portr.Stu_ID);
            int result = CMD.ExecuteNonQuery();
            conn.Close();
            if (result == 1)
            {
                return true;
            }
            return false;
        }
        public byte[] RollDisplay(int i,out string sid)
        {
            string Sentence = String.Format("select * from (select ROW_NUMBER() over(order by Stu_ID) as RowNo, * from Portrait) as part where RowNo between {0} and {1}", i, i);
            conn.Open();
            SqlCommand CMD = new SqlCommand(Sentence, conn, tran);
            SqlDataReader sdr= CMD.ExecuteReader();
            byte[] MyData = new byte[0];
            sid = "";
            while (sdr.Read())
            {
                if (!(sdr["Stu_ID"] is DBNull))
                {
                    sid = sdr["Stu_ID"].ToString().Trim();
                }
                if (!(sdr["Stu_Image"] is DBNull))
                {
                    MyData = (Byte[])sdr["Stu_Image"];
                }
            }
            conn.Close();
            return MyData;
        }
        public int GainSumline()
        {
            string Sentence = "select count(*) from Portrait";
            SqlCommand cmd = new SqlCommand(Sentence, conn, tran);
            conn.Open();
            int sum = (int)cmd.ExecuteScalar();
            conn.Close();
            return sum;
        }
    }
}
