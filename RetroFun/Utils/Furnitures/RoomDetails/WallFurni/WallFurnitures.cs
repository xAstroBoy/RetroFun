
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroFun.Utils.Furnitures.Furni
{
    public class WallFurnitures
    {
        public static List<HWallItem> Furni = new List<HWallItem>();
        public static List<HWallItem> RemFurni = new List<HWallItem>();

        public static List<HWallItem> Snapshot_Wall_furnis_In_room = new List<HWallItem>();

        public static void UpdateWallFurniPosition(int id, string newpos)
        {
            try {
                if (Furni.Find(f => f.Id == id) != null) { Furni.Find(f => f.Id == id).Location = newpos; }
                if (RemFurni.Find(f => f.Id == id) != null) { RemFurni.Find(f => f.Id == id).Location = newpos; }
                if (Snapshot_Wall_furnis_In_room.Find(f => f.Id == id) != null) { Snapshot_Wall_furnis_In_room.Find(f => f.Id == id).Location = newpos; }
            }
            catch (Exception) { }
        }

        public static void ClearFurnis()
        {
            Furni.Clear();
            RemFurni.Clear();
            Snapshot_Wall_furnis_In_room.Clear();
        }
        public static void HandleRemovedFurni(HWallItem item)
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

        public static void UpdateWallFurniPosition(string id, string newpos)
        {
            if(int.TryParse(id, out int furniid))
            {
                UpdateWallFurniPosition(furniid, newpos);
            }
        }

        public static List<HWallItem> GetWallFurnis()
        {
            return Furni;
        }

        public static void SetSnapshotWall()
        {
            Snapshot_Wall_furnis_In_room = GetWallFurnis();
        }

        public static List<HWallItem> Getsnapshot()
        {
            SetSnapshotWall();
            return Snapshot_Wall_furnis_In_room;
        }

        public static HMessage PacketBuilder(IList<HWallItem> items, ushort header)
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

        public static List<HWallItem> BobbaParser(HMessage packet)
        {
            int ownersCount = packet.ReadInt32();
            for (int i = 0; i < ownersCount; i++)
            {
                packet.ReadInt32();
                packet.ReadUTF8();
            }

            var wallItems = new HWallItem[packet.ReadInt32()];
            for (int i = 0; i < wallItems.Length; i++)
            {
                wallItems[i] = new HWallItem(packet);
            }
            return wallItems.ToList();
        }

    }
}
