using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class StalkingPage : ObservablePage, ISubscriber
    {
        private readonly Victim[] _victims = new[]
        {
            new Victim("Bot-giochi", 1442790),
            new Victim("gar0u", 1615824),
            new Victim("I.P.S", 1361879),
            new Victim(":Heidi:", 1569371),
            new Victim(":HEIDI:: (i.p.s)", 1608565),
            new Victim("Servedio (i.p.s)", 1224246)
        };


        private bool isUserManualWalking;

        private bool _isBotGiochiStalked;

        public bool isSpectatorModeActive
        {
            get => _isBotGiochiStalked;
            set
            {
                _isBotGiochiStalked = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _UserIDCapture;

        public int UserIDCapture
        {
            get => _UserIDCapture;
            set
            {
                _UserIDCapture = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _CooldownWalking = 11;

        public int CooldownWalking
        {
            get => _CooldownWalking;
            set
            {
                _CooldownWalking = value;
                RaiseOnPropertyChanged();
            }
        }


        private bool _ShouldCaptureIDMode;

        public bool ShouldCaptureIDMode
        {
            get => _ShouldCaptureIDMode;
            set
            {
                _ShouldCaptureIDMode = value;
                RaiseOnPropertyChanged();
            }
        }


        private bool _ShouldStalkBotGiochi;

        public bool ShouldStalkBotGiochi
        {
            get => _ShouldStalkBotGiochi;
            set
            {
                _ShouldStalkBotGiochi = value;
                RaiseOnPropertyChanged();
            }
        }
        private bool _ShouldExitDirectlyOnGames;

        public bool ShouldExitDirectlyOnGames
        {
            get => _ShouldExitDirectlyOnGames;
            set
            {
                _ShouldExitDirectlyOnGames = value;
                RaiseOnPropertyChanged();
            }
        }

            private bool _ShouldSpamRandomCoords;

        public bool ShouldSpamRandomCoords
        {
            get => _ShouldSpamRandomCoords;
            set
            {
                _ShouldSpamRandomCoords = value;
                RaiseOnPropertyChanged();
            }
        }





        public StalkingPage()
        {
            InitializeComponent();

            VictimsCmbx.Items.AddRange(_victims);
            VictimsCmbx.SelectedIndex = 0;
            Bind(InterceptVictimIDChbx, "Checked", nameof(ShouldCaptureIDMode));
            Bind(Stalkbotgamescheckbx, "Checked", nameof(ShouldStalkBotGiochi));
            Bind(SpamWalkChb, "Checked", nameof(ShouldSpamRandomCoords));

            Bind(SpectatorChbx, "Checked", nameof(ShouldExitDirectlyOnGames));

            
            Bind(IdOfVictimNbx, "Value", nameof(UserIDCapture));
            Bind(CooldownFloodNbx, "Value", nameof(CooldownWalking));

            if (Program.Master != null)
            {
                Triggers.InAttach(In.ReceivePrivateMessage, CheckifIsBotGiochi);
                Triggers.OutAttach(Out.RequestRoomData, RoomDataRequest);
            }
        }

        public bool IsReceiving => true;




        private async void StartRandomWalk()
        {
            try
            {
                CancellationTokenSource source = new CancellationTokenSource();

                for (int i = 0; i < 150; i++)
                {
                    for (int j = 0; j < 150; i++)
                    {
                        if (ShouldSpamRandomCoords)
                        {
                            if (!isUserManualWalking)
                            {
                                if (Connection.Remote.IsConnected)
                                {
                                    await Connection.SendToServerAsync(Out.RoomUserWalk, i, j);
                                    await Task.Delay(CooldownWalking);
                                }
                            }
                            else
                            {
                                i = 150;
                                j = 150;
                                source.Cancel();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }
        }




        public void InRoomData(DataInterceptedEventArgs e)
        {
            isUserRandomWalking();
        }

        public void RoomDataRequest(DataInterceptedEventArgs e)
        {
            isUserSpectatorMode();
        }

        private async void isUserSpectatorMode()
        {
            if (ShouldExitDirectlyOnGames)
            {
                if (isSpectatorModeActive)
                {
                   await  Connection.SendToServerAsync(Out.RoomUserTalk, "exit", 18);
                    isSpectatorModeActive = false;
                }
            }
        }

        private void isUserRandomWalking()
        {
            if (ShouldSpamRandomCoords)
            {
                isUserManualWalking = false;
                StartRandomWalk();
            }
        }

        public void OnRequestRoomLoad(DataInterceptedEventArgs e)
        {
        }

        public void InRoomUserLeft(DataInterceptedEventArgs e)
        {
        }

        public void OnCatalogBuyItem(DataInterceptedEventArgs e)
        {
        }

        public void InUserEnterRoom(DataInterceptedEventArgs e)
        {
        }

        public void InPurchaseOk(DataInterceptedEventArgs e)
        {
        }
        public void OnLatencyTest(DataInterceptedEventArgs e)
        {
        }
        public void OnUsername(DataInterceptedEventArgs e)
        {
        }
        public void InUserProfile(DataInterceptedEventArgs e)
        {
        }

        public void OnOutDiceTrigger(DataInterceptedEventArgs e)
        {
        }
        public void OnRoomUserStartTyping(DataInterceptedEventArgs e)
        {
        }

        public void OnUserFriendRemoval(DataInterceptedEventArgs e)
        {
        }

        public void OnRoomUserWalk(DataInterceptedEventArgs e)
        {
            isUserManualWalking = true;
        }

        public void InItemExtraData(DataInterceptedEventArgs e)
        {
        }

        public void InFloorItemUpdate(DataInterceptedEventArgs e)
        {
        }

        public void OnOutUserRequestBadge(DataInterceptedEventArgs e)
        {
            if (ShouldCaptureIDMode)
            {
                int UserID = e.Packet.ReadInteger();
                UserIDCapture = UserID;
                ShouldCaptureIDMode = false;
            }
        }

        private void CheckifIsBotGiochi(DataInterceptedEventArgs obj)
        {
            if (ShouldStalkBotGiochi)
            {
                int UserID = obj.Packet.ReadInteger();
                if (UserID == 1442790)
                {
                    if (ShouldExitDirectlyOnGames)
                    {
                        isSpectatorModeActive = true;
                    }
                    if (Connection.Remote.IsConnected)
                    {
                        Connection.SendToServerAsync(Out.StalkFriend, 1442790);
                    }
                }
            }
        }

        private void StalkVictimBtn_Click(object sender, EventArgs e)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToServerAsync(Out.StalkFriend, ((Victim)VictimsCmbx.SelectedItem).ID);
            }
        }

        private class Victim
        {
            public int ID { get; }
            public string Name { get; }

            public Victim(string name, int id)
            {
                ID = id;
                Name = name;
            }

            public override string ToString() => $"{Name} [#{ID}]";
        }

        private void StalkVictimID_Click(object sender, EventArgs e)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToServerAsync(Out.StalkFriend, UserIDCapture);
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
    }
}