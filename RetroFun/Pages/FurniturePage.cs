using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Components;
using Sulakore.Protocol;
using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class FurniturePage : ObservablePage, ISubscriber
    {
        private HMessage FurniDataStored;
        private Random ran = new Random();
        private bool _doubleClickFurnitureRemoval;
        private bool ConvertWalkinFurniMovement;
        private bool FloorFurniInterceptionMode;

        private int _FloorFurniID;



        private bool isTeleportFurni = true;
        private bool IsWalkingFurni;

        private int _FurniWalkingSpeed = 300;

        public int FurniWalkingSpeed
        {
            get => _FurniWalkingSpeed;
            set
            {
                _FurniWalkingSpeed = value;
                RaiseOnPropertyChanged();
            }
        }


        public int FloorFurniID
        {
            get => _FloorFurniID;
            set
            {
                _FloorFurniID = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _FloorFurniRotation;

        public int FloorFurniRotation
        {
            get => _FloorFurniRotation;
            set
            {
                _FloorFurniRotation = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool DoubleClickFurnitureRemoval
        {
            get => _doubleClickFurnitureRemoval;
            set
            {
                _doubleClickFurnitureRemoval = value;
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

        private int _FloorFurniLiveEditCooldown;

        public int FloorFurniLiveEditCooldown
        {
            get => _FloorFurniLiveEditCooldown;
            set
            {
                _FloorFurniLiveEditCooldown = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _FloorFurniX;

        public int FloorFurniX
        {
            get => _FloorFurniX;
            set
            {
                _FloorFurniX = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _FloorFurniY;

        public int FloorFurniY
        {
            get => _FloorFurniY;
            set
            {
                _FloorFurniY = value;
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

        public bool IsReceiving => true;

        public FurniturePage()
        {
            InitializeComponent();

            Bind(FurnitureIDTxt, "Text", nameof(FurnitureIdText));
            Bind(DoubleClickFurnitureRemovalChbx, "Checked", nameof(DoubleClickFurnitureRemoval));
            Bind(FurniPickChbx, "Checked", nameof(FurniPickedOutput));


            Bind(FloorFurniIDNbx, "Value", nameof(FloorFurniID));
            Bind(FloorFurniXNbx, "Value", nameof(FloorFurniX));
            Bind(FloorFurniYNbx, "Value", nameof(FloorFurniY));

            Bind(WalkingSpeedNbx, "Value", nameof(FurniWalkingSpeed));


            if (Program.Master != null)
            {
                Triggers.OutAttach(Out.RoomPickupItem, RoomPickupItem);
                Triggers.InAttach(In.RoomFloorItems, StoreRoomFurniData);
                Triggers.OutAttach(Out.RotateMoveItem, RotateMoveItemIntercept);
            }
        }

        private void StoreRoomFurniData(DataInterceptedEventArgs obj)
        {
            FurniDataStored = obj.Packet;
            obj.Continue();
        }


        private void RotateMoveItemIntercept(DataInterceptedEventArgs e)
        {
            if(FloorFurniInterceptionMode)
            {
                FloorFurniID = e.Packet.ReadInteger();
                FloorFurniX = e.Packet.ReadInteger();
                FloorFurniY = e.Packet.ReadInteger();
                ControlRotation(e.Packet.ReadInteger());
            }


        }




        private void WriteToButton(SKoreButton Button, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                Button.Text = text;
            });
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

        private void ControlRotation(int Rotation)
        {
            if (Rotation == 6)
                {
                    RadioButtonCheck(RotationUp, false);
                    RadioButtonCheck(RotationRight, false);
                RadioButtonCheck(RotationDown, false);
                RadioButtonCheck(rotationLeft, false);
                FloorFurniRotation = 6;


            }
            if (Rotation == 0)
            {
                RadioButtonCheck(RotationUp, false);
                RadioButtonCheck(RotationRight, true);
                RadioButtonCheck(RotationDown, false);
                RadioButtonCheck(rotationLeft, false);
                FloorFurniRotation = 0;
            }
            if (Rotation == 2)
            {
                RadioButtonCheck(RotationUp, false);
                RadioButtonCheck(RotationRight, false);
                RadioButtonCheck(RotationDown, true);
                RadioButtonCheck(rotationLeft, false);
                FloorFurniRotation = 2;
            }
            if (Rotation == 4)
            {
                RadioButtonCheck(RotationUp, false);
                RadioButtonCheck(RotationRight, false);
                RadioButtonCheck(RotationDown, false);
                RadioButtonCheck(rotationLeft, true);
                FloorFurniRotation = 4;
            }
        }

        private async void RotationUp_CheckedChanged(object sender, EventArgs e)
        {
            FloorFurniRotation = 6;
            await Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);

        }

        private async void RotationRight_CheckedChanged(object sender, EventArgs e)
        {
            FloorFurniRotation = 0;
            await Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);

        }

        private async void RotationDown_CheckedChanged(object sender, EventArgs e)
        {
            FloorFurniRotation = 2;
            await Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);

        }

        private async void rotationLeft_CheckedChanged(object sender, EventArgs e)
        {
            FloorFurniRotation = 4;
            await Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);

        }


        private async void RotateItem(int furnitureId, int two, int three, int Rotation)
        {
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToClientAsync(In.FloorItemUpdate, furnitureId, 0, two, three, 0, Rotation, 0, 0, 0, 0, 0, 0, 0);
            }
        }

        private async void RemoveWallItem(string furnitureId)
        {
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToClientAsync(In.RemoveWallItem, furnitureId, 0);
            }
        }

        private async void RemoveFloorItem(string furnitureId)
        {
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToClientAsync(In.RemoveFloorItem, furnitureId, false, 0, 0);
            }
        }

        private void RadioButtonCheck(RadioButton button, bool value)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Checked = value;
            });
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

        private async void Speak(string text)
        {
            if (Connection.Remote.IsConnected)
            {
               await  Connection.SendToClientAsync(In.RoomUserWhisper, 0, text, 0, 1, 0, -1);
            }
        }

        private void WalkAsSelectedFurniBtn_Click(object sender, EventArgs e)
        {
            if (ConvertWalkinFurniMovement)
            {
                WriteToButton(WalkAsSelectedFurniBtn, "Furni Walk Edit : OFF");
                ConvertWalkinFurniMovement = false;
            }
            else
            {

                WriteToButton(WalkAsSelectedFurniBtn, "Furni Walk Edit : ON");
                Speak("User Walking will be blocked , because you are controlling the selected furni now!");
                ConvertWalkinFurniMovement = true;
            }
        }

        private void CaptureFloorFurniBtn_Click(object sender, EventArgs e)
        {
            if(FloorFurniInterceptionMode)
            {
                WriteToButton(CaptureFloorFurniBtn, "Capture Furni : OFF");
                FloorFurniInterceptionMode = false;
            }
            else
            {

                WriteToButton(CaptureFloorFurniBtn, "Capture Furni : ON");
                Speak("Please move a furni to register it on retrofun and manually edit all the coordinates!");
                FloorFurniInterceptionMode = true;
            }

        }


        private void WalkingStyleBtn_Click(object sender, EventArgs e)
        {
            if(isTeleportFurni)
            {
                IsWalkingFurni = true;
                isTeleportFurni = false;
                WriteToButton(WalkingStyleBtn, "Walking mode : Walking");

            }
            else if(IsWalkingFurni)
            {
                IsWalkingFurni = false;
                isTeleportFurni = true;
                WriteToButton(WalkingStyleBtn, "Walking mode : Teleport");
            }
        }


        public async void TeleportfurniToCoord(int X , int Y)
        {
            await Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, X, Y, FloorFurniRotation);
        }


        public async void WalkFurniToCoord(int X, int Y)
        {
            if (ConvertWalkinFurniMovement)
            {
                while (FloorFurniX != X && FloorFurniY != Y)
                {
                    if (FloorFurniX < X)
                    {
                        FloorFurniX++;
                    }
                    if (FloorFurniX > X)
                    {
                        FloorFurniX--;
                    }

                    if (FloorFurniY < Y)
                    {
                        FloorFurniY++;
                    }
                    if (FloorFurniY > Y)
                    {
                        FloorFurniY--;
                    }

                    await Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);
                    await Task.Delay(FurniWalkingSpeed);

                }
            }

        }


        private void FloorFurniXNbx_ValueChanged(object sender, EventArgs e)
        {
            Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);
        }

        private void FloorFurniYNbx_ValueChanged(object sender, EventArgs e)
        {
            Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);
        }

        public void OnOutDiceTrigger(DataInterceptedEventArgs e)
        {

        }

        public void InFloorItemUpdate(DataInterceptedEventArgs e)
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

        }

        public void OnLatencyTest(DataInterceptedEventArgs e)
        {

        }

        public void OnCatalogBuyItem(DataInterceptedEventArgs e)
        {
        }

        public void OnUsername(DataInterceptedEventArgs e)
        {

        }

        public void InRoomData(DataInterceptedEventArgs e)
        {

        }

        public void InItemExtraData(DataInterceptedEventArgs e)
        {
        }
        public void OnRoomUserWalk(DataInterceptedEventArgs e)
        {
            int coordX = e.Packet.ReadInteger();
            int coordY = e.Packet.ReadInteger();
            
            if (ConvertWalkinFurniMovement)
            {
                if(isTeleportFurni)
                {
                    TeleportfurniToCoord(coordX, coordY);
                    e.IsBlocked = true;
                }
                else if(IsWalkingFurni)
                {

                     WalkFurniToCoord(coordX, coordY);
                    e.IsBlocked = true;
                }
            }

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

        public void OnRoomUserStartTyping(DataInterceptedEventArgs e)
        {
        }


    }
}