using System;
using System.ComponentModel;

using BobbaFun.Controls;
using Sulakore.Communication;

namespace BobbaFun.Pages
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

            if (Program.Master != null)
            {
                Triggers.OutAttach(Out.RoomPickupItem, RoomPickupItem);
                //Triggers.OutAttach(Out.ToggleWallItem, ToggleWallItem);
                //Triggers.OutAttach(Out.ToggleFloorItem, ToggleFloorItem);
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

        private void RemoveWallItem(string furnitureId)
        {
            Connection.SendToClientAsync(In.RemoveWallItem, furnitureId, 0);
        }
        private void RemoveFloorItem(string furnitureId)
        {
            Connection.SendToClientAsync(In.RemoveFloorItem, furnitureId, false, 0, 0);
        }
    }
}