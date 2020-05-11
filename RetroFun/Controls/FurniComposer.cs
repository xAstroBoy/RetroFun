using Sulakore.Habbo;
using Sulakore.Protocol;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroFun.Controls
{
    public static class FurniComposer
    {

        public static HMessage composer(this IList<HFloorItem> objects, ushort header)
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
        public static HMessage composer(this IList<HWallItem> items, ushort header)
        {
            var itemsMessage = new HMessage(header);
            var owners = items.GroupBy(i => i.OwnerId).Select(g => g.First());

            itemsMessage.WriteInteger(owners.Count());
            foreach (var owner in owners)
            {
                itemsMessage.WriteInteger(owner.OwnerId);
                itemsMessage.WriteString(owner.OwnerName);
            }

            itemsMessage.WriteInteger(items.Count);
            foreach (var obj in items)
            {


                itemsMessage.WriteString(obj.Id.ToString());
                itemsMessage.WriteInteger(obj.TypeId);
                itemsMessage.WriteString(obj.Location);
                itemsMessage.WriteString(obj.State);
                itemsMessage.WriteInteger(obj.SecondsToExpiration);
                itemsMessage.WriteInteger((int)obj.UsagePolicy);
                itemsMessage.WriteInteger(obj.OwnerId);
            }
            return itemsMessage;

        }
    }
}
