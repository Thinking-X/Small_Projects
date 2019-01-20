using SMarketProj.DAL;
using SMarketProj.PublicClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMarketProj.UI
{
    public partial class Form_Personal : Form
    {
        public Form_Personal(string userNum_)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.userNum = userNum_;
        }
        string userNum;
        MembDAO membDAO = new MembDAO();
        Member member = new Member();//当前页面显示的会员信息
        PortrDAO portrDAO = new PortrDAO();
        Portrait Portr = new Portrait();

        Label LMemPwd = new Label();
        Label LMemName = new Label();
        Label LGender = new Label();
        Label LFAddress = new Label();

        TextBox TMemPwd = new TextBox();
        TextBox TMemName = new TextBox();
        RadioButton radioX = new RadioButton();
        RadioButton radioY = new RadioButton();
        TextBox TFAddress = new TextBox();
        private void DisplayMembInfo()
        {
            TMemPwd.Dispose();
            TMemName.Dispose();
            radioX.Dispose();
            radioY.Dispose();
            TFAddress.Dispose();

            LMemPwd = new Label();
            LMemName = new Label();
            LGender = new Label();
            LFAddress = new Label();

            LMemPwd.Text = member.MemPwd;
            LMemPwd.Font = new Font("宋体", 9f);
            LMemPwd.Location = new Point(120, 70);
            this.Controls.Add(LMemPwd);

            LMemName.Text = member.MemName;
            LMemName.Font = new Font("宋体", 9f);
            LMemName.Location = new Point(120, 145);
            this.Controls.Add(LMemName);

            LGender.Text = member.Gender;
            LGender.Font = new Font("宋体", 9f);
            LGender.Location = new Point(130, 185);
            this.Controls.Add(LGender);

            LFAddress.Text = member.FAddress;
            LFAddress.Width = 150;
            LFAddress.Font = new Font("宋体", 9f);
            LFAddress.Location = new Point(95, 265);
            this.Controls.Add(LFAddress);
            return;
        }
        private void UpdateMembInfo()
        {
            LMemPwd.Dispose();
            LMemName.Dispose();
            LGender.Dispose();
            LFAddress.Dispose();

            TMemPwd = new TextBox();
            TMemName = new TextBox();
            radioX = new RadioButton();
            radioY = new RadioButton();
            TFAddress = new TextBox();

            TMemPwd.Text = member.MemPwd;
            TMemPwd.Width = 120;
            TMemPwd.Location = new Point(97, 63);
            this.Controls.Add(TMemPwd);

            TMemName.Text = member.MemName;
            TMemName.Width = 120;
            TMemName.Location = new Point(97, 138);
            this.Controls.Add(TMemName);

            radioY.Text = "男";
            radioY.Width = 50;
            radioY.Location = new Point(110, 180);
            if (member.Gender.Trim() == "男")
            {
                radioY.Checked = true;
            }
            this.Controls.Add(radioY);
            radioX.Text = "女";
            radioX.Width = 50;
            radioX.Location = new Point(160, 180);
            if (member.Gender.Trim() == "女")
            {
                radioX.Checked = true;
            }
            this.Controls.Add(radioX);

            TFAddress.Text = member.FAddress;
            TFAddress.Width = 120;
            TFAddress.Location = new Point(97, 260);
            this.Controls.Add(TFAddress);
            return;
        }
        private void ChangeColumnNames()
        {
            View_Shop.Columns["ProdName"].HeaderText = "商品名";
            View_Shop.Columns["SalePrice"].HeaderText = "单价";
            View_Shop.Columns["SaleQuantity"].HeaderText = "购买数量";
            View_Shop.Columns["SaleDate"].HeaderText = "购买日期";
            return;
        }
        private string pathName = string.Empty;
        private void Insert_Portr(string userNum)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = ".";
            file.Filter = "所有文件(*.*)|*.*";
            file.ShowDialog();
            pathName = file.FileName;
            if (string.IsNullOrWhiteSpace(pathName))
            {
                MessageBox.Show("请选择图片！");
                return;
            }
            try
            {
                Image img = Image.FromFile(pathName);
            }
            catch
            {
                MessageBox.Show("请选择正确的图片类型！");
                return;
            }
            DialogResult dr = MessageBox.Show("确定要添加吗?", "提示：", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            FileStream fs = new FileStream(pathName, FileMode.Open, FileAccess.Read);
            Byte[] image = new byte[fs.Length];
            fs.Read(image, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            Portr.UserPortr = image;
            Portr.UserNum = userNum;
            if (portrDAO.Insert_Portr(Portr))
            {
                MessageBox.Show("设置成功！");
                pictureBox1.Load(pathName);
            }
            else
            {
                MessageBox.Show("设置失败！");
            }
            return;
        }
        private void Form_Personal_Load(object sender, EventArgs e)
        {
            member = membDAO.Select_OneMemb(userNum);
            MemNum.Text = member.MemNum;//
            Grade.Text = member.Grade.ToString();//
            IdNum.Text = member.IdNum;//
            DisplayMembInfo();
            View_Shop.AutoGenerateColumns = true;
            View_Shop.DataSource = membDAO.ShoppingHistory(userNum);
            ChangeColumnNames();
            CancelUpdate.Visible = false;
            UpdatePortr.Visible = false;
            if (portrDAO.SelectPortr(userNum) == 1)
            {
                MemoryStream stmBLOBData = new MemoryStream(portrDAO.DisplayPortr(userNum));
                pictureBox1.Image = Image.FromStream(stmBLOBData);
            }
            return;
        }
        private void View_Shop_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
        private void Update_Click(object sender, EventArgs e)
        {
            if (Update.Text == "更改信息")
            {
                UpdateMembInfo();
                Update.Text = "确认更改";
                CancelUpdate.Visible = true;
                UpdatePortr.Visible = true;
            }
            else if (Update.Text == "确认更改")
            {
                Member memb_ = new Member();
                if (TMemPwd.Text.Trim() == "")
                {
                    MessageBox.Show("请输入密码！");
                    return;
                }
                memb_.MemPwd = TMemPwd.Text.Trim();
                if (TMemName.Text.Trim() == "")
                {
                    MessageBox.Show("请输入会员名！");
                    return;
                }
                memb_.MemName = TMemName.Text.Trim();
                if (radioX.Checked == false && radioY.Checked == false)
                {
                    MessageBox.Show("请选择性别！");
                    return;
                }
                if(radioX.Checked == true)
                {
                    memb_.Gender = "女";
                }
                else
                {
                    memb_.Gender = "男";
                }
                if(TFAddress.Text.Trim() == "")
                {
                    MessageBox.Show("请输入地址！");
                    return;
                }
                memb_.FAddress = TFAddress.Text.Trim();
                memb_.MemNum = MemNum.Text.Trim();
                memb_.Grade = Convert.ToInt32(Grade.Text);
                memb_.IdNum = IdNum.Text.Trim();
                if(membDAO.Update_Memb(memb_))
                {
                    MessageBox.Show("更改成功！");
                    Update.Text = "更改信息";
                    CancelUpdate.Visible = false;
                    UpdatePortr.Visible = false;
                    member = memb_;
                    DisplayMembInfo();
                }
                else
                {
                    MessageBox.Show("更改失败！");
                }               
            }
            return;
            //myButton.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            //myButton.Click += new System.EventHandler(this.btn_Click);
        }
        private void CancelUpdate_Click(object sender, EventArgs e)
        {
            DisplayMembInfo();
            CancelUpdate.Visible = false;
            UpdatePortr.Visible = false;
            Update.Text = "更改信息";
            return;
        }
        private void UpdatePortr_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            if (pictureBox1.Image == null)
            {
                dr = MessageBox.Show("您没有设置头像，是否要添加?", "提示：", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Insert_Portr(userNum);
                }
                return;
            }            
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = ".";
            file.Filter = "所有文件(*.*)|*.*";
            file.ShowDialog();
            pathName = file.FileName;
            if (string.IsNullOrWhiteSpace(pathName))
            {
                MessageBox.Show("请选择图片！");
                return;
            }
            try
            {
                Image img = Image.FromFile(pathName);
            }
            catch
            {
                MessageBox.Show("请选择正确的图片类型！");
                return;
            }
            dr = MessageBox.Show("确定要更改吗?", "提示：", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            pictureBox1.Image = null;
            FileStream fs = new FileStream(pathName, FileMode.Open, FileAccess.Read);
            Byte[] image = new byte[fs.Length];
            fs.Read(image, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            Portr.UserNum = userNum.Trim();
            Portr.UserPortr = image;
            if (portrDAO.Update_Portr(Portr))
            {
                MessageBox.Show("更改成功！");
                pictureBox1.Load(pathName);
            }
            else
            {
                MessageBox.Show("更改失败！");
            }
            return;
        }
        //private void btn_MouseEnter(object sender, System.EventArgs e)
        //{
        //    //出箱 
        //    Button currentButton = (Button)sender;
        //    //设定按钮的背景色 
        //    currentButton.BackColor = Color.Red;
        //}
        //private void btn_Click(object sender, System.EventArgs e)
        //{
        //    MessageBox.Show("btn_Click！");
        //}
    }
}
