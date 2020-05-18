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
    public partial class FakeMessagePage : SubscriberPackets
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


        private List<HEntity> users = new List<HEntity>();


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

        public override void Out_RequestRoomLoad(DataInterceptedEventArgs e)
        {
            users.Clear();
        }

        public override void Out_UserRequestBadge(DataInterceptedEventArgs e)
        {
            SelectedUserID = e.Packet.ReadInteger();
            var entity = users.Find(u => u.Id == SelectedUserID);
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

        public override void In_UserEnterRoom(DataInterceptedEventArgs obj)
        {

            try
            {
                HEntity[] array = HEntity.Parse(obj.Packet);
                if (array.Length != 0)
                {
                    foreach (HEntity hentity in array)
                    {
                        if (!users.Contains(hentity))
                        {
                            users.Add(hentity);
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {

            }
        }



        public override void In_RoomUserLeft(DataInterceptedEventArgs e)
        {
            int index = int.Parse(e.Packet.ReadString());
            var entity = FindEntity(index);
            if (entity == null) return;
            users.Remove(entity);
        }

        private HEntity FindEntity(int index)
        {
            var entity = users.Find(f => f.Index == index);
            if (entity != null)
            {
                return entity;
            }
            else
            {
                return null;
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