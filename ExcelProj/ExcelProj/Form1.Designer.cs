namespace ExcelProj
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_LookUp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Display = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_LastTime = new System.Windows.Forms.Button();
            this.btn_TaskConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LookUp
            // 
            this.btn_LookUp.Location = new System.Drawing.Point(40, 359);
            this.btn_LookUp.Name = "btn_LookUp";
            this.btn_LookUp.Size = new System.Drawing.Size(138, 43);
            this.btn_LookUp.TabIndex = 0;
            this.btn_LookUp.Text = "查找Excel文件";
            this.btn_LookUp.UseVisualStyleBackColor = true;
            this.btn_LookUp.Click += new System.EventHandler(this.btn_LookUp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(766, 283);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // btn_Display
            // 
            this.btn_Display.Location = new System.Drawing.Point(40, 435);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(138, 43);
            this.btn_Display.TabIndex = 2;
            this.btn_Display.Text = "显示数据";
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(347, 365);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 25);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "输入模板代码";
            // 
            // btn_LastTime
            // 
            this.btn_LastTime.Location = new System.Drawing.Point(668, 359);
            this.btn_LastTime.Name = "btn_LastTime";
            this.btn_LastTime.Size = new System.Drawing.Size(138, 43);
            this.btn_LastTime.TabIndex = 5;
            this.btn_LastTime.Text = "继续上次任务";
            this.btn_LastTime.UseVisualStyleBackColor = true;
            this.btn_LastTime.Click += new System.EventHandler(this.btn_LastTime_Click);
            // 
            // btn_TaskConfig
            // 
            this.btn_TaskConfig.Location = new System.Drawing.Point(668, 435);
            this.btn_TaskConfig.Name = "btn_TaskConfig";
            this.btn_TaskConfig.Size = new System.Drawing.Size(138, 43);
            this.btn_TaskConfig.TabIndex = 6;
            this.btn_TaskConfig.Text = "工位任务配置";
            this.btn_TaskConfig.UseVisualStyleBackColor = true;
            this.btn_TaskConfig.Click += new System.EventHandler(this.btn_TaskConfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 509);
            this.Controls.Add(this.btn_TaskConfig);
            this.Controls.Add(this.btn_LastTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Display);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_LookUp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LookUp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_LastTime;
        private System.Windows.Forms.Button btn_TaskConfig;
    }
}

