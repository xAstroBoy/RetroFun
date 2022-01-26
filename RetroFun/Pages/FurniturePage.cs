using RetroFun.Controls;
using RetroFun.Subscribers;
using Geode.Network;

using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

using System.Linq;
using RetroFun.Helpers;
using System.Text;
using RetroFun.Utils.Furnitures.Furni;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class FurniturePage : ObservablePage
    {

        List<HFloorObject> SnapshotHFloorObjects;
        List<HWallItem> SnapshotWallItems;
        private List<HFloorObject> RoomFloorFurni { get => FloorFurnitures.Furni; }
        private List<HWallItem> RoomWallFurni { get => WallFurnitures.Furni; }
        private bool _RemoveFurnisInClientSideOnly;
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

        private bool isAutomaticClientMode = true;
        private bool isAutomaticServerMode = false;

        private bool isAutomaticPicker = false;

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

        public bool RemoveFurnisInClientSideOnly
        {
            get => _RemoveFurnisInClientSideOnly;
            set
            {
                _RemoveFurnisInClientSideOnly = value;
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
            Bind(RemoveFurnisInClientSideChbx, "Checked", nameof(RemoveFurnisInClientSideOnly));
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
            SnapshotHFloorObjects = new List<HFloorObject>();
            SnapshotWallItems = new List<HWallItem>();

        }

        private void SetFurnisSnapshot()
        {

            SnapshotHFloorObjects = RoomFloorFurni.ToList();
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

        private void RemoveHFloorObjectCSBtn_Click(object sender, EventArgs e)
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
                string Filepath = "../PlacedFurnis/" + KnownDomains.GetHostName(Connection.Host) + "_FURNI" + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".log";
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

        private void RecordFurniDetails(HFloorObject furni)
        {
            try
            {
                int i = 0;
                string Filepath = "../FurniDetails/" + KnownDomains.GetHostName(Connection.Host) + "_FloorFurni" + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".log";
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
                string Filepath = "../FurniDetails/" + KnownDomains.GetHostName(Connection.Host) + "_WallFurni" + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".log";
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
            Speak("You are picking a furni ClientSide with ID : " + FurniID, 34);
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
                await  SendToServer(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);
        }

        private async void RotationRight_CheckedChanged(object sender, EventArgs e)
        {
            FloorFurniRotation = 0;

                await  SendToServer(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);

        }

        private async void RotationDown_CheckedChanged(object sender, EventArgs e)
        {
            FloorFurniRotation = 2;
                await  SendToServer(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);
        }

        private async void rotationLeft_CheckedChanged(object sender, EventArgs e)
        {
            FloorFurniRotation = 4;
                await  SendToServer(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);
            
        }

        private async void RotateItem(int furnitureId, int two, int three, int Rotation)
        {
                await  SendToClient(In.HFloorObjectUpdate, furnitureId, 0, two, three, 0, Rotation, 0, 0, 0, 0, 0, 0, 0);
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
                    _ = SendToClient(FloorFurnitures.PacketBuilder(RoomFloorFurni, In.RoomHFloorObjects));
            }
            if (RoomWallFurni != null && !(RoomWallFurni.Count == 0))
            {
                _ = SendToClient(WallFurnitures.PacketBuilder(RoomWallFurni, In.RoomWallItems));
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
                await Task.Delay(150);
                await  SendToClient(In.RoomUserTalk, 0, text, 0, 34, 0, -1);
        }

        private async void Speak(string text, int bubble)
        {
                await Task.Delay(50);
                await  SendToClient(In.RoomUserTalk, 0, text, 0, bubble, 0, -1);
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

                await  SendToServer(Out.RotateMoveItem, FloorFurniID, X, Y, FloorFurniRotation);
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
                    _ = SendToServer(Out.RotateMoveItem, FloorFurniID, X, Y, FloorFurniRotation);
            }
        }
        private void FloorFurniXNbx_ValueChanged(object sender, EventArgs e)
        {
            if (ConvertWalkinFurniMovement)
            {
                _ = SendToServer(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);
            }
        }

        private void FloorFurniYNbx_ValueChanged(object sender, EventArgs e)
        {
            if (ConvertWalkinFurniMovement)
            {
                _ = SendToServer(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);
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
            RemoveFurnisInClientSideOnly = false;
            SnapshotHFloorObjects.Clear();
            SnapshotWallItems.Clear();
            ShouldUnlockTypeIDPicker(true);
            IS_PICKING_FLOOR_FURNITYPE_SS = false;
            IS_PICKING_FLOOR_FURNITYPE_CS = false;
            IS_PICKING_WALL_FURNITYPE_CS = false;
            IS_PICKING_WALL_FURNITYPE_SS = false;
            IS_PICKING_BADGEHOLDER_CS = false;
            IS_PICKING_BADGEHOLDER_SS = false;
            isAutomaticPicker = false;
            ShouldUnlockBadgePicker(true);
            isAutomaticServerMode = false;
            isAutomaticClientMode = true;
            WriteToButton(PickerDefaultPickBtn, "Client-side");
        }

        public override void Out_RoomUserWalk(DataInterceptedEventArgs e)
        {
            int coordX = e.Packet.ReadInt32();
            int coordY = e.Packet.ReadInt32();

            if (ConvertWalkinFurniMovement)
            {
                e.IsBlocked = true;
                if (isTeleportFurni)
                {
                    TeleportfurniToCoord(coordX, coordY);
                }
                else if (IsWalkingFurni)
                {
                    WalkFurniToCoord(coordX, coordY);
                }
            }

        }

        public static List<HWallItem> BobbaParser(HMessage packet)
        {
            int ownersCount = packet.ReadInt32();
            for (int i = 0; i < ownersCount; i++)
            {
                packet.ReadInt32();
                packet.ReadUTF8();
            }

            var wallItems = new HWallItem[packet.ReadInt32()];
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
            _ = SendToServer(Out.RoomPickupItem, 2, furniID);
        }
        private void PickFurniSS(HFloorObject furni)
        {
            _ = SendToServer(Out.RoomPickupItem, 2, furni.Id);
        }
        private void PickFurniSS(HWallItem furni)
        {
            _ = SendToServer(Out.RoomPickupItem, 2, furni.Id);
        }
        private void DoubleClickFurnitureRemovalChbx_CheckedChanged(object sender, EventArgs e)
        {
            if (!RemoveFurnisInClientSideOnly)
            {
                Speak("You will be picking furni on Client-side (it wont modify the user's room)");
            }
            else
            {
                Speak("You will be picking furni on Server-side, (it will modify the user-room!)");
            }
        }

        public override void Out_RoomPickupItem(DataInterceptedEventArgs e)
        {
            int furnitureId = e.Packet.ReadInt32(4);

            if (StoreFurniID)
            {
                RecordPlacedRare(furnitureId);
            }

            if (RemoveFurnisInClientSideOnly)
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
            int furniid = e.Packet.ReadInt32();

            if (RemoveFurnisInClientSideOnly)
            {
                FindFurniToRemoveCS(furniid);
                if (FurniPickedOutput)
                {
                    NoticePickup(furniid);
                }
                e.IsBlocked = true;
            }

            if (FloorFurniInterceptionMode)
            {
                var furni = FindFloorFurni(furniid);
                if (furni != null)
                {
                    FloorFurniID = furni.Id;
                    FloorFurniX = furni.Tile.X;
                    FloorFurniY = furni.Tile.Y;
                    ControlRotation((int)furni.Facing);
                    e.IsBlocked = true;
                }
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

        private HFloorObject FindFloorFurni(int FurniID)
        {
            var floorfurni = RoomFloorFurni.Find(x => x.Id == FurniID);
            if (floorfurni != null)
            {
                return floorfurni;
            }
            else
            {
                return null;
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
        private void ShowFurniDetails(HFloorObject furni)
        {
            Speak(CreateOneBigString(furni), 34);
        }

        private string CreateOneBigString(HFloorObject furni)
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

        private void FindTypeId(HFloorObject furni)
        {
            TargetFurniType = furni.TypeId;
            Speak("[FurniType Picker] I will pick furnis containing this Typeid ( " + TargetFurniType + " )", 34);
            if (isAutomaticPicker)
            {
                AutomaticFloorFurniPicker(furni.TypeId);
            }
            return;
        }
        private void FindTypeId(HWallItem furni)
        {
            TargetFurniType = furni.TypeId;
            Speak("[FurniType Picker] I will pick furnis containing this Typeid ( " + TargetFurniType + " )", 34);
            if(isAutomaticPicker)
            {
                AutomaticWallFurniPicker(furni.TypeId);
            }
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
                        if (!(SnapshotHFloorObjects.Count == 0) && SnapshotHFloorObjects != null)
                        {
                            foreach (HFloorObject furni in SnapshotHFloorObjects)
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
                await Task.Delay(250);
                await  SendToClient(In.RemoveWallItem, item.Id.ToString(), 0);
        }
        private async void HideFurnisClient(HFloorObject item)
        {
            if (In.RemoveHFloorObject == 0 && KnownDomains.isBobbaHotel)
            {
                await Task.Delay(250);
                await  SendToClient(2411, item.Id.ToString(), false, 0, 0);
                return;
            }
            else
            {
                await Task.Delay(250);
                await  SendToClient(In.RemoveHFloorObject, item.Id.ToString(), false, 0, 0);
                return;
            }
        }

        private void RemoveSelectedFloorFurniCS(int TypeID)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (!(SnapshotHFloorObjects.Count == 0) && SnapshotHFloorObjects != null)
                        {
                            foreach (HFloorObject furni in SnapshotHFloorObjects)
                            {
                                if (furni.TypeId == TypeID)
                                {
                                    Thread.Sleep(TypeIDPickerSpeed);
                                    HideFurnisClient(furni);
                                    SnapshotHFloorObjects.Remove(furni);
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

        private void RemoveSelectedFloorFurniCS()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (!(SnapshotHFloorObjects.Count == 0) && SnapshotHFloorObjects != null)
                        {
                            foreach (HFloorObject furni in SnapshotHFloorObjects)
                            {
                                if (furni.TypeId == TargetFurniType)
                                {
                                    Thread.Sleep(TypeIDPickerSpeed);
                                    HideFurnisClient(furni);
                                    SnapshotHFloorObjects.Remove(furni);
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
                        if (!(SnapshotHFloorObjects.Count == 0) && SnapshotHFloorObjects != null)
                        {
                            foreach (HFloorObject furni in SnapshotHFloorObjects)
                            {
                                if (BadgeHoldersTypeIDS.Contains(furni.TypeId))
                                {
                                    if (furni.Stuff.Contains(BadgeCodeInHolder))
                                    {
                                        Thread.Sleep(TypeIDPickerSpeed);
                                        HideFurnisClient(furni);
                                        SnapshotHFloorObjects.Remove(furni);
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
                        if (!(SnapshotHFloorObjects.Count == 0) && SnapshotHFloorObjects != null)
                        {
                            foreach (HFloorObject furni in SnapshotHFloorObjects)
                            {
                                if (BadgeHoldersTypeIDS.Contains(furni.TypeId))
                                {
                                    if (furni.Stuff.Contains(BadgeCodeInHolder))
                                    {
                                        Thread.Sleep(TypeIDPickerSpeed);
                                        PickFurniSS(furni.Id);
                                        SnapshotHFloorObjects.Remove(furni);
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

        public override void Out_ToggleHFloorObject(DataInterceptedEventArgs e)
        {
            int FurniID = e.Packet.ReadInt32();

            if (RemoveFurnisInClientSideOnly)
            {
                FindFurniToRemoveCS(FurniID);
                if (FurniPickedOutput)
                {
                    NoticePickup(FurniID);
                }
                e.IsBlocked = true;
            }

            if (FloorFurniInterceptionMode)
            {
                var furni = FindFloorFurni(FurniID);
                if (furni != null)
                {
                    FloorFurniID = furni.Id;
                    FloorFurniX = furni.Tile.X;
                    FloorFurniY = furni.Tile.Y;
                    ControlRotation((int)furni.Facing);
                    e.IsBlocked = true;
                }
            }
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
            int FurniID = e.Packet.ReadInt32();
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
            int FurniID = e.Packet.ReadInt32();
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
            Speak("Picking Furnis in Server Side!", 34);
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
            SnapshotHFloorObjects.Clear();
            SnapshotWallItems.Clear();
            Speak("Picking Furnis in Client Side!", 34);
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
            SnapshotHFloorObjects.Clear();
            SnapshotWallItems.Clear();
            Speak("Hiding Room BG In Client Side!", 34);
            IS_PICKING_FLOOR_FURNITYPE_CS = true;
            IS_TARGET_FLOORFURNI = true;
            IS_TARGET_WALLFURNI = false;
            var bglist = GetRoomBGIDs();
            if(bglist != null)
            {
                foreach (var id in bglist)
                {
                    TargetFurniType = id;
                    SetFurnisSnapshot();
                    DisablePicker();
                    ShouldUnlockTypeIDPicker(false);
                    RemoveSelectedFloorFurniCS(id);
                }
                ShouldUnlockTypeIDPicker(true);
            }
            else
            {
                Speak("I Cant Recognize this Retro, You have to manually Find these BGs from :furni !");
            }
        }

        private readonly List<int> BSSBG = new List<int> {123896125, 3996};

        private readonly List<int> BobbaBG = new List<int> { 3821 };

        private List<int> GetRoomBGIDs()
        {
            if (KnownDomains.isBobbaHotel)
            {
                return BobbaBG;
            }
            if (KnownDomains.isBSSHotel)
            {
                return BSSBG;
            }
            else
            {
                return null;
            }
        }

        private void AutomaticFloorFurniPicker(int typeid)
        {
            if (isAutomaticClientMode)
            {
                SnapshotHFloorObjects.Clear();
                SnapshotWallItems.Clear();
                Speak("Hiding Furnis in Client-side", 34);
                IS_PICKING_FLOOR_FURNITYPE_CS = true;
                IS_TARGET_FLOORFURNI = true;
                IS_TARGET_WALLFURNI = false;
                TargetFurniType = typeid;
                SetFurnisSnapshot();
                RemoveSelectedFloorFurniCS();
                ShouldUnlockTypeIDPicker(false);
            }
            else
            {
                if(isAutomaticServerMode)
                {
                    SnapshotHFloorObjects.Clear();
                    SnapshotWallItems.Clear();
                    Speak("Removing Furnis in Server-side", 34);
                    IS_PICKING_FLOOR_FURNITYPE_SS = true;
                    IS_TARGET_FLOORFURNI = true;
                    IS_TARGET_WALLFURNI = false;
                    TargetFurniType = typeid;
                    SetFurnisSnapshot();
                    RemoveSelectedFloorFurniTypeSS();
                    ShouldUnlockTypeIDPicker(false);
                }
            }
        }

        private void AutomaticWallFurniPicker(int typeid)
        {
            if (isAutomaticClientMode)
            {
                SnapshotHFloorObjects.Clear();
                SnapshotWallItems.Clear();
                Speak("Hiding Furnis in Client-side", 34);
                IS_PICKING_WALL_FURNITYPE_CS = true;
                IS_TARGET_FLOORFURNI = false;
                IS_TARGET_WALLFURNI = true;
                TargetFurniType = typeid;
                SetFurnisSnapshot();
                RemoveSelectedWallFurniCS();
                ShouldUnlockTypeIDPicker(false);
            }
            else
            {
                if (isAutomaticServerMode)
                {
                    SnapshotHFloorObjects.Clear();
                    SnapshotWallItems.Clear();
                    Speak("Removing Furnis in Server-side", 34);
                    IS_PICKING_WALL_FURNITYPE_SS = true;
                    IS_TARGET_FLOORFURNI = false;
                    IS_TARGET_WALLFURNI = true;
                    TargetFurniType = typeid;
                    SetFurnisSnapshot();
                    RemoveSelectedWallFurniSS();
                    ShouldUnlockTypeIDPicker(false);
                }
            }
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
                Speak("Please Put a target badge to find!", 34);
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
                Speak("Please Put a target badge to find!", 34);
            }
        }

        private void PickerDefaultPickBtn_Click(object sender, EventArgs e)
        {
            AutomaticPickerMode();
        }

        private void PickerIsAutomaticBtn_Click(object sender, EventArgs e)
        {
            if(isAutomaticPicker)
            {
                WriteToButton(PickerIsAutomaticBtn, "Automatic : OFF");
                isAutomaticPicker = false;
            }
            else
            {
                WriteToButton(PickerIsAutomaticBtn, "Automatic : ON");
                Speak("The picker will grab anything you double-click by now!");
                isAutomaticPicker = true;
            }
        }

        private void AutomaticPickerMode()
        {
            if(isAutomaticServerMode)
            {
                isAutomaticServerMode = false;
                isAutomaticClientMode = true;
                Speak("The automatic picker will grab anything client-side!");
                WriteToButton(PickerDefaultPickBtn, "Client-side");
                return;
            }
            else
            {
                if (isAutomaticClientMode)
                {
                    isAutomaticServerMode = true;
                    isAutomaticClientMode = false;
                    Speak("DANGER!!!: The automatic picker will grab anything server-side!");
                    WriteToButton(PickerDefaultPickBtn, "Server-side");
                    return;
                }
            }

        }
    }
}