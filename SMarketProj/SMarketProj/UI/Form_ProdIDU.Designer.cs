namespace SMarketProj.UI
{
    partial class Form_ProdIDU
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
            this.label5 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.BuyPrice = new System.Windows.Forms.TextBox();
            this.SalePrice = new System.Windows.Forms.TextBox();
            this.IDUS = new System.Windows.Forms.Button();
            this.ProdNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "进价";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "售价";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(202, 170);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(144, 25);
            this.Quantity.TabIndex = 6;
            // 
            // ProdName
            // 
            this.ProdName.Location = new System.Drawing.Point(202, 113);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(144, 25);
            this.ProdName.TabIndex = 7;
            // 
            // BuyPrice
            // 
            this.BuyPrice.Location = new System.Drawing.Point(202, 224);
            this.BuyPrice.Name = "BuyPrice";
            this.BuyPrice.Size = new System.Drawing.Size(144, 25);
            this.BuyPrice.TabIndex = 8;
            // 
            // SalePrice
            // 
            this.SalePrice.Location = new System.Drawing.Point(202, 279);
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.Size = new System.Drawing.Size(144, 25);
            this.SalePrice.TabIndex = 9;
            // 
            // IDUS
            // 
            this.IDUS.Location = new System.Drawing.Point(105, 355);
            this.IDUS.Name = "IDUS";
            this.IDUS.Size = new System.Drawing.Size(241, 52);
            this.IDUS.TabIndex = 10;
            this.IDUS.UseVisualStyleBackColor = true;
            this.IDUS.Click += new System.EventHandler(this.IDUS_Click);
            // 
            // ProdNum
            // 
            this.ProdNum.AutoSize = true;
            this.ProdNum.Location = new System.Drawing.Point(244, 60);
            this.ProdNum.Name = "ProdNum";
            this.ProdNum.Size = new System.Drawing.Size(39, 15);
            this.ProdNum.TabIndex = 11;
            this.ProdNum.Text = "----";
            // 
            // Form_ProdIDU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.ProdNum);
            this.Controls.Add(this.IDUS);
            this.Controls.Add(this.SalePrice);
            this.Controls.Add(this.BuyPrice);
            this.Controls.Add(this.ProdName);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_ProdIDU";
            this.Text = "ProductIDUS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ProdIDUS_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_ProdIDUS_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.TextBox BuyPrice;
        private System.Windows.Forms.TextBox SalePrice;
        private System.Windows.Forms.Button IDUS;
        private System.Windows.Forms.Label ProdNum;
    }
}