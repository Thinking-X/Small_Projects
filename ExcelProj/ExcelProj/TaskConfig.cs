using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelProj
{
    class TaskConfig
    {
        private string iD;
        private string name;
        private string status;
        private int beginNum;
        private int endNum;

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public int BeginNum { get => beginNum; set => beginNum = value; }
        public int EndNum { get => endNum; set => endNum = value; }
    }
}
