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
    public partial class Form_RoleInse : Form
    {
        public Form_RoleInse()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        RoleDAO roleDAO = new RoleDAO();
        private void Clean()
        {
            RoleNum.Text = "";
            RoleName.Text = "";
            return;
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            Roles role = new Roles();
            if(RoleNum.Text.Trim() == "")
            {
                MessageBox.Show("请输入角色号！");
                return;
            }
            role.RoleNum = RoleNum.Text.Trim();
            if (RoleName.Text.Trim() == "")
            {
                MessageBox.Show("请输入角色名！");
                return;
            }
            role.RoleName = RoleName.Text.Trim();
            if (roleDAO.Insert_Role(role))
            {
                MessageBox.Show("成功添加一个角色！");
                Clean();
            }
            else
            {
                MessageBox.Show("添加角色失败！");
            }
            return;
        }
    }
}
