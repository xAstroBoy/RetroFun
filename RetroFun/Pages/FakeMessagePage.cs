using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Habbo;
using Sulakore.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class FakeMessagePage : ObservablePage, ISubscriber
    {
        private int SelectedUserID;
        private string SelectedUsername;
        private string SelectedLook;

        private bool _ShouldBlockReminders = true;

        public bool ShouldBlockReminders
        {
            get => _ShouldBlockReminders;
            set
            {
                _ShouldBlockReminders = value;
                RaiseOnPropertyChanged();
            }
        }

        private string _UserMessage = "";

        public string UserMessage
        {
            get => _UserMessage;
            set
            {
                _UserMessage = value;
                RaiseOnPropertyChanged();
            }
        }

        [MessageId("ef5f3ca3b9e2ee58f030527d85bd4da7")]
        public ushort PrivateMessageAlert { get; set; }

        private Dictionary<int, HEntity> users = new Dictionary<int, HEntity>();


        public FakeMessagePage()
        {
            InitializeComponent();
            Bind(StringMessageTbx, "Text", nameof(UserMessage));
            Bind(NoClientMessageBlockerChbx, "Checked", nameof(ShouldBlockReminders));

            if (Program.Master != null)
            {
                Triggers.InAttach(PrivateMessageAlert, BlockThis);
            }
        }

        public bool IsReceiving => true;

        private void BlockThis(DataInterceptedEventArgs e)
        {
            e.IsBlocked = ShouldBlockReminders;
        }
        public void OnLatencyTest(DataInterceptedEventArgs e)
        {
        }
        public void OnUsername(DataInterceptedEventArgs e)
        {
        }

        public void InPurchaseOk(DataInterceptedEventArgs e)
        {
        }

        public void OnOutDiceTrigger(DataInterceptedEventArgs e)
        {
        }

        public void OnCatalogBuyItem(DataInterceptedEventArgs e)
        {
        }

        public void OnRequestRoomLoad(DataInterceptedEventArgs e)
        {
            users.Clear();
        }

        public void OnUserFriendRemoval(DataInterceptedEventArgs e)
        {
        }
        public void OnRoomUserWalk(DataInterceptedEventArgs e)
        {
        }

        public void InItemExtraData(DataInterceptedEventArgs e)
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

        public void OnOutUserRequestBadge(DataInterceptedEventArgs e)
        {
            SelectedUserID = e.Packet.ReadInteger();
            if (users.TryGetValue(SelectedUserID, out var entity))
            {
                SelectUserLabel.Invoke((MethodInvoker)delegate
                {
                    SelectUserLabel.Text = entity.Name;
                    SelectedLook = entity.FigureId;
                    SelectedUsername = entity.Name;
                });
            }
        }

        public void InUserEnterRoom(DataInterceptedEventArgs obj)
        {

            try
            {
                HEntity[] array = HEntity.Parse(obj.Packet);
                if (array.Length != 0)
                {
                    foreach (HEntity hentity in array)
                    {
                        if (!users.ContainsKey(hentity.Id))
                        {
                            users.Add(hentity.Id, hentity);
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {

            }
        }



        public void InRoomUserLeft(DataInterceptedEventArgs e)
        {
            int index = int.Parse(e.Packet.ReadString());
            var UserLeaveEntity = users.Values.FirstOrDefault(ent => ent.Index == index);
            if (UserLeaveEntity == null) return;

            users.Remove(UserLeaveEntity.Id);
        }

        public void InUserProfile(DataInterceptedEventArgs e)
        {
            e.Packet.ReadInteger();
            SelectedUsername = e.Packet.ReadString();
            SelectedLook = e.Packet.ReadString();
            SelectUserLabel.Invoke((MethodInvoker)delegate
            {
                SelectUserLabel.Text = SelectedUsername;
            });
        }

        private void SendMessagePacket(int userid, string message)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.ReceivePrivateMessage, userid, message, 0);
            }
        }

        private void SendMessageBtn_Click(object sender, EventArgs e)
        {
            SendMessagePacket(SelectedUserID, UserMessage);
        }

        private void AddFriend(int userid, string username, string look)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.UpdateFriend, 0, 1, 1, userid, username, 1, true, true, look, 0, username, 0, 0, false, false);
            }
        }

        private void RemoveFriend(int userid)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.UpdateFriend, 0, 1, -1, userid);
            }
        }

        private void CSFriendAddBtn_Click(object sender, EventArgs e)
        {
            AddFriend(SelectedUserID, SelectedUsername, SelectedLook);
        }

        private void RemoveFriendBtn_Click(object sender, EventArgs e)
        {
            RemoveFriend(SelectedUserID);
        }
        public void OnRoomUserStartTyping(DataInterceptedEventArgs e)
        {
        }

    }
}