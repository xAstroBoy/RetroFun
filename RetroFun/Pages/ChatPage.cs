using RetroFun.Controls;
using RetroFun.Properties;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Components;
using Sulakore.Habbo;
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
    public partial class ChatPage : ObservablePage
    {
        private HMessage replacement;
        private HMessage ChatMessageBuild;
        private HMessage FloodMessageBuild;
        private HMessage PyramidChatBuild;

        private string OldPyramidString = string.Empty;

        private bool isCloneChatUser;
        private bool isCloneChatAlertDone;

        private readonly int[] rainbowlist = new int[] { 3, 4, 5, 6, 7, 11, 12, 13, 14, 15, 18 };
        private readonly string[] knowncommands = new string[] { "pickall", "setspeed", "reload", "disablediagonal", "setmax", "override", "tele", "teleport", "tp", "refresh_catalogue", "refreshcata", "roomalert", "coords", "coins", "credits", "givecoins", "pixels ", "givepixels ", "handitem ", "ha", "hotelalert", "freeze", "buyx", "enable", "roommute", "masscredits", "globalcredits", "openroom", "roombadge", "massbadge", "language", "userinfo", "halbug", "dumpmaps", "givebadge", "invisible", "ban", "disconnect", "dc", "superban", "langban", "roomkick", "mutam", "unmute", "alert", "cacciam", "unban", "geefbelcredits", "givecrystals", "deletemission", "hai", "hal", "setchatlog", "aprilpt", "inisondaggio", "discomode", "ghal", "gpok", "apripok", "comeall", "commands", "faq", "info", "about", "enablestatus", "disablefriends", "enablefriends", "disabletrade", "enabletrade", "mordi", "wheresmypet", "wheresmypets", "whereismypets", "powerlevels", "forcerot", "seteffect", "empty", "whosonline", "stalk", "follow", "warp", "lay", "sit", "come", "moonwalk", "push", "pull", "copylook", "fly", "placex", "placecircle", "placesquare", "staffalert", "smallban", "danceid", "domanda", "chiudidadi", "vota", "terminavoto" };
        public int Bubbleused { get => GlobalInts.Selected_bubble_ID; set { GlobalInts.Selected_bubble_ID = value; RaiseOnPropertyChanged(); } }

        //private int oldrainbowbubble;
        //private int newrainbowselected;

        private string SelectedColorChat = "@red@";
        private Random rand = new Random();



        private bool isLiveEditChat;
        private bool _FlooderEnabled;

        private int ChatMessageBubble;

        private int FloodMessageBubble;

        private int PyramidMessageBubble;

        public bool FlooderEnabled
        {
            get => _FlooderEnabled;
            set
            {
                _FlooderEnabled = value;
                RaiseOnPropertyChanged();
            }
        }

        private readonly ChatColors[] _ComicTextColor = new[]
{
           new ChatColors(Color.Red, "Red" , "@red@"),
           new ChatColors(Color.Green, "Green" , "@green@"),
           new ChatColors(Color.Purple, "Purple" , "@purple@"),
           new ChatColors(Color.Blue, "Blue" , "@blue@"),
           new ChatColors(Color.Cyan, "Cyan" , "@cyan@"),
        };

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


        private int _TargetUserIndex = 0;

        public int TargetUserIndex
        {
            get => _TargetUserIndex;
            set
            {
                _TargetUserIndex = value;
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


        private bool _EditPacketChat;

        public bool EditPacketChat
        {
            get => _EditPacketChat;
            set
            {
                _EditPacketChat = value;
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


        private bool _ColorizeText;

        public bool ColorizeText
        {
            get => _ColorizeText;
            set
            {
                _ColorizeText = value;
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

        public string UsernameFilter { get => GlobalStrings.UserDetails_Username; }




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

        public int SelectedSSBubbleId { get; private set; }
        public int SelectedCSBubbleId { get; private set; }



        
        public ChatPage()
        {
            InitializeComponent();

            ChatColorComboBox.Items.AddRange(_ComicTextColor);
            ChatColorComboBox.SelectedIndex = 0;

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
            Bind(EditChatPacketsChbx, "Checked", nameof(EditPacketChat));

            Bind(TextFloodPhraseBox, "Text", nameof(FlooderText));
            Bind(CooldownFloodNbx, "Value", nameof(FlooderCooldown));
            Bind(TargetUserTxb, "Text", nameof(CloneUsernameFilter));
            Bind(IndexNbx, "Value", nameof(TargetUserIndex));
            Bind(CooldownCloneUserChatNbx, "Value", nameof(RaidUserCooldownCooldown));
            Bind(ChatMsgTxb, "Text", nameof(ChatMessageText));
            Bind(SetTextColorChbx, "Checked", nameof(ColorizeText));


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


        public override void Out_RoomUserTalk(DataInterceptedEventArgs e)
        {
            EditUserChatPacket(e);
        }

        public override void Out_RoomUserShout(DataInterceptedEventArgs e)
        {
            EditUserChatPacket(e);
        }

        public override void Out_RoomUserWhisper(DataInterceptedEventArgs e)
        {
            EditUserChatPacket(e);
        }


        public override void In_RoomUserTalk(DataInterceptedEventArgs e)
        {
            int index = e.Packet.ReadInteger();
            string msg = e.Packet.ReadString();
            e.Packet.ReadInteger();
            int bubbleid = e.Packet.ReadInteger();
            if (UseSelectedBubbleClientSide)
            {
                if (index == GlobalInts.OwnUser_index)
                {
                    e.IsBlocked = true;
                    _ = SendToClient(In.RoomUserTalk, GlobalInts.OwnUser_index, msg, 0, SelectedCSBubbleId, 0, -1);
                }
            }
            if (isCloneChatUser)
            {
                if (index == TargetUserIndex)
                {
                    ConvertCSChatTalk(msg, bubbleid);
                }
            }
        }
        private async void ConvertCSChatTalk(string message, int bubbleid)
        {
            await Task.Delay(RaidUserCooldownCooldown);

               await  SendToServer(Out.RoomUserTalk, " " + message, bubbleid);
            return;
        }

        private async void ConvertCSChatShout(string message, int bubbleid)
        {
            await Task.Delay(RaidUserCooldownCooldown);

               await  SendToServer(Out.RoomUserTalk, " " + message, bubbleid);
            return;
        }


        public override void  In_RoomUserShout(DataInterceptedEventArgs e)
        {
            int index = e.Packet.ReadInteger();
            string msg = e.Packet.ReadString();
            e.Packet.ReadInteger();
            int bubbleid = e.Packet.ReadInteger();

            if (UseSelectedBubbleClientSide)
            {
                if (index == GlobalInts.OwnUser_index)
                {
                    e.IsBlocked = true;
                    _ = SendToClient(In.RoomUserShout, GlobalInts.OwnUser_index, msg, 0, SelectedCSBubbleId, 0, -1);
                }
            }

            if (isCloneChatUser)
            {
                if (index == TargetUserIndex)
                {
                    ConvertCSChatShout(msg, bubbleid);
                }
            }
        }

        public override void In_RoomUserWhisper(DataInterceptedEventArgs e)
        {
            int index = e.Packet.ReadInteger();
            string msg = e.Packet.ReadString();
            e.Packet.ReadInteger();
            int bubbleid = e.Packet.ReadInteger();

            if (UseSelectedBubbleClientSide)
            {
                if (index == GlobalInts.OwnUser_index)
                {
                    e.IsBlocked = true;
                    _ = SendToClient(In.RoomUserWhisper, GlobalInts.OwnUser_index, msg, 0, SelectedCSBubbleId, 0, -1);
                }
            }
        }





        private void EditUserChatPacket(DataInterceptedEventArgs Packet)
        {
            string message = Packet.Packet.ReadString();
            int bubbleId = Packet.Packet.ReadInteger();

            string whisperTarget = null;

            if (Bubbleused != bubbleId)
            {
                Bubbleused = bubbleId;
            }

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
                if(!ColorizeText)
                {
                    message = whisperTarget + " " + message;
                }
                else
                {
                    message = whisperTarget + " " + SelectedColorChat + " " + message;
                }
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
                if (!ColorizeText)
                {
                    replacement = new HMessage(Packet.Packet.Header, message, bubbleId);
                }
                else
                {
                    if (!(Packet.Packet.Header == Out.RoomUserWhisper))
                    {
                        if (!knowncommands.Any(s => message.StartsWith(":" + s)))
                        {
                            replacement = new HMessage(Packet.Packet.Header, SelectedColorChat + " " + message, bubbleId);
                        }
                        else
                        {
                            replacement = new HMessage(Packet.Packet.Header, message, bubbleId);
                        }
                    }
                    else
                    {
                        replacement = new HMessage(Packet.Packet.Header,  message, bubbleId);
                    }
                }
            }
            else
            {
                if (!ColorizeText)
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
                else
                {
                    if (ForceNormalSpeak)
                    {
                        replacement = new HMessage(Out.RoomUserTalk, SelectedColorChat + " " + message, bubbleId);
                    }
                    else if (ForceShoutChat)
                    {
                        replacement = new HMessage(Out.RoomUserShout, SelectedColorChat + " " + message, bubbleId);
                    }
                    else if (ForceWhisperChat)
                    {
                        replacement = new HMessage(Out.RoomUserWhisper, SelectedColorChat + " " + message, bubbleId);
                    }
                }
            }


            if (Packet.Packet.Readable > 0)
            {
                replacement.WriteInteger(0);
            }

                _ = SendToServer(replacement);
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


        private HMessage PyramidChatBuilder()
        {
            string PyramidChatText;
            if (FlooderText != null)
            {
                if (AntiBobbaFilter)
                {
                    PyramidChatText = BypassFilter(FlooderText);
                }
                else
                {
                    PyramidChatText = FlooderText;
                }

                if (UseSelectedBubbleServerSide)
                {
                    PyramidMessageBubble = SelectedSSBubbleId;
                }
                else
                {
                    PyramidMessageBubble = Bubbleused;
                }

                if (RainbowChatEnabled)
                {
                    int Debug = GetRainbowBubbleint();
                    PyramidMessageBubble = Debug;
                }


                if (!ForceChatSpeak)
                {
                    if (!ColorizeText)
                    {
                        PyramidChatBuild = new HMessage(Out.RoomUserTalk, PyramidChatText, PyramidMessageBubble);
                    }
                    else
                    {
                        PyramidChatBuild = new HMessage(Out.RoomUserTalk, SelectedColorChat +  " " + PyramidChatText, PyramidMessageBubble);
                    }
                }
                else
                {
                    if (!ColorizeText)
                    {
                        if (ForceNormalSpeak)
                        {
                            PyramidChatBuild = new HMessage(Out.RoomUserTalk, PyramidChatText, ChatMessageBubble);
                        }
                        else if (ForceShoutChat)
                        {
                            PyramidChatBuild = new HMessage(Out.RoomUserShout, PyramidChatText, ChatMessageBubble);
                        }
                        else if (ForceWhisperChat)
                        {
                            PyramidChatBuild = new HMessage(Out.RoomUserWhisper, PyramidChatText, ChatMessageBubble);
                        }
                    }
                    else
                    {
                        if (ForceNormalSpeak)
                        {
                            PyramidChatBuild = new HMessage(Out.RoomUserTalk, SelectedColorChat +  " " + PyramidChatText, ChatMessageBubble);
                        }
                        else if (ForceShoutChat)
                        {
                            PyramidChatBuild = new HMessage(Out.RoomUserShout, SelectedColorChat +  " " + PyramidChatText, ChatMessageBubble);
                        }
                        else if (ForceWhisperChat)
                        {
                            PyramidChatBuild = new HMessage(Out.RoomUserWhisper, SelectedColorChat +  " " + PyramidChatText, ChatMessageBubble);
                        }
                    }
                    return PyramidChatBuild;
                }
                return PyramidChatBuild;
            }
            return null;
        }


        private HMessage FloodMessageBuilder()
        {
            string FloodMessage;

            if (FlooderText != null)
            {
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
                    FloodMessageBubble = Bubbleused;
                }

                if (RainbowChatEnabled)
                {
                    int Debug = GetRainbowBubbleint();
                    FloodMessageBubble = Debug;
                }

                if (!ForceChatSpeak)
                {
                    if (!ColorizeText)
                    {
                        FloodMessageBuild = new HMessage(Out.RoomUserTalk, FloodMessage, FloodMessageBubble);
                    }
                    else
                    {
                        FloodMessageBuild = new HMessage(Out.RoomUserTalk, SelectedColorChat +  " " + FloodMessage, FloodMessageBubble);
                    }
                }
                else
                {
                    if (!ColorizeText)
                    {
                        if (ForceNormalSpeak)
                        {
                            FloodMessageBuild = new HMessage(Out.RoomUserTalk, FloodMessage, FloodMessageBubble);
                        }
                        else if (ForceShoutChat)
                        {
                            FloodMessageBuild = new HMessage(Out.RoomUserShout, FloodMessage, FloodMessageBubble);
                        }
                        else if (ForceWhisperChat)
                        {
                            FloodMessageBuild = new HMessage(Out.RoomUserWhisper, FloodMessage, FloodMessageBubble);
                        }
                    }
                    else
                    {
                        if (ForceNormalSpeak)
                        {
                            FloodMessageBuild = new HMessage(Out.RoomUserTalk, SelectedColorChat +  " " + FloodMessage, FloodMessageBubble);
                        }
                        else if (ForceShoutChat)
                        {
                            FloodMessageBuild = new HMessage(Out.RoomUserShout, SelectedColorChat +  " " + FloodMessage, FloodMessageBubble);
                        }
                        else if (ForceWhisperChat)
                        {
                            FloodMessageBuild = new HMessage(Out.RoomUserWhisper, SelectedColorChat +  " " + FloodMessage, FloodMessageBubble);
                        }
                    }
                    return FloodMessageBuild;
                }
                return FloodMessageBuild;
            }
            return null;
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
                ChatMessageBubble = Bubbleused;
            }

            if (RainbowChatEnabled)
            {
                int Debug = GetRainbowBubbleint();
                ChatMessageBubble = Debug;
            }
            if (!ForceChatSpeak)
            {
                if (!ColorizeText)
                {
                    ChatMessageBuild = new HMessage(Out.RoomUserTalk, ChatMessage, ChatMessageBubble);
                }
                else
                {
                    ChatMessageBuild = new HMessage(Out.RoomUserTalk, SelectedColorChat +  " " + ChatMessage, ChatMessageBubble);
                }
            }
            else
            {
                if (!ColorizeText)
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
                else
                {
                    if (ForceNormalSpeak)
                    {
                        ChatMessageBuild = new HMessage(Out.RoomUserTalk, SelectedColorChat +  " " + ChatMessage, ChatMessageBubble);
                    }
                    else if (ForceShoutChat)
                    {
                        ChatMessageBuild = new HMessage(Out.RoomUserShout, SelectedColorChat +  " " + ChatMessage, ChatMessageBubble);
                    }
                    else if (ForceWhisperChat)
                    {
                        ChatMessageBuild = new HMessage(Out.RoomUserWhisper, SelectedColorChat +  " " + ChatMessage, ChatMessageBubble);
                    }
                }
            }
            return ChatMessageBuild;
        }
    

        private class ChatColors
        {
            public string Color { get; }
            public Color SelectedTextColor { get; }
            public string selectedchatcolor { get; }

            public ChatColors(Color TextColor , string color, string selectedchat)
            {
                SelectedTextColor = TextColor;
                Color = color;
                selectedchatcolor = selectedchat;
            }
            public override string ToString() => $"{Color}";
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
                            _ = SendToServer(FloodMessageBuilder());
                        Thread.Sleep(100);
                    }

                } while (FlooderEnabled);
            }).Start();
        }


        private void StartPyramidThread()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    if (isLiveEditChat)
                    {
                        Thread.Sleep(FlooderCooldown);
                            if(OldPyramidString != FlooderText)
                            {
                                OldPyramidString = FlooderText;
                                if(PyramidChatBuilder() != null)
                                {
                                    _ = SendToServer(PyramidChatBuilder());
                                }
                            }
                        Thread.Sleep(100);
                    }

                } while (isLiveEditChat);
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
            if (isCloneChatUser)
            {
                WriteToButton(CloneUserSpeakBtn, "Clone User Speak : OFF");
                isCloneChatUser = false;
            }
            else
            {

                WriteToButton(CloneUserSpeakBtn, "Clone User Speak : ON");
                isCloneChatUser = true;
                if(!isCloneChatAlertDone)
                {
                    _ = SendToClient(In.RoomUserWhisper, 0, "CAUTION: This can result in a ban of the account! Use with caution!", 0, 34, 0, -1);
                    isCloneChatAlertDone = true;
                }

            }

        }

        public override void Out_RoomUserStartTyping(DataInterceptedEventArgs e)
        {
            e.IsBlocked = HideSpeakingBubble;
        }




        private void FindIndexBtn_click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(CloneUsernameFilter))
            {
                TargetUserIndex = HentityUtils.FindUserIndexByUsername(CloneUsernameFilter);
            }
        }



        private void SendMessageBtn_Click(object sender, EventArgs e)
        {
                _ = SendToServer(ChatMessageBuilder());
        }

        private void LiveEditChatBtn_Click(object sender, EventArgs e)
        {
            if(isLiveEditChat)
            {
                WriteToButton(LiveEditChatBtn, "Live Edit : OFF");
                isLiveEditChat = false;
            }
            else
            {
                WriteToButton(LiveEditChatBtn, "Live Edit : ON");
                isLiveEditChat = true;
                StartPyramidThread();
            }
        }

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedColorChat = ((ChatColors)ChatColorComboBox.SelectedItem).selectedchatcolor;
        }
    }
}
