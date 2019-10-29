using System;
using System.ComponentModel;
using System.Windows.Forms;
using RetroFun.Controls;
using System.Threading;
using Sulakore.Components;
using Sulakore.Communication;
using RetroFun.Subscribers;
using Sulakore.Modules;
using System.Xml;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class LookGeneratorPage : ObservablePage
    {


        private int _SpeedTimer1;
        public int SpeedTimer1
        {
            get => _SpeedTimer1;
            set
            {
                _SpeedTimer1 = value;
                RaiseOnPropertyChanged();
            }
        }

        private string _UrlBoxText = "http://www.bobbaitalia.it/gamedata/figuredata.xml";
        public string UrlBoxText
        {
            get => _UrlBoxText;
            set
            {
                _UrlBoxText = value;
                RaiseOnPropertyChanged();
            }
        }



        public LookGeneratorPage()
        {
            InitializeComponent();
        }

        private void XmlParserBtn_Click(object sender, EventArgs e)
        {
            if(UrlBoxText != "")
            {
                ReadAllData(UrlBoxText);
            }
        }
        private void ReadAllData(string url)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(url);
            foreach(XmlNode node in xmlDoc.DocumentElement)
            {

            }


        }
    }
}
