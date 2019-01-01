using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.PublicClass
{
    class Portrait
    {
        private string stu_ID;
        private byte[] stu_Image;

        public string Stu_ID { get => stu_ID; set => stu_ID = value; }
        public byte[] Stu_Image { get => stu_Image; set => stu_Image = value; }
    }
}
