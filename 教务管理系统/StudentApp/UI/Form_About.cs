using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp.UI
{
    public partial class Form_About : Form
    {
        public Form_About()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            label.Text = "感谢您使用本公司开发的软件！您的使用是我们\n最大的荣幸！本程序是为管理学校教务数据库而\n开发的软件，在基本的“增”“删”“改”“查”\n功能之上，又添加了许多BUG处理，以增强程序的\n健壮性。尽管在上线之前测试了好多次，但仍可能\n还有其他不可预料的BUG，为您带来不便，希望您\n及时反馈给我们，我们会在第一时间为您解决。除\n此之外，又增加了一些方便您使用的功能。\n祝您使用愉快。";
        }
    }
}
