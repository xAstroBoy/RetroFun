using RetroFun.Controls;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace RetroFun
{
    public static class Program
    {
        public static ObservableExtensionForm Master { get; set; }

        [STAThread]


        public static void Main()
        {

            if (Debugger.IsAttached)
            {
                CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrm());
        }
    }
}