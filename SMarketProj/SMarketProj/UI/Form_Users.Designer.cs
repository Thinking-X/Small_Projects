namespace SMarketProj.UI
{
    partial class Form_Users
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
            this.Insert = new System.Windows.Forms.Button();
            this.View_User = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboProp = new System.Windows.Forms.ComboBox();
            this.textVal = new System.Windows.Forms.TextBox();
            this.Display = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.View_User)).BeginInit();
            this.SuspendLayout();
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(514, 446);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(221, 43);
            this.Select.TabIndex = 14;
            this.Select.Text = "查询";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(278, 376);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(103, 43);
            this.Insert.TabIndex = 11;
            this.Insert.Text = "添加";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // View_User
            // 
            this.View_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_User.Location = new System.Drawing.Point(57, 47);
            this.View_User.Name = "View_User";
            this.View_User.RowTemplate.Height = 27;
            this.View_User.Size = new System.Drawing.Size(814, 270);
            this.View_User.TabIndex = 10;
            this.View_User.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.View_User_RowPostPaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "选择查询方式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "请输入(选填)";
            // 
            // comboProp
            // 
            this.comboProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProp.FormattingEnabled = true;
            this.comboProp.Location = new System.Drawing.Point(614, 360);
            this.comboProp.Name = "comboProp";
            this.comboProp.Size = new System.Drawing.Size(121, 23);
            this.comboProp.TabIndex = 18;
            // 
            // textVal
            // 
            this.textVal.Location = new System.Drawing.Point(614, 402);
            this.textVal.Name = "textVal";
            this.textVal.Size = new System.Drawing.Size(121, 25);
            this.textVal.TabIndex = 19;
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(118, 376);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(94, 43);
            this.Display.TabIndex = 20;
            this.Display.Text = "显示全部";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // Form_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 529);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.textVal);
            this.Controls.Add(this.comboProp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.View_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_Users";
            this.Text = "用户表";
            this.Load += new System.EventHandler(this.Form_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.DataGridView View_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboProp;
        private System.Windows.Forms.TextBox textVal;
        private System.Windows.Forms.Button Display;
    }
}