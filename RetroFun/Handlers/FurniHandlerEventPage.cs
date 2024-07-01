using RetroFun.Globals;
using RetroFun.Helpers;
using RetroFun.Pages;
using RetroFun.Subscribers;
using RetroFun.Utils.Furnitures.Furni;
using RetroFun.Utils.Globals;
using RetroFun.Utils.HostFinder.BobbaItalia;
using Sulakore.Communication;
using Sulakore.Habbo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.IO;
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

        //private void UpdateBothFurniById(int furniid , dynamic stuff)
        //{
        //    if(FloorFurnitures.FindFloorFurni(furniid) != null)
        //    {

        //    }
        //}

        // TODO: ASK THE ORIGINAL CREATOR FOR THE EXTRADATA UPDATER

        //public override void In_ItemExtraData(DataInterceptedEventArgs e)
        //{
        //    int items = e.Packet.ReadInteger();

        //        dynamic item = new ExpandoObject();

        //        int FurniID = e.Packet.ReadInteger();

        //        int spriteId = e.Packet.ReadInteger();
        //        item.spriteId = spriteId;

        //        int x = e.Packet.ReadInteger(); // X
        //        item.x = x;

        //        int y = e.Packet.ReadInteger(); // Y
        //        item.y = y;

        //        int rotation = e.Packet.ReadInteger(); // Rotation //Direction
        //        item.rotation = rotation;

        //        string height = e.Packet.ReadString(); // Height
        //        item.height = height; //z position = furniture placement

        //        string sizeZ = e.Packet.ReadString();
        //        item.sizeZ = sizeZ; //z dimensions = furniture height

        //        int extraDataPerspective = e.Packet.ReadInteger();//_local_3._SafeStr_6897 = k._SafeStr_5432();
        //        item.extraDataVariable = extraDataPerspective;

        //        int extraDataType = e.Packet.ReadInteger();//var _local_2:int = k._SafeStr_5432
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
        //            string extraDataString = e.Packet.ReadString();
        //            item.extraDataString = extraDataString;
        //        }

        //        else if (extraDataType == 1) // Key value //Map //https://github.com/JasonWibbo/HabboSwfOpenSource/blob/master/src/com/sulake/habbo/room/object/data/MapStuffData.as#L28
        //        {
        //            int strings = e.Packet.ReadInteger();
        //            item.keyValue = new Dictionary<string, string>();

        //            for (int j = 0; j < strings; j++)
        //            {
        //                string key = e.Packet.ReadString();
        //                string value = e.Packet.ReadString();

        //                item.keyValue.Add(key, value);
        //            }
        //        }

        //        else if (extraDataType == 2) // String array //https://github.com/JasonWibbo/HabboSwfOpenSource/blob/master/src/com/sulake/habbo/room/object/data/StringArrayStuffData.as
        //        {
        //            int strings = e.Packet.ReadInteger();
        //            item.strings = new List<String>();

        //            for (int j = 0; j < strings; j++)
        //            {
        //                string str = e.Packet.ReadString();
        //                item.strings.Add(str);
        //            }
        //        }

        //        else if (extraDataType == 3) //VoteResult //https://github.com/JasonWibbo/HabboSwfOpenSource/blob/master/src/com/sulake/habbo/room/object/data/VoteResultStuffData.as#L20
        //        {
        //            string state = e.Packet.ReadString();
        //            item.state = state;

        //            int result = e.Packet.ReadInteger();
        //            item.result = result;
        //        }

        //        else if (extraDataType == 4) { } //Empty //https://github.com/JasonWibbo/HabboSwfOpenSource/blob/master/src/com/sulake/habbo/room/object/data/EmptyStuffData.as#L10

        //        else if (extraDataType == 5) // Integer array //https://github.com/JasonWibbo/HabboSwfOpenSource/blob/master/src/com/sulake/habbo/room/object/data/IntArrayStuffData.as#L22
        //        {
        //            int integers = e.Packet.ReadInteger();
        //            item.ints = new List<int>();

        //            for (int j = 0; j < integers; j++)
        //            {
        //                int number = e.Packet.ReadInteger();
        //                item.ints.Add(number);
        //            }
        //        }

        //        else if (extraDataType == 6) //high score //https://github.com/JasonWibbo/HabboSwfOpenSource/blob/master/src/com/sulake/habbo/room/object/data/HighScoreStuffData.as
        //        {
        //            item.state = e.Packet.ReadString();
        //            item.scoretype = e.Packet.ReadInteger();
        //            item.clearType = e.Packet.ReadInteger();

        //            int amountScores = e.Packet.ReadInteger();
        //            item.scores = new List<dynamic>();

        //            for (int k = 0; k < amountScores; k++)
        //            {
        //                dynamic scoreData = new ExpandoObject();

        //                scoreData.score = e.Packet.ReadInteger();

        //                int amountUsers = e.Packet.ReadInteger();
        //                scoreData.users = new List<String>();

        //                for (int l = 0; l < amountUsers; l++)
        //                {
        //                    string username = e.Packet.ReadString();
        //                    scoreData.users.Add(username);
        //                }

        //                itemData.scores.Add(scoreData);
        //            }
        //        }

        //        else if (extraDataType == 7) //crackable
        //        {
        //            item.state = e.Packet.ReadString();

        //            item.hits = e.Packet.ReadInteger();

        //            item.target = e.Packet.ReadInteger();
        //        }

        //        else { }

        //        if (LTD)
        //        {
        //            item.uniqueSerialNumber = e.Packet.ReadInteger();
        //            item.uniqueSeriesSize = e.Packet.ReadInteger();
        //        }

        //        // More junk
        //        int rentTimeSecondsLeft = e.Packet.ReadInteger(); //rent time in seconds, or -1
        //        item.rentTimeSecondsLeft = rentTimeSecondsLeft;
        //        //https://github.com/JasonWibbo/HabboSwfOpenSource/blob/master/src/com/sulake/habbo/ui/widget/enums/RoomWidgetFurniInfoUsagePolicyEnum.as
        //        //https://github.com/JasonWibbo/HabboSwfOpenSource/blob/master/src/com/sulake/habbo/ui/widget/infostand/InfoStandFurniView.as#L506
        //        //int infostand text           opens on click
        //        //<0  infostand.button.buy,    catalog page
        //        //>=0 infostand.button.buyout  buy window directly

        //        int amountOfStates = e.Packet.ReadInteger(); //amount of states furni has. infostand shows use button in info, if 1 or 2
        //        item.amountOfStates = amountOfStates;

        //        int ownerId = e.Packet.ReadInteger();
        //        item.ownerId = ownerId; //Furniture owner ID
        //}



        public override void In_AddFloorItem(DataInterceptedEventArgs e)
        {
            if (KnownDomains.isDomainRecognized)
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
