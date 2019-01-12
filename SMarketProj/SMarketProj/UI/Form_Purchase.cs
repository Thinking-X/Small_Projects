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
    public partial class Form_Purchase : Form
    {
        public Form_Purchase()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        PurchDAO purchDAO = new PurchDAO();
        private void ChangeColumnNames(bool flag, string prop)
        {
            if (flag)
            {
                View_Purc.Columns["PurcTabNum"].HeaderText = "进货单号";
                View_Purc.Columns["PurcDate"].HeaderText = "进货日期";
                View_Purc.Columns["PordNum"].HeaderText = "商品号";
                View_Purc.Columns["PurcQuan"].HeaderText = "进货数量";
                View_Purc.Columns["PurcTotal"].HeaderText = "进货总金额";
            }
            else
            {
                View_Purc.Columns[0].HeaderText = prop;
            }
            return;
        }
        private void RefreshTable()
        {
            View_Purc.AutoGenerateColumns = true;
            View_Purc.DataSource = purchDAO.SelectAllPurch();
            ChangeColumnNames(true, "");
            return;
        }
        private void Form_Purchase_Load(object sender, EventArgs e)
        {
            RefreshTable();
            Dictionary<string, string> Dic = new Dictionary<string, string>();
            Dic.Add("进货单号", "PurcTabNum");
            Dic.Add("进货日期", "PurcDate");
            Dic.Add("商品号", "PordNum");
            Dic.Add("进货数量", "PurcQuan");
            Dic.Add("进货总金额", "PurcTotal");
            var t = Dic.Select(u => new { key = u.Key, value = u.Value });
            comboProp.DataSource = t.ToList();
            comboProp.DisplayMember = "key";
            comboProp.ValueMember = "value";
            return;
        }
        private void View_Purc_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
        private void Select_Click(object sender, EventArgs e)
        {
            View_Purc.AutoGenerateColumns = true;
            string prop = comboProp.SelectedValue.ToString().Trim();
            string val = textVal.Text.ToString().Trim();
            if (val != "")
            {
                View_Purc.DataSource = purchDAO.Select_Purch(prop, val, true);
                ChangeColumnNames(true, "");
            }
            else
            {
                View_Purc.DataSource = purchDAO.Select_Purch(prop, "", false);
                ChangeColumnNames(false, comboProp.Text.Trim());
            }
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
            Form_PurchInse ProdIDUS = new Form_PurchInse();
            ProdIDUS.StartPosition = FormStartPosition.CenterScreen;
            ProdIDUS.ShowDialog();
            RefreshTable();
            this.Show();
            return;
        }
    }
}
