﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
            this.MaximizeBox = false;//禁用最大化按钮
            this.MinimizeBox = false;//禁用最小化按钮
        }       
        public int Result = 0;
        private void Student_Click(object sender, EventArgs e)
        {
            Result = 1;
            this.Dispose();
            return;
        }
        private void Course_Click(object sender, EventArgs e)
        {
            Result = 2;
            this.Dispose();
            return;
        }
        private void SC_Click(object sender, EventArgs e)
        {
            Result = 3;
            this.Dispose();
            return;
        }
        private void Custom_Click(object sender, EventArgs e)
        {
            Result = 4;
            this.Dispose();
            return;
        }
        private void Portrait_Click(object sender, EventArgs e)
        {
            Result = 5;
            this.Dispose();
            return;
        }
        private void About_Click(object sender, EventArgs e)
        {
            Result = 6;
            this.Dispose();
            return;
        }
    }
}
