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
    public partial class Form_Sale : Form
    {
        public Form_Sale()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        SaleDAO saleDAO = new SaleDAO();
        private void ChangeColumnNames(bool flag, string prop)
        {
            if (flag)
            {
                View_Sale.Columns["SaleTabNum"].HeaderText = "销售单号";
                View_Sale.Columns["SaleDate"].HeaderText = "销售日期";
                View_Sale.Columns["MemNum"].HeaderText = "会员号";
                View_Sale.Columns["SaleTotal"].HeaderText = "销售总和";
            }
            else
            {
                View_Sale.Columns[0].HeaderText = prop;
            }
            return;
        }
        private void RefreshTable()
        {
            View_Sale.AutoGenerateColumns = true;
            View_Sale.DataSource = saleDAO.SelectAllSale();
            ChangeColumnNames(true, "");
            return;
        }
        private void Form_Sale_Load(object sender, EventArgs e)
        {
            RefreshTable();
            Dictionary<string, string> Dic = new Dictionary<string, string>();
            Dic.Add("销售单号", "SaleTabNum");
            Dic.Add("销售日期", "SaleDate");
            Dic.Add("会员号", "MemNum");
            Dic.Add("销售总和", "SaleTotal");
            var t = Dic.Select(u => new { key = u.Key, value = u.Value });
            comboProp.DataSource = t.ToList();
            comboProp.DisplayMember = "key";
            comboProp.ValueMember = "value";
            return;
        }
        private void View_Sale_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
            View_Sale.AutoGenerateColumns = true;
            string prop = comboProp.SelectedValue.ToString().Trim();
            string val = textVal.Text.ToString().Trim();
            if (val != "")
            {
                View_Sale.DataSource = saleDAO.Select_Sale(prop, val, true);
                ChangeColumnNames(true, "");
            }
            else
            {
                View_Sale.DataSource = saleDAO.Select_Sale(prop, "", false);
                ChangeColumnNames(false, comboProp.Text.Trim());
            }
            return;
        }
    }
}
