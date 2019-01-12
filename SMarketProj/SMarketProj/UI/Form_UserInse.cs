using SMarketProj.DAL;
using SMarketProj.PublicClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMarketProj.UI
{
    public partial class Form_UserInse : Form
    {
        public Form_UserInse()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        UsersDAO usersDAO = new UsersDAO();
        private void Clean()
        {
            RoleNum.Text = "";
            UserNum.Text = "";
            UserPwd.Text = "";
            return;
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            if (RoleNum.Text.Trim() == "")
            {
                MessageBox.Show("请输入角色号！");
                return;
            }
            user.RoleNum = RoleNum.Text.Trim();
            if (UserNum.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户号！");
                return;
            }
            user.UserNum = UserNum.Text.Trim();
            if(UserPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户密码！");
                return;
            }
            user.UserPwd = UserPwd.Text.Trim();
            if (usersDAO.Insert_user(user))
            {
                MessageBox.Show("成功添加一个用户！");
                Clean();
            }
            else
            {
                MessageBox.Show("添加用户失败！");
            }
            return;
        }
    }
}
