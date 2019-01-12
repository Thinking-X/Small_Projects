namespace SMarketProj.UI
{
    partial class Form_Portrait
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
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.DisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Select = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextNum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mLabelNum = new MaterialSkin.Controls.MaterialLabel();
            this.View_Num = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_Num)).BeginInit();
            this.SuspendLayout();
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DisplayToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(184, 28);
            // 
            // DisplayToolStripMenuItem
            // 
            this.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem";
            this.DisplayToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.DisplayToolStripMenuItem.Text = "显示该会员头像";
            this.DisplayToolStripMenuItem.Click += new System.EventHandler(this.DisplayToolStripMenuItem_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.AutoSize = true;
            this.btn_Select.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Select.Depth = 0;
            this.btn_Select.Location = new System.Drawing.Point(157, 405);
            this.btn_Select.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Select.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Primary = false;
            this.btn_Select.Size = new System.Drawing.Size(126, 36);
            this.btn_Select.TabIndex = 4;
            this.btn_Select.Text = "查找该会员号";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(157, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // TextNum
            // 
            this.TextNum.Depth = 0;
            this.TextNum.Hint = "";
            this.TextNum.Location = new System.Drawing.Point(216, 347);
            this.TextNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextNum.Name = "TextNum";
            this.TextNum.PasswordChar = '\0';
            this.TextNum.SelectedText = "";
            this.TextNum.SelectionLength = 0;
            this.TextNum.SelectionStart = 0;
            this.TextNum.Size = new System.Drawing.Size(96, 28);
            this.TextNum.TabIndex = 14;
            this.TextNum.UseSystemPasswordChar = false;
            // 
            // mLabelNum
            // 
            this.mLabelNum.AutoSize = true;
            this.mLabelNum.Depth = 0;
            this.mLabelNum.Font = new System.Drawing.Font("Roboto", 11F);
            this.mLabelNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mLabelNum.Location = new System.Drawing.Point(131, 347);
            this.mLabelNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelNum.Name = "mLabelNum";
            this.mLabelNum.Size = new System.Drawing.Size(70, 24);
            this.mLabelNum.TabIndex = 15;
            this.mLabelNum.Text = "会员号";
            // 
            // View_Num
            // 
            this.View_Num.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_Num.ContextMenuStrip = this.materialContextMenuStrip1;
            this.View_Num.Location = new System.Drawing.Point(506, 129);
            this.View_Num.Name = "View_Num";
            this.View_Num.RowTemplate.Height = 27;
            this.View_Num.Size = new System.Drawing.Size(194, 351);
            this.View_Num.TabIndex = 16;
            this.View_Num.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.View_Num_CellMouseDown);
            this.View_Num.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.View_Num_RowPostPaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(535, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "存在头像的会员";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "*右键显示会员";
            // 
            // Form_Portrait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 533);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.View_Num);
            this.Controls.Add(this.mLabelNum);
            this.Controls.Add(this.TextNum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Select);
            this.Name = "Form_Portrait";
            this.Text = "用户头像";
            this.Load += new System.EventHandler(this.Form_Portrait_Load);
            this.materialContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_Num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialFlatButton btn_Select;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextNum;
        private MaterialSkin.Controls.MaterialLabel mLabelNum;
        private System.Windows.Forms.DataGridView View_Num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem DisplayToolStripMenuItem;
    }
}