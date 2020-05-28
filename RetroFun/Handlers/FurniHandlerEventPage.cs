﻿using RetroFun.Globals;
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
                    var NewFloorFurnis = new HFloorItem(e.Packet);
                    if (RemFloorFurni.Contains(NewFloorFurnis))
                    {
                        RemFloorFurni.Remove(NewFloorFurnis);
                    }
                    if (!RoomFloorFurni.Contains(NewFloorFurnis))
                    {
                        RoomFloorFurni.Add(NewFloorFurnis);
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
                    var NewPlacedWallFurni = new HWallItem(e.Packet);
                    if (RemWallFurni.Contains(NewPlacedWallFurni))
                    {
                        RemWallFurni.Remove(NewPlacedWallFurni);
                    }
                    if (!RoomWallFurni.Contains(NewPlacedWallFurni))
                    {
                        RoomWallFurni.Add(NewPlacedWallFurni);
                    }
                }
                catch (Exception) { }
            }
        }


        private void HandleRemovedFurni(HWallItem item)
        {
            if (RoomWallFurni.Contains(item))
            {
                RoomWallFurni.Remove(item);
            }
            if (!RemWallFurni.Contains(item))
            {
                RemWallFurni.Add(item);
            }
        }

        private void HandleRemovedFurni(HFloorItem item)
        {
            if (RoomFloorFurni.Contains(item))
            {
                RoomFloorFurni.Remove(item);
            }
            if (!RemFloorFurni.Contains(item))
            {
                RemFloorFurni.Add(item);
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


        public override void In_RoomData(DataInterceptedEventArgs e)
        {
            e.Packet.ReadBoolean();
            Room_ID = e.Packet.ReadInteger();
            Room_name = e.Packet.ReadString();
            e.Packet.ReadInteger();
            Room_Owner = e.Packet.ReadString();
        }


        public override void Out_RotateMoveItem(DataInterceptedEventArgs e)
        {
            if (!KnownDomains.isHartico)
            {
                int FurniID = e.Packet.ReadInteger();
                int x = e.Packet.ReadInteger();
                int y = e.Packet.ReadInteger();
                int z = e.Packet.ReadInteger();
                UpdateFurniMovement(FurniID, x, y, z);
                e.Packet.Position = 0;
                e.Continue();
            }
        }

        private void UpdateFurniMovement(HFloorItem furni, int Coord_x, int Coord_y, string Coord_z)
        {
            var roomfurni = RoomFloorFurni.Find(x => x == furni);
            var remfoundfurni = RemFloorFurni.Find(x => x == furni);

            if (roomfurni != null)
            {
                roomfurni.Tile.X = Coord_x;
                roomfurni.Tile.Y = Coord_y;
                if (Double.TryParse(Coord_z, out Double res))
                {
                    roomfurni.Tile.Z = res;
                }
            }
            if (remfoundfurni != null)
            {
                remfoundfurni.Tile.X = Coord_x;
                remfoundfurni.Tile.Y = Coord_y;
                if (Double.TryParse(Coord_z, out Double res))
                {
                    remfoundfurni.Tile.Z = res;
                }
            }

        }

        private void UpdateFurniMovement(HFloorItem furni, int Coord_x, int Coord_y)
        {
            var roomfurni = RoomFloorFurni.Find(x => x == furni);
            var remfoundfurni = RemFloorFurni.Find(x => x == furni);

            if (roomfurni != null)
            {
                roomfurni.Tile.X = Coord_x;
                roomfurni.Tile.Y = Coord_y;
            }
            if (remfoundfurni != null)
            {
                remfoundfurni.Tile.X = Coord_x;
                remfoundfurni.Tile.Y = Coord_y;
            }
        }
        private void HandleRemovedFurni(string item)
        {
            if (int.TryParse(item, out int furni))
            {
                var foundfurni = RoomFloorFurni.Find(f => f.Id == furni);
                var wallfurni = RoomWallFurni.Find(f => f.Id == furni);
                var remfoundfurni = RemFloorFurni.Find(f => f.Id == furni);
                var remwallfurni = RemWallFurni.Find(f => f.Id == furni);
                if (foundfurni != null)
                {
                    HandleRemovedFurni(foundfurni);
                    if (KnownDomains.isBobbaHotel)
                    {
                        FloorFurniCheck.HandleRemovedFurni(foundfurni);
                    }
                    return;
                }
                if (wallfurni != null)
                {
                    HandleRemovedFurni(wallfurni);
                    if (KnownDomains.isBobbaHotel)
                    {
                        WallFurniCheck.HandleRemovedFurni(wallfurni);
                    }
                    return;
                }
                if (remfoundfurni != null)
                {
                    HandleRemovedFurni(remfoundfurni);
                    return;
                }
                if (remwallfurni != null)
                {
                    HandleRemovedFurni(remwallfurni);
                    return;
                }
                return;
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
        private void UpdateFurniMovement(int furni, int Coord_x, int Coord_y, int Coord_z)
        {
            var roomfurni = RoomFloorFurni.Find(x => x.Id == furni);
            if (roomfurni != null)
            {
                UpdateFurniMovement(roomfurni, Coord_x, Coord_y, Coord_z);
                return;
            }
        }

        private void UpdateFurniMovement(HFloorItem furni, int Coord_x, int Coord_y, int Coord_z)
        {
            var roomfurni = RoomFloorFurni.Find(x => x == furni);
            var wallremitem = RemFloorFurni.Find(x => x == furni);
            if (roomfurni != null)
            {
                roomfurni.Tile.X = Coord_x;
                roomfurni.Tile.Y = Coord_y;
                roomfurni.Tile.Z = Coord_z;
            }
            if (wallremitem != null)
            {
                wallremitem.Tile.X = Coord_x;
                wallremitem.Tile.Y = Coord_y;
                wallremitem.Tile.Z = Coord_z;
            }
        }


        private void UpdateFurniMovement(int furni, string wallcoord)
        {
            var WallFurni = RoomWallFurni.Find(x => x.Id == furni);
            var wallremitem = RemWallFurni.Find(x => x.Id == furni);

            if (WallFurni != null)
            {
                UpdateFurniMovement(WallFurni, wallcoord);
                return;
            }
            if (wallremitem != null)
            {
                UpdateFurniMovement(wallremitem, wallcoord);
                return;
            }
        }

        private void UpdateFurniMovement(HWallItem furni, string wallcoord)
        {
            var wallitem = RoomWallFurni.Find(x => x == furni);
            var wallremitem = RemWallFurni.Find(x => x == furni);

            if (wallitem != null)
            {
                wallitem.Location = wallcoord;
            }

            if (wallremitem != null)
            {
                wallremitem.Location = wallcoord;
            }


        }

        public override void Out_RequestRoomLoad(DataInterceptedEventArgs e)
        {
            if (!KnownDomains.isHartico)
            {
                RoomFloorFurni.Clear();
                RoomWallFurni.Clear();
                RemWallFurni.Clear();
                RemFloorFurni.Clear();
            }
        }


        public override void Out_RequestRoomHeightmap(DataInterceptedEventArgs e)
        {
            if (!KnownDomains.isHartico)
            {
                RoomFloorFurni.Clear();
                RoomWallFurni.Clear();
                RemWallFurni.Clear();
                RemFloorFurni.Clear();
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
