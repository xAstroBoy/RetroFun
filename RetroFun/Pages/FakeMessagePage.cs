using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Habbo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class FakeMessagePage : ObservablePage
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

        public FakeMessagePage()
        {
            InitializeComponent();
            Bind(StringMessageTbx, "Text", nameof(UserMessage));
            Bind(NoClientMessageBlockerChbx, "Checked", nameof(ShouldBlockReminders));
            if (Program.Master != null)
            {
                Triggers.InAttach(817, BlockThis);
            }
        }



        private void BlockThis(DataInterceptedEventArgs e)
        {
            e.IsBlocked = ShouldBlockReminders;
        }

        public override void Out_RequestWearingBadges(DataInterceptedEventArgs e)
        {
            SelectedUserID = e.Packet.ReadInteger();
            var entity = HentityUtils.FindEntityByUserID(SelectedUserID);
            if (entity != null)
            {
                SelectUserLabel.Invoke((MethodInvoker)delegate
                {
                    SelectUserLabel.Text = entity.Name;
                    SelectedLook = entity.FigureId;
                    SelectedUsername = entity.Name;
                });
            }
        }



        public override void In_UserProfile(DataInterceptedEventArgs e)
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
                _ = SendToClient(In.ReceivePrivateMessage, userid, message, 0);
        }

        private void SendMessageBtn_Click(object sender, EventArgs e)
        {
            SendMessagePacket(SelectedUserID, UserMessage);
        }

        private void AddFriend(int userid, string username, string look)
        {
                _ = SendToClient(In.UpdateFriend, 0, 1, 1, userid, username, 1, true, true, look, 0, username, 0, 0, false, false);
        }

        private void RemoveFriend(int userid)
        {
                _ = SendToClient(In.UpdateFriend, 0, 1, -1, userid);
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