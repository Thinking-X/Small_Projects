using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NewsPublishSystem.DAL
{
    class DBHelper
    {
        private static string Login = "data source=.;initial catalog=NewsPublishDB;Integrated Security=True";
        //server=.;database=educ;Trusted_Connection=true;
        public static SqlConnection Connect()
        {
            SqlConnection sqlConnection = new SqlConnection(Login);
            return sqlConnection;
        }
    }
}