using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.PublicClass
{
    class All
    {
        private string sid;
        private string sname;
        private string sex;
        private string className;
        private DateTime birthdate;
        private Decimal aScores;

        private int no;
        private string cid;
        private string cname;
        private decimal credit;

        private decimal scores;

        public string Sid { get => sid; set => sid = value; }
        public string Sname { get => sname; set => sname = value; }
        public string Sex { get => sex; set => sex = value; }
        public string ClassName { get => className; set => className = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public Decimal AScores { get => aScores; set => aScores = value; }

        public int No { get => no; set => no = value; }
        public string Cid { get => cid; set => cid = value; }
        public string Cname { get => cname; set => cname = value; }
        public decimal Credit { get => credit; set => credit = value; }
 
        public decimal Scores { get => scores; set => scores = value; }
    }
}
