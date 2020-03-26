using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Modules;
using System.Collections.Generic;
using System.ComponentModel;

namespace RetroFun
{
    [DesignerCategory("Form")]
    [Module("RetroFun", "Miscellaneous stuff for retroservers")]
    [Author("marcocorriero")]
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


        private List<ISubscriber> _subscribers = new List<ISubscriber>();

        public MainFrm()
        {
            // Must be set before initializing components.
            Program.Master = this;
            InitializeComponent();

            //Pages sharing events
            _subscribers = new List<ISubscriber>
            {
                ChatPg,
                DicePg,
                AutoHoloDicePg,
                BuyFurniBruteforcerPg,
                GiftEditorPg,
                MakeSayPg,
                StalkingPg,
                FakeMessagePg,
                MiscellaneousPg,
                furniSpawnPg,
                BottomPg,
                FurniPg,
                PetPg,
                UserEditorPg,
            };

            Bind(AlwaysOnTopChbx, "Checked", nameof(IsAlwaysOnTop));
        }



        public override void HandleOutgoing(DataInterceptedEventArgs e)
        {
            int id = e.Packet.Header;
            foreach (var sub in _subscribers)
            {
                if (!sub.IsReceiving) continue;
                e.Packet.Position = 0;

                if (Out.TriggerDice == id || Out.CloseDice == id)
                {
                    sub.OnOutDiceTrigger(e);
                }
                else if (Out.RequestWearingBadges == id)
                {
                    sub.OnOutUserRequestBadge(e);
                }
                else if (Out.RemoveFriend == id)
                {
                    sub.OnUserFriendRemoval(e);
                }
                else if (Out.RequestRoomLoad == id)
                {
                    sub.OnRequestRoomLoad(e);
                }
                else if (Out.LatencyTest == id)
                {
                    sub.OnLatencyTest(e);
                }
                else if (Out.Username == id)
                {
                    sub.OnUsername(e);
                }
                else if (Out.RoomUserWalk == id)
                {
                    sub.OnRoomUserWalk(e);
                }
                else if (Out.CatalogBuyItem == id)
                {
                    sub.OnCatalogBuyItem(e);
                }
            }
        }

        public override void HandleIncoming(DataInterceptedEventArgs e)
        {
            int id = e.Packet.Header;
            foreach (var sub in _subscribers)
            {
                if (!sub.IsReceiving) continue;
                e.Packet.Position = 0;

                if (In.PurchaseOK == id)
                {
                    sub.InPurchaseOk(e);
                }
                else if (In.RoomUsers == id)
                {
                    sub.InUserEnterRoom(e);
                }
                else if (In.RoomUserRemove == id)
                {
                    sub.InRoomUserLeft(e);
                }
                else if (In.UserProfile == id)
                {
                    sub.inUserProfile(e);
                }
            }
        }
    }
}