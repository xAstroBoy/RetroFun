using RetroFun.Globals;
using RetroFun.Helpers;
using RetroFun.Pages;
using RetroFun.Subscribers;
using RetroFun.Utils.Furnitures.FloorFurni;
using RetroFun.Utils.Furnitures.WallFurni;
using RetroFun.Utils.Globals;
using RetroFun.Utils.HostFinder.BobbaItalia;
using Sulakore.Communication;
using Sulakore.Habbo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace RetroFun.Handlers
{
    public partial class FurniHandlerEventPage :  ObservablePage
    {

        public FurniHandlerEventPage()
        {
        }

        public int Room_ID { get => GlobalInts.ROOM_ID; set { GlobalInts.ROOM_ID = value; } }
        public string Room_Owner { get => GlobalStrings.ROOM_OWNER; set { GlobalStrings.ROOM_OWNER = value; } }
        public string Room_name { get => GlobalStrings.ROOM_NAME; set { GlobalStrings.ROOM_NAME = value; } }


        private List<HFloorItem> RoomFloorFurni
        {
            get => FloorFurnitures.Furni;
            set
            {
                FloorFurnitures.Furni = value;
                RaiseOnPropertyChanged();
            }
        }

        private List<HFloorItem> RemFloorFurni
        {
            get => FloorFurnitures.RemFurni;
            set
            {
                FloorFurnitures.RemFurni = value;
                RaiseOnPropertyChanged();
            }
        }

        private List<HWallItem> RemWallFurni
        {
            get => WallFurnitures.RemFurni;
            set
            {
                WallFurnitures.RemFurni = value;
                RaiseOnPropertyChanged();
            }
        }

        private List<HWallItem> RoomWallFurni
        {
            get => WallFurnitures.Furni;
            set
            {
                WallFurnitures.Furni = value;
                RaiseOnPropertyChanged();
            }
        }


        public override void In_RoomFloorItems(DataInterceptedEventArgs e)
        {
            if (!KnownDomains.isHartico)
            {
                RoomFloorFurni = HFloorItem.Parse(e.Packet).ToList(); //All Floor Objects
                e.Continue();
            }
        }


        public override void In_AddFloorItem(DataInterceptedEventArgs e)
        {
            if (!KnownDomains.isHartico)
            {
                try
                {
                    var furni = new HFloorItem(e.Packet);
                    if (RemFloorFurni.Contains(furni))
                    {
                        RemFloorFurni.Remove(furni);
                    }
                    if (!RoomFloorFurni.Contains(furni))
                    {
                        RoomFloorFurni.Add(furni);
                    }
                    if (KnownDomains.isBobbaHotel)
                    {
                        FloorFurniCheck.HandleAddedFurni(furni);
                    }
                }
                catch (Exception) { }
            }
        }

        public override void In_RoomWallItems(DataInterceptedEventArgs e)
        {
            if (!KnownDomains.isHartico)
            {
                if (KnownDomains.isBobbaHotel)
                {
                    RoomWallFurni = WallFurnitures.BobbaParser(e.Packet);
                }
                else
                {
                    RoomWallFurni = HWallItem.Parse(e.Packet).ToList();
                }
            }
        }

        public override void In_AddWallItem(DataInterceptedEventArgs e)
        {
            if (!KnownDomains.isHartico)
            {
                try
                {
                    var furni = new HWallItem(e.Packet);
                    if (RemWallFurni.Contains(furni))
                    {
                        RemWallFurni.Remove(furni);
                    }
                    if (!RoomWallFurni.Contains(furni))
                    {
                        RoomWallFurni.Add(furni);
                    }
                    if (KnownDomains.isBobbaHotel)
                    {
                        WallFurniCheck.HandleAddedFurni(furni);
                    }
                }
                catch (Exception) { }
            }
        }







        public override void In_WallItemUpdate(DataInterceptedEventArgs e)
        {
            string FurniID = e.Packet.ReadString();
            int typeIdIguess = e.Packet.ReadInteger();
            string newLocation = e.Packet.ReadString();
            WallFurnitures.UpdateWallFurniPosition(FurniID, newLocation);
            if(KnownDomains.isBobbaHotel)
            {
                WallFurniCheck.UpdateWallFurniPosition(FurniID, newLocation);
            }
            e.Packet.Position = 0;
            e.Continue();
        }





        public override void In_FloorItemUpdate(DataInterceptedEventArgs e)
        {
            if (KnownDomains.isBobbaHotel)
            {
                int FurniID = e.Packet.ReadInteger();
                int typeId = e.Packet.ReadInteger();
                int x = e.Packet.ReadInteger();
                int y = e.Packet.ReadInteger();
                int facingprob = e.Packet.ReadInteger();
                string z = e.Packet.ReadString();

                FloorFurnitures.UpdateFloorFurniPosition(FurniID, x, y, z);
                FloorFurnitures.UpdateFloorFurniFacing(FurniID, facingprob);
                if (KnownDomains.isBobbaHotel)
                {
                    FloorFurniCheck.UpdateFloorFurniFacing(FurniID, facingprob);
                    FloorFurniCheck.updateFloorFurniPosition(FurniID, x, y, z);
                }

                e.Packet.Position = 0;
                e.Continue();
            }
        }


        public override void In_RoomData(DataInterceptedEventArgs e)
        {
            e.Packet.ReadBoolean();
            Room_ID = e.Packet.ReadInteger();
            Room_name = e.Packet.ReadString();
            e.Packet.ReadInteger();
            Room_Owner = e.Packet.ReadString();
        }


        private void HandleRemovedFurni(string item)
        {
            if (int.TryParse(item, out int furni))
            {
                var foundfurni = RoomFloorFurni.Find(f => f.Id == furni);
                var wallfurni = RoomWallFurni.Find(f => f.Id == furni);
                if (foundfurni != null)
                {
                    FloorFurnitures.HandleRemovedFurni(foundfurni);
                    if (KnownDomains.isBobbaHotel)
                    {
                        FloorFurniCheck.HandleRemovedFurni(foundfurni);
                    }
                    return;
                }
                if (wallfurni != null)
                {
                    WallFurnitures.HandleRemovedFurni(wallfurni);
                    if (KnownDomains.isBobbaHotel)
                    {
                        WallFurniCheck.HandleRemovedFurni(wallfurni);
                    }
                    return;
                }
            }
        }


        public override void Out_RequestRoomLoad(DataInterceptedEventArgs e)
        {
            if (!KnownDomains.isHartico)
            {
                ClearRoomFurnis();
            }
        }


        private void ClearRoomFurnis()
        {
            FloorFurnitures.ClearFurnis();
            WallFurnitures.ClearFurnis();
        }

        public override void Out_RequestRoomHeightmap(DataInterceptedEventArgs e)
        {
            if (!KnownDomains.isHartico)
            {
                ClearRoomFurnis();
            }
        }

        public override void In_RemoveFloorItem(DataInterceptedEventArgs e)
        {
            if (!KnownDomains.isHartico)
            {
                HandleRemovedFurni(e.Packet.ReadString());
                e.Continue();
            }
        }

        public override void In_RemoveWallItem(DataInterceptedEventArgs e)
        {
            if (!KnownDomains.isHartico)
            {
                HandleRemovedFurni(e.Packet.ReadString());
                e.Continue();
            }
        }
    }
}
