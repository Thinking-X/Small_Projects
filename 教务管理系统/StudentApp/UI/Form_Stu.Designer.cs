﻿namespace StudentApp
{
    partial class Form_Stu
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
            this.radio_Y = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_X = new System.Windows.Forms.RadioButton();
            this.Birthdate = new System.Windows.Forms.DateTimePicker();
            this.Delete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Val = new System.Windows.Forms.TextBox();
            this.Prop = new System.Windows.Forms.ComboBox();
            this.SelectBox = new System.Windows.Forms.GroupBox();
            this.valText2 = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.valText1 = new System.Windows.Forms.TextBox();
            this.Select = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Sname = new System.Windows.Forms.TextBox();
            this.AScores = new System.Windows.Forms.TextBox();
            this.Sid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.Button();
            this.ClassName = new System.Windows.Forms.TextBox();
            this.View_Stu = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DownPage = new System.Windows.Forms.Button();
            this.UpPage = new System.Windows.Forms.Button();
            this.FirstPage = new System.Windows.Forms.Button();
            this.LineNum = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SelectBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View_Stu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radio_Y
            // 
            this.radio_Y.AutoSize = true;
            this.radio_Y.Location = new System.Drawing.Point(17, 20);
            this.radio_Y.Name = "radio_Y";
            this.radio_Y.Size = new System.Drawing.Size(43, 19);
            this.radio_Y.TabIndex = 21;
            this.radio_Y.TabStop = true;
            this.radio_Y.Text = "男";
            this.radio_Y.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_X);
            this.groupBox1.Controls.Add(this.radio_Y);
            this.groupBox1.Location = new System.Drawing.Point(928, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 45);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // radio_X
            // 
            this.radio_X.AutoSize = true;
            this.radio_X.Location = new System.Drawing.Point(75, 20);
            this.radio_X.Name = "radio_X";
            this.radio_X.Size = new System.Drawing.Size(43, 19);
            this.radio_X.TabIndex = 22;
            this.radio_X.TabStop = true;
            this.radio_X.Text = "女";
            this.radio_X.UseVisualStyleBackColor = true;
            // 
            // Birthdate
            // 
            this.Birthdate.Location = new System.Drawing.Point(914, 273);
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Size = new System.Drawing.Size(158, 25);
            this.Birthdate.TabIndex = 52;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(62, 183);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(210, 33);
            this.Delete.TabIndex = 24;
            this.Delete.Text = "确认删除";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "输入(选填)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "选择查找方式：";
            // 
            // Val
            // 
            this.Val.Location = new System.Drawing.Point(126, 82);
            this.Val.Name = "Val";
            this.Val.Size = new System.Drawing.Size(167, 25);
            this.Val.TabIndex = 30;
            // 
            // Prop
            // 
            this.Prop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Prop.FormattingEnabled = true;
            this.Prop.Location = new System.Drawing.Point(126, 38);
            this.Prop.Name = "Prop";
            this.Prop.Size = new System.Drawing.Size(167, 23);
            this.Prop.TabIndex = 29;
            this.Prop.SelectedIndexChanged += new System.EventHandler(this.Prop_SelectedIndexChanged);
            this.Prop.Click += new System.EventHandler(this.Prop_Click);
            // 
            // SelectBox
            // 
            this.SelectBox.Controls.Add(this.valText2);
            this.SelectBox.Controls.Add(this.toLabel);
            this.SelectBox.Controls.Add(this.Delete);
            this.SelectBox.Controls.Add(this.label8);
            this.SelectBox.Controls.Add(this.valText1);
            this.SelectBox.Controls.Add(this.label7);
            this.SelectBox.Controls.Add(this.Val);
            this.SelectBox.Controls.Add(this.Prop);
            this.SelectBox.Controls.Add(this.Select);
            this.SelectBox.Location = new System.Drawing.Point(441, 342);
            this.SelectBox.Name = "SelectBox";
            this.SelectBox.Size = new System.Drawing.Size(344, 238);
            this.SelectBox.TabIndex = 49;
            this.SelectBox.TabStop = false;
            this.SelectBox.Text = "查找/删除";
            // 
            // valText2
            // 
            this.valText2.Location = new System.Drawing.Point(245, 82);
            this.valText2.Name = "valText2";
            this.valText2.Size = new System.Drawing.Size(48, 25);
            this.valText2.TabIndex = 57;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(202, 88);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(15, 15);
            this.toLabel.TabIndex = 58;
            this.toLabel.Text = "-";
            // 
            // valText1
            // 
            this.valText1.Location = new System.Drawing.Point(126, 82);
            this.valText1.Name = "valText1";
            this.valText1.Size = new System.Drawing.Size(52, 25);
            this.valText1.TabIndex = 56;
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(62, 130);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(210, 33);
            this.Select.TabIndex = 3;
            this.Select.Text = "确认查找";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(198, 318);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(94, 44);
            this.Update.TabIndex = 48;
            this.Update.Text = "更改信息";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Sname
            // 
            this.Sname.Location = new System.Drawing.Point(916, 78);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(158, 25);
            this.Sname.TabIndex = 47;
            // 
            // AScores
            // 
            this.AScores.Location = new System.Drawing.Point(914, 222);
            this.AScores.Name = "AScores";
            this.AScores.Size = new System.Drawing.Size(158, 25);
            this.AScores.TabIndex = 45;
            // 
            // Sid
            // 
            this.Sid.Location = new System.Drawing.Point(916, 39);
            this.Sid.Name = "Sid";
            this.Sid.Size = new System.Drawing.Size(158, 25);
            this.Sid.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(862, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "成绩";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(862, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "生日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(862, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "班级";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(862, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(862, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "学号";
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(865, 339);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(207, 45);
            this.Insert.TabIndex = 37;
            this.Insert.Text = "注册";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(862, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "性别";
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(35, 318);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(123, 44);
            this.Display.TabIndex = 35;
            this.Display.Text = "显示全部学生";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // ClassName
            // 
            this.ClassName.Location = new System.Drawing.Point(914, 172);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(158, 25);
            this.ClassName.TabIndex = 46;
            // 
            // View_Stu
            // 
            this.View_Stu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_Stu.Location = new System.Drawing.Point(33, 36);
            this.View_Stu.Name = "View_Stu";
            this.View_Stu.RowTemplate.Height = 27;
            this.View_Stu.Size = new System.Drawing.Size(800, 262);
            this.View_Stu.TabIndex = 34;
            this.View_Stu.Tag = "550:302:84:60:23";
            this.View_Stu.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.View_Stu_RowPostPaint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.DownPage);
            this.groupBox2.Controls.Add(this.UpPage);
            this.groupBox2.Controls.Add(this.FirstPage);
            this.groupBox2.Controls.Add(this.LineNum);
            this.groupBox2.Location = new System.Drawing.Point(35, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 204);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "分页显示";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 55;
            this.label9.Text = "每页显示的行数";
            // 
            // DownPage
            // 
            this.DownPage.Location = new System.Drawing.Point(29, 155);
            this.DownPage.Name = "DownPage";
            this.DownPage.Size = new System.Drawing.Size(179, 33);
            this.DownPage.TabIndex = 3;
            this.DownPage.Text = "下一页";
            this.DownPage.UseVisualStyleBackColor = true;
            this.DownPage.Click += new System.EventHandler(this.DownPage_Click);
            // 
            // UpPage
            // 
            this.UpPage.Location = new System.Drawing.Point(29, 110);
            this.UpPage.Name = "UpPage";
            this.UpPage.Size = new System.Drawing.Size(179, 33);
            this.UpPage.TabIndex = 2;
            this.UpPage.Text = "上一页";
            this.UpPage.UseVisualStyleBackColor = true;
            this.UpPage.Click += new System.EventHandler(this.UpPage_Click);
            // 
            // FirstPage
            // 
            this.FirstPage.Location = new System.Drawing.Point(29, 64);
            this.FirstPage.Name = "FirstPage";
            this.FirstPage.Size = new System.Drawing.Size(179, 33);
            this.FirstPage.TabIndex = 1;
            this.FirstPage.Text = "显示第一页";
            this.FirstPage.UseVisualStyleBackColor = true;
            this.FirstPage.Click += new System.EventHandler(this.FirstPage_Click);
            // 
            // LineNum
            // 
            this.LineNum.Location = new System.Drawing.Point(144, 27);
            this.LineNum.Name = "LineNum";
            this.LineNum.Size = new System.Drawing.Size(64, 25);
            this.LineNum.TabIndex = 0;
            // 
            // Form_Stu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 599);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Birthdate);
            this.Controls.Add(this.SelectBox);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Sname);
            this.Controls.Add(this.AScores);
            this.Controls.Add(this.Sid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.ClassName);
            this.Controls.Add(this.View_Stu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_Stu";
            this.Text = "学生窗口";
            this.Load += new System.EventHandler(this.Form_Stu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SelectBox.ResumeLayout(false);
            this.SelectBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View_Stu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_Y;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_X;
        private System.Windows.Forms.DateTimePicker Birthdate;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Val;
        private System.Windows.Forms.ComboBox Prop;
        private System.Windows.Forms.GroupBox SelectBox;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox Sname;
        private System.Windows.Forms.TextBox AScores;
        private System.Windows.Forms.TextBox Sid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.TextBox ClassName;
        private System.Windows.Forms.DataGridView View_Stu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DownPage;
        private System.Windows.Forms.Button UpPage;
        private System.Windows.Forms.Button FirstPage;
        private System.Windows.Forms.TextBox LineNum;
        private System.Windows.Forms.TextBox valText1;
        private System.Windows.Forms.TextBox valText2;
        private System.Windows.Forms.Label toLabel;
    }
}

