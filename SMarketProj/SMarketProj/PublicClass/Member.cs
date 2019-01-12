using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMarketProj.PublicClass
{
    public class Member
    {
        private string memNum;
        private string memPwd;
        private int grade;
        private string memName;
        private string gender;
        private string idNum;
        private string fAddress;

        public string MemNum { get => memNum; set => memNum = value; }
        public string MemPwd { get => memPwd; set => memPwd = value; }
        public int Grade { get => grade; set => grade = value; }
        public string MemName { get => memName; set => memName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string IdNum { get => idNum; set => idNum = value; }
        public string FAddress { get => fAddress; set => fAddress = value; }
    }
}
