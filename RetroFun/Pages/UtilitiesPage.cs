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
using Sulakore.Components;

namespace RetroFun.Pages
{

    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class UtilitiesPage : ObservablePage
    {

        private bool IsBGInterceptor;
        private bool isLiveBGEditor;

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



        private int _OffsetX;

        public int OffsetX
        {
            get => _OffsetX;
            set
            {
                _OffsetX = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _OffsetY;

        public int OffsetY
        {
            get => _OffsetY;
            set
            {
                _OffsetY = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _OffsetZ;

        public int OffsetZ
        {
            get => _OffsetZ;
            set
            {
                _OffsetZ = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _RoomBGID;


        public int RoomBGID
        {
            get => _RoomBGID;
            set
            {
                _RoomBGID = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _RoomBGX;


        public int RoomBGX
        {
            get => _RoomBGX;
            set
            {
                _RoomBGX = value;
                RaiseOnPropertyChanged();
            }
        }


        private string _RoomBGURL;


        public string RoomBGURL
        {
            get => _RoomBGURL;
            set
            {
                _RoomBGURL = value;
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


            Bind(OffsetXNbx, "Value", nameof(OffsetX));
            Bind(OffsetYNbx, "Value", nameof(OffsetY));
            Bind(OffsetZNbx, "Value", nameof(OffsetZ));
            Bind(RoomBGNBx, "Value", nameof(RoomBGID));

            Bind(RoomBGurlTxb, "Text", nameof(RoomBGURL));




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

        public override void Out_AdvertisingSave(DataInterceptedEventArgs e)
        {
            if (IsBGInterceptor)
            {
                RoomBGID = e.Packet.ReadInteger();
                RoomBGX = e.Packet.ReadInteger();
                e.Packet.ReadString();
                RoomBGURL = e.Packet.ReadString();
                e.Packet.ReadString();
                OffsetX = int.Parse(e.Packet.ReadString());
                e.Packet.ReadString();
                OffsetY = int.Parse(e.Packet.ReadString());
                e.Packet.ReadString();
                OffsetZ = int.Parse(e.Packet.ReadString());
                WriteToButton(CaptureRoomBGBtn, "Capture RoomBG : OFF");
                IsBGInterceptor = false;
            }
        } 
        public override void Out_RoomPlaceItem(DataInterceptedEventArgs e)
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

        private async void SendRoomBGPacket(int FurnID, int RoomBG_X, int OffsetX, int OffsetY, int OffsetZ, string URL)
        {
            await Task.Delay(250);
            await Connection.SendToServerAsync(Out.AdvertisingSave, FurnID, RoomBG_X, "imageUrl", URL, "offsetX", OffsetX.ToString(), "offsetY", OffsetY.ToString(), "offsetZ", OffsetZ.ToString());
        }


        private void WriteToButton(SKoreButton button, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Text = text;
            });
        }



        private void CaptureRoomBGBtn_Click(object sender, EventArgs e)
        {
            if(IsBGInterceptor)
            {
                WriteToButton(CaptureRoomBGBtn, "Capture RoomBG : OFF");
                IsBGInterceptor = false;
            }
            else
            {
                WriteToButton(CaptureRoomBGBtn, "Capture RoomBG : ON");
                IsBGInterceptor = true;
            }
        }

        private void SetRoomBGBtn_Click(object sender, EventArgs e)
        {
            SendRoomBGPacket(RoomBGID, RoomBGX, OffsetX, OffsetY, OffsetZ, RoomBGURL);
        }

        private void LiveEditBtn_Click(object sender, EventArgs e)
        {
            if (isLiveBGEditor)
            {
                WriteToButton(LiveEditBtn, "Live Edit : OFF");
                isLiveBGEditor = false;
            }
            else
            {
                WriteToButton(LiveEditBtn, "Live Edit : ON");
                isLiveBGEditor = true;
            }
        }

        private void OffsetZNbx_ValueChanged(object sender, EventArgs e)
        {
            if(isLiveBGEditor)
            {
                SendRoomBGPacket(RoomBGID, RoomBGX, OffsetX, OffsetY, OffsetZ, RoomBGURL);

            }
        }

        private void OffsetYNbx_ValueChanged(object sender, EventArgs e)
        {
            if (isLiveBGEditor)
            {
                SendRoomBGPacket(RoomBGID, RoomBGX, OffsetX, OffsetY, OffsetZ, RoomBGURL);

            }
        }

        private void OffsetXNbx_ValueChanged(object sender, EventArgs e)
        {
            if (isLiveBGEditor)
            {
                SendRoomBGPacket(RoomBGID, RoomBGX, OffsetX, OffsetY, OffsetZ, RoomBGURL);

            }
        }

        private void RoomBGUrlTxb_TextChanged(object sender, EventArgs e)
        {
            if (isLiveBGEditor)
            {
                SendRoomBGPacket(RoomBGID, RoomBGX, OffsetX, OffsetY, OffsetZ, RoomBGURL);
            }
        }
    }
}