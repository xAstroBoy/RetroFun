using Sulakore.Habbo;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroFun.Utils.HostFinder.BobbaItalia
{
    public class FloorFurniCheck
    {
        public static List<HFloorItem> IrregularFloorFurni = new List<HFloorItem>();
        public static List<HFloorItem> CreditsFloorFurnis = new List<HFloorItem>();
        public static List<HFloorItem> CrystalsFloorFurnis = new List<HFloorItem>();
        public static List<HFloorItem> CatalogueFloorFurnis = new List<HFloorItem>();
        public static List<HFloorItem> RaresFloorFurnis = new List<HFloorItem>();
        public static List<HFloorItem> RegularFloorFurni = new List<HFloorItem>();
        public static List<HFloorItem> WhiteListedFloorFurni = new List<HFloorItem>();
        public static List<HFloorItem> HIDDEN_IRREGULAR_FLOORFURNIS = new List<HFloorItem>();
        public static List<HFloorItem> HIDDEN_REGULAR_FLOORFURNIS = new List<HFloorItem>();
        public static List<HFloorItem> FloorRaresSnapShotCount = new List<HFloorItem>();
        public static List<HFloorItem> RoomFloorItemsSnapshot = new List<HFloorItem>();
        public static List<HFloorItem> SnapShotIrregularFloorFurni = new List<HFloorItem>();
        public static List<HFloorItem> SnapshotRegularFloorItems = new List<HFloorItem>();
        public static List<HFloorItem> SnapshotRemovedFloorItems = new List<HFloorItem>();
        public static List<HFloorItem> SnapshotCatalogueFloorItems = new List<HFloorItem>();
        public static List<HFloorItem> UnknownFloorItems = new List<HFloorItem>();
        public static List<HFloorItem> SnapshotCreditsFloorFurnis = new List<HFloorItem>();
        public static List<HFloorItem> SnapshotCrystalsFloorFurnis = new List<HFloorItem>();
        public static List<HFloorItem> RemovedIrregularFloorFurnis = new List<HFloorItem>();
        public static List<HFloorItem> RemovedRegularFloorFurnis = new List<HFloorItem>();
        public static List<HFloorItem> SnapshotRemovedIrregularFloorFurnis = new List<HFloorItem>();
        public static List<HFloorItem> SnapshotRemovedRegularFloorFurnis = new List<HFloorItem>();



        public static void updateFloorFurniPosition(int id, int x, int y, string furniz)
        {
            if (decimal.TryParse(furniz, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal decz))
            {
                double z = (double)decz;
                IrregularFloorFurni.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                CreditsFloorFurnis.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                CrystalsFloorFurnis.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                CatalogueFloorFurnis.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                RaresFloorFurnis.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                RegularFloorFurni.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                WhiteListedFloorFurni.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                HIDDEN_IRREGULAR_FLOORFURNIS.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                HIDDEN_REGULAR_FLOORFURNIS.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                FloorRaresSnapShotCount.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                RoomFloorItemsSnapshot.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                SnapShotIrregularFloorFurni.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                SnapshotRegularFloorItems.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                SnapshotRemovedFloorItems.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                SnapshotCatalogueFloorItems.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                UnknownFloorItems.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                SnapshotCreditsFloorFurnis.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                SnapshotCrystalsFloorFurnis.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                RemovedIrregularFloorFurnis.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                RemovedRegularFloorFurnis.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                SnapshotRemovedIrregularFloorFurnis.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
                SnapshotRemovedRegularFloorFurnis.Find(f => f.Id == id).Tile = new HPoint(x, y, z);
            }
        }

        public static void UpdateFloorFurniFacing(int id, int facing)
        {
            if(facing == 0)
            {
                UpdateFurniFacing(id, HDirection.North);
            }
            else if(facing == 1)
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
            IrregularFloorFurni.Find(f => f.Id == id).Facing = direction;
            CreditsFloorFurnis.Find(f => f.Id == id).Facing = direction;
            CrystalsFloorFurnis.Find(f => f.Id == id).Facing = direction;
            CatalogueFloorFurnis.Find(f => f.Id == id).Facing = direction;
            RaresFloorFurnis.Find(f => f.Id == id).Facing = direction;
            RegularFloorFurni.Find(f => f.Id == id).Facing = direction;
            WhiteListedFloorFurni.Find(f => f.Id == id).Facing = direction;
            HIDDEN_IRREGULAR_FLOORFURNIS.Find(f => f.Id == id).Facing = direction;
            HIDDEN_REGULAR_FLOORFURNIS.Find(f => f.Id == id).Facing = direction;
            FloorRaresSnapShotCount.Find(f => f.Id == id).Facing = direction;
            RoomFloorItemsSnapshot.Find(f => f.Id == id).Facing = direction;
            SnapShotIrregularFloorFurni.Find(f => f.Id == id).Facing = direction;
            SnapshotRegularFloorItems.Find(f => f.Id == id).Facing = direction;
            SnapshotRemovedFloorItems.Find(f => f.Id == id).Facing = direction;
            SnapshotCatalogueFloorItems.Find(f => f.Id == id).Facing = direction;
            UnknownFloorItems.Find(f => f.Id == id).Facing = direction;
            SnapshotCreditsFloorFurnis.Find(f => f.Id == id).Facing = direction;
            SnapshotCrystalsFloorFurnis.Find(f => f.Id == id).Facing = direction;
            RemovedIrregularFloorFurnis.Find(f => f.Id == id).Facing = direction;
            RemovedRegularFloorFurnis.Find(f => f.Id == id).Facing = direction;
            SnapshotRemovedIrregularFloorFurnis.Find(f => f.Id == id).Facing = direction;
            SnapshotRemovedRegularFloorFurnis.Find(f => f.Id == id).Facing = direction;
        }




        public static void HandleAddedFurni(HFloorItem item)
        {
            if(SnapshotRemovedFloorItems.Contains(item))
            {
                SnapshotRemovedFloorItems.Remove(item);
            }
            if (RemovedIrregularFloorFurnis.Contains(item))
            {
                RemovedIrregularFloorFurnis.Remove(item);
            }
            if (RemovedRegularFloorFurnis.Contains(item))
            {
                RemovedRegularFloorFurnis.Remove(item);
            }
            if (SnapshotRemovedIrregularFloorFurnis.Contains(item))
            {
                SnapshotRemovedIrregularFloorFurnis.Remove(item);
            }
            if (SnapshotRemovedRegularFloorFurnis.Contains(item))
            {
                SnapshotRemovedRegularFloorFurnis.Remove(item);
            }
        }

        public static void HandleRemovedFurni(HFloorItem item)
        {
            if (IrregularFloorFurni.Contains(item)) if (!RemovedIrregularFloorFurnis.Contains(item)) RemovedIrregularFloorFurnis.Add(item);
            if (RegularFloorFurni.Contains(item)) if (!RemovedRegularFloorFurnis.Contains(item)) RemovedRegularFloorFurnis.Add(item);
            if (WhiteListedFloorFurni.Contains(item)) { WhiteListedFloorFurni.Remove(item); }
            if (HIDDEN_IRREGULAR_FLOORFURNIS.Contains(item)) { HIDDEN_IRREGULAR_FLOORFURNIS.Remove(item); }
            if (HIDDEN_REGULAR_FLOORFURNIS.Contains(item)) { HIDDEN_REGULAR_FLOORFURNIS.Remove(item); }
            if (FloorRaresSnapShotCount.Contains(item)) { FloorRaresSnapShotCount.Remove(item); }
            if (SnapshotRegularFloorItems.Contains(item)) { SnapshotRegularFloorItems.Remove(item); }
            if (SnapShotIrregularFloorFurni.Contains(item)) { SnapShotIrregularFloorFurni.Remove(item); }
            if (CreditsFloorFurnis.Contains(item)) { CreditsFloorFurnis.Remove(item); }
            if (CrystalsFloorFurnis.Contains(item)) { CrystalsFloorFurnis.Remove(item); }
            if (CatalogueFloorFurnis.Contains(item)) { CatalogueFloorFurnis.Remove(item); }
            if (RaresFloorFurnis.Contains(item)) { RaresFloorFurnis.Remove(item); }
            if (RoomFloorItemsSnapshot.Contains(item)) { RoomFloorItemsSnapshot.Remove(item); }
            if (SnapshotCatalogueFloorItems.Contains(item)) { SnapshotCatalogueFloorItems.Remove(item); }
            if (SnapshotCreditsFloorFurnis.Contains(item)) { SnapshotCreditsFloorFurnis.Remove(item); }
            if (SnapshotCrystalsFloorFurnis.Contains(item)) { SnapshotCrystalsFloorFurnis.Remove(item); }
            if (UnknownFloorItems.Contains(item)) { UnknownFloorItems.Remove(item); }
        }

        public static void ClearAll()
        {
            IrregularFloorFurni.Clear();
            CreditsFloorFurnis.Clear();
            CrystalsFloorFurnis.Clear();
            CatalogueFloorFurnis.Clear();
            RaresFloorFurnis.Clear();
            RegularFloorFurni.Clear();
            WhiteListedFloorFurni.Clear();
            HIDDEN_IRREGULAR_FLOORFURNIS.Clear();
            HIDDEN_REGULAR_FLOORFURNIS.Clear();
            FloorRaresSnapShotCount.Clear();
            RoomFloorItemsSnapshot.Clear();
            SnapShotIrregularFloorFurni.Clear();
            SnapshotRegularFloorItems.Clear();
            SnapshotRemovedFloorItems.Clear();
            SnapshotCatalogueFloorItems.Clear();
            UnknownFloorItems.Clear();
            SnapshotCreditsFloorFurnis.Clear();
            SnapshotCrystalsFloorFurnis.Clear();
            RemovedIrregularFloorFurnis.Clear();
            RemovedRegularFloorFurnis.Clear();
            SnapshotRemovedIrregularFloorFurnis.Clear();
            SnapshotRemovedRegularFloorFurnis.Clear();
        }
    }
}

