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
    public partial class Form_Member : Form
    {
        public Form_Member()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        MembDAO membDAO = new MembDAO();
        private void View_Memb_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
        private void RefreshTable()
        {
            View_Memb.AutoGenerateColumns = true;
            View_Memb.DataSource = membDAO.SelectAllMemb();
            ChangeColumnNames(true, "");
            Delete.Enabled = true;
            return;
        }
        private void Form_Member_Load(object sender, EventArgs e)
        {
            RefreshTable();
            Dictionary<string, string> Dic = new Dictionary<string, string>();
            Dic.Add("会员号", "MemNum");
            Dic.Add("会员密码", "MemPwd");
            Dic.Add("会员积分", "Grade");
            Dic.Add("会员名", "MemName");
            Dic.Add("性别", "Gender");
            Dic.Add("身份证号", "IdNum");
            Dic.Add("地址", "FAddress");
            var t = Dic.Select(u => new { key = u.Key, value = u.Value });
            comboProp.DataSource = t.ToList();
            comboProp.DisplayMember = "key";
            comboProp.ValueMember = "value";
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
            Form_MembIDU MembIDUS = new Form_MembIDU(null, Insert.Text);
            MembIDUS.StartPosition = FormStartPosition.CenterScreen;
            MembIDUS.ShowDialog();
            RefreshTable();
            this.Show();
            return;
        }
        private void ChangeColumnNames(bool flag, string prop)
        {
            if (flag)
            {
                View_Memb.Columns["MemNum"].HeaderText = "会员号";
                View_Memb.Columns["MemPwd"].HeaderText = "会员密码";
                View_Memb.Columns["Grade"].HeaderText = "会员积分";
                View_Memb.Columns["MemName"].HeaderText = "会员名";
                View_Memb.Columns["Gender"].HeaderText = "性别";
                View_Memb.Columns["IdNum"].HeaderText = "身份证号";
                View_Memb.Columns["FAddress"].HeaderText = "地址";
            }
            else
            {
                View_Memb.Columns[0].HeaderText = prop;
            }
            return;
        }
        private void Select_Click(object sender, EventArgs e)
        {
            View_Memb.AutoGenerateColumns = true;
            string prop = comboProp.SelectedValue.ToString().Trim();
            string val = textVal.Text.ToString().Trim();
            if (val != "")
            {
                View_Memb.DataSource = membDAO.Select_Memb(prop, val, true);
                ChangeColumnNames(true, "");
                Delete.Enabled = true;
            }
            else
            {
                View_Memb.DataSource = membDAO.Select_Memb (prop, "", false);
                ChangeColumnNames(false, comboProp.Text.Trim());
                Delete.Enabled = false;
            }
            return;
        }
        private Member Deliver()
        {
            Member Memb = new Member();
            Memb.MemNum = View_Memb.SelectedRows[0].Cells[0].Value.ToString();
            Memb.MemPwd = View_Memb.SelectedRows[0].Cells[1].Value.ToString();
            Memb.Grade = Convert.ToInt32(View_Memb.SelectedRows[0].Cells[2].Value);
            Memb.MemName = View_Memb.SelectedRows[0].Cells[3].Value.ToString();
            Memb.Gender = View_Memb.SelectedRows[0].Cells[4].Value.ToString();
            Memb.IdNum = View_Memb.SelectedRows[0].Cells[5].Value.ToString();
            Memb.FAddress = View_Memb.SelectedRows[0].Cells[6].Value.ToString();
            return Memb;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (View_Memb.SelectedRows.Count != 1)
            {
                MessageBox.Show("请点击索引，选择一行！");
                return;
            }
            this.Hide();
            Member Memb = Deliver();
            Form_MembIDU MembIDU = new Form_MembIDU(Memb, Delete.Text);
            MembIDU.StartPosition = FormStartPosition.CenterScreen;
            MembIDU.ShowDialog();
            RefreshTable();
            this.Show();
            return;
        }
    }
}
