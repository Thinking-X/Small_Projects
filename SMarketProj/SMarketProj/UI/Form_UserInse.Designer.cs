namespace SMarketProj.UI
{
    partial class Form_UserInse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RoleNum = new System.Windows.Forms.TextBox();
            this.UserNum = new System.Windows.Forms.TextBox();
            this.UserPwd = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "角色号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户密码";
            // 
            // RoleNum
            // 
            this.RoleNum.Location = new System.Drawing.Point(227, 102);
            this.RoleNum.Name = "RoleNum";
            this.RoleNum.Size = new System.Drawing.Size(120, 25);
            this.RoleNum.TabIndex = 3;
            // 
            // UserNum
            // 
            this.UserNum.Location = new System.Drawing.Point(227, 172);
            this.UserNum.Name = "UserNum";
            this.UserNum.Size = new System.Drawing.Size(120, 25);
            this.UserNum.TabIndex = 4;
            // 
            // UserPwd
            // 
            this.UserPwd.Location = new System.Drawing.Point(227, 242);
            this.UserPwd.Name = "UserPwd";
            this.UserPwd.Size = new System.Drawing.Size(120, 25);
            this.UserPwd.TabIndex = 5;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(130, 316);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(217, 45);
            this.Insert.TabIndex = 6;
            this.Insert.Text = "确认添加";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Form_UserInse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 457);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.UserPwd);
            this.Controls.Add(this.UserNum);
            this.Controls.Add(this.RoleNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_UserInse";
            this.Text = "添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RoleNum;
        private System.Windows.Forms.TextBox UserNum;
        private System.Windows.Forms.TextBox UserPwd;
        private System.Windows.Forms.Button Insert;
    }
}