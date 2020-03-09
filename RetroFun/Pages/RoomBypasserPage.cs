using RetroFun.Controls;
using Sulakore.Protocol;
using System;
using System.ComponentModel;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class RoomBypasserPage : ObservablePage
    {
        public RoomBypasserPage()
        {
            InitializeComponent();

            if (Program.Master != null)
            {
                //Triggers.InAttach();
            }
        }

        private bool _ReloadCheckbox;

        public bool ReloadCheckbox
        {
            get => _ReloadCheckbox;
            set
            {
                _ReloadCheckbox = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _BlockBypassers = true;

        public bool BlockBypassers
        {
            get => _BlockBypassers;
            set
            {
                _BlockBypassers = value;
                RaiseOnPropertyChanged();
            }
        }

        private void EnterRoomBtn_Click(object sender, EventArgs e)
        {
            HMessage hmessage = new HMessage("{l}{u:" + Out.RequestRoomHeightmap.ToString() + "}");
            if (Connection.Remote.IsConnected)
            {
               SendToServerAsync(hmessage.ToBytes());
            }
        }
    }
}