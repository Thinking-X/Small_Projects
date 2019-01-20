using StudentApp.DAL;
using StudentApp.PublicClass;
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

namespace StudentApp.UI
{
    public partial class Form_Portrait : Form
    {
        public Form_Portrait()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Delete.Enabled = false;
            Update.Enabled = false;
            btn_Up.Enabled = false;
            btn_Down.Enabled = false;
        }
        PortrDAO portrDAO = new PortrDAO();
        Portrait Portr = new Portrait();
        List<String> list;
        private void Form_Portrait_Load(object sender, EventArgs e)
        {
            View_SID.DataSource = portrDAO.DisplayAllSID();
            View_SID.Columns[0].HeaderText = "学号";
            list = portrDAO.SelectAllSID();
            return;
        }
        private void View_SID_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
        private void InitializeInfo()
        {
            labelSID.Text = "----";
            labelSname.Text = "----";
            labelSex.Text = "----";
            labelClass.Text = "----";
            labelBirth.Text = "----";
            labelScores.Text = "----";
            pictureBox.Image = null;
            return;
        }
        private void Update_Click(object sender, EventArgs e)
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
            DialogResult dr = MessageBox.Show("确定要更改吗?", "提示：", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            FileStream fs = new FileStream(pathName, FileMode.Open, FileAccess.Read);
            Byte[] image = new byte[fs.Length];
            fs.Read(image, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            Portr.Stu_ID = labelSID.Text.Trim();
            Portr.Stu_Image = image;
            if(portrDAO.Update_Portr(Portr))
            {
                MessageBox.Show("更改成功！");
                pictureBox.Load(pathName);
            }
            else
            {
                MessageBox.Show("更改失败！");
            }
            return;
        }
        private void DisplayStuInfo(string sid)
        {
            Student Stu = portrDAO.SelectOneStu(sid);
            labelSID.Text = Stu.Sid;
            labelSname.Text = Stu.Sname;
            labelSex.Text = Stu.Sex;
            labelClass.Text = Stu.ClassName.Trim();
            string Birth = Stu.Birthdate.ToString();
            labelBirth.Text = Birth.Substring(0, Birth.Length - 8);
            labelScores.Text = Stu.AScores.ToString();
            return;
        }
        private void DisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeInfo();
            if (portrDAO.Select_SID(Sid) == 1)
            {
                Delete.Enabled = true;
                Update.Enabled = true;
                MemoryStream stmBLOBData = new MemoryStream(portrDAO.DisplayImg(Sid));
                pictureBox.Image = Image.FromStream(stmBLOBData);
                DisplayStuInfo(Sid);
            }
            else
            {
                Delete.Enabled = false;
                Update.Enabled = false;
                DisplayStuInfo(Sid);
                DialogResult dr = MessageBox.Show("该生没有照片信息，要添加吗?", "提示：", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    Insert_Portr(Sid);
                }
                return;
            }
        }
        private void Select_Click(object sender, EventArgs e)
        {
            InitializeInfo();
            string sid = textSID.Text.Trim();
            if(sid == "")
            {
                MessageBox.Show("请输入该生的学号！");
                return;
            }
            if (!list.Contains(sid))
            {
                MessageBox.Show("未找到该生的信息！");
                Delete.Enabled = false;
                Update.Enabled = false;
                return;
            }
            DisplayStuInfo(sid);
            if (portrDAO.Select_SID(sid) == 1)
            {
                Delete.Enabled = true;
                Update.Enabled = true;
                MemoryStream stmBLOBData = new MemoryStream(portrDAO.DisplayImg(sid));
                pictureBox.Image = Image.FromStream(stmBLOBData);
            }
            else
            {
                Delete.Enabled = false;
                Update.Enabled = false;
                DialogResult dr = MessageBox.Show("找到该生的信息，但没有该生的头像！是否要添加?", "提示：", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Insert_Portr(sid);
                }
                return;
            }
        }
        private string Sid;//datagridview中的某个SID
        private void View_SID_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.RowIndex > -1)
                {
                    View_SID.ClearSelection();
                    View_SID.Rows[e.RowIndex].Selected = true;
                    Sid = View_SID.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
            }
            catch
            {
                return;
            }
        }
        private string pathName = string.Empty;
        private void Insert_Portr(string sid)
        {
            pictureBox.Image = null;
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
            Portr.Stu_Image = image;
            Portr.Stu_ID = sid;
            if(portrDAO.Insert_Portr(Portr))
            {
                MessageBox.Show("添加成功！");
                pictureBox.Load(pathName);
                Delete.Enabled = true;
                Update.Enabled = true;
            }
            else
            {
                MessageBox.Show("添加失败！");
                Delete.Enabled = false;
                Update.Enabled = false;
            }
            return;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要删除吗?", "提示：", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            if (portrDAO.Delete_Portr(labelSID.Text.Trim()))
            {
                MessageBox.Show("删除成功！");
                pictureBox.Image = null;
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
            return;
        }
        int i;//表示第几页
        int count;//表示所查询的表一共几行
        private void DisplayFirst_Click(object sender, EventArgs e)
        {
            count = portrDAO.GainSumline();
            if (count == 0)
            {
                MessageBox.Show("没有存储的头像！");
                return;
            }
            Delete.Enabled = true;
            Update.Enabled = true;
            btn_Up.Enabled = false;
            btn_Down.Enabled = true;
            i = 1;
            byte[] imageData = portrDAO.RollDisplay(i, out string Sid_);
            MemoryStream stmBLOBData = new MemoryStream(imageData);
            pictureBox.Image = Image.FromStream(stmBLOBData);
            DisplayStuInfo(Sid_);
            return;
        }
        private void btn_Up_Click(object sender, EventArgs e)
        {
            i--;
            if (i == 0)
            {
                i++;
                btn_Up.Enabled = false;
                MessageBox.Show("往上已经没有了！");
                return;
            }
            MemoryStream stmBLOBData = new MemoryStream(portrDAO.RollDisplay(i, out string Sid_));
            pictureBox.Image = Image.FromStream(stmBLOBData);
            DisplayStuInfo(Sid_);
            btn_Down.Enabled = true;
            return;
        }
        private void btn_Down_Click(object sender, EventArgs e)
        {
            i++;
            count = portrDAO.GainSumline();
            if (count + 1 == i)
            {
                i--;
                btn_Down.Enabled = false;
                MessageBox.Show("往下已经没有了！");
                return;
            }
            MemoryStream stmBLOBData = new MemoryStream(portrDAO.RollDisplay(i, out string Sid_));
            pictureBox.Image = Image.FromStream(stmBLOBData);
            DisplayStuInfo(Sid_);
            btn_Up.Enabled = true;
            return;
        }
    }
}
