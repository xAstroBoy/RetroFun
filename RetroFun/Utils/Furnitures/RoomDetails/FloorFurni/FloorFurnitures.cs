using Sulakore.Habbo;
using Sulakore.Protocol;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroFun.Utils.Furnitures.Furni
{
    public class FloorFurnitures
    {

        public static List<HFloorItem> Furni = new List<HFloorItem>();
        public static List<HFloorItem> RemFurni = new List<HFloorItem>();

        public static List<HFloorItem> Snapshot_Floor_Furnis_in_room = new List<HFloorItem>();


        public static void ClearFurnis()
        {
            Furni.Clear();
            RemFurni.Clear();
            Snapshot_Floor_Furnis_in_room.Clear();
        }

        public static void HandleRemovedFurni(HFloorItem item)
        {
            if (Furni.Contains(item))
            {
                Furni.Remove(item);
            }
            if (!RemFurni.Contains(item))
            {
                RemFurni.Add(item);
            }
        }


        public static HFloorItem FindFloorFurni(int id)
        {
            return Furni.Find(f => f.Id == id);
        }
        public static HFloorItem FindFloorFurniForTypeID(int typeid)
        {
            return Furni.Find(f => f.TypeId == typeid);
        }

        public static void UpdateFloorFurniFacing(int id, int facing)
        {
            if (facing == 0)
            {
                UpdateFurniFacing(id, HDirection.North);
            }
            else if (facing == 1)
            {
                UpdateFurniFacing(id, HDirection.NorthEast);
            }
            else if (facing == 2)
            {
                UpdateFurniFacing(id, HDirection.East);
            }
            else if (facing == 3)
            {
                UpdateFurniFacing(id, HDirection.SouthEast);
            }
            else if (facing == 4)
            {
                UpdateFurniFacing(id, HDirection.South);
            }
            else if (facing == 5)
            {
                UpdateFurniFacing(id, HDirection.SouthWest);
            }
            else if (facing == 6)
            {
                UpdateFurniFacing(id, HDirection.West);
            }
            else if (facing == 7)
            {
                UpdateFurniFacing(id, HDirection.NorthWest);
            }
        }

        public static void UpdateFurniFacing(int id, HDirection direction)
        {
            try {
                if (Furni.Find(f => f.Id == id) != null) { Furni.Find(f => f.Id == id).Facing = direction; }
                if (RemFurni.Find(f => f.Id == id) != null) { RemFurni.Find(f => f.Id == id).Facing = direction; }
                if (Snapshot_Floor_Furnis_in_room.Find(f => f.Id == id) != null) { Snapshot_Floor_Furnis_in_room.Find(f => f.Id == id).Facing = direction; }
            
            }
            catch (Exception) { }

        }

        public static  List<HFloorItem> GetFloorFurnis()
        {
            return Furni.ToList();
        }





        public static void UpdateFloorFurniPosition(int id, int x, int y, string z)
        {
            try
            {
                if (decimal.TryParse(z, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal value))
                {
                    double dectodouble = (double)value;
                    if (Furni.Find(f => f.Id == id) != null) { Furni.Find(f => f.Id == id).Tile = new HPoint(x, y, dectodouble); }
                    if (RemFurni.Find(f => f.Id == id) != null) { RemFurni.Find(f => f.Id == id).Tile = new HPoint(x, y, dectodouble); }
                    if (Snapshot_Floor_Furnis_in_room.Find(f => f.Id == id) != null) { Snapshot_Floor_Furnis_in_room.Find(f => f.Id == id).Tile = new HPoint(x, y, dectodouble); }
                }
            }
            catch(Exception) { }
        }

       
        public static HMessage PacketBuilder(IList<HFloorItem> objects, ushort header)
        {
            var ret = new HMessage(header);

            var l = objects.ToList();

            var ownersCount = l.GroupBy(x => x.OwnerId).Select(g => g.First()).ToList();

            ret.WriteInteger(ownersCount.Count());

            foreach (var owner in ownersCount)
            {
                ret.WriteInteger(owner.OwnerId);
                ret.WriteString(owner.OwnerName);
            }

            ret.WriteInteger(objects.Count);

            foreach (var obj in objects)
            {
                ret.WriteInteger(obj.Id);
                ret.WriteInteger(obj.TypeId);
                ret.WriteInteger(obj.Tile.X);
                ret.WriteInteger(obj.Tile.Y);
                ret.WriteInteger((int)obj.Facing);
                ret.WriteString(obj.Tile.Z.ToString("0.0", CultureInfo.InvariantCulture));
                ret.WriteString("1.0");
                ret.WriteInteger(0); // LinkedPortId (maybe not a good idea but we don't know the value)
                ret.WriteInteger(obj.Category);

                var stuff = obj.Stuff.ToList();

                foreach (var thing in stuff)
                {
                    if (thing is string)
                        ret.WriteString((string)thing);
                    else if (thing is int)
                        ret.WriteInteger((int)thing);
                }

                ret.WriteInteger(obj.SecondsToExpiration);
                ret.WriteInteger((int)obj.UsagePolicy);

                ret.WriteInteger(obj.OwnerId);

                if (obj.TypeId < 0)
                    ret.WriteString(""); // no idea about this one tbh
            }
            return ret;
        }

    }
}
