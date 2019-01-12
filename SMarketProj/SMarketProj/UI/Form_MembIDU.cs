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
    public partial class Form_MembIDU : Form
    {
        public Form_Member PForm;
        MembDAO membDAO = new MembDAO();
        public Form_MembIDU(Member memb_, string display)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            if(memb_ != null)
            {
                MemNum.Text = memb_.MemNum;
                MemPwd.Text = memb_.MemPwd;
                Grade.Text = memb_.Grade.ToString();
                MemName.Text = memb_.MemName;
                if (memb_.Gender.Trim() == "男")
                {
                    radio_Y.Checked = true;
                }
                if (memb_.Gender.Trim() == "女")
                {
                    radio_X.Checked = true;
                }
                IdNum.Text = memb_.IdNum;
                FAddress.Text = memb_.FAddress;
            }  
            this.IDU.Text = "确认" + display;
            this.Text = display;
        }
        private void Clean()
        {
            MemNum.Text = "";
            MemPwd.Text = "";
            Grade.Text = "";
            MemName.Text = "";
            radio_Y.Checked = false;
            radio_X.Checked = false;
            IdNum.Text = "";
            FAddress.Text = "";
            return;
        }
        private void InsertUpdate()
        {
            Member Memb_ = new Member();
            if(MemNum.Text.Trim() == "")
            {
                MessageBox.Show("请输入会员号！");
                return;
            }
            Memb_.MemNum = MemNum.Text.Trim();
            if(MemPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码！");
                return;
            }
            Memb_.MemPwd = MemPwd.Text.Trim();
            if(Grade.Text.Trim() == "")
            {
                MessageBox.Show("请输入会员积分！");
                return;
            }
            Memb_.Grade = Convert.ToInt32(Grade.Text);
            Memb_.MemName = MemName.Text.Trim();
            if (radio_Y.Checked == true)
            {
                Memb_.Gender = "男";
            }
            if (radio_X.Checked == true)
            {
                Memb_.Gender = "女";
            }
            if(IdNum.Text.Trim() == "")
            {
                MessageBox.Show("请输入身份证号！");
                return;
            }
            Memb_.IdNum = IdNum.Text.Trim();
            Memb_.FAddress = FAddress.Text.Trim();
            if (IDU.Text.Trim() == "确认添加")
            {
                if (membDAO.Insert_Memb(Memb_))
                {
                    MessageBox.Show("成功添加一个会员！");
                    Clean();
                }
                else
                {
                    MessageBox.Show("添加会员失败！");
                }
            }
            else
            {
                if (membDAO.Update_Memb(Memb_))
                {
                    MessageBox.Show("成功更改一个会员！");
                    Clean();
                }
                else
                {
                    MessageBox.Show("更改会员失败！");
                }
            }
            return;
        }
        private void Delete()
        {
            if (membDAO.Delete_Memb(MemNum.Text.Trim()))
            {
                MessageBox.Show("成功删除一个会员！");
                Clean();
            }
            else
            {
                MessageBox.Show("删除会员失败！");
            }
            return;
        }
        private void IDU_Click(object sender, EventArgs e)
        {
            if (IDU.Text.Trim() == "确认删除")
            {
                Delete();
            }
            else
            {
                InsertUpdate();
            }
            return;
        }
    }
}
