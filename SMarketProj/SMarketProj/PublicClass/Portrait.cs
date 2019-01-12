using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMarketProj.PublicClass
{
    class Portrait
    {
        private string userNum;
        private byte[] userPortr;

        public string UserNum { get => userNum; set => userNum = value; }
        public byte[] UserPortr { get => userPortr; set => userPortr = value; }
    }
}
