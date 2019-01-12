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
    public partial class Form_SList : Form
    {
        public Form_SList()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        SListDAO slistDAO = new SListDAO();
        private void ChangeColumnNames(bool flag, string prop)
        {
            if (flag)
            {
                View_SList.Columns["SaleTabNum"].HeaderText = "销售单号";
                View_SList.Columns["ProdNum"].HeaderText = "商品号";
                View_SList.Columns["SaleQuantity"].HeaderText = "销售数量";
            }
            else
            {
                View_SList.Columns[0].HeaderText = prop;
            }
            return;
        }
        private void RefreshTable()
        {
            View_SList.AutoGenerateColumns = true;
            View_SList.DataSource = slistDAO.SelectAllList();
            ChangeColumnNames(true, "");
            return;
        }
        private void Form_SList_Load(object sender, EventArgs e)
        {
            RefreshTable();
            Dictionary<string, string> Dic = new Dictionary<string, string>();
            Dic.Add("销售单号", "SaleTabNum");
            Dic.Add("商品号", "ProdNum");
            Dic.Add("销售数量", "SaleQuantity");
            var t = Dic.Select(u => new { key = u.Key, value = u.Value });
            comboProp.DataSource = t.ToList();
            comboProp.DisplayMember = "key";
            comboProp.ValueMember = "value";
            return;
        }
        private void View_SList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
        private void Select_Click(object sender, EventArgs e)
        {
            View_SList.AutoGenerateColumns = true;
            string prop = comboProp.SelectedValue.ToString().Trim();
            string val = textVal.Text.ToString().Trim();
            if (val != "")
            {
                View_SList.DataSource = slistDAO.Select_List(prop, val, true);
                ChangeColumnNames(true, "");
            }
            else
            {
                View_SList.DataSource = slistDAO.Select_List(prop, "", false);
                ChangeColumnNames(false, comboProp.Text.Trim());
            }
            return;
        }
    }
}
