namespace SMarketProj.UI
{
    partial class Form_Cashier
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
            this.components = new System.ComponentModel.Container();
            this.listPrice = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listShop = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListProd = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Append = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listQuan = new System.Windows.Forms.ListBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelMem = new System.Windows.Forms.Panel();
            this.labelWarn = new System.Windows.Forms.Label();
            this.Award = new System.Windows.Forms.Label();
            this.ActualPay = new System.Windows.Forms.Label();
            this.NormalPay = new System.Windows.Forms.Label();
            this.Pay = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.CurrentScore = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.textNum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelNor = new System.Windows.Forms.Panel();
            this.Pay_ = new System.Windows.Forms.Button();
            this.payMent = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.numericQuan = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panelMem.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelNor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // listPrice
            // 
            this.listPrice.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listPrice.FormattingEnabled = true;
            this.listPrice.ItemHeight = 20;
            this.listPrice.Location = new System.Drawing.Point(33, 93);
            this.listPrice.Name = "listPrice";
            this.listPrice.Size = new System.Drawing.Size(87, 384);
            this.listPrice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(139, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "商品";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(48, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "单价";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(78, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "选择客户购买的商品";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(786, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "结算";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(437, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "购物车";
            // 
            // listShop
            // 
            this.listShop.ContextMenuStrip = this.contextMenuStrip1;
            this.listShop.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listShop.FormattingEnabled = true;
            this.listShop.ItemHeight = 20;
            this.listShop.Location = new System.Drawing.Point(414, 93);
            this.listShop.Name = "listShop";
            this.listShop.Size = new System.Drawing.Size(120, 384);
            this.listShop.TabIndex = 8;
            this.listShop.Click += new System.EventHandler(this.listShop_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuRemove});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 28);
            // 
            // ToolStripMenuRemove
            // 
            this.ToolStripMenuRemove.Name = "ToolStripMenuRemove";
            this.ToolStripMenuRemove.Size = new System.Drawing.Size(153, 24);
            this.ToolStripMenuRemove.Text = "移除此商品";
            this.ToolStripMenuRemove.Click += new System.EventHandler(this.ToolStripMenuRemove_Click);
            // 
            // checkedListProd
            // 
            this.checkedListProd.FormattingEnabled = true;
            this.checkedListProd.Location = new System.Drawing.Point(120, 93);
            this.checkedListProd.Name = "checkedListProd";
            this.checkedListProd.Size = new System.Drawing.Size(100, 384);
            this.checkedListProd.TabIndex = 10;
            this.checkedListProd.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListProd_ItemCheck);
            this.checkedListProd.Click += new System.EventHandler(this.checkedListProd_Click);
            this.checkedListProd.SelectedIndexChanged += new System.EventHandler(this.checkedListProd_SelectedIndexChanged);
            this.checkedListProd.SelectedValueChanged += new System.EventHandler(this.checkedListProd_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(269, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "购买数量";
            // 
            // Append
            // 
            this.Append.Location = new System.Drawing.Point(264, 289);
            this.Append.Name = "Append";
            this.Append.Size = new System.Drawing.Size(100, 40);
            this.Append.TabIndex = 13;
            this.Append.Text = "加入购物车";
            this.Append.UseVisualStyleBackColor = true;
            this.Append.Click += new System.EventHandler(this.Append_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(553, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "数量";
            // 
            // listQuan
            // 
            this.listQuan.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listQuan.FormattingEnabled = true;
            this.listQuan.ItemHeight = 20;
            this.listQuan.Location = new System.Drawing.Point(534, 93);
            this.listQuan.Name = "listQuan";
            this.listQuan.Size = new System.Drawing.Size(94, 384);
            this.listQuan.TabIndex = 15;
            this.listQuan.Click += new System.EventHandler(this.listQuan_Click);
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "是",
            "否"});
            this.comboStatus.Location = new System.Drawing.Point(845, 93);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(65, 23);
            this.comboStatus.TabIndex = 16;
            this.comboStatus.SelectedIndexChanged += new System.EventHandler(this.comboStatus_SelectedIndexChanged);
            this.comboStatus.SelectedValueChanged += new System.EventHandler(this.comboStatus_SelectedValueChanged);
            this.comboStatus.TextChanged += new System.EventHandler(this.comboStatus_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(737, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "是否为会员";
            // 
            // panelMem
            // 
            this.panelMem.Controls.Add(this.labelWarn);
            this.panelMem.Controls.Add(this.Award);
            this.panelMem.Controls.Add(this.ActualPay);
            this.panelMem.Controls.Add(this.NormalPay);
            this.panelMem.Controls.Add(this.Pay);
            this.panelMem.Controls.Add(this.label16);
            this.panelMem.Controls.Add(this.label15);
            this.panelMem.Controls.Add(this.label12);
            this.panelMem.Controls.Add(this.label14);
            this.panelMem.Controls.Add(this.Discount);
            this.panelMem.Controls.Add(this.CurrentScore);
            this.panelMem.Controls.Add(this.label10);
            this.panelMem.Location = new System.Drawing.Point(713, 132);
            this.panelMem.Name = "panelMem";
            this.panelMem.Size = new System.Drawing.Size(242, 319);
            this.panelMem.TabIndex = 19;
            this.panelMem.Visible = false;
            // 
            // labelWarn
            // 
            this.labelWarn.AutoSize = true;
            this.labelWarn.Location = new System.Drawing.Point(37, 285);
            this.labelWarn.Name = "labelWarn";
            this.labelWarn.Size = new System.Drawing.Size(167, 15);
            this.labelWarn.TabIndex = 31;
            this.labelWarn.Text = "注: 每消费10元得1积分";
            // 
            // Award
            // 
            this.Award.AutoSize = true;
            this.Award.Location = new System.Drawing.Point(158, 183);
            this.Award.Name = "Award";
            this.Award.Size = new System.Drawing.Size(63, 15);
            this.Award.TabIndex = 30;
            this.Award.Text = "label19";
            // 
            // ActualPay
            // 
            this.ActualPay.AutoSize = true;
            this.ActualPay.Location = new System.Drawing.Point(158, 142);
            this.ActualPay.Name = "ActualPay";
            this.ActualPay.Size = new System.Drawing.Size(63, 15);
            this.ActualPay.TabIndex = 29;
            this.ActualPay.Text = "label18";
            // 
            // NormalPay
            // 
            this.NormalPay.AutoSize = true;
            this.NormalPay.Location = new System.Drawing.Point(158, 97);
            this.NormalPay.Name = "NormalPay";
            this.NormalPay.Size = new System.Drawing.Size(63, 15);
            this.NormalPay.TabIndex = 28;
            this.NormalPay.Text = "label17";
            // 
            // Pay
            // 
            this.Pay.Location = new System.Drawing.Point(63, 227);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(123, 45);
            this.Pay.TabIndex = 27;
            this.Pay.Text = "确认付款";
            this.Pay.UseVisualStyleBackColor = true;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(48, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 15);
            this.label16.TabIndex = 26;
            this.label16.Text = "实付款";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(48, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 15);
            this.label15.TabIndex = 25;
            this.label15.Text = "应付款";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "本次消费可得积分";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "折扣";
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Location = new System.Drawing.Point(158, 53);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(63, 15);
            this.Discount.TabIndex = 23;
            this.Discount.Text = "label13";
            // 
            // CurrentScore
            // 
            this.CurrentScore.AutoSize = true;
            this.CurrentScore.Location = new System.Drawing.Point(158, 15);
            this.CurrentScore.Name = "CurrentScore";
            this.CurrentScore.Size = new System.Drawing.Size(63, 15);
            this.CurrentScore.TabIndex = 21;
            this.CurrentScore.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "当前积分";
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.btn_Confirm);
            this.panelLogin.Controls.Add(this.textPwd);
            this.panelLogin.Controls.Add(this.textNum);
            this.panelLogin.Controls.Add(this.label11);
            this.panelLogin.Controls.Add(this.label9);
            this.panelLogin.Location = new System.Drawing.Point(681, 137);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(307, 119);
            this.panelLogin.TabIndex = 31;
            this.panelLogin.Visible = false;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(52, 79);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(205, 38);
            this.btn_Confirm.TabIndex = 4;
            this.btn_Confirm.Text = "确定";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // textPwd
            // 
            this.textPwd.Location = new System.Drawing.Point(133, 43);
            this.textPwd.Name = "textPwd";
            this.textPwd.Size = new System.Drawing.Size(124, 25);
            this.textPwd.TabIndex = 3;
            this.textPwd.Text = "123456789";
            // 
            // textNum
            // 
            this.textNum.Location = new System.Drawing.Point(133, 9);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(124, 25);
            this.textNum.TabIndex = 2;
            this.textNum.Text = "201801010006   ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "会员密码";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "会员号";
            // 
            // panelNor
            // 
            this.panelNor.Controls.Add(this.Pay_);
            this.panelNor.Controls.Add(this.payMent);
            this.panelNor.Controls.Add(this.label20);
            this.panelNor.Location = new System.Drawing.Point(702, 259);
            this.panelNor.Name = "panelNor";
            this.panelNor.Size = new System.Drawing.Size(263, 95);
            this.panelNor.TabIndex = 31;
            this.panelNor.Visible = false;
            // 
            // Pay_
            // 
            this.Pay_.Location = new System.Drawing.Point(64, 35);
            this.Pay_.Name = "Pay_";
            this.Pay_.Size = new System.Drawing.Size(143, 51);
            this.Pay_.TabIndex = 2;
            this.Pay_.Text = "确认付款";
            this.Pay_.UseVisualStyleBackColor = true;
            this.Pay_.Click += new System.EventHandler(this.Pay__Click);
            // 
            // payMent
            // 
            this.payMent.AutoSize = true;
            this.payMent.Location = new System.Drawing.Point(140, 4);
            this.payMent.Name = "payMent";
            this.payMent.Size = new System.Drawing.Size(63, 15);
            this.payMent.TabIndex = 1;
            this.payMent.Text = "label21";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(57, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "应付款";
            // 
            // numericQuan
            // 
            this.numericQuan.Location = new System.Drawing.Point(264, 221);
            this.numericQuan.Name = "numericQuan";
            this.numericQuan.Size = new System.Drawing.Size(100, 25);
            this.numericQuan.TabIndex = 32;
            this.numericQuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericQuan_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(493, 495);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 15);
            this.label13.TabIndex = 33;
            this.label13.Text = "*右键移除选中商品";
            // 
            // Form_Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 533);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numericQuan);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelNor);
            this.Controls.Add(this.panelMem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.listQuan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Append);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkedListProd);
            this.Controls.Add(this.listShop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_Cashier";
            this.Text = "购物结算";
            this.Load += new System.EventHandler(this.Form_Cashier_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelMem.ResumeLayout(false);
            this.panelMem.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelNor.ResumeLayout(false);
            this.panelNor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listShop;
        private System.Windows.Forms.CheckedListBox checkedListProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Append;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listQuan;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelMem;
        private System.Windows.Forms.Label Award;
        private System.Windows.Forms.Label ActualPay;
        private System.Windows.Forms.Label NormalPay;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Label CurrentScore;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelNor;
        private System.Windows.Forms.Button Pay_;
        private System.Windows.Forms.Label payMent;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.TextBox textPwd;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelWarn;
        private System.Windows.Forms.NumericUpDown numericQuan;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuRemove;
        private System.Windows.Forms.Label label13;
    }
}