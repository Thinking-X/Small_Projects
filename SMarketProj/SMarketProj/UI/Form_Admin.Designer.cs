namespace SMarketProj.UI
{
    partial class Form_Admin
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
            this.Product = new System.Windows.Forms.Button();
            this.Member = new System.Windows.Forms.Button();
            this.SaleDetail = new System.Windows.Forms.Button();
            this.PurchaseDetail = new System.Windows.Forms.Button();
            this.Roles = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.Button();
            this.SaleList = new System.Windows.Forms.Button();
            this.Portrait = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Product
            // 
            this.Product.Location = new System.Drawing.Point(79, 139);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(144, 83);
            this.Product.TabIndex = 0;
            this.Product.Text = "商品";
            this.Product.UseVisualStyleBackColor = true;
            this.Product.Click += new System.EventHandler(this.Product_Click);
            // 
            // Member
            // 
            this.Member.Location = new System.Drawing.Point(79, 298);
            this.Member.Name = "Member";
            this.Member.Size = new System.Drawing.Size(144, 83);
            this.Member.TabIndex = 1;
            this.Member.Text = "会员";
            this.Member.UseVisualStyleBackColor = true;
            this.Member.Click += new System.EventHandler(this.Member_Click);
            // 
            // SaleDetail
            // 
            this.SaleDetail.Location = new System.Drawing.Point(283, 139);
            this.SaleDetail.Name = "SaleDetail";
            this.SaleDetail.Size = new System.Drawing.Size(144, 83);
            this.SaleDetail.TabIndex = 2;
            this.SaleDetail.Text = "销售明细";
            this.SaleDetail.UseVisualStyleBackColor = true;
            this.SaleDetail.Click += new System.EventHandler(this.SaleDetail_Click);
            // 
            // PurchaseDetail
            // 
            this.PurchaseDetail.Location = new System.Drawing.Point(492, 139);
            this.PurchaseDetail.Name = "PurchaseDetail";
            this.PurchaseDetail.Size = new System.Drawing.Size(144, 83);
            this.PurchaseDetail.TabIndex = 3;
            this.PurchaseDetail.Text = "进货明细";
            this.PurchaseDetail.UseVisualStyleBackColor = true;
            this.PurchaseDetail.Click += new System.EventHandler(this.PurchaseDetail_Click);
            // 
            // Roles
            // 
            this.Roles.Location = new System.Drawing.Point(492, 298);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(146, 83);
            this.Roles.TabIndex = 4;
            this.Roles.Text = "角色";
            this.Roles.UseVisualStyleBackColor = true;
            this.Roles.Click += new System.EventHandler(this.Roles_Click);
            // 
            // Users
            // 
            this.Users.Location = new System.Drawing.Point(695, 139);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(144, 83);
            this.Users.TabIndex = 7;
            this.Users.Text = "用户";
            this.Users.UseVisualStyleBackColor = true;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // SaleList
            // 
            this.SaleList.Location = new System.Drawing.Point(283, 298);
            this.SaleList.Name = "SaleList";
            this.SaleList.Size = new System.Drawing.Size(147, 83);
            this.SaleList.TabIndex = 8;
            this.SaleList.Text = "销售清单";
            this.SaleList.UseVisualStyleBackColor = true;
            this.SaleList.Click += new System.EventHandler(this.SaleList_Click);
            // 
            // Portrait
            // 
            this.Portrait.Location = new System.Drawing.Point(695, 298);
            this.Portrait.Name = "Portrait";
            this.Portrait.Size = new System.Drawing.Size(144, 83);
            this.Portrait.TabIndex = 9;
            this.Portrait.Text = "用户头像";
            this.Portrait.UseVisualStyleBackColor = true;
            this.Portrait.Click += new System.EventHandler(this.Portrait_Click);
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 529);
            this.Controls.Add(this.Portrait);
            this.Controls.Add(this.SaleList);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.Roles);
            this.Controls.Add(this.PurchaseDetail);
            this.Controls.Add(this.SaleDetail);
            this.Controls.Add(this.Member);
            this.Controls.Add(this.Product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_Admin";
            this.Text = "所有信息";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Product;
        private System.Windows.Forms.Button Member;
        private System.Windows.Forms.Button SaleDetail;
        private System.Windows.Forms.Button PurchaseDetail;
        private System.Windows.Forms.Button Roles;
        private System.Windows.Forms.Button Users;
        private System.Windows.Forms.Button SaleList;
        private System.Windows.Forms.Button Portrait;
    }
}