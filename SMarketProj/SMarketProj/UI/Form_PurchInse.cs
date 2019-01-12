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
    public partial class Form_PurchInse : Form
    {
        public Form_PurchInse()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            PurcTabNum.Text = Guid.NewGuid().ToString().Substring(0, 8);
        }
        PurchDAO purchDAO = new PurchDAO();
        private void Clean()
        {
            PurcTabNum.Text = "";
            PurcDate.Text = "";
            PurcQuan.Text = "";
            PordNum.Text = "";
            PurcTotal.Text = "";
            return;
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            PurchaseDetail Purch = new PurchaseDetail();
            Purch.PurcTabNum = PurcTabNum.Text.Trim();
            if (PurcDate.Text.Trim() == "")
            {
                MessageBox.Show("请输入进货时间！");
                return;
            }
            Purch.PurcDate = Convert.ToDateTime(PurcDate.Text.Trim());
            if(PordNum.Text.Trim() == "")
            {
                MessageBox.Show("请输入商品号！");
                return;
            }
            Purch.PordNum = PordNum.Text.Trim();
            if(PurcQuan.Text.Trim() == "")
            {
                MessageBox.Show("请输入进货数量！");
                return;
            }
            Purch.PurcQuan = Convert.ToInt32(PurcQuan.Text);
            if(PurcTotal.Text.Trim() == "")
            {
                MessageBox.Show("请输入进货总金额！");
                return;
            }
            Purch.PurcTotal = Convert.ToInt32(PurcTotal.Text.Trim());
            if (purchDAO.Insert_Purch(Purch))
            {
                MessageBox.Show("成功添加一条记录！");
                Clean();
                PurcTabNum.Text = Guid.NewGuid().ToString().Substring(0, 8);
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }
    }
}
