using SMarketProj.PublicClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMarketProj.DAL
{
    class PortrDAO
    {
        public PortrDAO()
        {
            Conn = DBHelper.Connect();
        }
        SqlConnection Conn;
        SqlTransaction Tran = null;
        public byte[] DisplayPortr(string UserNum)
        {
            string select = String.Format("select UserPortr from Portrait where UserNum = '{0}'", UserNum);
            byte[] MyData = new byte[0];
            Conn.Open();
            SqlCommand cmd = new SqlCommand(select, Conn, Tran);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                if (!(sdr["UserPortr"] is DBNull))
                {
                    MyData = (Byte[])sdr["UserPortr"];
                }
            }
            Conn.Close();
            return MyData;
        }
        public bool Update_Portr(Portrait portr)
        {
            string delete = @"update Portrait set UserPortr = @UserPortr where UserNum = @UserNum";
            Conn.Open();
            SqlCommand CMD = new SqlCommand(delete, Conn, Tran);
            CMD.Parameters.AddWithValue("@UserPortr", portr.UserPortr);
            CMD.Parameters.AddWithValue("@UserNum", portr.UserNum);
            int result = CMD.ExecuteNonQuery();
            Conn.Close();
            if (result == 1)
            {
                return true;
            }
            return false;
        }
        public bool Insert_Portr(Portrait Portr)
        {
            string insert = "insert into Portrait values(@ID,@imgfile)";
            SqlCommand CMD = new SqlCommand(insert, Conn, Tran);
            Conn.Open();
            CMD.Parameters.AddWithValue("@ID", Portr.UserNum);
            CMD.Parameters.AddWithValue("@imgfile", Portr.UserPortr);
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
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }  
        }
        public int SelectPortr(string UserNum)
        {
            string select = String.Format("select count(*) from Portrait where UserNum = '{0}'", UserNum);
            Conn.Open();
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
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
        public DataTable DisplayAllPortr()
        {
            string select = "select UserNum from Portrait";
            SqlCommand CMD = new SqlCommand(select, Conn, Tran);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            DataTable Table = new DataTable();
            adapter.Fill(Table);
            return Table;
        }
        //public int Select_SID(string sid)
        //{
        //    string select = String.Format("select Count(*) from  Portrait where Stu_ID = '{0}'", sid);
        //    SqlCommand CMD = new SqlCommand(select, Conn, Tran);
        //    Conn.Open();
        //    int result = (int)CMD.ExecuteScalar();
        //    Conn.Close();
        //    return result;
        //}

        //public bool Delete_Portr(string Sid)
        //{
        //    string delete = String.Format("delete Portrait where Stu_ID = '{0}'", Sid);
        //    Conn.Open();
        //    SqlCommand CMD = new SqlCommand(delete, Conn, Tran);
        //    int result = CMD.ExecuteNonQuery();
        //    Conn.Close();
        //    if (result == 1)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public byte[] RollDisplay(int i, out string sid)
        //{
        //    string Sentence = String.Format("select * from (select ROW_NUMBER() over(order by Stu_ID) as RowNo, * from Portrait) as part where RowNo between {0} and {1}", i, i);
        //    Conn.Open();
        //    SqlCommand CMD = new SqlCommand(Sentence, Conn, Tran);
        //    SqlDataReader sdr = CMD.ExecuteReader();
        //    byte[] MyData = new byte[0];
        //    sid = "";
        //    while (sdr.Read())
        //    {
        //        if (!(sdr["Stu_ID"] is DBNull))
        //        {
        //            sid = sdr["Stu_ID"].ToString().Trim();
        //        }
        //        if (!(sdr["Stu_Image"] is DBNull))
        //        {
        //            MyData = (Byte[])sdr["Stu_Image"];
        //        }
        //    }
        //    Conn.Close();
        //    return MyData;
        //}
        //public int GainSumline()
        //{
        //    string Sentence = "select count(*) from Portrait";
        //    SqlCommand cmd = new SqlCommand(Sentence, Conn, Tran);
        //    Conn.Open();
        //    int sum = (int)cmd.ExecuteScalar();
        //    Conn.Close();
        //    return sum;
        //}
    }
}
