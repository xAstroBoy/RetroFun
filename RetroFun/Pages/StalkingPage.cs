using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Communication;
using System;
using System.ComponentModel;

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

        public StalkingPage()
        {
            InitializeComponent();

            VictimsCmbx.Items.AddRange(_victims);
            VictimsCmbx.SelectedIndex = 0;
            Bind(InterceptVictimIDChbx, "Checked", nameof(ShouldCaptureIDMode));
            Bind(IdOfVictimNbx, "Value", nameof(UserIDCapture));

            if (Program.Master != null)
            {
                Triggers.InAttach(In.ReceivePrivateMessage, CheckifIsBotGiochi);
            }
        }

        public bool IsReceiving => true;

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
        public void inUserProfile(DataInterceptedEventArgs e)
        {
        }

        public void OnOutDiceTrigger(DataInterceptedEventArgs e)
        {
        }

        public void OnUserFriendRemoval(DataInterceptedEventArgs e)
        {
        }

        public void OnRoomUserWalk(DataInterceptedEventArgs e)
        {
        }

        public void InItemExtraData(DataInterceptedEventArgs e)
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
            if (Stalkbotgamescheck.Checked)
            {
                int UserID = obj.Packet.ReadInteger();
                if (UserID == 1442790)
                {
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


    }
}