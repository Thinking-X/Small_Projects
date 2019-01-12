using Login_Form_Design_Example;
using SMarketProj.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMarketProj
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Form_Login Login = new Form_Login();
            //Login.StartPosition = FormStartPosition.CenterScreen;
            //Application.Run(Login);
            //string Status = Login.result;
            //string userNum = Login.userNum;
            //Login.Dispose();
            Login log = new Login();
            log.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(log);
            string Status = log.result;
            string userNum = log.userNum;
            log.Dispose();
            switch (Status)
            {
                case "000":
                    break;
                case "1":
                    Option1();
                    break;
                case "10":
                    Option10();
                    break;
                case "100":
                    Option100(userNum);
                    break;
            }
            return;
        }
        public static void Option1()
        {
            int Result = 0;
            Form_Admin Admin = new Form_Admin();
            Admin.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(Admin);
            Result = Admin.Result;
            while(Result != 0)
            {
                switch (Result)
                {
                    case 1:
                        OptionProd();
                        break;
                    case 2:
                        OptionMember();
                        break;
                    case 3:
                        OptionSale();
                        break;
                    case 4:
                        OptionSList();
                        break;
                    case 5:
                        OptionPurchase();
                        break;
                    case 6:
                        OptionRole();
                        break;
                    case 7:
                        OptionUser();
                        break;
                    case 8:
                        OptionPortr();
                        break;
                }
                Form_Admin Admin_ = new Form_Admin();
                Admin_.StartPosition = FormStartPosition.CenterScreen;
                Application.Run(Admin_);
                Result = Admin_.Result;
            }
            return;
        }
        public static void Option10()
        {
            Form_Cashier Cashier = new Form_Cashier();
            Cashier.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(Cashier);
            bool Result = Cashier.result;
            while (Result)
            {
                Form_Cashier cash_ = new Form_Cashier();
                cash_.StartPosition = FormStartPosition.CenterScreen;
                Application.Run(cash_);
                Result = cash_.result;
            }
            return;
        }
        public static void Option100(string userNum)
        {
            Form_Personal Personal = new Form_Personal(userNum);
            Personal.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(Personal);
        }
        public static void OptionProd()
        {
            Form_Product Form_Prod = new Form_Product();
            Form_Prod.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(Form_Prod);
            return;
        }
        public static void OptionMember()
        {
            Form_Member Form_Memb = new Form_Member();
            Form_Memb.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(Form_Memb);
            return;
        }
        public static void OptionSale()
        {
            Form_Sale form_Sale = new Form_Sale();
            form_Sale.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(form_Sale);
            return;
        }
        public static void OptionSList()
        {
            Form_SList form_SList = new Form_SList();
            form_SList.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(form_SList);
            return;
        }
        public static void OptionPurchase()
        {
            Form_Purchase Form_Purc = new Form_Purchase();
            Form_Purc.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(Form_Purc);
            return;
        }
        public static void OptionRole()
        {
            Form_Roles form_Role = new Form_Roles();
            form_Role.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(form_Role);
            return;
        }
        public static void OptionUser()
        {
            Form_Users form_User = new Form_Users();
            form_User.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(form_User);
            return;
        }
        public static void OptionPortr()
        {
            Form_Portrait form_Portr = new Form_Portrait();
            form_Portr.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(form_Portr);
            return;
        }
    }
}
