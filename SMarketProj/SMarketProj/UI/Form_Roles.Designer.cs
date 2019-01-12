namespace SMarketProj.UI
{
    partial class Form_Roles
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
            this.View_Role = new System.Windows.Forms.DataGridView();
            this.DisplayTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboProp = new System.Windows.Forms.ComboBox();
            this.textVal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.View_Role)).BeginInit();
            this.SuspendLayout();
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(540, 446);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(222, 43);
            this.Select.TabIndex = 14;
            this.Select.Text = "查找";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(305, 368);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(113, 43);
            this.Insert.TabIndex = 11;
            this.Insert.Text = "增加";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // View_Role
            // 
            this.View_Role.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_Role.Location = new System.Drawing.Point(61, 52);
            this.View_Role.Name = "View_Role";
            this.View_Role.RowTemplate.Height = 27;
            this.View_Role.Size = new System.Drawing.Size(806, 270);
            this.View_Role.TabIndex = 10;
            this.View_Role.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.View_Role_RowPostPaint);
            // 
            // DisplayTable
            // 
            this.DisplayTable.Location = new System.Drawing.Point(119, 368);
            this.DisplayTable.Name = "DisplayTable";
            this.DisplayTable.Size = new System.Drawing.Size(107, 43);
            this.DisplayTable.TabIndex = 15;
            this.DisplayTable.Text = "显示全部";
            this.DisplayTable.UseVisualStyleBackColor = true;
            this.DisplayTable.Click += new System.EventHandler(this.DisplayTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "选择查找方式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "请输入(选填)";
            // 
            // comboProp
            // 
            this.comboProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProp.FormattingEnabled = true;
            this.comboProp.Location = new System.Drawing.Point(641, 365);
            this.comboProp.Name = "comboProp";
            this.comboProp.Size = new System.Drawing.Size(121, 23);
            this.comboProp.TabIndex = 18;
            // 
            // textVal
            // 
            this.textVal.Location = new System.Drawing.Point(641, 406);
            this.textVal.Name = "textVal";
            this.textVal.Size = new System.Drawing.Size(121, 25);
            this.textVal.TabIndex = 19;
            // 
            // Form_Roles
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
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.View_Role);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_Roles";
            this.Text = "角色表";
            this.Load += new System.EventHandler(this.Form_Roles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_Role)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.DataGridView View_Role;
        private System.Windows.Forms.Button DisplayTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboProp;
        private System.Windows.Forms.TextBox textVal;
    }
}