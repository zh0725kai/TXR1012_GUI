using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace TXR1012_GUI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region 方法二:使用进程名
            //Process[] processcollection = Process.GetProcessesByName(Application.CompanyName);
            Process[] processcollection = Process.GetProcessesByName("TXR1012_GUI");
            if (processcollection.Length > 1)
            {
                MessageBox.Show("应用程序已经在运行中。。");
                Thread.Sleep(1000);
                System.Environment.Exit(1);
            }
            
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmMain());
                //FrmCOMSet frmComSet = new FrmCOMSet();
                //frmComSet.ShowDialog();
            }
            #endregion
        }
    }
}
