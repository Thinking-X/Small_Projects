namespace StudentApp.UI
{
    partial class Form_Custom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SID = new System.Windows.Forms.CheckBox();
            this.Sname = new System.Windows.Forms.CheckBox();
            this.Sex = new System.Windows.Forms.CheckBox();
            this.ClassName = new System.Windows.Forms.CheckBox();
            this.Birthdate = new System.Windows.Forms.CheckBox();
            this.Ascores = new System.Windows.Forms.CheckBox();
            this.Select = new System.Windows.Forms.Button();
            this.panelAll = new System.Windows.Forms.Panel();
            this.CID_ = new System.Windows.Forms.CheckBox();
            this.SID_ = new System.Windows.Forms.CheckBox();
            this.Scores = new System.Windows.Forms.CheckBox();
            this.Credit = new System.Windows.Forms.CheckBox();
            this.Cname = new System.Windows.Forms.CheckBox();
            this.CID = new System.Windows.Forms.CheckBox();
            this.No = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.View_All = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectAll = new System.Windows.Forms.Button();
            this.panelAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View_All)).BeginInit();
            this.SuspendLayout();
            // 
            // SID
            // 
            this.SID.AutoSize = true;
            this.SID.Location = new System.Drawing.Point(18, 16);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(59, 19);
            this.SID.TabIndex = 0;
            this.SID.Tag = "SID";
            this.SID.Text = "学号";
            this.SID.UseVisualStyleBackColor = true;
            // 
            // Sname
            // 
            this.Sname.AutoSize = true;
            this.Sname.Location = new System.Drawing.Point(18, 55);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(59, 19);
            this.Sname.TabIndex = 1;
            this.Sname.Tag = "Sname";
            this.Sname.Text = "姓名";
            this.Sname.UseVisualStyleBackColor = true;
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Location = new System.Drawing.Point(18, 94);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(59, 19);
            this.Sex.TabIndex = 2;
            this.Sex.Tag = "Sex";
            this.Sex.Text = "性别";
            this.Sex.UseVisualStyleBackColor = true;
            // 
            // ClassName
            // 
            this.ClassName.AutoSize = true;
            this.ClassName.Location = new System.Drawing.Point(18, 130);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(59, 19);
            this.ClassName.TabIndex = 3;
            this.ClassName.Tag = "ClassName";
            this.ClassName.Text = "班级";
            this.ClassName.UseVisualStyleBackColor = true;
            // 
            // Birthdate
            // 
            this.Birthdate.AutoSize = true;
            this.Birthdate.Location = new System.Drawing.Point(18, 169);
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Size = new System.Drawing.Size(89, 19);
            this.Birthdate.TabIndex = 4;
            this.Birthdate.Tag = "Birthdate";
            this.Birthdate.Text = "出生日期";
            this.Birthdate.UseVisualStyleBackColor = true;
            // 
            // Ascores
            // 
            this.Ascores.AutoSize = true;
            this.Ascores.Location = new System.Drawing.Point(18, 207);
            this.Ascores.Name = "Ascores";
            this.Ascores.Size = new System.Drawing.Size(89, 19);
            this.Ascores.TabIndex = 5;
            this.Ascores.Tag = "Ascores";
            this.Ascores.Text = "入学成绩";
            this.Ascores.UseVisualStyleBackColor = true;
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(502, 403);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(142, 71);
            this.Select.TabIndex = 9;
            this.Select.Text = "查询";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.CID_);
            this.panelAll.Controls.Add(this.SID_);
            this.panelAll.Controls.Add(this.Scores);
            this.panelAll.Controls.Add(this.Credit);
            this.panelAll.Controls.Add(this.Cname);
            this.panelAll.Controls.Add(this.CID);
            this.panelAll.Controls.Add(this.No);
            this.panelAll.Controls.Add(this.SID);
            this.panelAll.Controls.Add(this.Ascores);
            this.panelAll.Controls.Add(this.ClassName);
            this.panelAll.Controls.Add(this.Sname);
            this.panelAll.Controls.Add(this.Sex);
            this.panelAll.Controls.Add(this.Birthdate);
            this.panelAll.Location = new System.Drawing.Point(22, 317);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(394, 241);
            this.panelAll.TabIndex = 10;
            // 
            // CID_
            // 
            this.CID_.AutoSize = true;
            this.CID_.Location = new System.Drawing.Point(306, 101);
            this.CID_.Name = "CID_";
            this.CID_.Size = new System.Drawing.Size(74, 19);
            this.CID_.TabIndex = 12;
            this.CID_.Tag = "CID";
            this.CID_.Text = "课程号";
            this.CID_.UseVisualStyleBackColor = true;
            // 
            // SID_
            // 
            this.SID_.AutoSize = true;
            this.SID_.Location = new System.Drawing.Point(308, 16);
            this.SID_.Name = "SID_";
            this.SID_.Size = new System.Drawing.Size(59, 19);
            this.SID_.TabIndex = 11;
            this.SID_.Tag = "SID";
            this.SID_.Text = "学号";
            this.SID_.UseVisualStyleBackColor = true;
            // 
            // Scores
            // 
            this.Scores.AutoSize = true;
            this.Scores.Location = new System.Drawing.Point(308, 207);
            this.Scores.Name = "Scores";
            this.Scores.Size = new System.Drawing.Size(59, 19);
            this.Scores.TabIndex = 10;
            this.Scores.Tag = "Scores";
            this.Scores.Text = "分数";
            this.Scores.UseVisualStyleBackColor = true;
            // 
            // Credit
            // 
            this.Credit.AutoSize = true;
            this.Credit.Location = new System.Drawing.Point(153, 207);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(59, 19);
            this.Credit.TabIndex = 9;
            this.Credit.Tag = "Credit";
            this.Credit.Text = "学分";
            this.Credit.UseVisualStyleBackColor = true;
            // 
            // Cname
            // 
            this.Cname.AutoSize = true;
            this.Cname.Location = new System.Drawing.Point(153, 138);
            this.Cname.Name = "Cname";
            this.Cname.Size = new System.Drawing.Size(74, 19);
            this.Cname.TabIndex = 8;
            this.Cname.Tag = "Cname";
            this.Cname.Text = "课程名";
            this.Cname.UseVisualStyleBackColor = true;
            // 
            // CID
            // 
            this.CID.AutoSize = true;
            this.CID.Location = new System.Drawing.Point(152, 78);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(74, 19);
            this.CID.TabIndex = 7;
            this.CID.Tag = "CID";
            this.CID.Text = "课程号";
            this.CID.UseVisualStyleBackColor = true;
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.Location = new System.Drawing.Point(153, 16);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(59, 19);
            this.No.TabIndex = 6;
            this.No.Tag = "No";
            this.No.Text = "编号";
            this.No.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "学生信息表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "成绩信息表";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "课程信息表";
            // 
            // View_All
            // 
            this.View_All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_All.Location = new System.Drawing.Point(19, 25);
            this.View_All.Name = "View_All";
            this.View_All.RowTemplate.Height = 27;
            this.View_All.Size = new System.Drawing.Size(1065, 254);
            this.View_All.TabIndex = 14;
            this.View_All.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.View_All_RowPostPaint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "在上方选择要查询的属性";
            // 
            // SelectAll
            // 
            this.SelectAll.Location = new System.Drawing.Point(502, 515);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(142, 34);
            this.SelectAll.TabIndex = 16;
            this.SelectAll.Text = "一键选择所有";
            this.SelectAll.UseVisualStyleBackColor = true;
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // Form_Custom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 599);
            this.Controls.Add(this.SelectAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.View_All);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_Custom";
            this.Text = "自定义查询窗口";
            this.panelAll.ResumeLayout(false);
            this.panelAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View_All)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox SID;
        private System.Windows.Forms.CheckBox Sname;
        private System.Windows.Forms.CheckBox Sex;
        private System.Windows.Forms.CheckBox ClassName;
        private System.Windows.Forms.CheckBox Birthdate;
        private System.Windows.Forms.CheckBox Ascores;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.CheckBox Scores;
        private System.Windows.Forms.CheckBox Credit;
        private System.Windows.Forms.CheckBox Cname;
        private System.Windows.Forms.CheckBox CID;
        private System.Windows.Forms.CheckBox No;
        private System.Windows.Forms.CheckBox CID_;
        private System.Windows.Forms.CheckBox SID_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView View_All;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SelectAll;
    }
}