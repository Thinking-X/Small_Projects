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
    class CourseDAO
    {
        public CourseDAO()
        {
            con = DBHelper.Connect();
        }
        SqlConnection con;
        SqlTransaction tran = null;
        public List<Course> Deliver(SqlDataReader reader)
        {
            List<Course> list = new List<Course>();
            while (reader.Read())
            {
                Course cour = new Course();
                if (!(reader["No"] is DBNull))
                {
                    cour.No = Convert.ToInt32(reader["No"]);
                }
                cour.Cid = reader["Cid"].ToString();
                if (!(reader["Cname"] is DBNull))
                {
                    cour.Cname = reader["Cname"].ToString();
                }
                if (!(reader["Credit"] is DBNull))
                {
                    cour.Credit = Convert.ToDecimal(reader["Credit"]);
                }
                list.Add(cour);
            }
            return list;
        }
        public List<Course> DisplayTableCour()
        {
            string Sentence = "select * from course";
            SqlCommand cmd = new SqlCommand(Sentence, con, tran);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Course> list = Deliver(reader);
            con.Close();
            return list;
        }
        public int GainSumline()//获取表的总行数
        {
            string Sentence = "select count(*) from course";
            SqlCommand cmd = new SqlCommand(Sentence, con, tran);
            con.Open();
            int sum = (int)cmd.ExecuteScalar();
            con.Close();
            return sum;
        }
        public List<Course> DisplayPage(int LineNum, int i)
        {           
            string Sentence = String.Format("select * from (select ROW_NUMBER() over(order by cid) as RowNo, * from course) as part where RowNo between ({0}*({1}-1)+1) and ({2}*{3})", LineNum, i, LineNum, i);
            SqlCommand cmd = new SqlCommand(Sentence, con, tran);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Course> list = Deliver(reader);
            con.Close();
            return list;
        }
        public void Insert_Cour(Course cou)
        {
            string insert = string.Format("insert into course values ({0}, '{1}', '{2}', {3})", cou.No, cou.Cid, cou.Cname, cou.Credit);
            SqlCommand cmd = new SqlCommand(insert, con, tran);
            con.Open();
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("成功插入一行记录！");
                }
                else
                {
                    MessageBox.Show("插入失败！");
                }
            }
            catch
            {
                MessageBox.Show("执行出错，插入失败！");
            }
            con.Close();
            return;
        }
        public void Delete_Cour(string Id)
        {
            string delete = String.Format("delete course where cid = '{0}'", Id);
            SqlCommand cmd = new SqlCommand(delete, con, tran);
            con.Open();
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("成功删除一行记录！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
            catch
            {
                MessageBox.Show("执行出错，删除失败！");
            }
            con.Close();
            return;
        }
        public void Updata_Cour(Course cou)
        {
            string update = string.Format("update course set no = {0}, cname = '{1}', credit = '{2}' where cid = {3}", cou.No, cou.Cname, cou.Credit, cou.Cid);
            SqlCommand cmd = new SqlCommand(update, con, tran);
            con.Open();
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("成功更改一行记录！");
                }
                else
                {
                    MessageBox.Show("未作更改！");
                }
            }
            catch
            {
                MessageBox.Show("执行出错，更改失败！");
            }
            con.Close();
            return;
        }
        public DataTableCollection Select_Cour1(string Prop)
        {
            string select = "select " + Prop + " from course";
            SqlCommand cmd = new SqlCommand(select, con, tran);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet Data = new DataSet();
            adapter.Fill(Data, "T");
            con.Close();
            return Data.Tables;
        }
        public List<Course> Select_Cour2(string Prop, string Val)
        {
            string select = "select * from course where " + Prop + " like " + "'%" + Val + "%'";
            SqlCommand cmd = new SqlCommand(select, con, tran);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Course> list = Deliver(reader);
            con.Close();
            return list;
        }
        public List<Course> Select_Cour3(string Prop, string Scor1, string Scor2)
        {
            string select = String.Format("select * from course where {0} between {1} and {2}", Prop, Scor1, Scor2);
            SqlCommand cmd = new SqlCommand(select, con, tran);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Course> list = Deliver(reader);
            con.Close();
            return list;
        }
    }
}
