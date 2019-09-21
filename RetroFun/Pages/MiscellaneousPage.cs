using System;
using System.ComponentModel;

using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Communication;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class MiscellaneousPage : ObservablePage, ISubscriber
    {
        public MiscellaneousPage()
        {
            InitializeComponent();

            Bind(FreezeMovementCheck, "Checked", nameof(FreezeUserMovement));
        }

        private bool _FreezeUserMovement;
        public bool FreezeUserMovement
        {
            get => _FreezeUserMovement;
            set
            {
                _FreezeUserMovement = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool IsReceiving => true;

        private void AcquireMODPermissionsBtn_Click(object sender, EventArgs e)
        {
            Connection.SendToClientAsync(In.UserPermissions, 999, 999, true);
        }

        public void OnOutDiceTrigger(DataInterceptedEventArgs e){ }

        public void OnOutUserWalk(DataInterceptedEventArgs e)
        {
            if (FreezeUserMovement)
                e.IsBlocked = true;
        }
    }
}