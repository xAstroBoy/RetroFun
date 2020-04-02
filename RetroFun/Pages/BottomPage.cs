using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class BottomPage : ObservablePage, ISubscriber
    {
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

        private string _UsernameFilter;

        public string UsernameFilter
        {
            get => _UsernameFilter;
            set
            {
                _UsernameFilter = value;
                RaiseOnPropertyChanged();
            }
        }

        public BottomPage()
        {
            InitializeComponent();

            Bind(FreezeMovementCheck, "Checked", nameof(FreezeUserMovement));
            Bind(UsernameTextBox, "Text", nameof(UsernameFilter));

        }

        public bool IsReceiving => true;

        public void OnCatalogBuyItem(DataInterceptedEventArgs e)
        {
        }
        public void InPurchaseOk(DataInterceptedEventArgs e)
        {
        }

        public void InRoomUserLeft(DataInterceptedEventArgs e)
        {
        }


        public void OnRoomUserTalk(DataInterceptedEventArgs e)
        {

        }

        public void OnRoomUserShout(DataInterceptedEventArgs e)
        {

        }

        public void OnRoomUserWhisper(DataInterceptedEventArgs e)
        {

        }

        public void InRoomUserTalk(DataInterceptedEventArgs e)
        {

        }

        public void InRoomUserShout(DataInterceptedEventArgs e)
        {

        }

        public void InRoomUserWhisper(DataInterceptedEventArgs e)
        {

        }
        public void OnRequestRoomLoad(DataInterceptedEventArgs e)
        {
        }
        public void InUserEnterRoom(DataInterceptedEventArgs e)
        {
        }

        public void InUserProfile(DataInterceptedEventArgs e)
        {
        }

        public void OnLatencyTest(DataInterceptedEventArgs obj)
        {
            if (UsernameFilter == null)
            {
                Connection.SendToServerAsync(Out.RequestUserData);
            }
        }


        public void OnOutDiceTrigger(DataInterceptedEventArgs e)
        {
        }

        public void OnOutUserRequestBadge(DataInterceptedEventArgs e)
        {
        }

        public void OnUserFriendRemoval(DataInterceptedEventArgs e)
        {
        }


        public void OnUsername(DataInterceptedEventArgs obj)
        {
            string username = obj.Packet.ReadString();


            if (UsernameFilter == null)
            {
                UsernameFilter = username;
            }
        }

        public void OnRoomUserWalk(DataInterceptedEventArgs e)
        {
            if (FreezeUserMovement)
            {
                e.IsBlocked = true;
            }
        }

        public void InItemExtraData(DataInterceptedEventArgs e)
        {
        }

    }
}
