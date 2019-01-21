using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelProj
{
    class DBHelper
    {
        public static string Login = "data source = .; initial catalog = Library; Integrated Security = True";
        public static SqlConnection Connect()
        { 
            SqlConnection connection = new SqlConnection(Login);
            return connection;
        }
    }
}
