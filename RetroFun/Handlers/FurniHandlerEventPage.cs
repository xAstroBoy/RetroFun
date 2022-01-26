using RetroFun.Globals;
using RetroFun.Helpers;
using RetroFun.Pages;
using RetroFun.Subscribers;
using RetroFun.Utils.Furnitures.Furni;
using RetroFun.Utils.Globals;
using RetroFun.Utils.HostFinder.BobbaItalia;
using Geode.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using Geode.Habbo.Packages;

namespace RetroFun.Handlers
{
    public partial class FurniHandlerEventPage : ObservablePage
    {

        public FurniHandlerEventPage()
        {
        }

        public int Room_ID { get => GlobalInts.ROOM_ID; set { GlobalInts.ROOM_ID = value; } }
        public string Room_Owner { get => GlobalStrings.ROOM_OWNER; set { GlobalStrings.ROOM_OWNER = value; } }
        public string Room_name { get => GlobalStrings.ROOM_NAME; set { GlobalStrings.ROOM_NAME = value; } }

        private List<HFloorObject> RoomFloorFurni
        {
            get => FloorFurnitures.Furni;
            set
            {
                FloorFurnitures.Furni = value;
                RaiseOnPropertyChanged();
            }
        }

        private List<HFloorObject> RemFloorFurni
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

        public override void In_RoomHFloorObjects(DataInterceptedEventArgs e)
        {
            if (!KnownDomains.isHartico)
            {
                RoomFloorFurni = HFloorObject.Parse(e.Packet).ToList(); //All Floor Objects
                e.Continue();
            }
        }

        //private void UpdateBothFurniById(int furniid , dynamic stuff)
        //{
        //    if(FloorFurnitures.FindFloorFurni(furniid) != null)
        //    {

        //    }
        //}

        // TODO: ASK THE ORIGINAL CREATOR FOR THE EXTRADATA UPDATER

        //public override void In_ItemExtraData(DataInterceptedEventArgs e)
        //{
        //    int items = e.Packet.ReadInt32();

        //        dynamic item = new ExpandoObject();

        //        int FurniID = e.Packet.ReadInt32();

        //        int spriteId = e.Packet.ReadInt32();
        //        item.spriteId = spriteId;

        //        int x = e.Packet.ReadInt32(); // X
        //        item.x = x;

        //        int y = e.Packet.ReadInt32(); // Y
        //        item.y = y;

        //        int rotation = e.Packet.ReadInt32(); // Rotation //Direction
        //        item.rotation = rotation;

        //        string height = e.Packet.ReadUTF8(); // Height
        //        item.height = height; //z position = furniture placement

        //        string sizeZ = e.Packet.ReadUTF8();
        //        item.sizeZ = sizeZ; //z dimensions = furniture height

        //        int extraDataPerspective = e.Packet.ReadInt32();//_local_3._SafeStr_6897 = k._SafeStr_5432();
        //        item.extraDataVariable = extraDataPerspective;

        //        int extraDataType = e.Packet.ReadInt32();//var _local_2:int = k._SafeStr_5432
        //        item.extraDataId = extraDataType;

        //        //4 hex nibbles store 2 values:
        //        //hex nibbles 1-2 for extraDataType //https://github.com/xnumad/HabboSwfOpenSource/blob/master/src/com/sulake/habbo/room/object/data/StuffDataFactory.as#L10
        //        //hex nibbles 3-4 for LTD
        //        //
        //        //Example:
        //        //   LTD extraDataType
        //        //0x 01  03

        //        bool LTD = false;
        //        if (extraDataType > 0xFF) //LTD indication
        //        {
        //            LTD = true;
        //            extraDataType &= 0xFF; //trim value for extraDataType
        //        }

        //        //https://github.com/JasonWibbo/HabboSwfOpenSource/tree/master/src/com/sulake/habbo/room/object/data
        //        //https://github.com/JasonWibbo/HabboSwfOpenSource/blob/master/src/com/sulake/habbo/room/object/data/StuffDataFactory.as
        //        //https://github.com/JasonWibbo/HabboSwfOpenSource/blob/master/src/com/sulake/habbo/room/IStuffData.as

        //        if (extraDataType == 0) // String //Legacy //https://github.com/JasonWibbo/HabboSwfOpenSource/blob/master/src/com/sulake/habbo/room/object/data/LegacyStuffData.as#L15
        //        {
        //            string extraDataString = e.Packet.ReadUTF8();
        //            item.extraDataString = extraDataString;
        //        }

        //        else if (extraDataType == 1) // Key value //Map //https://github.com/JasonWibbo/HabboSwfOpenSource/blob/master/src/com/sulake/habbo/room/object/data/MapStuffData.as#L28
        //        {
        //            int strings = e.Packet.ReadInt32();
        //            item.keyValue = new Dictionary<string, string>();

        //            for (int j = 0; j < strings; j++)
        //            {
        //                string key = e.Packet.ReadUTF8();
        //                string value = e.Packet.ReadUTF8();

        //                item.keyValue.Add(key, value);
        //            }
        //        }

        //        else if (extraDataType == 2) // String array //https://github.com/JasonWibbo/HabboSwfOpenSource/blob/master/src/com/sulake/habbo/room/object/data/StringArrayStuffData.as
        //        {
        //            int strings = e.Packet.ReadInt32();
        //            item.strings = new List<String>();

        //            for (int j = 0; j < strings; j++)
        //            {
        //                string str = e.Packet.ReadUTF8();
        //                item.strings.Add(str);
        //            }
        //        }

        //        else if (extraDataType == 3) //VoteResult //https://github.com/JasonWibbo/HabboSwfOpenSource/blob/master/src/com/sulake/habbo/room/object/data/VoteResultStuffData.as#L20
        //        {
        //            string state = e.Packet.ReadUTF8();
        //            item.state = state;

        //            int result = e.Packet.ReadInt32();
        //            item.result = result;
        //        }

        //        else if (extraDataType == 4) { } //Empty //https://github.com/JasonWibbo/HabboSwfOpenSource/blob/master/src/com/sulake/habbo/room/object/data/EmptyStuffData.as#L10

        //        else if (extraDataType == 5) // Integer array //https://github.com/JasonWibbo/HabboSwfOpenSource/blob/master/src/com/sulake/habbo/room/object/data/IntArrayStuffData.as#L22
        //        {
        //            int integers = e.Packet.ReadInt32();
        //            item.ints = new List<int>();

        //            for (int j = 0; j < integers; j++)
        //            {
        //                int number = e.Packet.ReadInt32();
        //                item.ints.Add(number);
        //            }
        //        }

        //        else if (extraDataType == 6) //high score //https://github.com/JasonWibbo/HabboSwfOpenSource/blob/master/src/com/sulake/habbo/room/object/data/HighScoreStuffData.as
        //        {
        //            item.state = e.Packet.ReadUTF8();
        //            item.scoretype = e.Packet.ReadInt32();
        //            item.clearType = e.Packet.ReadInt32();

        //            int amountScores = e.Packet.ReadInt32();
        //            item.scores = new List<dynamic>();

        //            for (int k = 0; k < amountScores; k++)
        //            {
        //                dynamic scoreData = new ExpandoObject();

        //                scoreData.score = e.Packet.ReadInt32();

        //                int amountUsers = e.Packet.ReadInt32();
        //                scoreData.users = new List<String>();

        //                for (int l = 0; l < amountUsers; l++)
        //                {
        //                    string username = e.Packet.ReadUTF8();
        //                    scoreData.users.Add(username);
        //                }

        //                itemData.scores.Add(scoreData);
        //            }
        //        }

        //        else if (extraDataType == 7) //crackable
        //        {
        //            item.state = e.Packet.ReadUTF8();

        //            item.hits = e.Packet.ReadInt32();

        //            item.target = e.Packet.ReadInt32();
        //        }

        //        else { }

        //        if (LTD)
        //        {
        //            item.uniqueSerialNumber = e.Packet.ReadInt32();
        //            item.uniqueSeriesSize = e.Packet.ReadInt32();
        //        }

        //        // More junk
        //        int rentTimeSecondsLeft = e.Packet.ReadInt32(); //rent time in seconds, or -1
        //        item.rentTimeSecondsLeft = rentTimeSecondsLeft;
        //        //https://github.com/JasonWibbo/HabboSwfOpenSource/blob/master/src/com/sulake/habbo/ui/widget/enums/RoomWidgetFurniInfoUsagePolicyEnum.as
        //        //https://github.com/JasonWibbo/HabboSwfOpenSource/blob/master/src/com/sulake/habbo/ui/widget/infostand/InfoStandFurniView.as#L506
        //        //int infostand text           opens on click
        //        //<0  infostand.button.buy,    catalog page
        //        //>=0 infostand.button.buyout  buy window directly

        //        int amountOfStates = e.Packet.ReadInt32(); //amount of states furni has. infostand shows use button in info, if 1 or 2
        //        item.amountOfStates = amountOfStates;

        //        int ownerId = e.Packet.ReadInt32();
        //        item.ownerId = ownerId; //Furniture owner ID
        //}

        public override void In_AddHFloorObject(DataInterceptedEventArgs e)
        {
            if (KnownDomains.isDomainRecognized)
            {
                if (!KnownDomains.isHartico)
                {
                    try
                    {
                        var furni = new HFloorObject(e.Packet);
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
        }

        public override void In_RoomWallItems(DataInterceptedEventArgs e)
        {
            if (KnownDomains.isDomainRecognized)
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
            string FurniID = e.Packet.ReadUTF8();
            int typeIdIguess = e.Packet.ReadInt32();
            string newLocation = e.Packet.ReadUTF8();
            WallFurnitures.UpdateWallFurniPosition(FurniID, newLocation);
            if (KnownDomains.isBobbaHotel)
            {
                WallFurniCheck.UpdateWallFurniPosition(FurniID, newLocation);
            }
            e.Packet.Position = 0;
            e.Continue();
        }

        public override void In_HFloorObjectUpdate(DataInterceptedEventArgs e)
        {

            int FurniID = e.Packet.ReadInt32();
            int typeId = e.Packet.ReadInt32();
            int x = e.Packet.ReadInt32();
            int y = e.Packet.ReadInt32();
            int facingprob = e.Packet.ReadInt32();
            string z = e.Packet.ReadUTF8();

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

        public override void In_RoomData(DataInterceptedEventArgs e)
        {
            e.Packet.ReadBoolean();
            Room_ID = e.Packet.ReadInt32();
            Room_name = e.Packet.ReadUTF8();
            e.Packet.ReadInt32();
            Room_Owner = e.Packet.ReadUTF8();
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

        public override void In_RemoveHFloorObject(DataInterceptedEventArgs e)
        {
            if (!KnownDomains.isHartico)
            {
                HandleRemovedFurni(e.Packet.ReadUTF8());
                e.Continue();
            }
        }

        public override void In_RemoveWallItem(DataInterceptedEventArgs e)
        {
            if (!KnownDomains.isHartico)
            {
                HandleRemovedFurni(e.Packet.ReadUTF8());
                e.Continue();
            }
        }
    }
}
