using System;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.Globalization;
using System.ComponentModel;

using RetroFun.Controls;
using RetroFun.Properties;

using Sulakore.Protocol;
using Sulakore.Communication;
using System.Resources;
using Sulakore.Habbo;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class MakeSayPage : ObservablePage
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

            if (Program.Master != null)
            {
                Triggers.InAttach(In.RoomUsers, RoomUserEnterRoom);
                Triggers.OutAttach(Out.RequestWearingBadges, UserIDGrabber);
                Triggers.InAttach(In.RoomUserRemove, RoomUserLeft);
                Triggers.OutAttach(Out.RequestRoomLoad, UserLeaveRoom);
            }
        }

        private void BubblesCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Avoid cross-thread exceptions by waiting for an event in the UI thread to update this property.
            SelectedBubbleId = (int)BubblesCmbx1.SelectedTag;
        }

        private void RoomUserEnterRoom(DataInterceptedEventArgs obj)
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
            WriteRegistrationUsers(users.Count);
        }

        private void UserIDGrabber(DataInterceptedEventArgs obj)
        {
            int userId = obj.Packet.ReadInteger();
            if (users.TryGetValue(userId, out var entity))
            {
                selectedIndex = entity.Index;
                SelectUserLabel.Invoke((MethodInvoker)delegate
                {
                    SelectUserLabel.Text = entity.Name;
                });
            }
        }

        private void UserLeaveRoom(DataInterceptedEventArgs obj)
        {
            users.Clear();
            WriteRegistrationUsers(users.Count);
        }

        private void RoomUserLeft(DataInterceptedEventArgs e)
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
            base.Connection.SendToClientAsync(id, selectedIndex, MakeTextBox.Text, 0, bubble, 0, -1);
        }
    }
}