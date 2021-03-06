﻿using SMarketProj.DAL;
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
    public partial class Form_ProdIDU : Form
    {
        ProdDAO prodDAO = new ProdDAO();
        public Form_ProdIDU(Product Prod_, string display)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            if (Prod_ == null)
            {
                ProdNum.Text = Guid.NewGuid().ToString().Substring(0, 8);
            }
            else
            {
                ProdNum.Text = Prod_.ProdNum;
                ProdName.Text = Prod_.ProdName;
                Quantity.Text = Prod_.Quantity.ToString();
                BuyPrice.Text = Prod_.BuyPrice.ToString();
                SalePrice.Text = Prod_.SalePrice.ToString();
            }
            this.IDUS.Text = "确认" + display;
            this.Text = display;
        }
        private void Clean()
        {
            ProdNum.Text = "";
            ProdName.Text = "";
            Quantity.Text = "";
            BuyPrice.Text = "";
            SalePrice.Text = "";
            return;
        }
        private void InsertUpdate()
        {
            Product Prod_ = new Product();
            Prod_.ProdNum = ProdNum.Text;
            if (ProdName.Text.Trim() == "")
            {
                MessageBox.Show("请输入商品名！");
                return;
            }
            Prod_.ProdName = ProdName.Text.Trim();
            if(Quantity.Text.Trim() == "")
            {
                MessageBox.Show("请输入数量！");
                return;
            }
            int quan;
            bool x = int.TryParse(Quantity.Text, out quan);
            if (x && quan > 0)
            {
                Prod_.Quantity = quan;
            }
            else
            {
                MessageBox.Show("请输入合法的数！");
                return;
            }
            if(BuyPrice.Text.Trim() == "")
            {
                MessageBox.Show("请输入进价！");
                return;
            }
            decimal buyPrice;
            x = Decimal.TryParse(BuyPrice.Text, out buyPrice);
            if (x && buyPrice > 0)
            {
                Prod_.BuyPrice = buyPrice;
            }
            else
            {
                MessageBox.Show("请输入合法的数！");
                return;
            } 
            if (SalePrice.Text.Trim() == "")
            {
                MessageBox.Show("请输入售价！");
                return;
            }
            decimal salePrice;
            x = Decimal.TryParse(BuyPrice.Text, out salePrice);
            if (x && salePrice > 0)
            {
                Prod_.SalePrice = salePrice;
            }
            else
            {
                MessageBox.Show("请输入合法的数！");
                return;
            }           
            if (IDUS.Text.Trim() == "确认添加")
            {
                if (prodDAO.Insert_Prod(Prod_))
                {
                    MessageBox.Show("成功添加一个商品！");
                    Clean();
                    ProdNum.Text = Guid.NewGuid().ToString().Substring(0, 8);
                }
                else
                {
                    MessageBox.Show("添加商品失败！");
                }
            }
            else
            {
                if (prodDAO.Update_Prod(Prod_))
                {
                    MessageBox.Show("成功更改一个商品！");
                    Clean();
                }
                else
                {
                    MessageBox.Show("更改商品失败！");
                }
            }
            return;
        }
        private void Delete()
        {
            if(prodDAO.Delete_Prod(ProdNum.Text.Trim()))
            {
                MessageBox.Show("成功删除一个商品！");
                Clean();
            }
            else
            {
                MessageBox.Show("删除商品失败！");
            }
            return;
        }
        private void IDUS_Click(object sender, EventArgs e)
        {
            if(IDUS.Text.Trim() == "确认删除")
            {
                Delete();
            }
            else
            {
                InsertUpdate();
            }
            return;
        }
        private void Form_ProdIDUS_FormClosed(object sender, FormClosedEventArgs e)
        {
            //FormClosed不能询问用户是否要取消关闭
        }
        private void Form_ProdIDUS_FormClosing(object sender, FormClosingEventArgs e)
        {
            //FormClosing的时候还能取消，可以提问要不要关闭，如果用户不要，可以取消，用e.Cancel。
        }
    }
}
