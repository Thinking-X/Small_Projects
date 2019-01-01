using StudentApp.DAL;
using StudentApp.PublicClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class Form_SC : Form
    {
        public Form_SC()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private void Clean()
        {
            Sid.Text = "";
            Cid.Text = "";
            Scores.Text = "";
            return;
        }
        private void Form_SC_Load(object sender, EventArgs e)
        {
            UpPage.Enabled = false;
            DownPage.Enabled = false;
            Update.Enabled = false;
            Delete.Enabled = false;

            Dictionary<string, string> Dic = new Dictionary<string, string>();
            Dic.Add("学号", "Sid");
            Dic.Add("课程号", "Cid");
            Dic.Add("分数段", "Scores");
            var t = Dic.Select(u => new { key = u.Key, value = u.Value });
            Prop.DataSource = t.ToList();
            Prop.DisplayMember = "key";
            Prop.ValueMember = "value";

            valText1.Visible = false;
            valText2.Visible = false;
            toLabel.Visible = false;
            return;
        }
        SCDAO scDao = new SCDAO();
        private void View_SC_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
        private void ChangeColumnNames(bool flag, string prop)
        {
            if (flag)
            {
                View_SC.Columns["Sid"].HeaderText = "学号";
                View_SC.Columns["Cid"].HeaderText = "课程号";
                View_SC.Columns["Scores"].HeaderText = "分数";
            }
            else
            {
                if (prop == "分数段")
                {
                    View_SC.Columns[0].HeaderText = "分数";
                    return;
                }
                View_SC.Columns[0].HeaderText = prop;
            }
            return;
        }
        int i;//表示第几页
        int count;//表示所查询的表一共几行
        private void Display_Click(object sender, EventArgs e)
        {
            View_SC.AutoGenerateColumns = true;
            View_SC.DataSource = scDao.DisplayTableSc();
            ChangeColumnNames(true, "");
            count = scDao.GainSumline();
            UpPage.Enabled = false;
            DownPage.Enabled = false;
            Update.Enabled = true;
            Delete.Enabled = true;
            return;
        }
        private void FirstPage_Click(object sender, EventArgs e)
        {
            int num;//一页显示几行
            bool x = int.TryParse(LineNum.Text, out num);
            if (x && num > 0)
            {
                i = 1;
                View_SC.AutoGenerateColumns = true;
                View_SC.DataSource = scDao.DisplayPage(num, i);
                ChangeColumnNames(true, "");
                UpPage.Enabled = false;
                DownPage.Enabled = true;
                Update.Enabled = true;
                Delete.Enabled = true;
                count = scDao.GainSumline();
            }
            else
            {
                MessageBox.Show("请输入合法的数！");
            }
            return;
        }
        private void UpPage_Click(object sender, EventArgs e)
        {
            i--;
            if (i == 0)
            {
                i++;
                UpPage.Enabled = false;
                MessageBox.Show("往上已经没有了！");
                return;
            }
            int num = Convert.ToInt32(LineNum.Text);
            View_SC.AutoGenerateColumns = true;
            View_SC.DataSource = scDao.DisplayPage(num, i);
            ChangeColumnNames(true, "");
            DownPage.Enabled = true;
            return;
        }
        private void DownPage_Click(object sender, EventArgs e)
        {
            i++;
            int num = Convert.ToInt32(LineNum.Text);//一页显示几行
            if (count % num == 0)
            {
                if ((i - 1) == (count / num))
                {
                    i--;
                    DownPage.Enabled = false;
                    MessageBox.Show("往下已经没有了！");
                    return;
                }
            }
            else
            {
                if ((i - 1) == (count / num + 1))
                {
                    i--;
                    DownPage.Enabled = false;
                    MessageBox.Show("往下已经没有了！");
                    return;
                }
            }
            View_SC.AutoGenerateColumns = true;
            View_SC.DataSource = scDao.DisplayPage(num, i);
            ChangeColumnNames(true, "");
            UpPage.Enabled = true;
            return;
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            SC sc = new SC();
            if((Sid.Text.Trim() == "") || (Cid.Text.Trim() == ""))
            {
                MessageBox.Show("请务必输入学号和课程号！");
                return;
            }
            else
            {
                sc.Sid = Sid.Text;
                sc.Cid = Cid.Text;
            }
            if(Scores.Text.Trim() != "")
            {
                sc.Scores = Convert.ToDecimal(Scores.Text);
            }           
            if (Insert.Text.Equals("添加"))
            {
                if(scDao.Insert_SC(sc))
                {
                    MessageBox.Show("成功插入一行记录！");
                    Clean();
                }
                else
                {
                    MessageBox.Show("执行出错，插入失败！");
                }
            }
            else
            {
                Sid.ReadOnly = false;
                Cid.ReadOnly = false;
                if(scDao.Update_SC(sc))
                {
                    MessageBox.Show("成功更改一行记录！");
                    Clean(); 
                }
                else
                {
                    MessageBox.Show("执行出错，更改失败！");
                }
                Insert.Text = "添加";
            }
            return;
        }
        private void Update_Click(object sender, EventArgs e)
        {
            Clean();
            if (View_SC.SelectedRows.Count == 1)
            {
                int index = View_SC.CurrentRow.Index;
            }
            else
            {
                MessageBox.Show("请点击索引，选择一行！");
                return;
            }
            Insert.Text = "确认更改";
            MessageBox.Show("请在右侧更改！");
            Sid.Text = View_SC.SelectedRows[0].Cells[0].Value.ToString();
            Cid.Text = View_SC.SelectedRows[0].Cells[1].Value.ToString();
            Scores.Text = View_SC.SelectedRows[0].Cells[2].Value.ToString();
            Sid.ReadOnly = true;
            Cid.ReadOnly = true;
            return;
        }       
        private void Prop_Click(object sender, EventArgs e)
        {
            Val.Text = "";
            valText1.Text = "";
            valText2.Text = "";
            return;
        }
        private void Select_Click(object sender, EventArgs e)
        {
            View_SC.AutoGenerateColumns = true;
            string prop = Prop.SelectedValue.ToString().Trim();
            if (prop == "Scores")
            {
                string Scor1 = valText1.Text.ToString().Trim();
                string Scor2 = valText2.Text.ToString().Trim();
                if ((Scor1 == "") && (Scor2 == ""))
                {
                    View_SC.DataSource = scDao.Select_SC1(prop);
                    ChangeColumnNames(false, Prop.Text.Trim());
                    Update.Enabled = false;
                    Delete.Enabled = false;
                    return;
                }
                if ((Scor1 != "") && (Scor2 != ""))
                {
                    View_SC.DataSource = scDao.Select_SC3(prop, Scor1, Scor2);
                    ChangeColumnNames(true, "");
                    Update.Enabled = true;
                    Delete.Enabled = true;
                }
                else
                {
                    MessageBox.Show("请输入合法的范围！");
                }
                return;
            }
            string val = Val.Text.ToString().Trim();
            if( val != "")
            {
                View_SC.DataSource = scDao.Select_SC2(prop, val);
                ChangeColumnNames(true, "");
                Update.Enabled = true;
                Delete.Enabled = true;
            }
            else
            {
                View_SC.DataSource = scDao.Select_SC1(prop);
                ChangeColumnNames(false, Prop.Text.Trim());
                Update.Enabled = false;
                Delete.Enabled = false;
            }
            return;
        }
        private void Prop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prop = Prop.SelectedValue.ToString().Trim();
            if (prop == "Scores")
            {
                Val.Visible = false;
                valText1.Visible = true;
                valText2.Visible = true;
                toLabel.Visible = true;
                return;
            }
            valText1.Visible = false;
            valText2.Visible = false;
            toLabel.Visible = false;
            Val.Visible = true;
            return;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (View_SC.SelectedRows.Count == 1)
            {
                int index = View_SC.CurrentRow.Index;
            }
            else
            {
                MessageBox.Show("请点击索引，选择一行！");
                return;
            }
            DialogResult dr = MessageBox.Show("确定要删除吗?", "提示：", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            if (scDao.Delete_SC(View_SC.SelectedRows[0].Cells["Sid"].Value.ToString(), View_SC.SelectedRows[0].Cells["Cid"].Value.ToString()))
            {
                MessageBox.Show("成功删除一行记录！");
            }
            else
            {
                MessageBox.Show("执行出错，删除失败！");
            }
            return;
        }
    }
}
