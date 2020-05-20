using RetroFun.Globals;
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
    public partial class MakeSayPage:  ObservablePage
    {
        public int SelectedBubbleId { get; private set; }

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

        public override void In_RoomUsers(DataInterceptedEventArgs obj)
        {
         WriteRegistrationUsers();
        }

        public override void Out_RequestWearingBadges(DataInterceptedEventArgs e)
        {
            int userId = e.Packet.ReadInteger();
            var entity = HentityUtils.FindEntityByUserID(userId);
            if (entity != null)
            {
            
                selectedIndex = entity.Index;
                SelectUserLabel.Invoke((MethodInvoker)delegate
                {
                    SelectUserLabel.Text = entity.Name;
                });
            }
        }


        private void WriteRegistrationUsers()
        {
            Invoke((MethodInvoker)delegate
            {
                TotUserRegistered.Text = GlobalLists.UsersInRoom.Count().ToString();
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
    }
}