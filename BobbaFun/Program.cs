using System;
using System.Windows.Forms;
using BobbaFun.Controls;

namespace BobbaFun
{
    public static class Program
    {
        public static ObservableExtensionForm Master { get; set; }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrm());
        }
    }
}