namespace StudentApp.UI
{
    partial class Form_Portrait
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.DisplayFirst = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.btn_Down = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSname = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelBirth = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelScores = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.Button();
            this.labelTips = new System.Windows.Forms.Label();
            this.textSID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lable6 = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.View_SID = new System.Windows.Forms.DataGridView();
            this.labelSID = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View_SID)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(60, 56);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(186, 246);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // DisplayFirst
            // 
            this.DisplayFirst.Location = new System.Drawing.Point(60, 378);
            this.DisplayFirst.Name = "DisplayFirst";
            this.DisplayFirst.Size = new System.Drawing.Size(186, 45);
            this.DisplayFirst.TabIndex = 1;
            this.DisplayFirst.Text = "显示第一个";
            this.DisplayFirst.UseVisualStyleBackColor = true;
            this.DisplayFirst.Click += new System.EventHandler(this.DisplayFirst_Click);
            // 
            // btn_Up
            // 
            this.btn_Up.Location = new System.Drawing.Point(60, 443);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(186, 45);
            this.btn_Up.TabIndex = 2;
            this.btn_Up.Text = "上一个";
            this.btn_Up.UseVisualStyleBackColor = true;
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // btn_Down
            // 
            this.btn_Down.Location = new System.Drawing.Point(60, 510);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(186, 45);
            this.btn_Down.TabIndex = 3;
            this.btn_Down.Text = "下一个";
            this.btn_Down.UseVisualStyleBackColor = true;
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(306, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "学号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(306, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(306, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(306, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "出生日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(306, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "班级";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(306, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "入学成绩";
            // 
            // labelSname
            // 
            this.labelSname.AutoSize = true;
            this.labelSname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSname.Location = new System.Drawing.Point(423, 109);
            this.labelSname.Name = "labelSname";
            this.labelSname.Size = new System.Drawing.Size(49, 20);
            this.labelSname.TabIndex = 16;
            this.labelSname.Text = "----";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSex.Location = new System.Drawing.Point(423, 164);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(49, 20);
            this.labelSex.TabIndex = 17;
            this.labelSex.Text = "----";
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBirth.Location = new System.Drawing.Point(423, 217);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(49, 20);
            this.labelBirth.TabIndex = 18;
            this.labelBirth.Text = "----";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelClass.Location = new System.Drawing.Point(423, 273);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(49, 20);
            this.labelClass.TabIndex = 19;
            this.labelClass.Text = "----";
            // 
            // labelScores
            // 
            this.labelScores.AutoSize = true;
            this.labelScores.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelScores.Location = new System.Drawing.Point(423, 326);
            this.labelScores.Name = "labelScores";
            this.labelScores.Size = new System.Drawing.Size(49, 20);
            this.labelScores.TabIndex = 20;
            this.labelScores.Text = "----";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(310, 488);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(187, 67);
            this.Update.TabIndex = 23;
            this.Update.Text = "更改头像";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(559, 488);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(187, 67);
            this.Select.TabIndex = 24;
            this.Select.Text = "查询";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // labelTips
            // 
            this.labelTips.AutoSize = true;
            this.labelTips.Location = new System.Drawing.Point(923, 540);
            this.labelTips.Name = "labelTips";
            this.labelTips.Size = new System.Drawing.Size(105, 15);
            this.labelTips.TabIndex = 27;
            this.labelTips.Text = "*右键显示菜单";
            // 
            // textSID
            // 
            this.textSID.Location = new System.Drawing.Point(629, 443);
            this.textSID.Name = "textSID";
            this.textSID.Size = new System.Drawing.Size(117, 25);
            this.textSID.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(556, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 30;
            this.label8.Text = "输入学号";
            // 
            // lable6
            // 
            this.lable6.AutoSize = true;
            this.lable6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable6.Location = new System.Drawing.Point(868, 41);
            this.lable6.Name = "lable6";
            this.lable6.Size = new System.Drawing.Size(89, 20);
            this.lable6.TabIndex = 31;
            this.lable6.Text = "所有学号";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DisplayToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(169, 28);
            // 
            // DisplayToolStripMenuItem
            // 
            this.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem";
            this.DisplayToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.DisplayToolStripMenuItem.Text = "显示该生头像";
            this.DisplayToolStripMenuItem.Click += new System.EventHandler(this.DisplayToolStripMenuItem_Click);
            // 
            // View_SID
            // 
            this.View_SID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_SID.ContextMenuStrip = this.contextMenuStrip;
            this.View_SID.Location = new System.Drawing.Point(815, 80);
            this.View_SID.Name = "View_SID";
            this.View_SID.RowTemplate.Height = 27;
            this.View_SID.Size = new System.Drawing.Size(213, 450);
            this.View_SID.TabIndex = 32;
            this.View_SID.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.View_SID_CellMouseDown);
            this.View_SID.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.View_SID_RowPostPaint);
            // 
            // labelSID
            // 
            this.labelSID.AutoSize = true;
            this.labelSID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSID.Location = new System.Drawing.Point(424, 56);
            this.labelSID.Name = "labelSID";
            this.labelSID.Size = new System.Drawing.Size(49, 20);
            this.labelSID.TabIndex = 33;
            this.labelSID.Text = "----";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(310, 378);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(187, 67);
            this.Delete.TabIndex = 34;
            this.Delete.Text = "删除头像";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form_Portrait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 603);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.labelSID);
            this.Controls.Add(this.View_SID);
            this.Controls.Add(this.lable6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textSID);
            this.Controls.Add(this.labelTips);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.labelScores);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelSname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Down);
            this.Controls.Add(this.btn_Up);
            this.Controls.Add(this.DisplayFirst);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_Portrait";
            this.Text = "学生肖像窗口";
            this.Load += new System.EventHandler(this.Form_Portrait_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.View_SID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button DisplayFirst;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.Button btn_Down;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSname;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelScores;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Label labelTips;
        private System.Windows.Forms.TextBox textSID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lable6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem DisplayToolStripMenuItem;
        private System.Windows.Forms.DataGridView View_SID;
        private System.Windows.Forms.Label labelSID;
        private System.Windows.Forms.Button Delete;
    }
}