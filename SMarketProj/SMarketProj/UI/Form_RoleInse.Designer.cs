namespace SMarketProj.UI
{
    partial class Form_RoleInse
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
            this.RoleName = new System.Windows.Forms.TextBox();
            this.RoleNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RoleName
            // 
            this.RoleName.Location = new System.Drawing.Point(232, 217);
            this.RoleName.Name = "RoleName";
            this.RoleName.Size = new System.Drawing.Size(112, 25);
            this.RoleName.TabIndex = 0;
            // 
            // RoleNum
            // 
            this.RoleNum.Location = new System.Drawing.Point(232, 123);
            this.RoleNum.Name = "RoleNum";
            this.RoleNum.Size = new System.Drawing.Size(112, 25);
            this.RoleNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "角色号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "角色名";
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(136, 294);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(208, 43);
            this.Insert.TabIndex = 4;
            this.Insert.Text = "确认添加";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Form_RoleInse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 457);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoleNum);
            this.Controls.Add(this.RoleName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_RoleInse";
            this.Text = "添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RoleName;
        private System.Windows.Forms.TextBox RoleNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Insert;
    }
}