namespace SMarketProj.UI
{
    partial class Form_PurchInse
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
            this.label4 = new System.Windows.Forms.Label();
            this.PurcTabNum = new System.Windows.Forms.Label();
            this.PurcDate = new System.Windows.Forms.DateTimePicker();
            this.PordNum = new System.Windows.Forms.TextBox();
            this.PurcQuan = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PurcTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "进货单号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "进货日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "商品编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "进货数量";
            // 
            // PurcTabNum
            // 
            this.PurcTabNum.AutoSize = true;
            this.PurcTabNum.Location = new System.Drawing.Point(272, 74);
            this.PurcTabNum.Name = "PurcTabNum";
            this.PurcTabNum.Size = new System.Drawing.Size(39, 15);
            this.PurcTabNum.TabIndex = 4;
            this.PurcTabNum.Tag = "";
            this.PurcTabNum.Text = "----";
            // 
            // PurcDate
            // 
            this.PurcDate.Location = new System.Drawing.Point(226, 117);
            this.PurcDate.Name = "PurcDate";
            this.PurcDate.Size = new System.Drawing.Size(160, 25);
            this.PurcDate.TabIndex = 5;
            // 
            // PordNum
            // 
            this.PordNum.Location = new System.Drawing.Point(226, 178);
            this.PordNum.Name = "PordNum";
            this.PordNum.Size = new System.Drawing.Size(160, 25);
            this.PordNum.TabIndex = 6;
            // 
            // PurcQuan
            // 
            this.PurcQuan.Location = new System.Drawing.Point(226, 236);
            this.PurcQuan.Name = "PurcQuan";
            this.PurcQuan.Size = new System.Drawing.Size(160, 25);
            this.PurcQuan.TabIndex = 7;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(90, 345);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(296, 52);
            this.Insert.TabIndex = 8;
            this.Insert.Text = "确认添加";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "进货总金额";
            // 
            // PurcTotal
            // 
            this.PurcTotal.Location = new System.Drawing.Point(226, 290);
            this.PurcTotal.Name = "PurcTotal";
            this.PurcTotal.Size = new System.Drawing.Size(160, 25);
            this.PurcTotal.TabIndex = 10;
            // 
            // Form_PurchInse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 457);
            this.Controls.Add(this.PurcTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.PurcQuan);
            this.Controls.Add(this.PordNum);
            this.Controls.Add(this.PurcDate);
            this.Controls.Add(this.PurcTabNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_PurchInse";
            this.Text = "添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PurcTabNum;
        private System.Windows.Forms.DateTimePicker PurcDate;
        private System.Windows.Forms.TextBox PordNum;
        private System.Windows.Forms.TextBox PurcQuan;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PurcTotal;
    }
}