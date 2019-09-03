using System;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Globalization;
using System.ComponentModel;

using BobbaFun.Controls;
using BobbaFun.Properties;

using Sulakore.Protocol;
using Sulakore.Communication;
using System.Collections.Generic;
using System.Resources;
using System.Linq;


namespace BobbaFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class ChatPage : ObservablePage
    {



        private bool _antiBobbaFilter;
        public bool AntiBobbaFilter
        {
            get => _antiBobbaFilter;
            set
            {
                _antiBobbaFilter = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _useSelectedBubble;
        public bool UseSelectedBubble
        {
            get => _useSelectedBubble;
            set
            {
                _useSelectedBubble = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _hideSpeakingBubble;
        public bool HideSpeakingBubble
        {
            get => _hideSpeakingBubble;
            set
            {
                _hideSpeakingBubble = value;
                RaiseOnPropertyChanged();
            }
        }

        public int SelectedBubbleId { get; private set; }

        public ChatPage()
        {
            InitializeComponent();

            Bind(AntiBobbaFilterChbx, "Checked", nameof(AntiBobbaFilter));
            Bind(UseSelectedBubbleChbx, "Checked", nameof(UseSelectedBubble));
            Bind(HideSpeakingBubbleChbx, "Checked", nameof(HideSpeakingBubble));

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
                BubblesCmbx.AddImageItem((Image)entry.Value, name, bubbleId);

            }






            BubblesCmbx.SelectedIndex = 17;

            if (Program.Master != null)
            {
                Triggers.OutAttach(Out.RoomUserTalk, RoomUserStartSpeaking);
                Triggers.OutAttach(Out.RoomUserShout, RoomUserStartSpeaking);
                Triggers.OutAttach(Out.RoomUserWhisper, RoomUserStartSpeaking);
                Triggers.OutAttach(Out.RoomUserStartTyping, RoomUserStartTyping);
            }
        }




        private void BubblesCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Avoid cross-thread exceptions by waiting for an event in the UI thread to update this property.
            SelectedBubbleId = (int)BubblesCmbx.SelectedTag;
        }

        private void RoomUserStartTyping(DataInterceptedEventArgs obj)
        {
            obj.IsBlocked = HideSpeakingBubble;
        }

        private void RoomUserStartSpeaking(DataInterceptedEventArgs obj)
        {
            string message = obj.Packet.ReadString();
            int bubbleId = obj.Packet.ReadInteger();

            string whisperTarget = null;
            if (obj.Packet.Header == Out.RoomUserWhisper)
            {
                whisperTarget = message.Split(' ')[0];
                message = message.Substring(whisperTarget.Length);
            }

            if (AntiBobbaFilter)
            {
                message = BypassFilter(message);
            }

            if (!string.IsNullOrWhiteSpace(whisperTarget))
            {
                message = whisperTarget + " " + message;
            }

            if (UseSelectedBubble)
            {
                bubbleId = SelectedBubbleId;
            }

            obj.IsBlocked = true;
            var replacement = new HMessage(obj.Packet.Header, message, bubbleId);
            if (obj.Packet.Readable > 0)
            {
                replacement.WriteInteger(0);
            }
            Connection.SendToServerAsync(replacement);
        }








        private string BypassFilter(string message)
        {
            var builder = new StringBuilder(message.Length * 5);
            foreach (char character in message)
            {
                builder.Append("&#" + (int)character + "º;");
            }
            return builder.ToString();
        }


    }
}