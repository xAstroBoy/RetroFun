using RetroFun.Controls;
using Sulakore.Communication;

namespace RetroFun.Subscribers
{
    public class SubscriberPackets : ObservablePage 
    {
        //Outgoing events shared by multiple pages
        public virtual void Out_DiceTrigger(DataInterceptedEventArgs e) { }
        public virtual void Out_CloseDice(DataInterceptedEventArgs e) { }
        public virtual void Out_UserRequestBadge(DataInterceptedEventArgs e) { }
        public virtual void Out_UserFriendRemoval(DataInterceptedEventArgs e) { }
        public virtual void Out_RequestRoomLoad(DataInterceptedEventArgs e) { }
        public virtual void Out_LatencyTest(DataInterceptedEventArgs e) { }
        public virtual void Out_Username(DataInterceptedEventArgs e) { }
        public virtual void Out_RoomUserWalk(DataInterceptedEventArgs e) { }
        public virtual void Out_CatalogBuyItem(DataInterceptedEventArgs e) { }
        public virtual void Out_RoomUserTalk(DataInterceptedEventArgs e) { }
        public virtual void Out_RoomUserShout(DataInterceptedEventArgs e) { }
        public virtual void Out_RoomUserWhisper(DataInterceptedEventArgs e) { }
        public virtual void Out_RoomUserStartTyping(DataInterceptedEventArgs e) { }
        public virtual void Out_RoomPickupItem(DataInterceptedEventArgs e) { }
        public virtual void Out_RotateMoveItem(DataInterceptedEventArgs e) { }
        public virtual void Out_MoveWallItem(DataInterceptedEventArgs e) { }
        public virtual void Out_ToggleFloorItem(DataInterceptedEventArgs e) { }
        public virtual void Out_ToggleWallItem(DataInterceptedEventArgs e) { }
        public virtual void Out_RequestRoomHeightmap(DataInterceptedEventArgs e) { }
        public virtual void Out_TriggerColorWheel(DataInterceptedEventArgs e) { }
        public virtual void Out_TradeStart(DataInterceptedEventArgs e) { }
        public virtual void Out_RoomBackground(DataInterceptedEventArgs e) { }
        public virtual void Out_RequestRoomData(DataInterceptedEventArgs e) { }
        public virtual void Out_RoomPlaceItem(DataInterceptedEventArgs e) { }
        public virtual void Out_AdvertisingSave(DataInterceptedEventArgs e) { }
        //Incoming events shared by multiple pages
        public virtual void In_PurchaseOk(DataInterceptedEventArgs e) { }
        public virtual void In_RoomUserLeft(DataInterceptedEventArgs e) { }
        public virtual void In_UserEnterRoom(DataInterceptedEventArgs e) { }
        public virtual void In_UserProfile(DataInterceptedEventArgs e) { }
        public virtual void In_ItemExtraData(DataInterceptedEventArgs e) { }
        public virtual void In_RoomUserTalk(DataInterceptedEventArgs e) { }
        public virtual void In_RoomUserShout(DataInterceptedEventArgs e) { }
        public virtual void In_RoomUserWhisper(DataInterceptedEventArgs e) { }
        public virtual void In_FloorItemUpdate(DataInterceptedEventArgs e) { }
        public virtual void In_RoomData(DataInterceptedEventArgs e) { }
        public virtual void In_RoomFloorItems(DataInterceptedEventArgs e) { }
        public virtual void In_RoomWallItems(DataInterceptedEventArgs e) { }
        public virtual void In_AddFloorItem(DataInterceptedEventArgs e) { }
        public virtual void In_AddWallItem(DataInterceptedEventArgs e) { }
        public virtual void In_RemoveFloorItem(DataInterceptedEventArgs e) { }
        public virtual void In_RemoveWallItem(DataInterceptedEventArgs e) { }
        public virtual void In_WallItemUpdate(DataInterceptedEventArgs e) { }
        public virtual void In_UserPermissions(DataInterceptedEventArgs e) { }
        public virtual void In_TradeStopped(DataInterceptedEventArgs e) { }
        public virtual void In_GenericErrorMessages(DataInterceptedEventArgs e) { }
        public virtual void In_RoomAccessDenied(DataInterceptedEventArgs e) { }
        public virtual void In_HotelView(DataInterceptedEventArgs e) { }
        public virtual void In_RoomOpen(DataInterceptedEventArgs e) { }
        public virtual void In_RoomEnterError(DataInterceptedEventArgs e) { }
        public virtual void In_ReceivePrivateMessage(DataInterceptedEventArgs e) { }
        public virtual void In_MessagesForYou(DataInterceptedEventArgs e) { }

    }
}