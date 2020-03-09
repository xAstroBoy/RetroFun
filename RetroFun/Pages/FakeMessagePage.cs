using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Communication;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class FakeMessagePage : ObservablePage, ISubscriber
    {
        public readonly string blockhash = "ef5f3ca3b9e2ee58f030527d85bd4da7";
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

        public FakeMessagePage()
        {
            InitializeComponent();
            Bind(StringMessageTbx, "Text", nameof(UserMessage));
            Bind(NoClientMessageBlockerChbx, "Checked", nameof(ShouldBlockReminders));
            if (Program.Master != null)
            {
                Triggers.InAttach(In.PrivateMessageAlert, BlockThis);
            }
        }

        public bool IsReceiving => true;

        private void BlockThis(DataInterceptedEventArgs e)
        {
            e.IsBlocked = ShouldBlockReminders;
        }

        public void InPurchaseOk(DataInterceptedEventArgs e)
        {
        }

        public void OnOutDiceTrigger(DataInterceptedEventArgs e)
        {
        }

        public void OnUserFriendRemoval(DataInterceptedEventArgs e)
        {
        }

        public void OnOutUserRequestBadge(DataInterceptedEventArgs e)
        {
            SelectedUserID = e.Packet.ReadInteger();
        }

        public void InUserEnterRoom(DataInterceptedEventArgs obj)
        { }

        public void OnUserLeaveRoom(DataInterceptedEventArgs obj)
        { }

        public void InRoomUserLeft(DataInterceptedEventArgs e)
        { }

        public void inUserProfile(DataInterceptedEventArgs e)
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
    }
}