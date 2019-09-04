using System.ComponentModel;

using RetroFun.Controls;

using Sulakore.Modules;

namespace RetroFun
{
    [DesignerCategory("Form")]
    [Module("RetroFun", "Miscellaneous stuff for retroservers")]
    public partial class MainFrm : ObservableExtensionForm
    {
        public override bool IsRemoteModule => true;

        public bool IsAlwaysOnTop
        {
            get => TopMost;
            set
            {
                TopMost = value;
                RaiseOnPropertyChanged();
            }
        }

        public MainFrm()
        {
            // Must be set before initializing components.
            Program.Master = this;

            InitializeComponent();
            Bind(AlwaysOnTopChbx, "Checked", nameof(IsAlwaysOnTop));
        }
    }
}