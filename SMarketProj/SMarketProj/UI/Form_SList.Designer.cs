namespace SMarketProj.UI
{
    partial class Form_SList
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
            this.View_SList = new System.Windows.Forms.DataGridView();
            this.DisplayTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboProp = new System.Windows.Forms.ComboBox();
            this.textVal = new System.Windows.Forms.TextBox();
            this.Select = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.View_SList)).BeginInit();
            this.SuspendLayout();
            // 
            // View_SList
            // 
            this.View_SList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_SList.Location = new System.Drawing.Point(53, 59);
            this.View_SList.Name = "View_SList";
            this.View_SList.RowTemplate.Height = 27;
            this.View_SList.Size = new System.Drawing.Size(814, 274);
            this.View_SList.TabIndex = 0;
            this.View_SList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.View_SList_RowPostPaint);
            // 
            // DisplayTable
            // 
            this.DisplayTable.Location = new System.Drawing.Point(54, 368);
            this.DisplayTable.Name = "DisplayTable";
            this.DisplayTable.Size = new System.Drawing.Size(103, 48);
            this.DisplayTable.TabIndex = 1;
            this.DisplayTable.Text = "显示全部";
            this.DisplayTable.UseVisualStyleBackColor = true;
            this.DisplayTable.Click += new System.EventHandler(this.DisplayTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "选择查找方式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "请输入(选填)";
            // 
            // comboProp
            // 
            this.comboProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProp.FormattingEnabled = true;
            this.comboProp.Location = new System.Drawing.Point(454, 373);
            this.comboProp.Name = "comboProp";
            this.comboProp.Size = new System.Drawing.Size(121, 23);
            this.comboProp.TabIndex = 4;
            // 
            // textVal
            // 
            this.textVal.Location = new System.Drawing.Point(454, 414);
            this.textVal.Name = "textVal";
            this.textVal.Size = new System.Drawing.Size(121, 25);
            this.textVal.TabIndex = 5;
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(354, 456);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(221, 39);
            this.Select.TabIndex = 6;
            this.Select.Text = "查找";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Form_SList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 529);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.textVal);
            this.Controls.Add(this.comboProp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayTable);
            this.Controls.Add(this.View_SList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_SList";
            this.Text = "购物清单表";
            this.Load += new System.EventHandler(this.Form_SList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_SList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView View_SList;
        private System.Windows.Forms.Button DisplayTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboProp;
        private System.Windows.Forms.TextBox textVal;
        private System.Windows.Forms.Button Select;
    }
}