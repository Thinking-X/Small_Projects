namespace SMarketProj.UI
{
    partial class Form_Sale
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
            this.View_Sale = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.Button();
            this.DisplayTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboProp = new System.Windows.Forms.ComboBox();
            this.textVal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.View_Sale)).BeginInit();
            this.SuspendLayout();
            // 
            // View_Sale
            // 
            this.View_Sale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_Sale.Location = new System.Drawing.Point(56, 55);
            this.View_Sale.Name = "View_Sale";
            this.View_Sale.RowTemplate.Height = 27;
            this.View_Sale.Size = new System.Drawing.Size(813, 241);
            this.View_Sale.TabIndex = 0;
            this.View_Sale.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.View_Sale_RowPostPaint);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(316, 423);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(237, 45);
            this.Select.TabIndex = 4;
            this.Select.Text = "查询";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // DisplayTable
            // 
            this.DisplayTable.Location = new System.Drawing.Point(55, 296);
            this.DisplayTable.Name = "DisplayTable";
            this.DisplayTable.Size = new System.Drawing.Size(117, 47);
            this.DisplayTable.TabIndex = 5;
            this.DisplayTable.Text = "显示全部";
            this.DisplayTable.UseVisualStyleBackColor = true;
            this.DisplayTable.Click += new System.EventHandler(this.DisplayTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "选择查找方式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "请输入(选填)";
            // 
            // comboProp
            // 
            this.comboProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProp.FormattingEnabled = true;
            this.comboProp.Location = new System.Drawing.Point(422, 339);
            this.comboProp.Name = "comboProp";
            this.comboProp.Size = new System.Drawing.Size(131, 23);
            this.comboProp.TabIndex = 8;
            // 
            // textVal
            // 
            this.textVal.Location = new System.Drawing.Point(422, 381);
            this.textVal.Name = "textVal";
            this.textVal.Size = new System.Drawing.Size(131, 25);
            this.textVal.TabIndex = 9;
            // 
            // Form_Sale
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
            this.Controls.Add(this.View_Sale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_Sale";
            this.Text = "销售明细表";
            this.Load += new System.EventHandler(this.Form_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_Sale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView View_Sale;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Button DisplayTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboProp;
        private System.Windows.Forms.TextBox textVal;
    }
}