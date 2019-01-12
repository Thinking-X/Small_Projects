using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMarketProj.PublicClass
{
    public class Product
    {
        private string prodNum;
        private string prodName;
        private int quantity;
        private decimal buyPrice;
        private decimal salePrice;

        public string ProdNum { get => prodNum; set => prodNum = value; }
        public string ProdName { get => prodName; set => prodName = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public decimal BuyPrice { get => buyPrice; set => buyPrice = value; }
        public decimal SalePrice { get => salePrice; set => salePrice = value; }
    }
}
