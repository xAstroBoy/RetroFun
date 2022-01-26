using RetroFun.Controls;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using Geode.Extension;

namespace RetroFun
{
    public static class Program
    {
        public static ObservableExtensionForm Master { get; set; }
        public static GeodeExtension Extension { get; set; } = new GeodeExtension("RetroFun", "All-in-one scripting tool!", "xAstroBoy"); // Add G-earth support.

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