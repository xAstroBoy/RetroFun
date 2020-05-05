using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Components;
using Sulakore.Protocol;
using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using Sulakore.Habbo;
using System.Linq;

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



        private int _FurniIDToCheck;

        public int FurniIDToCheck
        {
            get => _FurniIDToCheck;
            set
            {
                _FurniIDToCheck = value;
                RaiseOnPropertyChanged();
            }
        }



        private bool isTeleportFurni = true;
        private bool IsWalkingFurni;

        private int _FurniWalkingSpeed = 15;

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

        private int _controlledFloorFurni;

        public int ControlledFloorFurni
        {
            get => _controlledFloorFurni;
            set
            {
                _controlledFloorFurni = value;
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


        private bool _StoreFurniID;

        public bool StoreFurniID
        {
            get => _StoreFurniID;
            set
            {
                _StoreFurniID = value;
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

            Bind(StoreFurniIDOnFileChbx, "Checked", nameof(StoreFurniID));

            Bind(FloorFurniIDNbx, "Value", nameof(FloorFurniID));
            Bind(FloorFurniXNbx, "Value", nameof(FloorFurniX));
            Bind(FloorFurniYNbx, "Value", nameof(FloorFurniY));

            Bind(WalkingSpeedNbx, "Value", nameof(FurniWalkingSpeed));

            if (Program.Master != null)
            {
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
 

        private string GetHost(string host)
        {
            if (host == "217.182.58.18")
            {
                return "bobbaitalia.it";
            }
            else
            {
                return host;
            }
        }

        private void RecordPlacedRare(int FurniID)
        {
            try
            {
                string Filepath = "../PlacedFurnis/" + GetHost(Connection.Host) + "_FURNI" + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".log";
                string FolderName = "PlacedFurnis";

                Directory.CreateDirectory("../" + FolderName);

                if (!File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        txtFile.WriteLine("furni ID stored at :" + DateTime.Now.ToString());
                        txtFile.WriteLine(FurniID);
                    }
                }
                else if (File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        txtFile.WriteLine(FurniID);
                    }
                }
            }

            catch (Exception)
            {

            }
        }


        private void RecordRareControl(bool isRegolar, string text)
        {
            string raretype;
            try
            {
                if (isRegolar)
                {
                    raretype = "_rari_regolari";
                }
                else
                {
                    raretype = "_rari_irregolari";
                }

                string Filepath = "../RareControls/" + GetHost(Connection.Host) + raretype + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".log";
                string FolderName = "RareControls";

                Directory.CreateDirectory("../" + FolderName);

                if (!File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        txtFile.WriteLine("Rares Control Done at :" + DateTime.Now.ToString());
                        txtFile.WriteLine(text);
                    }
                }
                else if (File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        txtFile.WriteLine(text);
                    }
                }
            }

            catch (Exception)
            {

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
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);
            }

        }

        private async void RotationRight_CheckedChanged(object sender, EventArgs e)
        {
            FloorFurniRotation = 0;
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);
            }

        }

        private async void RotationDown_CheckedChanged(object sender, EventArgs e)
        {
            FloorFurniRotation = 2;
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);
            }
        }

        private async void rotationLeft_CheckedChanged(object sender, EventArgs e)
        {
            FloorFurniRotation = 4;
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);
            }
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
                await Task.Delay(150);
                await Connection.SendToClientAsync(In.RoomUserTalk, 0, text, 0, 1, 0, -1);
            }
        }

        private async void Speak(string text, int bubble)
        {
            if (Connection.Remote.IsConnected)
            {
                await Task.Delay(50);
                await Connection.SendToClientAsync(In.RoomUserTalk, 0, text, 0, bubble, 0, -1);
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
            if (FloorFurniInterceptionMode)
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
            if (isTeleportFurni)
            {
                IsWalkingFurni = true;
                isTeleportFurni = false;
                WriteToButton(WalkingStyleBtn, "Walking mode : Walking");

            }
            else if (IsWalkingFurni)
            {
                IsWalkingFurni = false;
                isTeleportFurni = true;
                WriteToButton(WalkingStyleBtn, "Walking mode : Teleport");
            }
        }


        public async void TeleportfurniToCoord(int X, int Y)
        {
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, X, Y, FloorFurniRotation);
            }
        }


        private async void WalkFurniToCoordX(int X)
        {
            if (ConvertWalkinFurniMovement)
            {
                while (FloorFurniX != X)
                {
                    if (FloorFurniX < X)
                    {
                        FloorFurniX++;
                        await Task.Delay(FurniWalkingSpeed);
                        SendWalkingFurniPacket(FloorFurniX, FloorFurniY);
                    }
                    if (FloorFurniX > X)
                    {
                        FloorFurniX--;
                        await Task.Delay(FurniWalkingSpeed);
                        SendWalkingFurniPacket(FloorFurniX, FloorFurniY);

                    }
                }
            }
            else
            {
                return;
            }
        }

        private async void WalkFurniToCoordY(int Y)
        {
            if (ConvertWalkinFurniMovement)
            {
                while (FloorFurniY != Y)
                {
                    if (FloorFurniY < Y)
                    {
                        FloorFurniY++;
                        await Task.Delay(FurniWalkingSpeed);
                        SendWalkingFurniPacket(FloorFurniX, FloorFurniY);

                    }
                    if (FloorFurniY > Y)
                    {
                        FloorFurniY--;
                        await Task.Delay(FurniWalkingSpeed);
                        SendWalkingFurniPacket(FloorFurniX, FloorFurniY);
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void SendWalkingFurniPacket(int X, int Y)
        {
            if (ConvertWalkinFurniMovement)
            {
                if (Connection.Remote.IsConnected)
                {
                    Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, X, Y, FloorFurniRotation);
                }
            }
        }
        private void FloorFurniXNbx_ValueChanged(object sender, EventArgs e)
        {
            if (ConvertWalkinFurniMovement)
            {
                Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);
            }
        }

        private void FloorFurniYNbx_ValueChanged(object sender, EventArgs e)
        {
            if (ConvertWalkinFurniMovement)
            {
                Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);
            }
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
                if (isTeleportFurni)
                {
                    TeleportfurniToCoord(coordX, coordY);
                    e.IsBlocked = true;
                }
                else if (IsWalkingFurni)
                {

                    WalkFurniToCoord(coordX, coordY);
                    e.IsBlocked = true;
                }
            }
        }

        public static HWallItem[] BobbaParser(HMessage packet)
        {
            int ownersCount = packet.ReadInteger();
            for (int i = 0; i < ownersCount; i++)
            {
                packet.ReadInteger();
                packet.ReadString();
            }

            var wallItems = new HWallItem[packet.ReadInteger()];
            for (int i = 0; i < wallItems.Length; i++)
            {
                wallItems[i] = new HWallItem(packet);
            }
            return wallItems;
        }


        private async void WalkFurniToCoord(int X, int Y)
        {
            WalkFurniToCoordX(X);
            await Task.Delay(10);
            WalkFurniToCoordY(Y);
            await Task.Delay(10);
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

        private void PickWallItemCSBtn_Click(object sender, EventArgs e)
        {
            if (FurnitureId == 0) return;
            PickFurniSS(FurnitureId);
        }

        private void PickFloorFurniSSBtn_Click(object sender, EventArgs e)
        {
            if (FurnitureId == 0) return;
            PickFurniSS(FurnitureId);
        }

        private void PickFurniSS(int furniID)
        {
            Connection.SendToServerAsync(Out.RoomPickupItem, 2, furniID);
        }

        private void DoubleClickFurnitureRemovalChbx_CheckedChanged(object sender, EventArgs e)
        {
            Speak("You will be picking furni on Client, instead of Server side!");
        }





        private void StoreFurniIDOnFileChbx_CheckedChanged(object sender, EventArgs e)
        {

        }


        public void OnRoomPickupItem(DataInterceptedEventArgs e)
        {
            int furnitureId = e.Packet.ReadInteger(4);

            if (StoreFurniID)
            {
                RecordPlacedRare(furnitureId);
            }

            if (DoubleClickFurnitureRemoval)
            {
                string furnitureIdString = furnitureId.ToString();
                RemoveWallItem(furnitureIdString);
                RemoveFloorItem(furnitureIdString);
                if (FurniPickedOutput)
                {
                    NoticePickup(furnitureIdString);
                }
                e.IsBlocked = true;
            }
        }

        public void OnRotateMoveItem(DataInterceptedEventArgs e)
        {
            int FloorFurni = e.Packet.ReadInteger();
            int FurniX = e.Packet.ReadInteger();
            int FurniY = e.Packet.ReadInteger();
            int Rotation = e.Packet.ReadInteger();
            if (FloorFurniInterceptionMode)
            {
                FloorFurniID = FloorFurni;
                FloorFurniX = FurniX;
                FloorFurniY = FurniY;
                ControlRotation(Rotation);
            }
        }

        public void OnMoveWallItem(DataInterceptedEventArgs e)
        {
        }

        public void InRoomFloorItems(DataInterceptedEventArgs e)
        {
            if (FurniDataStored == null)
            {
                FurniDataStored = e.Packet;
            }
        }

        public void InRoomWallItems(DataInterceptedEventArgs e)
        {
        }

        public void InAddFloorItem(DataInterceptedEventArgs e)
        {
        }

        public void InAddWallItem(DataInterceptedEventArgs e)
        {

        }

        public void InRemoveFloorItem(DataInterceptedEventArgs e)
        { }

        public void InRemoveWallItem(DataInterceptedEventArgs e)
        { }
    }
}