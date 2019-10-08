using System.ComponentModel;

using RetroFun.Pages;
using RetroFun.Controls;
using Sulakore.Communication;
using Sulakore.Modules;
using System.Collections.Generic;
using RetroFun.Subscribers;

namespace RetroFun
{
    [DesignerCategory("Form")]
    [Module("RetroFun", "Miscellaneous stuff for retroservers")]
    [Author("marcocorriero")]
    public partial class MainFrm : ObservableExtensionForm
    {
        public override bool IsRemoteModule => true;

        public bool IsAlwaysOnTop
        {
            get => TopMost;
            set
            {
                TopMost = value;
                RaiseOnPropertyChanged();
            }
        }

        private List<ISubscriber> _subscribers = new List<ISubscriber>();

        public MainFrm()
        {
            // Must be set before initializing components.
            Program.Master = this;
            InitializeComponent();

            //Pages sharing events
            _subscribers = new List<ISubscriber>
            {
                DicePg,
                AutoHoloDicePg,
                BuyFurniBruteforcerPg,
                GiftEditorPg,
                MiscellaneousPg,
            };

            Bind(AlwaysOnTopChbx, "Checked", nameof(IsAlwaysOnTop));
        }

        public override void HandleOutgoing(DataInterceptedEventArgs e)
        {
            int id = e.Packet.Header;
            foreach (var sub in _subscribers)
            {
                if (!sub.IsReceiving) continue;

                if (Out.TriggerDice == id || Out.CloseDice == id)
                    sub.OnOutDiceTrigger(e);
                 else if (Out.RoomUserWalk == id)
                    sub.OnOutUserWalk(e);
            }
        }

        public override void HandleIncoming(DataInterceptedEventArgs e)
        {
            int id = e.Packet.Header;
            foreach (var sub in _subscribers)
            {
                if (!sub.IsReceiving) continue;

                if (In.PurchaseOK == id)
                    sub.InPurchaseOk(e);
            }
        }

    }
}