using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMarketProj.PublicClass
{
    public class PurchaseDetail
    {
        private string purcTabNum;
        private DateTime purcDate;
        private string pordNum;
        private int purcQuan;
        private int purcTotal;
        public string PurcTabNum { get => purcTabNum; set => purcTabNum = value; }
        public DateTime PurcDate { get => purcDate; set => purcDate = value; }
        public string PordNum { get => pordNum; set => pordNum = value; }
        public int PurcQuan { get => purcQuan; set => purcQuan = value; }
        public int PurcTotal { get => purcTotal; set => purcTotal = value; }
    }
}
