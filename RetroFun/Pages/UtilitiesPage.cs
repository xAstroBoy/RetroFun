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
using Sulakore.Communication;
using RetroFun.Subscribers;
using Sulakore.Habbo;

namespace RetroFun.Pages
{

    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class UtilitiesPage : ObservablePage
    {



        private bool _CreditMultiplierEnabled;

        public bool CreditMultiplierEnabled
        {
            get => _CreditMultiplierEnabled;
            set
            {
                _CreditMultiplierEnabled = value;
                RaiseOnPropertyChanged();
            }
        }

        private int selectedIndex;


        private int _CreditIDInt = 1;

        public int CreditIDInt
        {
            get => _CreditIDInt;
            set
            {
                _CreditIDInt = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _CreditMultiplierAmount = 1;

        public int CreditMultiplierAmount
        {
            get => _CreditMultiplierAmount;
            set
            {
                _CreditMultiplierAmount = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _CreditExchangeMode;

        public bool CreditExchangeMode
        {
            get => _CreditExchangeMode;
            set
            {
                _CreditExchangeMode = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _GiftExchangeMode;

        public bool GiftExchangeMode
        {
            get => _GiftExchangeMode;
            set
            {
                _GiftExchangeMode = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _GiftInt = 1;

        public int GiftInt
        {
            get => _GiftInt;
            set
            {
                _GiftInt = value;
                RaiseOnPropertyChanged();
            }
        }

        public UtilitiesPage()
        {
            InitializeComponent();

            Bind(ExchangeCreditChbx, "Checked", nameof(CreditExchangeMode));
            Bind(ExchangeMPChbx, "Checked", nameof(CreditMultiplierEnabled));
            Bind(MultiplierNbx, "Value", nameof(CreditMultiplierAmount));
            Bind(CreditsIDNbx, "Value", nameof(CreditIDInt));
            Bind(GiftExchangerIDNBx, "Value", nameof(GiftInt));
            Bind(AutoGiftExchangerBtn, "Checked", nameof(GiftExchangeMode));

            if (Program.Master != null)
            {
                Triggers.OutAttach(Out.RoomPlaceItem, RoomPlaceItemsHandler);
            }


        }



        private async void SendExchangePacket(int furniid)
        {
            await Task.Delay(350);
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToServerAsync(Out.RedeemItem, furniid);
            }
            await Task.Delay(50);
        }



        private void RoomPlaceItemsHandler(DataInterceptedEventArgs e)
        {
            if (CreditExchangeMode)
            {
                CreditIDInt = int.Parse(e.Packet.ReadString().Split(' ')[0]);
                HandleCreditsExchanger(CreditIDInt);
            }
            if (GiftExchangeMode)
            {
                GiftInt = int.Parse(e.Packet.ReadString().Split(' ')[0]);
                HandleGiftExchanger(GiftInt);
            }
        }

        private void HandleGiftExchanger(int furniid)
        {
            SendOpenGiftPacket(furniid);
        }

        private void HandleCreditsExchanger(int furniid)
        {
            if (!CreditMultiplierEnabled)
            {
                SendExchangePacket(furniid);
            }
            if (CreditMultiplierEnabled)
            {
                ExchangeMultiplier(furniid);
            }
        }

        private async void ExchangeMultiplier(int furniid)
        {
            for (int i = 0; i < CreditMultiplierAmount; i++)
            {
                await Task.Delay(50);
                if (Connection.Remote.IsConnected)
                {
                    await Connection.SendToServerAsync(Out.RedeemItem, furniid);
                }
            }
        }
        private async void SendOpenGiftPacket(int furniid)
        {
            await Task.Delay(350);
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToServerAsync(Out.OpenRecycleBox, furniid);
            }
            await Task.Delay(50);
        }


        private void RedeemCreditsBtn_Click(object sender, EventArgs e)
        {
            HandleCreditsExchanger(CreditIDInt);
        }

        private void ReedemGiftBtn_Click(object sender, EventArgs e)
        {
            HandleGiftExchanger(GiftInt);

        }





    }
}