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
using MaterialSkin.Controls;
using SMarketProj.DAL;

namespace SMarketProj.UI
{
    public partial class Form_Portrait : MaterialForm
    {
        PortrDAO portrDAO = new PortrDAO();
        public Form_Portrait()
        {
            InitializeComponent();
        }
        private void Form_Portrait_Load(object sender, EventArgs e)
        {
            View_Num.DataSource = portrDAO.DisplayAllPortr();
            View_Num.Columns[0].HeaderText = "会员号";
            return;
        }
        private void View_Num_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
        private void btn_Select_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            string MemNum = TextNum.Text.Trim();
            if (MemNum == "")
            {
                MessageBox.Show("请输入会员号！");
                return;
            }
            int count = portrDAO.SelectPortr(MemNum);
            if (count == 0)
            {
                MessageBox.Show("未找到该会员的头像！");
            }
            else
            {
                MemoryStream stmBLOBData = new MemoryStream(portrDAO.DisplayPortr(MemNum));
                pictureBox1.Image = Image.FromStream(stmBLOBData);
            }
            return;
        }
        string MemberNum;
        private void View_Num_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.RowIndex > -1)
                {
                    View_Num.ClearSelection();
                    View_Num.Rows[e.RowIndex].Selected = true;
                    MemberNum = View_Num.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
            }
            catch
            {
                return;
            }
        }
        private void DisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (portrDAO.SelectPortr(MemberNum) == 1)
            {
                MemoryStream stmBLOBData = new MemoryStream(portrDAO.DisplayPortr(MemberNum));
                pictureBox1.Image = Image.FromStream(stmBLOBData);
            }
            else
            {
                MessageBox.Show("该会员没有头像信息！"); 
            }
            return;
        }
    }
}
