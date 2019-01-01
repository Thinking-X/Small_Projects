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
    public partial class Form_Stu : Form
    {
        public Form_Stu()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private void Clean()
        {
            Sid.Text = "";
            Sname.Text = "";
            radio_Y.Checked = false;
            radio_X.Checked = false;
            ClassName.Text = "";
            AScores.Text = "";
            Birthdate.Text = "";
            return;
        }
        int i;//表示第几页
        int count;//表示所查询的表一共几行
        private void Form_Stu_Load(object sender, EventArgs e)
        {
            UpPage.Enabled = false;
            DownPage.Enabled = false;
            Update.Enabled = false;
            Delete.Enabled = false;

            Dictionary<string, string> Dic = new Dictionary<string, string>();
            Dic.Add("学号", "Sid");
            Dic.Add("姓名", "Sname");
            Dic.Add("性别", "Sex");
            Dic.Add("班级", "ClassName");
            Dic.Add("生日(用“-”隔开)", "Birthdate");
            Dic.Add("入学成绩段", "Ascores");         
            var t = Dic.Select(u => new { key = u.Key, value = u.Value });
            Prop.DataSource = t.ToList();
            Prop.DisplayMember = "key";
            Prop.ValueMember = "value";
            
            valText1.Visible = false;
            valText2.Visible = false;
            toLabel.Visible = false;
            return;
        }
        StudentDAO StuDao = new StudentDAO();
        private void View_Stu_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)//为dataGridView增加索引列
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
            if(flag)
            {
                View_Stu.Columns["Sid"].HeaderText = "学号";
                View_Stu.Columns["Sname"].HeaderText = "姓名";
                View_Stu.Columns["Sex"].HeaderText = "性别";
                View_Stu.Columns["ClassName"].HeaderText = "班级";
                View_Stu.Columns["Birthdate"].HeaderText = "出生日期";
                View_Stu.Columns["AScores"].HeaderText = "入学成绩";
            }
            else
            {
                if(prop == "入学成绩段")
                {
                    View_Stu.Columns[0].HeaderText = "入学成绩";
                    return;
                }
                if (prop == "生日(用“-”隔开)")
                {
                    View_Stu.Columns[0].HeaderText = "生日";
                    return;
                }
                View_Stu.Columns[0].HeaderText = prop;
            }
            return;
        }
        private void Display_Click(object sender, EventArgs e)
        {          
            View_Stu.AutoGenerateColumns = true;
            View_Stu.DataSource = StuDao.DisplayTableStu();
            ChangeColumnNames(true, "");
            count = StuDao.GainSumline();
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
                View_Stu.AutoGenerateColumns = true;
                View_Stu.DataSource = StuDao.DisplayPage(num,i);
                ChangeColumnNames(true, "");
                UpPage.Enabled = false;
                DownPage.Enabled = true;
                Update.Enabled = true;
                Delete.Enabled = true;
                count = StuDao.GainSumline();
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
            View_Stu.AutoGenerateColumns = true;
            View_Stu.DataSource = StuDao.DisplayPage(num, i);
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
            View_Stu.AutoGenerateColumns = true;
            View_Stu.DataSource = StuDao.DisplayPage(num, i);
            ChangeColumnNames(true, "");
            UpPage.Enabled = true;
            return;
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            if(Sid.Text.Trim() != "")
            {
                stu.Sid = Sid.Text;
            }
            else
            {
                MessageBox.Show("请务必输入学号！");
                return;
            }
            if(Sname.Text.Trim() != "")
            {
                stu.Sname = Sname.Text;
            }          
            stu.Birthdate = Convert.ToDateTime(Birthdate.Text);
            if (ClassName.Text.Trim() != "")
            {
                stu.ClassName = ClassName.Text;
            }
            if(AScores.Text.Trim() != "")
            {
                stu.AScores = Convert.ToDecimal(AScores.Text);
            }              
            foreach (Control item in groupBox1.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton button = item as RadioButton;
                    if (button.Checked)
                    {
                        stu.Sex = button.Text;
                        break;
                    }
                }
            }
            if (Insert.Text.Equals("注册"))
            {
                if(StuDao.Insert_Stu(stu))
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
                if(StuDao.Update_Stu(stu))
                {
                    MessageBox.Show("成功更改一行记录！");
                    Clean();
                }
                else
                {
                    MessageBox.Show("执行出错，更改失败！");
                }
                Insert.Text = "注册";
            }
            return;
        }
        private void Update_Click(object sender, EventArgs e)
        {
            Clean();
            if (View_Stu.SelectedRows.Count == 1)
            {
                int index = View_Stu.CurrentRow.Index;
            }
            else
            {
                MessageBox.Show("请点击索引，选择一行！");
                return;
            }
            Insert.Text = "确认更改";
            MessageBox.Show("请在右侧更改！");
            Sid.Text = View_Stu.SelectedRows[0].Cells[0].Value.ToString();
            Sname.Text = View_Stu.SelectedRows[0].Cells[1].Value.ToString();
            string Gender = View_Stu.SelectedRows[0].Cells[2].Value.ToString();
            if (Gender.Trim() == "男")
            {
                radio_Y.Checked = true;
            }
            if (Gender.Trim() == "女")
            {
                radio_X.Checked = true;
            }
            ClassName.Text = View_Stu.SelectedRows[0].Cells[3].Value.ToString();
            Birthdate.Text = View_Stu.SelectedRows[0].Cells[4].Value.ToString();
            AScores.Text = View_Stu.SelectedRows[0].Cells[5].Value.ToString();
            Sid.ReadOnly = true;
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
            View_Stu.AutoGenerateColumns = true;
            string prop = Prop.SelectedValue.ToString().Trim();
            if (prop == "Ascores")
            {
                string Scor1 = valText1.Text.ToString().Trim();
                string Scor2 = valText2.Text.ToString().Trim();
                if ((Scor1 == "") && (Scor2 == ""))
                {
                    View_Stu.DataSource = StuDao.Select_Stu1(prop);
                    ChangeColumnNames(false, Prop.Text.Trim());
                    Update.Enabled = false;
                    Delete.Enabled = false;
                    return;
                }
                if ((Scor1 != "") && (Scor2 != ""))
                {
                    View_Stu.DataSource = StuDao.Select_Stu3(prop, Scor1, Scor2);
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
            if (val != "")
            {
                if (prop == "Birthdate")
                {
                    int date_;
                    if (int.TryParse(val, out date_))
                    {
                        View_Stu.DataSource = StuDao.Select_Stu2(prop, val);
                        ChangeColumnNames(true, "");
                        Update.Enabled = true;
                        Delete.Enabled = true;
                        return;
                    }
                    DateTime date;
                    if (DateTime.TryParse(val, out date))
                    {
                        string[] Date = val.Split('-');
                        if (Date.Length == 2)
                        {
                            if (Date[1].Length == 1)
                            {
                                val = Date[0] + "-0" + Date[1];
                            }
                            View_Stu.DataSource = StuDao.Select_Stu2(prop, val);
                            Update.Enabled = true;
                            Delete.Enabled = true;
                            ChangeColumnNames(true, "");
                            return;
                        }
                        if (Date.Length == 3)
                        {
                            if (Date[1].Length == 1)
                            {
                                Date[1] = "0" + Date[1];
                            }
                            if (Date[2].Length == 1)
                            {
                                Date[2] = "0" + Date[2];
                            }
                            val = Date[0] + "-" + Date[1] + "-" + Date[2];
                            View_Stu.DataSource = StuDao.Select_Stu2(prop, val);
                            Update.Enabled = true;
                            Delete.Enabled = true;
                            ChangeColumnNames(true, "");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("输入正确的日期格式！");
                        return;
                    }
                }
                View_Stu.DataSource = StuDao.Select_Stu2(prop, val);
                ChangeColumnNames(true, "");
                Update.Enabled = true;
                Delete.Enabled = true;
            }
            else
            {
                View_Stu.DataSource = StuDao.Select_Stu1(prop);
                ChangeColumnNames(false, Prop.Text.Trim());
                Update.Enabled = false;
                Delete.Enabled = false;
            }
            return;
        }
        private void Prop_SelectedIndexChanged(object sender, EventArgs e)
        {           
            string prop = Prop.SelectedValue.ToString().Trim();            
            if(prop == "Ascores")
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
            if (View_Stu.SelectedRows.Count == 1)
            {
                int index = View_Stu.CurrentRow.Index;
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
            if (StuDao.Delete_Stu(View_Stu.SelectedRows[0].Cells["Sid"].Value.ToString()))
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
