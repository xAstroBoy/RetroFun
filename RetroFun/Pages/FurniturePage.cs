using System;
using System.ComponentModel;
using System.Windows.Forms;
using RetroFun.Controls;
using Sulakore.Communication;
using Sulakore.Protocol;

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
            Bind(ToggleFurniRotCS, "Checked", nameof(ButtonRotateMoveItem));
            Bind(FurniPickChbx, "Checked", nameof(FurniPickedOutput));

            if (Program.Master != null)
            {
                Triggers.OutAttach(Out.RoomPickupItem, RoomPickupItem);
                Triggers.InAttach(In.RoomFloorItems, StoreRoomFurniData);
            }
        }


        private void StoreRoomFurniData(DataInterceptedEventArgs obj)
        {
            FurniDataStored = obj.Packet;
            obj.Continue();
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

            Connection.SendToClientAsync(In.FloorItemUpdate, furnitureId, 0, two, three, 0, Rotation, 0, 0, 0, 0, 0, 0, 0);
        }



        private void RemoveWallItem(string furnitureId)
        {
            Connection.SendToClientAsync(In.RemoveWallItem, furnitureId, 0);
        }
        private void RemoveFloorItem(string furnitureId)
        {
            Connection.SendToClientAsync(In.RemoveFloorItem, furnitureId, false, 0, 0);
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
            Connection.SendToClientAsync(In.UserPermissions, int.MaxValue, int.MaxValue, true);
        }

        private void RestoreFurnisBtn_Click(object sender, EventArgs e)
        {
            if (FurniDataStored != null)
            {
                Connection.SendToClientAsync(FurniDataStored);
            }
            else
            {
                Speak("Stored Furnidata is empty! Try refreshing the room!");

            }
        }


        private void Speak(string text)
        {
            Connection.SendToClientAsync(In.RoomUserWhisper, 0, text , 0, 1, 0, -1);

        }

    }
}