using System;
using System.ComponentModel;

using BobbaFun.Controls;
using Sulakore.Communication;

namespace BobbaFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class MiscellaneousPage : ObservablePage
    {
        public MiscellaneousPage()
        {
            InitializeComponent();

            Bind(FreezeMovementCheck, "Checked", nameof(FreezeUserMovement));

            if (Program.Master != null)
            {
                Triggers.OutAttach(Out.RoomUserWalk, FreezeUser);

            }
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


        private void FreezeUser(DataInterceptedEventArgs obj)
        {
            obj.IsBlocked = FreezeUserMovement;
        }

        private void AcquireMODPermissionsBtn_Click(object sender, EventArgs e)
        {
            Connection.SendToClientAsync(In.UserPermissions, 999, 999, true);
        }


    }
}