using System;
using System.ComponentModel;

using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Modules;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class MiscPage : ObservablePage, ISubscriber
    {
        public MiscPage()
        {
            InitializeComponent();

            Bind(FreezeMovementCheck, "Checked", nameof(FreezeUserMovement));
            Bind(NoFriendRemove, "Checked", nameof(AntiFriendRemove));
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

        private bool _AntiFriendRemove;
        public bool AntiFriendRemove
        {
            get => _AntiFriendRemove;
            set
            {
                _AntiFriendRemove = value;
                RaiseOnPropertyChanged();
            }
        }


        public bool IsReceiving => true;

        private void AcquireMODPermissionsBtn_Click(object sender, EventArgs e)
        {
            Connection.SendToClientAsync(In.UserPermissions, int.MaxValue, int.MaxValue, true);
        }

        public void OnOutDiceTrigger(DataInterceptedEventArgs e) { }

        public void OnOutUserWalk(DataInterceptedEventArgs e)
        {
            if (FreezeUserMovement)
                e.IsBlocked = true;
        }
        [OutDataCapture("RemoveFriend")]
        public void BlockFriendRemoval(DataInterceptedEventArgs e)
        {
            if (AntiFriendRemove)
                e.IsBlocked = true;
        }
    }
}

