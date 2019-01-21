using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelProj
{
    public class Templet
    {
        private string code;
        private string areaCode;
        private int quantity;
        private int sortedQuan;
        private string sortState;

        public string Code { get => code; set => code = value; }
        public string AreaCode { get => areaCode; set => areaCode = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int SortedQuan { get => sortedQuan; set => sortedQuan = value; }
        public string SortState { get => sortState; set => sortState = value; }
    }
}
