using RetroFun.Controls;
using RetroFun.Pages;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace RetroFun
{
    [DesignerCategory("Form")]
    [Module("RetroFun", "All-in-one scripting tool!")]
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
                AvatarEditorPg,
                FurniTrollPg,
                PersonalPg,
                ModerationPg,
                FurnitureCheckerPg
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
                else if (Out.RoomUserTalk == id)
                {
                    sub.OnRoomUserTalk(e);
                }
                else if (Out.RoomUserShout == id)
                {
                    sub.OnRoomUserShout(e);
                }
                else if (Out.RoomUserWhisper == id)
                {
                    sub.OnRoomUserWhisper(e);
                }
                else if(Out.RoomUserStartTyping == id)
                {
                    sub.OnRoomUserStartTyping(e);
                }
                else if (Out.RoomPickupItem == id)
                {
                    sub.OnRoomPickupItem(e);
                }
                else if (Out.RotateMoveItem == id)
                {
                    sub.OnRotateMoveItem(e);
                }
                else if (Out.MoveWallItem == id)
                {
                    sub.OnMoveWallItem(e);
                }
                else if (Out.ToggleFloorItem == id)
                {
                    sub.OnToggleFloorItem(e);
                }
                else if (Out.ToggleWallItem == id)
                {
                    sub.OnToggleWallItem(e);
                }
                else if (Out.RequestRoomHeightmap == id)
                {
                    sub.OnRequestRoomHeightmap(e);
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
                    sub.InUserProfile(e);
                }
                else if(In.ItemExtraData == id)
                {
                    sub.InItemExtraData(e);
                }
                else if (In.RoomUserTalk == id)
                {
                    sub.InRoomUserTalk(e);
                }
                else if (In.RoomUserShout == id)
                {
                    sub.InRoomUserShout(e);
                }
                else if (In.RoomUserWhisper == id)
                {
                    sub.InRoomUserWhisper(e);
                }
                else if (In.FloorItemUpdate == id)
                {
                    sub.InFloorItemUpdate(e);
                }
                else if (In.RoomData == id)
                {
                    sub.InRoomData(e);
                }
                else if (In.RoomFloorItems == id)
                {
                    sub.InRoomFloorItems(e);
                }
                else if (In.RoomWallItems == id)
                {
                    sub.InRoomWallItems(e);
                }
                else if (In.AddFloorItem == id)
                {
                    sub.InAddFloorItem(e);
                }
                else if (In.AddWallItem == id)
                {
                    sub.InAddWallItem(e);
                }
                else if (In.RemoveWallItem == id)
                {
                    sub.InRemoveWallItem(e);
                }
                else if (In.RemoveFloorItem == id)
                {
                    sub.InRemoveFloorItem(e);
                }
                else if (In.WallItemUpdate == id)
                {
                    sub.InWallItemUpdate(e);
                }
            }
        }
    }
}