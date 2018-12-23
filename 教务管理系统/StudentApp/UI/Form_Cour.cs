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

namespace StudentApp.UI
{
    public partial class Form_Cour : Form
    {
        public Form_Cour()
        {
            InitializeComponent();
        }
        private void Clean()
        {
            No.Text = "";
            Cid.Text = "";
            Cname.Text = "";
            Credit.Text = "";
            return;
        }
        int i;//表示第几页
        int count;//表示所查询的表一共几行
        private void Form_Cour_Load(object sender, EventArgs e)
        {
            UpPage.Enabled = false;
            DownPage.Enabled = false;
            Update.Enabled = false;
            Delete.Enabled = false;

            Dictionary<string, string> Dic = new Dictionary<string, string>();
            Dic.Add("编号", "No");
            Dic.Add("课程号", "Cid");
            Dic.Add("课程名", "Cname");
            Dic.Add("学分段", "Credit");
            var t = Dic.Select(u => new { key = u.Key, value = u.Value });
            Prop.DataSource = t.ToList();
            Prop.DisplayMember = "key";
            Prop.ValueMember = "value";

            valText1.Visible = false;
            valText2.Visible = false;
            toLabel.Visible = false;
            return;
        }
        CourseDAO CourDao = new CourseDAO();
        private void View_Cour_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
                View_Cour.Columns["No"].HeaderText = "编号";
                View_Cour.Columns["Cid"].HeaderText = "课程号";
                View_Cour.Columns["Cname"].HeaderText = "课程名";
                View_Cour.Columns["Credit"].HeaderText = "学分";
            }
            else
            {
                if (prop == "学分段")
                {
                    View_Cour.Columns[0].HeaderText = "学分";
                    return;
                }
                View_Cour.Columns[0].HeaderText = prop;
            }
            return;
        }
        private void Display_Click(object sender, EventArgs e)
        {
            View_Cour.AutoGenerateColumns = true;
            View_Cour.DataSource = CourDao.DisplayTableCour();
            ChangeColumnNames(true, "");
            count = CourDao.GainSumline();
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
                View_Cour.AutoGenerateColumns = true;
                View_Cour.DataSource = CourDao.DisplayPage(num, i);
                ChangeColumnNames(true, "");
                UpPage.Enabled = false;
                DownPage.Enabled = true;
                Update.Enabled = true;
                Delete.Enabled = true;
                count = CourDao.GainSumline();
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
            View_Cour.AutoGenerateColumns = true;
            View_Cour.DataSource = CourDao.DisplayPage(num, i);
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
            View_Cour.AutoGenerateColumns = true;
            View_Cour.DataSource = CourDao.DisplayPage(num, i);
            ChangeColumnNames(true, "");
            UpPage.Enabled = true;
            return;
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            Course cour = new Course();
            if (Cid.Text.Trim() != "")
            {
                cour.Cid = Cid.Text;
            }
            else
            {
                MessageBox.Show("请务必输入课程号！");
                return;
            }
            if (No.Text.Trim() != "")
            {
                cour.No = Convert.ToInt32(No.Text);
            }
            if(Cname.Text.Trim() != "")
            {
                cour.Cname = Cname.Text;
            }           
            if(Credit.Text.Trim() != "")
            {
                cour.Credit = Convert.ToDecimal(Credit.Text);
            }          
            if (Insert.Text.Equals("添加"))
            {
                CourDao.Insert_Cour(cour);
                Clean();
            }
            else
            {
                Cid.ReadOnly = false;
                CourDao.Updata_Cour(cour);
                Clean();
                Insert.Text = "添加";
            }
            return;
        }
        private void Update_Click(object sender, EventArgs e)
        {
            Clean();
            if (View_Cour.SelectedRows.Count == 1)
            {
                int index = View_Cour.CurrentRow.Index;
            }
            else
            {
                MessageBox.Show("请点击索引，选择一行！");
                return;
            }
            Insert.Text = "确认更改";
            MessageBox.Show("请在右侧更改！");
            No.Text = View_Cour.SelectedRows[0].Cells[0].Value.ToString();
            Cid.Text = View_Cour.SelectedRows[0].Cells[1].Value.ToString();
            Cname.Text = View_Cour.SelectedRows[0].Cells[2].Value.ToString();
            Credit.Text = View_Cour.SelectedRows[0].Cells[3].Value.ToString();
            Cid.ReadOnly = true;
            return;
        }
        private void Prop_Click(object sender, EventArgs e)
        {
            Val.Text = "";
        }
        private void Select_Click(object sender, EventArgs e)
        {
            View_Cour.AutoGenerateColumns = true;
            string prop = Prop.SelectedValue.ToString().Trim();
            string val = Val.Text.ToString().Trim();
            if(val != "")
            {
                if (prop == "Credit")
                {
                    string Scor1 = valText1.Text.ToString().Trim();
                    string Scor2 = valText2.Text.ToString().Trim();
                    if ((Scor1 != "") && (Scor2 != ""))
                    {
                        View_Cour.DataSource = CourDao.Select_Cour3(prop, Scor1, Scor2);
                        ChangeColumnNames(true, "");
                    }
                    else
                    {
                        MessageBox.Show("请输入合法的范围！");
                    }
                    return;
                }
                View_Cour.DataSource = CourDao.Select_Cour2(prop, val);
                ChangeColumnNames(true, "");
                Update.Enabled = true;
                Delete.Enabled = true;
            }
            else
            {
                View_Cour.DataSource = CourDao.Select_Cour1(prop)["T"];
                ChangeColumnNames(false, Prop.Text.Trim());
                Update.Enabled = false;
                Delete.Enabled = false;
            }
            return;
        }
        private void Prop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prop = Prop.SelectedValue.ToString().Trim();
            if (prop == "Credit")
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
            if (View_Cour.SelectedRows.Count == 1)
            {
                int index = View_Cour.CurrentRow.Index;
            }
            else
            {
                MessageBox.Show("请点击索引，选择一行！");
                return;
            }
            CourDao.Delete_Cour(View_Cour.SelectedRows[0].Cells["Cid"].Value.ToString());
            return;
        }      
    }
}
