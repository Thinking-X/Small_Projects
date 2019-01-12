using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMarketProj.UI
{
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        public int Result = 0;
        private void Product_Click(object sender, EventArgs e)
        {
            Result = 1;
            this.Dispose();
            return;
        }
        private void Member_Click(object sender, EventArgs e)
        {
            Result = 2;
            this.Dispose();
            return;
        }
        private void SaleDetail_Click(object sender, EventArgs e)
        {
            Result = 3;
            this.Dispose();
            return;
        }
        private void SaleList_Click(object sender, EventArgs e)
        {
            Result = 4;
            this.Dispose();
            return;
        }
        private void PurchaseDetail_Click(object sender, EventArgs e)
        {
            Result = 5;
            this.Dispose();
            return;
        }
        private void Roles_Click(object sender, EventArgs e)
        {
            Result = 6;
            this.Dispose();
            return;
        }
        private void Users_Click(object sender, EventArgs e)
        {
            Result = 7;
            this.Dispose();
            return;
        }

        private void Portrait_Click(object sender, EventArgs e)
        {
            Result = 8;
            this.Dispose();
            return;
        }
    }
}
