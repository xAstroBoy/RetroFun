using RetroFun.Controls;
using System;
using System.Windows.Forms;

namespace RetroFun
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