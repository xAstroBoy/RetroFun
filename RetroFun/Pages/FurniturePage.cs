using RetroFun.Controls;
using Sulakore.Communication;
using Sulakore.Protocol;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class FurniturePage : ObservablePage
    {
        private HMessage FurniDataStored;

        private bool _doubleClickFurnitureRemoval;

        public bool DoubleClickFurnitureRemoval
        {
            get => _doubleClickFurnitureRemoval;
            set
            {
                _doubleClickFurnitureRemoval = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _ButtonRotateMoveItem;

        public bool ButtonRotateMoveItem
        {
            get => _ButtonRotateMoveItem;
            set
            {
                _ButtonRotateMoveItem = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _FurniPickedOutput;

        public bool FurniPickedOutput
        {
            get => _FurniPickedOutput;
            set
            {
                _FurniPickedOutput = value;
                RaiseOnPropertyChanged();
            }
        }

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

        private string _furnitureIdText;

        public string FurnitureIdText
        {
            get => _furnitureIdText;
            set
            {
                _furnitureIdText = value;
                RaiseOnPropertyChanged();

                // Set the default value(0) if it fails to parse.
                int.TryParse(value, out int furnitureId);

                FurnitureId = furnitureId;
                RaiseOnPropertyChanged(nameof(FurnitureId));
            }
        }

        public int FurnitureId { get; private set; }

        public FurniturePage()
        {
            InitializeComponent();

            Bind(FurnitureIDTxt, "Text", nameof(FurnitureIdText));
            Bind(DoubleClickFurnitureRemovalChbx, "Checked", nameof(DoubleClickFurnitureRemoval));
            //Bind(ToggleFurniRotCS, "Checked", nameof(ButtonRotateMoveItem));
            Bind(FurniPickChbx, "Checked", nameof(FurniPickedOutput));
            Bind(ExchangeCreditChbx, "Checked", nameof(CreditExchangeMode));
            Bind(ExchangeMPChbx, "Checked", nameof(CreditMultiplierEnabled));
            Bind(MultiplierNbx, "Value", nameof(CreditMultiplierAmount));
            Bind(CreditsIDNbx, "Value", nameof(CreditIDInt));
            Bind(GiftExchangerIDNBx, "Value", nameof(GiftInt));
            Bind(AutoGiftExchangerBtn, "Checked", nameof(GiftExchangeMode));

            if (Program.Master != null)
            {
                Triggers.OutAttach(Out.RoomPickupItem, RoomPickupItem);
                Triggers.InAttach(In.RoomFloorItems, StoreRoomFurniData);
                Triggers.OutAttach(Out.RoomPlaceItem, RoomPlaceItemsHandler);
            }
        }

        private void StoreRoomFurniData(DataInterceptedEventArgs obj)
        {
            FurniDataStored = obj.Packet;
            obj.Continue();
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

        private async void SendExchangePacket(int furniid)
        {
            await Task.Delay(350);
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToServerAsync(Out.RedeemItem, furniid);
            }
            await Task.Delay(50);
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

        private void RemoveWallItemBtn_Click(object sender, EventArgs e)
        {
            if (FurnitureId == 0) return;
            RemoveWallItem(FurnitureIdText);
        }

        private void RemoveFloorItemBtn_Click(object sender, EventArgs e)
        {
            if (FurnitureId == 0) return;
            RemoveFloorItem(FurnitureIdText);
        }

        private void RoomPickupItem(DataInterceptedEventArgs obj)
        {
            int furnitureId = obj.Packet.ReadInteger(4);
            if (DoubleClickFurnitureRemoval)
            {
                string furnitureIdString = furnitureId.ToString();
                RemoveWallItem(furnitureIdString);
                RemoveFloorItem(furnitureIdString);
                if (FurniPickedOutput)
                {
                    NoticePickup(furnitureIdString);
                }
                obj.IsBlocked = true;
            }
        }

        private void NoticePickup(string FurniID)
        {
            Speak("You are picking a furni ClientSide with ID : " + FurniID);
        }

        private void RotateMoveItems(DataInterceptedEventArgs obj)
        {
            int FurnID = obj.Packet.ReadInteger();
            int two = obj.Packet.ReadInteger();
            int three = obj.Packet.ReadInteger();
            int Rotation = obj.Packet.ReadInteger();

            if (ButtonRotateMoveItem)
            {
                if (RotationUp.Checked)
                {
                    Rotation = 6;
                    RadioButtonCheck(RotationUp, false);
                    RadioButtonCheck(RotationRight, true);
                }
                else if (RotationRight.Checked)
                {
                    Rotation = 0;
                    RadioButtonCheck(RotationRight, false);
                    RadioButtonCheck(RotationDown, true);
                }
                else if (RotationDown.Checked)
                {
                    Rotation = 2;
                    RadioButtonCheck(RotationDown, false);
                    RadioButtonCheck(rotationLeft, true);
                }
                else if (rotationLeft.Checked)
                {
                    Rotation = 4;
                    RadioButtonCheck(rotationLeft, false);
                    RadioButtonCheck(RotationUp, true);
                }
                obj.IsBlocked = true;
                RotateItem(FurnID, two, three, Rotation);
            }
        }

        private void RotateItem(int furnitureId, int two, int three, int Rotation)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.FloorItemUpdate, furnitureId, 0, two, three, 0, Rotation, 0, 0, 0, 0, 0, 0, 0);
            }
        }

        private void RemoveWallItem(string furnitureId)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.RemoveWallItem, furnitureId, 0);
            }
        }

        private void RemoveFloorItem(string furnitureId)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.RemoveFloorItem, furnitureId, false, 0, 0);
            }
        }

        private void RadioButtonCheck(RadioButton button, bool value)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Checked = value;
            });
        }

        private void AcquireMODPermissionsBtn_Click(object sender, EventArgs e)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.UserPermissions, int.MaxValue, int.MaxValue, true);
            }
        }

        private void RestoreFurnisBtn_Click(object sender, EventArgs e)
        {
            if (FurniDataStored != null)
            {
                if (Connection.Remote.IsConnected)
                {
                    Connection.SendToClientAsync(FurniDataStored);
                }
            }
            else
            {
                Speak("Stored Furnidata is empty! Try refreshing the room!");
            }
        }

        private void Speak(string text)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, text, 0, 1, 0, -1);
            }
        }

        private void RedeemCreditsBtn_Click(object sender, EventArgs e)
        {
            HandleCreditsExchanger(CreditIDInt);
        }

        private void ReedemGiftBtn_Click(object sender, EventArgs e)
        {
            HandleGiftExchanger(GiftInt);
        }

        private void DoubleClickFurnitureRemovalChbx_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}