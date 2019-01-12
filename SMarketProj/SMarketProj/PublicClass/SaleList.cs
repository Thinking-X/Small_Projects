using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMarketProj.PublicClass
{
    class SaleList
    {
        private string saleTabNum;
        private string prodNum;
        private int saleQuantity;
        public string SaleTabNum { get => saleTabNum; set => saleTabNum = value; }
        public string ProdNum { get => prodNum; set => prodNum = value; }
        public int SaleQuantity { get => saleQuantity; set => saleQuantity = value; }
    }
}
