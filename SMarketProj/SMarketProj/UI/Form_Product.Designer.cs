namespace SMarketProj.UI
{
    partial class Form_Product
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
            this.View_Prod = new System.Windows.Forms.DataGridView();
            this.Insert = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.Button();
            this.comboProp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textVal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DisplayTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.View_Prod)).BeginInit();
            this.SuspendLayout();
            // 
            // View_Prod
            // 
            this.View_Prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_Prod.Location = new System.Drawing.Point(54, 41);
            this.View_Prod.Name = "View_Prod";
            this.View_Prod.RowTemplate.Height = 27;
            this.View_Prod.Size = new System.Drawing.Size(818, 270);
            this.View_Prod.TabIndex = 0;
            this.View_Prod.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.View_Prod_RowPostPaint);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(284, 350);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(132, 43);
            this.Insert.TabIndex = 1;
            this.Insert.Text = "添加";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(105, 436);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(132, 43);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "删除";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(284, 436);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(132, 43);
            this.Update.TabIndex = 3;
            this.Update.Text = "更改";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(570, 436);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(221, 43);
            this.Select.TabIndex = 4;
            this.Select.Text = "查找";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // comboProp
            // 
            this.comboProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProp.FormattingEnabled = true;
            this.comboProp.Location = new System.Drawing.Point(670, 347);
            this.comboProp.Name = "comboProp";
            this.comboProp.Size = new System.Drawing.Size(121, 23);
            this.comboProp.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "选择查找方式";
            // 
            // textVal
            // 
            this.textVal.Location = new System.Drawing.Point(670, 392);
            this.textVal.Name = "textVal";
            this.textVal.Size = new System.Drawing.Size(121, 25);
            this.textVal.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "请输入(选填)";
            // 
            // DisplayTable
            // 
            this.DisplayTable.Location = new System.Drawing.Point(105, 350);
            this.DisplayTable.Name = "DisplayTable";
            this.DisplayTable.Size = new System.Drawing.Size(132, 43);
            this.DisplayTable.TabIndex = 9;
            this.DisplayTable.Text = "显示全部";
            this.DisplayTable.UseVisualStyleBackColor = true;
            this.DisplayTable.Click += new System.EventHandler(this.DisplayTable_Click);
            // 
            // Form_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 529);
            this.Controls.Add(this.DisplayTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboProp);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.View_Prod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_Product";
            this.Text = "商品表";
            this.Load += new System.EventHandler(this.Form_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_Prod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView View_Prod;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.ComboBox comboProp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DisplayTable;
    }
}