using RetroFun.Globals;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geode.Habbo;
using Geode.Habbo.Packages;

namespace RetroFun.Utils.HostFinder.BobbaItalia
{
    public class FloorFurniCheck
    {
        public static List<HFloorObject> IrregularFloorFurni = new List<HFloorObject>();
        public static List<HFloorObject> CreditsFloorFurnis = new List<HFloorObject>();
        public static List<HFloorObject> CrystalsFloorFurnis = new List<HFloorObject>();
        public static List<HFloorObject> CatalogueFloorFurnis = new List<HFloorObject>();
        public static List<HFloorObject> RaresFloorFurnis = new List<HFloorObject>();
        public static List<HFloorObject> RegularFloorFurni = new List<HFloorObject>();
        public static List<HFloorObject> WhiteListedFloorFurni = new List<HFloorObject>();
        public static List<HFloorObject> HIDDEN_IRREGULAR_FLOORFURNIS = new List<HFloorObject>();
        public static List<HFloorObject> HIDDEN_REGULAR_FLOORFURNIS = new List<HFloorObject>();
        public static List<HFloorObject> FloorRaresSnapShotCount = new List<HFloorObject>();
        public static List<HFloorObject> RoomHFloorObjectsSnapshot = new List<HFloorObject>();
        public static List<HFloorObject> SnapShotIrregularFloorFurni = new List<HFloorObject>();
        public static List<HFloorObject> SnapshotRegularHFloorObjects = new List<HFloorObject>();
        public static List<HFloorObject> SnapshotRemovedHFloorObjects = new List<HFloorObject>();
        public static List<HFloorObject> SnapshotCatalogueHFloorObjects = new List<HFloorObject>();
        public static List<HFloorObject> UnknownHFloorObjects = new List<HFloorObject>();
        public static List<HFloorObject> SnapshotCreditsFloorFurnis = new List<HFloorObject>();
        public static List<HFloorObject> SnapshotCrystalsFloorFurnis = new List<HFloorObject>();
        public static List<HFloorObject> RemovedIrregularFloorFurnis = new List<HFloorObject>();
        public static List<HFloorObject> RemovedRegularFloorFurnis = new List<HFloorObject>();
        public static List<HFloorObject> SnapshotRemovedIrregularFloorFurnis = new List<HFloorObject>();
        public static List<HFloorObject> SnapshotRemovedRegularFloorFurnis = new List<HFloorObject>();
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
                    if (RoomHFloorObjectsSnapshot.Find(f => f.Id == id) != null) { RoomHFloorObjectsSnapshot.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (SnapShotIrregularFloorFurni.Find(f => f.Id == id) != null) { SnapShotIrregularFloorFurni.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (SnapshotRegularHFloorObjects.Find(f => f.Id == id) != null) { SnapshotRegularHFloorObjects.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (SnapshotRemovedHFloorObjects.Find(f => f.Id == id) != null) { SnapshotRemovedHFloorObjects.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (SnapshotCatalogueHFloorObjects.Find(f => f.Id == id) != null) { SnapshotCatalogueHFloorObjects.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
                    if (UnknownHFloorObjects.Find(f => f.Id == id) != null) { UnknownHFloorObjects.Find(f => f.Id == id).Tile = new HPoint(x, y, z); }
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
                if (RoomHFloorObjectsSnapshot.Find(f => f.Id == id) != null) { RoomHFloorObjectsSnapshot.Find(f => f.Id == id).Facing = direction; }
                if (SnapShotIrregularFloorFurni.Find(f => f.Id == id) != null) { SnapShotIrregularFloorFurni.Find(f => f.Id == id).Facing = direction; }
                if (SnapshotRegularHFloorObjects.Find(f => f.Id == id) != null) { SnapshotRegularHFloorObjects.Find(f => f.Id == id).Facing = direction; }
                if (SnapshotRemovedHFloorObjects.Find(f => f.Id == id) != null) { SnapshotRemovedHFloorObjects.Find(f => f.Id == id).Facing = direction; }
                if (SnapshotCatalogueHFloorObjects.Find(f => f.Id == id) != null) { SnapshotCatalogueHFloorObjects.Find(f => f.Id == id).Facing = direction; }
                if (UnknownHFloorObjects.Find(f => f.Id == id) != null) { UnknownHFloorObjects.Find(f => f.Id == id).Facing = direction; }
                if (SnapshotCreditsFloorFurnis.Find(f => f.Id == id) != null) { SnapshotCreditsFloorFurnis.Find(f => f.Id == id).Facing = direction; }
                if (SnapshotCrystalsFloorFurnis.Find(f => f.Id == id) != null) { SnapshotCrystalsFloorFurnis.Find(f => f.Id == id).Facing = direction; }
                if (RemovedIrregularFloorFurnis.Find(f => f.Id == id) != null) { RemovedIrregularFloorFurnis.Find(f => f.Id == id).Facing = direction; }
                if (RemovedRegularFloorFurnis.Find(f => f.Id == id) != null) { RemovedRegularFloorFurnis.Find(f => f.Id == id).Facing = direction; }
                if (SnapshotRemovedIrregularFloorFurnis.Find(f => f.Id == id) != null) { SnapshotRemovedIrregularFloorFurnis.Find(f => f.Id == id).Facing = direction; }
                if (SnapshotRemovedRegularFloorFurnis.Find(f => f.Id == id) != null) { SnapshotRemovedRegularFloorFurnis.Find(f => f.Id == id).Facing = direction; }
            }
            catch (Exception) { }

        }

        public static void HandleAddedFurni(HFloorObject item)
        {
            if(SnapshotRemovedHFloorObjects.Contains(item))
            {
                SnapshotRemovedHFloorObjects.Remove(item);
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

        public static void HandleRemovedFurni(HFloorObject item)
        {
            if (IrregularFloorFurni.Contains(item)) { IrregularFloorFurni.Remove(item); if (!RemovedIrregularFloorFurnis.Contains(item)) { RemovedIrregularFloorFurnis.Add(item); } }
            if (RegularFloorFurni.Contains(item)) { RegularFloorFurni.Remove(item); if (!RemovedRegularFloorFurnis.Contains(item)) { RemovedRegularFloorFurnis.Add(item); } }
            if (WhiteListedFloorFurni.Contains(item)) { WhiteListedFloorFurni.Remove(item); }
            if (HIDDEN_IRREGULAR_FLOORFURNIS.Contains(item)) { HIDDEN_IRREGULAR_FLOORFURNIS.Remove(item); }
            if (HIDDEN_REGULAR_FLOORFURNIS.Contains(item)) { HIDDEN_REGULAR_FLOORFURNIS.Remove(item); }
            if (FloorRaresSnapShotCount.Contains(item)) { FloorRaresSnapShotCount.Remove(item); }
            if (SnapshotRegularHFloorObjects.Contains(item)) { SnapshotRegularHFloorObjects.Remove(item); }
            if (SnapShotIrregularFloorFurni.Contains(item)) { SnapShotIrregularFloorFurni.Remove(item); }
            if (CreditsFloorFurnis.Contains(item)) { CreditsFloorFurnis.Remove(item); }
            if (CrystalsFloorFurnis.Contains(item)) { CrystalsFloorFurnis.Remove(item); }
            if (CatalogueFloorFurnis.Contains(item)) { CatalogueFloorFurnis.Remove(item); }
            if (RaresFloorFurnis.Contains(item)) { RaresFloorFurnis.Remove(item); }
            if (RoomHFloorObjectsSnapshot.Contains(item)) { RoomHFloorObjectsSnapshot.Remove(item); }
            if (SnapshotCatalogueHFloorObjects.Contains(item)) { SnapshotCatalogueHFloorObjects.Remove(item); }
            if (SnapshotCreditsFloorFurnis.Contains(item)) { SnapshotCreditsFloorFurnis.Remove(item); }
            if (SnapshotCrystalsFloorFurnis.Contains(item)) { SnapshotCrystalsFloorFurnis.Remove(item); }
            if (UnknownHFloorObjects.Contains(item)) { UnknownHFloorObjects.Remove(item); }
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
            RoomHFloorObjectsSnapshot.Clear();
            SnapShotIrregularFloorFurni.Clear();
            SnapshotRegularHFloorObjects.Clear();
            SnapshotRemovedHFloorObjects.Clear();
            SnapshotCatalogueHFloorObjects.Clear();
            UnknownHFloorObjects.Clear();
            SnapshotCreditsFloorFurnis.Clear();
            SnapshotCrystalsFloorFurnis.Clear();
            RemovedIrregularFloorFurnis.Clear();
            RemovedRegularFloorFurnis.Clear();
            SnapshotRemovedIrregularFloorFurnis.Clear();
            SnapshotRemovedRegularFloorFurnis.Clear();
        }
    }
}

