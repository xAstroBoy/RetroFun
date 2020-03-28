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


        //Incoming events shared by multiple pages
        void InPurchaseOk(DataInterceptedEventArgs e);

        void InRoomUserLeft(DataInterceptedEventArgs e);

        void InUserEnterRoom(DataInterceptedEventArgs e);

        void inUserProfile(DataInterceptedEventArgs e);

        void InItemExtraData(DataInterceptedEventArgs e);
    }
}