using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SMarketProj.PublicClass
{
    class SelfClosingMessageBox
    {
        [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Auto)]
        public extern static IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int PostMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        public const int WM_CLOSE = 0x10;
        public static void StartKiller(string MessageBoxTitle, int TimeInterval)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = TimeInterval;    //延时时间
            timer.Tag = MessageBoxTitle;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }
        private static void Timer_Tick(object sender, EventArgs e)
        {
            KillMessageBox((string)((System.Windows.Forms.Timer)sender).Tag);
            //停止计时器
            ((System.Windows.Forms.Timer)sender).Stop();
        }
        private static void KillMessageBox(string MessageBoxTitle)
        {
            //根据标题查找MessageBox的弹出窗口
            IntPtr ptr = FindWindow(null, MessageBoxTitle);
            if (ptr != IntPtr.Zero)
            {
                //查找到窗口则关闭
                PostMessage(ptr, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            }
        }
    }
}
