namespace SMarketProj.UI
{
    partial class Form_Member
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
            this.Select = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.View_Memb = new System.Windows.Forms.DataGridView();
            this.DisplayTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboProp = new System.Windows.Forms.ComboBox();
            this.textVal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.View_Memb)).BeginInit();
            this.SuspendLayout();
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(560, 445);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(221, 43);
            this.Select.TabIndex = 4;
            this.Select.Text = "查找";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(340, 445);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(132, 43);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "删除";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(340, 362);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(132, 43);
            this.Insert.TabIndex = 1;
            this.Insert.Text = "添加";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // View_Memb
            // 
            this.View_Memb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_Memb.Location = new System.Drawing.Point(58, 51);
            this.View_Memb.Name = "View_Memb";
            this.View_Memb.Size = new System.Drawing.Size(808, 270);
            this.View_Memb.TabIndex = 0;
            this.View_Memb.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.View_Memb_RowPostPaint);
            // 
            // DisplayTable
            // 
            this.DisplayTable.Location = new System.Drawing.Point(106, 362);
            this.DisplayTable.Name = "DisplayTable";
            this.DisplayTable.Size = new System.Drawing.Size(132, 43);
            this.DisplayTable.TabIndex = 5;
            this.DisplayTable.Text = "显示全部";
            this.DisplayTable.UseVisualStyleBackColor = true;
            this.DisplayTable.Click += new System.EventHandler(this.DisplayTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "选择查找方式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "请输入(选填)";
            // 
            // comboProp
            // 
            this.comboProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProp.FormattingEnabled = true;
            this.comboProp.Location = new System.Drawing.Point(660, 367);
            this.comboProp.Name = "comboProp";
            this.comboProp.Size = new System.Drawing.Size(121, 23);
            this.comboProp.TabIndex = 8;
            // 
            // textVal
            // 
            this.textVal.Location = new System.Drawing.Point(660, 403);
            this.textVal.Name = "textVal";
            this.textVal.Size = new System.Drawing.Size(121, 25);
            this.textVal.TabIndex = 9;
            // 
            // Form_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 529);
            this.Controls.Add(this.textVal);
            this.Controls.Add(this.comboProp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayTable);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.View_Memb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_Member";
            this.Text = "会员表";
            this.Load += new System.EventHandler(this.Form_Member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_Memb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.DataGridView View_Memb;
        private System.Windows.Forms.Button DisplayTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboProp;
        private System.Windows.Forms.TextBox textVal;
    }
}