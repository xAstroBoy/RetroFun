using RetroFun.Controls;
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
    public partial class FurniturePage : ObservablePage
    {
        private HMessage FurniDataStored;

        private bool _doubleClickFurnitureRemoval;
        private bool liveEditFloorFurni;
        private bool FloorFurniInterceptionMode;

        private int _FloorFurniID;


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

        public FurniturePage()
        {
            InitializeComponent();

            Bind(FurnitureIDTxt, "Text", nameof(FurnitureIdText));
            Bind(DoubleClickFurnitureRemovalChbx, "Checked", nameof(DoubleClickFurnitureRemoval));
            Bind(FurniPickChbx, "Checked", nameof(FurniPickedOutput));


            Bind(FloorFurniIDNbx, "Value", nameof(FloorFurniID));
            Bind(FloorFurniXNbx, "Value", nameof(FloorFurniX));
            Bind(FloorFurniYNbx, "Value", nameof(FloorFurniY));
            Bind(FloorFurniLiveEditCooldownNbx, "Value", nameof(FloorFurniLiveEditCooldown));


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

        private void RotationUp_CheckedChanged(object sender, EventArgs e)
        {
            FloorFurniRotation = 6;
            Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);

        }

        private void RotationRight_CheckedChanged(object sender, EventArgs e)
        {
            FloorFurniRotation = 0;
            Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);

        }

        private void RotationDown_CheckedChanged(object sender, EventArgs e)
        {
            FloorFurniRotation = 2;
            Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);

        }

        private void rotationLeft_CheckedChanged(object sender, EventArgs e)
        {
            FloorFurniRotation = 4;
            Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);

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

        //private void StartLiveFloorFurniEditor()
        //{
        //    new Thread(() =>
        //    {
        //        Thread.CurrentThread.IsBackground = true;
        //        do
        //        {

        //            if (liveEditFloorFurni)
        //            {
        //                Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);
        //                Thread.Sleep(FloorFurniLiveEditCooldown);
        //            }
        //        } while (liveEditFloorFurni);
        //    }).Start();
        //}



        private void LiveEditFloorFurniBtn_Click(object sender, EventArgs e)
        {
            if (liveEditFloorFurni)
            {
                WriteToButton(LiveEditFloorFurniBtn, "Live Edit : OFF");
                liveEditFloorFurni = false;
            }
            else
            {

                WriteToButton(LiveEditFloorFurniBtn, "Live Edit : ON");
                liveEditFloorFurni = true;
                //StartLiveFloorFurniEditor();
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

        private void FloorFurniXNbx_ValueChanged(object sender, EventArgs e)
        {
            Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);
        }

        private void FloorFurniYNbx_ValueChanged(object sender, EventArgs e)
        {
            Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);
        }
    }
}