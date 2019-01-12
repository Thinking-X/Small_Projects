using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMarketProj.PublicClass
{
    public class Users
    {
        private string roleNum;
        private string userNum;
        private string userPwd;

        public string RoleNum { get => roleNum; set => roleNum = value; }
        public string UserNum { get => userNum; set => userNum = value; }
        public string UserPwd { get => userPwd; set => userPwd = value; }
    }
}
