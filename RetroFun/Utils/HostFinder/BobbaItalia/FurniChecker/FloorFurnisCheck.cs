using RetroFun.Globals;
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
        public static List<GlobalLists.FurniTypeIDFixer> OriginalFurniTypeID { get => GlobalLists.furnifix; set { GlobalLists.furnifix = value;} }



        public static void updateFloorFurniPosition(int id, int x, int y, string furniz)
        {
            try
            {
                if (decimal.TryParse(furniz, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal decz))
                {
                    double z = (double)decz;
                    if (CreditsFloorFurnis.Find(f => f.Id == id) != null) { CreditsFloorFurnis.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (CrystalsFloorFurnis.Find(f => f.Id == id) != null) { CrystalsFloorFurnis.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (CatalogueFloorFurnis.Find(f => f.Id == id) != null) { CatalogueFloorFurnis.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (RaresFloorFurnis.Find(f => f.Id == id) != null) { RaresFloorFurnis.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (RegularFloorFurni.Find(f => f.Id == id) != null) { RegularFloorFurni.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (WhiteListedFloorFurni.Find(f => f.Id == id) != null) { WhiteListedFloorFurni.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (HIDDEN_IRREGULAR_FLOORFURNIS.Find(f => f.Id == id) != null) { HIDDEN_IRREGULAR_FLOORFURNIS.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (HIDDEN_REGULAR_FLOORFURNIS.Find(f => f.Id == id) != null) { HIDDEN_REGULAR_FLOORFURNIS.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (FloorRaresSnapShotCount.Find(f => f.Id == id) != null) { FloorRaresSnapShotCount.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (RoomFloorItemsSnapshot.Find(f => f.Id == id) != null) { RoomFloorItemsSnapshot.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (SnapShotIrregularFloorFurni.Find(f => f.Id == id) != null) { SnapShotIrregularFloorFurni.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (SnapshotRegularFloorItems.Find(f => f.Id == id) != null) { SnapshotRegularFloorItems.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (SnapshotRemovedFloorItems.Find(f => f.Id == id) != null) { SnapshotRemovedFloorItems.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (SnapshotCatalogueFloorItems.Find(f => f.Id == id) != null) { SnapshotCatalogueFloorItems.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (UnknownFloorItems.Find(f => f.Id == id) != null) { UnknownFloorItems.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (SnapshotCreditsFloorFurnis.Find(f => f.Id == id) != null) { SnapshotCreditsFloorFurnis.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (SnapshotCrystalsFloorFurnis.Find(f => f.Id == id) != null) { SnapshotCrystalsFloorFurnis.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (RemovedIrregularFloorFurnis.Find(f => f.Id == id) != null) { RemovedIrregularFloorFurnis.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (RemovedRegularFloorFurnis.Find(f => f.Id == id) != null) { RemovedRegularFloorFurnis.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (SnapshotRemovedIrregularFloorFurnis.Find(f => f.Id == id) != null) { SnapshotRemovedIrregularFloorFurnis.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (SnapshotRemovedRegularFloorFurnis.Find(f => f.Id == id) != null) { SnapshotRemovedRegularFloorFurnis.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if(OriginalFurniTypeID.Find(f => f.FloorFurni.Id == id).FloorFurni != null) { _ = OriginalFurniTypeID.Find(f => f.FloorFurni.Id == id).Z == z; }
                }
            }
            catch (Exception) { }
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
            try
            {
                if (CreditsFloorFurnis.Find(f => f.Id == id) != null) { CreditsFloorFurnis.Find(f => f.Id == id).Facing = direction; }
                if (CrystalsFloorFurnis.Find(f => f.Id == id) != null) { CrystalsFloorFurnis.Find(f => f.Id == id).Facing = direction; }
                if (CatalogueFloorFurnis.Find(f => f.Id == id) != null) { CatalogueFloorFurnis.Find(f => f.Id == id).Facing = direction; }
                if (RaresFloorFurnis.Find(f => f.Id == id) != null) { RaresFloorFurnis.Find(f => f.Id == id).Facing = direction; }
                if (RegularFloorFurni.Find(f => f.Id == id) != null) { RegularFloorFurni.Find(f => f.Id == id).Facing = direction; }
                if (WhiteListedFloorFurni.Find(f => f.Id == id) != null) { WhiteListedFloorFurni.Find(f => f.Id == id).Facing = direction; }
                if (HIDDEN_IRREGULAR_FLOORFURNIS.Find(f => f.Id == id) != null) { HIDDEN_IRREGULAR_FLOORFURNIS.Find(f => f.Id == id).Facing = direction; }
                if (HIDDEN_REGULAR_FLOORFURNIS.Find(f => f.Id == id) != null) { HIDDEN_REGULAR_FLOORFURNIS.Find(f => f.Id == id).Facing = direction; }
                if (FloorRaresSnapShotCount.Find(f => f.Id == id) != null) { FloorRaresSnapShotCount.Find(f => f.Id == id).Facing = direction; }
                if (RoomFloorItemsSnapshot.Find(f => f.Id == id) != null) { RoomFloorItemsSnapshot.Find(f => f.Id == id).Facing = direction; }
                if (SnapShotIrregularFloorFurni.Find(f => f.Id == id) != null) { SnapShotIrregularFloorFurni.Find(f => f.Id == id).Facing = direction; }
                if (SnapshotRegularFloorItems.Find(f => f.Id == id) != null) { SnapshotRegularFloorItems.Find(f => f.Id == id).Facing = direction; }
                if (SnapshotRemovedFloorItems.Find(f => f.Id == id) != null) { SnapshotRemovedFloorItems.Find(f => f.Id == id).Facing = direction; }
                if (SnapshotCatalogueFloorItems.Find(f => f.Id == id) != null) { SnapshotCatalogueFloorItems.Find(f => f.Id == id).Facing = direction; }
                if (UnknownFloorItems.Find(f => f.Id == id) != null) { UnknownFloorItems.Find(f => f.Id == id).Facing = direction; }
                if (SnapshotCreditsFloorFurnis.Find(f => f.Id == id) != null) { SnapshotCreditsFloorFurnis.Find(f => f.Id == id).Facing = direction; }
                if (SnapshotCrystalsFloorFurnis.Find(f => f.Id == id) != null) { SnapshotCrystalsFloorFurnis.Find(f => f.Id == id).Facing = direction; }
                if (RemovedIrregularFloorFurnis.Find(f => f.Id == id) != null) { RemovedIrregularFloorFurnis.Find(f => f.Id == id).Facing = direction; }
                if (RemovedRegularFloorFurnis.Find(f => f.Id == id) != null) { RemovedRegularFloorFurnis.Find(f => f.Id == id).Facing = direction; }
                if (SnapshotRemovedIrregularFloorFurnis.Find(f => f.Id == id) != null) { SnapshotRemovedIrregularFloorFurnis.Find(f => f.Id == id).Facing = direction; }
                if (SnapshotRemovedRegularFloorFurnis.Find(f => f.Id == id) != null) { SnapshotRemovedRegularFloorFurnis.Find(f => f.Id == id).Facing = direction; }
            }
            catch (Exception) { }

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
            if (IrregularFloorFurni.Contains(item)) { IrregularFloorFurni.Remove(item); if (!RemovedIrregularFloorFurnis.Contains(item)) { RemovedIrregularFloorFurnis.Add(item); } }
            if (RegularFloorFurni.Contains(item)) { RegularFloorFurni.Remove(item); if (!RemovedRegularFloorFurnis.Contains(item)) { RemovedRegularFloorFurnis.Add(item); } }
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

