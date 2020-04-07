using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetroFun.Controls;
using Sulakore.Protocol;
using Sulakore.Communication;
using Sulakore.Components;
using System.Threading;
using RetroFun.Subscribers;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class PersonalPage : ObservablePage, ISubscriber
    {
        HMessage Permissions;

        private bool HasUserPermissionsMessage;
        private bool _HasModToolsUnlocked;
        private bool IsInterceptTradeUserOn;
        private bool TradeSpammerActivated;




        public bool HasModToolsUnlocked
        {
            get => _HasModToolsUnlocked;
            set
            {
                _HasModToolsUnlocked = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _HasStaffPermissions;

        public bool HasStaffPermissions
        {
            get => _HasStaffPermissions;
            set
            {
                _HasStaffPermissions = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _CreditsChecked = true;

        private bool _CrystalsChecked = true;
        public bool CrystalsChecked
        {
            get => _CrystalsChecked;
            set
            {
                _CrystalsChecked = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool CreditsChecked
        {
            get => _CreditsChecked;
            set
            {
                _CreditsChecked = value;
                RaiseOnPropertyChanged();
            }
        }


        private bool _DucketsChecked = true;

        public bool DucketsChecked
        {
            get => _DucketsChecked;
            set
            {
                _DucketsChecked = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _CreditsValue = int.MaxValue;

        private int _CrystalsValue = int.MaxValue;
        public int CrystalsValue
        {
            get => _CrystalsValue;
            set
            {
                _CrystalsValue = value;
                RaiseOnPropertyChanged();
            }
        }






        private int _TradeSpammerUserID;
        public int TradeSpammerUserID
        {
            get => _TradeSpammerUserID;
            set
            {
                _TradeSpammerUserID = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _TradeSpammerCooldown;
        public int TradeSpammerCooldown
        {
            get => _TradeSpammerCooldown;
            set
            {
                _TradeSpammerCooldown = value;
                RaiseOnPropertyChanged();
            }
        }



        public int CreditsValue
        {
            get => _CreditsValue;
            set
            {
                _CreditsValue = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _DucketsValue = int.MaxValue;

        public int DucketsValue
        {
            get => _DucketsValue;
            set
            {
                _DucketsValue = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _BlockBypassers;

        public bool BlockBypassers
        {
            get => _BlockBypassers;
            set
            {
                _BlockBypassers = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _AutomaticAttempt;

        public bool AutomaticAttempt
        {
            get => _AutomaticAttempt;
            set
            {
                _AutomaticAttempt = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool IsReceiving => true;

        public PersonalPage()
        {
            InitializeComponent();
            Bind(CreditsChbx, "Checked", nameof(CreditsChecked));
            Bind(CrystalsChbx, "Checked", nameof(CrystalsChecked));
            Bind(DucketsChbx, "Checked", nameof(DucketsChecked));

            Bind(CreditsNbx, "Value", nameof(CreditsValue));
            Bind(CrystalsNbx, "Value", nameof(CrystalsValue));
            Bind(DucketsNbx, "Value", nameof(DucketsValue));
            Bind(UserIntUpDwn, "Value", nameof(TradeSpammerUserID));
            Bind(TradeSpammerCooldownNbx, "Value", nameof(TradeSpammerCooldown));

            if (Program.Master != null)
            {
                Triggers.InAttach(In.UserPermissions, CloneDefaultUserPermissions);
                Triggers.InAttach(In.TradeStopped, PreventCrashOnTrade);

                Triggers.OutAttach(Out.TradeStart, InterceptTradeUser);

                Triggers.InAttach(In.GenericErrorMessages, AntiRoomUnload);
                Triggers.InAttach(In.RoomAccessDenied, AntiRoomUnload);
                Triggers.InAttach(In.HotelView, AntiRoomUnload);
                Triggers.InAttach(In.RoomOpen, DoorbellBypasser);
            }


        }



        public void AntiRoomUnload(DataInterceptedEventArgs e)
        {
            e.IsBlocked = BlockBypassers;
        }


        public void DoorbellBypasser(DataInterceptedEventArgs e)
        {
            if (AutomaticAttempt)
            {
                RoomBypass();
            }
        }

        private void CloneDefaultUserPermissions(DataInterceptedEventArgs e)
        {
            if (!HasUserPermissionsMessage)
            {
                Permissions = e.Packet;
                HasUserPermissionsMessage = true;
            }
        }

        private void InterceptTradeUser(DataInterceptedEventArgs e)
        {
            if (IsInterceptTradeUserOn)
            {
                TradeSpammerUserID = e.Packet.ReadInteger();
                TradeSpammerspeak("Victim ID Found!");
                IsInterceptTradeUserOn = false;
                e.IsBlocked = true;
            }

        }


        private void PreventCrashOnTrade(DataInterceptedEventArgs e)
        {
                e.IsBlocked = TradeSpammerActivated;
        }


        private void EnableModToolsBtn_Click(object sender, EventArgs e)
        {
            ManageModTools();
        }

        private void AcquireMODPermissionsBtn_Click(object sender, EventArgs e)
        {
            ManageModPermissions();
        }

        private void ManageModPermissions()
        {
            if(HasStaffPermissions)
            {
                if (HasUserPermissionsMessage)
                {
                    Speak("Your Normal permissions have been restored.");
                    Connection.SendToClientAsync(Permissions);
                }
                else
                {
                    Speak("Default permissions have been restored.");
                    Connection.SendToClientAsync(In.UserPermissions, 2, 4, false);
                    WriteToButton(AcquireMODPermissionsBtn, "Acquire MOD Permissions (CS)");
                }
                HasStaffPermissions = false;
            }
            else
            {
                Speak("Permissions set to Staff.");
                Connection.SendToClientAsync(In.UserPermissions, int.MaxValue, int.MaxValue, false);
                WriteToButton(AcquireMODPermissionsBtn, "Remove MOD Permissions (CS)");
                HasStaffPermissions = true;

            }
        }

        private void Speak(string text)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Personal]: " + text, 0, 34, 0, -1);
            }
        }


        private void WriteToButton(SKoreButton button, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Text = text;
            });
        }


        private void ManageModTools()
        {
            if(HasModToolsUnlocked)
            {
                SendPacketModTools(false);
                HasModToolsUnlocked = false;
                WriteToButton(EnableModToolsBtn, "Show Mod Tools (CS)");
            }
            else
            {
                SendPacketModTools(true);
                HasModToolsUnlocked = true;
                WriteToButton(EnableModToolsBtn, "Hide Mod Tools (CS)");
            }
        }


        private void SendPacketModTools(bool value)
        {
            Connection.SendToClientAsync(In.ModTool, new object[]
                {
                0,
                0,
                0,
                value,
                value,
                value,
                value,
                value,
                value,
                value,
                0
});
        }

        private void SetCurrencyBtn_Click(object sender, EventArgs e)
        {
            SetCurrencyOnClient();
        }

        private void SetCurrencyOnClient()
        {

            if(CreditsChecked)
            {
                SetCredits(CreditsValue);
            }
            if(CrystalsChecked)
            {
                SetCrystals(CrystalsValue, DucketsValue);

            if (DucketsChecked)
            {
                    SetDuckets(DucketsValue);
            }
        }
    }

        private void SetCrystals(int crystals, int duckets)
        {
            Connection.SendToClientAsync(In.UserCurrency, new object[]
       {
                        11,
                        0,
                        duckets,
                        1,
                        0,
                        2,
                        0,
                        3,
                        0,
                        4,
                        0,
                        5,
                        crystals,
                        101,
                        0,
                        102,
                        0,
                        103,
                        0,
                        104,
                        0,
                        105,
                        0
       });
        }

        private void SetDuckets(int Duckets)
        {
            Connection.SendToClientAsync(In.UserPoints, Duckets + ".0");
        }

        private void SetCredits(int Credits)
        {
            Connection.SendToClientAsync(In.UserCredits, CreditsValue + ".0");
        }



        private void StartTradeSpammer()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    if (TradeSpammerActivated)
                    {
                        Connection.SendToServerAsync(Out.TradeStart, TradeSpammerUserID);
                        Thread.Sleep(TradeSpammerCooldown);
                        Connection.SendToServerAsync(Out.TradeClose);
                        Thread.Sleep(TradeSpammerCooldown);
                    }
                } while (TradeSpammerActivated);
            }).Start();
        }




        private void RequestRoomHeightmap()
        {
            Connection.SendToServerAsync(Out.RequestRoomHeightmap);
        }

        private void CrashUserBtn_Click(object sender, EventArgs e)
        {
            if(TradeSpammerActivated)
            {
                WriteToButton(CrashUserBtn, "Spam Trade : OFF"); 
                TradeSpammerActivated = false;
            }
            else
            {
                WriteToButton(CrashUserBtn, "Spam Trade : ON");
                TradeSpammerActivated = true;
                StartTradeSpammer();
            }
        }

        private void CaptureTradeUserBtn_Click(object sender, EventArgs e)
        {
            TradeSpammerspeak("Please trade once with the victim to intercept his Trade user ID.");
            IsInterceptTradeUserOn = true;
        }

        private void TradeSpammerspeak(string text)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Trade Spammer]: " + text, 0, 34, 0, -1);
            }
        }

        private void EnterRoomBtn_Click(object sender, EventArgs e)
        {
            RequestRoomHeightmap();

        }

        private void AutomaticBypassBtn_Click(object sender, EventArgs e)
        {
            if (AutomaticAttempt)
            {
                WriteToButton(AutomaticBypassBtn, "Automatic: OFF");
                AutomaticAttempt = false;
            }
            else
            {
                WriteToButton(AutomaticBypassBtn, "Automatic: ON");
                AutomaticAttempt = true;
            }
        }

        public void OnOutDiceTrigger(DataInterceptedEventArgs e)
        {

        }

        public void OnOutUserRequestBadge(DataInterceptedEventArgs e)
        {

        }

        public void OnUserFriendRemoval(DataInterceptedEventArgs e)
        {

        }

        public void OnRequestRoomLoad(DataInterceptedEventArgs e)
        {
            //if (AutomaticAttempt)
            //{
            //    RoomBypass();
            //    WriteToButton(AutomaticBypassBtn, "Automatic: OFF");
            //    AutomaticAttempt = false;
            //}
        }


        private async void RoomBypass()
        {
            await Task.Delay(200);
            await Connection.SendToServerAsync(Out.RequestRoomHeightmap);
            WriteToButton(AutomaticBypassBtn, "Automatic: OFF");
            AutomaticAttempt = false;
        }

        public void OnLatencyTest(DataInterceptedEventArgs e)
        {

        }

        public void OnUsername(DataInterceptedEventArgs e)
        {

        }

        public void OnRoomUserWalk(DataInterceptedEventArgs e)
        {

        }

        public void OnCatalogBuyItem(DataInterceptedEventArgs e)
        {

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

        public void OnRoomUserStartTyping(DataInterceptedEventArgs e)
        {

        }

        public void InPurchaseOk(DataInterceptedEventArgs e)
        {

        }

        public void InRoomUserLeft(DataInterceptedEventArgs e)
        {

        }

        public void InUserEnterRoom(DataInterceptedEventArgs e)
        {

        }

        public void InUserProfile(DataInterceptedEventArgs e)
        {

        }

        public void InItemExtraData(DataInterceptedEventArgs e)
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

        private void BlockRestrictionsBtn_Click(object sender, EventArgs e)
        {
            if(BlockBypassers)
            {
                WriteToButton(BlockRestrictionsBtn, "Block Restrictions : OFF");
                BlockBypassers = false;

            }
            else
            {
                WriteToButton(BlockRestrictionsBtn, "Block Restrictions : ON");
                BlockBypassers = true;
            }
        }
    }
}
