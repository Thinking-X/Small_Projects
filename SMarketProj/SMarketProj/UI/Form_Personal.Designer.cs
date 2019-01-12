namespace SMarketProj.UI
{
    partial class Form_Personal
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.View_Shop = new System.Windows.Forms.DataGridView();
            this.MemNum = new System.Windows.Forms.Label();
            this.Grade = new System.Windows.Forms.Label();
            this.IdNum = new System.Windows.Forms.Label();
            this.CancelUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpdatePortr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.View_Shop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "会员密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "会员积分";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "会员名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "性别";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "身份证号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "地址";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(53, 394);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(172, 43);
            this.Update.TabIndex = 16;
            this.Update.Text = "更改信息";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(563, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "购物历史";
            // 
            // View_Shop
            // 
            this.View_Shop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_Shop.Location = new System.Drawing.Point(323, 79);
            this.View_Shop.Name = "View_Shop";
            this.View_Shop.RowTemplate.Height = 27;
            this.View_Shop.Size = new System.Drawing.Size(556, 303);
            this.View_Shop.TabIndex = 18;
            this.View_Shop.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.View_Shop_RowPostPaint);
            // 
            // MemNum
            // 
            this.MemNum.AutoSize = true;
            this.MemNum.Location = new System.Drawing.Point(149, 36);
            this.MemNum.Name = "MemNum";
            this.MemNum.Size = new System.Drawing.Size(103, 15);
            this.MemNum.TabIndex = 28;
            this.MemNum.Text = "201801010001";
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Location = new System.Drawing.Point(174, 130);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(39, 15);
            this.Grade.TabIndex = 29;
            this.Grade.Text = "1000";
            // 
            // IdNum
            // 
            this.IdNum.Location = new System.Drawing.Point(134, 280);
            this.IdNum.Name = "IdNum";
            this.IdNum.Size = new System.Drawing.Size(152, 15);
            this.IdNum.TabIndex = 0;
            this.IdNum.Text = "123456789123456789";
            // 
            // CancelUpdate
            // 
            this.CancelUpdate.Location = new System.Drawing.Point(53, 460);
            this.CancelUpdate.Name = "CancelUpdate";
            this.CancelUpdate.Size = new System.Drawing.Size(172, 43);
            this.CancelUpdate.TabIndex = 30;
            this.CancelUpdate.Text = "取消更改";
            this.CancelUpdate.UseVisualStyleBackColor = true;
            this.CancelUpdate.Click += new System.EventHandler(this.CancelUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(323, 417);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // UpdatePortr
            // 
            this.UpdatePortr.Location = new System.Drawing.Point(496, 444);
            this.UpdatePortr.Name = "UpdatePortr";
            this.UpdatePortr.Size = new System.Drawing.Size(98, 38);
            this.UpdatePortr.TabIndex = 32;
            this.UpdatePortr.Text = "更改头像";
            this.UpdatePortr.UseVisualStyleBackColor = true;
            this.UpdatePortr.Click += new System.EventHandler(this.UpdatePortr_Click);
            // 
            // Form_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 529);
            this.Controls.Add(this.UpdatePortr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CancelUpdate);
            this.Controls.Add(this.IdNum);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.MemNum);
            this.Controls.Add(this.View_Shop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_Personal";
            this.Text = "会员窗口";
            this.Load += new System.EventHandler(this.Form_Personal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_Shop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView View_Shop;
        private System.Windows.Forms.Label MemNum;
        private System.Windows.Forms.Label Grade;
        private System.Windows.Forms.Label IdNum;
        private System.Windows.Forms.Button CancelUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UpdatePortr;
    }
}