using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TempletDAO templetDAO = new TempletDAO();
        private string pathName = string.Empty;
        public bool exist = true;
        private void Form1_Load(object sender, EventArgs e)
        {
            IniFile ini = new IniFile("D://record.ini");
            //判断返回值，避免第一次运行时为空出错
            if (ini.IniReadValue("table", "exist") != "")
            {
                bool status = Convert.ToBoolean(ini.IniReadValue("table", "exist"));
                if (status)
                {
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = templetDAO.SelectAll();
                    ChangeColumnNames();
                    btn_LookUp.Enabled = false;
                }
            }
            else
            {
                exist = false;
            }
            return;
        }
        private void btn_LookUp_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = ".";
            file.Filter = "表格文件(2007)|*.xlsx|表格文件(2003)|*.xls";
            file.ShowDialog();
            pathName = file.FileName;
            if (string.IsNullOrWhiteSpace(pathName))
            {
                MessageBox.Show("请选择文件！");
                return;
            }
            string fileClass = Path.GetExtension(pathName);
            DialogResult dr = MessageBox.Show("确定要将该文件中的数据导入到SQL Server?", "提示：", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                ExcelToTable(file.FileName, "sheet1", fileClass);
            }
            catch
            {
                MessageBox.Show("不能重复导入！");
            }
            btn_LookUp.Enabled = false;
            return;
        }
        public void ExcelToTable(string excelFile, string sheetName, string fileClass)
        {
            //获取全部数据
            string strConn;
            if (fileClass == ".xlsx")
            {
                strConn = "Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + excelFile + ";" + "Extended Properties = 'Excel 8.0;HDR=Yes;IMEX=1;'";
            }
            else
            {
                strConn = "provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + excelFile + ";" + "Extended Properties = 'Excel 8.0;HDR=Yes;IMEX=1;'";
            }

            //创建新表,excel文件的第一行为列标题,从第二行开始全部都是数据记录
            string strSql = string.Format("if not exists(select * from sysobjects where name = '{0}') create table {0}([Code] nvarchar(255) primary key,[AreaCode] nvarchar(20),[Quantity] int, [SortedQuan] int, [SortState] nvarchar(20))", sheetName, sheetName);

            SqlConnection Conn = DBHelper.Connect();
            Conn.Open();
            SqlCommand CMD = Conn.CreateCommand();
            CMD.CommandText = strSql;
            CMD.ExecuteNonQuery();
            Conn.Close();
            //用bcp导入数据
            //excel文件中列的顺序必须和数据表的列顺序一致
            using (SqlBulkCopy bcp = new SqlBulkCopy(DBHelper.Login))
            {
                bcp.BatchSize = 100;//每次传输的行数
                bcp.NotifyAfter = 100;//进度提示的行数
                bcp.DestinationTableName = sheetName;//目标表   
                bcp.WriteToServer(ListToTable(readExcel(".xlsx")));
            }           
            MessageBox.Show("导入完毕！");
            exist = true;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = templetDAO.SelectAll();
            ChangeColumnNames();
            IniFile ini = new IniFile("D://record.ini");
            ini.IniWriteValue("table", "exist", "true");
            //table初始状态为false，导入成功后改为true
            return;
        }
        public List<Templet> readExcel(string fileClass)
        {
            //通过select语句读取excel表的内容，存放到dataset中，方便操作
            List<Templet> list = new List<Templet>();
            try
            {
                //创建连接，引用协议
                string strConnect;
                if (fileClass == ".xlsx")
                {
                    strConnect = "Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + pathName + ";" + "Extended Properties = 'Excel 8.0;HDR=Yes;IMEX=1;'";
                }
                else
                {
                    strConnect = "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + pathName + ";" + "Extended Properties = 'Excel 8.0;HDR=Yes;IMEX=1;'";
                }
                //HDR=YES,第一行为表头，否则为FALSE
                OleDbConnection oleDbConnect = new OleDbConnection(strConnect);

                //打开连接，并执行sql语句，需要最后关闭
                oleDbConnect.Open();
                string sql = "SELECT 模板代码,数量 FROM [Sheet1$]";

                //执行sql命令
                OleDbDataAdapter oleDaExcel = new OleDbDataAdapter(sql, oleDbConnect);

                DataSet oleDsExcel = new DataSet();
                oleDaExcel.Fill(oleDsExcel, "Sheet1");
                oleDbConnect.Close();

                foreach (DataRow row in oleDsExcel.Tables["Sheet1"].Rows)
                {
                    Templet templet = new Templet();
                    templet.Code = row["模板代码"].ToString();
                    string code = row["模板代码"].ToString().Trim();
                    int begin = code.LastIndexOf('Q');
                    templet.AreaCode = code.Substring(begin + 1);
                    templet.Quantity = Convert.ToInt32(row["数量"]);
                    templet.SortedQuan = 0;
                    templet.SortState = "否";
                    list.Add(templet);
                }
                return list;
            }
            catch
            {
                return list;
            }
        }
        public static DataTable ListToTable<T>(List<T> list)
        {
            Type tp = typeof(T);
            System.Reflection.PropertyInfo[] proInfos = tp.GetProperties();
            DataTable dt = new DataTable();
            foreach (var item in proInfos)
            {
                dt.Columns.Add(item.Name, item.PropertyType); //添加列明及对应类型
            }
            foreach (var item in list)
            {
                DataRow dr = dt.NewRow();
                foreach (var proInfo in proInfos)
                {
                    object obj = proInfo.GetValue(item);
                    if (obj != null)
                    {
                        dr[proInfo.Name] = obj;
                    }   
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
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
        private void ChangeColumnNames()
        {
            dataGridView1.Columns["Code"].HeaderText = "模板代码";
            dataGridView1.Columns["AreaCode"].HeaderText = "模板区号";
            dataGridView1.Columns["Quantity"].HeaderText = "模板数量";
            dataGridView1.Columns["SortedQuan"].HeaderText = "已分拣模板数量";
            dataGridView1.Columns["SortState"].HeaderText = "是否分拣完毕";
            dataGridView1.Columns[0].FillWeight = 27;
            dataGridView1.Columns[1].FillWeight = 15;
            dataGridView1.Columns[2].FillWeight = 15;
            dataGridView1.Columns[3].FillWeight = 23;
            dataGridView1.Columns[4].FillWeight = 20;
            return;
        }
        private void btn_Display_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = templetDAO.SelectAll();
                ChangeColumnNames();
            }
            catch
            {
                MessageBox.Show("未导入表！");
            }
            return;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string code = textBox1.Text.Trim();
                int result = templetDAO.SelectOneCode(code);
                if(result == 1)
                {
                    Update(code);
                }
                else
                {
                    MessageBox.Show("不存在此模板！");
                }
            }
            return;
        }
        private void Update(string code)
        {
            int index = dataGridView1.CurrentRow.Index;
            int sortedQuan = templetDAO.SelectOneSortedQuan(code);
            int quan = templetDAO.SelectOneQuantity(code);
            if (sortedQuan != quan)
            {
                templetDAO.UpdateOneSortedQuan(sortedQuan + 1, code);
                sortedQuan = templetDAO.SelectOneSortedQuan(code);
                quan = templetDAO.SelectOneQuantity(code);
                if (sortedQuan == quan)
                {
                    templetDAO.UpdateOneSortState(code);
                }
            }
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = templetDAO.SelectAll();
            ChangeColumnNames();
            dataGridView1.Rows[index].Selected = true;//设置指定行
            dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
            textBox1.Text = "";
            return;
        }
        private void btn_TaskConfig_Click(object sender, EventArgs e)
        {
            if(exist)
            {
                IniFile ini = new IniFile("D://record.ini");
                bool status = false;
                //判断返回值，避免第一次运行时为空出错
                if (ini.IniReadValue("table_", "exist_") != "")
                {
                    status = Convert.ToBoolean(ini.IniReadValue("table_", "exist_"));
                }
                this.Hide();
                Form2 form2 = new Form2(status);
                form2.StartPosition = FormStartPosition.CenterScreen;
                form2.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("请先将excel表格导入数据库！");
            }
            return;
        }
        private void btn_LastTime_Click(object sender, EventArgs e)
        {
            try
            {
                IniFile ini = new IniFile("D://record.ini");
                //判断返回值，避免第一次运行时为空出错
                if (ini.IniReadValue("LOC", "index") != "")
                {
                    int index = int.Parse(ini.IniReadValue("LOC", "index"));
                    dataGridView1.Rows[index].Selected = true;//设置指定行
                    dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
                    //跳到指定行
                }
            }
            catch
            { }
            return;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            IniFile ini = new IniFile("D://record.ini");
            try
            {               
                ini.IniWriteValue("LOC", "index", dataGridView1.CurrentRow.Index.ToString());
            }
            catch
            {
                ini.IniWriteValue("LOC", "index", "0");
                ini.IniWriteValue("table", "exist", "false");
                ini.IniWriteValue("table_", "exist_", "false");                
            }
            return;
        }
    }
}
