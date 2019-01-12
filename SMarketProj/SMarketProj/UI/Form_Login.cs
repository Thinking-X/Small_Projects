using SMarketProj.DAL;
using SMarketProj.PublicClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace SMarketProj
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();//画窗体控件
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        public string result = "000";
        public string userNum = ""; 
        UsersDAO userDAO = new UsersDAO();
        private void Login_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> Dic = new Dictionary<string, string>();
            Dic.Add("1", "经理");
            Dic.Add("10", "收银员");
            Dic.Add("100", "会员");
            var t = Dic.Select(u => new { Key = u.Key, Value = u.Value});
            Role.DataSource = t.ToList();
            Role.ValueMember = "key";
            Role.DisplayMember = "Value";
            return;
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.RoleNum = Role.SelectedValue.ToString().Trim();
            user.UserNum = Num.Text.ToString().Trim();
            user.UserPwd = Pwd.Text.ToString().Trim();
            if (userDAO.Proving(user))
            {
                SelfClosingMessageBox.StartKiller("提示", 500);
                MessageBox.Show("输入正确！", "提示");
                result = user.RoleNum;
                userNum = user.UserNum;
                this.Dispose();
            }
            else
            {
                SelfClosingMessageBox.StartKiller("提示", 1000);
                MessageBox.Show("您输入有误！请重新输入！", "提示");
                Num.Text = "";
                Pwd.Text = "";
            }
        }
    }
}
