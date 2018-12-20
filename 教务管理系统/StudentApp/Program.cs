using StudentApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
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
            Form_Menu menu = new Form_Menu();
            menu.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(menu);
            int result = menu.Result;
            while(result != 0)
            {
                switch (result)
                {
                    case 1:
                        Form_Stu Stu = new Form_Stu();
                        Stu.StartPosition = FormStartPosition.CenterScreen;
                        Application.Run(Stu);
                        break;
                    case 2:
                        Form_Cour Cour = new Form_Cour();
                        Cour.StartPosition = FormStartPosition.CenterScreen;
                        Application.Run(Cour);
                        break;
                    case 3:
                        Form_SC SC = new Form_SC();
                        SC.StartPosition = FormStartPosition.CenterScreen;
                        Application.Run(SC);
                        break;
                    case 4:
                        Form_Custom Custom = new Form_Custom();
                        Custom.StartPosition = FormStartPosition.CenterScreen;
                        Application.Run(Custom);
                        break;
                }
                Form_Menu menu_ = new Form_Menu();
                menu_.StartPosition = FormStartPosition.CenterScreen;
                Application.Run(menu_);
                result = menu_.Result;
            }
            return;
        }
    }
}
