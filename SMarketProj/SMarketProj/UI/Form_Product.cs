using SMarketProj.DAL;
using SMarketProj.PublicClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMarketProj.UI
{
    public partial class Form_Product : Form
    {
        public Form_Product()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        ProdDAO prodDAO = new ProdDAO();
        private void ChangeColumnNames(bool flag, string prop)
        {
            if (flag)
            {
                View_Prod.Columns["ProdNum"].HeaderText = "商品号";
                View_Prod.Columns["ProdName"].HeaderText = "商品名";
                View_Prod.Columns["Quantity"].HeaderText = "商品数量";
                View_Prod.Columns["BuyPrice"].HeaderText = "商品进价";
                View_Prod.Columns["SalePrice"].HeaderText = "商品售价";
            }
            else
            {
                View_Prod.Columns[0].HeaderText = prop;
            }
            return;
        }
        private void RefreshTable()
        {
            View_Prod.AutoGenerateColumns = true;
            View_Prod.DataSource = prodDAO.SelectAllProd();
            ChangeColumnNames(true, "");
            Update.Enabled = true;
            Delete.Enabled = true;
            return;
        }
        private void Form_Product_Load(object sender, EventArgs e)
        {
            RefreshTable();
            Dictionary<string, string> Dic = new Dictionary<string, string>();
            Dic.Add("商品号", "ProdNum");
            Dic.Add("商品名", "ProdName");
            Dic.Add("商品数量", "Quantity");
            Dic.Add("商品进价", "BuyPrice");
            Dic.Add("商品售价", "SalePrice");
            var t = Dic.Select(u => new { key = u.Key, value = u.Value });
            comboProp.DataSource = t.ToList();
            comboProp.DisplayMember = "key";
            comboProp.ValueMember = "value";
            return;
        }
        private void View_Prod_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
            Form_ProdIDU ProdIDUS = new Form_ProdIDU(null, Insert.Text);
            ProdIDUS.StartPosition = FormStartPosition.CenterScreen;
            ProdIDUS.ShowDialog();
            RefreshTable();
            this.Show();
            return;
        }
        private void Select_Click(object sender, EventArgs e)
        {
            View_Prod.AutoGenerateColumns = true;
            string prop = comboProp.SelectedValue.ToString().Trim();
            string val = textVal.Text.ToString().Trim();
            if (val != "")
            {
                View_Prod.DataSource = prodDAO.Select_Prod(prop, val, true);
                ChangeColumnNames(true, "");
                Update.Enabled = true;
                Delete.Enabled = true;
            }
            else
            {
                View_Prod.DataSource = prodDAO.Select_Prod(prop, "", false);
                ChangeColumnNames(false, comboProp.Text.Trim());
                Update.Enabled = false;
                Delete.Enabled = false;
            }
            return;
        }
        private Product Deliver()
        {
            Product Prod = new Product();
            Prod.ProdNum = View_Prod.SelectedRows[0].Cells[0].Value.ToString();
            Prod.ProdName = View_Prod.SelectedRows[0].Cells[1].Value.ToString();
            Prod.Quantity = Convert.ToInt32(View_Prod.SelectedRows[0].Cells[2].Value);
            Prod.BuyPrice = Convert.ToDecimal(View_Prod.SelectedRows[0].Cells[3].Value);
            Prod.SalePrice = Convert.ToDecimal(View_Prod.SelectedRows[0].Cells[4].Value);
            return Prod;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (View_Prod.SelectedRows.Count != 1)
            {
                MessageBox.Show("请点击索引，选择一行！");
                return;
            }
            this.Hide();
            Product Prod = Deliver();
            Form_ProdIDU ProdIDUS = new Form_ProdIDU(Prod, Delete.Text);
            ProdIDUS.StartPosition = FormStartPosition.CenterScreen;
            ProdIDUS.ShowDialog();
            RefreshTable();
            this.Show();
            return;
        }
        private void Update_Click(object sender, EventArgs e)
        {
            if (View_Prod.SelectedRows.Count != 1)
            {
                MessageBox.Show("请点击索引，选择一行！");
                return;
            }
            this.Hide();
            Product Prod = Deliver();
            Form_ProdIDU ProdIDUS = new Form_ProdIDU(Prod, Update.Text);
            ProdIDUS.StartPosition = FormStartPosition.CenterScreen;
            ProdIDUS.ShowDialog();
            RefreshTable();
            this.Show();
            return;
        }
    }
}
