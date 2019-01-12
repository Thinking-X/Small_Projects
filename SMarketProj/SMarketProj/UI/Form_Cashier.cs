using SMarketProj.DAL;
using SMarketProj.PublicClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMarketProj.UI
{
    public partial class Form_Cashier : Form
    {
        public Form_Cashier()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        public bool result = false;
        ProdDAO prodDAO = new ProdDAO();
        UsersDAO userDAO = new UsersDAO();
        MembDAO membDAO = new MembDAO();
        SaleDAO saleDAO = new SaleDAO();
        SListDAO slistDAO = new SListDAO();
        SaleDetail sale = new SaleDetail();
        SaleList saleList = new SaleList();
        int count;//表示一共几种商品
        double totalPrice = 0;//正常购买的总价
        List<Product> list;
        private void Form_Cashier_Load(object sender, EventArgs e)
        {
            list = prodDAO.SelectAllProd();
            //显示商品
            var T = list.Select(u => new { ProdNum = u.ProdNum, ProdName = u.ProdName });
            checkedListProd.DataSource = T.ToList();
            checkedListProd.ValueMember = "ProdNum";
            checkedListProd.DisplayMember = "ProdName";
            //显示对应商品的价格
            count = list.Count;
            for (int i = 0; i < count; i++)
            {
                listPrice.Items.Add(list[i].SalePrice.ToString().Trim());
            }
            comboStatus.Enabled = false;
            return;
        }
        Dictionary<string, int> Dic = new Dictionary<string, int>();
        private bool JudgeRepeat(int i, int num, int Quan)
        {
            string commodity = list[i].ProdName;
            string commodityNum = list[i].ProdNum;
            for (int n = 0; n < listShop.Items.Count; n++)
            {
                if (listShop.Items[n].ToString() == commodity)
                {
                    DialogResult dialog = MessageBox.Show("该商品以购买，确定还要再次购买吗?", "提示：", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        if(Convert.ToInt32(listQuan.Items[n]) + num > Quan)
                        {
                            MessageBox.Show("库存不足！");
                            return true;
                        }
                        listQuan.Items[n] = (Convert.ToInt32(listQuan.Items[n]) + num).ToString();
                        Dic[commodityNum] += num;
                        double price = Convert.ToDouble(listPrice.Items[i]);
                        //获取选中商品的价格
                        totalPrice += num * price;//累加总价
                    }
                    for (int j = 0; j < count; j++)
                    {
                        checkedListProd.SetItemChecked(j, false);
                    }
                    numericQuan.Text = "";
                    return true;
                }
            }
            return false;
        }
        private void Append_Click(object sender, EventArgs e)
            //加入购物车
        {  
            int i;//作为选中的某一项
            for (i = 0; i < count; i++)
            {
                if (checkedListProd.GetItemChecked(i))
                {
                    break;
                    //循环停止时，i代表选中的商品的位置
                    //加入购物车时，一次只允许加入一个
                }
            }
            if (i == count)
            {
                MessageBox.Show("请一件选择商品！");
                return;
            }
            if (numericQuan.Text.Trim() == "")
            {
                MessageBox.Show("请选择购买数量！");
                return;
            }
            int num = Convert.ToInt32(numericQuan.Value);
            if(num == 0)
            {
                MessageBox.Show("请选择购买数量！");
                return;
            }
            int Quan = prodDAO.GetProdQuan(list[i].ProdNum);
            if (JudgeRepeat(i, num, Quan))
            //判断购买的商品是否重复
            {
                return;
            }
            if (Quan < num)
            {
                MessageBox.Show("库存不足！");
                return;
            }
            listQuan.Items.Add(num);//往listQuan中追加购买数量
            listShop.Items.Add(list[i].ProdName);
            //往listShop中追加商品
            double price = Convert.ToDouble(listPrice.Items[i]);
            //获取选中商品的价格
            totalPrice += num * price;//累加总价
            Dic.Add(list[i].ProdNum, num);
            //记录购买的商品号和数量
            for (int j = 0; j < count; j++)
            {
                checkedListProd.SetItemChecked(j, false);
            }
            //一次只允许加入一个，清空选中的商品
            numericQuan.Text = "";           
            comboStatus.Enabled = true;
            return;
        }
        private void checkedListProd_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //每次勾选商品时，去掉上次勾选的(一次只能勾选一个)
            if (checkedListProd.CheckedItems.Count > 0) 
            {
                for (int i = 0; i < count; i++)
                {
                    if (i != e.Index) 
                    {
                        checkedListProd.SetItemCheckState(i, CheckState.Unchecked);
                    }
                } 
            }
        }
        private void checkedListProd_SelectedValueChanged(object sender, EventArgs e){}
        private void checkedListProd_SelectedIndexChanged(object sender, EventArgs e){}
        private void checkedListProd_Click(object sender, EventArgs e)
        {
            //点击商品时，选中对应的价格 
            listPrice.SetSelected(checkedListProd.SelectedIndex, true);
            return;
        }
        private void listQuan_Click(object sender, EventArgs e)
        {
            int i = listQuan.SelectedIndex;
            if (i > -1)
            {
                listShop.SetSelected(i, true);
            }
            return;
        }
        private void listShop_Click(object sender, EventArgs e)
        {
            int i = listShop.SelectedIndex;
            if (i > -1)
            {
                listQuan.SetSelected(i, true);
            }
            return;
        }
        private void MembState(string userNum)//会员折扣状态
        {
            int Grade = membDAO.Select_MembGrade(userNum);
            CurrentScore.Text = Grade.ToString();
            Discount.Text =  Grade.ToString() + "元";
            NormalPay.Text = totalPrice.ToString() + "元";
            if(totalPrice <= Grade)
            {
                ActualPay.Text = "0元";
                ActualPay.Tag = 0;
                Award.Text = "0";
            }
            else
            {
                ActualPay.Text = (totalPrice - Grade).ToString() + "元";
                ActualPay.Tag = totalPrice - Grade;
                Award.Text = ((int)totalPrice/10 - (int)Grade/10).ToString();
            }
            return;
        }
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.RoleNum = "100";
            if(textNum.Text.Trim() == "")
            {
                MessageBox.Show("请输入会员号！");
                return;
            }
            user.UserNum = textNum.Text.Trim();
            if (textPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码！");
                return;
            }
            user.UserPwd = textPwd.Text.Trim();
            user.RoleNum = "100";
            if (userDAO.Proving(user))
            {
                SelfClosingMessageBox.StartKiller("提示", 500);
                MessageBox.Show("输入正确！", "提示");
                panelLogin.Visible = false;
                panelMem.Visible = true;
                panelNor.Visible = false;
                MembState(user.UserNum);
            }
            else
            {
                MessageBox.Show("输入错误！");
            }
            return;
        }
        private void comboStatus_SelectedValueChanged(object sender, EventArgs e){}
        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e){}
        private void comboStatus_TextChanged(object sender, EventArgs e)
        {
            string Status = comboStatus.Text.Trim();
            if (Status == "是")
            {
                panelLogin.Visible = true;
                panelMem.Visible = false;
                panelNor.Visible = false;
                Append.Enabled = false;
            }
            if (Status == "否")
            {
                panelNor.Visible = true;
                payMent.Text = totalPrice.ToString() + "元";
                panelLogin.Visible = false;
                panelMem.Visible = false;
                Append.Enabled = false;
            }
        }
        private void Settlement(bool status)
        {
            bool resultSale;//SaleDetail添加结果
            bool resultSList;//SaleList添加结果
            bool resultProd;//商品更改结果
            bool resultMemb;//会员更改结果
            string listNum = Guid.NewGuid().ToString().Substring(0, 8);
            foreach (var item in Dic)
            {
                saleList.ProdNum = item.Key;
                saleList.SaleQuantity = item.Value;
                saleList.SaleTabNum = listNum;
                //添加销售记录
                resultSList = slistDAO.Insert_List(saleList);
                resultProd = prodDAO.UpdateQuan(item.Value, item.Key);
                //更改商品数量
                if (resultSList && resultProd){}
                else
                {
                    MessageBox.Show("执行出错1！");
                    return;
                }
            }
            sale.SaleTabNum = listNum;
            sale.SaleDate = Convert.ToDateTime(DateTime.Now.ToShortDateString().ToString());
            if (status)
            {
                sale.MemNum = textNum.Text.Trim();
                sale.SaleTotal = Convert.ToDouble(ActualPay.Tag);
                resultSale = saleDAO.Insert_Sale(sale);
                resultMemb = membDAO.UpdateGrade(Convert.ToInt32(Award.Text), textNum.Text.Trim());
                if (resultSale && resultMemb)//更改会员积分
                {
                    SelfClosingMessageBox.StartKiller("提示", 2000);
                    MessageBox.Show("结算完毕！正在打印小票！", "提示");
                    MessageBox.Show("小票已生成！欢迎您再次光临！");
                    result = true;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("执行出错2！");
                }
            }
            else
            {
                sale.MemNum = "----";
                sale.SaleTotal = totalPrice;
                resultSale = saleDAO.Insert_Sale(sale);
                if(resultSale)
                {
                    SelfClosingMessageBox.StartKiller("提示", 2000);
                    MessageBox.Show("结算完毕！正在打印小票！", "提示");
                    MessageBox.Show("小票已生成！欢迎您再次光临！");
                    result = true;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("结算出错3！");
                }
            }
            return;
        }
        private void Pay_Click(object sender, EventArgs e)
            //会员结算
        {
            Settlement(true);
            return;
        }
        private void Pay__Click(object sender, EventArgs e)
            //非会员结算
        {
            Settlement(false);
            return;
        }
        private void numericQuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == '-')
                e.Handled = true;
            return;
        }       
        private void ToolStripMenuRemove_Click(object sender, EventArgs e)
        {
            int sign = listShop.SelectedIndex;
            if(sign == -1)
            {
                MessageBox.Show("请选中商品！");
                return;
            }            
            for(int i = 0; i < count; i++)
            {
                if(list[i].ProdName.Trim() == listShop.Items[sign].ToString().Trim())
                {
                    int repay = Convert.ToInt32(list[i].SalePrice) * Convert.ToInt32(listQuan.Items[sign]);
                    totalPrice -= repay;
                    Dic.Remove(list[i].ProdNum);
                    break;
                }
            }
            listShop.Items.Remove(listShop.Items[sign]);
            listQuan.Items.Remove(listQuan.Items[sign]);
            if(Dic.Count < 1)
            {
                comboStatus.Enabled = false;
            }
            return;
        }
    }
}
