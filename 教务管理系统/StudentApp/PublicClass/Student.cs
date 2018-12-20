using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.PublicClass
{
    class Student
    {
        private string sid;
        private string sname;
        private string sex;
        private string className;
        private DateTime birthdate;    
        private Decimal aScores;
        public string Sid { get => sid; set => sid = value; }
        public string Sname { get => sname; set => sname = value; }
        public string Sex { get => sex; set => sex = value; }
        public string ClassName { get => className; set => className = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public Decimal AScores { get => aScores; set => aScores = value; }              
    }
}
