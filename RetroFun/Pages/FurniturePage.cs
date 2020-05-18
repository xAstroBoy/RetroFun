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
    public partial class FurniturePage:  ObservablePage
    {

        List<HFloorItem> SnapshotFloorItems;
        List<HWallItem> SnapshotWallItems;
        List<HFloorItem> RoomFloorFurni;
        List<HWallItem> RoomWallFurni;
        private Random ran = new Random();
        private bool _doubleClickFurnitureRemoval;
        private bool ConvertWalkinFurniMovement;
        private bool FloorFurniInterceptionMode;

        private bool IsPickerGrabMode;

       private bool IS_PICKING_FURNITYPE_SS;
        private bool IS_PICKING_FURNITYPE_CS;

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

        private int _TargetFurniType;

        public int TargetFurniType
        {
            get => _TargetFurniType;
            set
            {
                _TargetFurniType = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _TypeIDPickerSpeed = 5;

        public int TypeIDPickerSpeed
        {
            get => _TypeIDPickerSpeed;
            set
            {
                _TypeIDPickerSpeed = value;
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



        public FurniturePage()
        {
            InitializeComponent();

            Bind(FurnitureIDTxt, "Text", nameof(FurnitureIdText));
            Bind(DoubleClickFurnitureRemovalChbx, "Checked", nameof(DoubleClickFurnitureRemoval));
            Bind(FurniPickChbx, "Checked", nameof(FurniPickedOutput));
            Bind(SelectedFurniTypeNbx, "Value", nameof(TargetFurniType));
            Bind(PickerSpeedNbx, "Value", nameof(TypeIDPickerSpeed));



            Bind(StoreFurniIDOnFileChbx, "Checked", nameof(StoreFurniID));

            Bind(FloorFurniIDNbx, "Value", nameof(FloorFurniID));
            Bind(FloorFurniXNbx, "Value", nameof(FloorFurniX));
            Bind(FloorFurniYNbx, "Value", nameof(FloorFurniY));

            Bind(WalkingSpeedNbx, "Value", nameof(FurniWalkingSpeed));
            RoomFloorFurni = new List<HFloorItem>();
            RoomWallFurni = new List<HWallItem>();
            SnapshotFloorItems = new List<HFloorItem>();
            SnapshotWallItems = new List<HWallItem>();
            //if (Program.Master != null)
            //{
            //}
        }

        private void SetFurnisSnapshot()
        {
            
            SnapshotFloorItems = RoomFloorFurni.ToList();
            SnapshotWallItems = RoomWallFurni.ToList();
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
            FindFurniToRemove(FurnitureId);
        }

        private void RemoveFloorItemBtn_Click(object sender, EventArgs e)
        {
            if (FurnitureId == 0) return;
            FindFurniToRemove(FurnitureId);
        }
 
        private void FindFurniToRemove(int furni)
        {
            var roomfurni = RoomFloorFurni.Find(x => x.Id == furni);
            var wallfurni = RoomWallFurni.Find(x => x.Id == furni);
            if(roomfurni != null)
            {
                HideFurnisClient(roomfurni);
                return;
            }
            if (wallfurni != null)
            {
                HideFurnisClient(wallfurni);
                return;
            }
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



        private void NoticePickup(int FurniID)
        {
            Speak("You are picking a furni ClientSide with ID : " + FurniID, 30);
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


        private void RadioButtonCheck(RadioButton button, bool value)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Checked = value;
            });
        }



        private void RestoreFurnisBtn_Click(object sender, EventArgs e)
        {
            if (RoomFloorFurni != null && !(RoomFloorFurni.Count == 0))
            {
                if (Connection.Remote.IsConnected)
                {
                    Connection.SendToClientAsync(FurniComposer.composer(RoomFloorFurni, In.RoomFloorItems));
                }
            }
            if(RoomWallFurni != null && !(RoomWallFurni.Count == 0))
            {
                Connection.SendToClientAsync(FurniComposer.composer(RoomWallFurni, In.RoomWallItems));
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



        private void UpdateFurniMovement(int furni, int Coord_x, int Coord_y)
        {
            var roomfurni = RoomFloorFurni.Find(x => x.Id == furni);
            if (roomfurni != null)
            {
                UpdateFurniMovement(roomfurni, Coord_x, Coord_y);
                return;
            }
        }


        private void UpdateFurniMovement(int furni, int Coord_x, int Coord_y, string Coord_z)
        {
            var roomfurni = RoomFloorFurni.Find(x => x.Id == furni);
            if (roomfurni != null)
            {
                UpdateFurniMovement(roomfurni, Coord_x, Coord_y, Coord_z);
                return;
            }

        }
        private void UpdateFurniMovement(int furni, string wallcoord)
        {
            var roomfurni = RoomWallFurni.Find(x => x.Id == furni);
            if (roomfurni != null)
            {
                UpdateFurniMovement(roomfurni, wallcoord);
                return;
            }
        }

        private void UpdateFurniMovement(HFloorItem furni, int Coord_x, int Coord_y)
        {
            var roomfurni = RoomFloorFurni.Find(x => x == furni);
            if (roomfurni != null)
            {
                roomfurni.Tile.X = Coord_x;
                roomfurni.Tile.Y = Coord_y;
            }
        }


        private void UpdateFurniMovement(HFloorItem furni, int Coord_x, int Coord_y, string Coord_z)
        {
            var roomfurni = RoomFloorFurni.Find(x => x == furni);
            if (roomfurni != null)
            {
                roomfurni.Tile.X = Coord_x;
                roomfurni.Tile.Y = Coord_y;
                if (Double.TryParse(Coord_z, out Double res))
                {
                    roomfurni.Tile.Z = res;
                }
            }
        }

        private void UpdateFurniMovement(HWallItem furni, string wallcoord)
        {
            var roomfurni = RoomWallFurni.Find(x => x == furni);
            if (roomfurni != null)
            {
                roomfurni.Location = wallcoord;
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


        public override void In_FloorItemUpdate(DataInterceptedEventArgs e)
        {
                int uniqueId = e.Packet.ReadInteger();
                int typeId = e.Packet.ReadInteger();
                int x = e.Packet.ReadInteger();
                int y = e.Packet.ReadInteger();
                int facingprob = e.Packet.ReadInteger();
                string z = e.Packet.ReadString();
                string heightthingyprob = e.Packet.ReadString();
                int stateprobidk = e.Packet.ReadInteger();
                int newXProb = e.Packet.ReadInteger();
                int newYProb = e.Packet.ReadInteger();

                UpdateFurniMovement(uniqueId, x, y, z);
                e.Packet.Position = 0;
            e.Continue();
            }


        public override void Out_RequestRoomLoad(DataInterceptedEventArgs e)
        {
            RoomFloorFurni.Clear();
            RoomWallFurni.Clear();
            SnapshotFloorItems.Clear();
            SnapshotWallItems.Clear();
            ShouldUnlock(true);
            IS_PICKING_FURNITYPE_SS = false;
            IS_PICKING_FURNITYPE_CS = false;
        }
        public override void Out_RequestRoomHeightmap(DataInterceptedEventArgs e)
        {
            RoomFloorFurni.Clear();
            RoomWallFurni.Clear();
            SnapshotFloorItems.Clear();
            SnapshotWallItems.Clear();
            ShouldUnlock(true);
            IS_PICKING_FURNITYPE_SS = false;
            IS_PICKING_FURNITYPE_CS = false;
        }


        public override void Out_RoomUserWalk(DataInterceptedEventArgs e)
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

        public static List<HWallItem> BobbaParser(HMessage packet)
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
            return wallItems.ToList();
        }



        private async void WalkFurniToCoord(int X, int Y)
        {
            WalkFurniToCoordX(X);
            await Task.Delay(10);
            WalkFurniToCoordY(Y);
            await Task.Delay(10);
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

        public override void Out_RoomPickupItem(DataInterceptedEventArgs e)
        {
            int furnitureId = e.Packet.ReadInteger(4);

            if (StoreFurniID)
            {
                RecordPlacedRare(furnitureId);
            }

            if (DoubleClickFurnitureRemoval)
            {
                FindFurniToRemove(furnitureId);
                FindFurniToRemove(furnitureId);
                if (FurniPickedOutput)
                {
                    NoticePickup(furnitureId);
                }
                e.IsBlocked = true;
            }
            if (IsPickerGrabMode)
            {
                FindTypeId(furnitureId);
                e.IsBlocked = true;

            }
        }

        public override void Out_RotateMoveItem(DataInterceptedEventArgs e)
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
            if(IsPickerGrabMode)
            {
                FindTypeId(FloorFurni);
                e.IsBlocked = true;
            }
        }


        private void FindTypeId(int FurniID)
        {
            var roomfurni = RoomFloorFurni.Find(x => x.Id == FurniID);
            if (roomfurni != null)
            {
                FindTypeId(roomfurni);
                return;
            }
        }
        private void FindTypeId(HFloorItem furni)
        {
            TargetFurniType = furni.TypeId;
            Speak("[FurniType Picker] I will pick furnis containing this Typeid ( " + TargetFurniType + " )", 30);
            return;
        }

        public override void In_RoomFloorItems(DataInterceptedEventArgs e)
        {
            RoomFloorFurni = HFloorItem.Parse(e.Packet).ToList(); //All Floor Objects
        }
        private void RemoveSelectedFurniTypeSS()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (!(SnapshotFloorItems.Count == 0) && SnapshotFloorItems != null)
                        {
                            foreach (HFloorItem furni in SnapshotFloorItems)
                            {
                                if (furni.TypeId == TargetFurniType)
                                {
                                    Thread.Sleep(TypeIDPickerSpeed);
                                    PickFurniSS(furni.Id);
                                }
                            }
                            ShouldUnlock(true);
                            IS_PICKING_FURNITYPE_SS = false;
                        }
                        ShouldUnlock(true);
                        IS_PICKING_FURNITYPE_SS = false;
                    }
                    catch (Exception)
                    {
                    }
                } while (IS_PICKING_FURNITYPE_SS);
            }).Start();
        }


        private async void HideFurnisClient(HWallItem item)
        {
            if (Connection.Remote.IsConnected)
            {
                await Task.Delay(250);
                await Connection.SendToClientAsync(In.RemoveWallItem, item.Id.ToString(), 0);
            }
        }
        private async void HideFurnisClient(HFloorItem item)
        {
            if (Connection.Remote.IsConnected)
            {
                if(In.RemoveFloorItem == 0 && GetHost(Connection.Host) == "bobbaitalia.it")
                {
                    await Task.Delay(250);
                    await Connection.SendToClientAsync(2411, item.Id.ToString(), false, 0, 0);
                    return;
                }
                else
                {
                    await Task.Delay(250);
                    await Connection.SendToClientAsync(In.RemoveFloorItem, item.Id.ToString(), false, 0, 0);
                    return;
                }
            }
        }


        private void RemoveSelectedFurnisCS()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (!(SnapshotFloorItems.Count == 0) && SnapshotFloorItems != null)
                        {
                            foreach (HFloorItem furni in SnapshotFloorItems)
                            {
                                if (furni.TypeId == TargetFurniType)
                                {
                                    Thread.Sleep(TypeIDPickerSpeed);
                                    HideFurnisClient(furni);
                                    SnapshotFloorItems.Remove(furni);
                                }
                            }
                            ShouldUnlock(true);
                            IS_PICKING_FURNITYPE_CS = false;
                        }
                        ShouldUnlock(true);
                        IS_PICKING_FURNITYPE_CS = false;
                    }
                    catch (Exception)
                    {
                    }
                } while (IS_PICKING_FURNITYPE_CS);
            }).Start();
        }



        private void ShouldUnlock(bool isUnlocked)
        {
            Invoke((MethodInvoker)delegate
            {
                PickSelectedTypeSSBtn.Enabled = isUnlocked;
                PickSelectedTypeCSBtn.Enabled = isUnlocked;
                GrabTypeIdBtn.Enabled = isUnlocked;
                PickerSpeedNbx.Enabled = isUnlocked;
                SelectedFurniTypeNbx.Enabled = isUnlocked;
                RemoveRoomBGCSBtn.Enabled = isUnlocked;
            });
        }

        private void DisablePicker()
        {
            WriteToButton(GrabTypeIdBtn, "TypeID Grabber : OFF");
            IsPickerGrabMode = false;
        }
        public override void In_RoomWallItems(DataInterceptedEventArgs e)
        {
            RoomWallFurni = BobbaParser(e.Packet);
        }

        public override void In_AddFloorItem(DataInterceptedEventArgs e)
        {
                try
                {
                var NewFloorFurnis = new HFloorItem(e.Packet);
                if (!RoomFloorFurni.Contains(NewFloorFurnis))
                    {
                        RoomFloorFurni.Add(NewFloorFurnis);
                    }
                }
                catch (Exception) { }
        }

        public override void In_AddWallItem(DataInterceptedEventArgs e)
        {
            try
            {
                var NewPlacedWallFurni = new HWallItem(e.Packet);
                if (!RoomWallFurni.Contains(NewPlacedWallFurni))
                {
                    RoomWallFurni.Add(NewPlacedWallFurni);
                }
            }
            catch (Exception) { }
        }
    

        public override void In_RemoveFloorItem(DataInterceptedEventArgs e)
        {
            HandleRemovedFurni(e.Packet.ReadString());
            e.Continue();
        }

        public override void In_RemoveWallItem(DataInterceptedEventArgs e)
        {
            HandleRemovedFurni(e.Packet.ReadString());
            e.Continue();
        }


        private void HandleRemovedFurni(string item)
        {
            if (int.TryParse(item, out int furni))
            {
                var foundfurni = RoomFloorFurni.Find(f => f.Id == furni);
                var wallfurni = RoomWallFurni.Find(f => f.Id == furni);

                if (foundfurni != null)
                {
                    HandleRemovedFurni(foundfurni);
                }
                if (wallfurni != null)
                {
                    HandleRemovedFurni(wallfurni);
                }
            }
            else
            {
                return;
            }
        }


        private void HandleRemovedFurni(HWallItem item)
        {
            if (RoomWallFurni.Contains(item))
            {
                RoomWallFurni.Remove(item);
            }
        }


        private void HandleRemovedFurni(HFloorItem item)
        {
            try
            {

                if (RoomFloorFurni.Contains(item))
                {
                    RoomFloorFurni.Remove(item);
                }
            }

            catch (Exception) { }
        }



        public override void Out_ToggleFloorItem(DataInterceptedEventArgs e)
        {
            int FurniID = e.Packet.ReadInteger();
            if (IsPickerGrabMode)
            {
                FindTypeId(FurniID);
                e.IsBlocked = true;
            }
        }

        public override void In_WallItemUpdate(DataInterceptedEventArgs e)
        {
            string furniid = e.Packet.ReadString();
            int typeIdIguess = e.Packet.ReadInteger();
            string newLocation = e.Packet.ReadString();
            if (int.TryParse(furniid, out int furni))
            {
                UpdateFurniMovement(furni, newLocation);
            }
            e.Packet.Position = 0;
            e.Continue();
        }


        private void PickRegisteredFurniTypes_Click(object sender, EventArgs e)
        {
            Speak("Picking Furnis in Server Side!", 30);
            IS_PICKING_FURNITYPE_SS = true;
            RemoveSelectedFurniTypeSS();
            DisablePicker();
            ShouldUnlock(false);
        }

        private void GrabTypeIDBtn_Click(object sender, EventArgs e)
        {
            if(IsPickerGrabMode)
            {
                WriteToButton(GrabTypeIdBtn, "TypeID Grabber : OFF");
                IsPickerGrabMode = false;
            }
            else
            {
                WriteToButton(GrabTypeIdBtn, "TypeID Grabber : ON");
                IsPickerGrabMode = true;
            }
        }

        private void PickFurniCSBtn_Click(object sender, EventArgs e)
        {
            SnapshotFloorItems.Clear();
            SnapshotWallItems.Clear();
            Speak("Picking Furnis in Client Side!", 30);
            IS_PICKING_FURNITYPE_CS = true;
            SetFurnisSnapshot();
            RemoveSelectedFurnisCS();
            DisablePicker();
            ShouldUnlock(false);
        }

        private void RemoveRoomBGCS_click(object sender, EventArgs e)
        {
            SnapshotFloorItems.Clear();
            SnapshotWallItems.Clear();
            Speak("Hiding Room BG In Client Side!", 30);
            IS_PICKING_FURNITYPE_CS = true;
            TargetFurniType = 3821;
            SetFurnisSnapshot();
            RemoveSelectedFurnisCS();
            DisablePicker();
            ShouldUnlock(false);
        }
    }
}