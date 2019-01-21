using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelProj
{
    public partial class Form2 : Form
    {      
        public bool status;
        TempletDAO templetDAO = new TempletDAO();
        public Form2(bool status_)
        {
            InitializeComponent();
            status = status_;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            int max = templetDAO.SelectMaxAreaCode();
            int number = max / 5;
            string[] range = new string[8];
            int i, range1 = 0, range2 = 0;
            for (i = 1; i <= number; i++)
            {
                range1 = 5 * i - 4;
                range2 = 5 * i;
                range[i - 1] = range1.ToString() + " - " + range2.ToString();
            }
            range[i - 1] = (range2 + 1).ToString() + " - " + max.ToString();
            textBox2.Text = range[0];
            textBox3.Text = range[1];
            textBox4.Text = range[2];
            textBox5.Text = range[3];
            textBox6.Text = range[4];
            textBox7.Text = range[5];
            textBox8.Text = range[6];
            textBox9.Text = range[7];
            if (status)
            {
                btn_Save.Enabled = false;
            }
            else
            {
                btn_Display.Enabled = false;
            }
            return;
        }
        private void Form2_Shown(object sender, EventArgs e){ }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
        private void ChangeColumnNames_()
        {
            dataGridView1.Columns["ID"].HeaderText = "ID";
            dataGridView1.Columns["Name"].HeaderText = "工位名称";
            dataGridView1.Columns["Status"].HeaderText = "工位是否使用";
            dataGridView1.Columns["BeginNum"].HeaderText = "起始区号";
            dataGridView1.Columns["EndNum"].HeaderText = "终止区号";
            return;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                templetDAO.CreateTaskConfigTable();
                int max = templetDAO.SelectMaxAreaCode();
                int number = max / 5;
                int i, range1 = 0, range2 = 0;
                TaskConfig task = new TaskConfig();
                for (i = 1; i <= number; i++)
                {
                    range1 = 5 * i - 4;
                    range2 = 5 * i;
                    task.BeginNum = range1;
                    task.EndNum = range2;
                    task.ID = i.ToString();
                    task.Name = "工位" + i.ToString();
                    task.Status = "是";
                    templetDAO.InsertTaskConfig(task);
                }
                task.BeginNum = range2 + 1;
                task.EndNum = max;
                task.ID = i.ToString();
                task.Name = "工位" + i.ToString();
                task.Status = "是";
                templetDAO.InsertTaskConfig(task);
                MessageBox.Show("导入成功！");
                btn_Display.Enabled = true;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = templetDAO.SelectAll_();
                ChangeColumnNames_();
                IniFile ini = new IniFile("D://record.ini");
                ini.IniWriteValue("table_", "exist_", "true");
                //table_初始状态为false，导入成功后改为true
            }
            catch
            {
                MessageBox.Show("导入失败！");               
            }
            btn_Save.Enabled = false;
            return;
        }
        private void btn_Display_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = templetDAO.SelectAll_();
            ChangeColumnNames_();
            return;
        }
    }
}
