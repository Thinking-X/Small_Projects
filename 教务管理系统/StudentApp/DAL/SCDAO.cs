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
    class SCDAO
    {
        public SCDAO()
        {
            con = DBHelper.Connect();
        }
        SqlConnection con;
        SqlTransaction tran = null;
        public List<SC> Deliver(SqlDataReader reader)
        {
            List<SC> list = new List<SC>();
            while (reader.Read())
            {
                SC sc = new SC();
                sc.Sid = reader["Sid"].ToString();
                sc.Cid = reader["Cid"].ToString();
                if(!(reader["Scores"] is DBNull))
                {
                    sc.Scores = Convert.ToDecimal(reader["Scores"]);
                }
                list.Add(sc);
            }
            return list;
        }
        public List<SC> DisplayTableSc()
        {
            string Sentence = "select * from sc";
            SqlCommand cmd = new SqlCommand(Sentence, con, tran);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<SC> list = Deliver(reader);
            con.Close();
            return list;
        }
        public int GainSumline()//获取表的总行数
        {
            string Sentence = "select count(*) from sc";
            SqlCommand cmd = new SqlCommand(Sentence, con, tran);
            con.Open();
            int sum = (int)cmd.ExecuteScalar();
            con.Close();
            return sum;
        }
        public List<SC> DisplayPage(int LineNum, int i)
        {
            string Sentence = String.Format("select * from (select ROW_NUMBER() over(order by sid) as RowNo, * from sc) as part where RowNo between ({0}*({1}-1)+1) and ({2}*{3})", LineNum, i, LineNum, i);
            SqlCommand cmd = new SqlCommand(Sentence, con, tran);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<SC> list = Deliver(reader);
            con.Close();
            return list;
        }
        public bool Insert_SC(SC sc)
        {
            string insert = string.Format("insert into SC values ('{0}', '{1}', {2})", sc.Sid, sc.Cid, sc.Scores);
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
        public bool Delete_SC(string sid,string cid)
        {
            string delete = String.Format("delete sc where sid = '{0}' and  cid='{1}'", sid, cid);
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
        public bool Update_SC(SC sc)
        {
            string update = string.Format("update sc set scores = '{0}' where sid = '{1}' and cid = '{2}'", sc.Scores, sc.Sid, sc.Cid);
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
        public DataTable Select_SC1(string Prop)
        {
            string select = "select " + Prop + " from sc";
            SqlCommand cmd = new SqlCommand(select, con, tran);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable Data = new DataTable();
            adapter.Fill(Data);
            return Data;
        }
        public List<SC> Select_SC2(string Prop, string Val)
        {
            string select = "select * from sc where " + Prop + " like " + "'%" + Val + "%'";
            SqlCommand cmd = new SqlCommand(select, con, tran);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<SC> list = Deliver(reader);
            con.Close();
            return list;
        }
        public List<SC> Select_SC3(string Prop, string Scor1, string Scor2)
        {
            string select = String.Format("select * from SC where {0} between {1} and {2}", Prop, Scor1, Scor2);
            SqlCommand cmd = new SqlCommand(select, con, tran);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<SC> list = Deliver(reader);
            con.Close();
            return list;
        }
    }
}
