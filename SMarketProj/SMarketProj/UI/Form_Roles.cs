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
    public partial class Form_Roles : Form
    {
        public Form_Roles()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        RoleDAO roleDAO = new RoleDAO();
        private void ChangeColumnNames(bool flag, string prop)
        {
            if (flag)
            {
                View_Role.Columns["RoleNum"].HeaderText = "角色号";
                View_Role.Columns["RoleName"].HeaderText = "角色名";
            }
            else
            {
                View_Role.Columns[0].HeaderText = prop;
            }
            return;
        }
        private void RefreshTable()
        {
            View_Role.AutoGenerateColumns = true;
            View_Role.DataSource = roleDAO.SelectAllRole();
            ChangeColumnNames(true, "");
            return;
        }
        private void Form_Roles_Load(object sender, EventArgs e)
        {
            RefreshTable();
            Dictionary<string, string> Dic = new Dictionary<string, string>();
            Dic.Add("角色号", "RoleNum");
            Dic.Add("角色名", "RoleName");
            var t = Dic.Select(u => new { key = u.Key, value = u.Value });
            comboProp.DataSource = t.ToList();
            comboProp.DisplayMember = "key";
            comboProp.ValueMember = "value";
            return;
        }
        private void View_Role_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
        private void DisplayTable_Click(object sender, EventArgs e)
        {
            RefreshTable();
            return;
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_RoleInse RoleInse = new Form_RoleInse();
            RoleInse.StartPosition = FormStartPosition.CenterScreen;
            RoleInse.ShowDialog();
            RefreshTable();
            this.Show();
            return;
        }
        private void Select_Click(object sender, EventArgs e)
        {
            View_Role.AutoGenerateColumns = true;
            string prop = comboProp.SelectedValue.ToString().Trim();
            string val = textVal.Text.ToString().Trim();
            if (val != "")
            {
                View_Role.DataSource = roleDAO.Select_Role(prop, val, true);
                ChangeColumnNames(true, "");
            }
            else
            {
                View_Role.DataSource = roleDAO.Select_Role(prop, "", false);
                ChangeColumnNames(false, comboProp.Text.Trim());
            }
            return;
        }        
    }
}
