using RetroFun.Controls;
using RetroFun.Helpers;
using RetroFun.Properties;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Components;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class ChatPage : ObservablePage, ISubscriber
    {
        private HMessage replacement;
        private HMessage ChatMessageBuild;
        private HMessage FloodMessageBuild;

        private int LocalIndex;
        private Dictionary<int, HEntity> users = new Dictionary<int, HEntity>();

        private bool isRaidMode;
        private bool IsRaidModeAlertDone;

        private int[] rainbowlist = new int[] { 3, 4, 5, 6, 7, 11, 12, 13, 14, 15, 18 };

        //private int oldrainbowbubble;
        //private int newrainbowselected;

        private Random rand = new Random();

        public bool IsReceiving => true;

        private bool BlockRoomLoad;

        private bool _FlooderEnabled;

        private int ChatMessageBubble;

        private int FloodMessageBubble;

        public bool FlooderEnabled
        {
            get => _FlooderEnabled;
            set
            {
                _FlooderEnabled = value;
                RaiseOnPropertyChanged();
            }
        }



        private string _FlooderText;

        public string FlooderText
        {
            get => _FlooderText;
            set
            {
                _FlooderText = value;
                RaiseOnPropertyChanged();
            }
        }


        private string _ChatMessageText;

        public string ChatMessageText
        {
            get => _ChatMessageText;
            set
            {
                _ChatMessageText = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _FlooderCooldown = 50;

        public int FlooderCooldown
        {
            get => _FlooderCooldown;
            set
            {
                _FlooderCooldown = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _RaidUserCooldownCooldown = 50;

        public int RaidUserCooldownCooldown
        {
            get => _RaidUserCooldownCooldown;
            set
            {
                _RaidUserCooldownCooldown = value;
                RaiseOnPropertyChanged();
            }
        }

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


        private string _CloneUsernameFilter;

        public string CloneUsernameFilter
        {
            get => _CloneUsernameFilter;
            set
            {
                _CloneUsernameFilter = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _MainUserIndex;

        public int MainUserIndex
        {
            get => _MainUserIndex;
            set
            {
                _MainUserIndex = value;
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

            Bind(TextFloodPhraseBox, "Text", nameof(FlooderText));
            Bind(CooldownFloodNbx, "Value", nameof(FlooderCooldown));
            Bind(TargetUserTxb, "Text", nameof(CloneUsernameFilter));
            Bind(IndexNbx, "Value", nameof(MainUserIndex));
            Bind(CooldownCloneUserChatNbx, "Value", nameof(RaidUserCooldownCooldown));
            Bind(ChatMsgTxb, "Text", nameof(ChatMessageText));

            

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

        }


        public void OnLatencyTest(DataInterceptedEventArgs obj)
        {
            if (UsernameFilter == null)
            {
                Connection.SendToServerAsync(Out.RequestUserData);
                BlockRoomLoad = true;
            }
        }

        public void OnUsername(DataInterceptedEventArgs obj)
        {
            string username = obj.Packet.ReadString();


            if (UsernameFilter == null)
            {
                UsernameFilter = username;
            }
        }


        private void WriteToButton(SKoreButton Button, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                Button.Text = text;
            });


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
            try
            {
                if (UsernameFilter != null)
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
                            if (hentity.Name == UsernameFilter)
                            {
                                LocalIndex = hentity.Index;
                            }
                            if (hentity.Name == CloneUsernameFilter)
                            {
                                MainUserIndex = hentity.Index;
                            }
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
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
        public void OnUserFriendRemoval(DataInterceptedEventArgs e)
        {
        }

        public void InUserProfile(DataInterceptedEventArgs e)
        {
        }

        public void OnRequestRoomLoad(DataInterceptedEventArgs e)
        {
            users.Clear();
            if (BlockRoomLoad)
            {

                e.IsBlocked = true;
                BlockRoomLoad = false;
            }

        }
        public void OnOutUserRequestBadge(DataInterceptedEventArgs e)
        {
        }

        public void InRoomUserLeft(DataInterceptedEventArgs e)
        {
            int index = int.Parse(e.Packet.ReadString());
            var UserLeaveEntity = users.Values.FirstOrDefault(ent => ent.Index == index);
            if (UserLeaveEntity == null) return;

            users.Remove(UserLeaveEntity.Id);
        }

        public void OnRoomUserWalk(DataInterceptedEventArgs e)
        {
        }

        public void InItemExtraData(DataInterceptedEventArgs e)
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


        public void OnRoomUserTalk(DataInterceptedEventArgs e)
        {
            RoomUserStartSpeaking(e);
        }

        public void OnRoomUserShout(DataInterceptedEventArgs e)
        {
            RoomUserStartSpeaking(e);
        }

        public void OnRoomUserWhisper(DataInterceptedEventArgs e)
        {
            RoomUserStartSpeaking(e);
        }


        public void InRoomUserTalk(DataInterceptedEventArgs e)
        {
            int index = e.Packet.ReadInteger();
            string msg = e.Packet.ReadString();
            e.Packet.ReadInteger();
            int bubbleid = e.Packet.ReadInteger();
            if (UseSelectedBubbleClientSide)
            {
                if (index == LocalIndex)
                {
                    e.IsBlocked = true;
                    Connection.SendToClientAsync(In.RoomUserTalk, LocalIndex, msg, 0, SelectedCSBubbleId, 0, -1);
                }
            }
            if (isRaidMode)
            {
                if (index == MainUserIndex)
                {
                    ConvertCSChatTalk(msg, bubbleid);
                }
            }
        }
        private async void ConvertCSChatTalk(string message, int bubbleid)
        {
            await Task.Delay(RaidUserCooldownCooldown);
            await Connection.SendToServerAsync(Out.RoomUserTalk, " " + message, bubbleid);
            return;
        }

        private async void ConvertCSChatShout(string message, int bubbleid)
        {
            await Task.Delay(RaidUserCooldownCooldown);
            await Connection.SendToServerAsync(Out.RoomUserTalk, " " + message, bubbleid);
            return;
        }


        public void InRoomUserShout(DataInterceptedEventArgs e)
        {
            int index = e.Packet.ReadInteger();
            string msg = e.Packet.ReadString();
            e.Packet.ReadInteger();
            int bubbleid = e.Packet.ReadInteger();

            if (UseSelectedBubbleClientSide)
            {
                if (index == LocalIndex)
                {
                    e.IsBlocked = true;
                    Connection.SendToClientAsync(In.RoomUserShout, LocalIndex, msg, 0, SelectedCSBubbleId, 0, -1);
                }
            }

            if (isRaidMode)
            {
                if (index == MainUserIndex)
                {
                    ConvertCSChatShout(msg, bubbleid);
                }
            }
        }

        public void InRoomUserWhisper(DataInterceptedEventArgs e)
        {
            int index = e.Packet.ReadInteger();
            string msg = e.Packet.ReadString();
            e.Packet.ReadInteger();
            int bubbleid = e.Packet.ReadInteger();

            if (UseSelectedBubbleClientSide)
            {
                if (index == LocalIndex)
                {
                    e.IsBlocked = true;
                    Connection.SendToClientAsync(In.RoomUserWhisper, LocalIndex, msg, 0, SelectedCSBubbleId, 0, -1);
                }
            }
            //if(msg.Contains("Sussurra"))
            //{
            //    msg.Remove(8);
            //    Connection.SendToClientAsync(In.RoomUserWhisper, LocalIndex, "Sussurra " + msg, 0, bubbleid, 0, -1);
            //    e.IsBlocked = true;

            //}
        }





        private void RoomUserStartSpeaking(DataInterceptedEventArgs Packet)
        {
            string message = Packet.Packet.ReadString();
            int bubbleId = Packet.Packet.ReadInteger();

            string whisperTarget = null;
            if (Packet.Packet.Header == Out.RoomUserWhisper)
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
                bubbleId = Debug;
            }

            Packet.IsBlocked = true;
            if (!ForceChatSpeak)
            {
                replacement = new HMessage(Packet.Packet.Header, message, bubbleId);
            }
            else
            {
                if (ForceNormalSpeak)
                {
                    replacement = new HMessage(Out.RoomUserTalk, " " + message, bubbleId);
                }
                else if (ForceShoutChat)
                {
                    replacement = new HMessage(Out.RoomUserShout, " " + message, bubbleId);
                }
                else if (ForceWhisperChat)
                {
                    replacement = new HMessage(Out.RoomUserWhisper, " " + message, bubbleId);
                }
            }


            if (Packet.Packet.Readable > 0)
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


        private HMessage FloodMessageBuilder()
        {
            string FloodMessage;

            if (AntiBobbaFilter)
            {
                FloodMessage = BypassFilter(FlooderText);
            }
            else
            {
                FloodMessage = FlooderText;
            }

            if (UseSelectedBubbleServerSide)
            {
                FloodMessageBubble = SelectedSSBubbleId;
            }
            else
            {
                FloodMessageBubble = 18;
            }

            if (RainbowChatEnabled)
            {
                int Debug = GetRainbowBubbleint();
                FloodMessageBubble = Debug;
            }
            if (!ForceChatSpeak)
            {
                FloodMessageBuild = new HMessage(Out.RoomUserTalk, FloodMessage, ChatMessageBubble);
            }
            else
            {
                if (ForceNormalSpeak)
                {
                    FloodMessageBuild = new HMessage(Out.RoomUserTalk, FloodMessage, ChatMessageBubble);
                }
                else if (ForceShoutChat)
                {
                    FloodMessageBuild = new HMessage(Out.RoomUserShout, FloodMessage, ChatMessageBubble);
                }
                else if (ForceWhisperChat)
                {
                    FloodMessageBuild = new HMessage(Out.RoomUserWhisper, FloodMessage, ChatMessageBubble);
                }
            }

            return FloodMessageBuild;
        }


        private HMessage ChatMessageBuilder()
        {
            string ChatMessage;

            if (AntiBobbaFilter)
            {
                ChatMessage = BypassFilter(ChatMessageText);
            }
            else
            {
                ChatMessage = ChatMessageText;
            }

            if (UseSelectedBubbleServerSide)
            {
                ChatMessageBubble = SelectedSSBubbleId;
            }
            else
            {
                ChatMessageBubble = 18;
            }

            if (RainbowChatEnabled)
            {
                int Debug = GetRainbowBubbleint();
                ChatMessageBubble = Debug;
            }
            if (!ForceChatSpeak)
            {
                ChatMessageBuild = new HMessage(Out.RoomUserTalk, ChatMessage, ChatMessageBubble);
            }
            else
            {
                if (ForceNormalSpeak)
                {
                    ChatMessageBuild = new HMessage(Out.RoomUserTalk, ChatMessage, ChatMessageBubble);
                }
                else if (ForceShoutChat)
                {
                    ChatMessageBuild = new HMessage(Out.RoomUserShout, ChatMessage, ChatMessageBubble);
                }
                else if (ForceWhisperChat)
                {
                    ChatMessageBuild = new HMessage(Out.RoomUserWhisper, ChatMessage, ChatMessageBubble);
                }
            }
            return ChatMessageBuild;
        }


        private void StartFloodThread()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    if (FlooderEnabled)
                    {
                        Thread.Sleep(FlooderCooldown);
                        Connection.SendToServerAsync(FloodMessageBuilder());
                        Thread.Sleep(100);
                    }

                } while (FlooderEnabled);
            }).Start();
        }




        private void FloodBtn_Click(object sender, EventArgs e)
        {
            if (FlooderEnabled)
            {
                WriteToButton(FloodBtn, "Flooder : OFF");
                FlooderEnabled = false;
            }
            else
            {
                WriteToButton(FloodBtn, "Flooder : ON");
                FlooderEnabled = true;
                StartFloodThread();
            }
        }



        private void CloneUserSpeakBtn_Click(object sender, EventArgs e)
        {
            if (isRaidMode)
            {
                WriteToButton(CloneUserSpeakBtn, "Clone User Speak : OFF");
                isRaidMode = false;
            }
            else
            {

                WriteToButton(CloneUserSpeakBtn, "Clone User Speak : ON");
                isRaidMode = true;
                if(!IsRaidModeAlertDone)
                {
                    Connection.SendToClientAsync(In.RoomUserWhisper, 0, "CAUTION: This can result in a ban of the account! Use with caution!", 0, 34, 0, -1);
                    IsRaidModeAlertDone = true;
                }

            }

        }

        public void OnRoomUserStartTyping(DataInterceptedEventArgs e)
        {
            e.IsBlocked = HideSpeakingBubble;

        }


        private void FindUserIndex(string username)
        {
            MainUserIndex = users.Values.FirstOrDefault(e => e.Name == username).Index;
        }

        private void FindIndexBtn_click(object sender, EventArgs e)
        {
            FindUserIndex(CloneUsernameFilter);
        }

        public void InFloorItemUpdate(DataInterceptedEventArgs e)
        {
        }

        private void SendMessageBtn_Click(object sender, EventArgs e)
        {
            Connection.SendToServerAsync(ChatMessageBuilder());
        }
    }
}