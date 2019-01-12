using SMarketProj.DAL;
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
    public partial class Form_Users : Form
    {
        public Form_Users()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        UsersDAO usersDAO = new UsersDAO();
        private void ChangeColumnNames(bool flag, string prop)
        {
            if (flag)
            {
                View_User.Columns["RoleNum"].HeaderText = "角色号";
                View_User.Columns["UserNum"].HeaderText = "用户名";
                View_User.Columns["UserPwd"].HeaderText = "用户密码";
            }
            else
            {
                View_User.Columns[0].HeaderText = prop;
            }
            return;
        }
        private void RefreshTable()
        {
            View_User.AutoGenerateColumns = true;
            View_User.DataSource = usersDAO.SelectAllUser();
            ChangeColumnNames(true, "");
            return;
        }
        private void Form_Users_Load(object sender, EventArgs e)
        {
            RefreshTable();
            Dictionary<string, string> Dic = new Dictionary<string, string>();
            Dic.Add("角色号", "RoleNum");
            Dic.Add("用户名", "UserNum");
            var t = Dic.Select(u => new { key = u.Key, value = u.Value });
            comboProp.DataSource = t.ToList();
            comboProp.DisplayMember = "key";
            comboProp.ValueMember = "value";
            return;
        }
        private void View_User_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();
            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
            return;
        }
        private void Display_Click(object sender, EventArgs e)
        {
            RefreshTable();
            return;
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_UserInse UserInse = new Form_UserInse();
            UserInse.StartPosition = FormStartPosition.CenterScreen;
            UserInse.ShowDialog();
            RefreshTable();
            this.Show();
            return;
        }
        private void Select_Click(object sender, EventArgs e)
        {
            View_User.AutoGenerateColumns = true;
            string prop = comboProp.SelectedValue.ToString().Trim();
            string val = textVal.Text.ToString().Trim();
            if (val != "")
            {
                View_User.DataSource = usersDAO.Select_User(prop, val, true);
                ChangeColumnNames(true, "");
            }
            else
            {
                View_User.DataSource = usersDAO.Select_User(prop, "", false);
                ChangeColumnNames(false, comboProp.Text.Trim());
            }
            return;
        }
    }
}
