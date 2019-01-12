using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMarketProj.DAL
{
    class DBHelper
    {
        private static string Login = "data source = .; initial catalog = SMarket; integrated security = true";
        public static SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(Login);
            return conn;
        }
    }
}
