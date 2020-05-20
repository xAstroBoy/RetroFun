using Sulakore.Habbo;
using Sulakore.Protocol;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroFun.Utils.Furnitures.WallFurni
{
    public class FloorFurnitures
    {

        public static List<HFloorItem> Furni = new List<HFloorItem>();
        public static List<HFloorItem> RemFurni = new List<HFloorItem>();

        public static List<HFloorItem> Snapshot_Floor_Furnis_in_room = new List<HFloorItem>();


        public static List<HFloorItem> GetFloorFurnis()
        {
            return Furni;
        }

        public static void SetSnapshotFloor()
        {
            Snapshot_Floor_Furnis_in_room = GetFloorFurnis();
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
