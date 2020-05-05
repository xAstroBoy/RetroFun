using Sulakore.Communication;

namespace RetroFun.Subscribers
{
    public interface ISubscriber
    {
        bool IsReceiving { get; }

        //Outgoing events shared by multiple pages
        void OnOutDiceTrigger(DataInterceptedEventArgs e);
        void OnOutUserRequestBadge(DataInterceptedEventArgs e);
        void OnUserFriendRemoval(DataInterceptedEventArgs e);
        void OnRequestRoomLoad(DataInterceptedEventArgs e);
        void OnLatencyTest(DataInterceptedEventArgs e);
        void OnUsername(DataInterceptedEventArgs e);
        void OnRoomUserWalk(DataInterceptedEventArgs e);
        void OnCatalogBuyItem(DataInterceptedEventArgs e);
        void OnRoomUserTalk(DataInterceptedEventArgs e);
        void OnRoomUserShout(DataInterceptedEventArgs e);
        void OnRoomUserWhisper(DataInterceptedEventArgs e);
        void OnRoomUserStartTyping(DataInterceptedEventArgs e);
        void OnRoomPickupItem(DataInterceptedEventArgs e);
        void OnRotateMoveItem(DataInterceptedEventArgs e);
        void OnMoveWallItem(DataInterceptedEventArgs e);


        //Incoming events shared by multiple pages
        void InPurchaseOk(DataInterceptedEventArgs e);
        void InRoomUserLeft(DataInterceptedEventArgs e);
        void InUserEnterRoom(DataInterceptedEventArgs e);
        void InUserProfile(DataInterceptedEventArgs e);
        void InItemExtraData(DataInterceptedEventArgs e);
        void InRoomUserTalk(DataInterceptedEventArgs e);
        void InRoomUserShout(DataInterceptedEventArgs e);
        void InRoomUserWhisper(DataInterceptedEventArgs e);
        void InFloorItemUpdate(DataInterceptedEventArgs e);
        void InRoomData(DataInterceptedEventArgs e);
        void InRoomFloorItems(DataInterceptedEventArgs e);
        void InRoomWallItems(DataInterceptedEventArgs e);
        void InAddFloorItem(DataInterceptedEventArgs e);
        void InAddWallItem(DataInterceptedEventArgs e);
        void InRemoveFloorItem(DataInterceptedEventArgs e);
        void InRemoveWallItem(DataInterceptedEventArgs e);


    }
}