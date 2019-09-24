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
    public partial class MiscellaneousPage : ObservablePage, ISubscriber
    {
        public MiscellaneousPage()
        {
            InitializeComponent();

            Bind(FreezeMovementCheck, "Checked", nameof(FreezeUserMovement));

                //Triggers.OutAttach(Out.RemoveFriend, BlockFriendRemoval);
            //Triggers.InAttach(In.CatalogPage, );
            
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


        public void OnOutDiceTrigger(DataInterceptedEventArgs e){ }
        public void InPurchaseOk(DataInterceptedEventArgs e) { }


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

        private void AcquireMODPermissionsBtn_Click_1(object sender, EventArgs e)
        {
            Connection.SendToClientAsync(In.UserPermissions, int.MaxValue, int.MaxValue, true);
        }
    }
}