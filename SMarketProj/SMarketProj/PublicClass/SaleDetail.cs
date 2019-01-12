using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMarketProj.PublicClass
{
    public class SaleDetail
    {
        private string saleTabNum;
        private DateTime saleDate;
        private string memNum;
        private double saleTotal;

        public string SaleTabNum { get => saleTabNum; set => saleTabNum = value; }
        public DateTime SaleDate { get => saleDate; set => saleDate = value; }
        public string MemNum { get => memNum; set => memNum = value; }
        public double SaleTotal { get => saleTotal; set => saleTotal = value; }
    }
}
