using RetroFun.Controls;
using RetroFun.Properties;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Habbo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class MakeSayPage : ObservablePage, ISubscriber
    {
        public int SelectedBubbleId { get; private set; }

        private Dictionary<int, HEntity> users = new Dictionary<int, HEntity>();

        private int selectedIndex;

        public MakeSayPage()
        {
            InitializeComponent();

            var imageType = typeof(Image);

            ResourceSet res = Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            IOrderedEnumerable<DictionaryEntry> reorder = res.Cast<DictionaryEntry>().OrderBy(i => int.Parse(i.Key.ToString().Substring(1)));

            foreach (DictionaryEntry entry in reorder)
            {
                string name = entry.Key.ToString();

                if (string.IsNullOrWhiteSpace(name) || name[0] != '_') continue;

                name = name.Substring(1);
                int bubbleId = int.Parse(name);

                if (entry.Value.GetType() != imageType && !entry.Value.GetType().IsSubclassOf(imageType)) continue;
                BubblesCmbx1.AddImageItem((Image)entry.Value, name, bubbleId);
            }

            BubblesCmbx1.SelectedIndex = 17;
        }

        private void BubblesCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Avoid cross-thread exceptions by waiting for an event in the UI thread to update this property.
            SelectedBubbleId = (int)BubblesCmbx1.SelectedTag;
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
                        hentity.Motto = String.Empty;
                        if (!users.ContainsKey(hentity.Id))
                        {
                            users.Add(hentity.Id, hentity);
                        }
                    }
                }
                WriteRegistrationUsers(users.Count);
            }
            catch(IndexOutOfRangeException)
            {

            }
        }

        public bool IsReceiving => true;

        public void InPurchaseOk(DataInterceptedEventArgs e)
        {
        }

        public void OnOutDiceTrigger(DataInterceptedEventArgs e)
        {
        }
        public void OnLatencyTest(DataInterceptedEventArgs e)
        {
        }
        public void OnUsername(DataInterceptedEventArgs e)
        {
        }
        public void OnUserFriendRemoval(DataInterceptedEventArgs e)
        {
        }

        public void OnCatalogBuyItem(DataInterceptedEventArgs e)
        {
        }

        public void InUserProfile(DataInterceptedEventArgs e)
        {
        }

        public void InItemExtraData(DataInterceptedEventArgs e)
        {
        }
        public void OnRoomUserWalk(DataInterceptedEventArgs e)
        {
        }

        public void InRoomData(DataInterceptedEventArgs e)
        {

        }
        public void OnOutUserRequestBadge(DataInterceptedEventArgs e)
        {
            int userId = e.Packet.ReadInteger();
            if (users.TryGetValue(userId, out var entity))
            {
                selectedIndex = entity.Index;
                SelectUserLabel.Invoke((MethodInvoker)delegate
                {
                    SelectUserLabel.Text = entity.Name;
                });
            }
        }

        public void OnRequestRoomLoad(DataInterceptedEventArgs obj)
        {
            users.Clear();
            WriteRegistrationUsers(users.Count);
        }

        public void InRoomUserLeft(DataInterceptedEventArgs e)
        {
            int index = int.Parse(e.Packet.ReadString());
            var UserLeaveEntity = users.Values.FirstOrDefault(ent => ent.Index == index);
            if (UserLeaveEntity == null) return;

            users.Remove(UserLeaveEntity.Id);
            WriteRegistrationUsers(users.Count);
        }

        private void WriteRegistrationUsers(int count)
        {
            Invoke((MethodInvoker)delegate
            {
                TotUserRegistered.Text = count.ToString();
            });
        }

        private void MakeSayButton_Click(object sender, EventArgs e)
        {
            ushort id = 0;
            if (radioNormal.Checked)
            {
                id = In.RoomUserTalk;
            }
            else if (RadioShout.Checked)
            {
                id = In.RoomUserShout;
            }
            else if (RadioWhisper.Checked)
            {
                id = In.RoomUserWhisper;
            }
            int bubble = int.Parse(this.BubblesCmbx1.GetItemText(this.BubblesCmbx1.SelectedItem));
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(id, selectedIndex, MakeTextBox.Text, 0, bubble, 0, -1);
            }
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
        public void OnRoomUserStartTyping(DataInterceptedEventArgs e)
        {
        }

        public void InFloorItemUpdate(DataInterceptedEventArgs e)
        {
        }
        public void OnRoomPickupItem(DataInterceptedEventArgs e)
        {
        }

        public void OnRotateMoveItem(DataInterceptedEventArgs e)
        {
        }

        public void OnMoveWallItem(DataInterceptedEventArgs e)
        {
        }

        public void InRoomFloorItems(DataInterceptedEventArgs e)
        {
        }

        public void InRoomWallItems(DataInterceptedEventArgs e)
        {
        }

        public void InAddFloorItem(DataInterceptedEventArgs e)
        {
        }

        public void InAddWallItem(DataInterceptedEventArgs e)
        {
        }
        public void InRemoveFloorItem(DataInterceptedEventArgs e)
        { }

        public void InRemoveWallItem(DataInterceptedEventArgs e)
        { }

        public void OnToggleFloorItem(DataInterceptedEventArgs e)
        { }


        public void OnToggleWallItem(DataInterceptedEventArgs e)
        { }

        public void OnRequestRoomHeightmap(DataInterceptedEventArgs e)
        { }

        public void InWallItemUpdate(DataInterceptedEventArgs e)
        { }
    }
}