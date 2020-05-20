using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Components;
using Sulakore.Protocol;
using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using Sulakore.Habbo;
using System.Linq;
using RetroFun.Helpers;
using RetroFun.Utils.Furnitures.FloorFurni;
using RetroFun.Utils.Furnitures.WallFurni;
using System.Text;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class FurniturePage : ObservablePage
    {

        List<HFloorItem> SnapshotFloorItems;
        List<HWallItem> SnapshotWallItems;
        private List<HFloorItem> RoomFloorFurni { get => FloorFurnitures.Furni; }
        private List<HWallItem> RoomWallFurni { get => WallFurnitures.Furni; }
        private bool _doubleClickFurnitureRemoval;
        private bool ConvertWalkinFurniMovement;
        private bool FloorFurniInterceptionMode;

        private bool IsPickerGrabMode;

        private bool IS_TARGET_WALLFURNI;
        private bool IS_TARGET_FLOORFURNI;
        private bool IS_PICKING_FLOOR_FURNITYPE_SS;
        private bool IS_PICKING_WALL_FURNITYPE_SS;

        private bool IS_PICKING_BADGEHOLDER_SS;
        private bool IS_PICKING_BADGEHOLDER_CS;

        private readonly List<int> BadgeHoldersTypeIDS = new List<int> { 4827, 4828, 4831, 4830, 4829, 4827, 4828 };
        private bool IS_PICKING_FLOOR_FURNITYPE_CS;
        private bool IS_PICKING_WALL_FURNITYPE_CS;

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

        private bool _ShowFurniDetailsInChat;

        public bool ShowFurniDetailsInChat
        {
            get => _ShowFurniDetailsInChat;
            set
            {
                _ShowFurniDetailsInChat = value;
                RaiseOnPropertyChanged();
            }
        }
        private bool _StoreFurniDetailsToFile;

        public bool StoreFurniDetailsToFile
        {
            get => _StoreFurniDetailsToFile;
            set
            {
                _StoreFurniDetailsToFile = value;
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

        private string _BadgeCodeInHolder;

        public string BadgeCodeInHolder
        {
            get => _BadgeCodeInHolder;
            set
            {
                _BadgeCodeInHolder = value;
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


            Bind(ShowFurniDetailsChbx, "Checked", nameof(StoreFurniDetailsToFile));
            Bind(ShowFurnIStuffInChatChbx, "Checked", nameof(ShowFurniDetailsInChat));
            Bind(StoreFurniIDOnFileChbx, "Checked", nameof(StoreFurniID));

            Bind(FloorFurniIDNbx, "Value", nameof(FloorFurniID));
            Bind(FloorFurniXNbx, "Value", nameof(FloorFurniX));
            Bind(FloorFurniYNbx, "Value", nameof(FloorFurniY));

            Bind(WalkingSpeedNbx, "Value", nameof(FurniWalkingSpeed));

            Bind(BadgeCodePickerTxb, "Text", nameof(BadgeCodeInHolder));
            SnapshotFloorItems = new List<HFloorItem>();
            SnapshotWallItems = new List<HWallItem>();

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


        private void RemoveWallItemCSBtn_Click(object sender, EventArgs e)
        {
            if (FurnitureId == 0) return;
            FindFurniToRemoveCS(FurnitureId);
        }

        private void RemoveFloorItemCSBtn_Click(object sender, EventArgs e)
        {
            if (FurnitureId == 0) return;
            FindFurniToRemoveCS(FurnitureId);
        }

        private void FindFurniToRemoveCS(int furni)
        {
            var roomfurni = RoomFloorFurni.Find(x => x.Id == furni);
            var wallfurni = RoomWallFurni.Find(x => x.Id == furni);
            if (roomfurni != null)
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


        private void RecordPlacedRare(int FurniID)
        {
            try
            {
                string Filepath = "../PlacedFurnis/" + RecognizeDomain.GetHost(Connection.Host) + "_FURNI" + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".log";
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

        private void RecordFurniDetails(HFloorItem furni)
        {
            try
            {
                int i = 0;
                string Filepath = "../FurniDetails/" + RecognizeDomain.GetHost(Connection.Host) + "_FloorFurni" + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".log";
                string FolderName = "FurniDetails";

                Directory.CreateDirectory("../" + FolderName);

                if (!File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        txtFile.WriteLine("furni ID stored at :" + DateTime.Now.ToString());
                        txtFile.WriteLine(" ");
                        txtFile.WriteLine("[Furni Id] : " + furni.Id);
                        txtFile.WriteLine("[Furni TypeId] : " + furni.TypeId);
                        txtFile.WriteLine("[Furni Tile] : " + furni.Tile);
                        txtFile.WriteLine("[Furni Facing] : " + furni.Facing);
                        txtFile.WriteLine("[Furni Category] : " + furni.Category);
                        foreach (object obj in furni.Stuff)
                        {
                            txtFile.WriteLine("[Furni Stuff [" + i + "] : " + obj);
                            i++;
                        }
                        txtFile.WriteLine("[Furni SecondsToExpiration] : " + furni.SecondsToExpiration);
                        txtFile.WriteLine("[Furni UsagePolicy] : " + furni.UsagePolicy);
                        txtFile.WriteLine("[Furni OwnerId] : " + furni.OwnerId);
                        txtFile.WriteLine("[Furni OwnerName] : " + furni.OwnerName);

                    }
                }
                else if (File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        txtFile.WriteLine(" ");
                        txtFile.WriteLine("[Furni Id] : " + furni.Id);
                        txtFile.WriteLine("[Furni TypeId] : " + furni.TypeId);
                        txtFile.WriteLine("[Furni Tile] : " + furni.Tile);
                        txtFile.WriteLine("[Furni Facing] : " + furni.Facing);
                        txtFile.WriteLine("[Furni Category] : " + furni.Category);
                        foreach (object obj in furni.Stuff)
                        {
                            txtFile.WriteLine("[Furni Stuff [" + i + "] : " + obj);
                            i++;
                        }
                        txtFile.WriteLine("[Furni SecondsToExpiration] : " + furni.SecondsToExpiration);
                        txtFile.WriteLine("[Furni UsagePolicy] : " + furni.UsagePolicy);
                        txtFile.WriteLine("[Furni OwnerId] : " + furni.OwnerId);
                        txtFile.WriteLine("[Furni OwnerName] : " + furni.OwnerName);
                    }
                }
            }

            catch (Exception)
            {

            }
        }


        private void RecordFurniDetails(HWallItem furni)
        {
            try
            {
                string Filepath = "../FurniDetails/" + RecognizeDomain.GetHost(Connection.Host) + "_WallFurni" + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".log";
                string FolderName = "FurniDetails";

                Directory.CreateDirectory("../" + FolderName);

                if (!File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        txtFile.WriteLine("furni ID stored at :" + DateTime.Now.ToString());
                        txtFile.WriteLine(" ");
                        txtFile.WriteLine("[Furni Id] : " + furni.Id);
                        txtFile.WriteLine("[Furni TypeId] : " + furni.TypeId);
                        txtFile.WriteLine("[Furni Location] : " + furni.Location);
                        txtFile.WriteLine("[Furni State] : " + furni.State);
                        txtFile.WriteLine("[Furni SecondsToExpiration] : " + furni.SecondsToExpiration);
                        txtFile.WriteLine("[Furni UsagePolicy] : " + furni.UsagePolicy);
                        txtFile.WriteLine("[Furni OwnerId] : " + furni.OwnerId);
                        txtFile.WriteLine("[Furni OwnerName] : " + furni.OwnerName);

                    }
                }
                else if (File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        txtFile.WriteLine(" ");
                        txtFile.WriteLine("[Furni Id ] : " + furni.Id);
                        txtFile.WriteLine("[Furni TypeId ] : " + furni.TypeId);
                        txtFile.WriteLine("[Furni Location ] : " + furni.Location);
                        txtFile.WriteLine("[Furni State ] : " + furni.State);
                        txtFile.WriteLine("[Furni SecondsToExpiration ] : " + furni.SecondsToExpiration);
                        txtFile.WriteLine("[Furni UsagePolicy ] : " + furni.UsagePolicy);
                        txtFile.WriteLine("[Furni OwnerId ] : " + furni.OwnerId);
                        txtFile.WriteLine("[Furni OwnerName ] : " + furni.OwnerName);
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
                    Connection.SendToClientAsync(FloorFurnitures.PacketBuilder(RoomFloorFurni, In.RoomFloorItems));
                }
            }
            if (RoomWallFurni != null && !(RoomWallFurni.Count == 0))
            {
                Connection.SendToClientAsync(WallFurnitures.PacketBuilder(RoomWallFurni, In.RoomWallItems));
            }
            else
            {
                if (RoomWallFurni.Count == 0 && RoomFloorFurni.Count == 0)
                {
                    Speak("Stored Furnidata is empty! Try refreshing the room!");
                }
            }
        }

        private async void Speak(string text)
        {
            if (Connection.Remote.IsConnected)
            {
                await Task.Delay(150);
                await Connection.SendToClientAsync(In.RoomUserTalk, 0, text, 0, 34, 0, -1);
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


        public override void Out_RequestRoomLoad(DataInterceptedEventArgs e)
        {
            ResetPicker();
        }
        public override void Out_RequestRoomHeightmap(DataInterceptedEventArgs e)
        {
            ResetPicker();
        }

        public void ResetPicker()
        {
            SnapshotFloorItems.Clear();
            SnapshotWallItems.Clear();
            ShouldUnlockTypeIDPicker(true);
            IS_PICKING_FLOOR_FURNITYPE_SS = false;
            IS_PICKING_FLOOR_FURNITYPE_CS = false;
            IS_PICKING_WALL_FURNITYPE_CS = false;
            IS_PICKING_WALL_FURNITYPE_SS = false;
            IS_PICKING_BADGEHOLDER_CS = false;
            IS_PICKING_BADGEHOLDER_SS = false;
            ShouldUnlockBadgePicker(true);

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


        private void PickWallItemSSBtn_Click(object sender, EventArgs e)
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
        private void PickFurniSS(HFloorItem furni)
        {
            Connection.SendToServerAsync(Out.RoomPickupItem, 2, furni.Id);
        }
        private void PickFurniSS(HWallItem furni)
        {
            Connection.SendToServerAsync(Out.RoomPickupItem, 2, furni.Id);
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
                FindFurniToRemoveCS(furnitureId);
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
            if (StoreFurniDetailsToFile || ShowFurniDetailsInChat)
            {
                FindFurniDetals(furnitureId);
                e.IsBlocked = true;
            }
        }

        public override void Out_RotateMoveItem(DataInterceptedEventArgs e)
        {
            int furniid = e.Packet.ReadInteger();
            int FurniX = e.Packet.ReadInteger();
            int FurniY = e.Packet.ReadInteger();
            int Rotation = e.Packet.ReadInteger();
            if (FloorFurniInterceptionMode)
            {
                FloorFurniID = furniid;
                FloorFurniX = FurniX;
                FloorFurniY = FurniY;
                ControlRotation(Rotation);
            }
            if (IsPickerGrabMode)
            {
                FindTypeId(furniid);
                e.IsBlocked = true;
            }
            if (StoreFurniDetailsToFile || ShowFurniDetailsInChat)
            {
                FindFurniDetals(furniid);
                e.IsBlocked = true;
            }
        }


        private void FindTypeId(int FurniID)
        {
            var floorfurni = RoomFloorFurni.Find(x => x.Id == FurniID);
            var wallfurni = RoomWallFurni.Find(x => x.Id == FurniID);

            if (floorfurni != null)
            {
                FindTypeId(floorfurni);
                IS_TARGET_WALLFURNI = false;
                IS_TARGET_FLOORFURNI = true;
                return;
            }
            if (wallfurni != null)
            {
                FindTypeId(wallfurni);
                IS_TARGET_WALLFURNI = true;
                IS_TARGET_FLOORFURNI = false;
                return;
            }

        }

        private void FindFurniDetals(int FurniID)
        {
            var floorfurni = RoomFloorFurni.Find(x => x.Id == FurniID);
            var wallfurni = RoomWallFurni.Find(x => x.Id == FurniID);

            if (floorfurni != null)
            {
                if (ShowFurniDetailsInChat)
                {
                    ShowFurniDetails(floorfurni);
                }
                if (StoreFurniDetailsToFile)
                {
                    RecordFurniDetails(floorfurni);
                }
                return;
            }
            if (wallfurni != null)
            {
                if (ShowFurniDetailsInChat)
                {
                    PrintFurniDetailsInChat(wallfurni);
                }
                if (StoreFurniDetailsToFile)
                {
                    RecordFurniDetails(wallfurni);
                }
                return;
            }

        }
        private void ShowFurniDetails(HFloorItem furni)
        {
            Speak(CreateOneBigString(furni), 34);
        }

        private string CreateOneBigString(HFloorItem furni)
        {
            var FurniString = new StringBuilder();
            int i = 0;
            FurniString.Append("[Furni Id] : " + furni.Id + "\n");
            FurniString.Append("[Furni TypeId] : " + furni.TypeId+ "\n");
            FurniString.Append("[Furni Tile] : " + furni.Tile+ "\n");
            FurniString.Append("[Furni Facing] : " + furni.Facing+ "\n");
            FurniString.Append("[Furni Category] : " + furni.Category+ "\n");
            foreach (object obj in furni.Stuff)
            {
                FurniString.Append("[Furni Stuff [" + i + "] : " + obj + "\n");
                i++;
            }
            FurniString.Append("[Furni SecondsToExpiration] : " + furni.SecondsToExpiration+ "\n");
            FurniString.Append("[Furni UsagePolicy] : " + furni.UsagePolicy+ "\n");
            FurniString.Append("[Furni OwnerId] : " + furni.OwnerId+ "\n");
            FurniString.Append("[Furni OwnerName] : " + furni.OwnerName+ "\n");

            return FurniString.ToString();
        }


        private string CreateOneBigString(HWallItem furni)
        {
            var FurniString = new StringBuilder();
            FurniString.Append("[Furni Id] : " + furni.Id + "\n");
            FurniString.Append("[Furni TypeId ] : " + furni.TypeId + "\n");
            FurniString.Append("[Furni Location ] : " + furni.Location + "\n");
            FurniString.Append("[Furni State ] : " + furni.State + "\n");
            FurniString.Append("[Furni SecondsToExpiration ] : " + furni.SecondsToExpiration + "\n");
            FurniString.Append("[Furni UsagePolicy ] : " + furni.UsagePolicy + "\n");
            FurniString.Append("[Furni OwnerId ] : " + furni.OwnerId + "\n");
            FurniString.Append("[Furni OwnerName ] : " + furni.OwnerName + "\n");
            return FurniString.ToString();
        }


        private void PrintFurniDetailsInChat(HWallItem furni)
        {
            Speak(CreateOneBigString(furni), 34);
        }

        private void FindTypeId(HFloorItem furni)
        {
            TargetFurniType = furni.TypeId;
            Speak("[FurniType Picker] I will pick furnis containing this Typeid ( " + TargetFurniType + " )", 30);
            return;
        }
        private void FindTypeId(HWallItem furni)
        {
            TargetFurniType = furni.TypeId;
            Speak("[FurniType Picker] I will pick furnis containing this Typeid ( " + TargetFurniType + " )", 30);
            return;
        }

        private void RemoveSelectedFloorFurniTypeSS()
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
                            ShouldUnlockTypeIDPicker(true);
                            IS_PICKING_FLOOR_FURNITYPE_SS = false;
                        }
                        ShouldUnlockTypeIDPicker(true);
                        IS_PICKING_FLOOR_FURNITYPE_SS = false;
                    }
                    catch (Exception)
                    {
                    }
                } while (IS_PICKING_FLOOR_FURNITYPE_SS);
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
                if (In.RemoveFloorItem == 0 && RecognizeDomain.GetHost(Connection.Host) == RecognizeDomain.bobbaitalia)
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


        private void RemoveSelectedFloorFurniCS()
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
                            ShouldUnlockTypeIDPicker(true);
                            IS_PICKING_FLOOR_FURNITYPE_CS = false;
                        }
                        ShouldUnlockTypeIDPicker(true);
                        IS_PICKING_FLOOR_FURNITYPE_CS = false;
                    }
                    catch (Exception)
                    {
                    }
                } while (IS_PICKING_FLOOR_FURNITYPE_CS);
            }).Start();
        }

        private void RemoveBadgeHolderFloorFurniCS()
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
                                if (BadgeHoldersTypeIDS.Contains(furni.TypeId))
                                {
                                    if (furni.Stuff.Contains(BadgeCodeInHolder))
                                    {
                                        Thread.Sleep(TypeIDPickerSpeed);
                                        HideFurnisClient(furni);
                                        SnapshotFloorItems.Remove(furni);
                                    }
                                }
                            }
                            ShouldUnlockBadgePicker(true);
                            IS_PICKING_BADGEHOLDER_CS = false;
                        }
                        ShouldUnlockBadgePicker(true);
                        IS_PICKING_BADGEHOLDER_CS = false;
                    }
                    catch (Exception)
                    {
                    }
                } while (IS_PICKING_BADGEHOLDER_CS);
            }).Start();
        }

        private void RemoveBadgeHolderFloorFurniSS()
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
                                if (BadgeHoldersTypeIDS.Contains(furni.TypeId))
                                {
                                    if (furni.Stuff.Contains(BadgeCodeInHolder))
                                    {
                                        Thread.Sleep(TypeIDPickerSpeed);
                                        PickFurniSS(furni.Id);
                                        SnapshotFloorItems.Remove(furni);
                                    }
                                }
                            }
                            ShouldUnlockBadgePicker(true);
                            IS_PICKING_BADGEHOLDER_SS = false;
                        }
                        ShouldUnlockBadgePicker(true);
                        IS_PICKING_BADGEHOLDER_SS = false;
                    }
                    catch (Exception)
                    {
                    }
                } while (IS_PICKING_BADGEHOLDER_SS);
            }).Start();
        }


        private void RemoveSelectedWallFurniCS()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (!(SnapshotWallItems.Count == 0) && SnapshotWallItems != null)
                        {
                            foreach (HWallItem furni in SnapshotWallItems)
                            {
                                if (furni.TypeId == TargetFurniType)
                                {
                                    Thread.Sleep(TypeIDPickerSpeed);
                                    HideFurnisClient(furni);
                                    SnapshotWallItems.Remove(furni);
                                }
                            }
                            ShouldUnlockTypeIDPicker(true);
                            IS_PICKING_WALL_FURNITYPE_CS = false;
                        }
                        ShouldUnlockTypeIDPicker(true);
                        IS_PICKING_WALL_FURNITYPE_CS = false;
                    }
                    catch (Exception)
                    {
                    }
                } while (IS_PICKING_WALL_FURNITYPE_CS);
            }).Start();
        }

        private void RemoveSelectedWallFurniSS()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (!(SnapshotWallItems.Count == 0) && SnapshotWallItems != null)
                        {
                            foreach (HWallItem furni in SnapshotWallItems)
                            {
                                if (furni.TypeId == TargetFurniType)
                                {
                                    Thread.Sleep(TypeIDPickerSpeed);
                                    PickFurniSS(furni);
                                    SnapshotWallItems.Remove(furni);
                                }
                            }
                            ShouldUnlockTypeIDPicker(true);
                            IS_PICKING_WALL_FURNITYPE_SS = false;
                        }
                        ShouldUnlockTypeIDPicker(true);
                        IS_PICKING_WALL_FURNITYPE_SS = false;
                    }
                    catch (Exception)
                    {
                    }
                } while (IS_PICKING_WALL_FURNITYPE_SS);
            }).Start();
        }
        private void ShouldUnlockTypeIDPicker(bool isUnlocked)
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
        private void ShouldUnlockBadgePicker(bool isUnlocked)
        {
            Invoke((MethodInvoker)delegate
            {
                BadgeCodePickerTxb.Enabled = isUnlocked;
                PickBadgeCS.Enabled = isUnlocked;
                PickBadgeSS.Enabled = isUnlocked;
            });
        }
        private void DisablePicker()
        {
            WriteToButton(GrabTypeIdBtn, "TypeID Grabber : OFF");
            IsPickerGrabMode = false;
        }

        public override void Out_ToggleFloorItem(DataInterceptedEventArgs e)
        {
            int FurniID = e.Packet.ReadInteger();
            if (IsPickerGrabMode)
            {
                FindTypeId(FurniID);
                e.IsBlocked = true;
            }
            if (StoreFurniDetailsToFile || ShowFurniDetailsInChat)
            {
                FindFurniDetals(FurniID);
                e.IsBlocked = true;
            }
        }

        public override void Out_ToggleWallItem(DataInterceptedEventArgs e)
        {
            int FurniID = e.Packet.ReadInteger();
            if (IsPickerGrabMode)
            {
                FindTypeId(FurniID);
                e.IsBlocked = true;
            }
            if (StoreFurniDetailsToFile || ShowFurniDetailsInChat)
            {
                FindFurniDetals(FurniID);
                e.IsBlocked = true;
            }
        }

        public override void Out_MoveWallItem(DataInterceptedEventArgs e)
        {
            int FurniID = e.Packet.ReadInteger();
            if (IsPickerGrabMode)
            {
                FindTypeId(FurniID);
                e.IsBlocked = true;

            }
            if (StoreFurniDetailsToFile || ShowFurniDetailsInChat)
            {
                FindFurniDetals(FurniID);
                e.IsBlocked = true;
            }
        }

        private void PickRegisteredFurniTypes_Click(object sender, EventArgs e)
        {
            Speak("Picking Furnis in Server Side!", 30);
            if (IS_TARGET_FLOORFURNI)
            {
                IS_PICKING_FLOOR_FURNITYPE_SS = true;
                SetFurnisSnapshot();
                RemoveSelectedFloorFurniTypeSS();
            }
            if (IS_TARGET_WALLFURNI)
            {
                IS_PICKING_WALL_FURNITYPE_CS = true;
                SetFurnisSnapshot();
                RemoveSelectedWallFurniSS();
            }
            DisablePicker();
            ShouldUnlockTypeIDPicker(false);
        }

        private void GrabTypeIDBtn_Click(object sender, EventArgs e)
        {
            if (IsPickerGrabMode)
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
            if (IS_TARGET_FLOORFURNI)
            {
                IS_PICKING_FLOOR_FURNITYPE_CS = true;
                SetFurnisSnapshot();
                RemoveSelectedFloorFurniCS();
            }
            if (IS_TARGET_WALLFURNI)
            {
                IS_PICKING_WALL_FURNITYPE_CS = true;
                SetFurnisSnapshot();
                RemoveSelectedWallFurniCS();
            }
            DisablePicker();
            ShouldUnlockTypeIDPicker(false);
        }

        private void RemoveRoomBGCS_click(object sender, EventArgs e)
        {
            SnapshotFloorItems.Clear();
            SnapshotWallItems.Clear();
            Speak("Hiding Room BG In Client Side!", 30);
            IS_PICKING_FLOOR_FURNITYPE_CS = true;
            IS_TARGET_FLOORFURNI = true;
            IS_TARGET_WALLFURNI = false;
            TargetFurniType = 3821;
            SetFurnisSnapshot();
            RemoveSelectedFloorFurniCS();
            DisablePicker();
            ShouldUnlockTypeIDPicker(false);
        }

        private void PickBadgeCS_Click(object sender, EventArgs e)
        {
            if (BadgeCodeInHolder != "")
            {
                if (!IS_PICKING_BADGEHOLDER_CS)
                {
                    IS_PICKING_BADGEHOLDER_CS = true;
                    SetFurnisSnapshot();
                    ShouldUnlockBadgePicker(false);
                    RemoveBadgeHolderFloorFurniCS();
                }
            }
            else
            {
                Speak("Please Put a target badge to find!", 30);
            }

        }

        private void PickBadgeSS_Click(object sender, EventArgs e)
        {
            if (BadgeCodeInHolder != "")
            {
                if (!IS_PICKING_BADGEHOLDER_SS)
                {
                    IS_PICKING_BADGEHOLDER_SS = true;
                    SetFurnisSnapshot();
                    ShouldUnlockBadgePicker(false);
                    RemoveBadgeHolderFloorFurniSS();
                }
            }
            else
            {
                Speak("Please Put a target badge to find!", 30);
            }
        }
    }
}