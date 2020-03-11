using RetroFun.Controls;
using RetroFun.Helpers;
using RetroFun.Properties;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Habbo;
using Sulakore.Modules;
using Sulakore.Protocol;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class ChatPage : ObservablePage, ISubscriber
    {
        private HMessage replacement;
        private int LocalIndex;

        private int[] rainbowlist = new int[] { 3, 4, 5, 6, 7, 11, 12, 13, 14, 15, 18 };
        //private int oldrainbowbubble;
        //private int newrainbowselected;
        private Random rand = new Random();
        public bool IsReceiving => true;

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

        public bool UseSelectedBubbleServerSide
        {
            get => _useSelectedBubble;
            set
            {
                _useSelectedBubble = value;
                RaiseOnPropertyChanged();
            }
        }
        private bool _UseSelectedBubbleClientSide;

        public bool UseSelectedBubbleClientSide
        {
            get => _UseSelectedBubbleClientSide;
            set
            {
                _UseSelectedBubbleClientSide = value;
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

        private bool _ForceChatSpeak;

        public bool ForceChatSpeak
        {
            get => _ForceChatSpeak;
            set
            {
                _ForceChatSpeak = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _ForceNormalSpeak = true;

        public bool ForceNormalSpeak
        {
            get => _ForceNormalSpeak;
            set
            {
                _ForceNormalSpeak = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _ForceShoutChat;

        public bool ForceShoutChat
        {
            get => _ForceShoutChat;
            set
            {
                _ForceShoutChat = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _ForceWhisperChat;

        public bool ForceWhisperChat
        {
            get => _ForceWhisperChat;
            set
            {
                _ForceWhisperChat = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _RainbowChatEnabled;

        public bool RainbowChatEnabled
        {
            get => _RainbowChatEnabled;
            set
            {
                _RainbowChatEnabled = value;
                RaiseOnPropertyChanged();
            }
        }

        private string _UsernameFilter;

        public string UsernameFilter
        {
            get => _UsernameFilter;
            set
            {
                _UsernameFilter = value;
                RaiseOnPropertyChanged();
            }
        }


        public int SelectedSSBubbleId { get; private set; }
        public int SelectedCSBubbleId { get; private set; }

        public ChatPage()
        {
            InitializeComponent();

            Bind(AntiBobbaFilterChbx, "Checked", nameof(AntiBobbaFilter));
            Bind(UseSelectedBubbleSSChbx, "Checked", nameof(UseSelectedBubbleServerSide));
            Bind(UseSelectedBubbleCSChbx, "Checked", nameof(UseSelectedBubbleClientSide));
            Bind(UsernameTextBox, "Text", nameof(UsernameFilter));

            Bind(HideSpeakingBubbleChbx, "Checked", nameof(HideSpeakingBubble));
            Bind(ForceDefSpeakBox, "Checked", nameof(ForceChatSpeak));
            Bind(NormalTalkBox, "Checked", nameof(ForceNormalSpeak));
            Bind(ShoutTalkBox, "Checked", nameof(ForceShoutChat));
            Bind(WhisperChatBox, "Checked", nameof(ForceWhisperChat));
            Bind(RainbowChatChbx, "Checked", nameof(RainbowChatEnabled));

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
                BubblesSSCmbx.AddImageItem((Image)entry.Value, name, bubbleId);
                BubblesCSCmbx.AddImageItem((Image)entry.Value, name, bubbleId);

            }

            BubblesSSCmbx.SelectedIndex = 17;
            BubblesCSCmbx.SelectedIndex = 17;

            if (Program.Master != null)
            {
                Triggers.OutAttach(Out.RoomUserTalk, RoomUserStartSpeaking);
                Triggers.OutAttach(Out.RoomUserShout, RoomUserStartSpeaking);
                Triggers.OutAttach(Out.RoomUserWhisper, RoomUserStartSpeaking);
                Triggers.OutAttach(Out.RoomUserStartTyping, RoomUserStartTyping);


                Triggers.InAttach(In.RoomUserTalk, CSRoomUserTalk);
                Triggers.InAttach(In.RoomUserShout, CSRoomUserShout);
                Triggers.InAttach(In.RoomUserWhisper, CSRoomUserWhisper);

            }
        }


        public void OnLatencyTest(DataInterceptedEventArgs obj)
        {
            if (UsernameFilter == null)
            {
                Connection.SendToServerAsync(Out.RequestUserData);
            }
        }

        public void OnUsername(DataInterceptedEventArgs obj)
        {
            HMessage packet = obj.Packet;
            string username = packet.ReadString();

            if (UsernameFilter == null)
            {
                UsernameFilter = username;
            }
        }



        private void ForceDefSpeakBox_CheckedChanged(object sender, EventArgs e)
        {
            ToggleChatDefault();
        }

        private void RainbowChatChbx_CheckedChanged(object sender, EventArgs e)
        {
            ToggleRainbowChatRequirements();
        }

        private int GetRainbowBubbleint()
        {
            return rainbowlist[rand.Next(rainbowlist.Length)];
        }


        private void ToggleRainbowChatRequirements()
        {
            if (RainbowChatEnabled)
            {
                ToggleComboBox(BubblesSSCmbx, true);
                ToggleCheckbox(UseSelectedBubbleSSChbx, true);
            }
            else
            {
                ToggleComboBox(BubblesSSCmbx, false);
                ToggleCheckbox(UseSelectedBubbleSSChbx, false);
            }
        }


        private void ToggleChatDefault()
        {
            if (ForceChatSpeak)
            {
                ToggleGroupbox(GroupChatDefault, false);
            }
            else
            {
                ToggleGroupbox(GroupChatDefault, true);
            }
        }

        private void ToggleGroupbox(GroupBox Group, bool Actived)
        {
            Invoke((MethodInvoker)delegate
            {
                Group.Enabled = Actived;
            });
        }

        private void ToggleCheckbox(CheckBox checkbox, bool Actived)
        {
            Invoke((MethodInvoker)delegate
            {
                checkbox.Enabled = Actived;
            });
        }


        private void ToggleComboBox(ImageComboBox box, bool Actived)
        {
            Invoke((MethodInvoker)delegate
            {
                box.Enabled = Actived;
            });
        }

        public void InUserEnterRoom(DataInterceptedEventArgs obj)
        {
            if (UsernameFilter != null)
            {
                HEntity[] array = HEntity.Parse(obj.Packet);
                if (array.Length != 0)
                {
                    foreach (HEntity hentity in array)
                    {
                        if (hentity.Name == UsernameFilter)
                        {
                            LocalIndex = hentity.Index;
                        }
                    }
                }
            }
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

        public void inUserProfile(DataInterceptedEventArgs e)
        {
        }

        public void OnOutUserRequestBadge(DataInterceptedEventArgs e)
        {
        }

        public void OnUserLeaveRoom(DataInterceptedEventArgs e)
        {
        }

        public void InRoomUserLeft(DataInterceptedEventArgs e)
        {
        }

        public void OnRoomUserWalk(DataInterceptedEventArgs e)
        {
        }

        private void BubblesCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Avoid cross-thread exceptions by waiting for an event in the UI thread to update this property.
            SelectedSSBubbleId = (int)BubblesSSCmbx.SelectedTag;
        }

        private void BubblesCSCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Avoid cross-thread exceptions by waiting for an event in the UI thread to update this property.
            SelectedCSBubbleId = (int)BubblesCSCmbx.SelectedTag;
        }

        private void RoomUserStartTyping(DataInterceptedEventArgs obj)
        {
            obj.IsBlocked = HideSpeakingBubble;
        }


        private void CSRoomUserTalk(DataInterceptedEventArgs obj)
        {
            int index = obj.Packet.ReadInteger();
            string msg = obj.Packet.ReadString();
            if (UseSelectedBubbleClientSide)
            {
                if (index == LocalIndex)
                {
                    Connection.SendToClientAsync(In.RoomUserTalk, LocalIndex, msg, 0, SelectedCSBubbleId, 0, -1);
                    obj.IsBlocked = true;
                }
            }
        }

        private void CSRoomUserShout(DataInterceptedEventArgs obj)
        {
            int index = obj.Packet.ReadInteger();
            string msg = obj.Packet.ReadString();

            if (UseSelectedBubbleClientSide)
            {
                if (index == LocalIndex)
                {
                    Connection.SendToClientAsync(In.RoomUserShout, LocalIndex, msg, 0, SelectedCSBubbleId, 0, -1);
                    obj.IsBlocked = true;
                }
            }
        }
        private void CSRoomUserWhisper(DataInterceptedEventArgs obj)
        {
            int index = obj.Packet.ReadInteger();
            string msg = obj.Packet.ReadString();

            if (UseSelectedBubbleClientSide)
            {
                if (index == LocalIndex)
                {
                    Connection.SendToClientAsync(In.RoomUserWhisper, LocalIndex, msg, 0, SelectedCSBubbleId, 0, -1);
                    obj.IsBlocked = true;
                }
            }
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

            if (UseSelectedBubbleServerSide)
            {
                bubbleId = SelectedSSBubbleId;
            }

            if (RainbowChatEnabled)
            {
                int Debug = GetRainbowBubbleint();
                Console.WriteLine("RainbowBubbleTest : Used ID : " + Debug);

                bubbleId = Debug;
            }

            obj.IsBlocked = true;
            if (!ForceChatSpeak)
            {
                replacement = new HMessage(obj.Packet.Header, message, bubbleId);
            }
            else
            {
                if (ForceNormalSpeak)
                {
                    replacement = new HMessage(Out.RoomUserTalk, message, bubbleId);
                }
                else if (ForceShoutChat)
                {
                    replacement = new HMessage(Out.RoomUserShout, message, bubbleId);
                }
                else if (ForceWhisperChat)
                {
                    replacement = new HMessage(Out.RoomUserWhisper, message, bubbleId);
                }
            }


            if (obj.Packet.Readable > 0)
            {
                replacement.WriteInteger(0);
            }
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToServerAsync(replacement);
            }
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