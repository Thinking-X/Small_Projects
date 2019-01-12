using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using SMarketProj.DAL;
using SMarketProj.PublicClass;

namespace Login_Form_Design_Example
{
    public partial class Login : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Login()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
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
            var t = Dic.Select(u => new { Key = u.Key, Value = u.Value });
            comboRole.DataSource = t.ToList();
            comboRole.ValueMember = "key";
            comboRole.DisplayMember = "Value";
            cbxRemember.Checked = SMarketProj.Properties.Settings.Default.CheckBox;
            txtNum.Text = SMarketProj.Properties.Settings.Default.UserName;
            txtPwd.Text = SMarketProj.Properties.Settings.Default.Password;
            return;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.RoleNum = comboRole.SelectedValue.ToString().Trim();
            user.UserNum = txtNum.Text.Trim();
            user.UserPwd = txtPwd.Text.Trim();
            if (txtNum.Text.Trim() == "" && txtPwd.Text.Trim() == "")
            {
                lblErrorMessage.ForeColor = Color.Red;
                lblErrorMessage.Text = "用户名和密码不可为空！";
                return;
            }
            if (userDAO.Proving(user))
            {
                SelfClosingMessageBox.StartKiller("提示", 500);
                MessageBox.Show("输入正确！", "提示");
                result = user.RoleNum;
                userNum = user.UserNum;
                if (cbxRemember.Checked)
                {
                    SMarketProj.Properties.Settings.Default.UserName = txtNum.Text.Trim();
                    SMarketProj.Properties.Settings.Default.Password = txtPwd.Text.Trim();
                    SMarketProj.Properties.Settings.Default.CheckBox = cbxRemember.Checked;
                    SMarketProj.Properties.Settings.Default.Save();
                }
                this.Dispose();
            }         
            else
            {
                lblErrorMessage.ForeColor = Color.Red;
                lblErrorMessage.Text = "该用户名和密码不存在！";
                txtNum.Text = "";
                txtPwd.Text = "";
            }
        }
        private void txtNum_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "";
            return;
        }
        private void txtPwd_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "";
            return;
        }
    }
}
