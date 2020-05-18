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


        private List<SubscriberPackets> _subscribers = new List<SubscriberPackets>();

        public MainFrm()
        {
            // Must be set before initializing components.
            Program.Master = this;
            InitializeComponent();

            //Pages sharing events
            _subscribers = new List<SubscriberPackets>
            {
                ChatPg,
                DicePg,
                FurniPg,
                MakeSayPg,
                SpeechzPg,
                GiftEditorPg,
                StalkingPg,
                AutoHoloDicePg,
                AvatarEditorPg,
                MiscellaneousPg,
                BuyFurniBruteforcerPg,
                FakeMessagePg,
                RoomBackFunPg,
                furniSpawnPg,
                MoonLightFunPg,
                DiscoRoomFunPg,
                BottomPg,
                FurniTrollPg,
                UtilitiesPg,
                PetPg,
                UserEditorPg,
                PersonalPg,
                ModerationPg,
                FurnitureCheckerPg,
             };
                
            Bind(AlwaysOnTopChbx, "Checked", nameof(IsAlwaysOnTop));
        }



        public override void HandleOutgoing(DataInterceptedEventArgs e)
        {
            int id = e.Packet.Header;
            foreach (var sub in _subscribers)
            {
                e.Packet.Position = 0;

                if (Out.TriggerDice == id)
                {
                    sub.Out_DiceTrigger(e);
                }
                else if (Out.CloseDice == id)
                {
                    sub.Out_CloseDice(e);
                }
                else if (Out.RequestWearingBadges == id)
                {
                    sub.Out_UserRequestBadge(e);
                }
                else if (Out.RemoveFriend == id)
                {
                    sub.Out_UserFriendRemoval(e);
                }
                else if (Out.RequestRoomLoad == id)
                {
                    sub.Out_RequestRoomLoad(e);
                }
                else if (Out.LatencyTest == id)
                {
                    sub.Out_LatencyTest(e);
                }
                else if (Out.Username == id)
                {
                    sub.Out_Username(e);
                }
                else if (Out.RoomUserWalk == id)
                {
                    sub.Out_RoomUserWalk(e);
                }
                else if (Out.CatalogBuyItem == id)
                {
                    sub.Out_CatalogBuyItem(e);
                }
                else if (Out.RoomUserTalk == id)
                {
                    sub.Out_RoomUserTalk(e);
                }
                else if (Out.RoomUserShout == id)
                {
                    sub.Out_RoomUserShout(e);
                }
                else if (Out.RoomUserWhisper == id)
                {
                    sub.Out_RoomUserWhisper(e);
                }
                else if(Out.RoomUserStartTyping == id)
                {
                    sub.Out_RoomUserStartTyping(e);
                }
                else if (Out.RoomPickupItem == id)
                {
                    sub.Out_RoomPickupItem(e);
                }
                else if (Out.RotateMoveItem == id)
                {
                    sub.Out_RotateMoveItem(e);
                }
                else if (Out.MoveWallItem == id)
                {
                    sub.Out_MoveWallItem(e);
                }
                else if (Out.ToggleFloorItem == id)
                {
                    sub.Out_ToggleFloorItem(e);
                }
                else if (Out.ToggleWallItem == id)
                {
                    sub.Out_ToggleWallItem(e);
                }
                else if (Out.RequestRoomHeightmap == id)
                {
                    sub.Out_RequestRoomHeightmap(e);
                }
                else if (Out.TriggerColorWheel == id)
                {
                    sub.Out_TriggerColorWheel(e);
                }
                else if (Out.TradeStart == id)
                {
                    sub.Out_TradeStart(e);
                }
                else if (Out.RoomBackground == id)
                {
                    sub.Out_RoomBackground(e);
                }
                else if (Out.RequestRoomData == id)
                {
                    sub.Out_RequestRoomData(e);
                }
                else if (Out.RoomPlaceItem == id)
                {
                    sub.Out_RoomPlaceItem(e);
                }
                else if (Out.AdvertisingSave == id)
                {
                    sub.Out_AdvertisingSave(e);
                }
            }
        }

        public override void HandleIncoming(DataInterceptedEventArgs e)
        {
            int id = e.Packet.Header;
            foreach (var sub in _subscribers)
            {
                e.Packet.Position = 0;

                if (In.PurchaseOK == id)
                {
                    sub.In_PurchaseOk(e);
                }
                else if (In.RoomUsers == id)
                {
                    sub.In_UserEnterRoom(e);
                }
                else if (In.RoomUserRemove == id)
                {
                    sub.In_RoomUserLeft(e);
                }
                else if (In.UserProfile == id)
                {
                    sub.In_UserProfile(e);
                }
                else if(In.ItemExtraData == id)
                {
                    sub.In_ItemExtraData(e);
                }
                else if (In.RoomUserTalk == id)
                {
                    sub.In_RoomUserTalk(e);
                }
                else if (In.RoomUserShout == id)
                {
                    sub.In_RoomUserShout(e);
                }
                else if (In.RoomUserWhisper == id)
                {
                    sub.In_RoomUserWhisper(e);
                }
                else if (In.FloorItemUpdate == id)
                {
                    sub.In_FloorItemUpdate(e);
                }
                else if (In.RoomData == id)
                {
                    sub.In_RoomData(e);
                }
                else if (In.RoomFloorItems == id)
                {
                    sub.In_RoomFloorItems(e);
                }
                else if (In.RoomWallItems == id)
                {
                    sub.In_RoomWallItems(e);
                }
                else if (In.AddFloorItem == id)
                {
                    sub.In_AddFloorItem(e);
                }
                else if (In.AddWallItem == id)
                {
                    sub.In_AddWallItem(e);
                }
                else if (In.RemoveWallItem == id)
                {
                    sub.In_RemoveWallItem(e);
                }
                else if (In.RemoveFloorItem == id)
                {
                    sub.In_RemoveFloorItem(e);
                }
                else if (In.WallItemUpdate == id)
                {
                    sub.In_WallItemUpdate(e);
                }
                else if (In.UserPermissions == id)
                {
                    sub.In_UserPermissions(e);
                }
                else if (In.TradeStopped == id)
                {
                    sub.In_TradeStopped(e);
                }
                else if (In.GenericErrorMessages == id)
                {
                    sub.In_GenericErrorMessages(e);
                }
                else if (In.RoomAccessDenied == id)
                {
                    sub.In_RoomAccessDenied(e);
                }
                else if (In.HotelView == id)
                {
                    sub.In_HotelView(e);
                }
                else if (In.RoomOpen == id)
                {
                    sub.In_RoomOpen(e);
                }
                else if (In.RoomEnterError == id)
                {
                    sub.In_RoomEnterError(e);
                }
                else if (In.ReceivePrivateMessage == id)
                {
                    sub.In_ReceivePrivateMessage(e);
                }
                else if (In.MessagesForYou == id)
                {
                    sub.In_MessagesForYou(e);
                }
            }
        }
    }
}