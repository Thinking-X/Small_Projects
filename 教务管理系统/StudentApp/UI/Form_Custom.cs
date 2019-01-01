using StudentApp.DAL;
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
    public partial class Form_Custom : Form
    {
        public Form_Custom()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }
        CustomDAO custom = new CustomDAO();
        private void SetVisible()
        {
            for (int i = 0; i < 11; i++)
            {
                View_All.Columns[i].Visible = false;
            }
            return;
        }
        private void SelectAll_Click(object sender, EventArgs e)
        {
            foreach (CheckBox c in panelAll.Controls)
            {
                c.Checked = true;
            }
            return;
        }
        private void Select_Click(object sender, EventArgs e)
        {
            string[] ColumnName = { "学号", "姓名", "性别", "班级", "出生日期", "入学成绩", "编号", "课程号", "课程名", "学分", "分数" };
            List<int> list = new List<int>();
            bool sid = false,cid=false;
            foreach (CheckBox c in panelAll.Controls)
            {
                if (c.Checked == true)
                {
                    if (c.TabIndex == 0 || c.TabIndex == 11)
                    {
                        list.Add(0);
                        if(c.TabIndex == 0)
                        {
                            sid = true;
                        }
                    }
                    else if(c.TabIndex == 7 || c.TabIndex == 12)
                    {
                        list.Add(7);
                        if (c.TabIndex == 7)
                        {
                            cid = true;
                        }
                    }
                    else
                    {
                        list.Add(c.TabIndex);
                    }
                }
            }
            View_All.AutoGenerateColumns = true;
            if(sid == true)
            {
                View_All.DataSource = custom.SelectAll_Stu();
                SetVisible();
                for (int i = 0; i < list.Count; i++)
                {
                    View_All.Columns[list[i]].Visible = true;
                    View_All.Columns[list[i]].HeaderText = ColumnName[list[i]];
                }
                foreach (CheckBox c in panelAll.Controls)
                {
                    c.Checked = false;
                }
                return;
            }
            if(cid == true)
            {
                View_All.DataSource = custom.SelectAll_Cour();
                SetVisible();
                for (int i = 0; i < list.Count; i++)
                {
                    View_All.Columns[list[i]].Visible = true;
                    View_All.Columns[list[i]].HeaderText = ColumnName[list[i]];
                }
                foreach (CheckBox c in panelAll.Controls)
                {
                    c.Checked = false;
                }
                return;
            }
            View_All.DataSource = custom.SelectAll_SC();
            SetVisible();
            for (int i = 0; i < list.Count; i++)
            {
                View_All.Columns[list[i]].Visible = true;
                View_All.Columns[list[i]].HeaderText = ColumnName[list[i]];
            }
            foreach (CheckBox c in panelAll.Controls)
            {
                c.Checked = false;
            }
            return;
        }
        private void View_All_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
    }
}
