using System;
using System.ComponentModel;
using System.Windows.Forms;
using RetroFun.Controls;
using Sulakore.Communication;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class FurniturePage : ObservablePage
    {
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


            if (Program.Master != null)
            {
                Triggers.OutAttach(Out.RoomPickupItem, RoomPickupItem);
                //Triggers.OutAttach(Out.RotateMoveItem, RotateMoveItems);
                //Triggers.InAttach(In.FloorItemUpdate, temporary);
            }
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
            }
        }
        private void ToggleWallItem(DataInterceptedEventArgs obj)
        {
            if (DoubleClickFurnitureRemoval)
            {
                obj.IsBlocked = true;
                RemoveWallItem(obj.Packet.ReadInteger().ToString());
            }
        }
        private void ToggleFloorItem(DataInterceptedEventArgs obj)
        {
            if (DoubleClickFurnitureRemoval)
            {
                obj.IsBlocked = true;
                RemoveFloorItem(obj.Packet.ReadInteger().ToString());
            }
        }
        //private void temporary(DataInterceptedEventArgs obj)
        //{
        //    int one = obj.Packet.ReadInteger();
        //    int two = obj.Packet.ReadInteger();
        //    int three = obj.Packet.ReadInteger();
        //    int four = obj.Packet.ReadInteger();
        //    int six = obj.Packet.ReadInteger();
        //    int seven = obj.Packet.ReadInteger();
        //    int eight = obj.Packet.ReadInteger();
        //    int nine = obj.Packet.ReadInteger();
        //    int ten = obj.Packet.ReadInteger();
        //    int undici = obj.Packet.ReadInteger();
        //    int dodici = obj.Packet.ReadInteger();
        //    int tredici = obj.Packet.ReadInteger();


        //    if (ButtonRotateMoveItem)
        //    {

        //        obj.IsBlocked = false;

        //    }
        //}

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
    }
}