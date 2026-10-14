using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace san_ji_xiang_mu
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.IO.Directory.SetCurrentDirectory(Application.StartupPath);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
