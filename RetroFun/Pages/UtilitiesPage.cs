using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sulakore.Communication;
using RetroFun.Subscribers;
using Sulakore.Components;
using RetroFun.Helpers;
using System.Threading;
using RetroFun.Utils.Furnitures.Furni;
using Sulakore.Habbo;

namespace RetroFun.Pages
{

    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class UtilitiesPage : ObservablePage
    {

        private List<HFloorItem> RoomFloorFurni
        {
            get => FloorFurnitures.Furni;
            set
            {
                FloorFurnitures.Furni = value;
                RaiseOnPropertyChanged();
            }
        }


        // TEMP
        private Random random = new Random();

        private bool stackerrandomizeheight;
        private bool RiseStackerMode;
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


        private int _StackerID;


        public int StackerID
        {
            get => _StackerID;
            set
            {
                _StackerID = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _StackerSetHeight;


        public int StackerSetHeight
        {
            get => _StackerSetHeight;
            set
            {
                _StackerSetHeight = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _StackerRangeStartHeight;


        public int StackerRangeStartHeight
        {
            get => _StackerRangeStartHeight;
            set
            {
                _StackerRangeStartHeight = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _StackerRangeEndHeight = 50;


        public int StackerRangeEndHeight
        {
            get => _StackerRangeEndHeight;
            set
            {
                _StackerRangeEndHeight = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _StackerLiveEditMode;


        public bool StackerLiveEditMode
        {
            get => _StackerLiveEditMode;
            set
            {
                _StackerLiveEditMode = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _CaptureStackerMode;


        public bool CaptureStackerMode
        {
            get => _CaptureStackerMode;
            set
            {
                _CaptureStackerMode = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _StackerThreadDelay = 150;


        public int StackerThreadDelay
        {
            get => _StackerThreadDelay;
            set
            {
                _StackerThreadDelay = value;
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

            Bind(StackerHeightNbx, "Value", nameof(StackerSetHeight));
            Bind(StackerFurniIDNbx, "Value", nameof(StackerID));
            Bind(StackerStartRangeNbx, "Value", nameof(StackerRangeStartHeight));
            Bind(StackerEndRangeNbx, "Value", nameof(StackerRangeEndHeight));
            Bind(StackerThreadDelayNbx, "Value", nameof(StackerThreadDelay));


        }

        private async void SendExchangePacket(int furniid)
        {
            await Task.Delay(350);
            await SendToServer(Out.RedeemItem, furniid);
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
                WriteToButton(CaptureRoomBGBtn, "Capture RoomBG: OFF");
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
            if (CreditMultiplierEnabled)
            {
                ExchangeMultiplier(furniid);
            }
            else
            {
                SendExchangePacket(furniid);
            }
        }

        private async void ExchangeMultiplier(int furniid)
        {
            for (int i = 0; i < CreditMultiplierAmount; i++)
            {
                await Task.Delay(50);
                await SendToServer(Out.RedeemItem, furniid);

            }
        }
        private async void SendOpenGiftPacket(int furniid)
        {
            await Task.Delay(350);

            await SendToServer(Out.OpenRecycleBox, furniid);

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
            await SendToServer(Out.AdvertisingSave, FurnID, RoomBG_X, "imageUrl", URL, "offsetX", OffsetX.ToString(), "offsetY", OffsetY.ToString(), "offsetZ", OffsetZ.ToString());
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
            WriteToButton(CaptureRoomBGBtn, $"Capture RoomBG: {(IsBGInterceptor ? "OFF" : "ON")}");
            IsBGInterceptor = !IsBGInterceptor;
        }

        private void SetRoomBGBtn_Click(object sender, EventArgs e)
        {
            SendRoomBGPacket(RoomBGID, RoomBGX, OffsetX, OffsetY, OffsetZ, RoomBGURL);
        }

        private void LiveEditBtn_Click(object sender, EventArgs e)
        {
            WriteToButton(LiveEditBtn, $"Live Edit: {(isLiveBGEditor ? "OFF" : "ON")}");
            isLiveBGEditor = !isLiveBGEditor;
        }

        private void OffsetZNbx_ValueChanged(object sender, EventArgs e)
        {
            if (isLiveBGEditor)
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

        private void SetStacker(int id, int height)
        {
            _ = SendToServer(Out.SetStackHelperHeight, id, height);
        }

        private async void SetStackerThread(int id, int height)
        {
            await Task.Delay(150);
            await SendToServer(Out.SetStackHelperHeight, id, height);
        }


        private void StackerHeightNbx_ValueChanged(object sender, EventArgs e)
        {
            if (StackerLiveEditMode)
            {
                SetStacker(StackerID, StackerSetHeight);
            }
        }

        private void StackerLiveEditBtn_Click(object sender, EventArgs e)
        {

            WriteToButton(StackerLiveEditBtn, $"Live Edit: {(StackerLiveEditMode ? "OFF" : "ON")}");
            StackerLiveEditMode = !StackerLiveEditMode;

        }
        private void Speak(string text)
        {
            _ = SendToClient(In.RoomUserWhisper, 0, "[Utilities]: " + text, 0, 34, 0, -1);
        }


        private void DeactivateCaptureStacker()
        {
            Speak("Stacker Found, Check RetroFun for settings!");
            WriteToButton(CaptureStackerBtn, "Capture Stacker : OFF");
            CaptureStackerMode = false;
        }


        public override void Out_SetStackHelperHeight(DataInterceptedEventArgs e)
        {
            if (CaptureStackerMode)
            {
                int stacker = e.Packet.ReadInteger();
                int stackerHeight = e.Packet.ReadInteger();
                if (FloorFurnitures.FindFloorFurni(stacker) != null)
                {
                    StackerID = FloorFurnitures.FindFloorFurni(stacker).Id;
                    StackerSetHeight = (int)FloorFurnitures.FindFloorFurni(stacker).Tile.Z;
                }
                else
                {
                    StackerID = stacker;
                    StackerSetHeight = stackerHeight;
                }
                e.IsBlocked = true;
                DeactivateCaptureStacker();
            }

        }

        public override void Out_ToggleFloorItem(DataInterceptedEventArgs e)
        {

            int furniID = e.Packet.ReadInteger();
            if (CaptureStackerMode)
            {
                if (FloorFurnitures.FindFloorFurni(furniID) != null)
                {
                    StackerID = FloorFurnitures.FindFloorFurni(furniID).Id;
                    StackerSetHeight = (int)FloorFurnitures.FindFloorFurni(furniID).Tile.Z;
                }
                else
                {
                    StackerID = furniID;
                }
                e.IsBlocked = true;
                DeactivateCaptureStacker();
            }
        }


        public override void Out_RotateMoveItem(DataInterceptedEventArgs e)
        {
            int furniID = e.Packet.ReadInteger();
            if (CaptureStackerMode)
            {
                if (FloorFurnitures.FindFloorFurni(furniID) != null)
                {
                    StackerID = FloorFurnitures.FindFloorFurni(furniID).Id;
                    StackerSetHeight = (int)FloorFurnitures.FindFloorFurni(furniID).Tile.Z;
                }
                else
                {
                    StackerID = furniID;
                }
                e.IsBlocked = true;
                DeactivateCaptureStacker();
            }
        }



        private void RandomHeightSettings()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    if (stackerrandomizeheight)
                    {
                        StackerSetHeight = random.Next(StackerRangeStartHeight, StackerRangeEndHeight);
                        Thread.Sleep(StackerThreadDelay);
                        if (StackerLiveEditMode)
                        {
                            SetStacker(StackerID, StackerSetHeight);
                        }
                    }
                } while (stackerrandomizeheight);
            }).Start();
        }



        private void RiseStackerModality()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    for (int i = StackerRangeStartHeight; i < StackerRangeEndHeight; i++)
                    {
                        if (RiseStackerMode)
                        {
                            StackerSetHeight = i;
                            Thread.Sleep(StackerThreadDelay);
                            if (StackerLiveEditMode)
                            {
                                SetStacker(StackerID, StackerSetHeight);
                            }
                        }
                    }
                } while (RiseStackerMode);
            }).Start();
        }



        private void CaptureStackerBtn_Click(object sender, EventArgs e)
        {
            WriteToButton(CaptureStackerBtn, $"Capture Stacker: {(CaptureStackerMode ? "OFF" : "ON")}");
            CaptureStackerMode = !CaptureStackerMode;
        }

        private void DisableRandomizer()
        {
            WriteToButton(StackerRandomizerBtn, "Enable Randomizer: OFF");
            stackerrandomizeheight = false;
        }

        private void StackerRandomizerBtn_Click(object sender, EventArgs e)
        {
            if (stackerrandomizeheight)
            {
                WriteToButton(StackerRandomizerBtn, "Enable Randomizer: OFF");
                stackerrandomizeheight = false;
            }
            else
            {
                WriteToButton(StackerRandomizerBtn, "Enable Randomizer: ON");
                DisableRiseStacker();
                stackerrandomizeheight = true;
                RandomHeightSettings();
            }

        }

        private void DecOneStackerBtn_Click(object sender, EventArgs e)
        {
            if (StackerLiveEditMode)
            {
                SetStacker(StackerID, --StackerSetHeight);
            }
        }

        private void IncOneStackerBtn_Click(object sender, EventArgs e)
        {
            if (StackerLiveEditMode)
            {
                SetStacker(StackerID, ++StackerSetHeight);
            }
        }


        private void DisableRiseStacker()
        {
            WriteToButton(CaptureStackerBtn, "Rise Stacker: OFF");
            RiseStackerMode = false;
        }
        private void RiseStackerModeBtn_Click(object sender, EventArgs e)
        {
            if (RiseStackerMode)
            {
                WriteToButton(RiseStackerModeBtn, "Rise Stacker: OFF");
                RiseStackerMode = false;
            }
            else
            {
                WriteToButton(RiseStackerModeBtn, "Rise Stacker: ON");
                DisableRandomizer();
                RiseStackerMode = true;
                RiseStackerModality();
            }
        }

        private void GetStartUrlBtn_Click(object sender, EventArgs e)
        {
            if (KnownDomains.isBobbaHotel)
            {
                RoomBGURL = GlobalStrings.BOBBA_ROOMBG_STARTURL;
            }
            else
            {
                Speak("This host doesn't have a known BG start URL!");
            }
        }

        private void RedeemRoomCurrenciesBtn_Click(object sender, EventArgs e)
        {
            ConvertAllFurnisCredits(RoomFloorFurni);
        }

        private void ConvertAllFurnisCredits(List<HFloorItem> items)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                foreach (var furni in items)
                {
                    SendExchangePacket(furni.Id);
                    Thread.Sleep(150);
                }
            }).Start();
        }
    }
}