using System;
using System.ComponentModel;
using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Communication;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class FakeMessagePage : ObservablePage, ISubscriber
    {

        private bool _ShouldCaptureIDMode = false;
        public bool ShouldCaptureIDMode
        {
            get => _ShouldCaptureIDMode;
            set
            {
                _ShouldCaptureIDMode = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _UserIDCapture = 0;
        public int UserIDCapture
        {
            get => _UserIDCapture;
            set
            {
                _UserIDCapture = value;
                RaiseOnPropertyChanged();
            }
        }

        private string _UserMessage = "";
        public string UserMessage
        {
            get => _UserMessage;
            set
            {
                _UserMessage = value;
                RaiseOnPropertyChanged();
            }
        }



        public FakeMessagePage()
        {
            InitializeComponent();
            Bind(UserIdNbx, "Value", nameof(UserIDCapture));
            Bind(CaptUserIDChbx, "Checked", nameof(ShouldCaptureIDMode));
            Bind(StringMessageTbx, "Text", nameof(UserMessage));
        }

        public bool IsReceiving => true;

        public void InPurchaseOk(DataInterceptedEventArgs e) { }

        public void OnOutDiceTrigger(DataInterceptedEventArgs e) { }

        public void OnUserFriendRemoval(DataInterceptedEventArgs e) { }

        public void OnOutUserRequestBadge(DataInterceptedEventArgs e)
        {
            if (ShouldCaptureIDMode)
            {
                int UserID = e.Packet.ReadInteger();
                UserIDCapture = UserID;
                ShouldCaptureIDMode = false;
            }
        }


        private void SendMessagePacket(int userid, string message)
        {
            Connection.SendToClientAsync(In.ReceivePrivateMessage, userid, message, 0);
        }

        private void SendMessageBtn_Click(object sender, EventArgs e)
        {
            SendMessagePacket(UserIDCapture, UserMessage);
        }
    }
}
